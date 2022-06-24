using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;


namespace Elgin.Bridge.Interop
{
    /// <inheritdoc cref="SafeHandle" />
    public abstract class ElginSafeHandle : SafeHandle
    {
        #region InnerTypes

        private class LibLoader
        {
            #region InnerTypes

            private static class Windows
            {
                [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
                public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);

                [DllImport("kernel32", CharSet = CharSet.Unicode, SetLastError = true)]
                public static extern IntPtr LoadLibraryW(string lpszLib);

                [DllImport("kernel32", SetLastError = true)]
                public static extern bool FreeLibrary(IntPtr hModule);
            }

            private static class Linux
            {
                [DllImport("libdl.so.2")]
                public static extern IntPtr dlopen(string path, int flags);

                [DllImport("libdl.so.2")]
                public static extern IntPtr dlsym(IntPtr handle, string symbol);

                [DllImport("libdl.so.2")]
                public static extern int dlclose(IntPtr handle);
            }

            private static class OSX
            {
                [DllImport("/usr/lib/libSystem.dylib")]
                public static extern IntPtr dlopen(string path, int flags);

                [DllImport("/usr/lib/libSystem.dylib")]
                public static extern IntPtr dlsym(IntPtr handle, string symbol);

                [DllImport("/usr/lib/libSystem.dylib")]
                public static extern int dlclose(IntPtr handle);
            }

            #endregion InnerTypes

            #region Exports

            [DllImport("libc")]
            private static extern int uname(IntPtr buf);

            #endregion Exports

            #region Constructors

            static LibLoader()
            {
                switch (Environment.OSVersion.Platform)
                {
                    case PlatformID.Win32S:
                    case PlatformID.Win32Windows:
                    case PlatformID.Win32NT:
                    case PlatformID.WinCE:
                        IsWindows = true;
                        break;

                    case PlatformID.Unix:
                        try
                        {
                            var num = Marshal.AllocHGlobal(8192);
                            if (uname(num) == 0 && Marshal.PtrToStringAnsi(num) == "Darwin")
                                IsOSX = true;

                            Marshal.FreeHGlobal(num);
                            break;
                        }
                        catch
                        {
                            break;
                        }

                    case PlatformID.MacOSX:
                        IsOSX = true;
                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            #endregion Constructors

            #region Properties

            public static readonly bool IsWindows;

            public static readonly bool IsOSX;

            #endregion Properties

            #region Methods

            public static IntPtr LoadLibrary(string libname)
            {
                if (IsWindows) return Windows.LoadLibraryW(libname);
                return IsOSX ? OSX.dlopen(libname, 1) : Linux.dlopen(libname, 1);
            }

            public static bool FreeLibrary(IntPtr library)
            {
                if (IsWindows) return Windows.FreeLibrary(library);
                return (IsOSX ? OSX.dlclose(library) : Linux.dlclose(library)) == 0;
            }

            public static IntPtr GetProcAddress(IntPtr library, string function)
            {
                var num = !IsWindows ? !IsOSX ? Linux.dlsym(library, function) : OSX.dlsym(library, function) :
                                       Windows.GetProcAddress(library, function);
                return num;
            }

            public static T LoadFunction<T>(IntPtr procaddress) where T : Delegate
            {
                if (procaddress == IntPtr.Zero || procaddress == MinusOne) return null;
                var functionPointer = Marshal.GetDelegateForFunctionPointer(procaddress, typeof(T));

                return functionPointer as T;
            }

            #endregion Methods
        }

        #endregion InnerTypes

        #region Fields

        protected readonly Dictionary<Type, string> methodList;
        protected readonly Dictionary<string, Delegate> methodCache;
        protected readonly string className;

        #endregion Fields

        #region Constructors

        static ElginSafeHandle() => MinusOne = new IntPtr(-1);

        /// <inheritdoc />
        protected ElginSafeHandle(string dllPath) : base(IsWindows ? IntPtr.Zero : MinusOne, true)
        {
            methodList = new Dictionary<Type, string>();
            methodCache = new Dictionary<string, Delegate>();
            className = GetType().Name;

            var pNewSession = LibLoader.LoadLibrary(dllPath);
            SetHandle(pNewSession);
            if (IsInvalid) throw new Exception("Não foi possivel carregar a biblioteca.");
        }

        #endregion Constructors

        #region Properties

        private static IntPtr MinusOne { get; }

        /// <summary>
        /// Retornar o valor de um handler invalido.
        /// </summary>
        protected IntPtr InvalidHandler => IsWindows ? IntPtr.Zero : MinusOne;

        /// <inheritdoc />
        public override sealed bool IsInvalid => InvalidHandler == handle;

        public static bool IsWindows => LibLoader.IsWindows;

        public static bool IsOSX => LibLoader.IsOSX;

        public static bool IsLinux => !LibLoader.IsOSX && LibLoader.IsWindows;

        #endregion Properties

        #region Methods

        /// <inheritdoc />
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        protected override bool ReleaseHandle()

        {
            if (IsInvalid) return true;

            var ret = LibLoader.FreeLibrary(handle);

            if (ret)
                SetHandleAsInvalid();

            return ret;
        }

        /// <summary>
        /// Adiciona um delegate a lista para a função informada.
        /// </summary>
        /// <param name="functionName">Nome da função para exportar</param>
        /// <typeparam name="T">Delegate da função</typeparam>
        protected virtual void AddMethod<T>(string functionName) where T : Delegate
        {
            methodList.Add(typeof(T), functionName);
        }

        /// <summary>
        /// Retorna o delegate para uso.
        ///  </summary>
        /// <typeparam name="T">Delegate</typeparam>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        protected virtual T GetMethod<T>() where T : Delegate
        {
            if (!methodList.ContainsKey(typeof(T))) throw new Exception($"Função não adicionada para o [{nameof(T)}].");

            var method = methodList[typeof(T)];
            if (methodCache.ContainsKey(method)) return methodCache[method] as T;

            var mHandler = LibLoader.GetProcAddress(handle, method);

            if (mHandler == IntPtr.Zero || mHandler == MinusOne) throw new ArgumentNullException("Função não encontrada: " + method);

            var methodHandler = LibLoader.LoadFunction<T>(mHandler);
            methodCache.Add(method, methodHandler);
            return methodHandler;
        }

        /// <summary>
        /// Executa a função e trata erros nativos.
        /// </summary>
        /// <param name="method"></param>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        [HandleProcessCorruptedStateExceptions]
        protected virtual T ExecuteMethod<T>(Func<T> method)
        {
            return method();
        }

        /// <summary>
        /// Executa a função e trata erros nativos.
        /// </summary>
        /// <param name="method"></param>
        /// <exception cref="OpenException"></exception>
        [HandleProcessCorruptedStateExceptions]
        protected virtual void ExecuteMethod(Action method)
        {
            method();
        }

        #endregion Methods
    }
}
using System;
using System.Runtime.InteropServices;


namespace Elgin.Bridge.Interop
{
    public sealed class ElginLPStr : ICustomMarshaler
    {
        #region Fields

        private static ElginLPStr marshaler;

        #endregion Fields

        #region Methods

        public static ICustomMarshaler GetInstance(string cookie)
        {
            return marshaler ?? (marshaler = new ElginLPStr());
        }

        /// <inheritdoc />
        public object MarshalNativeToManaged(IntPtr pNativeData)
        {
            return Marshal.PtrToStringAnsi(pNativeData);
        }

        /// <inheritdoc />
        public void CleanUpNativeData(IntPtr pNativeData)
        {
        }

        /// <inheritdoc />
        public IntPtr MarshalManagedToNative(object ManagedObj)
        {
            return IntPtr.Zero;
        }

        /// <inheritdoc />
        public void CleanUpManagedData(object ManagedObj)
        {
        }

        /// <inheritdoc />
        public int GetNativeDataSize()
        {
            return IntPtr.Size;
        }

        #endregion Methods
    }
}
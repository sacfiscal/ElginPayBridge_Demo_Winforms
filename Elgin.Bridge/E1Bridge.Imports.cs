using System;
using Elgin.Bridge.Interop;
using System.Runtime.InteropServices;

namespace Elgin.Bridge
{
    public sealed partial class E1Bridge
    {
        public class CdeclImports
        {
            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string ConsultarStatus();

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string ConsultarUltimaTransacao([MarshalAs(UnmanagedType.LPStr)] string pdv);


            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string GetServer();

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string SetServer([MarshalAs(UnmanagedType.LPStr)] string ipTerminal, int portaTransacao, int portaStatus);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string GetTimeout();

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string SetTimeout(int timeOut);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string IniciaVenda(int idTransacao, 
                [MarshalAs(UnmanagedType.LPStr)] string pdv, 
                [MarshalAs(UnmanagedType.LPStr)] string valorTotal);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string IniciaVendaDebito(int idTransacao, 
                [MarshalAs(UnmanagedType.LPStr)] string pdv,
                [MarshalAs(UnmanagedType.LPStr)] string valorTotal);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string IniciaVendaCredito(int idTransacao, string pdv, 
                [MarshalAs(UnmanagedType.LPStr)] string valorTotal, 
                int tipoFinanciamento,
                int numParcelas);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string IniciaCancelamentoVenda(int idTransacao, string pdv,
                [MarshalAs(UnmanagedType.LPStr)] string valorTotal,
                [MarshalAs(UnmanagedType.LPStr)] string dataHora,
                [MarshalAs(UnmanagedType.LPStr)] string nsu);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string IniciaOperacaoAdministrativa(int idTransacao,
                [MarshalAs(UnmanagedType.LPStr)] string pdv, 
                int operacao);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string ImprimirCupomSat([MarshalAs(UnmanagedType.LPStr)] string xml);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string ImprimirCupomSatCancelamento([MarshalAs(UnmanagedType.LPStr)] string xml, 
                [MarshalAs(UnmanagedType.LPStr)] string qRCode);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string ImprimirCupomNfce([MarshalAs(UnmanagedType.LPStr)] string xml,
                int indexcsc, 
                [MarshalAs(UnmanagedType.LPStr)] string csc);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string SetSenha([MarshalAs(UnmanagedType.LPStr)] string senha, 
                bool habilitada);

            [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string SetSenhaServer([MarshalAs(UnmanagedType.LPStr)] string senha,
                bool habilitada);
        }

        public class StdCallImports
        {
            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string ConsultarStatus();

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string ConsultarUltimaTransacao([MarshalAs(UnmanagedType.LPStr)] string pdv);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string GetServer();

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string SetServer([MarshalAs(UnmanagedType.LPStr)] string ipTerminal, int portaTransacao, int portaStatus);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string GetTimeout();

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string SetTimeout(int timeOut);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string IniciaVenda(int idTransacao,
                [MarshalAs(UnmanagedType.LPStr)] string pdv,
                [MarshalAs(UnmanagedType.LPStr)] string valorTotal);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string IniciaVendaDebito(int idTransacao,
                [MarshalAs(UnmanagedType.LPStr)] string pdv,
                [MarshalAs(UnmanagedType.LPStr)] string valorTotal);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string IniciaVendaCredito(int idTransacao, string pdv,
                [MarshalAs(UnmanagedType.LPStr)] string valorTotal,
                int tipoFinanciamento,
                int numParcelas);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string IniciaCancelamentoVenda(int idTransacao, string pdv,
                [MarshalAs(UnmanagedType.LPStr)] string valorTotal,
                [MarshalAs(UnmanagedType.LPStr)] string dataHora,
                [MarshalAs(UnmanagedType.LPStr)] string nsu);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string IniciaOperacaoAdministrativa(int idTransacao,
                [MarshalAs(UnmanagedType.LPStr)] string pdv,
                int operacao);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string ImprimirCupomSat([MarshalAs(UnmanagedType.LPStr)] string xml);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string ImprimirCupomSatCancelamento(
                [MarshalAs(UnmanagedType.LPStr)] string xml,
                [MarshalAs(UnmanagedType.LPStr)] string qRCode);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string ImprimirCupomNfce([MarshalAs(UnmanagedType.LPStr)] string xml,
                int indexcsc,
                [MarshalAs(UnmanagedType.LPStr)] string csc);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string SetSenha([MarshalAs(UnmanagedType.LPStr)] string senha,
                bool habilitada);

            [UnmanagedFunctionPointer(CallingConvention.StdCall)]
            [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ElginLPStr))]
            public delegate string SetSenhaServer([MarshalAs(UnmanagedType.LPStr)] string senha,
                bool habilitada);
        }

        #region Methods

        private void InitializeMethods()
        {
            if (IsWindows)
            {
                AddMethod<StdCallImports.ConsultarStatus>("ConsultarStatus");
                AddMethod<StdCallImports.ConsultarUltimaTransacao>("ConsultarUltimaTransacao");
                AddMethod<StdCallImports.GetServer>("GetServer");
                AddMethod<StdCallImports.SetServer>("SetServer");
                AddMethod<StdCallImports.GetTimeout>("GetTimeout");
                AddMethod<StdCallImports.SetTimeout>("GetTimeout");
                AddMethod<StdCallImports.IniciaVenda>("IniciaVenda");
                AddMethod<StdCallImports.IniciaVendaDebito>("IniciaVendaDebito");
                AddMethod<StdCallImports.IniciaVendaCredito>("IniciaVendaCredito");
                AddMethod<StdCallImports.IniciaCancelamentoVenda>("IniciaCancelamentoVenda");
                AddMethod<StdCallImports.IniciaOperacaoAdministrativa>("IniciaOperacaoAdministrativa");
                AddMethod<StdCallImports.ImprimirCupomSat>("ImprimirCupomSat");
                AddMethod<StdCallImports.ImprimirCupomSatCancelamento>("ImprimirCupomSatCancelamento");
                AddMethod<StdCallImports.ImprimirCupomNfce>("ImprimirCupomNfce");
                AddMethod<StdCallImports.SetSenha>("SetSenha");
                AddMethod<StdCallImports.SetSenhaServer>("SetSenhaServer");
            }
            else
            {
                AddMethod<CdeclImports.ConsultarStatus>("ConsultarStatus");
                AddMethod<CdeclImports.ConsultarUltimaTransacao>("ConsultarUltimaTransacao");
                AddMethod<CdeclImports.GetServer>("GetServer");
                AddMethod<CdeclImports.SetServer>("SetServer");
                AddMethod<StdCallImports.GetTimeout>("GetTimeout");
                AddMethod<StdCallImports.SetTimeout>("GetTimeout");
                AddMethod<CdeclImports.IniciaVenda>("IniciaVenda");
                AddMethod<CdeclImports.IniciaVendaDebito>("IniciaVendaDebito");
                AddMethod<CdeclImports.IniciaVendaCredito>("IniciaVendaCredito");
                AddMethod<CdeclImports.IniciaCancelamentoVenda>("IniciaCancelamentoVenda");
                AddMethod<CdeclImports.IniciaOperacaoAdministrativa>("IniciaOperacaoAdministrativa");
                AddMethod<CdeclImports.ImprimirCupomSat>("ImprimirCupomSat");
                AddMethod<CdeclImports.ImprimirCupomSatCancelamento>("ImprimirCupomSatCancelamento");
                AddMethod<CdeclImports.ImprimirCupomNfce>("ImprimirCupomNfce");
                AddMethod<CdeclImports.SetSenha>("SetSenha");
                AddMethod<CdeclImports.SetSenhaServer>("SetSenhaServer");
            }
        }

        #endregion Methods
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_E1Bridge
{
    public class FuncoesDLL
    {
        public const string PATH = @"E1_Bridge01.dll";

        [DllImport(PATH, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ConsultarStatus();

        [DllImport(PATH, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetServer(string ipTerminal, int portaTransacao, int portaStatus);

        [DllImport(PATH, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr IniciaVenda(int idTransacao, string pdv, string valorTotal);

        [DllImport(PATH, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr IniciaVendaDebito(int idTransacao, string pdv, string valorTotal);

        [DllImport(PATH, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr IniciaVendaCredito(int idTransacao, string pdv, string valorTotal, int tipoFinanciamento, int numParcelas);

        [DllImport(PATH, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr IniciaOperacaoAdministrativa(int idTransacao, string pdv, int operacao);

        [DllImport(PATH, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ImprimirCupomSat(string xml);

        [DllImport(PATH, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ImprimirCupomSatCancelamento(string xml, string qRCode);

        [DllImport(PATH, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr ImprimirCupomNfce(string xml, int indexcsc, string csc);

        [DllImport(PATH, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetSenha(string senha, bool habilitada);

        [DllImport(PATH, CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static extern IntPtr SetSenhaServer(string senha, bool habilitada);
    }
}

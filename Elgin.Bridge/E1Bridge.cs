using System;
using System.Globalization;
using System.IO;
using System.Text.Json;
using Elgin.Bridge.Commom;
using Elgin.Bridge.Interop;

namespace Elgin.Bridge
{
    public sealed partial class E1Bridge : ElginSafeHandle
    {
        #region Constructors

        public E1Bridge() : this(IsWindows ? "E1_Bridge01.dll" : "E1_Bridge01.so",
                                 IsWindows ? "E1_Bridge01.dll" : "E1_Bridge01.so")
        {
        }

        public E1Bridge(string dllName64, string dllName32) :
                       base(Environment.Is64BitProcess ? dllName64 : dllName32)
        {
            InitializeMethods();
        }

        #endregion Constructors

        #region Properties

        public ServerInfo CurrentServer
        {
            get
            {
                Delegate method;
                if (IsWindows)
                    method = GetMethod<StdCallImports.GetServer>();
                else
                    method = GetMethod<CdeclImports.GetServer>();

                var ret = ExecuteMethod(() => (string)method.DynamicInvoke());
                var result = JsonSerializer.Deserialize<ElginResult>(ret);
                if (result == null) throw new Exception("Erro ao consultar a dll.");
                var dados = result.Mensagem.Trim().Split('|');
                return new ServerInfo
                {
                    Terminal = dados[0],
                    PortaTransacao = Convert.ToInt32(dados[1]),
                    PortaStatus = Convert.ToInt32(dados[2])
                };
            }
        }

        public int Timeout 
        {
            get
            {
                Delegate method;
                if (IsWindows)
                    method = GetMethod<StdCallImports.GetTimeout>();
                else
                    method = GetMethod<CdeclImports.GetTimeout>();

                var ret = ExecuteMethod(() => (string)method.DynamicInvoke());
                var result = JsonSerializer.Deserialize<ElginResult>(ret);
                return Convert.ToInt32(result?.Mensagem);
            }
            set
            {
                Delegate method;
                if (IsWindows)
                    method = GetMethod<StdCallImports.SetTimeout>();
                else
                    method = GetMethod<CdeclImports.SetTimeout>();

                var ret = ExecuteMethod(() => (string)method.DynamicInvoke(value));
                var result = JsonSerializer.Deserialize<ElginResult>(ret);
                if (result== null) throw new Exception("Erro ao consultar a dll.");
                if (result.Mensagem.Trim() != "Sucesso") throw new Exception(result.Mensagem);
            }
        }

        #endregion

        #region Methods

        public ServerInfo SetServer(string ipTerminal, int portaTransacao, int portaStatus)
        {
            Delegate method;
            if (IsWindows)
                method = GetMethod<StdCallImports.SetServer>();
            else
                method = GetMethod<CdeclImports.SetServer>();

            var ret = ExecuteMethod(() => (string)method.DynamicInvoke(ipTerminal, portaTransacao, portaStatus));
            var result = JsonSerializer.Deserialize<ElginResult>(ret);
            if (result == null) throw new Exception("Erro ao consultar a dll.");

            var dados = result.Mensagem.Trim().Split('|');
            return new ServerInfo()
            {
                Terminal = dados[0],
                PortaTransacao = Convert.ToInt32(dados[1]),
                PortaStatus = Convert.ToInt32(dados[2])
            };
        }

        public void SetSenha(string senha, bool habilitada)
        {
            Delegate method;
            if (IsWindows)
                method = GetMethod<StdCallImports.SetSenha>();
            else
                method = GetMethod<CdeclImports.SetSenha>();

            var ret = ExecuteMethod(() => (string)method.DynamicInvoke(senha, habilitada));
            var result = JsonSerializer.Deserialize<ElginResult>(ret);
            if (result == null) throw new Exception("Erro ao consultar a dll.");

            var dados = result.Mensagem.Trim().Split('|'); 
            if (result.Mensagem.Trim() != "Sucesso") throw new Exception(result.Mensagem);
        }

        public void SetSenhaServer(string senha, bool habilitada)
        {
            Delegate method;
            if (IsWindows)
                method = GetMethod<StdCallImports.SetSenhaServer>();
            else
                method = GetMethod<CdeclImports.SetSenhaServer>();

            var ret = ExecuteMethod(() => (string)method.DynamicInvoke(senha, habilitada));
            var result = JsonSerializer.Deserialize<ElginResult>(ret);
            if (result == null) throw new Exception("Erro ao consultar a dll.");

            var dados = result.Mensagem.Trim().Split('|');
            if (result.Mensagem.Trim() != "Sucesso") throw new Exception(result.Mensagem);
        }

        public ElginResult ConsultarStatus()
        {
            Delegate method;
            if (IsWindows)
                method = GetMethod<StdCallImports.ConsultarStatus>();
            else
                method = GetMethod<CdeclImports.ConsultarStatus>();

            var ret = ExecuteMethod(() => (string)method.DynamicInvoke());
            var result = JsonSerializer.Deserialize<ElginResult>(ret);
            if (result == null) throw new Exception("Erro ao consultar a dll.");

            result.ResultText = ret;
            return result;
        }

        public TransacaoResult ConsultarUltimaTransacao(string pdv)
        {
            Delegate method;
            if (IsWindows)
                method = GetMethod<StdCallImports.ConsultarUltimaTransacao>();
            else
                method = GetMethod<CdeclImports.ConsultarUltimaTransacao>();

            var ret = ExecuteMethod(() => (string)method.DynamicInvoke(pdv));
            var result = JsonSerializer.Deserialize<TransacaoResult>(ret);
            if (result == null) throw new Exception("Erro ao consultar a dll.");

            result.ResultText = ret;
            return result;
        }

        public void ImprimirCupomSat(string xml)
        {
            Delegate method;
            if (IsWindows)
                method = GetMethod<StdCallImports.ImprimirCupomSat>();
            else
                method = GetMethod<CdeclImports.ImprimirCupomSat>();

            var dadosSat = File.Exists(xml) ? File.ReadAllText(xml) : xml;
            var ret = ExecuteMethod(() => (string)method.DynamicInvoke(dadosSat));
            var result = JsonSerializer.Deserialize<ElginResult>(ret);

            if (result == null) throw new Exception("Erro ao consultar a dll.");
            if (result.Mensagem.Trim() != "Sucesso") throw new Exception(result.Mensagem);
        }

        public void ImprimirCupomSatCancelamento(string xml, string qrCode)
        {
            Delegate method;
            if (IsWindows)
                method = GetMethod<StdCallImports.ImprimirCupomSatCancelamento>();
            else
                method = GetMethod<CdeclImports.ImprimirCupomSatCancelamento>();

            var dadosSat = File.Exists(xml) ? File.ReadAllText(xml) : xml;
            var ret = ExecuteMethod(() => (string)method.DynamicInvoke(dadosSat, qrCode));
            var result = JsonSerializer.Deserialize<ElginResult>(ret);

            if (result == null) throw new Exception("Erro ao consultar a dll.");
            if (result.Mensagem.Trim() != "Sucesso") throw new Exception(result.Mensagem);
        }

        public void ImprimirCupomNfce(string xml, int idCSC, string csc)
        {
            Delegate method;
            if (IsWindows)
                method = GetMethod<StdCallImports.ImprimirCupomNfce>();
            else
                method = GetMethod<CdeclImports.ImprimirCupomNfce>();

            var dadosXml = File.Exists(xml) ? File.ReadAllText(xml) : xml;
            var ret = ExecuteMethod(() => (string)method.DynamicInvoke(dadosXml, idCSC, csc));
            var result = JsonSerializer.Deserialize<ElginResult>(ret);

            if (result == null) throw new Exception("Erro ao consultar a dll.");
            if (result.Mensagem.Trim() != "Sucesso") throw new Exception(result.Mensagem);
        }
        
        public TransacaoResult IniciaVenda(int idTransacao, string pdv, decimal valorTotal)
        {
            Delegate method;
            if (IsWindows)
                method = GetMethod<StdCallImports.IniciaVenda>();
            else
                method = GetMethod<CdeclImports.IniciaVenda>();

            var valor = Convert.ToInt64(valorTotal * 100).ToString();
            var ret = ExecuteMethod(() => (string)method.DynamicInvoke(idTransacao, pdv, valor));
            var result = JsonSerializer.Deserialize<TransacaoResult>(ret);
            if (result == null) throw new Exception("Erro ao consultar a dll.");

            result.ResultText = ret;
            return result;
        }

        public TransacaoResult IniciaVendaDebito(int idTransacao, string pdv, decimal valorTotal)
        {
            Delegate method;
            if (IsWindows)
                method = GetMethod<StdCallImports.IniciaVendaDebito>();
            else
                method = GetMethod<CdeclImports.IniciaVendaDebito>();

            var valor = Convert.ToInt64(valorTotal * 100).ToString();
            var ret = ExecuteMethod(() => (string)method.DynamicInvoke(idTransacao, pdv, valor));
            var result = JsonSerializer.Deserialize<TransacaoResult>(ret);
            if (result == null) throw new Exception("Erro ao consultar a dll.");

            result.ResultText = ret;
            return result;
        }

        public TransacaoResult IniciaVendaCredito(int idTransacao, string pdv, decimal valorTotal, TipoFinanciamento tipoFinanciamento, int numParcelas = 0)
        {
            Delegate method;
            if (IsWindows)
                method = GetMethod<StdCallImports.IniciaVendaCredito>();
            else
                method = GetMethod<CdeclImports.IniciaVendaCredito>();

            var valor = Convert.ToInt64(valorTotal * 100).ToString();
            var ret = ExecuteMethod(() => (string)method.DynamicInvoke(idTransacao, pdv, valor, (int)tipoFinanciamento, numParcelas));
            var result = JsonSerializer.Deserialize<TransacaoResult>(ret);
            if (result == null) throw new Exception("Erro ao consultar a dll.");

            result.ResultText = ret;
            return result;
        }

        public TransacaoResult IniciaCancelamentoVenda(int idTransacao, string pdv, decimal valorTotal, DateTime dataHora, string nsu)
        {
            Delegate method;
            if (IsWindows)
                method = GetMethod<StdCallImports.IniciaCancelamentoVenda>();
            else
                method = GetMethod<CdeclImports.IniciaCancelamentoVenda>();

            var valor = Convert.ToInt64(valorTotal * 100).ToString();
            var data = dataHora.ToString("dd/MM/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            var ret = ExecuteMethod(() => (string)method.DynamicInvoke(idTransacao, pdv, valor, data, nsu));
            var result = JsonSerializer.Deserialize<TransacaoResult>(ret);
            if (result == null) throw new Exception("Erro ao consultar a dll.");

            result.ResultText = ret;
            return result;
        }

        public TransacaoResult IniciaOperacaoAdministrativa(int idTransacao, string pdv, OperacaoAdm operacao)
        {
            Delegate method;
            if (IsWindows)
                method = GetMethod<StdCallImports.IniciaOperacaoAdministrativa>();
            else
                method = GetMethod<CdeclImports.IniciaOperacaoAdministrativa>();

            var ret = ExecuteMethod(() => (string)method.DynamicInvoke(idTransacao, pdv, (int)operacao));
            var result = JsonSerializer.Deserialize<TransacaoResult>(ret);
            if (result == null) throw new Exception("Erro ao consultar a dll.");

            result.ResultText = ret;
            return result;
        }

        #endregion Methods
    }
}

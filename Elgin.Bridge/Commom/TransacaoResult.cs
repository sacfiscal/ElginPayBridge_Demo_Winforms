using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Elgin.Bridge.Commom
{
    public sealed class TransacaoResult : ElginResult
    {
        [JsonPropertyName("e1_pdv")]
        public string PDV { get; set; }

        [JsonPropertyName("e1_cupom_fiscal")]
        public bool CumpomFiscal { get; set; }

        [JsonPropertyName("aidCartao")]
        public string AidCartao { get; set; }

        [JsonPropertyName("existeComprovanteGrafico")]
        public string ExisteComprovante { get; set; }

        [JsonPropertyName("comprovanteGraficoLojista")]
        public string ComprovanteLojista { get; set; }

        [JsonPropertyName("comprovanteGraficoPortador")]
        public string ComprovantePortador { get; set; }

        [JsonPropertyName("modalidadeTransacao")]
        public string Modalidade { get; set; }

        [JsonPropertyName("codigoAutorizacao")]
        public string Autorizacao { get; set; }

        [JsonPropertyName("codigoAutorizacaoOriginal")]
        public string AutorizacaoOriginal { get; set; }

        [JsonPropertyName("identificadorTransacaoAutomacao")]
        public string IdTransacaoAutomacao { get; set; }

        [JsonPropertyName("modoEntradaCartao")]
        public string ModoEntradaCartao { get; set; }

        [JsonPropertyName("panMascarado")]
        public string PanMascarado { get; set; }

        [ElginJsonDateTimeFormat]
        [JsonPropertyName("dataHoraTransacao")]
        public DateTime DataTransacao { get; set; }

        [JsonPropertyName("comprovanteCompleto")]
        public string ComprovanteCompleto { get; set; }

        [ElginJsonDateTimeFormat]
        [JsonPropertyName("dataHoraTransacaoOriginal")]
        public DateTime DtTransacaoOriginal { get; set; }

        [JsonPropertyName("nomeCartao")]
        public string NomeCartao { get; set; }
        
        [JsonPropertyName("comprovanteReduzidoPortador")]
        public string[] ComprovanteRedPortador { get; set; }

        [JsonPropertyName("documentoFiscal")]
        public string DocumentoFiscal { get; set; }

        [ElginJsonDecimalFormat]
        [JsonPropertyName("valorTroco")]
        public decimal ValorTroco { get; set; }

        [ElginJsonDecimalFormat]
        [JsonPropertyName("valorDesconto")]
        public decimal ValorDesconto { get; set; }

        [JsonPropertyName("identificadorEstabelecimento")]
        public string IdEstabelecimento { get; set; }

        [JsonPropertyName("nomeProvedor")]
        public string NomeProvedor { get; set; }

        [JsonPropertyName("operacao")]
        public string Operacao { get; set; }

        [JsonPropertyName("tipoCartao")]
        public string TipoCartao { get; set; }

        [JsonPropertyName("tipoFinanciamento")]
        public string TipoFinanciamento { get; set; }

        [JsonPropertyName("numeroParcelas")]
        public int NumeroParcelas { get; set; }

        [ElginJsonDateTimeFormat]
        [JsonPropertyName("dataPredatado")]
        public DateTime DtPredatado { get; set; }

        [JsonPropertyName("comprovanteDiferenciadoLoja")]
        public string[] ComprovanteDifLoja { get; set; }

        [JsonPropertyName("comprovanteDiferenciadoPortador")]
        public string[] ComprovanteDifPortador { get; set; }

        [JsonPropertyName("mensagemResultado")]
        public string MensagemResultado { get; set; }

        [JsonPropertyName("codigoMoeda")]
        public string CodigoMoeda { get; set; }

        [ElginJsonDecimalFormat]
        [JsonPropertyName("valorTotal")]
        public decimal ValorTotal { get; set; }

        [ElginJsonDecimalFormat]
        [JsonPropertyName("valorOriginal")]
        public decimal ValorOriginal { get; set; }

        [JsonPropertyName("identificadorPontoCaptura")]
        public string IdPontoCaptura { get; set; }

        [JsonPropertyName("viasImprimir")]
        public string ViasImprimir { get; set; }

        [JsonPropertyName("resultadoTransacao")]
        public int ResultadoTransacao { get; set; }

        [JsonPropertyName("modoVerificacaoSenha")]
        public string ModoVerificacaoSenha { get; set; }

        [JsonPropertyName("identificadorConfirmacaoTransacao")]
        public string IdConfirmacaoTransacao { get; set; }

        [JsonPropertyName("existeTransacaoPendente")]
        public bool ExisteTransacaoPendente { get; set; }

        [ElginJsonDecimalFormat]
        [JsonPropertyName("saldoVoucher")]
        public decimal SaldoVoucher { get; set; }

        [ElginJsonDecimalFormat]
        [JsonPropertyName("valorDevido")]
        public decimal ValorDevido { get; set; }

        [JsonPropertyName("nomeEstabelecimento")]
        public string NomeEstabelecimento { get; set; }

        [JsonPropertyName("panMascaradoPadrao")]
        public string PanMascaradoPadrao { get; set; }

        [JsonPropertyName("nomeCartaoPadrao")]
        public string NomeCartaoPadrao { get; set; }

        [JsonPropertyName("nomePortadorCartao")]
        public string NomePortadorCartao { get; set; }

        [JsonPropertyName("modalidadePagamento")]
        public string ModalidadePagamento { get; set; }

        [JsonPropertyName("idPortadorCarteira")]
        public string IdPortadorCarteira { get; set; }

        [JsonPropertyName("nsuTransacao")]
        public string NSUTransacao { get; set; }

        [JsonPropertyName("nsuTerminal")]
        public string NSUTerminal { get; set; }

        [JsonPropertyName("provedor")]
        public string Provedor { get; set; }

        [JsonPropertyName("uniqueID")]
        public string UniqueID { get; set; }

        [JsonPropertyName("requerConfirmacao")]
        public bool RequerConfirmacao { get; set; }

        [JsonPropertyName("respostaRede")]
        public bool RespostaRede { get; set; }

        [JsonPropertyName("nsuTransacaoOriginal")]
        public bool NSUTransacaoOriginal { get; set; }

        [JsonPropertyName("nsuTerminalOriginal")]
        public bool NSUTerminalOriginal { get; set; }

        [JsonPropertyName("dadosTransacaoPendente")]
        public bool DadosTransacaoPendente { get; set; }
    }
}
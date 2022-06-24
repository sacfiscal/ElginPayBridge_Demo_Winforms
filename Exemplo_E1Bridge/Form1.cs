using System.Runtime.InteropServices;
using System.Xml;
using Elgin.Bridge;
using Elgin.Bridge.Commom;

namespace Exemplo_E1Bridge
{
    public partial class E1_Bridge : Form
    {
        private readonly E1Bridge bridge;

        public E1_Bridge()
        {
            InitializeComponent();
            bridge = new E1Bridge();
        }

        public void ChecarCampos()
        {
            if (string.IsNullOrEmpty(txtIP.Text))
            {
                MessageBox.Show(@"Preencha o IP do Terminal");
                txtIP.Focus();
                return;
            }

            if (string.IsNullOrEmpty(txPortaTransacao.Text))
            {
                MessageBox.Show(@"Preencha a porta de transação");
                txPortaTransacao.Focus();
                return;
            }

            if (!string.IsNullOrEmpty(txPortaStatus.Text)) return;

            MessageBox.Show(@"Preencha a porta de status");
            txPortaStatus.Focus();
            return;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChecarCampos();
            var ret = bridge.ConsultarStatus();
            txResposta.Clear();
            txResposta.AppendText($"ConsultarStatus: {ret.ResultText}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChecarCampos();

            var ret = bridge.SetServer(txtIP.Text,
                                       (int)txPortaTransacao.Value,
                                       (int)txPortaStatus.Value);

            txResposta.Clear();
            txResposta.AppendText($"SetServer: {ret}");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChecarCampos();

            var ret = bridge.IniciaVenda(1,"PDV01", txValorVenda.Value);

            txResposta.Clear();
            txResposta.AppendText(ret.ResultText);

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txResposta.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChecarCampos();

            var ret = bridge.IniciaVendaDebito(1, "PDV01", txValorDebito.Value);

            txResposta.Clear();
            txResposta.AppendText(ret.ResultText);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChecarCampos();

            var op = cbTipoParcelamento.SelectedIndex;
            op += 1;
            if (op == 0)
            {
                MessageBox.Show(@"Selecione o tipo de financiamento");
                return;
            }

            var ret = bridge.IniciaVendaCredito(1, "PDV01", txValorCredito.Value, (TipoFinanciamento)op, (int)txParcelas.Value);

            txResposta.Clear();
            txResposta.AppendText(ret.ResultText);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChecarCampos();

            var op = cbOpcoesAdministrativas.SelectedIndex;
            op += 1;
            if (op == 0)
            {
                MessageBox.Show(@"Selecione a opção administrativa");
                return;
            }

            var ret = bridge.IniciaOperacaoAdministrativa(1, "PDV01", (OperacaoAdm)op);

            txResposta.Clear();
            txResposta.AppendText(ret.ResultText);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            txSenha.Clear();
            txConfirmaSenha.Clear();
            lbWarning1.Visible = true;
            chkHabilitaSenha.Checked = true;

        }

        private void rbSenhaTerminal_Click(object sender, EventArgs e)
        {
            txSenha.Clear();
            txConfirmaSenha.Clear();
            lbWarning1.Visible = false;
            chkHabilitaSenha.Checked = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            bridge.ImprimirCupomSat("VENDA_SAT.xml");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            const string qrCode = "kAmMUV2AFOP11vsbAwb4S1MrcnzIm8o6trefwjpRvpJaNGeXXcM2GKbs+aALc3WDxrimeOf9BdgoZl29RvtC1DmvqZ56oVEoRz0ymia1tHUdGPzuO035OuiEseEj3+gU+8NzGzqWQIJgqdgLOZgnmUP2aBOkC0QcokhHPVfwm9tJFQnQkzGzu4692+LtpxhLwEhnFjoZh+1hpBXn5AEcbMS4Lx751qvFlfZX0hsYJf5pKcFH88E3byU82MU8UD5p9fyX2qL5Ae+Uql1VLPqoJOsQmC2BCBkMW7oQRCCR0osz6eLX1DHHJU+stxKCkITlQnz6XJd4LKXifGZuZ25+Uw==";
            bridge.ImprimirCupomSatCancelamento("CANC_SAT.xml", qrCode);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            bridge.ImprimirCupomNfce("NFCe.xml", 1, "6ad7f390-7eb8-11ec-90d6-0242ac120003");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (rbSenhaCliente.Checked)
                bridge.SetSenha(string.Empty, false);
            else
                bridge.SetSenhaServer(string.Empty, false);

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txSenha.Text != txConfirmaSenha.Text
                    || string.IsNullOrWhiteSpace(txSenha.Text)
                    || string.IsNullOrWhiteSpace(txConfirmaSenha.Text))
            {
                MessageBox.Show(@"As senhas não são iguais");
                cbOpcoesAdministrativas.Focus();
                return;
            }

            if (rbSenhaCliente.Checked)
                bridge.SetSenha(txSenha.Text, false);
            else
                bridge.SetSenhaServer(txSenha.Text, false);
        }
    }
}
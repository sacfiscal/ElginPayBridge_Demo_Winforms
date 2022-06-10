using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.Json;
using System.Xml;

namespace Exemplo_E1Bridge
{
    public partial class E1_Bridge : Form
    {
        public E1_Bridge()
        {
            InitializeComponent();
        }

        public void ChecarCampos()
        {
            if (String.IsNullOrEmpty(txtIP.Text))
            {
                MessageBox.Show("Preencha o IP do Terminal");
                txtIP.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txPortaTransacao.Text))
            {
                MessageBox.Show("Preencha a porta de transação");
                txPortaTransacao.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txPortaStatus.Text))
            {
                MessageBox.Show("Preencha a porta de status");
                txPortaStatus.Focus();
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChecarCampos();

            string retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.ConsultarStatus());

            txResposta.Clear();
            txResposta.AppendText(JsonConvert.SerializeObject(retornoDireto));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChecarCampos();

            string retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.SetServer(txtIP.Text,
                                                                                Int32.Parse(txPortaTransacao.Text),
                                                                                Int32.Parse(txPortaStatus.Text)));

            txResposta.Clear();
            txResposta.AppendText(JsonConvert.SerializeObject(retornoDireto));

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChecarCampos();

            string retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.IniciaVenda(1,"PDV01", txValorVenda.Text));

            txResposta.Clear();
            txResposta.AppendText(JsonConvert.SerializeObject(retornoDireto));

        }

        private void button12_Click(object sender, EventArgs e)
        {
            txResposta.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChecarCampos();

            string retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.IniciaVendaDebito(1, "PDV01", txValorVenda.Text));

            txResposta.Clear();
            txResposta.AppendText(JsonConvert.SerializeObject(retornoDireto));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChecarCampos();

            int op = cbTipoParcelamento.SelectedIndex;
            op = op + 1;
            if (op == 0)
            {
                MessageBox.Show("Selecione o tipo de financiamento");
                return;
            }

            int parc = Int32.Parse(txParcelas.Text);

            string retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.IniciaVendaCredito(1, "PDV01", txValorCredito.Text, op, parc));

            txResposta.Clear();
            txResposta.AppendText(JsonConvert.SerializeObject(retornoDireto));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChecarCampos();

            int op = cbOpcoesAdministrativas.SelectedIndex;
            op = op + 1;
            if (op == 0)
            {
                MessageBox.Show("Selecione a opção administrativa");
                return;
            }

            string retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.IniciaOperacaoAdministrativa(1, "PDV01", op));

            txResposta.Clear();
            txResposta.AppendText(JsonConvert.SerializeObject(retornoDireto));
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
            XmlDocument xml = new XmlDocument();
            xml.Load("VENDA_SAT.xml");
            string xml_sat = xml.InnerXml;
            
            string retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.ImprimirCupomSat(xml_sat));

            txResposta.Clear();
            txResposta.AppendText(JsonConvert.SerializeObject(retornoDireto));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("CANC_SAT.xml");
            string xml_cancelamento = xml.InnerXml;
            string qrCode = "kAmMUV2AFOP11vsbAwb4S1MrcnzIm8o6trefwjpRvpJaNGeXXcM2GKbs+aALc3WDxrimeOf9BdgoZl29RvtC1DmvqZ56oVEoRz0ymia1tHUdGPzuO035OuiEseEj3+gU+8NzGzqWQIJgqdgLOZgnmUP2aBOkC0QcokhHPVfwm9tJFQnQkzGzu4692+LtpxhLwEhnFjoZh+1hpBXn5AEcbMS4Lx751qvFlfZX0hsYJf5pKcFH88E3byU82MU8UD5p9fyX2qL5Ae+Uql1VLPqoJOsQmC2BCBkMW7oQRCCR0osz6eLX1DHHJU+stxKCkITlQnz6XJd4LKXifGZuZ25+Uw==";

            string retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.ImprimirCupomSatCancelamento(xml_cancelamento, qrCode));

            txResposta.Clear();
            txResposta.AppendText(JsonConvert.SerializeObject(retornoDireto));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load("NFCe.xml");
            string xml_nfce = xml.InnerXml;
            string csc = "6ad7f390-7eb8-11ec-90d6-0242ac120003";

            string retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.ImprimirCupomNfce(xml_nfce, 1, csc));

            txResposta.Clear();
            txResposta.AppendText(JsonConvert.SerializeObject(retornoDireto));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string retornoDireto;
            if (rbSenhaCliente.Checked)
            {
                retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.SetSenha(string.Empty, false));
            }
            else
            {
                retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.SetSenhaServer(string.Empty, false));
            }

            txResposta.Clear();
            txResposta.AppendText(JsonConvert.SerializeObject(retornoDireto));

        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (txSenha.Text != txConfirmaSenha.Text
                    || string.IsNullOrWhiteSpace(txSenha.Text)
                    || string.IsNullOrWhiteSpace(txConfirmaSenha.Text))
            {
                MessageBox.Show("As senhas não são iguais");
                cbOpcoesAdministrativas.Focus();
                return;
            }

            string retornoDireto;
            if (rbSenhaCliente.Checked)
            {
                retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.SetSenha(string.Empty, false));
            }
            else
            {
                retornoDireto = Marshal.PtrToStringAnsi(FuncoesDLL.SetSenhaServer(string.Empty, false));
            }

            txResposta.Clear();
            txResposta.AppendText(JsonConvert.SerializeObject(retornoDireto));
        }
    }
}
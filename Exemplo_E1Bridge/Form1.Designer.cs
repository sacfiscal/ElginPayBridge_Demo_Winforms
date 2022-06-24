namespace Exemplo_E1Bridge
{
    partial class E1_Bridge
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txPortaStatus = new System.Windows.Forms.NumericUpDown();
            this.txPortaTransacao = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txValorVenda = new System.Windows.Forms.NumericUpDown();
            this.button3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txValorDebito = new System.Windows.Forms.NumericUpDown();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txParcelas = new System.Windows.Forms.NumericUpDown();
            this.txValorCredito = new System.Windows.Forms.NumericUpDown();
            this.cbTipoParcelamento = new System.Windows.Forms.ComboBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.cbOpcoesAdministrativas = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.lbWarning1 = new System.Windows.Forms.Label();
            this.chkHabilitaSenha = new System.Windows.Forms.CheckBox();
            this.txConfirmaSenha = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txSenha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.rbSenhaTerminal = new System.Windows.Forms.RadioButton();
            this.rbSenhaCliente = new System.Windows.Forms.RadioButton();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.txResposta = new System.Windows.Forms.RichTextBox();
            this.button12 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txPortaStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPortaTransacao)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txValorVenda)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txValorDebito)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txParcelas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValorCredito)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txPortaStatus);
            this.groupBox1.Controls.Add(this.txPortaTransacao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtIP);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Terminal";
            // 
            // txPortaStatus
            // 
            this.txPortaStatus.Location = new System.Drawing.Point(288, 60);
            this.txPortaStatus.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txPortaStatus.Name = "txPortaStatus";
            this.txPortaStatus.Size = new System.Drawing.Size(100, 23);
            this.txPortaStatus.TabIndex = 8;
            this.txPortaStatus.Value = new decimal(new int[] {
            3001,
            0,
            0,
            0});
            // 
            // txPortaTransacao
            // 
            this.txPortaTransacao.Location = new System.Drawing.Point(288, 21);
            this.txPortaTransacao.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
            this.txPortaTransacao.Name = "txPortaTransacao";
            this.txPortaTransacao.Size = new System.Drawing.Size(100, 23);
            this.txPortaTransacao.TabIndex = 4;
            this.txPortaTransacao.Value = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 7;
            this.label3.Text = "Porta de status:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Porta de transação:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(428, 60);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Testar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(428, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Endereço IP";
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(20, 60);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 23);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "10.0.0.119";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txValorVenda);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 118);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(521, 73);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Venda";
            // 
            // txValorVenda
            // 
            this.txValorVenda.DecimalPlaces = 2;
            this.txValorVenda.Location = new System.Drawing.Point(89, 31);
            this.txValorVenda.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.txValorVenda.Name = "txValorVenda";
            this.txValorVenda.Size = new System.Drawing.Size(120, 23);
            this.txValorVenda.TabIndex = 3;
            this.txValorVenda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txValorVenda.ThousandsSeparator = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(428, 31);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "Iniciar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 0;
            this.label4.Text = "Valor total:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txValorDebito);
            this.groupBox3.Controls.Add(this.button4);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Location = new System.Drawing.Point(12, 197);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(521, 75);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Venda no Débito";
            // 
            // txValorDebito
            // 
            this.txValorDebito.DecimalPlaces = 2;
            this.txValorDebito.Location = new System.Drawing.Point(89, 33);
            this.txValorDebito.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.txValorDebito.Name = "txValorDebito";
            this.txValorDebito.Size = new System.Drawing.Size(120, 23);
            this.txValorDebito.TabIndex = 4;
            this.txValorDebito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txValorDebito.ThousandsSeparator = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(428, 33);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Iniciar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Valor total:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txParcelas);
            this.groupBox4.Controls.Add(this.txValorCredito);
            this.groupBox4.Controls.Add(this.cbTipoParcelamento);
            this.groupBox4.Controls.Add(this.button5);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Location = new System.Drawing.Point(12, 278);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(521, 100);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Venda no Crédito";
            // 
            // txParcelas
            // 
            this.txParcelas.Location = new System.Drawing.Point(310, 22);
            this.txParcelas.Name = "txParcelas";
            this.txParcelas.Size = new System.Drawing.Size(67, 23);
            this.txParcelas.TabIndex = 11;
            this.txParcelas.Value = new decimal(new int[] {
            12,
            0,
            0,
            0});
            // 
            // txValorCredito
            // 
            this.txValorCredito.DecimalPlaces = 2;
            this.txValorCredito.Location = new System.Drawing.Point(89, 22);
            this.txValorCredito.Maximum = new decimal(new int[] {
            -1593835521,
            466537709,
            54210,
            0});
            this.txValorCredito.Name = "txValorCredito";
            this.txValorCredito.Size = new System.Drawing.Size(120, 23);
            this.txValorCredito.TabIndex = 6;
            this.txValorCredito.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txValorCredito.ThousandsSeparator = true;
            this.txValorCredito.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // cbTipoParcelamento
            // 
            this.cbTipoParcelamento.FormattingEnabled = true;
            this.cbTipoParcelamento.Items.AddRange(new object[] {
            "A VISTA",
            "PARC. EMISSOR",
            "PARC. ESTABELECIMENTO"});
            this.cbTipoParcelamento.Location = new System.Drawing.Point(20, 62);
            this.cbTipoParcelamento.Name = "cbTipoParcelamento";
            this.cbTipoParcelamento.Size = new System.Drawing.Size(169, 23);
            this.cbTipoParcelamento.TabIndex = 10;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(428, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Iniciar";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 15);
            this.label7.TabIndex = 7;
            this.label7.Text = "Qtde. Parcelas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Valor total:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button6);
            this.groupBox5.Controls.Add(this.cbOpcoesAdministrativas);
            this.groupBox5.Location = new System.Drawing.Point(12, 384);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(521, 72);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Operação Administrativa";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(418, 35);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Iniciar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // cbOpcoesAdministrativas
            // 
            this.cbOpcoesAdministrativas.FormattingEnabled = true;
            this.cbOpcoesAdministrativas.Items.AddRange(new object[] {
            "ADMINISTRATIVA",
            "INSTALAÇÃO",
            "CONFIGURAÇÃO",
            "MANUTENÇÃO",
            "TESTE DE COMUNICAÇÃO",
            "REIMPRESSÃO"});
            this.cbOpcoesAdministrativas.Location = new System.Drawing.Point(20, 36);
            this.cbOpcoesAdministrativas.Name = "cbOpcoesAdministrativas";
            this.cbOpcoesAdministrativas.Size = new System.Drawing.Size(169, 23);
            this.cbOpcoesAdministrativas.TabIndex = 11;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.button9);
            this.groupBox6.Controls.Add(this.button8);
            this.groupBox6.Controls.Add(this.button7);
            this.groupBox6.Location = new System.Drawing.Point(12, 462);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(521, 65);
            this.groupBox6.TabIndex = 5;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Outras Operaçãoes";
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(373, 32);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(142, 23);
            this.button9.TabIndex = 15;
            this.button9.Text = "Imprimir DANFECe";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(182, 32);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(166, 23);
            this.button8.TabIndex = 14;
            this.button8.Text = "Imprimir Cancelamento SAT";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(20, 32);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(142, 23);
            this.button7.TabIndex = 13;
            this.button7.Text = "Imprimir Extrato SAT";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.lbWarning1);
            this.groupBox7.Controls.Add(this.chkHabilitaSenha);
            this.groupBox7.Controls.Add(this.txConfirmaSenha);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.txSenha);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.groupBox8);
            this.groupBox7.Location = new System.Drawing.Point(12, 533);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(304, 212);
            this.groupBox7.TabIndex = 6;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Configuração de Senha";
            // 
            // lbWarning1
            // 
            this.lbWarning1.AutoSize = true;
            this.lbWarning1.Location = new System.Drawing.Point(-2, 168);
            this.lbWarning1.Name = "lbWarning1";
            this.lbWarning1.Size = new System.Drawing.Size(309, 15);
            this.lbWarning1.TabIndex = 12;
            this.lbWarning1.Text = "Obs: certifique-se de ter configurado a *senha do cliente*";
            this.lbWarning1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkHabilitaSenha
            // 
            this.chkHabilitaSenha.AutoSize = true;
            this.chkHabilitaSenha.Location = new System.Drawing.Point(79, 136);
            this.chkHabilitaSenha.Name = "chkHabilitaSenha";
            this.chkHabilitaSenha.Size = new System.Drawing.Size(115, 19);
            this.chkHabilitaSenha.TabIndex = 11;
            this.chkHabilitaSenha.Text = "Senha Habilitada";
            this.chkHabilitaSenha.UseVisualStyleBackColor = true;
            // 
            // txConfirmaSenha
            // 
            this.txConfirmaSenha.Location = new System.Drawing.Point(182, 102);
            this.txConfirmaSenha.Name = "txConfirmaSenha";
            this.txConfirmaSenha.Size = new System.Drawing.Size(100, 23);
            this.txConfirmaSenha.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(77, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 15);
            this.label9.TabIndex = 9;
            this.label9.Text = "Confirmar Senha:";
            // 
            // txSenha
            // 
            this.txSenha.Location = new System.Drawing.Point(182, 74);
            this.txSenha.Name = "txSenha";
            this.txSenha.Size = new System.Drawing.Size(100, 23);
            this.txSenha.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Senha:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.rbSenhaTerminal);
            this.groupBox8.Controls.Add(this.rbSenhaCliente);
            this.groupBox8.Location = new System.Drawing.Point(6, 22);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(278, 46);
            this.groupBox8.TabIndex = 0;
            this.groupBox8.TabStop = false;
            // 
            // rbSenhaTerminal
            // 
            this.rbSenhaTerminal.AutoSize = true;
            this.rbSenhaTerminal.Location = new System.Drawing.Point(149, 19);
            this.rbSenhaTerminal.Name = "rbSenhaTerminal";
            this.rbSenhaTerminal.Size = new System.Drawing.Size(122, 19);
            this.rbSenhaTerminal.TabIndex = 1;
            this.rbSenhaTerminal.TabStop = true;
            this.rbSenhaTerminal.Text = "Senha do Terminal";
            this.rbSenhaTerminal.UseVisualStyleBackColor = true;
            this.rbSenhaTerminal.Click += new System.EventHandler(this.rbSenhaTerminal_Click);
            // 
            // rbSenhaCliente
            // 
            this.rbSenhaCliente.AutoSize = true;
            this.rbSenhaCliente.Location = new System.Drawing.Point(15, 19);
            this.rbSenhaCliente.Name = "rbSenhaCliente";
            this.rbSenhaCliente.Size = new System.Drawing.Size(112, 19);
            this.rbSenhaCliente.TabIndex = 0;
            this.rbSenhaCliente.TabStop = true;
            this.rbSenhaCliente.Text = "Senha do cliente";
            this.rbSenhaCliente.UseVisualStyleBackColor = true;
            this.rbSenhaCliente.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(91, 751);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(75, 23);
            this.button10.TabIndex = 13;
            this.button10.Text = "Excluir";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(194, 751);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 14;
            this.button11.Text = "Salvar";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // txResposta
            // 
            this.txResposta.Location = new System.Drawing.Point(325, 543);
            this.txResposta.Name = "txResposta";
            this.txResposta.Size = new System.Drawing.Size(208, 202);
            this.txResposta.TabIndex = 15;
            this.txResposta.Text = "";
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(397, 751);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 23);
            this.button12.TabIndex = 16;
            this.button12.Text = "Limpar";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // E1_Bridge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 749);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.txResposta);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "E1_Bridge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "E1_Bridge";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txPortaStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txPortaTransacao)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txValorVenda)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txValorDebito)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txParcelas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txValorCredito)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Label label3;
        private Label label2;
        private Button button2;
        private Button button1;
        private Label label1;
        private TextBox txtIP;
        private GroupBox groupBox2;
        private Button button3;
        private Label label4;
        private GroupBox groupBox3;
        private Button button4;
        private Label label5;
        private GroupBox groupBox4;
        private ComboBox cbTipoParcelamento;
        private Button button5;
        private Label label7;
        private Label label6;
        private GroupBox groupBox5;
        private Button button6;
        private ComboBox cbOpcoesAdministrativas;
        private GroupBox groupBox6;
        private Button button9;
        private Button button8;
        private Button button7;
        private GroupBox groupBox7;
        private GroupBox groupBox8;
        private RadioButton rbSenhaTerminal;
        private RadioButton rbSenhaCliente;
        private Label lbWarning1;
        private CheckBox chkHabilitaSenha;
        private TextBox txConfirmaSenha;
        private Label label9;
        private TextBox txSenha;
        private Label label8;
        private Button button10;
        private Button button11;
        private RichTextBox txResposta;
        private Button button12;
        private NumericUpDown txValorVenda;
        private NumericUpDown txValorDebito;
        private NumericUpDown txParcelas;
        private NumericUpDown txValorCredito;
        private NumericUpDown txPortaStatus;
        private NumericUpDown txPortaTransacao;
    }
}
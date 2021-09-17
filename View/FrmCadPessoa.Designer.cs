
namespace View
{
    partial class FrmCadPessoa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCidade = new System.Windows.Forms.ComboBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.txbLogradouro = new System.Windows.Forms.TextBox();
            this.ltbTipoEndereco = new System.Windows.Forms.ListBox();
            this.gpbDadosComplementares = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rdbMasculino = new System.Windows.Forms.RadioButton();
            this.rdbFeminino = new System.Windows.Forms.RadioButton();
            this.rdbOutros = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdbSolteiro = new System.Windows.Forms.RadioButton();
            this.rdbCasado = new System.Windows.Forms.RadioButton();
            this.rdbEnrolado = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkAnimais = new System.Windows.Forms.CheckBox();
            this.chkFumante = new System.Windows.Forms.CheckBox();
            this.chkFilhos = new System.Windows.Forms.CheckBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gpbDadosPrincipais = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.v = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txbProfissao = new System.Windows.Forms.TextBox();
            this.mtbCel = new System.Windows.Forms.MaskedTextBox();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.mtbNascimento = new System.Windows.Forms.MaskedTextBox();
            this.txbNome = new System.Windows.Forms.TextBox();
            this.mtbCPF = new System.Windows.Forms.MaskedTextBox();
            this.ptbFoto = new System.Windows.Forms.PictureBox();
            this.gpbEndereco.SuspendLayout();
            this.gpbDadosComplementares.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gpbDadosPrincipais.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.label4);
            this.gpbEndereco.Controls.Add(this.label3);
            this.gpbEndereco.Controls.Add(this.label2);
            this.gpbEndereco.Controls.Add(this.label1);
            this.gpbEndereco.Controls.Add(this.cmbCidade);
            this.gpbEndereco.Controls.Add(this.cmbEstado);
            this.gpbEndereco.Controls.Add(this.txbLogradouro);
            this.gpbEndereco.Controls.Add(this.ltbTipoEndereco);
            this.gpbEndereco.Location = new System.Drawing.Point(12, 277);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(667, 188);
            this.gpbEndereco.TabIndex = 1;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Estado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Logradouro:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tipo:";
            // 
            // cmbCidade
            // 
            this.cmbCidade.FormattingEnabled = true;
            this.cmbCidade.Items.AddRange(new object[] {
            "Rio de Janeiro",
            "Araruama",
            "Niterói",
            "Vitória",
            "Belo Horizonte",
            "São Paulo",
            "Santos"});
            this.cmbCidade.Location = new System.Drawing.Point(432, 141);
            this.cmbCidade.Name = "cmbCidade";
            this.cmbCidade.Size = new System.Drawing.Size(188, 21);
            this.cmbCidade.TabIndex = 3;
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Items.AddRange(new object[] {
            "RJ",
            "SP",
            "MG",
            "ES"});
            this.cmbEstado.Location = new System.Drawing.Point(432, 55);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(188, 21);
            this.cmbEstado.TabIndex = 2;
            // 
            // txbLogradouro
            // 
            this.txbLogradouro.Location = new System.Drawing.Point(170, 55);
            this.txbLogradouro.MaxLength = 250;
            this.txbLogradouro.Multiline = true;
            this.txbLogradouro.Name = "txbLogradouro";
            this.txbLogradouro.Size = new System.Drawing.Size(220, 107);
            this.txbLogradouro.TabIndex = 1;
            // 
            // ltbTipoEndereco
            // 
            this.ltbTipoEndereco.FormattingEnabled = true;
            this.ltbTipoEndereco.Items.AddRange(new object[] {
            "Rua",
            "Av.",
            "Trv.",
            "Alm.",
            "Rod."});
            this.ltbTipoEndereco.Location = new System.Drawing.Point(16, 54);
            this.ltbTipoEndereco.Name = "ltbTipoEndereco";
            this.ltbTipoEndereco.Size = new System.Drawing.Size(120, 108);
            this.ltbTipoEndereco.TabIndex = 0;
            // 
            // gpbDadosComplementares
            // 
            this.gpbDadosComplementares.Controls.Add(this.groupBox5);
            this.gpbDadosComplementares.Controls.Add(this.groupBox4);
            this.gpbDadosComplementares.Controls.Add(this.groupBox3);
            this.gpbDadosComplementares.Location = new System.Drawing.Point(12, 493);
            this.gpbDadosComplementares.Name = "gpbDadosComplementares";
            this.gpbDadosComplementares.Size = new System.Drawing.Size(667, 169);
            this.gpbDadosComplementares.TabIndex = 2;
            this.gpbDadosComplementares.TabStop = false;
            this.gpbDadosComplementares.Text = "Dados Complementares";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rdbMasculino);
            this.groupBox5.Controls.Add(this.rdbFeminino);
            this.groupBox5.Controls.Add(this.rdbOutros);
            this.groupBox5.Location = new System.Drawing.Point(16, 23);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(189, 130);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Sexo";
            // 
            // rdbMasculino
            // 
            this.rdbMasculino.AutoSize = true;
            this.rdbMasculino.Location = new System.Drawing.Point(24, 19);
            this.rdbMasculino.Name = "rdbMasculino";
            this.rdbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rdbMasculino.TabIndex = 0;
            this.rdbMasculino.TabStop = true;
            this.rdbMasculino.Text = "Masculino";
            this.rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // rdbFeminino
            // 
            this.rdbFeminino.AutoSize = true;
            this.rdbFeminino.Location = new System.Drawing.Point(24, 57);
            this.rdbFeminino.Name = "rdbFeminino";
            this.rdbFeminino.Size = new System.Drawing.Size(67, 17);
            this.rdbFeminino.TabIndex = 1;
            this.rdbFeminino.TabStop = true;
            this.rdbFeminino.Text = "Feminino";
            this.rdbFeminino.UseVisualStyleBackColor = true;
            // 
            // rdbOutros
            // 
            this.rdbOutros.AutoSize = true;
            this.rdbOutros.Location = new System.Drawing.Point(24, 101);
            this.rdbOutros.Name = "rdbOutros";
            this.rdbOutros.Size = new System.Drawing.Size(56, 17);
            this.rdbOutros.TabIndex = 2;
            this.rdbOutros.TabStop = true;
            this.rdbOutros.Text = "Outros";
            this.rdbOutros.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdbSolteiro);
            this.groupBox4.Controls.Add(this.rdbCasado);
            this.groupBox4.Controls.Add(this.rdbEnrolado);
            this.groupBox4.Location = new System.Drawing.Point(232, 23);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(169, 130);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Estado Civil";
            // 
            // rdbSolteiro
            // 
            this.rdbSolteiro.AutoSize = true;
            this.rdbSolteiro.Location = new System.Drawing.Point(6, 19);
            this.rdbSolteiro.Name = "rdbSolteiro";
            this.rdbSolteiro.Size = new System.Drawing.Size(60, 17);
            this.rdbSolteiro.TabIndex = 3;
            this.rdbSolteiro.TabStop = true;
            this.rdbSolteiro.Text = "Solteiro";
            this.rdbSolteiro.UseVisualStyleBackColor = true;
            // 
            // rdbCasado
            // 
            this.rdbCasado.AutoSize = true;
            this.rdbCasado.Location = new System.Drawing.Point(6, 57);
            this.rdbCasado.Name = "rdbCasado";
            this.rdbCasado.Size = new System.Drawing.Size(61, 17);
            this.rdbCasado.TabIndex = 4;
            this.rdbCasado.TabStop = true;
            this.rdbCasado.Text = "Casado";
            this.rdbCasado.UseVisualStyleBackColor = true;
            // 
            // rdbEnrolado
            // 
            this.rdbEnrolado.AutoSize = true;
            this.rdbEnrolado.Location = new System.Drawing.Point(6, 101);
            this.rdbEnrolado.Name = "rdbEnrolado";
            this.rdbEnrolado.Size = new System.Drawing.Size(67, 17);
            this.rdbEnrolado.TabIndex = 5;
            this.rdbEnrolado.TabStop = true;
            this.rdbEnrolado.Text = "Enrolado";
            this.rdbEnrolado.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkAnimais);
            this.groupBox3.Controls.Add(this.chkFumante);
            this.groupBox3.Controls.Add(this.chkFilhos);
            this.groupBox3.Location = new System.Drawing.Point(432, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(145, 130);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Outros";
            // 
            // chkAnimais
            // 
            this.chkAnimais.AutoSize = true;
            this.chkAnimais.Location = new System.Drawing.Point(25, 26);
            this.chkAnimais.Name = "chkAnimais";
            this.chkAnimais.Size = new System.Drawing.Size(62, 17);
            this.chkAnimais.TabIndex = 6;
            this.chkAnimais.Text = "Animais";
            this.chkAnimais.UseVisualStyleBackColor = true;
            // 
            // chkFumante
            // 
            this.chkFumante.AutoSize = true;
            this.chkFumante.Location = new System.Drawing.Point(25, 102);
            this.chkFumante.Name = "chkFumante";
            this.chkFumante.Size = new System.Drawing.Size(67, 17);
            this.chkFumante.TabIndex = 8;
            this.chkFumante.Text = "Fumante";
            this.chkFumante.UseVisualStyleBackColor = true;
            // 
            // chkFilhos
            // 
            this.chkFilhos.AutoSize = true;
            this.chkFilhos.Location = new System.Drawing.Point(25, 64);
            this.chkFilhos.Name = "chkFilhos";
            this.chkFilhos.Size = new System.Drawing.Size(53, 17);
            this.chkFilhos.TabIndex = 7;
            this.chkFilhos.Text = "Filhos";
            this.chkFilhos.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(604, 712);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(514, 712);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // gpbDadosPrincipais
            // 
            this.gpbDadosPrincipais.Controls.Add(this.label9);
            this.gpbDadosPrincipais.Controls.Add(this.v);
            this.gpbDadosPrincipais.Controls.Add(this.label8);
            this.gpbDadosPrincipais.Controls.Add(this.label7);
            this.gpbDadosPrincipais.Controls.Add(this.label6);
            this.gpbDadosPrincipais.Controls.Add(this.label5);
            this.gpbDadosPrincipais.Controls.Add(this.txbProfissao);
            this.gpbDadosPrincipais.Controls.Add(this.mtbCel);
            this.gpbDadosPrincipais.Controls.Add(this.txbEmail);
            this.gpbDadosPrincipais.Controls.Add(this.mtbNascimento);
            this.gpbDadosPrincipais.Controls.Add(this.txbNome);
            this.gpbDadosPrincipais.Controls.Add(this.mtbCPF);
            this.gpbDadosPrincipais.Controls.Add(this.ptbFoto);
            this.gpbDadosPrincipais.Location = new System.Drawing.Point(12, 28);
            this.gpbDadosPrincipais.Name = "gpbDadosPrincipais";
            this.gpbDadosPrincipais.Size = new System.Drawing.Size(667, 220);
            this.gpbDadosPrincipais.TabIndex = 0;
            this.gpbDadosPrincipais.TabStop = false;
            this.gpbDadosPrincipais.Text = "Dados Principais";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(400, 134);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Profissão:";
            // 
            // v
            // 
            this.v.AutoSize = true;
            this.v.Location = new System.Drawing.Point(400, 86);
            this.v.Name = "v";
            this.v.Size = new System.Drawing.Size(25, 13);
            this.v.TabIndex = 11;
            this.v.Text = "Cel:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(400, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "E-mail:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(154, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Nascimento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(154, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Nome:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(151, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "CPF:";
            // 
            // txbProfissao
            // 
            this.txbProfissao.Location = new System.Drawing.Point(403, 150);
            this.txbProfissao.Name = "txbProfissao";
            this.txbProfissao.Size = new System.Drawing.Size(190, 20);
            this.txbProfissao.TabIndex = 6;
            this.txbProfissao.Text = "Professor";
            // 
            // mtbCel
            // 
            this.mtbCel.Location = new System.Drawing.Point(403, 102);
            this.mtbCel.Mask = "(99) 90000-0000";
            this.mtbCel.Name = "mtbCel";
            this.mtbCel.Size = new System.Drawing.Size(190, 20);
            this.mtbCel.TabIndex = 5;
            this.mtbCel.Text = "21212112121";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(403, 56);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(190, 20);
            this.txbEmail.TabIndex = 4;
            this.txbEmail.Text = "prof.thiago.ramos@soualasalle.com.br";
            // 
            // mtbNascimento
            // 
            this.mtbNascimento.Location = new System.Drawing.Point(154, 150);
            this.mtbNascimento.Mask = "00/00/0000";
            this.mtbNascimento.Name = "mtbNascimento";
            this.mtbNascimento.Size = new System.Drawing.Size(174, 20);
            this.mtbNascimento.TabIndex = 3;
            this.mtbNascimento.Text = "02071983";
            this.mtbNascimento.ValidatingType = typeof(System.DateTime);
            // 
            // txbNome
            // 
            this.txbNome.Location = new System.Drawing.Point(154, 102);
            this.txbNome.Name = "txbNome";
            this.txbNome.Size = new System.Drawing.Size(174, 20);
            this.txbNome.TabIndex = 2;
            this.txbNome.Text = "Thiago Gianninni Ramos";
            // 
            // mtbCPF
            // 
            this.mtbCPF.Location = new System.Drawing.Point(154, 56);
            this.mtbCPF.Mask = "000,000,000-00";
            this.mtbCPF.Name = "mtbCPF";
            this.mtbCPF.Size = new System.Drawing.Size(174, 20);
            this.mtbCPF.TabIndex = 1;
            this.mtbCPF.Text = "11111111111";
            // 
            // ptbFoto
            // 
            this.ptbFoto.Location = new System.Drawing.Point(33, 41);
            this.ptbFoto.Name = "ptbFoto";
            this.ptbFoto.Size = new System.Drawing.Size(100, 129);
            this.ptbFoto.TabIndex = 0;
            this.ptbFoto.TabStop = false;
            // 
            // FrmCadPessoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 773);
            this.ControlBox = false;
            this.Controls.Add(this.gpbDadosPrincipais);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpbDadosComplementares);
            this.Controls.Add(this.gpbEndereco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCadPessoa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastrado de Usuários";
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.gpbDadosComplementares.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gpbDadosPrincipais.ResumeLayout(false);
            this.gpbDadosPrincipais.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptbFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCidade;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.TextBox txbLogradouro;
        private System.Windows.Forms.ListBox ltbTipoEndereco;
        private System.Windows.Forms.GroupBox gpbDadosComplementares;
        private System.Windows.Forms.CheckBox chkFumante;
        private System.Windows.Forms.CheckBox chkFilhos;
        private System.Windows.Forms.CheckBox chkAnimais;
        private System.Windows.Forms.RadioButton rdbEnrolado;
        private System.Windows.Forms.RadioButton rdbCasado;
        private System.Windows.Forms.RadioButton rdbSolteiro;
        private System.Windows.Forms.RadioButton rdbOutros;
        private System.Windows.Forms.RadioButton rdbFeminino;
        private System.Windows.Forms.RadioButton rdbMasculino;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.GroupBox gpbDadosPrincipais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label v;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbProfissao;
        private System.Windows.Forms.MaskedTextBox mtbCel;
        private System.Windows.Forms.TextBox txbEmail;
        private System.Windows.Forms.MaskedTextBox mtbNascimento;
        private System.Windows.Forms.TextBox txbNome;
        private System.Windows.Forms.MaskedTextBox mtbCPF;
        private System.Windows.Forms.PictureBox ptbFoto;
    }
}
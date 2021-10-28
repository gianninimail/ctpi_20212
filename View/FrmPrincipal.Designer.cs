
namespace View
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.itbUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.itbHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.tHora = new System.Windows.Forms.Timer(this.components);
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.imArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.imAbrir = new System.Windows.Forms.ToolStripMenuItem();
            this.imSalvar = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.imSair = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barraTarefas = new System.Windows.Forms.ToolStrip();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.brBtnCadastrar = new System.Windows.Forms.ToolStripButton();
            this.brBtnListarPessoas = new System.Windows.Forms.ToolStripButton();
            this.barraStatus.SuspendLayout();
            this.menuPrincipal.SuspendLayout();
            this.barraTarefas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // barraStatus
            // 
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.itbUsuarioLogado,
            this.toolStripStatusLabel2,
            this.itbHora});
            this.barraStatus.Location = new System.Drawing.Point(0, 505);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(1060, 22);
            this.barraStatus.TabIndex = 0;
            this.barraStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel1.Text = "Usuário Logado: ";
            // 
            // itbUsuarioLogado
            // 
            this.itbUsuarioLogado.Name = "itbUsuarioLogado";
            this.itbUsuarioLogado.Size = new System.Drawing.Size(86, 17);
            this.itbUsuarioLogado.Text = "usuarioLogado";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel2.Text = "|";
            // 
            // itbHora
            // 
            this.itbHora.Name = "itbHora";
            this.itbHora.Size = new System.Drawing.Size(49, 17);
            this.itbHora.Text = "00:00:00";
            // 
            // tHora
            // 
            this.tHora.Enabled = true;
            this.tHora.Interval = 1000;
            this.tHora.Tick += new System.EventHandler(this.tHora_Tick);
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imArquivo,
            this.ajudaToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1060, 24);
            this.menuPrincipal.TabIndex = 1;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // imArquivo
            // 
            this.imArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imAbrir,
            this.imSalvar,
            this.toolStripSeparator1,
            this.imSair});
            this.imArquivo.Name = "imArquivo";
            this.imArquivo.Size = new System.Drawing.Size(61, 20);
            this.imArquivo.Text = "A&rquivo";
            // 
            // imAbrir
            // 
            this.imAbrir.Name = "imAbrir";
            this.imAbrir.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.imAbrir.Size = new System.Drawing.Size(145, 22);
            this.imAbrir.Text = "Abrir";
            // 
            // imSalvar
            // 
            this.imSalvar.Name = "imSalvar";
            this.imSalvar.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.imSalvar.Size = new System.Drawing.Size(145, 22);
            this.imSalvar.Text = "Salvar";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // imSair
            // 
            this.imSair.Name = "imSair";
            this.imSair.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.imSair.Size = new System.Drawing.Size(145, 22);
            this.imSair.Text = "Sair";
            this.imSair.Click += new System.EventHandler(this.imSair_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "&Ajuda";
            // 
            // barraTarefas
            // 
            this.barraTarefas.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraTarefas.ImageScalingSize = new System.Drawing.Size(40, 40);
            this.barraTarefas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.brBtnCadastrar,
            this.brBtnListarPessoas});
            this.barraTarefas.Location = new System.Drawing.Point(0, 24);
            this.barraTarefas.Name = "barraTarefas";
            this.barraTarefas.Size = new System.Drawing.Size(45, 481);
            this.barraTarefas.TabIndex = 2;
            this.barraTarefas.Text = "toolStrip1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::View.Properties.Resources.logo2_lasallerj;
            this.pictureBox1.Location = new System.Drawing.Point(45, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1015, 481);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // brBtnCadastrar
            // 
            this.brBtnCadastrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brBtnCadastrar.Image = global::View.Properties.Resources.user_add;
            this.brBtnCadastrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brBtnCadastrar.Name = "brBtnCadastrar";
            this.brBtnCadastrar.Size = new System.Drawing.Size(42, 44);
            this.brBtnCadastrar.Text = "Adicionar novo usuário!";
            this.brBtnCadastrar.Click += new System.EventHandler(this.brBtnCadastrar_Click);
            // 
            // brBtnListarPessoas
            // 
            this.brBtnListarPessoas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.brBtnListarPessoas.Image = global::View.Properties.Resources.user_list;
            this.brBtnListarPessoas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.brBtnListarPessoas.Name = "brBtnListarPessoas";
            this.brBtnListarPessoas.Size = new System.Drawing.Size(42, 44);
            this.brBtnListarPessoas.Text = "Listar Pessoas";
            this.brBtnListarPessoas.Click += new System.EventHandler(this.brBtnListarPessoas_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 527);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barraTarefas);
            this.Controls.Add(this.barraStatus);
            this.Controls.Add(this.menuPrincipal);
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Aplicação de Exemplo de Aula";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.barraTarefas.ResumeLayout(false);
            this.barraTarefas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.ToolStripStatusLabel itbUsuarioLogado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel itbHora;
        private System.Windows.Forms.Timer tHora;
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem imArquivo;
        private System.Windows.Forms.ToolStripMenuItem imAbrir;
        private System.Windows.Forms.ToolStripMenuItem imSalvar;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem imSair;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStrip barraTarefas;
        private System.Windows.Forms.ToolStripButton brBtnCadastrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripButton brBtnListarPessoas;
    }
}


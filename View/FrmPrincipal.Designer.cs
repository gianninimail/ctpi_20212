
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
            this.barraStatus = new System.Windows.Forms.StatusStrip();
            this.itbUsuarioLogado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.barraStatus.SuspendLayout();
            this.SuspendLayout();
            // 
            // barraStatus
            // 
            this.barraStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.itbUsuarioLogado});
            this.barraStatus.Location = new System.Drawing.Point(0, 505);
            this.barraStatus.Name = "barraStatus";
            this.barraStatus.Size = new System.Drawing.Size(1060, 22);
            this.barraStatus.TabIndex = 0;
            this.barraStatus.Text = "statusStrip1";
            // 
            // itbUsuarioLogado
            // 
            this.itbUsuarioLogado.Name = "itbUsuarioLogado";
            this.itbUsuarioLogado.Size = new System.Drawing.Size(86, 17);
            this.itbUsuarioLogado.Text = "usuarioLogado";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(96, 17);
            this.toolStripStatusLabel1.Text = "Usuário Logado: ";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 527);
            this.Controls.Add(this.barraStatus);
            this.Name = "FrmPrincipal";
            this.Text = "Aplicação de Exemplo de Aula";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.barraStatus.ResumeLayout(false);
            this.barraStatus.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip barraStatus;
        private System.Windows.Forms.ToolStripStatusLabel itbUsuarioLogado;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    }
}


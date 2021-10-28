
namespace View
{
    partial class FrmListaDePessoas
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
            this.components = new System.ComponentModel.Container();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.colCPF = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txbBusca = new System.Windows.Forms.TextBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.menuPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.miDeletar = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.menuPopup.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvDados
            // 
            this.dgvDados.AllowUserToAddRows = false;
            this.dgvDados.AllowUserToDeleteRows = false;
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCPF,
            this.colNome,
            this.colEmail});
            this.dgvDados.ContextMenuStrip = this.menuPopup;
            this.dgvDados.Location = new System.Drawing.Point(53, 71);
            this.dgvDados.MultiSelect = false;
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.ReadOnly = true;
            this.dgvDados.RowHeadersVisible = false;
            this.dgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDados.Size = new System.Drawing.Size(556, 458);
            this.dgvDados.TabIndex = 0;
            // 
            // colCPF
            // 
            this.colCPF.HeaderText = "CPF";
            this.colCPF.Name = "colCPF";
            this.colCPF.ReadOnly = true;
            this.colCPF.Width = 150;
            // 
            // colNome
            // 
            this.colNome.HeaderText = "Nome";
            this.colNome.Name = "colNome";
            this.colNome.ReadOnly = true;
            this.colNome.Width = 200;
            // 
            // colEmail
            // 
            this.colEmail.HeaderText = "E-mail";
            this.colEmail.Name = "colEmail";
            this.colEmail.ReadOnly = true;
            this.colEmail.Width = 200;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busca:";
            // 
            // txbBusca
            // 
            this.txbBusca.Location = new System.Drawing.Point(158, 34);
            this.txbBusca.Name = "txbBusca";
            this.txbBusca.Size = new System.Drawing.Size(339, 20);
            this.txbBusca.TabIndex = 2;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(534, 548);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // menuPopup
            // 
            this.menuPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miDeletar});
            this.menuPopup.Name = "menuPopup";
            this.menuPopup.Size = new System.Drawing.Size(181, 48);
            // 
            // miDeletar
            // 
            this.miDeletar.Name = "miDeletar";
            this.miDeletar.Size = new System.Drawing.Size(180, 22);
            this.miDeletar.Text = "Deletar";
            this.miDeletar.Click += new System.EventHandler(this.miDeletar_Click);
            // 
            // FrmListaDePessoas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 635);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.txbBusca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvDados);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmListaDePessoas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Lista de Pessoas Cadastradas no Mapa (Dictionary)";
            this.Load += new System.EventHandler(this.FrmListaDePessoas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.menuPopup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbBusca;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCPF;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.ContextMenuStrip menuPopup;
        private System.Windows.Forms.ToolStripMenuItem miDeletar;
    }
}
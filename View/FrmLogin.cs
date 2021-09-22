using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;

namespace View
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Usuario = txbUsuario.Text;
            user.Senha = txbSenha.Text;

            if (ValidarLogin(user))
            {
                this.DialogResult = DialogResult.OK;

                this.Tag = user;

                this.Close();
            }
            else
            {
                lblMsg.Visible = true;
            }
        }

        private bool ValidarLogin(User _user)
        {
            bool resultado = false;

            try
            {
                if (_user.Usuario.Equals("thiago") && _user.Senha.Equals("thiago"))
                {
                    resultado = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO EFETUAR LOGIN: " + ex.Message);
            }

            return resultado;
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void txbUsuario_TextChanged(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
        }

        private void txbSenha_TextChanged(object sender, EventArgs e)
        {
            lblMsg.Visible = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {
                case Keys.Enter:
                    btnLogin_Click(null, null);
                    break;
                case Keys.Escape:
                    this.Close();
                    break;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}

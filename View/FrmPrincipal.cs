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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            FrmLogin formLogin = new FrmLogin();
            this.Visible = false;
            formLogin.ShowDialog();
            this.Visible = true;

            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            FrmCadPessoa formCadPessoa = new FrmCadPessoa();

            formCadPessoa.ShowDialog();
        }
    }
}

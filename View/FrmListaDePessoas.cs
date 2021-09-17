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
    public partial class FrmListaDePessoas : Form
    {
        public FrmListaDePessoas()
        {
            InitializeComponent();
        }

        private void FrmListaDePessoas_Load(object sender, EventArgs e)
        {
            try
            {
                Dictionary<Int64, Pessoa> mapa = (Dictionary<Int64, Pessoa>)this.Tag;

                foreach (Pessoa p in mapa.Values)
                {
                    dgvDados.Rows.Add(p.CPF, p.Nome, p.Email);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR FORM: " + ex.Message);
            }
            
        }
    }
}

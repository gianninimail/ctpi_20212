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
using Control;

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
                PessoaCtrl control = new PessoaCtrl();
                Dictionary<Int64, Pessoa> mapa = (Dictionary < Int64, Pessoa>)control.BD("todos", null);

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

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miDeletar_Click(object sender, EventArgs e)
        {
            try
            {
                //Pegar CPF do DataGridView / Selecionar CPF
                //Vou ter meu CPF = Convert.ToInt64(dgvDados.Rows[0].Cells[0].Value.ToString());

                //Int64 cpfSelecionado = Convert.ToInt64(dgvDados.SelectedRows[0].Cells[0].Value.ToString());
                DataGridViewRow primeiraLinhaSelecionada = dgvDados.SelectedRows[0];
                DataGridViewCell primeiraColuna = primeiraLinhaSelecionada.Cells[0];
                Object valorDentroDaCelula = primeiraColuna.Value;

                String cpfSelecionadoString = valorDentroDaCelula.ToString();
                Int64 cpfSelecionado = Convert.ToInt64(cpfSelecionadoString);

                //Acionar o meu controller

                PessoaCtrl control = new PessoaCtrl();
                if((Boolean)control.BD("deletar", cpfSelecionado))
                {
                    MessageBox.Show("Pessoa deletada com sucesso!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO DELETAR PESSOA: " + ex.Message);
            }
        }
    }
}

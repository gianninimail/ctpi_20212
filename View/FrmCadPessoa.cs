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
    public partial class FrmCadPessoa : Form
    {
        
        public FrmCadPessoa()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            //Preenchimento do Objeto P
            //this.Tag = p;
            //this.Close();
            try
            {
                Pessoa p = CarregarObjetoPessoaDoForm();

                PessoaCtrl control = new PessoaCtrl();

                if((Boolean)control.BD("inserir", p))
                {
                    MessageBox.Show("Pessoa cadastrada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO INSERIR DADOS NO BD: " + ex.Message);
            }
        }

        private Pessoa CarregarObjetoPessoaDoForm()
        {
            Pessoa p = new Pessoa();
            try
            {
                //String cpf_sem_tracos = mtbCPF.Text.Replace("-", "");
                //String cpf_sem_pontos = cpf_sem_tracos.Replace(".", "");
                //p.CPF = Int64.Parse(cpf_sem_pontos);
                p.CPF = Convert.ToInt64(mtbCPF.Text.Replace(".", "").Replace("-", ""));
                p.Nome = txbNome.Text;
                p.Email = txbEmail.Text;
                p.Cel = mtbCel.Text;
                p.Profissão = txbProfissao.Text;
                p.Nascimento = Convert.ToDateTime(mtbNascimento.Text);

                //Contrução do Objeto Endereco
                Endereco end = new Endereco();
                end.ID = Convert.ToInt32(lblIdEnd.Text);
                end.TipoEndereco = ltbTipoEndereco.SelectedIndex;
                end.Logradouro = txbLogradouro.Text;
                end.Cidade = cmbCidade.SelectedIndex;
                end.Estado = cmbEstado.SelectedIndex;

                p.Endereco = end;

                //Sexo
                if (rdbMasculino.Checked)
                {
                    p.Sexo = "masculino";
                }
                else if (rdbFeminino.Checked)
                {
                    p.Sexo = "feminino";
                }
                else
                {
                    p.Sexo = "outros";
                }

                //Estado Civil
                if (rdbCasado.Checked)
                {
                    p.EstadoCivil = "casado";
                }
                else if (rdbSolteiro.Checked)
                {
                    p.EstadoCivil = "solteiro";
                }
                else
                {
                    p.EstadoCivil = "enrolado";
                }

                p.Filhos = chkFilhos.Checked;
                p.Animais = chkAnimais.Checked;
                p.Fumante = chkFumante.Checked;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS PARA PESSOA: " + ex.Message);
            }
            return p;
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            try
            {
                Pessoa p = CarregarObjetoPessoaDoForm();

                PessoaCtrl control = new PessoaCtrl();

                if ((Boolean)control.BD("alterar", p))
                {
                    MessageBox.Show("Pessoa alterada com sucesso!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO ALTERAR DADOS NO BD: " + ex.Message);
            }
        }

        private void FrmCadPessoa_Load(object sender, EventArgs e)
        {
            try
            {
                if (this.Tag != null)
                {
                    btnSalvar.Visible = false;
                    btnAlterar.Visible = true;
                    mtbCPF.Enabled = false;
                    this.btnAlterar.Location = new System.Drawing.Point(604, 712);

                    CarregarFormDoObjetoPessoa((Pessoa)this.Tag);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS NO BD: " + ex.Message);
            }
        }

        private void CarregarFormDoObjetoPessoa(Pessoa _pessoa)
        {
            try
            {
                mtbCPF.Text = _pessoa.CPF.ToString();
                txbNome.Text = _pessoa.Nome;
                txbEmail.Text = _pessoa.Email;
                mtbCel.Text = _pessoa.Cel;
                txbProfissao.Text = _pessoa.Profissão;
                mtbNascimento.Text = _pessoa.Nascimento.ToString();

                //Contrução do Objeto Endereco

                lblIdEnd.Text = _pessoa.Endereco.ID.ToString();
                ltbTipoEndereco.SelectedIndex = _pessoa.Endereco.TipoEndereco;
                txbLogradouro.Text = _pessoa.Endereco.Logradouro;
                cmbCidade.SelectedIndex = _pessoa.Endereco.Cidade;
                cmbEstado.SelectedIndex = _pessoa.Endereco.Estado;

                //p.Endereco = end;

                //Sexo
                if (_pessoa.Sexo == "masculino")
                {
                    rdbMasculino.Checked = true;
                }
                else if (_pessoa.Sexo.Equals("feminino"))
                {
                    rdbFeminino.Checked = true;
                }
                else
                {
                    rdbOutros.Checked = true;
                }

                //Estado Civil
                if (_pessoa.EstadoCivil == "casado")
                {
                    rdbCasado.Checked = true;
                }
                else if (_pessoa.EstadoCivil == "solteiro")
                {
                    rdbSolteiro.Checked = true;
                }
                else
                {
                    rdbEnrolado.Checked = true;
                }

                chkFilhos.Checked = _pessoa.Filhos;
                chkAnimais.Checked = _pessoa.Animais;
                chkFumante.Checked = _pessoa.Fumante;
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRO AO CARREGAR DADOS PARA PESSOA: " + ex.Message);
            }
        }
    }
}

using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class PessoaDAO
    {
        #region Métodos para manipulação de arquivos

        #endregion

        #region Métodos de acesso a Dados

        public Dictionary<Int64, Pessoa> BuscarTodos()
        {
            Dictionary<Int64, Pessoa> mapaPessoas = new Dictionary<Int64, Pessoa>();

            try
            {
                String SQL = "SELECT  " +
                    "[cpf]," +
                    "[nome]," +
                    "[email]," +
                    "[cel]," +
                    "[nascimento]," +
                    "[profissao]," +
                    "[sexo]," +
                    "[estado_civil]," +
                    "[filhos]," +
                    "[animais]," +
                    "[fumante] " +
                    "FROM [pessoas] ORDER BY cpf;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Pessoa p = new Pessoa();

                    p.CPF = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Email = data.GetString(2);
                    p.Cel = data.GetString(3);
                    p.Nascimento = data.GetDateTime(4);
                    p.Profissão = data.GetString(5);
                    p.Sexo = data.GetString(6);
                    p.EstadoCivil = data.GetString(7);
                    p.Filhos = data.GetBoolean(8);
                    p.Animais = data.GetBoolean(9);
                    p.Fumante = data.GetBoolean(10);

                    mapaPessoas.Add(p.CPF, p);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS / " + ex.Message);
            }

            return mapaPessoas;
        }

        public Pessoa BuscarPorCPF(Int64 _cpf)
        {
            Pessoa p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM pessoas WHERE cpf = {0};", _cpf);

                DataTableReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Pessoa();

                    p.CPF = data.GetInt64(0);
                    p.Nome = data.GetString(1);
                    p.Email = data.GetString(2);
                    p.Cel = data.GetString(3);
                    p.Nascimento = data.GetDateTime(4);
                    p.Profissão = data.GetString(5);
                    p.Sexo = data.GetString(6);
                    p.EstadoCivil = data.GetString(7);
                    p.Filhos = data.GetBoolean(8);
                    p.Animais = data.GetBoolean(9);
                    p.Fumante = data.GetBoolean(10);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR PELO CPF / " + ex.Message);
            }

            return p;
        }

        public Boolean Inserir(Pessoa _obj)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = String.Format("INSERT INTO pessoas (" +
                    "cpf," +
                    "nome," +
                    "email," +
                    "cel," +
                    "nascimento," +
                    "profissao," +
                    "sexo," +
                    "estado_civil," +
                    "filhos," +
                    "animais," +
                    "fumante" +
                    ") " +
                    "VALUES ({0}, '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}', '{8}', '{9}', '{10}');",
                    _obj.CPF,
                    _obj.Nome,
                    _obj.Email,
                    _obj.Cel,
                    _obj.Nascimento,
                    _obj.Profissão,
                    _obj.Sexo,
                    _obj.EstadoCivil,
                    _obj.Filhos,
                    _obj.Animais,
                    _obj.Fumante
                    );

                linhasAfetasdas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("INSERT / " + ex.Message);
            }

            if (linhasAfetasdas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean Deletar(Int64 _cpf)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = "DELETE FROM pessoas WHERE cpf = " + _cpf;

                linhasAfetasdas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("DELETE / " + ex.Message);
            }

            if (linhasAfetasdas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Boolean Alterar(Pessoa _obj)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = String.Format("UPDATE pessoas SET " +
                    "nome = '{0}'," +
                    "email = {1}," +
                    "cel = '{2}'," +
                    "nascimento = '{3}'," +
                    "profissao = '{4}', " +
                    "sexo = '{5}', " +
                    "estado_civil = '{6}'," +
                    "filhos = '{7}'," +
                    "animais = '{8}'," +
                    "fumante = '{9}'" +
                    " WHERE cpf = {10}",
                    _obj.Nome,
                    _obj.Email,
                    _obj.Cel,
                    _obj.Nascimento,
                    _obj.Profissão,
                    _obj.Sexo,
                    _obj.EstadoCivil,
                    _obj.Filhos,
                    _obj.Animais,
                    _obj.Fumante,
                    _obj.CPF
                    );

                linhasAfetasdas = BD.ExecutarIDU(SQL);
            }
            catch (Exception ex)
            {
                throw new Exception("UPDATE / " + ex.Message);
            }

            if (linhasAfetasdas > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
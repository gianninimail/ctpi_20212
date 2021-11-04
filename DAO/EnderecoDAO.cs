using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data.SqlServerCe;
using System.Data;

namespace DAO
{
    public class EnderecoDAO
    {
        public Endereco BuscarPorID(int _idEndereco)
        {
            Endereco p = null;
            try
            {
                String SQL = String.Format("SELECT * FROM enderecos WHERE id = {0};", _idEndereco);

                DataTableReader data = BD.ExecutarSelect(SQL);

                if (data.Read())
                {
                    p = new Endereco();

                    p.ID = data.GetInt32(0);
                    p.TipoEndereco = data.GetInt32(1);
                    p.Logradouro = data.GetString(2);
                    p.Cidade = data.GetInt32(3);
                    p.Estado = data.GetInt32(4);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR POR ID / " + ex.Message);
            }

            return p;
        }

        public int Inserir(Endereco _obj)
        {
            int idEnd = 0;

            try
            {
                String SQL = String.Format("INSERT INTO enderecos (" +
                    "tipo_end," +
                    "logradouro," +
                    "cidade_id," +
                    "estado_id" +
                    ") " +
                    "VALUES ({0}, '{1}', {2}, {3});",
                    _obj.TipoEndereco,
                    _obj.Logradouro,
                    _obj.Cidade,
                    _obj.Estado
                    );


                Object teste = BD.ExecutarInsertComRetornoDeValor(SQL, new List<SqlCeParameter>());
                idEnd = Convert.ToInt32(teste);
            }
            catch (Exception ex)
            {
                throw new Exception("INSERT / " + ex.Message);
            }

            return idEnd;
        }

        public Boolean Alterar(Endereco _obj)
        {
            int linhasAfetasdas = 0;

            try
            {
                String SQL = String.Format("UPDATE enderecos SET " +
                    "tipo_end = {0}," +
                    "logradouro = '{1}'," +
                    "cidade_id = {2}," +
                    "estado_id = {3}" +
                    " WHERE id = {4}",
                    _obj.TipoEndereco,
                    _obj.Logradouro,
                    _obj.Cidade,
                    _obj.Estado,
                    _obj.ID
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
    }
}
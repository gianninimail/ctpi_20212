using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace DAO
{
    public class EstadoDAO
    {
        public List<Estado> BuscarTodos()
        {
            List<Estado> listaEstados = new List<Estado>();

            try
            {
                String SQL = "SELECT * FROM estados ORDER BY descricao;";

                DataTableReader data = BD.ExecutarSelect(SQL);

                while (data.Read())
                {
                    Estado e = new Estado();

                    e.ID = data.GetInt32(0);
                    e.Descricao = data.GetString(1);


                    CidadeDAO cidadeDAO = new CidadeDAO();
                    e.Cidades = cidadeDAO.BuscarTodasPorEstadoID(e.ID);

                    listaEstados.Add(e);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("BUSCAR TODOS / " + ex.Message);
            }

            return listaEstados;
        }
    }
}

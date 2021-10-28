using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAO;

namespace Control
{
    public class PessoaCtrl
    {
        public Object BD(string _comando, Object _parametro)
        {
            PessoaDAO dao = new PessoaDAO();

            switch (_comando)
            {
                case "inserir":
                    return dao.Inserir((Pessoa)_parametro);
                case "deletar":
                    return dao.Deletar((Int64)_parametro);
                case "alterar":
                    return dao.Alterar((Pessoa)_parametro);
                case "todos":
                    return dao.BuscarTodos();
                case "pessoa":
                    return dao.BuscarPorCPF((Int64)_parametro);
                case "filtro":
                    //return dao.BuscarListaFiltrada(_parametro.ToString());
                default:
                    return "Comando inválido!";
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
//using PedidosWeb.Controller.Validacao;
//using PedidosWeb.CustomException;

namespace PedidosWeb.Models
{
    public class Categoria
    {
        private int _id;
        private string _nome;
        private List<Produto> _produtos;

        public Categoria()
        {

        }

        public Categoria(int id, string nome, List<Produto> produtos)
        {
            _id = id;
            //Validacoes.ValidaNome(this, nome, 20);
            _nome = nome;
            _produtos = produtos;
        }

        private int geraIdProduto()
        {
            int newId;

            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["categoriaConnection"].ConnectionString))
            {
                newId = db.Query<int>(
                    "SELECT MAX(c.id) + 1 " +
                    "FROM   loja.dbo.categoria c ").SingleOrDefault();
            }

            return newId;
        }

        public int Id
        {
            get
            {
                return _id;
            }

            set
            {

                _id = value;
            }

        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }

        public List<Produto> Produtos
        {
            get
            {
                return _produtos;
            }

            set
            {
                _produtos = value;
            }

        }
    }
}

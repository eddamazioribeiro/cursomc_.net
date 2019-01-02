using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.Controller.Validacao;
using Pedidos.CustomException;

namespace Pedidos.Model
{
    class Categoria
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

            Validacoes.ValidaNome(this, nome, 20);
            _nome = nome;
            _produtos = produtos;
        }

        public int Id
        {
            get
            {
                return _id;
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

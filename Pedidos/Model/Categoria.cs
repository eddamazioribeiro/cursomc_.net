using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.CustomException;

namespace Pedidos.Model
{
    partial class Categoria
    {
        private int _id;

        public int Id
        {
            get
            {
                return _id;
            }
        }

        private string _nome;

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

        private List<Produto> _produtos;

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

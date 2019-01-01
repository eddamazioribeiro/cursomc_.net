using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Model
{
    partial class Produto
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

        private double _preco;

        public double Preco
        {
            get
            {
                return _preco;
            }
            set
            {
                _preco = value;
            }
        }

        private List<Categoria> _categorias;

        public List<Categoria> Categorias
        {
            get
            {
                return _categorias;
            }
            set
            {
                _categorias = value;
            }
        }


    }
}

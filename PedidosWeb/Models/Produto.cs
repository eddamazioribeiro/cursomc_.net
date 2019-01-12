//using PedidosWeb.Controller.Validacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedidosWeb.Models
{
    public class Produto
    {
        private int _id;
        private string _nome;
        private double _preco;
        private List<Categoria> _categorias;

        public Produto()
        {

        }

        public Produto(int id, string nome, double preco, List<Categoria> categorias)
        {
            _id = id;
            //Validacoes.ValidaNome(this, nome, 50);
            _nome = nome;
            _preco = preco;
            _categorias = categorias;
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

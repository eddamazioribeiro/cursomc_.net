using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.Controller.Validacao;

namespace Pedidos.Model
{
    partial class Produto
    {
        public Produto()
        {

        }

        public Produto(int id, string nome, double preco, List<Categoria> categorias)
        {
            _id = id;
            Validacoes.ValidaNome(this, nome, 50);
            _nome = nome;
            _preco = preco;
            _categorias = categorias;
        }

    }
}

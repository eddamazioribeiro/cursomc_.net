using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.Controller.Validacao;

namespace Pedidos.Model
{
    partial class Categoria
    {
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
   
    }
}

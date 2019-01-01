using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Model
{
    partial class Cidade
    {
        public Cidade()
        {

        }

        public Cidade(int id, string nome, Estado estado)
        {
            _id = id;
            _nome = nome;
            _estado = estado;
        }

    }
}

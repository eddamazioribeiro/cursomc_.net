using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Model
{
    partial class Estado
    {
        public Estado()
        {

        }

        public Estado(int id, string nome, string sigla)
        {
            _id = id;
            _nome = nome;
            _sigla = sigla;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Model
{
    partial class Estado
    {
        private int _id;
        private string _nome;
        private string _sigla;

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

        public string Sigla
        {
            get
            {
                return _sigla;
            }

            set
            {
                _sigla = value;
            }
        }


    }
}

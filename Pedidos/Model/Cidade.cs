using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Model
{
    partial class Cidade
    {
        private int _id;
        private string _nome;
        private Estado _estado;

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

        public Estado Estado
        {
            get
            {
                return _estado;
            }

            set
            {
                _estado = value;
            }
        }

    }
}

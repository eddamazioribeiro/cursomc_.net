using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class Estado
    {
        private int _id;
        private string _nome;
        private string _sigla;

        public Estado()
        {

        }

        public Estado(int id, string nome, string sigla)
        {
            _id = id;
            _nome = nome;
            _sigla = sigla;
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

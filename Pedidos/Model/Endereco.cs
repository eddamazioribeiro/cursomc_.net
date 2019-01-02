using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Model
{
    partial class Endereco
    {
        private int _id;
        private string _logradouro;
        private int _numero;
        private string _complemento;
        private string _cep;
        private Cidade _cidade;

        public Endereco()
        {

        }

        public Endereco(int id, string logradouro, int numero, string complemento, string cep, Cidade cidade)
        {
            _id = id;
            _logradouro = logradouro;
            _numero = numero;
            _complemento = complemento;
            _cep = cep;
            _cidade = cidade;
        }

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

        public string Logradouro
        {
            get
            {
                return _logradouro;
            }

            set
            {
                _logradouro = value;
            }
        }

        public int Numero
        {
            get
            {
                return _numero;
            }

            set
            {
                _numero = value;
            }
        }

        public string Complemento
        {
            get
            {
                return _complemento;
            }

            set
            {
                _complemento = value;
            }
        }

        public string CEP
        {
            get
            {
                return _cep;
            }

            set
            {
                _cep = value;
            }
        }

        public Cidade Cidade
        {
            get
            {
                return _cidade;
            }

            set
            {
                _cidade = value;
            }
        }
    }
}

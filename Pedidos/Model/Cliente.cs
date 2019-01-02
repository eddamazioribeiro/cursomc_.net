using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.Model.Enum;

namespace Pedidos.Model
{
    partial class Cliente
    {
        private int _id;
        private string _nome;
        private string _email;
        private string _cpfCnpj;
        private int _tipoCliente;
        private List<string> _telefones;
        private List<Endereco> _enderecos;

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

        public string Email
        {
            get
            {
                return _email;
            }

            set
            {
                _email = value;
            }
        }

        public string CpfCnpj
        {
            get
            {
                return _cpfCnpj;
            }

            set
            {
                _cpfCnpj = value;
            }
        }

        public int TipoCliente
        {
            get
            {
                return _tipoCliente;
            }

            set
            {
                _tipoCliente = value;
            }
        }

        public List<string> Telefones
        {
            get
            {
                return _telefones;
            }

            set
            {
                _telefones = value;
            }

        }

        public List<Endereco> Enderecos
        {
            get
            {
                return _enderecos;
            }

            set
            {
                _enderecos = value;
            }
        }
    }
}

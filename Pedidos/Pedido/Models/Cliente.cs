using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.Models.Enum;

namespace Pedidos.Models
{
    public class Cliente
    {
        private int _id;
        private string _nome;
        private string _email;
        private string _cpfCnpj;
        private int _tipoCliente;
        private List<string> _telefones;
        private List<Endereco> _enderecos;
        private List<Pedido> _pedidos;

        public Cliente()
        {

        }

        public Cliente(int id, string nome, string email, string cpfCnpj, TipoCliente tipoCliente,
            List<string> telefones, List<Endereco> enderecos)
        {
            _id = id;
            _nome = nome;
            _email = email;
            _cpfCnpj = cpfCnpj;
            _tipoCliente = tipoCliente.GetHashCode();
            _telefones = telefones;
            _enderecos = enderecos;
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

        public List<Pedido> Pedidos
        {
            get
            {
                return _pedidos;
            }

            set
            {
                _pedidos = value;
            }
        }
    }
}

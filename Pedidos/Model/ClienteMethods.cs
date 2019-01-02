using Pedidos.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Model
{
    partial class Cliente
    {
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
    }
}

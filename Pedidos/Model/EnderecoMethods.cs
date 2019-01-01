using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Model
{
    partial class Endereco
    {
        public Endereco()
        {

        }

        public Endereco(int id, string logradouro, int numero, string complemento, int cep, Cidade cidade)
        {
            _id = id;
            _logradouro = logradouro;
            _numero = numero;
            _complemento = complemento;
            _cep = cep;
            _cidade = cidade;
        }
    }
}

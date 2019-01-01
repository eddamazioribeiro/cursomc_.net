using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.CustomException;

namespace Pedidos.Controller.Validacao
{
    class Validacoes
    {
        public static void ValidaNome(Object objeto, string nome, int tamanhoMax)
        {

            if (nome.Length == 0 || nome == null)
            {
                throw new ValidacaoException("A nome do/a " + objeto.GetType() + " não pode ser nulo! Verifique.");

            }
            else if (nome.Length > tamanhoMax)
            {
                throw new ValidacaoException("A nome do/a " + objeto.GetType() + " deve ter no máximo " + tamanhoMax + " caracteres! Verifique.");
            }

        }
    }
}

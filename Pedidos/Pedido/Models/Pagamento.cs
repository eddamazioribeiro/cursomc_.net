using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.Models.Enum;

namespace Pedidos.Models
{
    public class Pagamento
    {
        private int _id;
        private SituacaoPagamento _situacao;

        public Pagamento()
        {

        }

        public Pagamento(int id, SituacaoPagamento situacao)
        {
            _id = id;
            _situacao = situacao;
        }

        public int Id
        {
            get
            {
                return _id;
            }

        }

        public SituacaoPagamento Situacao
        {
            get
            {
                return _situacao;
            }

            set
            {
                _situacao = value;
            }
        }

    }
}

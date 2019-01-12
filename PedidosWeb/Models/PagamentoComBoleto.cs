using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedidosWeb.Models.Enum;

namespace PedidosWeb.Models
{
    public class PagamentoComBoleto : Pagamento
    {
        private DateTime _dataVencimento;
        private DateTime ? _dataPagamento;

        public PagamentoComBoleto()
        {

        }

        public PagamentoComBoleto(int id, SituacaoPagamento situacao, DateTime dataVencimento, DateTime? dataPagamento)
            : base(id, situacao)
        {
            _dataVencimento = dataVencimento;
            _dataPagamento = dataPagamento;
        }

        public DateTime DataVencimento
        {
            get
            {
                return _dataVencimento;
            }

            set
            {
                _dataVencimento = value;
            }
        }

        public DateTime DataPagamento
        {
            get
            {
                return _dataPagamento.Value;
                //if (_dataPagamento.Value == null)
                //{
                //    return DateTime.Now;
                //}
                //else
                //{
                //    return _dataPagamento.Value;
                //}
            }

            set
            {
                if (value != null)
                {
                    _dataPagamento = value;
                }
            }
        }

    }
}

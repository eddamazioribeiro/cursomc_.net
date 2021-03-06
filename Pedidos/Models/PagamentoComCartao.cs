﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PedidosWeb.Models.Enum;

namespace PedidosWeb.Models
{
    public class PagamentoComCartao : Pagamento
    {
        private int _nroParcelas;

        public PagamentoComCartao()
        {

        }

        public PagamentoComCartao(int id, SituacaoPagamento situacao, int nroParcelas)
            : base(id, situacao)
        {
            _nroParcelas = nroParcelas;
        }

        public int NroParcelas
        {
            get
            {
                return _nroParcelas;
            }

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Models
{
    public class ItemPedido
    {
        private Pedido _pedido;
        private Produto _produto;
        private int _quantidade;
        private double _valorTotalItem;
        private double _desconto;

        public ItemPedido()
        {

        }

        public ItemPedido(Pedido pedido, Produto produto, int quantidade, double valorTotalItem, double desconto)
        {
            _pedido = pedido;
            _produto = produto;
            _quantidade = quantidade;
            _valorTotalItem = valorTotalItem;
            _desconto = desconto;
        }

        public Pedido Pedido
        {
            get
            {
                return _pedido;
            }

            set
            {
                _pedido = value;
            }
        }

        public Produto Produto
        {
            get
            {
                return _produto;
            }

            set
            {
                _produto = value;
            }
        }

        public int Quantidade
        {
            get
            {
                return _quantidade;
            }

            set
            {
                _quantidade = value;
            }
        }

        public double ValorTotalItem
        {
            get
            {
                return _valorTotalItem;
            }

            set
            {
                _valorTotalItem = value;
            }
        }

        public double Desconto
        {
            get
            {
                return _desconto;
            }

            set
            {
                _desconto = value;
            }

        }

    }
}

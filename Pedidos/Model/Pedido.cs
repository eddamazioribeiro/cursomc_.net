using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Model
{
    class Pedido
    {
        private int _id;
        private DateTime _instanteFechamento;
        private Pagamento _formaDePagamento;
        private Cliente _cliente;
        private Endereco _enderecoEntrega;
        private List<ItemPedido> _itensPedido;

        public Pedido()
        {

        }

        public Pedido(int id, DateTime instanteFechamento, Pagamento formaDePagamento, 
            Cliente cliente, Endereco enderecoEntrega, List<ItemPedido> itensPedido)
        {
            _id = id;
            _instanteFechamento = instanteFechamento;
            _formaDePagamento = formaDePagamento;
            _cliente = cliente;
            _enderecoEntrega = enderecoEntrega;
            _itensPedido = itensPedido;
        }

        public int Id
        {
            get
            {
                return _id;
            }

        }

        public DateTime InstanteFechamento
        {
            get
            {
                return _instanteFechamento;
            }
        }

        public Pagamento FormaDePagamento
        {
            get
            {
                return _formaDePagamento;
            }

            set
            {
                _formaDePagamento = value;
            }
        }

        public Cliente Cliente
        {
            get
            {
                return _cliente;
            }
        }

        public Endereco EnderecoEntrega
        {
            get
            {
                return _enderecoEntrega;
            }
        }

        public List<ItemPedido> ItensPedido
        {
            get
            {
                return _itensPedido;
            }

            set
            {
                _itensPedido = value;
            }
        }

    }
}

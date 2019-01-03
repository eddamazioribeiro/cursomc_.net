using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.Model;
using Pedidos.Model.Enum;

namespace Pedidos
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            // Categorias
            Categoria cat1 = new Categoria(1, "Informática", null);
            Categoria cat2 = new Categoria(2, "Escritório", null);

            // Produtos
            Produto prod1 = new Produto(1, "Computador", 2000, null);
            Produto prod2 = new Produto(2, "Impressora", 800, null);
            Produto prod3 = new Produto(3, "Mouse", 70, null);

            // Associa Produto - Categoria
            List<Produto> produtos1 = new List<Produto>();
            produtos1.Add(prod1);
            produtos1.Add(prod2);
            produtos1.Add(prod3);

            List<Produto> produtos2 = new List<Produto>();
            produtos2.Add(prod2);

            cat1.Produtos = produtos1;
            cat2.Produtos = produtos2;

            // Associa Categoria - Produto
            List<Categoria> catProd1 = new List<Categoria>();
            List<Categoria> catProd2 = new List<Categoria>();
            List<Categoria> catProd3 = new List<Categoria>();

            catProd1.Add(cat1);
            catProd2.Add(cat1);
            catProd2.Add(cat2);
            catProd3.Add(cat1);

            prod1.Categorias = catProd1;
            prod2.Categorias = catProd2;
            prod3.Categorias = catProd3;

            // Estados
            Estado est1 = new Estado(1, "Minas Gerais", "MG");
            Estado est2 = new Estado(2, "São Paulo", "SP");

            // Cidades
            Cidade cid1 = new Cidade(1, "Uberlândia", est1);
            Cidade cid2 = new Cidade(1, "Mococa", est2);

            // Endereços
            Endereco end1 = new Endereco(1, "Rua das Flores", 300, "Apto. 31", "13730-000", cid1);
            Endereco end2 = new Endereco(2, "Rua Maestro Paschoal Gagliardi", 444, null, "13734-400", cid2);

            // Cliente
            List<string> telefones = new List<string>();
            telefones.Add("(19)993601202");

            List<Endereco> enderecos = new List<Endereco>();
            enderecos.Add(end1);
            enderecos.Add(end2);

            Cliente cli1 = new Cliente(1, "Eduardo Ribeiro", "ed.damazioribeiro@gmail.com", "414.887.248-81", TipoCliente.PESSOA_FISICA,
                telefones, enderecos);

            // Pedido, Pagamento, Itens do Pedido
            // Pedido 1
            DateTime dataPedido1 = new DateTime(2019, 1, 2, 8, 00, 06);
            PagamentoComCartao pagPed1 = new PagamentoComCartao(1, SituacaoPagamento.QUITADO, 6);
            Pedido ped1 = new Pedido(1, dataPedido1, pagPed1, cli1, end1, null);
            ItemPedido itemPedido1A = new ItemPedido(ped1, prod1, 2, (prod1.Preco * 2), 0);
            ItemPedido itemPedido1B = new ItemPedido(ped1, prod2, 3, (prod1.Preco * 3), 20);

            List<ItemPedido> itensPedido1 = new List<ItemPedido>();
            itensPedido1.Add(itemPedido1A);
            itensPedido1.Add(itemPedido1B);

            ped1.ItensPedido = itensPedido1;

            // Pedido 2
            DateTime dataPedido2 = new DateTime(2018, 12, 30, 10, 30, 00);
            DateTime dataVencPedido2 = new DateTime(2019, 1, 5, 10, 30, 00);
            PagamentoComBoleto pagPed2 = new PagamentoComBoleto(2, SituacaoPagamento.PENDENTE, dataPedido2, null);
            Pedido ped2 = new Pedido(1, dataPedido2, pagPed2, cli1, end2, null);
            ItemPedido itemPedido2A = new ItemPedido(ped2, prod3, 3, (prod1.Preco * 3), 0);

            List<ItemPedido> itensPedido2 = new List<ItemPedido>();
            itensPedido2.Add(itemPedido2A);

            ped2.ItensPedido = itensPedido2;

        }
    }
}

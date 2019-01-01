using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.Model;

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

            // Associa Categoria - Produto
            List<Produto> produtos1 = new List<Produto>();
            produtos1.Add(prod1);
            produtos1.Add(prod2);
            produtos1.Add(prod3);

            List<Produto> produtos2 = new List<Produto>();
            produtos2.Add(prod2);

            cat1.Produtos = produtos1;
            cat2.Produtos = produtos2;

            // Lista Caterogias e seus Produtos
            List<Categoria> categorias = new List<Categoria>();
            categorias.Add(cat1);
            categorias.Add(cat2);

            foreach(Categoria cat in categorias)
            {
                Console.WriteLine(cat.Id + " - " + cat.Nome + "\nProdutos");
                foreach (Produto prod in cat.Produtos)
                {
                    Console.WriteLine("-- " + prod.Id + " - " + prod.Nome + " - Preço: " + prod.Preco);
                }

            }

        }
    }
}

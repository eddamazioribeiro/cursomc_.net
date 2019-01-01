﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pedidos.Model
{
    partial class Produto
    {
        private int _id;
        private string _nome;
        private double _preco;
        private List<Categoria> _categorias;

        public int Id
        {
            get
            {
                return _id;
            }
            
        }

        public string Nome
        {
            get
            {
                return _nome;
            }
            set
            {
                _nome = value;
            }
        }


        public double Preco
        {
            get
            {
                return _preco;
            }
            set
            {
                _preco = value;
            }
        }

        public List<Categoria> Categorias
        {
            get
            {
                return _categorias;
            }
            set
            {
                _categorias = value;
            }
        }
    }
}

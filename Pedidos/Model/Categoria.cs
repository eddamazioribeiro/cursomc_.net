﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pedidos.CustomException;

namespace Pedidos.Model
{
    partial class Categoria
    {
        private int _id;
        private string _nome;
        private List<Produto> _produtos;

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

        public List<Produto> Produtos
        {
            get
            {
                return _produtos;
            }

            set
            {
                _produtos = value;
            }

        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermercadoGrandao
{
    public class Gerente : Funcionario
    {
        public Gerente(string nome, string email, string senha) : base(nome, email, senha)
        {

        }

        public override void removerProduto(int indice, Carrinho carrinho)
        {
            carrinho.removerProduto(indice);
        }

    }
}

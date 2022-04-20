using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermercadoGrandao
{
    abstract public class Produto
    {
        public string NomeProduto { get; private set; }
        public double Valor { get; private set; }

        public Produto(string nome, double valor)
        {
            this.NomeProduto = nome;
            this.Valor = valor;
        }

        public virtual double total()
        {
            return this.Valor;
        }
    }
}

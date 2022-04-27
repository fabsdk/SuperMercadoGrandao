using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermercadoGrandao
{
    public class ProdutoPeso :  Produto
    {
        public double Peso { get; private set; }

        public ProdutoPeso(string nomeProduto, double valor, double peso) : base(nomeProduto, valor)
        {
            this.Peso = peso;
        }

        public override double total()
        {
            return this.Valor * this.Peso;
        }
    }
}

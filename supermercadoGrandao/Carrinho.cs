using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermercadoGrandao
{
    public class Carrinho
    {
        public List<Produto> listaProdutos = new List<Produto>();
        public void adicionarProduto(Produto produto)
        {
            listaProdutos.Add(produto);
        }

        public void removerProduto(int indice)
        {
            listaProdutos.RemoveAt(indice);
        }

        public double total()
        {
            double total = 0;
            foreach(Produto produto in listaProdutos)
            {
                total += produto.total();
            }
            return total;
        }

        public void fecharPedido()
        {
            listaProdutos.Clear();
        }


    }
}

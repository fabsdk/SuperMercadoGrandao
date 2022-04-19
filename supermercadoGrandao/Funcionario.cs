using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace supermercadoGrandao
{
    public class Funcionario
    {
        public string Nome {get; private set;}
        public string Email { get; private set;}
        private string Senha { get; set; }

        public Funcionario( string nome, string email, string senha)
        {
            this.Nome = nome;
            this.Email = email;
            this.Senha = senha;
        }

        public bool SenhaCorreta(string senha)
        {
            return this.Senha.Equals(senha);
        }

        public void adicionarProduto(Produto produto, Carrinho carrinho)
        {
            carrinho.adicionarProduto(produto);
        }

        public virtual void removerProduto(int indice, Carrinho carrinho)
        {
            System.Windows.Forms.MessageBox.Show("Você não pode realizar essa função, por favor chame o gerente!", "Atenção", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
        }

        public double fecharCompra(Carrinho carrinho)
        {
            return carrinho.total();
        }

        public void receberPagamento(Carrinho carrinho, double dinheiro)
        {
            double troco = 0;
            double total = this.fecharCompra(carrinho);
            if (dinheiro >= total)
            {
                troco = dinheiro - total;
                System.Windows.Forms.MessageBox.Show("O seu troco é de " + troco.ToString(), "Troco", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                carrinho.fecharPedido();
                return;
            }
            System.Windows.Forms.MessageBox.Show("Ainda falta dinheiro, você tem que me pagar o valor da conta inteira");
        }
    }
}

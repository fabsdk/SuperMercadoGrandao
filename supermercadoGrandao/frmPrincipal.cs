using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace supermercadoGrandao
{
    public partial class frmPrincipal : Form
    {
        Funcionario funcionarioAtual { get; set; }
        List<Funcionario> listaDeFuncionarios = new List<Funcionario>();

        Carrinho carrinho = new Carrinho();
        List<Produto> listaDeProdutosDisponiveis = new List<Produto>();

        public frmPrincipal()
        {
            InitializeComponent();

            //produtos
            listaDeProdutosDisponiveis.Add(new ProdutoUnidade("Coca-Cola 2L", 8.00));
            listaDeProdutosDisponiveis.Add(new ProdutoPeso("Picanha", 98.00, 0.00));
            listaDeProdutosDisponiveis.Add(new ProdutoUnidade("Pão de alho poró 4un", 20.00));


            //funcionarios
            listaDeFuncionarios.Add(new Caixa("Tiago Claro", "tiagoclaro@hotmail.com", "1234"));
            listaDeFuncionarios.Add(new Gerente("Abenza","abenza@hotmail.com", "1234"));

        }

       public void AtualizarTela()
        {
            lblFuncionario.Text = funcionarioAtual.Nome;
        }


        public bool Login()
        {
            while (funcionarioAtual == null)
            {
                frmLogin login = new frmLogin();
                login.ShowDialog();
                foreach (Funcionario Funcionario in listaDeFuncionarios)
                {
                    if (Funcionario.Email == login.Email && Funcionario.SenhaCorreta(login.Senha))
                    {
                        funcionarioAtual = Funcionario; 
                        AtualizarTela();
                        return true;
                    }
                }
            }
            return false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Login();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            funcionarioAtual = null;
            this.Login();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            while(listaDeProdutosDisponiveis == null)
            {
                foreach(Produto produto in listaDeProdutosDisponiveis)
                {
                   
                }
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            funcionarioAtual.removerProduto(lstProdutos.SelectedIndex, carrinho);
            AtualizarTela();
        }

        private void btnReceber_Click(object sender, EventArgs e)
        {
            frmReceber receber = new frmReceber();
            receber.ShowDialog();
        }
    }
}
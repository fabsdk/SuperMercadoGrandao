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
    public partial class frmLogin : Form
    {
        public string Email { get; private set; }
        public string Senha { get; private set; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Email = txtEmail.Text;
            this.Senha = txtSenha.Text;
            this.Close();
        }


    }
}

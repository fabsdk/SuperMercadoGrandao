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
    public partial class frmReceber : Form
    {
        public double dinheiro { get; private set; }
        public frmReceber()
        {
            InitializeComponent();
        }

        

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
         
        }
    }
}

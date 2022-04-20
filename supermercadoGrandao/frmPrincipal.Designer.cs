namespace supermercadoGrandao
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblFuncionario = new System.Windows.Forms.Label();
            this.lstProdutos = new System.Windows.Forms.ListBox();
            this.txtProdutos = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblKilo = new System.Windows.Forms.Label();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnReceber = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitulo.Location = new System.Drawing.Point(209, 14);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(494, 37);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Seja bem-vindo(a) ao GRANDÃO";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Red;
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(9, 6);
            this.btnSair.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(61, 29);
            this.btnSair.TabIndex = 1;
            this.btnSair.Text = "SAIR";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 37);
            this.lbl1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(65, 13);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Funcionário:";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.Location = new System.Drawing.Point(13, 52);
            this.lblFuncionario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(0, 13);
            this.lblFuncionario.TabIndex = 3;
            // 
            // lstProdutos
            // 
            this.lstProdutos.BackColor = System.Drawing.Color.LemonChiffon;
            this.lstProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstProdutos.FormattingEnabled = true;
            this.lstProdutos.ItemHeight = 31;
            this.lstProdutos.Location = new System.Drawing.Point(8, 68);
            this.lstProdutos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstProdutos.Name = "lstProdutos";
            this.lstProdutos.Size = new System.Drawing.Size(803, 221);
            this.lstProdutos.TabIndex = 4;
            // 
            // txtProdutos
            // 
            this.txtProdutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProdutos.Location = new System.Drawing.Point(121, 318);
            this.txtProdutos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtProdutos.Name = "txtProdutos";
            this.txtProdutos.Size = new System.Drawing.Size(423, 38);
            this.txtProdutos.TabIndex = 5;
            // 
            // lblProduto
            // 
            this.lblProduto.AutoSize = true;
            this.lblProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduto.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblProduto.Location = new System.Drawing.Point(8, 321);
            this.lblProduto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(109, 31);
            this.lblProduto.TabIndex = 6;
            this.lblProduto.Text = "Produto";
            // 
            // lblKilo
            // 
            this.lblKilo.AutoSize = true;
            this.lblKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKilo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblKilo.Location = new System.Drawing.Point(557, 321);
            this.lblKilo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKilo.Name = "lblKilo";
            this.lblKilo.Size = new System.Drawing.Size(53, 31);
            this.lblKilo.TabIndex = 7;
            this.lblKilo.Text = "KG";
            // 
            // txtKilo
            // 
            this.txtKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKilo.Location = new System.Drawing.Point(617, 318);
            this.txtKilo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKilo.Name = "txtKilo";
            this.txtKilo.Size = new System.Drawing.Size(188, 38);
            this.txtKilo.TabIndex = 8;
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackColor = System.Drawing.Color.Gold;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.Location = new System.Drawing.Point(139, 371);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(111, 44);
            this.btnAdicionar.TabIndex = 9;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = false;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Gold;
            this.btnRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemover.Location = new System.Drawing.Point(261, 371);
            this.btnRemover.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(111, 44);
            this.btnRemover.TabIndex = 10;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(637, 385);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Total";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblTotal.Location = new System.Drawing.Point(713, 385);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(75, 31);
            this.lblTotal.TabIndex = 12;
            this.lblTotal.Text = "Total";
            // 
            // btnReceber
            // 
            this.btnReceber.BackColor = System.Drawing.Color.Gold;
            this.btnReceber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReceber.Location = new System.Drawing.Point(383, 371);
            this.btnReceber.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReceber.Name = "btnReceber";
            this.btnReceber.Size = new System.Drawing.Size(111, 44);
            this.btnReceber.TabIndex = 13;
            this.btnReceber.Text = "Receber";
            this.btnReceber.UseVisualStyleBackColor = false;
            this.btnReceber.Click += new System.EventHandler(this.btnReceber_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::supermercadoGrandao.Properties.Resources.caixaFundo;
            this.ClientSize = new System.Drawing.Size(825, 440);
            this.Controls.Add(this.btnReceber);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtKilo);
            this.Controls.Add(this.lblKilo);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.txtProdutos);
            this.Controls.Add(this.lstProdutos);
            this.Controls.Add(this.lblFuncionario);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmPrincipal";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblFuncionario;
        private System.Windows.Forms.ListBox lstProdutos;
        private System.Windows.Forms.TextBox txtProdutos;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnReceber;
    }
}


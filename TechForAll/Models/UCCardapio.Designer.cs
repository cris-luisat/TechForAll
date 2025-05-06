namespace TechForAll.Models
{
    partial class UCCardapio
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

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCardapio));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            lblProduto = new Label();
            pictureBox1 = new PictureBox();
            btnAddCarrinho = new TechForAll.CustomButtom.Botao();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Wheat;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1163, 512);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(btnAddCarrinho);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblProduto);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Location = new Point(100, 76);
            panel2.Name = "panel2";
            panel2.Size = new Size(960, 299);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Location = new Point(352, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(566, 188);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ItalicT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(821, 253);
            label1.Name = "label1";
            label1.Size = new Size(50, 32);
            label1.TabIndex = 1;
            label1.Text = "R$";
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("ItalicT", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduto.Location = new Point(389, 9);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(152, 37);
            lblProduto.TabIndex = 2;
            lblProduto.Text = "Pizza de";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 264);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // btnAddCarrinho
            // 
            btnAddCarrinho.BackColor = Color.ForestGreen;
            btnAddCarrinho.FlatAppearance.BorderSize = 0;
            btnAddCarrinho.FlatStyle = FlatStyle.Flat;
            btnAddCarrinho.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAddCarrinho.ForeColor = Color.White;
            btnAddCarrinho.Location = new Point(352, 245);
            btnAddCarrinho.Name = "btnAddCarrinho";
            btnAddCarrinho.Size = new Size(52, 40);
            btnAddCarrinho.TabIndex = 4;
            btnAddCarrinho.Text = "\U0001f6d2";
            btnAddCarrinho.UseVisualStyleBackColor = false;
            // 
            // UCCardapio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UCCardapio";
            Size = new Size(1163, 512);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private CustomButtom.Botao btnAddCarrinho;
        private PictureBox pictureBox1;
        private Label lblProduto;
        private Label label1;
        private Panel panel3;
    }
}

namespace TechForAll.Models
{
    partial class UCProdutoCarrinho
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
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            lblProduto = new Label();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(lblProduto);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(816, 299);
            panel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(21, 21);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(315, 264);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduto.Location = new Point(389, 9);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(104, 29);
            lblProduto.TabIndex = 2;
            lblProduto.Text = "Pizza de";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(821, 253);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 1;
            label1.Text = "R$";
            // 
            // panel3
            // 
            panel3.Location = new Point(352, 49);
            panel3.Name = "panel3";
            panel3.Size = new Size(453, 188);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F);
            label2.Location = new Point(676, 255);
            label2.Name = "label2";
            label2.Size = new Size(43, 29);
            label2.TabIndex = 4;
            label2.Text = "R$";
            // 
            // UCProdutoCarrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "UCProdutoCarrinho";
            Size = new Size(816, 299);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Label label2;
        private PictureBox pictureBox1;
        private Label lblProduto;
        private Label label1;
        private Panel panel3;
    }
}

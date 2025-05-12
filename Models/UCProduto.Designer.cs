namespace TechForAll.Models
{
    partial class UCProduto
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
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            btnAddCarrinho = new TechForAll.CustomButtom.Botao();
            lblProduto = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Bisque;
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1163, 512);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(btnAddCarrinho);
            panel3.Controls.Add(lblProduto);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1163, 512);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(40, 118);
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
            btnAddCarrinho.Location = new Point(513, 410);
            btnAddCarrinho.Name = "btnAddCarrinho";
            btnAddCarrinho.Size = new Size(87, 40);
            btnAddCarrinho.TabIndex = 4;
            btnAddCarrinho.Text = "➕\U0001f6d2";
            btnAddCarrinho.UseVisualStyleBackColor = false;
            // 
            // lblProduto
            // 
            lblProduto.AutoSize = true;
            lblProduto.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblProduto.Location = new Point(513, 89);
            lblProduto.Name = "lblProduto";
            lblProduto.Size = new Size(104, 29);
            lblProduto.TabIndex = 2;
            lblProduto.Text = "Pizza de";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(513, 185);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(445, 165);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(808, 425);
            label1.Name = "label1";
            label1.Size = new Size(41, 25);
            label1.TabIndex = 1;
            label1.Text = "R$";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(513, 142);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 5;
            label2.Text = "label2";
            // 
            // UCProduto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Name = "UCProduto";
            Size = new Size(1163, 512);
            Load += UCProduto_Load;
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private CustomButtom.Botao btnAddCarrinho;
        private PictureBox pictureBox1;
        private Label lblProduto;
        private Label label1;
        private Panel panel3;
        private TextBox textBox1;
        private Label label2;
    }
}

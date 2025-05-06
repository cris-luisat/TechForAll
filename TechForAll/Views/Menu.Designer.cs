namespace Teste_tela05.Views
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            panel3 = new Panel();
            btnMinimizar = new Button();
            btnFechar = new Button();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            btnUserCarteira = new TechForAll.CustomButtom.Botao();
            btnUserCarrinho = new TechForAll.CustomButtom.Botao();
            btnUserCardapio = new TechForAll.CustomButtom.Botao();
            btnUserSair = new TechForAll.CustomButtom.Botao();
            btnUserConfiguracao = new TechForAll.CustomButtom.Botao();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panel2 = new Panel();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel3
            // 
            panel3.BackColor = Color.ForestGreen;
            panel3.Controls.Add(btnMinimizar);
            panel3.Controls.Add(btnFechar);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1163, 52);
            panel3.TabIndex = 2;
            // 
            // btnMinimizar
            // 
            btnMinimizar.BackColor = Color.LightYellow;
            btnMinimizar.Font = new Font("Segoe UI Symbol", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMinimizar.Location = new Point(1075, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(35, 30);
            btnMinimizar.TabIndex = 3;
            btnMinimizar.Text = "-";
            btnMinimizar.UseVisualStyleBackColor = false;
            // 
            // btnFechar
            // 
            btnFechar.BackColor = Color.Brown;
            btnFechar.Font = new Font("Simplex_IV25", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFechar.ForeColor = SystemColors.ControlLightLight;
            btnFechar.Location = new Point(1116, 12);
            btnFechar.Name = "btnFechar";
            btnFechar.Size = new Size(35, 30);
            btnFechar.TabIndex = 2;
            btnFechar.Text = "X";
            btnFechar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("ItalicT", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(61, 9);
            label1.Name = "label1";
            label1.Size = new Size(268, 32);
            label1.TabIndex = 1;
            label1.Text = "Delicias da Itália";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.White;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(52, 44);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Red;
            panel1.Controls.Add(btnUserCarteira);
            panel1.Controls.Add(btnUserCarrinho);
            panel1.Controls.Add(btnUserCardapio);
            panel1.Controls.Add(btnUserSair);
            panel1.Controls.Add(btnUserConfiguracao);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(1163, 59);
            panel1.TabIndex = 3;
            // 
            // btnUserCarteira
            // 
            btnUserCarteira.BackColor = Color.Beige;
            btnUserCarteira.FlatAppearance.BorderSize = 0;
            btnUserCarteira.FlatStyle = FlatStyle.Flat;
            btnUserCarteira.Font = new Font("ItalicT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUserCarteira.ForeColor = Color.Black;
            btnUserCarteira.Location = new Point(168, 11);
            btnUserCarteira.Name = "btnUserCarteira";
            btnUserCarteira.Size = new Size(150, 40);
            btnUserCarteira.TabIndex = 8;
            btnUserCarteira.Text = "Carteira";
            btnUserCarteira.UseVisualStyleBackColor = false;
            btnUserCarteira.Click += btnUserCarteira_Click;
            // 
            // btnUserCarrinho
            // 
            btnUserCarrinho.BackColor = Color.Beige;
            btnUserCarrinho.FlatAppearance.BorderSize = 0;
            btnUserCarrinho.FlatStyle = FlatStyle.Flat;
            btnUserCarrinho.Font = new Font("ItalicT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUserCarrinho.ForeColor = Color.Black;
            btnUserCarrinho.Location = new Point(333, 11);
            btnUserCarrinho.Name = "btnUserCarrinho";
            btnUserCarrinho.Size = new Size(150, 40);
            btnUserCarrinho.TabIndex = 7;
            btnUserCarrinho.Text = "Carrinho";
            btnUserCarrinho.UseVisualStyleBackColor = false;
            btnUserCarrinho.Click += btnUserCarrinho_Click;
            // 
            // btnUserCardapio
            // 
            btnUserCardapio.BackColor = Color.Beige;
            btnUserCardapio.FlatAppearance.BorderSize = 0;
            btnUserCardapio.FlatStyle = FlatStyle.Flat;
            btnUserCardapio.Font = new Font("ItalicT", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnUserCardapio.ForeColor = Color.Black;
            btnUserCardapio.Location = new Point(3, 11);
            btnUserCardapio.Name = "btnUserCardapio";
            btnUserCardapio.Size = new Size(150, 40);
            btnUserCardapio.TabIndex = 4;
            btnUserCardapio.Text = "Cardápio";
            btnUserCardapio.UseVisualStyleBackColor = false;
            btnUserCardapio.Click += btnUserCardapio_Click;
            // 
            // btnUserSair
            // 
            btnUserSair.BackColor = Color.Red;
            btnUserSair.FlatAppearance.BorderSize = 0;
            btnUserSair.FlatStyle = FlatStyle.Flat;
            btnUserSair.Font = new Font("Segoe UI", 18F);
            btnUserSair.ForeColor = Color.White;
            btnUserSair.Image = (Image)resources.GetObject("btnUserSair.Image");
            btnUserSair.Location = new Point(1107, 11);
            btnUserSair.Name = "btnUserSair";
            btnUserSair.Size = new Size(40, 40);
            btnUserSair.TabIndex = 5;
            btnUserSair.TextAlign = ContentAlignment.MiddleLeft;
            btnUserSair.UseVisualStyleBackColor = false;
            // 
            // btnUserConfiguracao
            // 
            btnUserConfiguracao.BackColor = Color.Gray;
            btnUserConfiguracao.FlatAppearance.BorderSize = 0;
            btnUserConfiguracao.FlatStyle = FlatStyle.Flat;
            btnUserConfiguracao.Font = new Font("Segoe UI", 18F);
            btnUserConfiguracao.ForeColor = Color.White;
            btnUserConfiguracao.Location = new Point(1050, 11);
            btnUserConfiguracao.Name = "btnUserConfiguracao";
            btnUserConfiguracao.Size = new Size(51, 40);
            btnUserConfiguracao.TabIndex = 4;
            btnUserConfiguracao.Text = "⚙";
            btnUserConfiguracao.TextAlign = ContentAlignment.MiddleLeft;
            btnUserConfiguracao.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 111);
            panel2.Name = "panel2";
            panel2.Size = new Size(1163, 512);
            panel2.TabIndex = 4;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1163, 623);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu";
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Panel panel1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pictureBox1;
        private Button btnMinimizar;
        private Button btnFechar;
        private Label label1;
        private TechForAll.CustomButtom.Botao btnUserConfiguracao;
        private TechForAll.CustomButtom.Botao btnUserSair;
        private TechForAll.CustomButtom.Botao btnUserCardapio;
        private TechForAll.CustomButtom.Botao btnUserCarrinho;
        private TechForAll.CustomButtom.Botao btnUserCarteira;
        private Panel panel2;
    }
}
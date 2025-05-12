namespace TechForAll.Models
{
    partial class UCMCards
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
            panel1 = new Panel();
            panel2 = new Panel();
            botao1 = new TechForAll.CustomButtom.Botao();
            pnlNovoCartao = new Panel();
            pnlCards = new Panel();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(143, 512);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(botao1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(143, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(820, 100);
            panel2.TabIndex = 2;
            // 
            // botao1
            // 
            botao1.BackColor = Color.Maroon;
            botao1.FlatAppearance.BorderSize = 0;
            botao1.FlatStyle = FlatStyle.Flat;
            botao1.ForeColor = Color.White;
            botao1.Location = new Point(706, 45);
            botao1.Name = "botao1";
            botao1.Size = new Size(99, 49);
            botao1.TabIndex = 0;
            botao1.Text = "➕ Novo Cartão";
            botao1.UseVisualStyleBackColor = false;
            botao1.Click += botao1_Click;
            // 
            // pnlNovoCartao
            // 
            pnlNovoCartao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlNovoCartao.Location = new Point(625, 100);
            pnlNovoCartao.Name = "pnlNovoCartao";
            pnlNovoCartao.Size = new Size(338, 412);
            pnlNovoCartao.TabIndex = 4;
            pnlNovoCartao.Paint += pnlNovoCartao_Paint;
            // 
            // pnlCards
            // 
            pnlCards.AutoScroll = true;
            pnlCards.Location = new Point(146, 102);
            pnlCards.Name = "pnlCards";
            pnlCards.Size = new Size(475, 410);
            pnlCards.TabIndex = 5;
            pnlCards.Paint += pnlCards_Paint;
            // 
            // UCMCards
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            Controls.Add(pnlCards);
            Controls.Add(pnlNovoCartao);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCMCards";
            Size = new Size(963, 512);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private CustomButtom.Botao botao1;
        private Panel pnlNovoCartao;
        private Panel pnlCards;
    }
}

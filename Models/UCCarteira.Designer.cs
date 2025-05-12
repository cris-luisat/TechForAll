namespace TechForAll.Models
{
    partial class UCCarteira
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
            pnlCarteira = new Panel();
            panel2 = new Panel();
            botao3 = new TechForAll.CustomButtom.Botao();
            botao1 = new TechForAll.CustomButtom.Botao();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // pnlCarteira
            // 
            pnlCarteira.BackColor = Color.Wheat;
            pnlCarteira.Location = new Point(202, 3);
            pnlCarteira.Name = "pnlCarteira";
            pnlCarteira.Size = new Size(959, 507);
            pnlCarteira.TabIndex = 0;
            pnlCarteira.Paint += pnlCarteira_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 0, 0);
            panel2.Controls.Add(botao3);
            panel2.Controls.Add(botao1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 512);
            panel2.TabIndex = 0;
            // 
            // botao3
            // 
            botao3.BackColor = Color.ForestGreen;
            botao3.FlatAppearance.BorderSize = 0;
            botao3.FlatStyle = FlatStyle.Flat;
            botao3.ForeColor = Color.White;
            botao3.Location = new Point(25, 127);
            botao3.Name = "botao3";
            botao3.Size = new Size(150, 39);
            botao3.TabIndex = 2;
            botao3.Text = "Meu Saldo";
            botao3.UseVisualStyleBackColor = false;
            botao3.Click += botao3_Click;
            // 
            // botao1
            // 
            botao1.BackColor = Color.ForestGreen;
            botao1.FlatAppearance.BorderSize = 0;
            botao1.FlatStyle = FlatStyle.Flat;
            botao1.ForeColor = Color.White;
            botao1.Location = new Point(25, 65);
            botao1.Name = "botao1";
            botao1.Size = new Size(150, 39);
            botao1.TabIndex = 0;
            botao1.Text = "Meus Cartões";
            botao1.UseVisualStyleBackColor = false;
            botao1.Click += botao1_Click;
            // 
            // UCCarteira
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(pnlCarteira);
            Name = "UCCarteira";
            Size = new Size(1163, 512);
            Load += UCCarteira_Load;
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlCarteira;
        private Panel panel2;
        private CustomButtom.Botao botao3;
        private CustomButtom.Botao botao1;
    }
}

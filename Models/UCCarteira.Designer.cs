﻿namespace TechForAll.Models
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
            panel1 = new Panel();
            panel2 = new Panel();
            botao1 = new TechForAll.CustomButtom.Botao();
            botao2 = new TechForAll.CustomButtom.Botao();
            botao3 = new TechForAll.CustomButtom.Botao();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Wheat;
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1163, 512);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.OrangeRed;
            panel2.Controls.Add(botao3);
            panel2.Controls.Add(botao2);
            panel2.Controls.Add(botao1);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 512);
            panel2.TabIndex = 0;
            // 
            // botao1
            // 
            botao1.BackColor = Color.MediumSlateBlue;
            botao1.FlatAppearance.BorderSize = 0;
            botao1.FlatStyle = FlatStyle.Flat;
            botao1.ForeColor = Color.White;
            botao1.Location = new Point(32, 99);
            botao1.Name = "botao1";
            botao1.Size = new Size(150, 40);
            botao1.TabIndex = 0;
            botao1.Text = "Meus Cartões";
            botao1.UseVisualStyleBackColor = false;
            // 
            // botao2
            // 
            botao2.BackColor = Color.MediumSlateBlue;
            botao2.FlatAppearance.BorderSize = 0;
            botao2.FlatStyle = FlatStyle.Flat;
            botao2.ForeColor = Color.White;
            botao2.Location = new Point(32, 158);
            botao2.Name = "botao2";
            botao2.Size = new Size(150, 40);
            botao2.TabIndex = 1;
            botao2.Text = "Meus Cupons";
            botao2.UseVisualStyleBackColor = false;
            // 
            // botao3
            // 
            botao3.BackColor = Color.MediumSlateBlue;
            botao3.FlatAppearance.BorderSize = 0;
            botao3.FlatStyle = FlatStyle.Flat;
            botao3.ForeColor = Color.White;
            botao3.Location = new Point(32, 226);
            botao3.Name = "botao3";
            botao3.Size = new Size(150, 40);
            botao3.TabIndex = 2;
            botao3.Text = "Meu Saldo";
            botao3.UseVisualStyleBackColor = false;
            // 
            // UCCarteira
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UCCarteira";
            Size = new Size(1163, 512);
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private CustomButtom.Botao botao3;
        private CustomButtom.Botao botao2;
        private CustomButtom.Botao botao1;
    }
}

namespace TechForAll.Models
{
    partial class UCCard
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 9);
            label1.Name = "label1";
            label1.Size = new Size(73, 25);
            label1.TabIndex = 4;
            label1.Text = "Funcao";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(61, 75);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 5;
            label2.Text = "Validade";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(233, 75);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 6;
            label3.Text = "CVV";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(117, 159);
            label4.Name = "label4";
            label4.Size = new Size(52, 25);
            label4.TabIndex = 7;
            label4.Text = "0000";
            // 
            // label5
            // 
            label5.BackColor = Color.White;
            label5.Location = new Point(61, 43);
            label5.Name = "label5";
            label5.Size = new Size(338, 32);
            label5.TabIndex = 8;
            // 
            // label6
            // 
            label6.BackColor = Color.White;
            label6.Location = new Point(109, 154);
            label6.Name = "label6";
            label6.Size = new Size(244, 33);
            label6.TabIndex = 9;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F);
            label7.Location = new Point(175, 159);
            label7.Name = "label7";
            label7.Size = new Size(52, 25);
            label7.TabIndex = 10;
            label7.Text = "0000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F);
            label8.Location = new Point(233, 159);
            label8.Name = "label8";
            label8.Size = new Size(52, 25);
            label8.TabIndex = 11;
            label8.Text = "0000";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 14.25F);
            label9.Location = new Point(291, 159);
            label9.Name = "label9";
            label9.Size = new Size(52, 25);
            label9.TabIndex = 12;
            label9.Text = "0000";
            // 
            // label10
            // 
            label10.BackColor = Color.White;
            label10.Location = new Point(61, 100);
            label10.Name = "label10";
            label10.Size = new Size(166, 32);
            label10.TabIndex = 13;
            // 
            // label11
            // 
            label11.BackColor = Color.White;
            label11.Location = new Point(233, 100);
            label11.Name = "label11";
            label11.Size = new Size(166, 32);
            label11.TabIndex = 14;
            // 
            // UCCard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label5);
            Controls.Add(label6);
            Name = "UCCard";
            Size = new Size(455, 230);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
    }
}

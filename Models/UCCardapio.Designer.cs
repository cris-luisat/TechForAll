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
            panel4 = new Panel();
            panel3 = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.AutoScroll = true;
            panel1.BackColor = Color.Wheat;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1163, 512);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(100, 100);
            panel4.Name = "panel4";
            panel4.Size = new Size(1063, 412);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(100, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1063, 100);
            panel3.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(100, 512);
            panel2.TabIndex = 0;
            // 
            // UCCardapio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UCCardapio";
            Size = new Size(1163, 512);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
    }
}

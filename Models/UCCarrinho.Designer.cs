namespace TechForAll.Models
{
    partial class UCCarrinho
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCCarrinho));
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            botao1 = new TechForAll.CustomButtom.Botao();
            botao2 = new TechForAll.CustomButtom.Botao();
            label1 = new Label();
            botao3 = new TechForAll.CustomButtom.Botao();
            botao4 = new TechForAll.CustomButtom.Botao();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(100, 512);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(100, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1063, 100);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(comboBox2);
            panel3.Controls.Add(comboBox1);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(botao2);
            panel3.Controls.Add(botao1);
            panel3.Controls.Add(botao3);
            panel3.Controls.Add(botao4);
            panel3.Dock = DockStyle.Right;
            panel3.Location = new Point(916, 100);
            panel3.Name = "panel3";
            panel3.Size = new Size(247, 412);
            panel3.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(100, 100);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(816, 412);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // botao1
            // 
            botao1.BackColor = Color.Red;
            botao1.FlatAppearance.BorderSize = 0;
            botao1.FlatStyle = FlatStyle.Flat;
            botao1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botao1.ForeColor = Color.White;
            botao1.Location = new Point(46, 339);
            botao1.Name = "botao1";
            botao1.Size = new Size(161, 44);
            botao1.TabIndex = 0;
            botao1.Text = "Comprar agora";
            botao1.UseVisualStyleBackColor = false;
            // 
            // botao2
            // 
            botao2.BackColor = Color.ForestGreen;
            botao2.FlatAppearance.BorderSize = 0;
            botao2.FlatStyle = FlatStyle.Flat;
            botao2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botao2.ForeColor = Color.White;
            botao2.Location = new Point(46, 293);
            botao2.Name = "botao2";
            botao2.Size = new Size(161, 40);
            botao2.TabIndex = 1;
            botao2.Text = "Cancelar ";
            botao2.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15.75F);
            label1.Location = new Point(77, 252);
            label1.Name = "label1";
            label1.Size = new Size(103, 30);
            label1.TabIndex = 2;
            label1.Text = "R$ 000,00";
            // 
            // botao3
            // 
            botao3.BackColor = Color.DarkSeaGreen;
            botao3.FlatAppearance.BorderSize = 0;
            botao3.FlatStyle = FlatStyle.Flat;
            botao3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botao3.ForeColor = Color.White;
            botao3.Location = new Point(46, 247);
            botao3.Name = "botao3";
            botao3.Size = new Size(161, 40);
            botao3.TabIndex = 3;
            botao3.UseVisualStyleBackColor = false;
            // 
            // botao4
            // 
            botao4.BackColor = Color.DarkSeaGreen;
            botao4.FlatAppearance.BorderSize = 0;
            botao4.FlatStyle = FlatStyle.Flat;
            botao4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            botao4.ForeColor = Color.White;
            botao4.Location = new Point(46, 201);
            botao4.Name = "botao4";
            botao4.Size = new Size(161, 40);
            botao4.TabIndex = 5;
            botao4.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(77, 155);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(0, 23);
            comboBox1.TabIndex = 6;
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "10% ", "20%", "30%" });
            comboBox2.Location = new Point(69, 203);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 33);
            comboBox2.TabIndex = 7;
            comboBox2.Text = "Cupons";
            // 
            // UCCarrinho
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCCarrinho";
            Size = new Size(1163, 512);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private FlowLayoutPanel flowLayoutPanel1;
        private CustomButtom.Botao botao1;
        private CustomButtom.Botao botao3;
        private Label label1;
        private CustomButtom.Botao botao2;
        private CustomButtom.Botao botao4;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
    }
}

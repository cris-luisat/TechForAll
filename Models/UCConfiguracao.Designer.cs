namespace TechForAll.Models
{
    partial class UCConfiguracao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCConfiguracao));
            panelConf = new Panel();
            panelConf2 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtEditSenha = new TextBox();
            txtEditEndereco = new TextBox();
            txtEditEmail = new TextBox();
            txtEditNome = new TextBox();
            panelConf.SuspendLayout();
            SuspendLayout();
            // 
            // panelConf
            // 
            panelConf.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panelConf.AutoScroll = true;
            panelConf.BackColor = Color.White;
            panelConf.Controls.Add(panelConf2);
            panelConf.Controls.Add(label4);
            panelConf.Controls.Add(label3);
            panelConf.Controls.Add(label2);
            panelConf.Controls.Add(label1);
            panelConf.Controls.Add(txtEditSenha);
            panelConf.Controls.Add(txtEditEndereco);
            panelConf.Controls.Add(txtEditEmail);
            panelConf.Controls.Add(txtEditNome);
            panelConf.ForeColor = SystemColors.ActiveCaption;
            panelConf.Location = new Point(243, 32);
            panelConf.Name = "panelConf";
            panelConf.Size = new Size(769, 451);
            panelConf.TabIndex = 0;
            // 
            // panelConf2
            // 
            panelConf2.Location = new Point(408, 38);
            panelConf2.Name = "panelConf2";
            panelConf2.Size = new Size(338, 329);
            panelConf2.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(33, 169);
            label4.Name = "label4";
            label4.Size = new Size(118, 21);
            label4.TabIndex = 7;
            label4.Text = "Editar Endereço";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(45, 127);
            label3.Name = "label3";
            label3.Size = new Size(103, 21);
            label3.TabIndex = 6;
            label3.Text = "Mudar Senha";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = SystemColors.ControlDarkDark;
            label2.Location = new Point(39, 84);
            label2.Name = "label2";
            label2.Size = new Size(104, 21);
            label2.TabIndex = 5;
            label2.Text = "Mudar E-mail";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(45, 41);
            label1.Name = "label1";
            label1.Size = new Size(97, 21);
            label1.TabIndex = 4;
            label1.Text = "Editar Nome";
            // 
            // txtEditSenha
            // 
            txtEditSenha.Font = new Font("Segoe UI", 12F);
            txtEditSenha.Location = new Point(157, 124);
            txtEditSenha.Name = "txtEditSenha";
            txtEditSenha.Size = new Size(223, 29);
            txtEditSenha.TabIndex = 3;
            // 
            // txtEditEndereco
            // 
            txtEditEndereco.Font = new Font("Segoe UI", 12F);
            txtEditEndereco.Location = new Point(157, 166);
            txtEditEndereco.Name = "txtEditEndereco";
            txtEditEndereco.Size = new Size(223, 29);
            txtEditEndereco.TabIndex = 2;
            // 
            // txtEditEmail
            // 
            txtEditEmail.Font = new Font("Segoe UI", 12F);
            txtEditEmail.Location = new Point(157, 81);
            txtEditEmail.Name = "txtEditEmail";
            txtEditEmail.Size = new Size(223, 29);
            txtEditEmail.TabIndex = 1;
            // 
            // txtEditNome
            // 
            txtEditNome.Font = new Font("Segoe UI", 12F);
            txtEditNome.Location = new Point(157, 38);
            txtEditNome.Name = "txtEditNome";
            txtEditNome.Size = new Size(223, 29);
            txtEditNome.TabIndex = 0;
            // 
            // UCConfiguracao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = Color.Wheat;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            Controls.Add(panelConf);
            Name = "UCConfiguracao";
            Size = new Size(1163, 512);
            panelConf.ResumeLayout(false);
            panelConf.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelConf;
        private Label label1;
        private TextBox txtEditSenha;
        private TextBox txtEditEndereco;
        private TextBox txtEditEmail;
        private TextBox txtEditNome;
        private Label label4;
        private Label label3;
        private Label label2;
        private Panel panelConf2;
    }
}

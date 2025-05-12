namespace TechForAll.Models
{
    partial class UCCadastrarCartao
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
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            txtNumeroCartao = new TextBox();
            txtCardVencimento = new TextBox();
            txtCardCvv = new TextBox();
            txtNomeCliente = new TextBox();
            txtCpf = new TextBox();
            btnSalvarCard = new TechForAll.CustomButtom.Botao();
            cboTipoCartao = new ComboBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Maroon;
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.White;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 36);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(93, 8);
            label1.Name = "label1";
            label1.Size = new Size(154, 25);
            label1.TabIndex = 0;
            label1.Text = "Adicionar Cartão";
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 36);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 45);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(14, 3);
            label2.Name = "label2";
            label2.Size = new Size(298, 40);
            label2.TabIndex = 0;
            label2.Text = "Digite as informações do cartão de crédito \r\n    que você deseja usar para pagamento.";
            // 
            // txtNumeroCartao
            // 
            txtNumeroCartao.Font = new Font("Segoe UI", 12F);
            txtNumeroCartao.Location = new Point(3, 120);
            txtNumeroCartao.Name = "txtNumeroCartao";
            txtNumeroCartao.PlaceholderText = "Número do cartão";
            txtNumeroCartao.Size = new Size(332, 29);
            txtNumeroCartao.TabIndex = 2;
            // 
            // txtCardVencimento
            // 
            txtCardVencimento.Font = new Font("Segoe UI", 12F);
            txtCardVencimento.Location = new Point(3, 155);
            txtCardVencimento.Name = "txtCardVencimento";
            txtCardVencimento.PlaceholderText = "Validade";
            txtCardVencimento.Size = new Size(166, 29);
            txtCardVencimento.TabIndex = 3;
            // 
            // txtCardCvv
            // 
            txtCardCvv.Font = new Font("Segoe UI", 12F);
            txtCardCvv.Location = new Point(169, 155);
            txtCardCvv.Name = "txtCardCvv";
            txtCardCvv.PlaceholderText = "CVV";
            txtCardCvv.Size = new Size(166, 29);
            txtCardCvv.TabIndex = 4;
            // 
            // txtNomeCliente
            // 
            txtNomeCliente.Font = new Font("Segoe UI", 12F);
            txtNomeCliente.Location = new Point(3, 190);
            txtNomeCliente.Name = "txtNomeCliente";
            txtNomeCliente.PlaceholderText = "Nome do titular";
            txtNomeCliente.Size = new Size(332, 29);
            txtNomeCliente.TabIndex = 5;
            // 
            // txtCpf
            // 
            txtCpf.Font = new Font("Segoe UI", 12F);
            txtCpf.Location = new Point(3, 225);
            txtCpf.Name = "txtCpf";
            txtCpf.PlaceholderText = "CPF";
            txtCpf.Size = new Size(332, 29);
            txtCpf.TabIndex = 6;
            // 
            // btnSalvarCard
            // 
            btnSalvarCard.BackColor = Color.ForestGreen;
            btnSalvarCard.FlatAppearance.BorderSize = 0;
            btnSalvarCard.FlatStyle = FlatStyle.Flat;
            btnSalvarCard.ForeColor = Color.White;
            btnSalvarCard.Location = new Point(93, 323);
            btnSalvarCard.Name = "btnSalvarCard";
            btnSalvarCard.Size = new Size(150, 40);
            btnSalvarCard.TabIndex = 7;
            btnSalvarCard.Text = "Salvar";
            btnSalvarCard.UseVisualStyleBackColor = false;
            btnSalvarCard.Click += btnSalvarCard_Click;
            // 
            // cboTipoCartao
            // 
            cboTipoCartao.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            cboTipoCartao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboTipoCartao.FormattingEnabled = true;
            cboTipoCartao.Items.AddRange(new object[] { "Débito", "Crédito" });
            cboTipoCartao.Location = new Point(3, 260);
            cboTipoCartao.Name = "cboTipoCartao";
            cboTipoCartao.Size = new Size(332, 29);
            cboTipoCartao.TabIndex = 10;
            cboTipoCartao.Text = "Tipo do cartão";
            // 
            // UCCadastrarCartao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            Controls.Add(cboTipoCartao);
            Controls.Add(btnSalvarCard);
            Controls.Add(txtCpf);
            Controls.Add(txtNomeCliente);
            Controls.Add(txtCardCvv);
            Controls.Add(txtCardVencimento);
            Controls.Add(txtNumeroCartao);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "UCCadastrarCartao";
            Size = new Size(338, 380);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txtNumeroCartao;
        private TextBox txtCardVencimento;
        private TextBox txtCardCvv;
        private TextBox txtNomeCliente;
        private TextBox txtCpf;
        private Label label1;
        private Label label2;
        private CustomButtom.Botao btnSalvarCard;
        private ComboBox cboTipoCartao;
    }
}

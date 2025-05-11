using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechForAll.Models;

namespace Teste_tela05.Views
{
    public partial class Menu : Form
    {
        public static Panel MainPanel;
        public Menu()
        {
            InitializeComponent();
            MainPanel = panel2;
        }

        private void botao1_Click(object sender, EventArgs e)
        {

        }

        private void btnUserCardapio_Click(object sender, EventArgs e)
        {
            UCCardapio cardapio = new UCCardapio();
            panel2.Controls.Clear();
            panel2.Controls.Add(cardapio);
            panel2.Dock = DockStyle.Fill;
            panel2.BringToFront();
        }

        private void btnUserCarteira_Click(object sender, EventArgs e)
        {
            UCCarteira carteira = new UCCarteira();
            panel2.Controls.Clear();
            panel2.Controls.Add(carteira);
            panel2.Dock = DockStyle.Fill;
            panel2.BringToFront();

        }

        private void btnUserCarrinho_Click(object sender, EventArgs e)
        {
            UCCarrinho carrinho = new UCCarrinho();
            panel2.Controls.Clear();
            panel2.Controls.Add(carrinho);
            panel2.Dock = DockStyle.Fill;
            panel2.BringToFront();

        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUserSair_Click(object sender, EventArgs e)
        {
            TelaInicial telaInicial = new TelaInicial();
            telaInicial.Show();
            this.Hide();
        }

        private void btnUserConfiguracao_Click(object sender, EventArgs e)
        {
            UCConfiguracao conf = new UCConfiguracao();
            panel1.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(conf);
            panel1.BringToFront();
            conf.Show();
        }
    }
}

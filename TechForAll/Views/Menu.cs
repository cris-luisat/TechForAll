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
        public Menu()
        {
            InitializeComponent();
        }

        private void botao1_Click(object sender, EventArgs e)
        {

        }

        private void btnUserCardapio_Click(object sender, EventArgs e)
        {
            UCCardapio cardapio = new UCCardapio();
            cardapio.Show();

        }

        private void btnUserCarteira_Click(object sender, EventArgs e)
        {
            UCCarteira carteira = new UCCarteira();
            carteira.Show();
        }

        private void btnUserCarrinho_Click(object sender, EventArgs e)
        {
            UCCarrinho carrinho = new UCCarrinho();
            carrinho.Show();
        }
    }
}

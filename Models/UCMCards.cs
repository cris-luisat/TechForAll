using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechForAll.Models
{
    public partial class UCMCards : UserControl
    {
        public UCMCards()
        {
            InitializeComponent();
        }

        private void botao1_Click(object sender, EventArgs e)
        {
            var cadcartao = new UCCadastrarCartao();
            pnlNovoCartao.Dock = DockStyle.Fill;
            pnlNovoCartao.Controls.Clear();
            pnlNovoCartao.Controls.Add(cadcartao);
            pnlNovoCartao.BringToFront();
        }

        private void pnlNovoCartao_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlCards_Paint(object sender, PaintEventArgs e)
        {
            var cards = new UCCard();
            pnlCards.Dock = DockStyle.Fill;
            pnlCards.Controls.Clear();
            pnlCards.Controls.Add(cards);
        }
    }
}

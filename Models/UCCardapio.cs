using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TechForAll.Models
{
    public partial class UCCardapio : UserControl
    {
        public static Panel MainPanel;
        public UCCardapio()
        {
            InitializeComponent();
            MainPanel = panel4;
        }

        private void pnlCardapio_Paint(object sender, PaintEventArgs e)
        {
            var cardapio = new UCCardapio();

            var produto = new UCProduto();
            panel4.Dock = DockStyle.Fill;     
            panel4.Controls.Clear();
            this.Controls.Add(cardapio);
            cardapio.BringToFront();
        }


    }
}

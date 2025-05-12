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
    public partial class UCCarteira : UserControl
    {
        public static Panel MainPanel;
        public UCCarteira()
        {
            InitializeComponent();
            MainPanel = pnlCarteira;
        }

        //private void botao4_Click(object sender, EventArgs e)
        //{
        //    var cadcartao = new UCCadastrarCartao();
        //    panel1.Dock = DockStyle.Fill;
        //    panel1.Controls.Clear();
        //    panel1.Controls.Add(cadcartao);
        //    panel1.BringToFront();
        //}

        private void botao1_Click(object sender, EventArgs e)
        {
            var myCards = new UCMCards();
            pnlCarteira.Dock = DockStyle.Fill;
            pnlCarteira.Controls.Clear();
            pnlCarteira.Controls.Add(myCards);
            pnlCarteira.BringToFront();
        }

        private void UCCarteira_Load(object sender, EventArgs e)
        {

        }

        private void botao3_Click(object sender, EventArgs e)
        {
            var saldo = new UCCarrinho();
            pnlCarteira.Dock = DockStyle.Fill;
            pnlCarteira.Controls.Clear();
            pnlCarteira.Controls.Add(saldo);
        }

        private void pnlCarteira_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

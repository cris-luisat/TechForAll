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
            MainPanel = panel1;
        }

        private void botao4_Click(object sender, EventArgs e)
        {
            var cadcartao = new UCCadastrarCartao();            
            panel1.Dock = DockStyle.Fill;
            panel1.Controls.Clear();
            panel1.Controls.Add(cadcartao);
            panel1.BringToFront();           
        }
    }
}

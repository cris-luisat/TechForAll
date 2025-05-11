using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TechForAll.Models
{
    public partial class UCCadastrarCartao : UserControl
    {
        public UCCadastrarCartao()
        {
            InitializeComponent();
        }

        private void btnSalvarCard_Click(object sender, EventArgs e)
        {
            var numeroCartao = txtNumeroCartao.Text;
            var nomeCliente = txtNomeCliente.Text;
            var fotoCliente = "";
            var cpfCliente = string.Empty;
            var Email = string.Empty;
            var Celular = string.Empty;
            var NomeCartao = string.Empty;
            var CVV = txtCardCvv.Text;
            var VencCartao = txtCardVencimento.Text;

            var connection = new MySqlConnection();
            connection.Open();

            var sql = "INSERT INTO clientes ('Nome_Cliente', FotoCliente, " +
                "CPF, Email, Celular, Numero_Cartao, Nome_Cartao, CVV, " +
                "Dt_Venc_Cartao) VALUES (@Nome_Client, @FotoCliente, @CPF, @Email," +
                " @Celular, @Numero_Cartao, @Nome_Cartao, @CVV, @Dt_Venc_Cartao);";
            
            MySqlCommand cmdCadastrarCartao = new MySqlCommand(sql, connection);
            cmdCadastrarCartao.Parameters.AddWithValue("@Nome_Cliente", nomeCliente);            
            cmdCadastrarCartao.Parameters.AddWithValue("@Foto_Cliente", fotoCliente );
            cmdCadastrarCartao.Parameters.AddWithValue("@CPF", cpfCliente );
            cmdCadastrarCartao.Parameters.AddWithValue("@Email", Email);
            cmdCadastrarCartao.Parameters.AddWithValue("@Celular", Celular);
            cmdCadastrarCartao.Parameters.AddWithValue("@Numero_Cartao", numeroCartao);
            cmdCadastrarCartao.Parameters.AddWithValue("@CVV", CVV);
            cmdCadastrarCartao.Parameters.AddWithValue("@Dt_Venc_Cartao", VencCartao);

            cmdCadastrarCartao.ExecuteNonQuery();

            MessageBox.Show("Cartão cadatrado com sucesso!",
                MessageBoxIcon.Information.ToString(), 
                MessageBoxButtons.OK);
            

        }
    }
}

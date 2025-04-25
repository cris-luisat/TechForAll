using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Teste_tela05
{
    public partial class Cadastro : Form
    {
        public Cadastro()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cadastro form1 = new Cadastro();
            form1.Show();
            this.Hide();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Pega os valores digitados
            string usuario = txtUsuario.Text;
            string senha = txtCSenha.Text;
            string confirmarSenha = txtConfirmar.Text;
            string email = txtEmail.Text;
            string telefone = txtTelefone.Text;
            string foto = "FOTO";
            string cpf = txtCPF.Text;

            // Verifica campos obrigatórios
            if (string.IsNullOrWhiteSpace(usuario) || string.IsNullOrWhiteSpace(senha) ||
                string.IsNullOrWhiteSpace(confirmarSenha) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(telefone))
            {
                MessageBox.Show("Todos os campos são obrigatórios.");
                return;
            }
            else
            {
                var conexao = ConfigurationManager.ConnectionStrings["Conexao"].ConnectionString;

                MySqlConnection con = new MySqlConnection(conexao);

                con.Open();


                string sql = "INSERT INTO clientes (Nome_Cliente, FotoCliente, CPF, Email, Celular, " +
                    "Numero_Cartao, Nome_Cartao, CVV, Data_Venc_Cartao, Senha, ConfirmarSenha) " +
                    "VALUES(@Nome_Cliente=Nome_Cliente, FotoCliente=@FotoCliente,CPF=@CPF," +
                    "Email=@Email,Celular=@Celular, Nome_Cartao=@Nome_Cartao, Numero_Cartao=@Numero_Cartao,CVV=@CVV, " +
                    "Senha=@Senha,ConfirmarSenha=@ConfirmarSenha,Data_Venc_Cartao=@Data_Venc_Cartao);";

               
                MySqlCommand cmdCadastro = new MySqlCommand(sql, con);

                DateTime data = dtpNascimento.Value;

                string vencimentoCartao = data.ToString("YYYY-mm-dd HH:mm:ss");

                cmdCadastro.Parameters.AddWithValue("@Nome_Cliente", usuario);
                cmdCadastro.Parameters.AddWithValue("@FotoCliente", foto);
                cmdCadastro.Parameters.AddWithValue("@CPF", cpf);
                cmdCadastro.Parameters.AddWithValue("@Email", email);
                cmdCadastro.Parameters.AddWithValue("@Celular", telefone);
                cmdCadastro.Parameters.AddWithValue("@Numero_Cartao", "Numero_Cartao");
                cmdCadastro.Parameters.AddWithValue("@Nome_Cartao", usuario);
                cmdCadastro.Parameters.AddWithValue("@Senha", senha);
                cmdCadastro.Parameters.AddWithValue("@ConfirmarSenha", confirmarSenha);
                cmdCadastro.Parameters.AddWithValue("@CVV", "CVV");
                cmdCadastro.Parameters.AddWithValue("@Data_Venc_Cartao", vencimentoCartao);

                cmdCadastro.ExecuteNonQuery();

                con.Close();
            }

            // Validação da senha
            if (senha.Length < 6)
            {
                MessageBox.Show("A senha deve ter pelo menos 6 caracteres.");
                return;
            }

            if (senha != confirmarSenha)
            {
                MessageBox.Show("As senhas não coincidem.");
                return;
            }

            // Validação de e-mail simples
            if (!Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("E-mail inválido.");
                return;
            }

            // Validação de telefone (apenas números e no mínimo 10 dígitos)
            if (!Regex.IsMatch(telefone, @"^\d{10,11}$"))
            {
                MessageBox.Show("Telefone inválido. Digite apenas números (ex: 11912345678).");
                return;
            }

            // Se passou todas as validações
            MessageBox.Show("Cadastro realizado com sucesso!");

            // Aqui você poderia salvar em banco de dados, arquivo, etc.
            // Vamos apenas voltar para o Form1
            this.Hide(); // esconde o FormCadastro
            Cadastro formLogin = new Cadastro();
            formLogin.Show();
        }

        private void dtpNascimento_ValueChanged(object sender, EventArgs e)
        {
            DateTime dataNascimento = dtpNascimento.Value;
            int idade = DateTime.Now.Year - dataNascimento.Year;

            if (DateTime.Now.Date < dataNascimento.AddYears(idade))
            {
                idade--;
            }

            lblIdade.Text = "Idade: " + idade.ToString();

        }

        private void Cadastro_Load(object sender, EventArgs e)
        {

        }

        private void lblIdade_Click(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Imagens (*.jpg;*.png;*.bmp)|*.jpg;*.png;*.bmp|Todos os arquivos (*.*)|*.*";
                openFileDialog.Title = "Selecione uma imagem";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Carregar a imagem selecionada no PictureBox
                        pictureBox1.Image = Image.FromFile(openFileDialog.FileName);
                        pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage; // Ajustar ao tamanho do PictureBox
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Erro ao carregar a imagem: {ex.Message}");
                    }
                }

            }
        }
    }
}


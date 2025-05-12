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
    public partial class UCProduto : UserControl
    {
        public UCProduto()
        {
            InitializeComponent();
        }

        private void UCProduto_Load(object sender, EventArgs e)
        {
            var produtos = new List<Produto>();
            produtos.Add(new Produto
            {
                Id = 1,
                Nome = "Pizza Calabresa",
                Ingredientes = "Linguiça calabresa, cebola, molho de tomate",
                Descricao = "Descrição do Produto 1",
                Preco = 10.00d,
                Categoria = "Pizza",
                Sabor = "Calabresa",
                Imagem = System.IO.File.ReadAllBytes("image.jpg") // Convertendo a imagem para byte[]    
            },
            produtos.Add(new Produto
            {
                Id = 2,
                Nome = "Pizza Portuguesa",
                Ingredientes = "Presunto, queijo, ovo, cebola, molho de tomate",
                Descricao = "Descrição do Produto 2",
                Preco = 12.00d,
                Categoria = "Pizza",
                Sabor = "Portuguesa",
                Imagem = System.IO.File.ReadAllBytes("image.jpg")
            },
            produtos.Add(new Produto
            {
                Id = 3,
                Nome = "Pizza Quatro Queijos",
                Ingredientes = "Queijo muçarela, queijo gorgonzola, queijo parmesão, queijo provolone",
                Descricao = "Descrição do Produto 3",
                Preco = 15.00d,
                Categoria = "Pizza",
                Sabor = "Quatro Queijos",
                Imagem = System.IO.File.ReadAllBytes("image.jpg")
            },
            produtos.Add(new Produto
            {
                Id = 4,
                Nome = "Pizza Marguerita",
                Ingredientes = "Queijo muçarela, tomate, manjericão, molho de tomate",
                Descricao = "Descrição do Produto 4",
                Preco = 11.00d,
                Categoria = "Pizza",
                Sabor = "Marguerita",
                Imagem = System.IO.File.ReadAllBytes("image.jpg")
            },
            produtos.Add(new Produto
            {
                Id = 5,
                Nome = "Pizza Frango com Catupiry",
                Ingredientes = "Frango desfiado, catupiry, molho de tomate",
                Descricao = "Descrição do Produto 5",
                Preco = 13.00d,
                Categoria = "Pizza",
                Sabor = "Frango com Catupiry",
                Imagem = System.IO.File.ReadAllBytes("image.jpg")
            };

            foreach (var item in produtos)
            {
                var produtoItem = new UCProduto();
                produtoItem.lblProduto.Text = item.Nome;
                produtoItem.label2.Text = item.Descricao;
                if (item.Imagem != null)
                {
                    using (var ms = new System.IO.MemoryStream(item.Imagem))
                    {
                        produtoItem.pictureBox1.Image = Image.FromStream(ms);
                    }
                }
                produtoItem.btnAddCarrinho.Tag = item;
                produtoItem.btnAddCarrinho.Click += (s, e) =>
                {
                    // Adiciona o produto ao carrinho    
                    UCCarrinho.AdicionarProduto((Produto)produtoItem.btnAddCarrinho.Tag);
                    MessageBox.Show("Produto adicionado ao carrinho!");
                };
                UCCardapio.MainPanel.Controls.Add(produtoItem);
            }
        }
    }
}

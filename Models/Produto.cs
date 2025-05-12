using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechForAll.Models
{
    public class Produto
    {
        public Produto(int id, string nome, string 
            ingredientes, string descricao, double preco, 
            string categoria, string sabor, byte[] imagem)
        {
            Id = id;
            Nome = nome;
            Ingredientes = ingredientes;
            Descricao = descricao;
            Preco = (double)preco;
            Categoria = categoria;
            Sabor = sabor;
            Imagem = imagem;
        }
        public int Id { get; set; }
        public string? Nome { get; set; }
        public string? Ingredientes { get; set; }
        public string? Descricao { get; set; }
        public double? Preco { get; set; }
        public string? Categoria { get; set; }
        public string? Sabor { get; set; }
        public byte[]? Imagem { get; set; }
    }
}

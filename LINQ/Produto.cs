using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.LINQ
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public float Preco { get; set; }
        public int Estoque { get; set; }
        public string  Categoria { get; set; }


        public static List<Produto> GetProdutos()
        {
            List<Produto> produtos = new List<Produto>()
            {
                new Produto {Id = 1, Nome= "Camiseta", Preco=29.90f, Estoque =3, Categoria = "Roupas"},
                new Produto {Id = 2, Nome= "Meia Soc.", Preco=10.90f, Estoque =100, Categoria = "Roupas"},
                new Produto {Id = 3, Nome= "Calça Jeans", Preco=90.00f, Estoque =3, Categoria = "Calçados"},
                new Produto {Id = 4, Nome= "Tenis Nike", Preco=230.00f, Estoque =40, Categoria = "Tenis"},
                new Produto {Id = 5, Nome= "Notebook", Preco=3000.90f, Estoque =4, Categoria = "Eletronicos"},
                new Produto {Id = 6, Nome= "Mochila", Preco=29.90f, Estoque =30, Categoria = "Acessorios"},
                new Produto {Id = 7, Nome= "Smart TV", Preco=1500.90f, Estoque =366, Categoria = "Eletronicos"},
                new Produto {Id = 8, Nome= "Cadeira", Preco=40.90f, Estoque =20, Categoria = "Moveis"},
                new Produto {Id = 9, Nome= "Mesa Sala", Preco=100.00f, Estoque =10, Categoria = "Moveis"},
                new Produto {Id = 10, Nome= "Alicate", Preco=10.00f, Estoque =10, Categoria = "Ferramentas"}
            };

            return produtos;
        }
    }
}

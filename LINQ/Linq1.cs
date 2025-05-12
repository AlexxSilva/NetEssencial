using NetEssencial.Classes_e_metodos;
using NetEssencial.Orientacao_Objetos.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.LINQ
{
    public partial class Linq1 : Form
    {
        public Linq1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //Query Sintax
            
            List<string> list = new List<string>()
            {
                "Ana", "Maria", "Pedro", "Lair", "Hugo"
            };

            //(Method Sintax)

            var resultado = from m in list
                            where m.Contains('o')
                            select m;

            foreach (var item in resultado)
            {
                Console.WriteLine(item);
            }

            var resultado1 = list.Where(x => x.Contains('a'));
            foreach (var item in resultado1)
            {
                Console.WriteLine(item);
            }



            var listaProdutos = Produto.GetProdutos();
            //listar da categoria
            var produtosCategoria = listaProdutos.Where(p => p.Categoria == "Eletronicos");

            //filtrar duas condicoes
            var produtoCaroNoEstoque = listaProdutos.Where(p => p.Preco > 1500 && p.Estoque > 5);

            //filtrar com ordenação
            int minimo = 10;
            var produtoEstoqueMinimo = listaProdutos.Where(p => p.Estoque < minimo)
                .OrderBy(p => p.Nome)
                .ThenBy(p => p.Categoria);


            //select
            var nomeDosProdutos = listaProdutos.Select(p => p.Nome).OrderBy(nome => nome);

            var resultadoAnonimo = listaProdutos.Where(p => p.Preco < 500)
                .OrderBy(p => p.Nome)
                .Select(p => new { 
                    NomeProduto = p.Nome.ToUpper(),
                    PrecoComAumento = p.Preco * 1.1
                });

            //  calculos - media
            string categoria = "Eletronicos";
            var mediaProdutos = listaProdutos.Where(p => p.Categoria == categoria)
                .Average(p => p.Preco);


            //primeiro produto
            var primeiroProduto = listaProdutos.First();
            var primeiroProdutoPadrao = listaProdutos.FirstOrDefault(p => p.Categoria == categoria);


            //Ultimo produto
            var ultimoProduto = listaProdutos.Last();
            var ultimoProdutoPadrao = listaProdutos.LastOrDefault(p => p.Categoria == categoria);

            //single
            var unicoProduto = listaProdutos.Single(p => p.Nome == "Cadeira");


            //group by

            var produtosPorCategoria = listaProdutos.GroupBy(p => p.Categoria).OrderBy(c => c.Key).
                Select(g => new
                {
                    Categoria = g.Key,
                    Produtos = g.OrderBy(p => p.Nome)
                    .Select(p => new { 
                    Nome = p.Nome,
                    Preco = p.Preco,
                    Estoque = p.Estoque,
                    })

                });

            foreach (var grupo in produtosPorCategoria)
            {
                Console.WriteLine(grupo.Categoria + " : " + grupo.Categoria.Count());

                foreach (var produto in grupo.Produtos)
                {
                    Console.WriteLine(produto.Nome + " - " + produto.Preco + " - " + produto.Estoque);
                }
            }

        }
    }
}

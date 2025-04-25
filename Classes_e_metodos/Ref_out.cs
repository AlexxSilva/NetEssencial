using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.Classes_e_metodos
{
    public partial class Ref_out : Form
    {
        public Ref_out()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Estoque estoque = new Estoque();

            estoque.AdicionarProduto(new Produto(1, "Mouse Gamer", 50));

            int novaQtd = 30;
            estoque.AtualizarEstoque(1, ref novaQtd); // Passa por ref a nova quantidade
            
            gravarLog();//classe parcial

            if (estoque.ObterNomeDoProduto(1, out string nomeProduto)) // Usa out para obter o nome
            {
                MessageBox.Show($"Produto encontrado: {nomeProduto}");
            }
            else
            {
                MessageBox.Show("Produto não encontrado.");
            }
        }
    }


    public class Estoque
    {
        private List<Produto> produtos = new List<Produto>();

        public void AdicionarProduto(Produto produto)
        {
            produtos.Add(produto);
        }

        // Método usando ref: atualiza o estoque diretamente
        public void AtualizarEstoque(int id, ref int novaQuantidade)
        {
            Produto? produto = produtos.Find(p => p.Id == id);
            if (produto != null)
            {
                produto.QuantidadeEmEstoque = novaQuantidade;
                MessageBox.Show($"Estoque do produto {produto.Nome} atualizado para {novaQuantidade} unidades.");
            }
            else
            {
                MessageBox.Show("Produto não encontrado.");
            }
        }

        // Método usando out: retorna o nome do produto
        public bool ObterNomeDoProduto(int id, out string nome)
        {
            Produto? produto = produtos.Find(p => p.Id == id);
            if (produto != null)
            {
                nome = produto.Nome;
                return true;
            }
            else
            {
                nome = null;
                return false;
            }
        }
    }

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int QuantidadeEmEstoque { get; set; }

        public Produto(int id, string nome, int quantidade)
        {
            Id = id;
            Nome = nome;
            QuantidadeEmEstoque = quantidade;
        }
    }

}

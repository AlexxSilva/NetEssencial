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
    public partial class Propriedades : Form
    {
        public Propriedades()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Produtos p1 = new Produtos();
            p1.Nome = "Alex";
            p1.Preco = 10.00;
            p1.EstoqueMinimo = 10;
        }
    }

    public class Produtos
    {
        private string? nome; 
        public string? Nome
        {
            get { return nome?.ToUpper(); }
            set { nome = value; }
        }

        private double preco;
        public double Preco
        {
            get { return preco; }
            set
            {
                preco = preco < 5.00 ? 5.00 : value;
            }
        }
        private double desconto = 0.05;
        public double Desconto { 
            get {  return desconto; } 
        }

        public double PrecoFinal {
            get { return Preco - (Preco * Desconto); }
        }

        private int minimo;
        public int EstoqueMinimo
        {
            set
            {
                minimo = value;
            }
        }

        public void Exibir()
        {
            MessageBox.Show($"{Nome} \n {Preco.ToString("c")} \n {Desconto} \n {PrecoFinal.ToString("c")} \n {minimo}");
        }
    }

}

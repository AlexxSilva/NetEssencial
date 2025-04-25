using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.InferenciaDeDados1
{
    public partial class InferenciaDados : Form
    {
        public InferenciaDados()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var idade = 35;
            var nome = "Maria";
            var salario = 2500.00m;

            string valor = $"{nome} tem {idade} anos e ganha { salario.ToString("c") }";
            var teste = new Teste();
            teste.MeuMetodo();

            //limitaçoes - não pode
            //var salari = null;
            //var titulo;
            //var salari2, imposto, total;

            //var num = 10;
            //num = num + 20;
            //num = "teste";

        }
    }

    class Teste
    {
        public void MeuMetodo()
        {
            
        }
    }
}

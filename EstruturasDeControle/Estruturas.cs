using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.EstruturasDeControle
{
    public partial class Estruturas : Form
    {
        public Estruturas()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //IF
            var resposta = txtDesconto.Text == "S";
            if (resposta)
            {
                MessageBox.Show("Desconto de 10%");
            }

            //IF ELSE
            var nota = Convert.ToInt32(txtNota.Text);
            if (nota > 5)
            {
                MessageBox.Show("Aprovado");
            }
            else
            {
                MessageBox.Show("reprovado");
            }

            //IF ELSE IF
            if (nota >= 7)
            {
                MessageBox.Show("Aprovado");
            }
            else if (nota >= 5)
            {
                MessageBox.Show("recuperação");
            }
            else
            {
                MessageBox.Show("reprovado");
            }

            //switch
            switch (txtDesconto.Text) 
            {
                case "S":
                    MessageBox.Show("Tem desconto");
                    break;
                case "N":
                    MessageBox.Show("Não tem desconto");
                    break;
                default:
                    MessageBox.Show("valor invalido");
                    break;
            }

            //switch em conjunto
            string mes = DateTime.Now.Month.ToString("MMMM", new System.Globalization.CultureInfo("pt-BR"));
            
            switch (mes)
            {
                case "Janeiro":
                case "Fevereiro":
                case "Março":
                    MessageBox.Show("antes do meu aniversário");
                    break;
                case "Abril":
                    MessageBox.Show("Mes do aniversário");
                    break;
                default:
                    MessageBox.Show("Mes depois do aniversário");
                    break;
            }

            //estrutura de repeticao
            int i = 1;
        repetir:
            MessageBox.Show($"i:{i}");
            i++;
            if (i <= 10)
                goto repetir;
            MessageBox.Show("terminou...");

            //while
            var z = 1;
           
            while (i <= 10)
            {
                MessageBox.Show($"z:{z}");
                z++;
            }


            //while com break

            while (true)
            {
               string valor = Interaction.InputBox("Informe um numero inteiro: (Para sair tecle 999", "Entrada de dados", "Valor padrão");

                int numero = int.Parse(valor);

                if (numero == 999)
                {
                    break;
                }
                else
                {
                    if (numero%2 == 0)
                        MessageBox.Show($"Numero par");
                    else
                        MessageBox.Show($"Numero impar");
                }
            }

            //Do while

            var x = 1;
            do
            {
                MessageBox.Show($"x:{x}");
                x++;
            }
            while(i <=10);

            //For
            for (int d = 1; d <= 10; d++)
            {
                MessageBox.Show($"x:{d}");
            }

            for (int h = 0, j = 0; h + j <= 20; h++, j++)
            {
                MessageBox.Show($"h:{h} e j={j}");
            }

            var m = 1;
            for (; m <= 10; )
            {
                MessageBox.Show($"m:{m}");
                m++;
            }

            //break e continue
            //break ele interrompe o for, o continue ele deixa de executar 
            // o que tiver debaixo do for e vai pra proxima interação

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.Delegates
{
    public partial class Delegates1 : Form
    {
        public Delegates1()
        {
            InitializeComponent();
        }

        public delegate float DelegateCalculadora(float x, float y);

        public delegate void Imprimir(int valor);

        public delegate void MeuDelegate(string mensagem);


        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var resultado = Calculadora.Somar(10, 40);

            //DelegateCalculadora calc = new DelegateCalculadora(Calculadora.Somar);
            //var resultado1 = calc.Invoke(20, 30);
            //MessageBox.Show($"Soma={resultado1}");


            //DelegateCalculadora calc = Calculadora.Somar;
            //var resultado1 = calc.Invoke(20, 30);
            //MessageBox.Show($"Soma={resultado1}");

            DelegateCalculadora calc = (float x, float y) => Calculadora.Somar(x, y);
            var resultado1 = calc.Invoke(20, 30);
            MessageBox.Show($"Soma={resultado1}");


            //mult cast delegate
            MeuDelegate delegateMultCast = (msg) => Delegates1.metodo1(msg);
            delegateMultCast += metodo2;
            delegateMultCast += metodo3;
            delegateMultCast("Olá metodo multcast delegate");

            delegateMultCast -= metodo3;
            delegateMultCast("Removido delegate 3");


            // metodos anonimos
            Imprimir imprimir = delegate (int valor)
            {
                MessageBox.Show($"Método anonimo={valor}");
            };

            imprimir(100);

            List<string> nomes = new List<string>();
            nomes.Add("Alex");
            nomes.Add("Edinaldo");
            nomes.Add("Clayton");
            nomes.Add("Filipe");

            string result = nomes.Find(delegate (string nome)
            {
                return nome.Equals("Alex");
            });

            //com expressão lambda
            string result2 = nomes.Find((string nome) => nome.Equals("Alex"));


            //delegate predicate

            Predicate<int> numPar = x => x % 2 == 0;

            if (numPar(11))
            {
                MessageBox.Show("É par");
            }
            else
            {
                MessageBox.Show("Impar");
            }

        }


        static bool VerificaNomeNaLista(string nome) => nome.Equals("Alex");

        static void metodo1(string mensagem) => MessageBox.Show($"mensagem do método 1: {mensagem}");
        static void metodo2(string mensagem) => MessageBox.Show($"mensagem do método 2: {mensagem}");
        static void metodo3(string mensagem) => MessageBox.Show($"mensagem do método 2: {mensagem}");

        private void Delegates1_Load(object sender, EventArgs e)
        {

        }
    }

    public class Calculadora()
    {
        public static float Somar(float n1, float n2)
        {
            return n1 + n2;
        }

        public static float Multiplicar(float n1, float n2)
        {
            return n1 * n2;
        }

        public static float Subtrair(float n1, float n2)
        {
            return n1 - n2;
        }

        public static float Dividir(float n1, float n2)
        {
            return n1 / n2;
        }
    }

}

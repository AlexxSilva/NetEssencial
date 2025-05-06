using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.Pkcs;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.Generics
{
    public partial class Generics1 : Form
    {
        public Generics1()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //int valor1 = 10;
            //int valor2 = 10;

            //Teste1<int, int> f = new Teste1<int, int>();


            //bool resultado =  f.Comparar(valor1, valor2);

            //MessageBox.Show($"resultado: {resultado}");

            ClasseGenerica<int> objInt = new ClasseGenerica<int>();
            objInt.Adicionar(10);
            objInt.Adicionar(20);
            objInt.Adicionar(30);
            objInt.Adicionar(40);

            for (int i = 0; i < 5; i++)
            {
                MessageBox.Show($"{objInt[i]}");
            }

            //equals e gethascode

            var pessoa1 = new Pessoa(123467, "Erica");
            var pessoa2 = new Pessoa(12346, "Erica");
            MessageBox.Show(pessoa1.Equals(pessoa2).ToString());
            MessageBox.Show((pessoa1.GetHashCode() == pessoa2.GetHashCode()).ToString());



            //Dictionary---------------
            Dictionary<int, int> dic1 = new Dictionary<int, int>();
            var dic2 = new Dictionary<int, int>();

            dic2.Add(2, 100);
            dic2.Add(4, 300);
            dic2.Add(3, 400);

            var resultado = dic2.TryAdd(3, 400);// como já existe retorna false

            if (!dic2.ContainsKey(5))
            {
                dic2.Add(5, 700);
                //chave não existe
            }

            if (dic2.ContainsValue(7000))
            {
                MessageBox.Show($"Valor existe");
            }


            MessageBox.Show($"{dic2[7]}");

            if (!dic2.ContainsKey(2))
            {
                dic2[2] = 777;
                //chave não existe
            }

            if (dic2.TryGetValue(4, out int valor))
            {
                MessageBox.Show($"Valor {valor}");
            }

            foreach (var item in dic2)
            {
                MessageBox.Show($"Valor {item.Key} - {item.Value}");
            }

            var dic2Ordenado = new SortedDictionary<int, int>(dic2); //ordernar o dic2

            //ordenar com linq
            var dic2OrdenadoLinq = dic2.OrderBy(x => x.Key).ToList();


            //hashset

            var numeros = new HashSet<int> { 1, 2, 3, 4, 5, 6 };
            var frutas = new HashSet<string> { "Uva", "banana", "pera" };

            var pares = new HashSet<int>();
            for (int i = 0; i < 6; i++)
            {
                pares.Add(i * 2);
            }

            //
            var nums = new List<int>() { 1, 2, 3, 4, 5 }; // list que herda de Inumerable
            var conjunto = new HashSet<int>(nums);

            //
            var timeSP = new HashSet<string> { "Corinthians", "Palmeiras", "São Paulo" };
            var timeRJ = new HashSet<string> { "Vasco", "Flamengo", "Fluminense" };
            var timeBA = new HashSet<string> { "Bahia", "Vitoria", "Juazeiro" };

            var timesMundias = new HashSet<string> { "Santos", "Corinthians", "São Paulo", "Flamengo" };

            if (!timeSP.Contains("Santos"))
            {
                timeSP.Add("Santos");
            }

            var removeu = timeBA.Remove("Juazeiro");

            //

            if (timeSP.IsSubsetOf(timesMundias)) // time sp é um subconjunto de times mundiais.
            {

            }

            if (timesMundias.IsSupersetOf(timeSP)) // times mundiais é um super conjunto de timesp
            {

            }

            if (timeRJ.Overlaps(timesMundias)) // algum time do rj tem time mundial? items iguais nos 2
            {

            }

            if (!timeSP.SetEquals(timeRJ)) //se os times são iguais nos dois
            {

            }

            //operacoes de conjunto
            timeSP.UnionWith(timesMundias); //união dos 2
            timeSP.UnionWith(timeBA);

            var todosTimes = new SortedSet<string>(timeSP);

            ExibirColecao(todosTimes);

            //intercecção
            timeSP.IntersectWith(timesMundias); //numero entre os dois
            timeSP.ExceptWith(timesMundias); //numeros diferentes entre sp e times mundiais
            timeSP.SymmetricExceptWith(timesMundias); //numeros diferentes entre sp e times mundiais

            int[] a = { 1, 2, 3, 4 };
            Stack<int> b = new Stack<int>(a);

            /// stack
            Stack<int> numero = new Stack<int>();
            numero.Push(1);
            numero.Push(2);
            numero.Push(3);

            numero.Peek(); // retorna o primeiro elemento sem remover
            numero.Pop(); // remove o primeiro elemento da pilha

            int itens = numero.Count();


            Queue<string> diasSemana = new Queue<string>();
            diasSemana.Enqueue("Segunda");
            diasSemana.Enqueue("Terça");
            diasSemana.Enqueue("Quarta");
            diasSemana.Enqueue("Quinta");
            diasSemana.Enqueue("Sexta");

            string[] cursos = { "C#", "Python", "Java", "sql", "ASP.NET" };
            Queue<string> fila1 = new Queue<string>(cursos);

            int elementos = fila1.Count();
            
            fila1.Enqueue(".NET MAUI"); // adiciona no fim da fila
            fila1.Dequeue(); //remove o primeiro da fila.

            var elemento  = fila1.Peek();

            if (fila1.Contains(elemento))
            {
                MessageBox.Show($"Contem na fila");
            }
            ExibirFila(fila1);
            fila1.Clear();
        }

        private static void ExibirFila<T>(IEnumerable<T> fila1)
        {
            foreach (var item in fila1)
            {
                MessageBox.Show($"Valor {item}");
            }
        }

        private static void ExibirColecao<T>(IEnumerable<T> colecao)
        {
            foreach (var item in colecao)
            {
                MessageBox.Show($"{item}");
            }
        }
    }

    public class Teste1<T1, T2> where T1 : struct where T2 : struct
    {
        public bool Comparar(T1 p1, T2 p2)
        {
            MessageBox.Show($"Tipo 1: {p1.GetType()}");

            var resultado = p1.Equals(p2);

            return resultado;
        }
    }
}

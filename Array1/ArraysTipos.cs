using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.Array1
{
    public partial class ArraysTipos : Form
    {
        public ArraysTipos()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

            int[] numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //percorrer com o for
            for (int i = 0; i < numeros.Length; i++)
            {
                MessageBox.Show(numeros[i].ToString());
            }

            //com foreach
            foreach (int i in numeros)
            {
                MessageBox.Show(i.ToString());
            }



            //não precisa informar o numero de posicoes
            string[] nomes = new string[] { "Alex", "Jeniffer" };

            //sintaxe simplificada
            string[] nomes2 = { "Alex", "Jeniffer", "Pedro" };

            MessageBox.Show(nomes2[1]); //vai mostrar o nome Jeniffer

            //posso atribuir valres atravez do indice
            int[] valores = new int[2];
            valores[0] = 1;
            valores[1] = 2;
            valores[2] = 3;//aqui vai dar erro pois não existe o indice 2


            //metodos de array

            string[] nomes1 = { "Alex", "Jesse", "Filipe", "Edinaldo", "Clayton" };

            ExibeArray(nomes1);

            //inverter a ordem do array
            Array.Reverse(nomes1); //inverte o array na memoria
            ExibeArray(nomes1); // exibe o array

            //Ordernar
            Array.Sort(nomes1);
            ExibeArray(nomes1); // exibe o array

            //Ordernar
            Array.Sort(nomes1);
            ExibeArray(nomes1); // exibe o array

            var indice = Array.BinarySearch(nomes1, "Filipe");

            if (indice >= 0)
            {
                MessageBox.Show($"Nome encontrado no indice: {indice} valor: {nomes1[indice]}");
            }
            else
            {
                MessageBox.Show($"Nome não encontrado");
            }

            int[] numeross = { 1, 2, 3 };
            //calcular numeros
            int result = Soma(numeross);

            int result2 = SomaParams(1, 2, 3, 4, 5, 6);

            //array dimensional
            int[,] numeross2 = new int[3, 3];
            numeross2[0, 0] = 1;
            numeross2[0, 1] = 2;
            numeross2[0, 2] = 3;
            numeross2[1, 0] = 4;
            numeross2[1, 1] = 5;
            numeross2[1, 2] = 6;
            numeross2[2, 0] = 7;
            numeross2[2, 1] = 8;
            numeross2[2, 2] = 9;

            int[,] a = { { 0, 1 }, { 2, 3 } };


            //for com array
            int[,] n = new int[2, 3] { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int i = 0; i < n.GetLength(0); i++)
            {
                for (int j = 0; i < n.GetLength(1); i++)
                {

                }
            }


            //for com foreach
            int[,] nz = { { 11, 22, 33 },
                          { 44, 55, 66 },
                          { 77, 88, 99 } };

            foreach (int i in nz)
            {

            }

            //array list
            ArrayList lista;
            lista = new ArrayList();

            var listax = new ArrayList()
            {
                "Alex", 4.5,true
            };

            var valorr1 = listax[0];


            lista.Add("Alex");//adiciona no final
            lista.Insert(2, "Jeniffer"); //adiciona na posicao 2 e realoca os outros elementos


            var list = new ArrayList()
            {
                "Maria",
                5,
                true
            };

            bool existeMaria = list.Contains("Maria");

            int[] array1 = { 1, 2, 3 };

            list.AddRange(array1);

            list.InsertRange(2, array1);

            lista.Remove(null);//vai remover a primeira ocorrencia que tiver como null
            lista.Remove("Maria");
            lista.RemoveAt(1); //remove o da posição index 1
            lista.RemoveRange(0, 2); // remove começando da zero e duas posicoes

            lista.Sort();// ordena QuickSort
            lista.Clear(); // limpar a lista

            List<string> listanova = ["Alex", "Jeniffer"]; //count 0, capacity =0
            listanova.Add("Edinaldo"); //3 itens
            listanova.Insert(2, "Maria");// 4 itens, reposicionou

            string[] novalistaparaadd = { "Negan", "Meggie", "Marshall" };

            listanova.AddRange(novalistaparaadd);//adiciona no final
            listanova.InsertRange(1, novalistaparaadd); //adiciona no inicio



            //Lists
            var lista2 = new List<int>
            {
                1,
                2,
                3,
                4,
                5,
                6
            };


            lista2.Remove(3);
            lista2.RemoveAt(1);
            lista2.RemoveRange(0, 2);//inicia no zero e remove 2 posicoes

            //acessando elementos pelo indice
            int valorPrimeiraposicao = lista2[0];
            //alterando valor
            lista2[0] = 10;

            //percorrer
            for (int i = 0; i < lista2.Count; i++)
            {

            }

            foreach (var z in lista2)
            {

            }

            bool tem1 = lista2.Contains(1);//verificar se existe na lista

            lista2.Sort();//ordenar
            lista2.Clear();//apagar



            List<string> frutas = new() { "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango" };

            var fruta = frutas.Find(Procura);

            var fruta2 = frutas.Find(f => f.Contains('n'));

            var fruta3 = frutas.FindLast(f => f.Contains('n'));

            var fruta4 = frutas.FindIndex(f => f.Contains('n'));//retorna o indice
            string msg = $"index={fruta4} valor:{frutas[fruta4]}";

            var fruta5 = frutas.FindLastIndex(f => f.Contains('n'));//retorna o indice

            var fruta6 = frutas.FindAll(f => f.Contains('n'));//retorna o indice

            foreach (var item in fruta6)
            {
                MessageBox.Show(item);
            }


            //idexadores
            Time t = new Time();
            t[1] = "Corinthians";
            t[2] = "Santos";
            t[3] = "Palmeiras";
            t[4] = "São Paulo";
            t[5] = "Botafogo";
            t[6] = "Flamengo";
            t[7] = "Bahia";
            t[8] = "Internacional";
            t[9] = "Gremio";
            t[10] = "Bragantino";


            string primeiroTime = t[1];


            //numeros aleatorios

            Random rand = new Random();
            int[] numerosSorteados = new int[6];

            for (int i = 0; i < 6; i++)
            {
                int numeroAleatorio;
                do
                {
                    numeroAleatorio = rand.Next(1, 61);
                }while(numerosSorteados.Contains(numeroAleatorio));

                numerosSorteados[i] = numeroAleatorio;
            }

           Array.Sort(numerosSorteados);
           
            string valor = string.Join(" ", numerosSorteados);
        
        
        }

        static bool Procura(string item)
        {
            return item.StartsWith("L");
        }


        private static void ExibeArray(string[] nomes1)
        {
            foreach (string nome in nomes1)
            {
                MessageBox.Show(nome.ToString() + " ");
            }
        }


        public static int Soma(int[] numeros)
        {
            int total = 0;
            
            foreach (int numero in numeros)
            {
                total += numero;
            }

            return total;
        }

        public static int SomaParams(params int[] numeros)
        {
            int total = 0;

            foreach (int numero in numeros)
            {
                total += numero;
            }

            return total;
        }
    }

    public class Time
    {
        string[] valor = new string[10];

        //indexador
        public string this[int i]
        {
            get {
                if (i >= 0 && i < valor.Length)
                {
                    return valor[i];
                }
                return "ERRO";
            }
            set {
                if (i >= 0 && i < valor.Length)
                {
                    valor[i] = value;
                }
            }
        }
    }
}

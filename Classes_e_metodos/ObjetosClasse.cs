using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace NetEssencial.Classes_e_metodos
{
    public partial class ObjetosClasse : Form
    {
        public ObjetosClasse()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            Pessoa p1 = new Pessoa
            {
                Nome = "Alex",
                idade = 38,
                sexo = "M"
            };

            //Pessoa pessoa2 = new Pessoa
            //{
            //    nome = "Jeniffer",
            //    idade = 28,
            //    sexo = "F"
            //};

            Pessoa p2 = p1; // aponta pro mesmo objeto na heap

            Pessoa p3 = new() // nova forma
            {
                Nome = "Alex",
                idade = 38,
                sexo = "M"
            };

            string nome = "Alex", data = DateTime.Now.ToShortDateString();

            MinhaClasse minhaClasse = new();
            minhaClasse.Saudacao(nome, data);
            minhaClasse.ExibirDataAtual();

            Aluno aluno = new Aluno("", 0, "", "");// instanciando classe que tem contrutor com parametros
            Aluno aluno1 = new Aluno("Alex");

            Calculadora calc = new();
            var valor = calc.Somar(10, 10);

            //passagem de parametros por referencia
            int x = 20;
            Calculo calculo = new();
            calculo.Dobrar(ref x); // quando uso o ref a copia da referencia do local da memoria é enviada ao método.
            calculo.RestoDivisao(ref x, out string msg);
            MessageBox.Show(msg);

            calculo.EnviarEmail(titulo: "Certificado Qualidade", destino: "alex@hotmail.com", assunto: "o certificado está para vencer");
            calculo.Enviar("Diretoria");

            //metodos estaticos e variaveis estaticas
            CalculadoraEstatica.Nome = "Alex";
            CalculadoraEstatica.ExibirNome();


            int resultadoSoma = CalculadoraEstatica.Somar(10, 13);

            //struct
            Cliente c1 = new Cliente();
            c1.Nome = "Alex";
            c1.Idade = 16;

            //enum
            Console.WriteLine(DiasDaSemana.Segunda);
            
            //converte pro valor
            int dia1 = (int)DiasDaSemana.Domingo;
            //converte para o nome
            var valorDomingo = (DiasDaSemana)dia1;

            Console.WriteLine($"{DiasDaSemana.Segunda} - {(int)DiasDaSemana.Segunda}");

            //tratar excessões
            int valor1 = 10;
            int valor2 = 0;
            try
            {
                int calcular = valor1 / valor2;// erro na divisão por 0
            
            }catch (Exception ex)
            {
                Console.WriteLine("Erro de divisão por zero, tente outro numero ... ");
                Console.WriteLine(ex.Message.ToString());
                Console.WriteLine("Detalhes: " + ex?.StackTrace?.ToString());
            }
            finally 
            {
                Console.WriteLine("Processamento concluido  ... ");
            }

            //tipo anonimo
            var alunox = new
            {
                Nome = "Alex",
                Idade = 40,
                Endereco = new { Id = 1, Cidade = "SP" }
            };

            Console.WriteLine($"{alunox.Nome} - {alunox.Endereco.Cidade}");
        }

        private void ObjetosClasse_Load(object sender, EventArgs e)
        {

        }
    }

    public class Pessoa
    {
        //private string? nome;
        //public string? Nome { 

        //    get { return nome; }
        //    set { nome = value; }
        //}

        public string? Nome { get; set; }

        public int idade;
        public string? sexo;


        public void Andar()
        {
            MessageBox.Show("Estou andando ...");
        }
    }

    public class MinhaClasse
    {
        public void Saudacao(string nome, string data)
        {
            MessageBox.Show(nome);
            MessageBox.Show(data);
            ExibirDataAtual();
        }

        //formato de expressão compacto
        public void ExibirDataAtual() =>
            MessageBox.Show(DateTime.Now.ToShortDateString());

        public MinhaClasse()
        {

        }
    }

    public class Aluno
    {
        public string? Nome;
        public int Idade;
        public string? Sexo;
        public string? Aprovado;


        //public Aluno(string nome, int idade, string sexo, string aprovado) 
        //    //contrutor inicializado valores aqui o this(nome) está passado invocando o outro construtor e passando o valor como nome
        //{
        //    Nome = nome;
        //    Idade = idade;
        //    Sexo = sexo;
        //    Aprovado = aprovado;
        //}

        public Aluno(string nome, int idade, string sexo, string aprovado) : this(nome, idade)
        //contrutor inicializado valores aqui o this(nome) está passado invocando o outro construtor e passando o valor como nome
        {
            Sexo = sexo;
            Aprovado = aprovado;
        }


        public Aluno(string nome) => Nome = nome;

        public Aluno(string nome, int idade)
        {
            this.Nome = nome;
            this.Idade = idade;

        }
    }

    public class Teste
    {
        public void PassarParametro(Teste t)
        {
            
        }

        public void Exibir()
        {
            PassarParametro(this);
        }
    }

    //metodo com retorno
    public class Calculadora
    {

        public int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }
           
    }

    public class Calculo
    {
        //uso do ref
        public void Dobrar(ref int y)
        {
            y *= 2;
            Console.WriteLine($"Valor do parametro y no método dobrar: {y}");
            
        }

        //uso do out
        public void RestoDivisao(ref int y, out string msg)
        {
            msg = ""; // eu o metódo é transferido para fora do método
            int result = y % 2;
            if (result == 0)
                msg = "numero par";
            else
                msg = "numero impar";
        }

        //argumento nomeado
        public void EnviarEmail(string destino, string titulo, string assunto)
        {
            Console.WriteLine($"\nPara { destino } - {titulo} - {assunto}");
        }

        //parametros opcionais

        public void Enviar(string destino, string titulo="Reuniao", string assunto = "Avaliação")
        {
            Console.WriteLine($"\nPara {destino} - {titulo} - {assunto}");
        }



    }

    public class CalculadoraEstatica
    {
        public static string? Nome;
        public static int Idade;
        
        static CalculadoraEstatica() // contrutor para inicilizar a idade
        {
            Idade = 36;
        }

        public static void ExibirNome()
        {
            Console.WriteLine($"Nome: {Nome}");
        }

        public static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }

        public static int Multiplicar(int n1, int n2)
        {
            return n1 * n2;
        }

        public static int Dividir(int n1, int n2)
        {
            return n1 / n2;
        }

    }

    public struct Cliente
    {
        public string? Nome { get; set; }
        public int Idade { get; set; }

        public Cliente(string? nome, int idade)
        {
                Nome = nome;
                Idade = idade;  
        }
    }

    public enum DiasDaSemana
    {
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado,
        Domingo
    }
}
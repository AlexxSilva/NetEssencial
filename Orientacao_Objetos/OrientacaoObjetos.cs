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
using static System.Net.Mime.MediaTypeNames;
using Produto = NetEssencial.Orientacao_Objetos.Models.Produto;

namespace NetEssencial.Orientacao_Objetos
{
    public partial class OrientacaoObjetos : Form
    {
        public OrientacaoObjetos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Identificar(); // herdou de pessoa

            Alunos aluno = new Alunos();
            aluno.Nome = "João";
            aluno.Email = "joao@teste.com.br";
            aluno.Curso = "Analise de sistemas";
            aluno.Nota = 10;
            aluno.Identificar(); // herdou de pessoa


            //conversao

            Funcionario f = new Funcionario();
            NetEssencial.Orientacao_Objetos.Models.Pessoa p = f;//upcasting

            if (p is Funcionario) //se o p (pessoa é funcioario)
            {
                f.ListarFuncionario();
                //p.ListarFuncionario(); não existe

                //Funcionario f2 = (Funcionario)p; //Downcasting
                Funcionario? f2 = p as Funcionario; // com o operador se não converter retorna nulo
                f2?.ListarFuncionario(); // pessoa voltar a ser o funcionario// poderia usar o if pra saber se é nulo

            }

            //abstract
            Quadrado forma = new Quadrado();
            MessageBox.Show(forma.Descricao());

            MessageBox.Show("Informe a cor da figura");

            forma.Cor = "preto";

            forma.Lado = 10;

            forma.CalculaArea();
            forma.CalculaPerimetro();

            //interface
            Demo controle = new Demo();
            controle.Nome = "teste";
            controle.Desenhar();
            controle.Pintar();

            //composicao

            var categoria = new Categoria { Nome = "Bebidas" };
            var produto = new Produto { Nome = "Coca-Cola", Categoria = categoria };

            Console.WriteLine($"Produto: {produto.Nome}");
            Console.WriteLine($"Categoria: {produto.Categoria.Nome}");

            //polimorfismo - em tempo de execução

            var figuras = new List<Figura>()
            {
                new Triangulo(),
                new Circulo()
            };

            foreach (var figura in figuras)
            {
                figura.Desenhar();
            }


            //Overloading ou sobrecarga, polimorfismo em temp de compilacao
            Calcular calcular = new();
            calcular.somar(1, 2);
            calcular.somar(1, 3, 4);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Professor prof1 = new Professor("Alex", "Quimica");
            Professor prof2 = new Professor("Pedro", "Matematica");
            Professor prof3 = new Professor("Joana", "Portugues");
            Professor prof4 = new Professor("Maria", "Fisica");

            Departamento dep1 = new Departamento("Exatas");
            dep1.IncluirProfessor(prof1);
            dep1.IncluirProfessor(prof4);
            dep1.ListaProfessores();

        }
    }
}

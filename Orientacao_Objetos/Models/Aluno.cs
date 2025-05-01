using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Orientacao_Objetos.Models
{
    public class Alunos : Pessoa
    {
        public string? Curso { get; set; }
        public int Nota { get; set; }

        public Alunos() : base()
        {
            Console.WriteLine($"Contrutor da classe aluno");
        }
        public Alunos(string nome) : base(nome)
        {
            Console.WriteLine($"Contrutor da classe aluno com parametros");
        }

        public new string Saudacao() => $"Oi seu sou {Nome}";

        public override string retorno(string nome)
        {
            return base.retorno(nome);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace NetEssencial.Orientacao_Objetos.Models
{
    public class Pessoa
    {
        public string? Nome { get; set; }
        public string? Email { get; set; }


        //encapsulamento
        private string? endereco;
        public string? Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public Pessoa()
        {
            Console.WriteLine($"Contrutor da classe pessoa");
        }
        public Pessoa(string Nome)
        {
            Console.WriteLine($"Contrutor da classe pessoa com parametros");
        }

        public string Saudacao() => $"Oi seu sou {Nome}";

        public void Identificar() => Console.WriteLine($"{Nome} - {Email}"); //visivel para todas as classes dentro e fora do assembly


        internal void Exibir() => Console.WriteLine($"{Nome} - {Email}"); //visivel para todas as classes dentro do assembly



        protected void Listar() => Console.WriteLine($"listar pessoas ....");  //visivel para classe base e para classes derivadas dentro e fora do assembly


        protected internal void Mostrar() //visivel para classe base e para classes derivadas dentro do assembly
        {
            Console.WriteLine($"listar pessoas ....");
        }

        private void CriarPessoa() // visivel apenas dentro da classe base
        {
            Console.WriteLine($"criar pessoa ....");
        }

        public virtual string retorno(string nome)
        {
            return nome;
        }
    }
}

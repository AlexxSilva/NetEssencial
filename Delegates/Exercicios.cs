using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Delegates
{
    public class Exercicios
    {
        private void Dados()
        {
            var listaDePessoas = Pessoa.GetPessoas();
            
            Console.WriteLine("1- imprime o nome/idade de cada pessoa usando um delegate Action<Pessoa>");
            
            Action<Pessoa> imprimeNome =  p => Console.WriteLine(p.Nome);
            listaDePessoas.ForEach(imprimeNome);

            Console.WriteLine("2- Filtra pessoas maiores de 18 anos usando um delegate Pedicate<Pessoa>");

            Predicate<Pessoa> fitrarIdadeMaiorQue18 = p => p.Idade >= 18;
            var pessoasMaiores18Anos = listaDePessoas.FindAll(fitrarIdadeMaiorQue18);

            Console.WriteLine("3- Obtém nome/idade de pessoa mais velha utilizando um delegate Func<Pessoa>");

            Func<Pessoa, int> obterIdade = p => p.Idade;
            var pessoaMaisVelha = listaDePessoas.MaxBy(obterIdade);// C#10
            //int idadeMaxima = listaDePessoas.Max(obterIdade);
            //var pessoaMaisVelha = listaDePessoas?.Find(p => p.Idade == idadeMaxima);

            Console.WriteLine($"A pessoa mais velha é { pessoaMaisVelha.Nome } de idade {pessoaMaisVelha.Idade }");
        
            
        }
    }

    public class Pessoa
    {

        public Pessoa(string? nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string? Nome { get; set; }
        public int Idade { get; set; }

        public static List<Pessoa> GetPessoas()
        {
            return new List<Pessoa>()
            {
                new Pessoa("João", 20),
                new Pessoa("Maria", 18),
                new Pessoa("Pedro", 25),
                new Pessoa("Carlos", 15),
                new Pessoa("Ana", 17),
            };
        }
    }
}

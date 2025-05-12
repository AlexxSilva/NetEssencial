using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Delegates
{
    public class ExemplosDelegatePredicate
    {
        private void Exemplo1()
        {
            //exemplo tradicional
            Console.WriteLine("Informe um numero inteiro:");
            
            int numero = Convert.ToInt32(Console.ReadLine());
            if (VerificaPar(numero))
            {
                Console.WriteLine($"O numero {numero} é par");
            }
            else
            {
                Console.WriteLine($"O numero {numero} é impar");
            }
        }

        public delegate bool DelegatePar(int x);

        private void Exemplo2()
        {
            //exemplo com delegate
            Console.WriteLine("Informe um numero inteiro:");

            int numero = Convert.ToInt32(Console.ReadLine());

            DelegatePar delegatePar = VerificaPar;

            if (delegatePar(numero))
            {
                Console.WriteLine($"O numero {numero} é par");
            }
            else
            {
                Console.WriteLine($"O numero {numero} é impar");
            }
        }


        private void Exemplo3()
        {
            //exemplo com delegate predicate
            Console.WriteLine("Informe um numero inteiro:");

            int numero = Convert.ToInt32(Console.ReadLine());

            Predicate<int> delegatePar = VerificaPar;

            if (delegatePar(numero))
            {
                Console.WriteLine($"O numero {numero} é par");
            }
            else
            {
                Console.WriteLine($"O numero {numero} é impar");
            }
        }


        private void Exemplo4()
        {
            //exemplo com delegate predicate com expressão lambda
            Console.WriteLine("Informe um numero inteiro:");

            int numero = Convert.ToInt32(Console.ReadLine());

            Predicate<int> delegatePar = x => x % 2 == 0;

            if (delegatePar(numero))
            {
                Console.WriteLine($"O numero {numero} é par");
            }
            else
            {
                Console.WriteLine($"O numero {numero} é impar");
            }
        }


        static bool VerificaPar(int x)
        {
            if (x % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NetEssencial.Delegates
{
    public class ExemploDelegateAction
    {
        private void Exemplo1()
        {
            //exemplo action
            Console.WriteLine("Informe um numero inteiro:");

            int numero = Convert.ToInt32(Console.ReadLine());

            Action<int> dobra = Duplicar;
            dobra(numero);
        
        }


        private void Exemplo2()
        {
            //exemplo metodo anonimo
            Console.WriteLine("Informe um numero inteiro:");

            int numero = Convert.ToInt32(Console.ReadLine());

            Action<int> dobra = delegate (int x)
            {
                Console.WriteLine(x * 2);
            };

        }

        private void Exemplo3()
        {
            //exemplo expressão lambda
            Console.WriteLine("Informe um numero inteiro:");

            int numero = Convert.ToInt32(Console.ReadLine());

            Action<int> dobra = x =>  Console.WriteLine(x * 2);

        }

        static void Duplicar(int num)
        {
            int resultado = num * 2;
            Console.WriteLine(resultado);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Delegates
{
    public class ExemploDelegateFunc
    {

        private void Exemplo1()
        {
            //exemplo tradicional
            Console.WriteLine("Informe um numero:");

            double numero = Convert.ToDouble(Console.ReadLine());

            var resultado = CalculaRaiz(numero);

            Console.WriteLine($"A raiz quadrada de {numero} é {resultado}");

        }

        private void Exemplo2()
        {
            //exemplo com func
            Console.WriteLine("Informe um numero:");

            double numero = Convert.ToDouble(Console.ReadLine());

            Func<double, double> raizQuadrada = CalculaRaiz;

            var resultado = raizQuadrada;

            Console.WriteLine($"A raiz quadrada de {numero} é {resultado}");
        }


        private void Exemplo3()
        {
            //exemplo com metodo anonimo
            Console.WriteLine("Informe um numero:");

            double numero = Convert.ToDouble(Console.ReadLine());

            Func<double, double> raizQuadrada = delegate (double x)
            {
                 return Math.Sqrt(numero);
            };

            var resultado = raizQuadrada;

            Console.WriteLine($"A raiz quadrada de {numero} é {resultado}");
        }


        private void Exemplo4()
        {
            //exemplo com expressão lambda
            Console.WriteLine("Informe um numero:");

            double numero = Convert.ToDouble(Console.ReadLine());

            Func<double, double> raizQuadrada = x => Math.Sqrt(x);

            var resultado = raizQuadrada;

            Console.WriteLine($"A raiz quadrada de {numero} é {resultado}");
        }


        static double CalculaRaiz(double numero)
        {
            return Math.Sqrt(numero);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.ProgramacaoAssincrona
{

    internal class semaphore
    {
        static Semaphore sema;

        private void semaforo()
        {
            sema = new Semaphore(1, 2);
            Console.WriteLine("Incluiu a thread no semaforo");
            sema.WaitOne(); //inclui a tread no semaforo

            Console.WriteLine("Executa método");

            //libera a thread no semaforo
            sema.Release();

            Console.WriteLine("Liberou a thread");
        }
    
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.ProgramacaoAssincrona
{
    internal class MultiplasExcecoesAsync
    {

        public async Task LancaMultiplasExcecoesAsync()
        {
            Task? tarefas = null;

            try
            {
                var primeiraTask = Task.Run(() =>
                {
                    Task.Delay(1000);
                    throw new IndexOutOfRangeException("IndexOutOfRangeException explicitamente ...");
                });

                var segundaTask = Task.Run(() =>
                {
                    Task.Delay(1000);
                    throw new InvalidOperationException("InvalidOperationException explicitamente ...");
                });

                tarefas = Task.WhenAll(primeiraTask, segundaTask); //sem await não capitura nenhuma exceção

                await tarefas;
            
            }
            catch
            {
                Console.WriteLine("Ocorreram exceções");
                AggregateException todasExcecoes = tarefas.Exception;

                foreach (var ex in todasExcecoes.InnerExceptions)
                {
                    Console.WriteLine(ex.GetType().ToString());
                }
            
            }
            //catch (IndexOutOfRangeException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //catch (InvalidOperationException ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
    }
}

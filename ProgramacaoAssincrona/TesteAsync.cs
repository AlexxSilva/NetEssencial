using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.ProgramacaoAssincrona
{
    internal class TesteAsync
    {
        public Task MinhaTarefaAsync()
        {
            return Task.Run(() => {
                Task.Delay(2000);
                throw new Exception("Minha Exception ...");
            });
        }

        public async Task ChamadaTarefaAsync()
        {
            await MinhaTarefaAsync();
        }


        static private async IAsyncEnumerable<string> GeraMeses()
        {
            yield return "Janeiro";
            yield return "Fevereiro";
            yield return "Março";
            await Task.Delay(2000);
            yield return "Abril";
            yield return "Maio";
        }

    }
}

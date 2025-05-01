using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Orientacao_Objetos.Models
{
    public interface IControle
    {
        public string Nome { get; set; }
        void Desenhar();

        public void Exibir()
        {
            Console.WriteLine("Teste");
        }
    }
}

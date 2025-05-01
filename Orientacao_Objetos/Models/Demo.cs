using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Orientacao_Objetos.Models
{
    public class Demo : IControle, IGrafico
    {
        public string Nome { get ; set; } = string.Empty;

        public void Desenhar()
        {
            Console.WriteLine("Desenhar");
        }

        public void Pintar()
        {
            Console.WriteLine("Pintar");
        }
    }
}

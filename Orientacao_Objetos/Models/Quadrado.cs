using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Orientacao_Objetos.Models
{
    public class Quadrado : Forma
    {
        public double Lado { get; set; }
        public override void CalculaArea()
        {
            Area = Lado * Lado;
        }
        public override void CalculaPerimetro()
        {
            Perimetro = 4 * Lado;
        }
    }
}

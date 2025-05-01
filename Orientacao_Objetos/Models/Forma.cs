using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Orientacao_Objetos.Models
{
    public abstract class Forma
    {
        public string? Cor { get; set; }
        public double Area { get; set; }
        public double Perimetro { get; set; }

        public abstract void CalculaArea();
        public abstract void CalculaPerimetro();

        //metodo comum

        public string Descricao()
        { 
            return "Sou a classe abstrata Forma";
        }
    }
}

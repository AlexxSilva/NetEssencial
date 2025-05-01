using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Orientacao_Objetos.Models
{
    public class Triangulo : Figura
    {
        public override void Desenhar()
        {
            MessageBox.Show("Desenhando um circulo");
        }
    }
}

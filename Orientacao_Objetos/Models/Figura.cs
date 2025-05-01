using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetEssencial.Orientacao_Objetos.Models
{
    public class Figura // classe base
    {
        public virtual void Desenhar()
        {
            MessageBox.Show("Executando Desenhar na classe Base");

        }
    }
}

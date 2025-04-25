using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.Incremento_Decremento1
{
    public partial class incremento_decremento : Form
    {
        public incremento_decremento()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int x = 10;
            x++;

            int y = 8;
            y--;

            //pos incremento
            int a = 0;
            int resultadoa = a++ + 10; // aqui ele resolve a equacao primeiro dando 10, e o valor de a fica 1;

            // pre incremento
            int b = 0;
            int resultadob = b++ + 10; // aqui ele incrementa antes de dar o resultado da equacao entao da 11


        }
    }
}

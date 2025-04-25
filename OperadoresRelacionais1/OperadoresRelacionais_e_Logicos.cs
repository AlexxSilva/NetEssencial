using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.OperadoresRelacionais1
{
    public partial class OperadoresRelacionais_e_Logicos : Form
    {
        public OperadoresRelacionais_e_Logicos()
        {
            InitializeComponent();
        }

        private void btnOperadores_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 20;

            bool resultado = x == y;

            bool resultadoeq = x.Equals(y);
            
            bool resultado1 = x > y;
            bool resultado2 = x < y;
            bool resultado3 = x >= y;
            bool resultado4 = x <= y;
            bool resultado5 = x != y;


            //operador logico
            bool c1 = 4 >= 7;
            bool c2 = 9 != 8;
            bool result;

            result = c1 && c2; //false

            result = c1 || c2; //true

            result = !c2; //false

            //ordem de precedencia *, depois -
            int xvr = 10 - 2 * 3;
            
            //primeiro - depois * por conta do parenteses
            int xvr2 = (10 - 2) * 3;

           //primeiro !, &&, ||
            bool b = !(9 != 8) && 5 >= 7 || 8 >= 6;
        

            int a=5,c=6,d=4;
            
            //++, --, *, -
            int r = --a * c - ++c;
        }
    }
}

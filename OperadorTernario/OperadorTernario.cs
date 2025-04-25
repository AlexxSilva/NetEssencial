using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.OperadorTernario
{
    public partial class OperadorTernario : Form
    {
        public OperadorTernario()
        {
            InitializeComponent();
        }

        private void btnOperadores_Click(object sender, EventArgs e)
        {
            int positivo = 1;
            int resultado;
            resultado = +positivo; // resultado = 1

            int negativo = 1;
            int result;
            result = -negativo; //-1

            double temp = 1;


            string valortemp = temp > 35 ? " valor 1" : temp > 25 ? "valor2" : "valor3";

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.OperadoresAritmeticos1
{
    public partial class OperadoresAritmeticos : Form
    {
        public OperadoresAritmeticos()
        {
            InitializeComponent();
        }

        private void btnOperadores_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 100;
            //var1 = 10;
            //var2 = 10;
            //int result = var1 + var2 + valor6;

            MessageBox.Show($"soma de x+y = {x + y}" + "\n" +
              $"subtração de x-y = {x - y}" + "\n" +
              $"multplicação de x*y = {x * y}" + "\n" +
              $"divisão de x/y = {x / y}" + "\n" +
              $"resto divisão de x%y = {x % y}" + "\n" +
              $"raiz quadrada de x = { Math.Sqrt(x)}" + "\n"
                , "msg"
                , MessageBoxButtons.OK);
        }
    }
}

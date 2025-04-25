using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.OperadoresAtribuicao1
{
    public partial class Atribuicao : Form
    {
        public Atribuicao()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var x = 10;
            x += 5;
            x -= 3;
            x *= 4;
            x /= 5;
            x %= 5;

            //atribuição de strings
            var y = "123";
            y += "456";

            MessageBox.Show(y.ToString()
            , "msg"
            , MessageBoxButtons.OK);
        }
    }
}

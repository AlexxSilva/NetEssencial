using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.SaidaDados
{
    public partial class SaidaDados : Form
    {

        int idade = 25;
        string nome = "Maria";

        public SaidaDados()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(nome);
            sb.Append(" tem");
            sb.Append(idade);
            sb.Append(" anos");

            MessageBox.Show(sb.ToString()
               , "msg"
               , MessageBoxButtons.OK);
        }
    }
}

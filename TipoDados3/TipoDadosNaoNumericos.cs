using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.TipoDados3
{
    public partial class TipoDadosNaoNumericos : Form
    {

        bool ativo = true;
        Boolean inativo = false;

        char letra1 = 'A';
        char letra2 = '\u0041'; // \u indica que é caracter unicode

        public TipoDadosNaoNumericos()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {


            MessageBox.Show(ativo.ToString() + "\n" +
          inativo.ToString() + "\n" +
          (10 == 15).ToString() + "\n" +
          (10 < 15).ToString() + "\n" +
          (letra1).ToString() + "\n" +
          (letra2).ToString() + "\n"
          , "msg"
          , MessageBoxButtons.OK);
        }
    }
}

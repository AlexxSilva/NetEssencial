using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.TipoDados2
{
    public partial class TipoFlutuante : Form
    {
        double n1 = 1.234;
        float n2 = 1.234F;
        decimal n3 = 1.234m;

        public TipoFlutuante()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            float x = 1f / 3f;
            double y = 1d / 3d;
            decimal z = 1m / 3m;

            MessageBox.Show(n1.ToString() + "\n" +
             n2.ToString() + "\n" +
             n3.ToString() + "\n" +
              x.ToString() + "\n" +
               y.ToString() + "\n" +
               z.ToString() + "\n"
             , "msg"
             , MessageBoxButtons.OK);
        }
    }
}

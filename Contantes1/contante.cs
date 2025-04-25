using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.Contantes1
{
    public partial class contante : Form
    {

        const int DIAS_ANO = 365, MESES_ANO = 12;
        public contante()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            const float  DIA_POR_MES = (float)DIAS_ANO / (float)MESES_ANO;
        }
    }
}

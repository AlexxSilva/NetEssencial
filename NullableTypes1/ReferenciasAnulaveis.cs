using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.NullableTypes1
{
    public partial class ReferenciasAnulaveis : Form
    {
        public ReferenciasAnulaveis()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string? nome = null;
            nome?.ToUpper();
        }
    }
}

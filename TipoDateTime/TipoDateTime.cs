using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.TipoDateTime
{
    public partial class TipoDateTime : Form
    {
        DateTime dataAtual = DateTime.Now;



        DateTime dataHoje = new DateTime(2022,09,06);
        DateTime dataHoraHoje = new DateTime(2022, 09, 06, 10, 22, 30);
        public TipoDateTime()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            int ano = dataAtual.Year;
            int mes = dataAtual.Month;
            int dia = dataAtual.Day;
            int hora = dataAtual.Hour;
            int minuto = dataAtual.Minute;
            int segundo = dataAtual.Second;
            int milisegudo = dataAtual.Millisecond;



            dataAtual = dataAtual.AddDays(1);
            DayOfWeek diaSemana = dataAtual.DayOfWeek;

            MessageBox.Show(dataAtual.ToString() + "\n" +
                   dataHoje.ToString() + "\n" +
                   dataHoraHoje.ToString() + "\n" +
                    dataHoje.ToString() + "\n" +
                     diaSemana.ToString() + "\n"
                       , "msg"
                       , MessageBoxButtons.OK);
        }
    }
}

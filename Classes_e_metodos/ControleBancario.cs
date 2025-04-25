using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.Classes_e_metodos
{
    public partial class ControleBancario : Form
    {
        public ControleBancario()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            ContaCorrente c1 = new ContaCorrente();
            c1.Conta = 101;
            c1.Nome = "Maria";


            ContaCorrente c2 = new ContaCorrente();
            c1.Conta = 102;
            c1.Nome = "Marta";

            ContaCorrente.Juros = 4.25f;

            Console.WriteLine($"Cliente : {c1.Nome} - Juros Anual: {c1.JurosAnual}");
            Console.WriteLine($"Cliente : {c2.Nome} - Juros Anual: {c2.JurosAnual}");
        }
    }

    public class ContaCorrente
    {
        public int Conta;
        public string? Nome;
        public static float Juros;

        public float JurosAnual()
        {
            return Juros * 12;
        }

    }
}

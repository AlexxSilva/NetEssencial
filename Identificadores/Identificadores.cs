using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.Identificadores
{

    public partial class Identificadores : Form
    {
        //identificadoresvalidos
        string nome;
        string nomeCompleto;
        int idade;
        int _valor;
        int idade1;

        //camel case
        string descontoTotal;
        string desconto_Total;

        //contantes
        double PI = 3.14;
        string PREFIXO = "11";
        string PREFIXO_SP = "11";


        public Identificadores()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {

        }
    }

    //pascal case
    class ImprimirTexto
    {
        public void ImprimeNome()
        {
            MessageBox.Show("Alex Silva"
             , "msg"
             , MessageBoxButtons.OK);
        }
    }

}

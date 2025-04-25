using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.ConversaoTipos1
{
    public partial class ConversaoTipos : Form
    {
        public ConversaoTipos()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //conversão implicita
            int varInt = 100; // int usa 4 bytes
            double varDouble = varInt; //8 bytes// permite converter para variaveis de tamanho maior em tipo de dados valor 
            decimal varDecimal = varInt;
            MessageBox.Show(varDouble.ToString() 
                        , "msg"
                        , MessageBoxButtons.OK);

            //conversão explicita
            double varDouble2 = 12.456;
            int valor = (int)varDouble2; //cast - conversão explicita

            MessageBox.Show(valor.ToString()
                        , "msg"
                        , MessageBoxButtons.OK);

            //conversão tostring
            int valorInt = 123;
            double valorDouble = 12.45;
            decimal valorDecimal = 12.45678m;
            string s1 = valorInt.ToString();
            string s2 = valorDouble.ToString();
            string s3 = valorDecimal.ToString();

            //classe converter
            string intString = Convert.ToString(valorInt);
            int numero = Convert.ToInt32(valorInt);


            int varInts = 10000;
            Convert.ToByte(varInts);// OverflowExeption - byte menor que a quantiadade
        }
    }
}

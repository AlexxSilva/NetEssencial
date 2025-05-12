using NetEssencial.MetodoExtensao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.TipoDados4
{
    public partial class TipoReferencia : Form
    {
        string nome = "curso c#";
        String titulo = "curso c# essencial";

   
        public TipoReferencia()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            string valor = "é uma string";
            valor = "string alterada";
            valor = "teste"; // variaveis string são imutaveis (sempre que adiciono um valor na string ele aloca outro espaço de memoria
            //usar string builder.
            object nota = 10;
            object valor1 = 8.55m;
            object Nome1 = "maria";
            dynamic ativa = true;
            dynamic letra = 'A'; // usar com Reflection ou uso de linguaguens dinamicas.

            //dynamic e object são equivalentes

            MessageBox.Show(nota.ToString() + "\n" +
                        valor1.ToString() + "\n" +
                        (Nome1).ToString() + "\n" +
                        (ativa).ToString() + "\n" +
                        (letra).ToString() + "\n"
                        , "msg"
                        , MessageBoxButtons.OK);

            string texto = "Usando métodos de extensão";
            string textoInvertido = texto.InvertString();
        }
    }
}

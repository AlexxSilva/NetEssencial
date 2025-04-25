using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetEssencial.NullableTypes1
{
    public partial class SaidaDados : Form
    {
        Nullable<int> valor = null;
        int? valor2 = 10;

        public SaidaDados()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            //converter tipo anulavel para não anualavel
            int? a = null;
            int b = a??0; //"conciliência nula //se a não for nulo ele retorna o valor, se não retorna 0.


            if (valor2.HasValue)
            {
                MessageBox.Show(valor2.Value.ToString()
              , "msg"
              , MessageBoxButtons.OK);
                //o valor não é nulo
            }
            else
            {
                //o valor é nulo
            }



            MessageBox.Show(valor.ToString() + "\n"+
                valor2.ToString() + "\n"
              , "msg"
              , MessageBoxButtons.OK);
        }
    }
}

// Operador ?. (Null Conditional Operator)
//Evita exceções ao acessar membros de objetos que podem ser null.

//Operador ?? (Null Coalescing Operator)
//Fornece um valor padrão caso uma variável seja null.

//Operador ??= (Null Coalescing Assignment)
//Atribui um valor somente se a variável for null.
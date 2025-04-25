namespace NetEssencial.TipoDados1
{
    public partial class TipoDadosNumericos : Form
    {
        byte valor1 = 255;
        sbyte valor2 = -127;
        int valor3 = -2147483647;
        uint valor4 = 2147483647;
        long valor5 = -2147483647293;
        int var1, var2;
        const int valor6 = 1;
        public TipoDadosNumericos()
        {
            InitializeComponent();
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            var1 = 10;
            var2 = 10;
            int result = var1 + var2 + valor6;

            MessageBox.Show(valor1.ToString() + "\n" +
                valor2.ToString() + "\n" +
                valor3.ToString() + "\n" +
                valor4.ToString() + "\n" +
                valor5.ToString() + "\n" +
                result.ToString() + "\n"
                , "msg"
                , MessageBoxButtons.OK);
        }
    }
}

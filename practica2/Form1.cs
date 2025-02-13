namespace practica2
{
    public partial class Form1 : Form
    {
        public Decimal vResultado1, vResultado2;//declaracion de variables
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtvalores1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblresul1_Click(object sender, EventArgs e)
        {

        }

        private void btbconver1_Click(object sender, EventArgs e)
        {

        }

        private void lblresultado1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btbconvertir1_Click(object sender, EventArgs e)
        {
            vResultado1 = Convert.ToDecimal(txtingreso1.Text) * 9 / 5 + 32;//es para convertir los valores en f
            lblresultado1.Text = vResultado1.ToString() + "F";
        }

        private void txtingreso1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnconvertir2_Click(object sender, EventArgs e)
        {
            vResultado2 = (Convert.ToDecimal(txtingresar2.Text) - 32) * 5 / 9;//linea para convertir en C respeando la gerarquia
            lblresultado2.Text = vResultado2.ToString() + "C";

        }
    }
}

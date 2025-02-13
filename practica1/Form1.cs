using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica1
{
    public partial class Form1: Form
    {
        public decimal vResultado;//declarcion de valores
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblSigno_Click(object sender, EventArgs e)
        {

        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToDecimal(txtNum1.Text) + Convert.ToDecimal(txtNum2.Text);//esta linea sirve para convertir
            lblResult.Text = vResultado.ToString();// esta linea te ayuda a arrogar los resultados
            lblSigno.Text = "+";

        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToDecimal(txtNum1.Text) - Convert.ToDecimal(txtNum2.Text);
            lblResult.Text = vResultado.ToString();
            lblSigno.Text = "-";
        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToDecimal(txtNum1.Text) * Convert.ToDecimal(txtNum2.Text);
            lblResult.Text = vResultado.ToString();
            lblSigno.Text = "*";
        }

        private void btnDivi_Click(object sender, EventArgs e)
        {
            vResultado = Convert.ToInt32(txtNum1.Text) / Convert.ToInt32(txtNum2.Text);
            lblResult.Text = vResultado.ToString();
            lblSigno.Text = "/";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)//estas linea con las siguientes te ayudara a limpiar el formato
        {
            txtNum1.Text = " ";
            txtNum2.Text = " ";
            lblResult.Text = "000";
            lblSigno.Text = "?";
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();//esta linea te ayudara a cerrar el programa
        }
    }
}

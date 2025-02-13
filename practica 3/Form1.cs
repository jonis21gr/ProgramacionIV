using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica_3
{

    public partial class Form1 : Form
    {
        public double Vresultado;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblingre_Click(object sender, EventArgs e)
        {
         //linea de comentario
        }
        // el sigueinte codigo es para sacar el perimetro de un circulo para sacar el area es la siguiente formula pi*radio al cuadrado
        private void btnarea_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(txtresult.Text) * Convert.ToDouble(txtresult.Text);
            double area = (Math.PI * radio * radio); // linea de codigo para hacer la operacion
            lblresult.Text = "Area: " + area;//donde esta tu variable para llevar al resultado
        }

        private void lblresult_Click(object sender, EventArgs e)
        {

        }

        private void txtresult_TextChanged(object sender, EventArgs e)
        {

        }
        // el sigueinte codigo es para sacar el perimetro de un circulo para sacar el perimetro es la siguienteformula 2*pi*radio
        
        private void btnperi_Click(object sender, EventArgs e)
        {
            double radio = Convert.ToDouble(txtresult.Text) * Convert.ToDouble(txtresult.Text);
            double perimetro = (2 * Math.PI * radio); // linea de codigo para hacer la operacion
            lblresult2.Text = "Perimetro" + perimetro; //donde esta tu variable para llevar al resultado
        }

        private void lblresult2_Click(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

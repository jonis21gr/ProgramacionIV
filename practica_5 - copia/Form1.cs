using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Resources.ResXFileRef;

namespace practica_5
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        //el boton de calcular declararemos una variable que se utilizara para
        //poder calcular el promedio
        private void btncalcular_Click(object sender, EventArgs e)
        {
            // son variable para declarar
            double parcial1, parcial2, parcial3, promedio;

            //double Parse se convierte directamente un stringen double, para
            //detectar algun error

            parcial1 = double.Parse(txtpar1.Text);
            parcial2 = double.Parse(txtpar2.Text);
            parcial3 = double.Parse(txtpar3.Text);

            //codigo para calcular el promedio
            promedio = (parcial1 + parcial2 + parcial3) / 3;

            //abriremos un if para saber las condion de las calificaciones
            if (promedio >= 95)
            {
                txtcondicion.Text = "EXENTO";
                txtprom.Text = promedio.ToString();
            }
            else
            {
                //abriremos un if anidado para saber las condion de las calificaciones
                if (promedio >= 70)
                {
                    txtcondicion.Text = "ORDINARIO";
                    //aqui convirtimos el valor numérico promedio a una cadena de string
                    txtprom.Text = promedio.ToString();
                }
                else
                {
                    if (promedio >= 50)
                    {
                        txtcondicion.Text = "EXTRAORDINARIO";
                        txtprom.Text = promedio.ToString();
                    }
                    else
                    {
                        txtcondicion.Text = "ESPECIAL";
                        txtprom.Text = promedio.ToString();
                    }
                }
            }


        }

        private void txtprom_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnombre_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            txtpar1.Text = "";
            txtpar2.Text = "";
            txtpar3.Text = "";
            txtnombre.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

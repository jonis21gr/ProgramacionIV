using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercicio_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (txtusuario.Text == "Jonis" && txtcontra.Text == "jonis2004"//abrimos un if para agregar el usuario y la conraseña
                //y verifica que sean correctos  
            {
                //mosrar from 2
                //te mostrara el segundo formulario ya despues de que pusimos la contraseña y usuario correcto
                formulario2 formulario2 = new formulario2();
                formulario2.Show();
                this.Hide();
            }
            else
            {
                // la siguiente linea te arrogara un mensaje a pantalla si proporcionaron los datos mal
                MessageBox.Show("you re  entered incorrect login details");
            }
        }
    }
}

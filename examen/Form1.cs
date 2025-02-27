using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace examen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //este apartado ejecuta cuando cambia el estado del RadioButton
        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }
        //ejecuta cuando el usuario selecciona un día en el ComboBox
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //ahora si se viene lo bueno
       //este boton al momento de dar clicl va seleccionar el signo denro de este boton viene todo programado
        private void btnsigno_Click(object sender, EventArgs e)
        {
            //el usuario seleciona en el combobox un dia por eso utilizamos la propiedad selecteditem
            //el null es para dar entender que no ahi nada seleccionado
            if (comboBox1.SelectedItem == null)
            {
                // Muestra un mensaje de error si no se ha seleccionado un día por eso se utilzo anteriorente el ==null
                MessageBox.Show("Seleccione un día.");
            }
            // Convierte el día seleccionado en un número entero
            // aqui mismo declaramos el dia con un int y el mes con un string
            int day = Convert.ToInt32(comboBox1.SelectedItem);
            // Obtiene el mes seleccionado de los RadioButtons
            //el getselectedmonth es una funcion que es para obtener el mes seleccionado entre todos los radiobuton
            //y madar el texto del mes seleccionado por el usuario
            string month = GetSelectedMonth();
            // invesigado en google un metodo y encontre el isnullorempty este lo implemente para detectar si el mes esta vacio
           
            if (string.IsNullOrEmpty(month))
            {
                //Muestra un mensaje de error si no se ha seleccionado un mes
                MessageBox.Show("Seleccione un mes.");
            }
            // Obtiene el signo zodiacal correspondiente con la variable string zodiacal al día y mes seleccionados 
            // el getzodiacalsing me ayudara para implemetar un forech donde me sa el dia y el mes
            string zodiacal = GetZodiacSign(day, month);
            // este txtbox muestra el signo zodiacal al usuario
            txtsigno.Text = zodiacal;
        }

        private string GetSelectedMonth()
        {
            // Recorre todos los controles dentro del formulario
            foreach (Control control in this.Controls)
            {
                // Verifica si el control es un RadioButton y si está seleccionado Checked == true
                if (control is RadioButton rb && rb.Checked)
                {
                    return rb.Text; // Devuelve el texto del RadioButton seleccionado que representa el mes
                }
            }
            return string.Empty; // Si no se encuentra ningún mes seleccionado, devuelve una cadena vacía
        }

        private string GetZodiacSign(int day, string month)
        {
            switch (month)
            {
                case "Enero": return day <= 19 ? "Capricornio" : "Acuario";
                case "Febrero": return day <= 18 ? "Acuario" : "Piscis";
                case "Marzo": return day <= 20 ? "Piscis" : "Aries";
                case "Abril": return day <= 19 ? "Aries" : "Tauro";
                case "Mayo": return day <= 20 ? "Tauro" : "Géminis";
                case "Junio": return day <= 20 ? "Géminis" : "Cáncer";
                case "Julio": return day <= 22 ? "Cáncer" : "Leo";
                case "Agosto": return day <= 22 ? "Leo" : "Virgo";
                case "Septiembre": return day <= 22 ? "Virgo" : "Libra";
                case "Octubre": return day <= 22 ? "Libra" : "Escorpio";
                case "Noviembre": return day <= 21 ? "Escorpio" : "Sagitario";
                case "Diciembre": return day <= 21 ? "Sagitario" : "Capricornio";
                default: return "Desconocido";
            }
        }
    }
}
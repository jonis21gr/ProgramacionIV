using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica5
{
    public partial class Form1 : Form
    {
        //agregamos una variable que ocuparemos en otras lineas
        int vIndice;// no guarda el indice seleccionado en la table
        public Form1()
        {
            InitializeComponent();
        }

        private void name_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //lineas de codigo para agregar los paises 
            cbboxPais.Items.Add("Mexico");
            cbboxPais.Items.Add("Alemania");
            cbboxPais.Items.Add("China");
            cbboxPais.Items.Add("Japon");
            cbboxPais.Items.Add("España");
        }
        String Vseleccion; //se agrega una variable en tipo texto para hacer cadena de texto
        private void button1_Click(object sender, EventArgs e)
        {

            //linea de cofigo para agregar cada dao a cada campo que correspode
            Vseleccion = Convert.ToString(cbboxPais.Text);
            int vIndice = dataGridView1.Rows.Add();
            dataGridView1.Rows[vIndice].Cells[0].Value = txtname.Text;
            dataGridView1.Rows[vIndice].Cells[1].Value = txtlast.Text;
            dataGridView1.Rows[vIndice].Cells[2].Value = Vseleccion;

            //codigo para poner en blanco los text
            txtname.Text = "";
            txtlast.Text = "";
            cbboxPais.Text = "";

        }

        private void cbboxPais_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            vIndice = e.RowIndex;
        }

        private void btnr_Click(object sender, EventArgs e)
        {// linea para que se elemine los daos seliccionados en la tabla los cuales se guardaron en la variable vindece
            if (vIndice != -1)
            {
                dataGridView1.Rows.RemoveAt(vIndice);
            }
            else
            {
                MessageBox.Show("selected Item Incorrect");
            }
        }
       


    }
}
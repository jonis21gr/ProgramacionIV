using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EJERCICIO3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btncal_Click(object sender, EventArgs e)
        {
            double vnum1 = 0.0;
            double vnum2 = 0.0;
            double vresult = 0.0;

            vnum1 = Convert.ToDouble(txtnum1.Text);
            vnum2 = Convert.ToDouble(txtnum2.Text);
            if (RBSUMA.Checked == true)
            {
                vresult = vnum1 + vnum2;
            }
            if (RBRESTA.Checked == true)
            {
                vresult = vnum1 - vnum2;
            }
            if (RBMULT.Checked == true)
            {
                vresult = vnum1 * vnum2;
            }
            if (RBDIV.Checked == true)
            {
                vresult = vnum1 / vnum2;
            }
            lblres.Text = vresult.ToString();
        }
    }
}
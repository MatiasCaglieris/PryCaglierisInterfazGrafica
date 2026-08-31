using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryCasaleInterfazGrafica
{
    public partial class FormConversor : Form
    {
        public FormConversor()
        {
            InitializeComponent();
        }

        private void FormDescuentoTienda_Load(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
         

        }

        private void textMetros_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            //declarar variables
            double kilometros;
            double centimetros;
            double metros;

            //leer las variables

            kilometros = Convert.ToDouble(txtKilometros.Text);

            //metros = Convert.ToDouble(txtMetros.Text);

            //operaciones

            centimetros = kilometros * 100000;
            metros = kilometros * 100;
            //kilometros = metros / 1000;

            txtMetros.Text = metros.ToString();
            txtCentimetros.Text = centimetros.ToString();
            //txtKilometros.Text = metros.ToString();

        }
    }
}

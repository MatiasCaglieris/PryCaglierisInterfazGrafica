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
    public partial class frmBoton : Form
    {
        public frmBoton()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //variables
            string Nombre = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Edad = txtEdad.Text;
            string carrera = txtCarrera.Text;

            //mensajes
            lblMensaje.Text = $"hola soy {Nombre} {Apellido} tengo {Edad} años y estudio {carrera}";  
        }

        private void frmBoton_Load(object sender, EventArgs e)
        {
            

            
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtNombre.Text != "")
            {
                txtApellido.Enabled = true;
            }
            else
            {
                txtApellido.Enabled = false;
            }
        }

        private void txtCarrera_TextChanged(object sender, EventArgs e)
        {
            if (txtCarrera.Text != "")
            {
                ButtonPresentar.Enabled = true;
            }
            else
            {
                ButtonPresentar.Enabled = false;
            }
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtApellido.Text != "")
            {
                txtEdad.Enabled = true;
            }
            else
            {
                txtEdad.Enabled = false;
            }
        }

        private void txtEdad_TextChanged(object sender, EventArgs e)
        {
            if (txtEdad.Text != "")
            {
                txtCarrera.Enabled = true;
            }
            else
            {
                txtCarrera.Enabled = false;
            }
        }

        private void txtNombre_Click(object sender, EventArgs e)
        {
            
        }

        private void lstDatos_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

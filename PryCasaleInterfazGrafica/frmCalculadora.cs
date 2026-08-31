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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
        }

        private void LabelNumero2_Click(object sender, EventArgs e)
        {

        }

        private void frmCalculadora_Load(object sender, EventArgs e)
        {

        }

        private void buttonSumar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);
            double resultado = numero1 + numero2;

            lblresultado.Text = resultado.ToString();
        }

        private void textNumero2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonRestar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);
            double resultado = numero1 - numero2;

            lblresultado.Text = resultado.ToString();
        }

        private void buttonDividir_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text); 
            double numero2 = double.Parse(txtNumero2.Text);
            double resultado = numero1 / numero2;

            lblresultado.Text = resultado.ToString();
        }

        private void buttonMultiplicar_Click(object sender, EventArgs e)
        {
            double numero1 = double.Parse(txtNumero1.Text);
            double numero2 = double.Parse(txtNumero2.Text);
            double resultado = numero1 * numero2;

            lblresultado.Text = resultado.ToString();

        }
    }
}

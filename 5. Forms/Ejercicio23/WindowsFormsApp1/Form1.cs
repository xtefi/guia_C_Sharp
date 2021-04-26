using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Billetes;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txtCotiDolar.Text = Dolar.GetCotizacion().ToString();
            txtCotiEuro.Text = Euros.GetCotizacion().ToString();
            txtCotiPeso.Text = Pesos.GetCotizacion().ToString();
        }

        private void btnLockCotizacion_Click(object sender, EventArgs e)
        {
            if(txtCotiEuro.Enabled)
            {
                btnLockCotizacion.Text = "Locked";
                txtCotiDolar.Enabled = false;
                txtCotiEuro.Enabled = false;
                txtCotiPeso.Enabled = false;
            }
            else
            {
                btnLockCotizacion.Text = "Unlocked";
                txtCotiDolar.Enabled = true;
                txtCotiEuro.Enabled = true;
                txtCotiPeso.Enabled = true;
            }
        }

        private void btnEuroConvert_Click(object sender, EventArgs e)
        {
            double aux = 0;
            if(double.TryParse(txtEuro.Text, out aux))
            {
                Euros euro = new Euros(aux);
                txtEuroAEuro.Text = euro.GetCantidad().ToString();
                txtEuroADolar.Text = ((Dolar)euro).GetCantidad().ToString();
                txtEuroAPeso.Text= ((Pesos)euro).GetCantidad().ToString();
            }
            
        }

        private void btnDolarConvert_Click(object sender, EventArgs e)
        {
            double aux = 0;
            if(double.TryParse(txtDolar.Text, out aux))
            { 
                Dolar dolares = new Dolar(aux);
                txtDolarADolar.Text = dolares.GetCantidad().ToString();
                txtDolarAPeso.Text = ((Pesos)dolares).GetCantidad().ToString();
                txtDolarAEuro.Text = ((Euros)dolares).GetCantidad().ToString();
            }
        }

        private void btnPesoConvert_Click(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(txtDolar.Text, out aux))
            {
                Pesos peso = new Pesos(aux);
                txtPesoAPeso.Text = peso.GetCantidad().ToString();
                txtPesoADolar.Text = ((Dolar)peso).GetCantidad().ToString();
                txtPesoAEuro.Text = ((Euros)peso).GetCantidad().ToString();
            }

        }

        private void txtCotiEuro_TextChanged(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(txtCotiEuro.Text, out aux))
                Euros.SetCotizacion(aux);
            else
                txtCotiEuro.Focus();
        }

        private void txtCotiDolar_TextChanged(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(txtCotiDolar.Text, out aux))
                Dolar.SetCotizacion(aux);
            else
                txtCotiDolar.Focus();
        }

        private void txtCotiPeso_TextChanged(object sender, EventArgs e)
        {
            double aux = 0;
            if (double.TryParse(txtCotiPeso.Text, out aux))
                Pesos.SetCotizacion(aux);
            else
                txtCotiPeso.Focus();
        }
    }
}

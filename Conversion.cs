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

namespace Boceto_proyecto
{
    public partial class Conversion : Form
    {
        public Conversion()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para regresar al formulario del menu.
            this.Hide();
            Form2 frmmenu = new Form2();
            frmmenu.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Para cerrar los formularios.
            this.Dispose();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //comienzo del conversor
            if (cmbDe.SelectedItem.ToString() == "Centimetros" & cmbA.SelectedItem.ToString() == "Centimetros")
            {
                //Declaración de variables
                double conversion;
                //Darle valor a las variables.
                conversion = double.Parse(txtValor.Text) * 1;
                //Mostar el resultado.
                txtResultado.Text = conversion.ToString() + "cm";
            }
            else if (cmbDe.SelectedItem.ToString() == "Centimetros" & cmbA.SelectedItem.ToString() == "Metros")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 0.01;
                txtResultado.Text = conversion.ToString() + "m";
            }
            else if (cmbDe.SelectedItem.ToString() == "Centimetros" & cmbA.SelectedItem.ToString() == "Kilometros")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 0.00001;
                txtResultado.Text = conversion.ToString() + "km";
            }
            else if (cmbDe.SelectedItem.ToString() == "Centimetros" & cmbA.SelectedItem.ToString() == "Kilometros")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 0.00001;
                txtResultado.Text = conversion.ToString() + "km";
            }
            else if (cmbDe.SelectedItem.ToString() == "Kilometros" & cmbA.SelectedItem.ToString() == "Centimetros")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 100000;
                txtResultado.Text = conversion.ToString() + "cm";
            }
            else if (cmbDe.SelectedItem.ToString() == "Kilometros" & cmbA.SelectedItem.ToString() == "Metros")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 1000;
                txtResultado.Text = conversion.ToString() + "m";
            }
            else if (cmbDe.SelectedItem.ToString() == "Kilometros" & cmbA.SelectedItem.ToString() == "Kilometros")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 1;
                txtResultado.Text = conversion.ToString() + "km";
            }
            else if (cmbDe.SelectedItem.ToString() == "Metros" & cmbA.SelectedItem.ToString() == "Metros")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 1;
                txtResultado.Text = conversion.ToString() + "m";
            }
            else if (cmbDe.SelectedItem.ToString() == "Metros" & cmbA.SelectedItem.ToString() == "Centimetros")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 100;
                txtResultado.Text = conversion.ToString() + "cm";
            }
            else if (cmbDe.SelectedItem.ToString() == "Metros" & cmbA.SelectedItem.ToString() == "Kilometros")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 0.001;
                txtResultado.Text = conversion.ToString() + "km";
            }
            else if (cmbDe.SelectedItem.ToString() == "Segundos" & cmbA.SelectedItem.ToString() == "Segundos")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 1;
                txtResultado.Text = conversion.ToString() + "seg";
            }
            else if (cmbDe.SelectedItem.ToString() == "Segundos" & cmbA.SelectedItem.ToString() == "Minutos")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 0.0166666666666666666;
                txtResultado.Text = conversion.ToString() + "min";
            }
            else if (cmbDe.SelectedItem.ToString() == "Segundos" & cmbA.SelectedItem.ToString() == "Horas")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 0.000277777777777777777;
                txtResultado.Text = conversion.ToString() + "h";
            }
            else if (cmbDe.SelectedItem.ToString() == "Minutos" & cmbA.SelectedItem.ToString() == "Minutos")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 1;
                txtResultado.Text = conversion.ToString() + "min";
            }
            else if (cmbDe.SelectedItem.ToString() == "Minutos" & cmbA.SelectedItem.ToString() == "Segundos")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 60;
                txtResultado.Text = conversion.ToString() + "seg";
            }
            else if (cmbDe.SelectedItem.ToString() == "Minutos" & cmbA.SelectedItem.ToString() == "Horas")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 0.0166666666666666666;
                txtResultado.Text = conversion.ToString() + "h";
            }
            else if (cmbDe.SelectedItem.ToString() == "Horas" & cmbA.SelectedItem.ToString() == "Horas")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 1;
                txtResultado.Text = conversion.ToString() + "h";
            }
            else if (cmbDe.SelectedItem.ToString() == "Horas" & cmbA.SelectedItem.ToString() == "Minutos")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 60;
                txtResultado.Text = conversion.ToString() + "min";
            }
            else if (cmbDe.SelectedItem.ToString() == "Horas" & cmbA.SelectedItem.ToString() == "Segundos")
            {
                double conversion;
                conversion = double.Parse(txtValor.Text) * 3600;
                txtResultado.Text = conversion.ToString() + "seg";
            }
        }

        private void Conversion_Load(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Boceto_proyecto.Properties;

namespace Boceto_proyecto
{
    public partial class MRUVResolucion : Form
    {
        public MRUVResolucion()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            MRUVDescripcion frmMRUVdescripcion = new MRUVDescripcion();
            frmMRUVdescripcion.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtAceleracion.Text = "";
            txtVelocidadF.Text = "";
            txtTiempo.Text = "";
            txtVelocidadIn.Text = "";
            txtResultado.Text = "";
        }

        private void btnMRU_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frmMRU = new Form3();
            frmMRU.Show();
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            this.Hide();
            Conversion frmConverion = new Conversion();
            frmConverion.Show();
        }

        private void btnMRUV_Click(object sender, EventArgs e)
        {
            this.Hide();
            MRUVDescripcion frmMRUVDescripcion = new MRUVDescripcion();
            frmMRUVDescripcion.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaramos variables
            double velocidadF, VelocidadIn, aceleracion, tiempo, valorFinal;
            //Utilizamos Try para cacturar los posibles errores y mostrar un mensaje.
            try
            {
                // Utilizamos decisiones para calcular los datos.
                if (cmbElegir.SelectedItem.ToString() == "VelocidadFinal")
                {
                    //Le damos valor a las variables.
                    VelocidadIn = Convert.ToDouble(txtVelocidadIn.Text);
                    aceleracion = Convert.ToDouble(txtAceleracion.Text);
                    tiempo = Convert.ToDouble(txtTiempo.Text);
                    valorFinal = VelocidadIn + (aceleracion * tiempo);
                    //Mostramos el resultado de las operaciones.
                    txtResultado.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "VelocidadInicial")
                {
                    velocidadF = Convert.ToDouble(txtVelocidadF.Text);
                    aceleracion = Convert.ToDouble(txtAceleracion.Text);
                    tiempo = Convert.ToDouble(txtTiempo.Text);
                    valorFinal = velocidadF - (aceleracion * tiempo);
                    txtResultado.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Aceleracion")
                {
                    velocidadF = Convert.ToDouble(txtVelocidadF.Text);
                    VelocidadIn = Convert.ToDouble(txtVelocidadIn.Text);
                    tiempo = Convert.ToDouble(txtTiempo.Text);
                    valorFinal = velocidadF - (VelocidadIn / tiempo);
                    txtResultado.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Tiempo")
                {
                    velocidadF = Convert.ToDouble(txtVelocidadF.Text);
                    VelocidadIn = Convert.ToDouble(txtVelocidadIn.Text);
                    aceleracion = Convert.ToDouble(txtAceleracion.Text);
                    valorFinal = velocidadF - (VelocidadIn / aceleracion);
                    txtResultado.Text = valorFinal.ToString() + "seg";

                }
            }
            catch
            {
                MessageBox.Show("¡POR FAVOR INGRESE NÚMEROS EN LOS CAMPOS!");
            }
        }

        private void cmbElegir_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Bloqueamos el boton de calcular anteas de seleccionar alguna operacion
            btnCalcular.Enabled = true;
            //Cambiamos el color de las cajas de texto 
            if (cmbElegir.SelectedItem.ToString() == "VelocidadFinal")
            {
                txtVelocidadF.BackColor = Color.Gray;
                txtVelocidadIn.BackColor = Color.White;
                txtAceleracion.BackColor = Color.White;
                txtTiempo.BackColor = Color.White;
                //Bloqueamos las cajas de texto que no se utilizaran en la formula
                txtVelocidadF.ReadOnly = true;
                txtVelocidadIn.ReadOnly = false;
                txtAceleracion.ReadOnly = false;
                txtTiempo.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "VelocidadInicial")
            {
                txtVelocidadF.BackColor = Color.White;
                txtVelocidadIn.BackColor = Color.Gray;
                txtAceleracion.BackColor = Color.White;
                txtTiempo.BackColor = Color.White;
                txtVelocidadF.ReadOnly = false;
                txtVelocidadIn.ReadOnly = true;
                txtAceleracion.ReadOnly = false;
                txtTiempo.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Aceleracion")
            {
                txtVelocidadF.BackColor = Color.White;
                txtVelocidadIn.BackColor = Color.White;
                txtAceleracion.BackColor = Color.Gray;
                txtTiempo.BackColor = Color.White;
                txtVelocidadF.ReadOnly = false;
                txtVelocidadIn.ReadOnly = false;
                txtAceleracion.ReadOnly = true;
                txtTiempo.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Tiempo")
            {
                txtVelocidadF.BackColor = Color.White;
                txtVelocidadIn.BackColor = Color.White;
                txtAceleracion.BackColor = Color.White;
                txtTiempo.BackColor = Color.Gray;
                txtVelocidadF.ReadOnly = false;
                txtVelocidadIn.ReadOnly = false;
                txtAceleracion.ReadOnly = false;
                txtTiempo.ReadOnly = true;
            }
        }

        private void btnEjemplos_Click(object sender, EventArgs e)
        {
            //Para navegar hacia otro formulario
            this.Hide();
            EjemplosMRUV frmEjemplosMRUV = new EjemplosMRUV();
            frmEjemplosMRUV.Show();
        }

        private void btnCalcular_MouseDown(object sender, MouseEventArgs e)
        {
            //para cambiar la imagen al momento de darle clic a los botones
            btnCalcular.BackgroundImage = Resources.buton2;
        }

        private void btnCalcular_MouseUp(object sender, MouseEventArgs e)
        {
            //Para cambiar la imagen al momento de levantar el click 
            btnCalcular.BackgroundImage = Resources.buton1;
        }

        private void btnLimpiar_MouseDown(object sender, MouseEventArgs e)
        {
            btnLimpiar.BackgroundImage = Resources.buton2;
        }

        private void btnLimpiar_MouseUp(object sender, MouseEventArgs e)
        {
            btnLimpiar.BackgroundImage = Resources.buton1;
        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            btnAtras.BackgroundImage = Resources.buton2;
        }

        private void btnAtras_MouseUp(object sender, MouseEventArgs e)
        {
            btnAtras.BackgroundImage = Resources.buton1;
        }

        private void btnSalir_MouseDown(object sender, MouseEventArgs e)
        {
            btnSalir.BackgroundImage = Resources.buton2;
        }

        private void btnSalir_MouseUp(object sender, MouseEventArgs e)
        {
            btnSalir.BackgroundImage = Resources.buton1;
        }

        private void btnMCU_Click(object sender, EventArgs e)
        {
            this.Hide();
            MCUDescripcion frmMCUDescripcion = new MCUDescripcion();
            frmMCUDescripcion.Show();
        }

        private void btnMCUV_Click(object sender, EventArgs e)
        {
            this.Hide();
            MCUVDescripcion frmMCUVDescripcion = new MCUVDescripcion();
            frmMCUVDescripcion.Show();
        }

        private void btnTVCL_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de Tiro vertical y caida libre
            this.Hide();
            TVCL frmTVCL = new TVCL();
            frmTVCL.Show();
        }

        private void btnTiroParabolico_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de Tiro Parabólco
            this.Hide();
            TiroParabolicoDescripcion frmTP = new TiroParabolicoDescripcion();
            frmTP.Show();
        }
    }
}

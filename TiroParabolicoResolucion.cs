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
    public partial class TiroParabolicoResolucion : Form
    {
        public TiroParabolicoResolucion()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Para inhabilitar el botón de calcular sin antes seleccionar una operación.
            btnCalcular.Enabled = true;
            if (cmbElegir.SelectedItem.ToString() == "Altura Maxima")
            {

            }
            else if (cmbElegir.SelectedItem.ToString() == "Alcance Maximo")
            {

            }
            else if (cmbElegir.SelectedItem.ToString() == "Tiempo de Vuelo")
            {

            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Utilizamos Try para capturar cualquier error posible
            try
            {
                //Declaramos Variables
                double velocidadInicial, Angulo, gravedad, valorFinal;

                //Utilizamos una decsión para elegir las operaciones
                if (cmbElegir.SelectedItem.ToString() == "Altura Maxima")
                {
                    //Le damos valor a las variables
                    velocidadInicial = Convert.ToDouble(txtVelocidadInicial.Text);
                    Angulo = Convert.ToDouble(txtAngulo.Text);
                    gravedad = Convert.ToDouble(txtGravedad.Text);
                    //Utilizamos la formula para realizar la operación, utilizamos la función Math para seno y para elevar los datos
                    valorFinal = (Math.Pow(velocidadInicial, 2) * Math.Sin(2 * Angulo)) / (2 * gravedad);
                    //Mostramos el resultado de la operación
                    txtResultado.Text = valorFinal.ToString() + "m";
                }
                // Utilizamos para seleccionar otra operación y se realice otro proceso
                else if (cmbElegir.SelectedItem.ToString() == "Alcance Maximo")
                {
                    //Le damos valor a las variables
                    velocidadInicial = Convert.ToDouble(txtVelocidadInicial.Text);
                    Angulo = Convert.ToDouble(txtAngulo.Text);
                    gravedad = Convert.ToDouble(txtGravedad.Text);
                    //Utilizamos la formula para realizar la operación, utilizamos la función Math para seno y elevar los datos
                    valorFinal = (Math.Pow(velocidadInicial, 2) * Math.Sin(2 * Angulo)) / (gravedad);
                    //Mostramos el resultado de la operación
                    txtResultado.Text = valorFinal.ToString() + "m";
                }
                //Utilizamos para seleccionar otra operación y se realice otro proceso
                else if (cmbElegir.SelectedItem.ToString() == "Tiempo de Vuelo")
                {
                    //Le damos valor a las variables
                    velocidadInicial = Convert.ToDouble(txtVelocidadInicial.Text);
                    Angulo = Convert.ToDouble(txtAngulo.Text);
                    gravedad = Convert.ToDouble(txtGravedad.Text);
                    //Utilizamos la formula para realizar la operación, utilizamos la función Math para seno y elevar los datos
                    valorFinal = (2 * velocidadInicial * Math.Sin(Angulo)) / (gravedad);
                    //Mostramos el resultado de la operación
                    txtResultado.Text = valorFinal.ToString() + "s";

                }
            }
            catch
            {
                //Para mostar mensaje al momento de encontrar un error
                MessageBox.Show("¡POR FAVOR INGRESE NUMEROS VALIDOS EN LOS CAMPOS!");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiamos las cajas de texto
            txtVelocidadInicial.Text = "";
            txtAngulo.Text = "";
            txtGravedad.Text = "";
            txtResultado.Text = "";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para regresar a la descripción del tema
            this.Hide();
            TiroParabolicoDescripcion frmtiroparabolicoD = new TiroParabolicoDescripcion();
            frmtiroparabolicoD.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Para cerrar los formularios
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Para ir al ejemplo del tema
            this.Hide();
            EjemploTiroParabolico frmejemplo = new EjemploTiroParabolico();
            frmejemplo.Show();

        }

        private void btnCalcular_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de darle clic
            btnCalcular.BackgroundImage = Resources.buton2;
        }

        private void btnCalcular_MouseUp(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de levantar el clic
            btnCalcular.BackgroundImage = Resources.buton1;
        }

        private void btnLimpiar_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de darle clic
            btnLimpiar.BackgroundImage = Resources.buton2;
        }

        private void btnLimpiar_MouseUp(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de levantar el clic
            btnLimpiar.BackgroundImage = Resources.buton1;
        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de darle clic
            btnAtras.BackgroundImage = Resources.buton2;
        }

        private void btnAtras_MouseUp(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de levantar el clic
            btnAtras.BackgroundImage = Resources.buton1;
        }

        private void btnSalir_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de darle clic
            btnSalir.BackgroundImage = Resources.buton2;
        }

        private void btnSalir_MouseUp(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de levantar el clic
            btnSalir.BackgroundImage = Resources.buton1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Para navegar a las conversiones
            this.Hide();
            Conversion frmConversion = new Conversion();
            frmConversion.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de MRU
            this.Hide();
            Form3 frmMRU = new Form3();
            frmMRU.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de MRUV
            this.Hide();
            MRUVDescripcion frmMRUVD = new MRUVDescripcion();
            frmMRUVD.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de MCU
            this.Hide();
            MCUDescripcion frmMCU = new MCUDescripcion();
            frmMCU.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de MCUV
            this.Hide();
            MCUVDescripcion frmMCUVD = new MCUVDescripcion();
            frmMCUVD.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de Tiro vertical y caida libre
            this.Hide();
            TVCL frmTVCL = new TVCL();
            frmTVCL.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de tiro parabolico
            this.Hide();
            TiroParabolicoDescripcion frmTP = new TiroParabolicoDescripcion();
            frmTP.Show();
        }
    }
}

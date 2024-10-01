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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frmMRUexplicacion = new Form3();
            frmMRUexplicacion.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void lvlDistancia_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void btnMCUV_Click(object sender, EventArgs e)
        {
            //Para navegar en los formularios con distinto tema.
            this.Hide();
            MCUVDescripcion frmMCUVDescripcion = new MCUVDescripcion();
            frmMCUVDescripcion.Show();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Utilizamos Try para capturar cualquier error posible.
            try
            {
                //Utilizamos decisiones para realizar las operaciones.
                if (cmbElección.SelectedItem.ToString() == "Distancia")

                {
                    //Declaramos variables.
                    double valor1, valor2, valorfinal;
                    valor1 = Convert.ToDouble(txtVelocidad.Text);
                    valor2 = Convert.ToDouble(txtTiempo.Text);
                    valorfinal = valor1 * valor2;
                    //Mostramos el resulado de la operación.
                    txtResultado.Text = valorfinal.ToString() + "m";
                }
                else if (cmbElección.SelectedItem.ToString() == "Velocidad")

                {
                    double valor1, valor2, valorfinal;
                    valor1 = Convert.ToDouble(txtDistancia.Text);
                    valor2 = Convert.ToDouble(txtTiempo.Text);
                    valorfinal = valor1 / valor2;
                    txtResultado.Text = valorfinal.ToString() + "m/s";
                }
                else if (cmbElección.SelectedItem.ToString() == "Tiempo")

                {
                    double valor1, valor2, valorfinal;
                    valor1 = Convert.ToDouble(txtDistancia.Text);
                    valor2 = Convert.ToDouble(txtVelocidad.Text);
                    valorfinal = valor1 / valor2;
                    txtResultado.Text = valorfinal.ToString() + "seg";
                }
            }
            catch
            {
                //Para mostrar un mensaje al momento de encontrar un error.
                MessageBox.Show("¡POR FAVOR INGRESE NÚMEROS EN LOS CAMPOS!");
            }
        }

        private void cmbElección_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Para inhabilitar el botón de calcular antes de seleccionar una operación.
            btnCalcular.Enabled = true;

            if (cmbElección.SelectedItem.ToString() == "Distancia")
            {
                //Para cambiar el color de las cajas de texto que se ocuparan y las que no.
                txtDistancia.BackColor = Color.Gray;
                txtVelocidad.BackColor = Color.White;
                txtTiempo.BackColor = Color.White;
                //Para bloquear las casillas que no se ocuparan y dejar habilitadas las que si.
                txtDistancia.ReadOnly = true;
                txtTiempo.ReadOnly = false;
                txtVelocidad.ReadOnly = false;
            }
            else if (cmbElección.SelectedItem.ToString() == "Velocidad")
            {
                txtDistancia.BackColor = Color.White;
                txtVelocidad.BackColor = Color.Gray;
                txtTiempo.BackColor = Color.White;
                txtDistancia.ReadOnly = false;
                txtTiempo.ReadOnly = false;
                txtVelocidad.ReadOnly = true;
            }
            else if (cmbElección.SelectedItem.ToString() == "Tiempo")
            {
                txtDistancia.BackColor = Color.White;
                txtVelocidad.BackColor = Color.White;
                txtTiempo.BackColor = Color.Gray;
                txtDistancia.ReadOnly = false;
                txtTiempo.ReadOnly = true;
                txtVelocidad.ReadOnly = false;
            }

        }

        private void btnCalcular_MouseDown(object sender, MouseEventArgs e)
        {
            //Para cambiar la imagen al momento de darle clic al botón.
            btnCalcular.BackgroundImage = Resources.buton2;
        }

        private void btnCalcular_MouseUp(object sender, MouseEventArgs e)
        {
            //Para cambiar imagen al momento de levantar el clic.
            btnCalcular.BackgroundImage = Resources.buton1;
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            btnAtras.BackgroundImage = Resources.buton2;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Para limpiar las cajas de texto.
            txtDistancia.Text = "";
            txtVelocidad.Text = "";
            txtTiempo.Text = "";
            txtResultado.Text = "";
        }

        private void btnLimpiar_MouseDown(object sender, MouseEventArgs e)
        {
            btnLimpiar.BackgroundImage = Resources.buton2;
        }

        private void btnLimpiar_MouseUp(object sender, MouseEventArgs e)
        {
            btnLimpiar.BackgroundImage = Resources.buton1;
        }

        private void btnMRU_Click(object sender, EventArgs e)
        {
            //Para navegar atravez de otos temas.
            this.Hide();
            Form3 frmMRUdescripcion = new Form3();
            frmMRUdescripcion.Show();
        }

        private void lblVelocidad_Click(object sender, EventArgs e)
        {

        }

        private void btnTVCL_Click(object sender, EventArgs e)
        {
            //PARA NAVEGAR AL TEMA DE TIRO VERTICAL Y CAIDA LIBRE
            this.Hide();
            TVCL frmTVCL = new TVCL();
            frmTVCL.Show();
        }

        private void btnMCU_Click(object sender, EventArgs e)
        {
            this.Hide();
            MCUDescripcion frmMCUDescripcion = new MCUDescripcion();
            frmMCUDescripcion.Show();
        }

        private void btnEjemplos_Click(object sender, EventArgs e)
        {
            this.Hide();
            EjemplosMRU ejemplosMRU = new EjemplosMRU();
            ejemplosMRU.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Conversion frmConversion = new Conversion();
            frmConversion.Show();
        }

        private void btnMRUV_Click(object sender, EventArgs e)
        {
            this.Hide();
            MRUVDescripcion fmrMRUVDescripcion = new MRUVDescripcion();
            fmrMRUVDescripcion.Show();
        }

        private void btnTiroParabolico_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de tiro parabólico
            this.Hide();
            TiroParabolicoDescripcion frmTP = new TiroParabolicoDescripcion();
            frmTP.Show();
        }
    }
}

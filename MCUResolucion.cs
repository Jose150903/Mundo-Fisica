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
    public partial class MCUResolucion : Form
    {
        public MCUResolucion()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Para inhabilitar el boton de calcular amtes de seleccionar una operación.
            btnCalcular.Enabled = true;
            //Utilizamos una decisión para realizar los cambios en las cajas de texto.
            if (cmbElegir.SelectedItem.ToString() == "Periodo")
            {
                //Para cambiar el color de las cajas de texto.
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.Gray;
                //Para cambiar el texto de los label.
                lbl1.Text = "Frecuencia en S";
                lbl2.Text = "";
                lbl4.Text = "Resultado en S";
                //Para inhabilitar las cajas de texto que no se utilizaran en una operación.
                txt1.ReadOnly = false;
                txt2.ReadOnly = true;

            }
            else if (cmbElegir.SelectedItem.ToString() == "Frecuencia")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.Gray;
                lbl1.Text = "Periodo en Hz";
                lbl2.Text = "";
                lbl4.Text = "Resultado en Hz";
                txt1.ReadOnly = false;
                txt2.ReadOnly = true;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Velocidad Angular")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.Gray;
                lbl1.Text = "Periodo en s";
                lbl2.Text = "";
                lbl4.Text = "Resultado en m/s";
                txt1.ReadOnly = false;
                txt2.ReadOnly = true;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Velocidad Tangencial")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                lbl1.Text = "Radio en m";
                lbl2.Text = "Periodo en s";
                lbl4.Text = "Resultado m/s";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Aceleración Centrípeta")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                lbl1.Text = "Velocidad Tangencial en m/s";
                lbl2.Text = "Radio en m";
                lbl4.Text = "Resultado en m/s";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Velocidad Tangencial a Angular")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                lbl1.Text = "Velocidad Tangencial en m/s";
                lbl2.Text = "Radio en m";
                lbl4.Text = "Resultado en m/s";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Velocidad Angular a Tangencial")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                lbl1.Text = "Velocidad Angular en m/s";
                lbl2.Text = "Radio en m";
                lbl4.Text = "Resultado en m/s";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Desplazamiento Angular")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                lbl1.Text = "Velocidad Angular en m/s";
                lbl2.Text = "Tiempo en s";
                lbl4.Text = "Resultado en m/s";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Tiempo")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                lbl1.Text = "Desplazamiento en m";
                lbl2.Text = "Velocidad Angular en m/s";
                lbl4.Text = "Resultado en s";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para regresar al formulario de descripción del tema
            this.Hide();
            MCUDescripcion frmMCUDescripcion = new MCUDescripcion();
            frmMCUDescripcion.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Para cerrar todos los formularios.
            this.Dispose();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Para limpiar las cajas de texto.
            txt1.Text = "";
            txt2.Text = "";
            txtResultado.Text = "";
        }

        private void btnCalcular_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón.
            btnCalcular.BackgroundImage = Resources.buton2;
        }

        private void btnCalcular_MouseUp(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón.
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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Inicializamos Variables.
            double valor1, valor2, valorFinal;
            //Utilizamos Try para capturar los errores posibles.
            try
            {
                //Utilizamos una decisión para realizar las operaciónes.
                if (cmbElegir.SelectedItem.ToString() == "Periodo")
                {
                    //Le damos valor a las Variables.
                    valor1 = Convert.ToDouble(txt1.Text);
                    valorFinal = (1 / valor1);
                    //Mostramos el resultado.
                    txtResultado.Text = valorFinal.ToString() + "seg";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Frecuencia")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valorFinal = (1 / valor1);
                    txtResultado.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Velocidad Angular")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valorFinal = (2 * 3.1416) / valor1;
                    txtResultado.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Velocidad Tangencial")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valorFinal = ((2 * 3.1416) * (valor1)) / valor2;
                    txtResultado.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Aceleración Centrípeta")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valorFinal = (valor1 * valor1) / valor2;
                    txtResultado.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Velocidad Angular a Tangencial")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valorFinal = (valor1 / valor2);
                    txtResultado.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Velocidad Tangencial a Angular")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valorFinal = (valor1 * valor2);
                    txtResultado.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Desplazamiento Angular")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valorFinal = (valor1 * valor2);
                    txtResultado.Text = valorFinal.ToString() + "rads";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Tiempo")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valorFinal = (valor1 / valor2);
                    txtResultado.Text = valorFinal.ToString() + "seg";
                }
            }
            catch
            {
                //Para mostrar un mensaje al momento de capturar un error.
                MessageBox.Show("¡POR FAVOR INGRESE NÚMEROS VALIDOS EN LOS CAMPOS!");
            }
        }

        private void btnEjemplos_Click(object sender, EventArgs e)
        {
            //Para navegar hacia el ejemplo del tema.
            this.Hide();
            MCUEjemplos frmMCUEjemplos = new MCUEjemplos();
            frmMCUEjemplos.Show();
        }

        private void btnMRU_Click(object sender, EventArgs e)
        {
            //Para navegar en los distintos formularios con diferentes temas.
            this.Hide();
            Form4 frmMRUDescripcion = new Form4();
            frmMRUDescripcion.Show();
        }

        private void btnMRUV_Click(object sender, EventArgs e)
        {
            this.Hide();
            MRUVDescripcion frmMRUVDescripcion = new MRUVDescripcion();
            frmMRUVDescripcion.Show();
        }

        private void btnConversion_Click(object sender, EventArgs e)
        {
            //Para navegar a las conversiones
            this.Hide();
            Conversion frmConversion = new Conversion();
            frmConversion.Show();
        }

        private void btnMCU_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de MCU
            this.Hide();
            MCUDescripcion frmMCUD = new MCUDescripcion();
            frmMCUD.Show();
        }

        private void btnMCUV_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de MCUV
            this.Hide();
            MCUVDescripcion frmMCUVD = new MCUVDescripcion();
            frmMCUVD.Show();
        }

        private void btnTVCL_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de tiro vertical y caida libre
            this.Hide();
            TVCL frmTVCL = new TVCL();
            frmTVCL.Show();
        }

        private void btnTiroParabolico_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de Tiro Parabólico
            this.Hide();
            TiroParabolicoDescripcion frmTP = new TiroParabolicoDescripcion();
            frmTP.Show();
        }
    }
}

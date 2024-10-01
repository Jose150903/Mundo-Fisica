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
    public partial class MCUVResolucion : Form
    {
        public MCUVResolucion()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbElegir_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnCalcular.Enabled = true;
            if (cmbElegir.SelectedItem.ToString() == "Desplazamiento Angular")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                lbl1.Text = "Velocidad Angular Inicial";
                lbl2.Text = "Tiempo";
                lbl3.Text = "Aceleración Angular";
                lbl5.Text = "Resultado";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Velocidad Angular Inicial")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                lbl1.Text = "Velocidad Angular Final";
                lbl2.Text = "Aceleración Angular";
                lbl3.Text = "Tiempo";
                lbl5.Text = "Resultado";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Velocidad Angular Final")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                lbl1.Text = "Velocidad Angular Inicial";
                lbl2.Text = "Aceleración Angular";
                lbl3.Text = "Tiempo";
                lbl5.Text = "Resultado";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Tiempo")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                lbl1.Text = "Velocidad Angular Final";
                lbl2.Text = "Velocidad Angular Inicial";
                lbl3.Text = "Aceleración Angular";
                lbl5.Text = "Resultado";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Aceleración Angular")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                lbl1.Text = "Velocidad Angular Final";
                lbl2.Text = "Velocidad Angular Inicial";
                lbl3.Text = "Tiempo";
                lbl5.Text = "Resultado";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Longitud de Arco")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                lbl1.Text = "Velocidad Tangencial Inicial";
                lbl2.Text = "Tiempo";
                lbl3.Text = "Aceleración Tangencial";
                lbl5.Text = "Resultado";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Velocidad Tangencial Inicial")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                lbl1.Text = "Velocidad Tangencial Final";
                lbl2.Text = "Aceleración Tangencial";
                lbl3.Text = "Tiempo";
                lbl5.Text = "Resultado";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Velocidad Tangencial Final")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                lbl1.Text = "Velocidad Tangencial Inicial";
                lbl2.Text = "Aceleración Tangencial";
                lbl3.Text = "Tiempo";
                lbl5.Text = "Resultado";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
            }
            else if (cmbElegir.SelectedItem.ToString() == "Aceleración Tangencial")
            {
                txt1.BackColor = Color.White;
                txt2.BackColor = Color.White;
                txt3.BackColor = Color.White;
                lbl1.Text = "Velocidad Tangencial Final";
                lbl2.Text = "Velocidad Tangencial Inicial";
                lbl3.Text = "Tiempo";
                lbl5.Text = "Resultado";
                txt1.ReadOnly = false;
                txt2.ReadOnly = false;
                txt3.ReadOnly = false;
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaramos las variables.
            double valor1, valor2, valor3, valorFinal;
            //Utilizamos Try para capturar los errores´posibles al momento de ingresar datos.
            try
            {
                // Utilizamos una decisión para realizar las formulas de los datos.
                if (cmbElegir.SelectedItem.ToString() == "Desplazamiento Angular")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valor3 = Convert.ToDouble(txt3.Text);
                    valorFinal = (valor1 * valor2) + (0.5 * valor3 * (valor2 * valor2));
                    //Mostramos el valor del resultado.
                    txt5.Text = valorFinal.ToString() + "rads";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Velocidad Angular Inicial")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valor3 = Convert.ToDouble(txt3.Text);
                    valorFinal = valor1 - (valor2 * valor3);
                    txt5.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Velocidad Angular Final")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valor3 = Convert.ToDouble(txt3.Text);
                    valorFinal = valor1 + (valor2 * valor3);
                    txt5.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Tiempo")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valor3 = Convert.ToDouble(txt3.Text);
                    valorFinal = (valor1 - valor2) / valor3;
                    txt5.Text = valorFinal.ToString() + "seg";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Aceleración Angular")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valor3 = Convert.ToDouble(txt3.Text);
                    valorFinal = ((valor1 - valor2) / valor3) - valor2;
                    txt5.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Longitud de Arco")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valor3 = Convert.ToDouble(txt3.Text);
                    valorFinal = (valor1 * valor2) + (0.5 * valor3 * (valor2 * valor2));
                    txt5.Text = valorFinal.ToString() + "m";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Velocidad Tangencial Inicial")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valor3 = Convert.ToDouble(txt3.Text);
                    valorFinal = valor1 - valor2 * valor3;
                    txt5.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Velocidad Tangencial Final")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valor3 = Convert.ToDouble(txt3.Text);
                    valorFinal = valor1 + valor2 * valor3;
                    txt5.Text = valorFinal.ToString() + "m/s";
                }
                else if (cmbElegir.SelectedItem.ToString() == "Aceleración Tangencial")
                {
                    valor1 = Convert.ToDouble(txt1.Text);
                    valor2 = Convert.ToDouble(txt2.Text);
                    valor3 = Convert.ToDouble(txt3.Text);
                    valorFinal = (valor1 - valor2) / valor3 - valor2;
                    txt5.Text = valorFinal.ToString() + "m/s";
                }
            }
            catch
            {
                //Muestra un mensaje al momento de capturar un error.
                MessageBox.Show("¡POR FAVOR INGRESE NÚMEROS EN LOS CAMPOS!");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Limpiamos los valores que ya no utilizaremos.
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt5.Text = "";
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para navegar hacia el formulario de descripción del tema.
            this.Hide();
            MCUVDescripcion frmMCUVDescripcion = new MCUVDescripcion();
            frmMCUVDescripcion.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Para cerrar los formularios
            this.Dispose();
        }

        private void btnEjemplos_Click(object sender, EventArgs e)
        {
            //Para navegar hacia otro formularios con distinto tema.
            this.Hide();
            EjemplosMCUV frmEjemploMCUV = new EjemplosMCUV();
            frmEjemploMCUV.Show();
        }

        private void btnCalcular_MouseDown(object sender, MouseEventArgs e)
        {
            //Para cambiar la imagen al momento de darle clic al botón.
            btnCalcular.BackgroundImage = Resources.buton2;
        }

        private void btnCalcular_MouseUp(object sender, MouseEventArgs e)
        {
            //Para cambiar la imagen al momento de levantar el clic.
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

        private void btnMRU_Click(object sender, EventArgs e)
        {
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
            //Para navegar al tema de tiro verical y caida libre
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

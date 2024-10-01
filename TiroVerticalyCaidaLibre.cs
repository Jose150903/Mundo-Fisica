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
    public partial class TiroVerticalyCaidaLibre : Form
    {
        public TiroVerticalyCaidaLibre()
        {
            InitializeComponent();
        }

        private void cmbElegir1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbTiroVertical_Click(object sender, EventArgs e)
        {

        }

        private void rbCaidaLibre_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cmbTiroVertical_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Para Inhabilitar el botón de calcular sin antes seleccionar una operación
            btnCalcular.Enabled = true;
            //Utilizamos una decisión para cambiar los nombres de los label dependiendo la operación que elija
            if (cmbTiroVertical.SelectedItem.ToString() == "Altura")
            {
                lbl1.Text = "Velocidad Inicial";
                lbl2.Text = "Tiempo";
                lbl3.Text = "Gravedad";
                lbl4.Text = "Resultado";
            }
            //Caso contratio cambia los nombres
            else if (cmbTiroVertical.SelectedItem.ToString() == "Velocidad Inicial")
            {
                lbl1.Text = "Velocidad Final";
                lbl2.Text = "Gravedad";
                lbl3.Text = "Tiempo";
                lbl4.Text = "Resultado";
            }
            //Caso contratio cambia los nombres
            else if (cmbTiroVertical.SelectedItem.ToString() == "Tiempo")
            {
                lbl1.Text = "Velocidad Final";
                lbl2.Text = "Velocidad Inicial";
                lbl3.Text = "Gravedad";
                lbl4.Text = "Resultado";
            }
            //Caso contratio cambia los nombres
            else if (cmbTiroVertical.SelectedItem.ToString() == "Gravedad")
            {
                lbl1.Text = "Altura";
                lbl2.Text = "Velocidad Inicial";
                lbl3.Text = "Tiempo";
                lbl4.Text = "Resultado";
            }
        }

        private void cmbCaidaLibre_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //Para Inhabilitar el botón de calcular sin antes seleccionar una operación
            btnCalcular.Enabled = true;
            //Utilizamos una decisión para cambiar los nombres de los label dependiendo la operación que elija
            if (cmbCaidaLibre.SelectedItem.ToString() == "Altura")
            {
                lbl1.Text = "Velocidad Inicial";
                lbl2.Text = "Tiempo";
                lbl3.Text = "Gravedad";
                lbl4.Text = "Resultado";
            }
            //Caso contratio cambia los nombres
            else if (cmbCaidaLibre.SelectedItem.ToString() == "Velocidad Inicial")
            {
                lbl1.Text = "Velocidad Final";
                lbl2.Text = "Gravedad";
                lbl3.Text = "Tiempo";
                lbl4.Text = "Resultado";
            }
            //Caso contratio cambia los nombres
            else if (cmbCaidaLibre.SelectedItem.ToString() == "Velocidad Final")
            {
                lbl1.Text = "Altura";
                lbl2.Text = "Tiempo";
                lbl3.Text = "Velocidad Inicial";
                lbl4.Text = "Resultado";
            }
            //Caso contratio cambia los nombres
            else if (cmbCaidaLibre.SelectedItem.ToString() == "Tiempo")
            {
                lbl1.Text = "Velocidad Final";
                lbl2.Text = "Velocidad Inicial";
                lbl3.Text = "Gravedad";
                lbl4.Text = "Resultado";
            }
            //Caso contratio cambia los nombres
            else if (cmbCaidaLibre.SelectedItem.ToString() == "Gravedad")
            {
                lbl1.Text = "Velocidad Final";
                lbl2.Text = "Velocidad Inicial";
                lbl3.Text = "Tiempo";
                lbl4.Text = "Resultado";
            }
        }

        private void rbTiroVertical_CheckedChanged_1(object sender, EventArgs e)
        {
            //Utilizamos una decisiíon para volver invisible el combobox que no se utilizará y hacer visible el que si
            if (rbTiroVertical.Checked == true)
            {
                cmbTiroVertical.Visible = true;
                cmbCaidaLibre.Visible = false;
            }
        }

        private void rbCaidaLibre_CheckedChanged_1(object sender, EventArgs e)
        {
            //Utilizamos una decisiíon para volver invisible el combobox que no se utilizará y hacer visible el que si
            if (rbCaidaLibre.Checked == true)
            {
                cmbCaidaLibre.Visible = true;
                cmbTiroVertical.Visible = false;
            }
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            //Declaramos Variables
            double valor1, valor2, valor3, valorFinal;

            //Utilizamos una decisión para realizar los procedimientos
            if (cmbTiroVertical.SelectedItem.ToString() == "Altura")
            {
                //Le damos valor a las variables
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                //Realizamos las operaciones con los valores de las variables
                valorFinal = (valor1 * valor2) - (0.5 * valor3 * (valor2 * valor2));
                //Mostramos el resultado de las operaciones
                txt4.Text = valorFinal.ToString() + "m";
            }
            //Utilizamos para seleccionar otra operación y realizar otro proceso
            else if (cmbTiroVertical.SelectedItem.ToString() == "Velocidad Inicial")
            {
                //Le damos valor a las variables
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                //Realizamos las operaciones con los valores de las variables
                valorFinal = valor1 + (valor2 * valor3);
                //Mostramos el resultado
                txt4.Text = valorFinal.ToString() + "m/s";
            }
            //Utilizamos para seleccionar otra operación y realizar otro proceso
            else if (cmbTiroVertical.SelectedItem.ToString() == "Tiempo")
            {
                //Le damos valor a las variables
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                //Realizamos las operaciones con los valores de las variables
                valorFinal = (valor1 + valor2) * valor3;
                //Mostramos el resultado
                txt4.Text = valorFinal.ToString() + "seg";
            }
            //Utilizamos para seleccionar otra operación y realizar otro proceso
            else if (cmbTiroVertical.SelectedItem.ToString() == "Gravedad")
            {
                //Le damos valor a las  variables
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                //Realizamos las operaciones con el valor de las variables
                valorFinal = (valor1 - (valor2 * valor3)) / (0.5 * (valor3 * valor3));
                //Mostramos el resultado
                txt4.Text = valorFinal.ToString() + "m/s";
            }
            //Utilizamos para seleccionar otra operación y realizar otro proceso
            if (cmbCaidaLibre.SelectedItem.ToString() == "Altura")
            {
                //Le damos valor a las variables
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                //Realizamos las operaciones con el valor de las variables
                valorFinal = valor1 * valor2 + (0.5 * valor3 * (valor3 * valor3));
                //Mostramos el resultado
                txt4.Text = valorFinal.ToString() + "m";
            }
            //Utilizamos para seleccionar otra operación y realizar otro proceso
            else if (cmbCaidaLibre.SelectedItem.ToString() == "Velocidad Inicial")
            {
                //Le damos valor a las variables
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                //Realizamos las operaciones con los valores de las variables
                valorFinal = valor1 - (valor2 * valor3);
                //Mostramos el resultado
                txt4.Text = valorFinal.ToString() + "m/s";
            }
            //Utilizamos para seleccionar otra operación y realizar otro proceso
            else if (cmbCaidaLibre.SelectedItem.ToString() == "Velocidad Final")
            {
                //Le damos valor a las variables
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                //Realizamos las operaciones con el valor de las variables
                valorFinal = (2 * (valor1 * valor2)) - valor3;
                //Mostramos el resultado
                txt4.Text = valorFinal.ToString() + "m/s";
            }
            //Utilizamos para seleccionar otra operación y realizar otro proceso
            else if (cmbCaidaLibre.SelectedItem.ToString() == "Tiempo")
            {
                //Le damos valor a las variables
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                //Realizamos las operaciones con el valor de las variables
                valorFinal = (valor1 - valor2) / valor3;
                //Mostramos el resultado
                txt4.Text = valorFinal.ToString() + "seg";
            }
            //Utilizamos para seleccionar otra operación y realizar otro proceso
            else if (cmbCaidaLibre.SelectedItem.ToString() == "Gravedad")
            {
                //Le damos valor a las variables
                valor1 = Convert.ToDouble(txt1.Text);
                valor2 = Convert.ToDouble(txt2.Text);
                valor3 = Convert.ToDouble(txt3.Text);
                //Realizamos las operaciones con el valor de las variables
                valorFinal = ((valor1 - valor2) / valor3) - valor2;
                //Mostramos el resultado
                txt4.Text = valorFinal.ToString() + "m/s";
            }
        }

        private void btnCalcular_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al  momento de darle clic
            btnCalcular.BackgroundImage = Resources.buton2;
        }

        private void btnCalcular_MouseUp(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de levantar el clic
            btnCalcular.BackgroundImage = Resources.buton1;
        }

        private void btnLimpiar_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al  momento de darle clic
            btnLimpiar.BackgroundImage = Resources.buton2;
        }

        private void btnLimpiar_MouseUp(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de levantar el clic
            btnLimpiar.BackgroundImage = Resources.buton1;
        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al  momento de darle clic
            btnAtras.BackgroundImage = Resources.buton2;
        }

        private void btnAtras_MouseUp(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de levantar el clic
            btnAtras.BackgroundImage = Resources.buton1;
        }

        private void btnSalir_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al  momento de darle clic
            btnSalir.BackgroundImage = Resources.buton2;
        }

        private void btnSalir_MouseUp(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de levantar el clic
            btnSalir.BackgroundImage = Resources.buton1;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para regresar al formulario de descripcion del tema
            this.Hide();
            TVCL frmTVCLDescripcion = new TVCL();
            frmTVCLDescripcion.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            //Para limpiar las cajas de texto 
            lbl1.Text = "";
            lbl2.Text = "";
            lbl3.Text = "";
            lbl4.Text = "";
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Para cerrar los formularios
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Para ir a los ejemplos del tema
            this.Hide();
            EjemploTVCL frmEjemplos = new EjemploTVCL();
            frmEjemplos.Show();
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
            Form3 frMRU = new Form3();
            frMRU.Show();
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
            MCUDescripcion frmMCUD = new MCUDescripcion();
            frmMCUD.Show();
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
            //Para navegar al tema de Tiro parabólico
            this.Hide();
            TiroParabolicoDescripcion frmTP = new TiroParabolicoDescripcion();
            frmTP.Show();
        }
    }
}

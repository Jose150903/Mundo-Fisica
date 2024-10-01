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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //Para navegar dentro de otros formularios.
            this.Hide();
            Form4 frmMRUresolucion = new Form4();
            frmMRUresolucion.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para regresar al formulario de menu
            this.Hide();
            Form2 frmtemas = new Form2();
            frmtemas.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void txtHoraMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnTVCL_Click(object sender, EventArgs e)
        {
            //Para navegar al tem de tiro vertical
            this.Hide();
            TVCL frmTVCL = new TVCL();
            frmTVCL.Show();
        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            //Para cambiar imagen al momento de darle clic al botón.
            btnAtras.BackgroundImage = Resources.buton2;
        }

        private void btnAtras_MouseUp(object sender, MouseEventArgs e)
        {
            //Para cambiar imagen al momento de levantar el clic del botón.
            btnAtras.BackgroundImage = Resources.buton1;
        }

        private void btnContinuar_MouseDown(object sender, MouseEventArgs e)
        {
            btnContinuar.BackgroundImage = Resources.buton2;
        }

        private void btnContinuar_MouseUp(object sender, MouseEventArgs e)
        {
            btnContinuar.BackgroundImage = Resources.buton1;
        }

        private void btnTiroParabolico_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de tiro parabólico
            this.Hide();
            TiroParabolicoDescripcion frmTP = new TiroParabolicoDescripcion();
            frmTP.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Conversion frmConversion = new Conversion();
            frmConversion.Show();
        }

        private void lblMRUInfo_Click(object sender, EventArgs e)
        {

        }

        private void btnMRUV_Click(object sender, EventArgs e)
        {
            this.Hide();
            MRUVDescripcion frmMRUVDescripcion = new MRUVDescripcion();
            frmMRUVDescripcion.Show();
        }

        private void btnMCU_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de mcu
            this.Hide();
            MCUDescripcion frmMCUD = new MCUDescripcion();
            frmMCUD.Show();
        }

        private void btnMCUV_Click(object sender, EventArgs e)
        {
            //para navegar al tema de MCUV
            this.Hide();
            MCUVDescripcion frmMCUVD = new MCUVDescripcion();
            frmMCUVD.Show();
        }
    }
}

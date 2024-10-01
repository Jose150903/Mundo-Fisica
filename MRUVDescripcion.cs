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
    public partial class MRUVDescripcion : Form
    {
        public MRUVDescripcion()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Para navegar a las conversiones
            this.Hide();
            Conversion frmConversion = new Conversion();
            frmConversion.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para regresar al formulario de menu.
            this.Hide();
            Form2 frmmenu = new Form2();
            frmmenu.Show();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //Para navegar al formulario de la calculadora
            this.Hide();
            MRUVResolucion frmMRUVResolucion = new MRUVResolucion();
            frmMRUVResolucion.Show();
        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            //Para cambiar la imagen de al momento de darle clic al botón
            btnAtras.BackgroundImage = Resources.buton2;
        }

        private void btnAtras_MouseUp(object sender, MouseEventArgs e)
        {
            // Para cambiar la imagen al momento de levantar el clic del botón
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

        private void btnMRUV_Click(object sender, EventArgs e)
        {
            this.Hide();
            MRUVResolucion frmMRUVResolucion = new MRUVResolucion();
            frmMRUVResolucion.Show();
        }

        private void btnMRU_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de MRU
            this.Hide();
            Form4 frmMRU = new Form4();
            frmMRU.Show();
        }

        private void btnMCU_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de MCU
            this.Hide();
            MCUDescripcion frmMCU = new MCUDescripcion();
            frmMCU.Show();
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
            //Para navegar al tema de Tiro vertical y caida libre
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


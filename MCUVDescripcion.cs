using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Boceto_proyecto.Properties;

namespace Boceto_proyecto
{
    public partial class MCUVDescripcion : Form
    {
        public MCUVDescripcion()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //Para navegar en los distintos formularios con diferentes temas.
            this.Hide();
            MCUVResolucion frmMCUVResolucion = new MCUVResolucion();
            frmMCUVResolucion.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para regresar al formulario del menu.
            this.Hide();
            Form2 frmMenu = new Form2();
            frmMenu.Show();
        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón.
            btnAtras.BackgroundImage = Resources.buton2;
        }

        private void btnAtras_MouseUp(object sender, MouseEventArgs e)
        {
            //Parla darle animación al botón.
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

        private void btnConversion_Click(object sender, EventArgs e)
        {
            //Para navegar a las conversiones
            this.Hide();
            Conversion frmConversion = new Conversion();
            frmConversion.Show();
        }

        private void btnMRU_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de MRU
            this.Hide();
            Form4 frmMRU = new Form4();
            frmMRU.Show();
        }

        private void btnMRUV_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de MRUV
            this.Hide();
            MRUVDescripcion frmMRUVD = new MRUVDescripcion();
            frmMRUVD.Show();
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

        }

        private void btnTVCL_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de Tiro Vertical
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

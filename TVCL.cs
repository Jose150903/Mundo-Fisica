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
    public partial class TVCL : Form
    {
        public TVCL()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.Hide();
            TiroVerticalyCaidaLibre frmtiroVerticalyCaidaLibre = new TiroVerticalyCaidaLibre();
            frmtiroVerticalyCaidaLibre.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 frmMenu = new Form2();
            frmMenu.Show();
        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            btnAtras.BackgroundImage = Resources.buton2;
        }

        private void btnAtras_MouseUp(object sender, MouseEventArgs e)
        {
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
            Form3 frmMRU = new Form3();
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
            //Para navegar al tema de tiro parabólico
            this.Hide();
            TiroParabolicoDescripcion frmTP = new TiroParabolicoDescripcion();
            frmTP.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boceto_proyecto
{
    public partial class TiroParabolicoDescripcion : Form
    {
        public TiroParabolicoDescripcion()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //Para ir al formulario de la calculadora del tema
            this.Hide();
            TiroParabolicoResolucion frmTiroParabolicoR = new TiroParabolicoResolucion();
            frmTiroParabolicoR.Show();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para regresar al formulario del menu
            this.Hide();
            Form2 frmMenu = new Form2();
            frmMenu.Show();
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
            //Para navegar al tema de MCU
            this.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void btnMRUV_Click(object sender, EventArgs e)
        {
            //Para navegar al tema de MRUV
            this.Hide();
            MRUVDescripcion frmMCUV = new MRUVDescripcion();
            frmMCUV.Show();
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


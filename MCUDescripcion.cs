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
    public partial class MCUDescripcion : Form
    {
        public MCUDescripcion()
        {
            InitializeComponent();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //Para continuar al formulario de la calculadora.
            this.Hide();
            MCUResolucion frmMCUResolucion = new MCUResolucion();
            frmMCUResolucion.Show();
        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón.
            btnAtras.BackgroundImage = Resources.buton2;
        }

        private void btnAtras_MouseUp(object sender, MouseEventArgs e)
        {
            //Para darle animación de botón.
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

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para navegar a los distintos formularios con diferentes temas.
            this.Hide();
            Form2 frmMenu = new Form2();
            frmMenu.Show();
        }

        private void btnMRU_Click(object sender, EventArgs e)
        {
            this.Hide();
            MRUVDescripcion frmMRUDescripcion = new MRUVDescripcion();
            frmMRUDescripcion.Show();

        }

        private void btnMRUV_Click(object sender, EventArgs e)
        {
            this.Hide();
            MRUVDescripcion frmMRUVDescripcion = new MRUVDescripcion();
            frmMRUVDescripcion.Show();
        }

        private void btnMCUV_Click(object sender, EventArgs e)
        {
            this.Hide();
            MCUVDescripcion frmMCUVDescripcion = new MCUVDescripcion();
            frmMCUVDescripcion.Show();
        }

        private void btnMCU_Click(object sender, EventArgs e)
        {
            //Para navegar altema de MCU
            this.Hide();
            MCUDescripcion frmMCUD = new MCUDescripcion();
            frmMCUD.Show();
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
            //Para navegar al tema de Tiro parabólico
            this.Hide();
            TiroParabolicoDescripcion frmTP = new TiroParabolicoDescripcion();
            frmTP.Show();
        }
    }
}

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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para regresar al formulario de bienvenida.
            this.Hide();
            Form1 frminicio = new Form1();
            frminicio.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Para cerrar los formularios.
            this.Dispose();
        }

        private void btnMRU_Click(object sender, EventArgs e)
        {
            //Para navegar en los formularios con los distintos temas.
            this.Hide();
            Form3 frmMRUexplicacion = new Form3();
            frmMRUexplicacion.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Conversion frmconversion = new Conversion();
            frmconversion.Show();
        }

        private void btnMRUV_Click(object sender, EventArgs e)
        {
            this.Hide();
            MRUVDescripcion frmMRUVDescripcion = new MRUVDescripcion();
            frmMRUVDescripcion.Show();
        }

        private void btnTiroParabolico_Click(object sender, EventArgs e)
        {
            this.Hide();
            TiroParabolicoDescripcion frmTiroParabolico = new TiroParabolicoDescripcion();
            frmTiroParabolico.Show();
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

        private void btnSalir_MouseDown(object sender, MouseEventArgs e)
        {
            btnSalir.BackgroundImage = Resources.buton2;
        }

        private void btnSalir_MouseUp(object sender, MouseEventArgs e)
        {
            btnSalir.BackgroundImage = Resources.buton1;
        }

        private void btnMCU_Click(object sender, EventArgs e)
        {
            this.Hide();
            MCUDescripcion frmMCUDescripcion = new MCUDescripcion();
            frmMCUDescripcion.Show();
        }

        private void btnMCUV_Click(object sender, EventArgs e)
        {
            this.Hide();
            MCUVDescripcion frmMCUVDescripcion = new MCUVDescripcion();
            frmMCUVDescripcion.Show();
        }

        private void btnTVCL_Click(object sender, EventArgs e)
        {
            this.Hide();
            TVCL frmTVCL = new TVCL();
            frmTVCL.Show();
        }
    }
}

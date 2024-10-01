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
    public partial class EjemplosMRUV : Form
    {
        public EjemplosMRUV()
        {
            InitializeComponent();
        }

        private void EjemplosMRUV_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animacion al botón.
            btnAtras.BackgroundImage = Resources.buton2;
        }

        private void btnAtras_MouseUp(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón.
            btnAtras.BackgroundImage = Resources.buton1;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para regresar al formulario de la calculadora.
            this.Hide();
            MRUVResolucion frmMRUVResolucion = new MRUVResolucion();
            frmMRUVResolucion.Show();
        }
    }
}

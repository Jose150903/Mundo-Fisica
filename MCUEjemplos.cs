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
    public partial class MCUEjemplos : Form
    {
        public MCUEjemplos()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para regresar al formulario de la calculadora.
            this.Hide();
            MCUResolucion frmMCUResolucion = new MCUResolucion();
            frmMCUResolucion.Show();
        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            //Para cambiar la imagen al momento de darle clic al botón.
            btnAtras.BackgroundImage = Resources.buton2;
        }

        private void btnAtras_MouseUp(object sender, MouseEventArgs e)
        {
            //Para cambiar la imagen al momento de levantar el clicl del botón.
            btnAtras.BackgroundImage = Resources.buton1;
        }
    }
}

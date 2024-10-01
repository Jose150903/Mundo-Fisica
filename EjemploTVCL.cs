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
    public partial class EjemploTVCL : Form
    {
        public EjemploTVCL()
        {
            InitializeComponent();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            //Para regresar al formulario de la calculadora del tema
            this.Hide();
            TiroVerticalyCaidaLibre frmtiroVerticalyCaidaLibre = new TiroVerticalyCaidaLibre();
            frmtiroVerticalyCaidaLibre.Show();
        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de darle clic
            btnAtras.BackgroundImage = Resources.buton2;
        }

        private void btnAtras_MouseUp(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón al momento de levantar el clic
            btnAtras.BackgroundImage = Resources.buton1;
        }
    }
}

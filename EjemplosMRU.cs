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
    public partial class EjemplosMRU : Form
    {
        public EjemplosMRU()
        {
            InitializeComponent();
        }

        private void btnAtras_MouseDown(object sender, MouseEventArgs e)
        {
            //Para darle animación al botón.
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
            Form4 frmMRU = new Form4();
            frmMRU.Show();
        }
    }
}

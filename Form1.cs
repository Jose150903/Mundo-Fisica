using Boceto_proyecto.Properties;

namespace Boceto_proyecto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            //Para continuar al formulario del menu.
            this.Hide();
            Form2 frmtemas = new Form2();
            frmtemas.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            //Para cerrar los formularios.
            this.Dispose();
        }

        private void btnContinuar_MouseDown(object sender, MouseEventArgs e)
        {
            // Darle animación de clic
            btnContinuar.BackgroundImage = Resources.buton2;
        }

        private void btnContinuar_MouseUp(object sender, MouseEventArgs e)
        {
            // Darle animación de clic
            btnContinuar.BackgroundImage = Resources.buton1;
        }

        private void btnSalir_MouseDown(object sender, MouseEventArgs e)
        {
            // Darle animación de clic
            btnSalir.BackgroundImage = Resources.buton2;
        }

        private void btnSalir_MouseUp(object sender, MouseEventArgs e)
        {
            // Darle animación de clic
            btnSalir.BackgroundImage = Resources.buton1;
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

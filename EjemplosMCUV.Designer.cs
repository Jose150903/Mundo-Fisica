namespace Boceto_proyecto
{
    partial class EjemplosMCUV
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EjemplosMCUV));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnAtras = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.menuejemplos;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(162, -8);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 97);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(69, 95);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(473, 238);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // btnAtras
            // 
            btnAtras.BackColor = Color.Transparent;
            btnAtras.BackgroundImage = Properties.Resources.buton1;
            btnAtras.BackgroundImageLayout = ImageLayout.Stretch;
            btnAtras.FlatAppearance.BorderSize = 0;
            btnAtras.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnAtras.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnAtras.FlatStyle = FlatStyle.Flat;
            btnAtras.Location = new Point(501, 342);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(94, 42);
            btnAtras.TabIndex = 3;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            btnAtras.MouseDown += btnAtras_MouseDown;
            btnAtras.MouseUp += btnAtras_MouseUp;
            // 
            // EjemplosMCUV
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._104611882_textura_de_madera_superficie_de_fondo_de_madera_clara_para_el_diseño_y_la_decoración;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(631, 396);
            Controls.Add(btnAtras);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "EjemplosMCUV";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EjemplosMCUV";
            Load += EjemplosMCUV_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnAtras;
    }
}
namespace Boceto_proyecto
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            btnContinuar = new Button();
            btnSalir = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(12, 116);
            label1.Name = "label1";
            label1.Size = new Size(307, 174);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // btnContinuar
            // 
            btnContinuar.BackColor = Color.Transparent;
            btnContinuar.BackgroundImage = Properties.Resources.buton1;
            btnContinuar.BackgroundImageLayout = ImageLayout.Stretch;
            btnContinuar.FlatAppearance.BorderSize = 0;
            btnContinuar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnContinuar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnContinuar.FlatStyle = FlatStyle.Flat;
            btnContinuar.Location = new Point(377, 337);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(94, 42);
            btnContinuar.TabIndex = 2;
            btnContinuar.Text = "Continuar";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            btnContinuar.MouseDown += btnContinuar_MouseDown;
            btnContinuar.MouseUp += btnContinuar_MouseUp;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Transparent;
            btnSalir.BackgroundImage = Properties.Resources.buton1;
            btnSalir.BackgroundImageLayout = ImageLayout.Stretch;
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnSalir.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Location = new Point(505, 337);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 42);
            btnSalir.TabIndex = 3;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseDown += btnSalir_MouseDown;
            btnSalir.MouseUp += btnSalir_MouseUp;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = Properties.Resources.menu1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(140, -7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(294, 97);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(367, 116);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(252, 174);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(631, 396);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir);
            Controls.Add(btnContinuar);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button btnContinuar;
        private Button btnSalir;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}

namespace Boceto_proyecto
{
    partial class Form2
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
            lblInformacion = new Label();
            btnMRU = new Button();
            btnMRUV = new Button();
            btnMCU = new Button();
            btnMCUV = new Button();
            btnTVCL = new Button();
            btnTiroParabolico = new Button();
            btnAtras = new Button();
            btnSalir = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // lblInformacion
            // 
            lblInformacion.BackColor = Color.Transparent;
            lblInformacion.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblInformacion.ForeColor = SystemColors.ControlText;
            lblInformacion.Location = new Point(12, 173);
            lblInformacion.Name = "lblInformacion";
            lblInformacion.Size = new Size(312, 129);
            lblInformacion.TabIndex = 0;
            lblInformacion.Text = "Esta aplicación funciona con botones los cuales navegan entre los distintos temas, los cuales ayudan en distintas situaciones al igual que cuenta con un conversor de longitud y de tiempo";
            // 
            // btnMRU
            // 
            btnMRU.BackColor = Color.Transparent;
            btnMRU.BackgroundImage = Properties.Resources.MRU;
            btnMRU.BackgroundImageLayout = ImageLayout.Stretch;
            btnMRU.FlatAppearance.BorderSize = 0;
            btnMRU.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMRU.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMRU.FlatStyle = FlatStyle.Flat;
            btnMRU.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMRU.Location = new Point(168, 2);
            btnMRU.Name = "btnMRU";
            btnMRU.Size = new Size(155, 75);
            btnMRU.TabIndex = 1;
            btnMRU.UseVisualStyleBackColor = false;
            btnMRU.Click += btnMRU_Click;
            // 
            // btnMRUV
            // 
            btnMRUV.BackColor = Color.Transparent;
            btnMRUV.BackgroundImage = Properties.Resources.MRUV;
            btnMRUV.BackgroundImageLayout = ImageLayout.Stretch;
            btnMRUV.FlatAppearance.BorderSize = 0;
            btnMRUV.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMRUV.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMRUV.FlatStyle = FlatStyle.Flat;
            btnMRUV.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMRUV.Location = new Point(169, 70);
            btnMRUV.Name = "btnMRUV";
            btnMRUV.Size = new Size(155, 75);
            btnMRUV.TabIndex = 2;
            btnMRUV.UseVisualStyleBackColor = false;
            btnMRUV.Click += btnMRUV_Click;
            // 
            // btnMCU
            // 
            btnMCU.BackColor = Color.Transparent;
            btnMCU.BackgroundImage = Properties.Resources.MCU;
            btnMCU.BackgroundImageLayout = ImageLayout.Stretch;
            btnMCU.FlatAppearance.BorderSize = 0;
            btnMCU.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMCU.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMCU.FlatStyle = FlatStyle.Flat;
            btnMCU.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMCU.Location = new Point(321, 2);
            btnMCU.Name = "btnMCU";
            btnMCU.Size = new Size(155, 75);
            btnMCU.TabIndex = 3;
            btnMCU.UseVisualStyleBackColor = false;
            btnMCU.Click += btnMCU_Click;
            // 
            // btnMCUV
            // 
            btnMCUV.BackColor = Color.Transparent;
            btnMCUV.BackgroundImage = Properties.Resources.MCUV;
            btnMCUV.BackgroundImageLayout = ImageLayout.Stretch;
            btnMCUV.FlatAppearance.BorderSize = 0;
            btnMCUV.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMCUV.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMCUV.FlatStyle = FlatStyle.Flat;
            btnMCUV.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMCUV.Location = new Point(321, 70);
            btnMCUV.Name = "btnMCUV";
            btnMCUV.Size = new Size(155, 75);
            btnMCUV.TabIndex = 4;
            btnMCUV.UseVisualStyleBackColor = false;
            btnMCUV.Click += btnMCUV_Click;
            // 
            // btnTVCL
            // 
            btnTVCL.BackColor = Color.Transparent;
            btnTVCL.BackgroundImage = Properties.Resources.TVCL;
            btnTVCL.BackgroundImageLayout = ImageLayout.Stretch;
            btnTVCL.FlatAppearance.BorderSize = 0;
            btnTVCL.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTVCL.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTVCL.FlatStyle = FlatStyle.Flat;
            btnTVCL.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTVCL.Location = new Point(474, 0);
            btnTVCL.Name = "btnTVCL";
            btnTVCL.Size = new Size(155, 75);
            btnTVCL.TabIndex = 5;
            btnTVCL.UseVisualStyleBackColor = false;
            btnTVCL.Click += btnTVCL_Click;
            // 
            // btnTiroParabolico
            // 
            btnTiroParabolico.BackColor = Color.Transparent;
            btnTiroParabolico.BackgroundImage = Properties.Resources.TP;
            btnTiroParabolico.BackgroundImageLayout = ImageLayout.Stretch;
            btnTiroParabolico.FlatAppearance.BorderSize = 0;
            btnTiroParabolico.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnTiroParabolico.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnTiroParabolico.FlatStyle = FlatStyle.Flat;
            btnTiroParabolico.Location = new Point(474, 70);
            btnTiroParabolico.Name = "btnTiroParabolico";
            btnTiroParabolico.Size = new Size(155, 75);
            btnTiroParabolico.TabIndex = 6;
            btnTiroParabolico.UseVisualStyleBackColor = false;
            btnTiroParabolico.Click += btnTiroParabolico_Click;
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
            btnAtras.Location = new Point(367, 331);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(101, 39);
            btnAtras.TabIndex = 7;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            btnAtras.MouseDown += btnAtras_MouseDown;
            btnAtras.MouseUp += btnAtras_MouseUp;
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
            btnSalir.Location = new Point(508, 331);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(101, 39);
            btnSalir.TabIndex = 8;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseDown += btnSalir_MouseDown;
            btnSalir.MouseUp += btnSalir_MouseUp;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.Conversiones;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.ControlText;
            button2.Location = new Point(7, 70);
            button2.Name = "button2";
            button2.Size = new Size(155, 75);
            button2.TabIndex = 10;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._104611882_textura_de_madera_superficie_de_fondo_de_madera_clara_para_el_diseño_y_la_decoración;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(631, 396);
            Controls.Add(button2);
            Controls.Add(btnSalir);
            Controls.Add(btnAtras);
            Controls.Add(btnTiroParabolico);
            Controls.Add(btnTVCL);
            Controls.Add(btnMCUV);
            Controls.Add(btnMCU);
            Controls.Add(btnMRUV);
            Controls.Add(btnMRU);
            Controls.Add(lblInformacion);
            Name = "Form2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            ResumeLayout(false);
        }

        #endregion

        private Label lblInformacion;
        private Button btnMRU;
        private Button btnMRUV;
        private Button btnMCU;
        private Button btnMCUV;
        private Button btnTVCL;
        private Button btnTiroParabolico;
        private Button btnAtras;
        private Button btnSalir;
        private Button button2;
    }
}
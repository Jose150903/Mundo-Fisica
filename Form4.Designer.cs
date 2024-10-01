namespace Boceto_proyecto
{
    partial class Form4
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
            lvlDistancia = new Label();
            lblVelocidad = new Label();
            lblResultado = new Label();
            txtDistancia = new TextBox();
            txtVelocidad = new TextBox();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            btnAtras = new Button();
            btnSalir = new Button();
            btnTiroParabolico = new Button();
            btnTVCL = new Button();
            btnMCUV = new Button();
            btnMCU = new Button();
            btnMRUV = new Button();
            btnMRU = new Button();
            button2 = new Button();
            cmbElección = new ComboBox();
            txtTiempo = new TextBox();
            label1 = new Label();
            btnLimpiar = new Button();
            btnEjemplos = new Button();
            SuspendLayout();
            // 
            // lvlDistancia
            // 
            lvlDistancia.AutoSize = true;
            lvlDistancia.BackColor = Color.Transparent;
            lvlDistancia.ForeColor = SystemColors.ControlText;
            lvlDistancia.Location = new Point(141, 169);
            lvlDistancia.Name = "lvlDistancia";
            lvlDistancia.Size = new Size(92, 15);
            lvlDistancia.TabIndex = 0;
            lvlDistancia.Text = "Distancia en Km";
            lvlDistancia.Click += lvlDistancia_Click;
            // 
            // lblVelocidad
            // 
            lblVelocidad.AutoSize = true;
            lblVelocidad.BackColor = Color.Transparent;
            lblVelocidad.ForeColor = SystemColors.ControlText;
            lblVelocidad.Location = new Point(141, 215);
            lblVelocidad.Name = "lblVelocidad";
            lblVelocidad.Size = new Size(107, 15);
            lblVelocidad.TabIndex = 1;
            lblVelocidad.Text = "Velocidad en Km/h";
            lblVelocidad.Click += lblVelocidad_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.ForeColor = SystemColors.ControlText;
            lblResultado.Location = new Point(138, 291);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(88, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "El Resultado es:";
            // 
            // txtDistancia
            // 
            txtDistancia.Location = new Point(286, 164);
            txtDistancia.Name = "txtDistancia";
            txtDistancia.Size = new Size(74, 23);
            txtDistancia.TabIndex = 4;
            // 
            // txtVelocidad
            // 
            txtVelocidad.Location = new Point(286, 207);
            txtVelocidad.Name = "txtVelocidad";
            txtVelocidad.Size = new Size(74, 23);
            txtVelocidad.TabIndex = 5;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(285, 283);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(74, 23);
            txtResultado.TabIndex = 7;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Transparent;
            btnCalcular.BackgroundImage = Properties.Resources.buton1;
            btnCalcular.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalcular.Enabled = false;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCalcular.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Location = new Point(230, 342);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 42);
            btnCalcular.TabIndex = 11;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            btnCalcular.MouseDown += btnCalcular_MouseDown;
            btnCalcular.MouseUp += btnCalcular_MouseUp;
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
            btnAtras.Location = new Point(430, 342);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(94, 42);
            btnAtras.TabIndex = 12;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += button1_Click;
            btnAtras.MouseDown += button1_MouseDown;
            btnAtras.MouseUp += button1_MouseUp;
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
            btnSalir.Location = new Point(514, 342);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 42);
            btnSalir.TabIndex = 13;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseDown += btnSalir_MouseDown;
            btnSalir.MouseUp += btnSalir_MouseUp;
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
            btnTiroParabolico.Location = new Point(471, 70);
            btnTiroParabolico.Name = "btnTiroParabolico";
            btnTiroParabolico.Size = new Size(155, 75);
            btnTiroParabolico.TabIndex = 19;
            btnTiroParabolico.UseVisualStyleBackColor = false;
            btnTiroParabolico.Click += btnTiroParabolico_Click;
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
            btnTVCL.Location = new Point(471, -3);
            btnTVCL.Name = "btnTVCL";
            btnTVCL.Size = new Size(155, 75);
            btnTVCL.TabIndex = 18;
            btnTVCL.UseVisualStyleBackColor = false;
            btnTVCL.Click += btnTVCL_Click;
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
            btnMCUV.Location = new Point(318, 70);
            btnMCUV.Name = "btnMCUV";
            btnMCUV.Size = new Size(155, 75);
            btnMCUV.TabIndex = 17;
            btnMCUV.UseVisualStyleBackColor = false;
            btnMCUV.Click += btnMCUV_Click;
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
            btnMCU.Location = new Point(318, -3);
            btnMCU.Name = "btnMCU";
            btnMCU.Size = new Size(155, 75);
            btnMCU.TabIndex = 16;
            btnMCU.UseVisualStyleBackColor = false;
            btnMCU.Click += btnMCU_Click;
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
            btnMRUV.Location = new Point(160, 70);
            btnMRUV.Name = "btnMRUV";
            btnMRUV.Size = new Size(155, 75);
            btnMRUV.TabIndex = 15;
            btnMRUV.UseVisualStyleBackColor = false;
            btnMRUV.Click += btnMRUV_Click;
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
            btnMRU.Location = new Point(160, -3);
            btnMRU.Name = "btnMRU";
            btnMRU.Size = new Size(155, 75);
            btnMRU.TabIndex = 14;
            btnMRU.UseVisualStyleBackColor = false;
            btnMRU.Click += btnMRU_Click;
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
            button2.Location = new Point(6, 70);
            button2.Name = "button2";
            button2.Size = new Size(155, 75);
            button2.TabIndex = 20;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // cmbElección
            // 
            cmbElección.Font = new Font("Arial", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            cmbElección.FormattingEnabled = true;
            cmbElección.Items.AddRange(new object[] { "Distancia", "Velocidad", "Tiempo" });
            cmbElección.Location = new Point(430, 161);
            cmbElección.Name = "cmbElección";
            cmbElección.Size = new Size(136, 23);
            cmbElección.TabIndex = 21;
            cmbElección.Text = "Que desea calcular";
            cmbElección.SelectedIndexChanged += cmbElección_SelectedIndexChanged;
            // 
            // txtTiempo
            // 
            txtTiempo.Location = new Point(286, 244);
            txtTiempo.Name = "txtTiempo";
            txtTiempo.Size = new Size(74, 23);
            txtTiempo.TabIndex = 23;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(141, 252);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 22;
            label1.Text = "Tiempo en h";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.Transparent;
            btnLimpiar.BackgroundImage = Properties.Resources.buton1;
            btnLimpiar.BackgroundImageLayout = ImageLayout.Stretch;
            btnLimpiar.FlatAppearance.BorderSize = 0;
            btnLimpiar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnLimpiar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnLimpiar.FlatStyle = FlatStyle.Flat;
            btnLimpiar.Location = new Point(330, 342);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 42);
            btnLimpiar.TabIndex = 24;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseDown += btnLimpiar_MouseDown;
            btnLimpiar.MouseUp += btnLimpiar_MouseUp;
            // 
            // btnEjemplos
            // 
            btnEjemplos.BackColor = Color.Transparent;
            btnEjemplos.BackgroundImage = Properties.Resources.Ejemplos;
            btnEjemplos.BackgroundImageLayout = ImageLayout.Stretch;
            btnEjemplos.FlatAppearance.BorderSize = 0;
            btnEjemplos.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEjemplos.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEjemplos.FlatStyle = FlatStyle.Flat;
            btnEjemplos.Location = new Point(6, 2);
            btnEjemplos.Name = "btnEjemplos";
            btnEjemplos.Size = new Size(155, 65);
            btnEjemplos.TabIndex = 25;
            btnEjemplos.UseVisualStyleBackColor = false;
            btnEjemplos.Click += btnEjemplos_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._104611882_textura_de_madera_superficie_de_fondo_de_madera_clara_para_el_diseño_y_la_decoración;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(631, 396);
            Controls.Add(btnEjemplos);
            Controls.Add(btnLimpiar);
            Controls.Add(txtTiempo);
            Controls.Add(label1);
            Controls.Add(cmbElección);
            Controls.Add(button2);
            Controls.Add(btnTiroParabolico);
            Controls.Add(btnTVCL);
            Controls.Add(btnMCUV);
            Controls.Add(btnMCU);
            Controls.Add(btnMRUV);
            Controls.Add(btnMRU);
            Controls.Add(btnSalir);
            Controls.Add(btnAtras);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultado);
            Controls.Add(txtVelocidad);
            Controls.Add(txtDistancia);
            Controls.Add(lblResultado);
            Controls.Add(lblVelocidad);
            Controls.Add(lvlDistancia);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += Form4_Load;
            Click += button1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lvlDistancia;
        private Label lblVelocidad;
        private Label lblResultado;
        private TextBox txtDistancia;
        private TextBox txtVelocidad;
        private TextBox txtResultado;
        private Button btnCalcular;
        private Button btnAtras;
        private Button btnSalir;
        private Button btnTiroParabolico;
        private Button btnTVCL;
        private Button btnMCUV;
        private Button btnMCU;
        private Button btnMRUV;
        private Button btnMRU;
        private Button button2;
        private ComboBox cmbElección;
        private TextBox txtTiempo;
        private Label label1;
        private Button btnLimpiar;
        private Button btnEjemplos;
    }
}
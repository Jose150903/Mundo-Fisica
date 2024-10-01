namespace Boceto_proyecto
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            lblMRUInfo = new Label();
            btnContinuar = new Button();
            btnAtras = new Button();
            btnTiroParabolico = new Button();
            btnTVCL = new Button();
            btnMCUV = new Button();
            btnMCU = new Button();
            btnMRUV = new Button();
            btnMRU = new Button();
            btnConversion = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblMRUInfo
            // 
            lblMRUInfo.BackColor = Color.Transparent;
            lblMRUInfo.Font = new Font("Arial", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblMRUInfo.ForeColor = SystemColors.ControlText;
            lblMRUInfo.Location = new Point(12, 163);
            lblMRUInfo.Name = "lblMRUInfo";
            lblMRUInfo.Size = new Size(341, 158);
            lblMRUInfo.TabIndex = 0;
            lblMRUInfo.Text = resources.GetString("lblMRUInfo.Text");
            lblMRUInfo.Click += lblMRUInfo_Click;
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
            btnContinuar.Location = new Point(472, 337);
            btnContinuar.Name = "btnContinuar";
            btnContinuar.Size = new Size(121, 47);
            btnContinuar.TabIndex = 1;
            btnContinuar.Text = "Continuar a Resolver";
            btnContinuar.UseVisualStyleBackColor = false;
            btnContinuar.Click += btnContinuar_Click;
            btnContinuar.MouseDown += btnContinuar_MouseDown;
            btnContinuar.MouseUp += btnContinuar_MouseUp;
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
            btnAtras.Location = new Point(310, 337);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(121, 47);
            btnAtras.TabIndex = 2;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            btnAtras.MouseDown += btnAtras_MouseDown;
            btnAtras.MouseUp += btnAtras_MouseUp;
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
            btnTiroParabolico.Location = new Point(474, -3);
            btnTiroParabolico.Name = "btnTiroParabolico";
            btnTiroParabolico.Size = new Size(155, 75);
            btnTiroParabolico.TabIndex = 20;
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
            btnTVCL.Location = new Point(310, 70);
            btnTVCL.Name = "btnTVCL";
            btnTVCL.Size = new Size(155, 75);
            btnTVCL.TabIndex = 19;
            btnTVCL.UseVisualStyleBackColor = false;
            btnTVCL.Click += btnTVCL_Click;
            // 
            // btnMCUV
            // 
            btnMCUV.BackColor = Color.Transparent;
            btnMCUV.BackgroundImage = Properties.Resources.MCUV;
            btnMCUV.BackgroundImageLayout = ImageLayout.Stretch;
            btnMCUV.CausesValidation = false;
            btnMCUV.FlatAppearance.BorderSize = 0;
            btnMCUV.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnMCUV.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnMCUV.FlatStyle = FlatStyle.Flat;
            btnMCUV.Location = new Point(313, -3);
            btnMCUV.Name = "btnMCUV";
            btnMCUV.Size = new Size(155, 75);
            btnMCUV.TabIndex = 18;
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
            btnMCU.Location = new Point(160, 70);
            btnMCU.Name = "btnMCU";
            btnMCU.Size = new Size(155, 75);
            btnMCU.TabIndex = 17;
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
            btnMRUV.Location = new Point(160, -3);
            btnMRUV.Name = "btnMRUV";
            btnMRUV.Size = new Size(155, 75);
            btnMRUV.TabIndex = 16;
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
            btnMRU.Location = new Point(-1, 70);
            btnMRU.Name = "btnMRU";
            btnMRU.Size = new Size(155, 75);
            btnMRU.TabIndex = 15;
            btnMRU.UseVisualStyleBackColor = false;
            // 
            // btnConversion
            // 
            btnConversion.BackColor = Color.Transparent;
            btnConversion.BackgroundImage = Properties.Resources.Conversiones;
            btnConversion.BackgroundImageLayout = ImageLayout.Stretch;
            btnConversion.FlatAppearance.BorderSize = 0;
            btnConversion.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnConversion.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnConversion.FlatStyle = FlatStyle.Flat;
            btnConversion.ForeColor = SystemColors.ControlText;
            btnConversion.Location = new Point(-1, 0);
            btnConversion.Name = "btnConversion";
            btnConversion.Size = new Size(155, 75);
            btnConversion.TabIndex = 22;
            btnConversion.UseVisualStyleBackColor = false;
            btnConversion.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(387, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(206, 142);
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._104611882_textura_de_madera_superficie_de_fondo_de_madera_clara_para_el_diseño_y_la_decoración;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(631, 396);
            Controls.Add(pictureBox1);
            Controls.Add(btnConversion);
            Controls.Add(btnTiroParabolico);
            Controls.Add(btnTVCL);
            Controls.Add(btnMCUV);
            Controls.Add(btnMCU);
            Controls.Add(btnMRUV);
            Controls.Add(btnMRU);
            Controls.Add(btnAtras);
            Controls.Add(btnContinuar);
            Controls.Add(lblMRUInfo);
            Location = new Point(-1, 0);
            Name = "Form3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label lblMRUInfo;
        private Button btnContinuar;
        private Button btnAtras;
        private Button btnTiroParabolico;
        private Button btnTVCL;
        private Button btnMCUV;
        private Button btnMCU;
        private Button btnMRUV;
        private Button btnMRU;
        private Button btnConversion;
        private PictureBox pictureBox1;
    }
}
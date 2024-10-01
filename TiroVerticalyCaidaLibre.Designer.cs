namespace Boceto_proyecto
{
    partial class TiroVerticalyCaidaLibre
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
            rbCaidaLibre = new RadioButton();
            cmbCaidaLibre = new ComboBox();
            rbTiroVertical = new RadioButton();
            cmbTiroVertical = new ComboBox();
            txt4 = new TextBox();
            txt3 = new TextBox();
            txt2 = new TextBox();
            txt1 = new TextBox();
            lbl4 = new Label();
            lbl3 = new Label();
            lbl2 = new Label();
            lbl1 = new Label();
            btnLimpiar = new Button();
            btnSalir = new Button();
            btnAtras = new Button();
            btnCalcular = new Button();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            SuspendLayout();
            // 
            // rbCaidaLibre
            // 
            rbCaidaLibre.AutoSize = true;
            rbCaidaLibre.BackColor = Color.Transparent;
            rbCaidaLibre.FlatAppearance.BorderSize = 0;
            rbCaidaLibre.FlatAppearance.CheckedBackColor = Color.Transparent;
            rbCaidaLibre.FlatAppearance.MouseDownBackColor = Color.Transparent;
            rbCaidaLibre.FlatAppearance.MouseOverBackColor = Color.Transparent;
            rbCaidaLibre.Location = new Point(212, 163);
            rbCaidaLibre.Name = "rbCaidaLibre";
            rbCaidaLibre.Size = new Size(84, 19);
            rbCaidaLibre.TabIndex = 113;
            rbCaidaLibre.TabStop = true;
            rbCaidaLibre.Text = "Caída Libre";
            rbCaidaLibre.UseVisualStyleBackColor = false;
            rbCaidaLibre.CheckedChanged += rbCaidaLibre_CheckedChanged_1;
            // 
            // cmbCaidaLibre
            // 
            cmbCaidaLibre.FormattingEnabled = true;
            cmbCaidaLibre.Items.AddRange(new object[] { "Altura", "Velocidad Inicial", "Velocidad Final", "Tiempo", "Gravedad" });
            cmbCaidaLibre.Location = new Point(409, 167);
            cmbCaidaLibre.Name = "cmbCaidaLibre";
            cmbCaidaLibre.Size = new Size(181, 23);
            cmbCaidaLibre.TabIndex = 112;
            cmbCaidaLibre.Text = "Que desea Calcular";
            cmbCaidaLibre.Visible = false;
            cmbCaidaLibre.SelectedIndexChanged += cmbCaidaLibre_SelectedIndexChanged_1;
            // 
            // rbTiroVertical
            // 
            rbTiroVertical.AutoSize = true;
            rbTiroVertical.BackColor = Color.Transparent;
            rbTiroVertical.FlatAppearance.BorderSize = 0;
            rbTiroVertical.FlatAppearance.MouseDownBackColor = Color.Transparent;
            rbTiroVertical.FlatAppearance.MouseOverBackColor = Color.Transparent;
            rbTiroVertical.FlatStyle = FlatStyle.Flat;
            rbTiroVertical.Location = new Point(62, 163);
            rbTiroVertical.Name = "rbTiroVertical";
            rbTiroVertical.Size = new Size(85, 19);
            rbTiroVertical.TabIndex = 111;
            rbTiroVertical.TabStop = true;
            rbTiroVertical.Text = "Tiro Vertical";
            rbTiroVertical.UseVisualStyleBackColor = false;
            rbTiroVertical.CheckedChanged += rbTiroVertical_CheckedChanged_1;
            // 
            // cmbTiroVertical
            // 
            cmbTiroVertical.FormattingEnabled = true;
            cmbTiroVertical.Items.AddRange(new object[] { "Altura", "Velocidad Inicial", "Tiempo", "Gravedad" });
            cmbTiroVertical.Location = new Point(409, 167);
            cmbTiroVertical.Name = "cmbTiroVertical";
            cmbTiroVertical.Size = new Size(181, 23);
            cmbTiroVertical.TabIndex = 110;
            cmbTiroVertical.Text = "Que desea Calcular";
            cmbTiroVertical.Visible = false;
            cmbTiroVertical.SelectedIndexChanged += cmbTiroVertical_SelectedIndexChanged;
            // 
            // txt4
            // 
            txt4.Location = new Point(232, 306);
            txt4.Name = "txt4";
            txt4.ReadOnly = true;
            txt4.Size = new Size(128, 23);
            txt4.TabIndex = 109;
            // 
            // txt3
            // 
            txt3.Location = new Point(232, 272);
            txt3.Name = "txt3";
            txt3.Size = new Size(128, 23);
            txt3.TabIndex = 108;
            // 
            // txt2
            // 
            txt2.Location = new Point(232, 234);
            txt2.Name = "txt2";
            txt2.Size = new Size(128, 23);
            txt2.TabIndex = 107;
            // 
            // txt1
            // 
            txt1.Location = new Point(232, 200);
            txt1.Name = "txt1";
            txt1.Size = new Size(128, 23);
            txt1.TabIndex = 106;
            // 
            // lbl4
            // 
            lbl4.AutoSize = true;
            lbl4.BackColor = Color.Transparent;
            lbl4.FlatStyle = FlatStyle.Flat;
            lbl4.Location = new Point(75, 309);
            lbl4.Name = "lbl4";
            lbl4.Size = new Size(17, 15);
            lbl4.TabIndex = 105;
            lbl4.Text = "--";
            // 
            // lbl3
            // 
            lbl3.AutoSize = true;
            lbl3.BackColor = Color.Transparent;
            lbl3.FlatStyle = FlatStyle.Flat;
            lbl3.Location = new Point(75, 275);
            lbl3.Name = "lbl3";
            lbl3.Size = new Size(17, 15);
            lbl3.TabIndex = 104;
            lbl3.Text = "--";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.BackColor = Color.Transparent;
            lbl2.FlatStyle = FlatStyle.Flat;
            lbl2.Location = new Point(75, 237);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(17, 15);
            lbl2.TabIndex = 103;
            lbl2.Text = "--";
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.BackColor = Color.Transparent;
            lbl1.FlatStyle = FlatStyle.Flat;
            lbl1.Location = new Point(75, 203);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(17, 15);
            lbl1.TabIndex = 102;
            lbl1.Text = "--";
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
            btnLimpiar.Location = new Point(348, 339);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 42);
            btnLimpiar.TabIndex = 101;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            btnLimpiar.MouseDown += btnLimpiar_MouseDown;
            btnLimpiar.MouseUp += btnLimpiar_MouseUp;
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
            btnSalir.Location = new Point(532, 339);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 42);
            btnSalir.TabIndex = 100;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            btnSalir.MouseDown += btnSalir_MouseDown;
            btnSalir.MouseUp += btnSalir_MouseUp;
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
            btnAtras.Location = new Point(448, 339);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(94, 42);
            btnAtras.TabIndex = 99;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
            btnAtras.MouseDown += btnAtras_MouseDown;
            btnAtras.MouseUp += btnAtras_MouseUp;
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
            btnCalcular.Location = new Point(248, 339);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 42);
            btnCalcular.TabIndex = 98;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            btnCalcular.MouseDown += btnCalcular_MouseDown;
            btnCalcular.MouseUp += btnCalcular_MouseUp;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.Ejemplos;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Location = new Point(-2, 4);
            button1.Name = "button1";
            button1.Size = new Size(155, 65);
            button1.TabIndex = 97;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            button2.Location = new Point(-2, 69);
            button2.Name = "button2";
            button2.Size = new Size(155, 75);
            button2.TabIndex = 96;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImage = Properties.Resources.TP;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button3.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(471, 69);
            button3.Name = "button3";
            button3.Size = new Size(155, 75);
            button3.TabIndex = 95;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.TVCL;
            button4.BackgroundImageLayout = ImageLayout.Stretch;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button4.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(471, -1);
            button4.Name = "button4";
            button4.Size = new Size(155, 75);
            button4.TabIndex = 94;
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = Properties.Resources.MCUV;
            button5.BackgroundImageLayout = ImageLayout.Stretch;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button5.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(320, 69);
            button5.Name = "button5";
            button5.Size = new Size(155, 75);
            button5.TabIndex = 93;
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.BackColor = Color.Transparent;
            button6.BackgroundImage = Properties.Resources.MCU;
            button6.BackgroundImageLayout = ImageLayout.Stretch;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button6.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Location = new Point(320, -1);
            button6.Name = "button6";
            button6.Size = new Size(155, 75);
            button6.TabIndex = 92;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.BackColor = Color.Transparent;
            button7.BackgroundImage = Properties.Resources.MRUV;
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button7.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Location = new Point(159, 69);
            button7.Name = "button7";
            button7.Size = new Size(155, 75);
            button7.TabIndex = 91;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.Transparent;
            button8.BackgroundImage = Properties.Resources.MRU;
            button8.BackgroundImageLayout = ImageLayout.Stretch;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button8.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button8.FlatStyle = FlatStyle.Flat;
            button8.ForeColor = Color.BlanchedAlmond;
            button8.Location = new Point(159, -1);
            button8.Name = "button8";
            button8.Size = new Size(155, 75);
            button8.TabIndex = 90;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // TiroVerticalyCaidaLibre
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._104611882_textura_de_madera_superficie_de_fondo_de_madera_clara_para_el_diseño_y_la_decoración;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(631, 396);
            Controls.Add(rbCaidaLibre);
            Controls.Add(cmbCaidaLibre);
            Controls.Add(rbTiroVertical);
            Controls.Add(cmbTiroVertical);
            Controls.Add(txt4);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Controls.Add(lbl4);
            Controls.Add(lbl3);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(btnAtras);
            Controls.Add(btnCalcular);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Name = "TiroVerticalyCaidaLibre";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TiroVerticalyCaidaLibre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rbCaidaLibre;
        private ComboBox cmbCaidaLibre;
        private RadioButton rbTiroVertical;
        private ComboBox cmbTiroVertical;
        private TextBox txt4;
        private TextBox txt3;
        private TextBox txt2;
        private TextBox txt1;
        private Label lbl4;
        private Label lbl3;
        private Label lbl2;
        private Label lbl1;
        private Button btnLimpiar;
        private Button btnSalir;
        private Button btnAtras;
        private Button btnCalcular;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}
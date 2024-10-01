namespace Boceto_proyecto
{
    partial class Conversion
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
            cmbDe = new ComboBox();
            cmbA = new ComboBox();
            lblDe = new Label();
            lblA = new Label();
            lblValor = new Label();
            lblResultado = new Label();
            label5 = new Label();
            txtValor = new TextBox();
            txtResultado = new TextBox();
            btnCalcular = new Button();
            btnAtras = new Button();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // cmbDe
            // 
            cmbDe.FormattingEnabled = true;
            cmbDe.Items.AddRange(new object[] { "Centimetros", "Metros", "Kilometros", "Segundos", "Minutos", "Horas" });
            cmbDe.Location = new Point(148, 115);
            cmbDe.Name = "cmbDe";
            cmbDe.Size = new Size(121, 23);
            cmbDe.TabIndex = 0;
            // 
            // cmbA
            // 
            cmbA.FormattingEnabled = true;
            cmbA.Items.AddRange(new object[] { "Centimetros", "Metros", "Kilometros", "Segundos", "Minutos", "Horas" });
            cmbA.Location = new Point(390, 115);
            cmbA.Name = "cmbA";
            cmbA.Size = new Size(121, 23);
            cmbA.TabIndex = 1;
            // 
            // lblDe
            // 
            lblDe.AutoSize = true;
            lblDe.BackColor = Color.Transparent;
            lblDe.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDe.ForeColor = SystemColors.ControlText;
            lblDe.Location = new Point(148, 85);
            lblDe.Name = "lblDe";
            lblDe.Size = new Size(41, 25);
            lblDe.TabIndex = 2;
            lblDe.Text = "De:";
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.BackColor = Color.Transparent;
            lblA.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblA.ForeColor = SystemColors.ControlText;
            lblA.Location = new Point(390, 85);
            lblA.Name = "lblA";
            lblA.Size = new Size(30, 25);
            lblA.TabIndex = 3;
            lblA.Text = "A:";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.BackColor = Color.Transparent;
            lblValor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblValor.ForeColor = SystemColors.ControlText;
            lblValor.Location = new Point(148, 202);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(141, 21);
            lblValor.TabIndex = 4;
            lblValor.Text = "Valor a convertir:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.BackColor = Color.Transparent;
            lblResultado.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblResultado.ForeColor = SystemColors.ControlText;
            lblResultado.Location = new Point(390, 202);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(105, 25);
            lblResultado.TabIndex = 5;
            lblResultado.Text = "Resultado:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ControlText;
            label5.Location = new Point(247, 38);
            label5.Name = "label5";
            label5.Size = new Size(123, 30);
            label5.TabIndex = 6;
            label5.Text = "Conversión";
            label5.Click += label5_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(148, 231);
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(100, 23);
            txtValor.TabIndex = 7;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(390, 231);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(100, 23);
            txtResultado.TabIndex = 8;
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.Transparent;
            btnCalcular.BackgroundImage = Properties.Resources.buton1;
            btnCalcular.BackgroundImageLayout = ImageLayout.Stretch;
            btnCalcular.FlatAppearance.BorderSize = 0;
            btnCalcular.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnCalcular.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnCalcular.FlatStyle = FlatStyle.Flat;
            btnCalcular.Location = new Point(247, 327);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(94, 42);
            btnCalcular.TabIndex = 12;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
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
            btnAtras.Location = new Point(392, 327);
            btnAtras.Name = "btnAtras";
            btnAtras.Size = new Size(94, 42);
            btnAtras.TabIndex = 13;
            btnAtras.Text = "Atrás";
            btnAtras.UseVisualStyleBackColor = false;
            btnAtras.Click += btnAtras_Click;
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
            btnSalir.Location = new Point(503, 327);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 42);
            btnSalir.TabIndex = 14;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // Conversion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._104611882_textura_de_madera_superficie_de_fondo_de_madera_clara_para_el_diseño_y_la_decoración;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(631, 396);
            Controls.Add(btnSalir);
            Controls.Add(btnAtras);
            Controls.Add(btnCalcular);
            Controls.Add(txtResultado);
            Controls.Add(txtValor);
            Controls.Add(label5);
            Controls.Add(lblResultado);
            Controls.Add(lblValor);
            Controls.Add(lblA);
            Controls.Add(lblDe);
            Controls.Add(cmbA);
            Controls.Add(cmbDe);
            Name = "Conversion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversion";
            Load += Conversion_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbDe;
        private ComboBox cmbA;
        private Label lblDe;
        private Label lblA;
        private Label lblValor;
        private Label lblResultado;
        private Label label5;
        private TextBox txtValor;
        private TextBox txtResultado;
        private Button btnCalcular;
        private Button btnAtras;
        private Button btnSalir;
    }
}
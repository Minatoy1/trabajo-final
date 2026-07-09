namespace trabajo_final
{
    partial class FormPaciente
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
            btnSiguiente = new Button();
            btnCancelar = new Button();
            label2 = new Label();
            tabControl1 = new TabControl();
            tapControl1 = new TabPage();
            dtpNacimientoP = new DateTimePicker();
            lblNacimientoP = new Label();
            txbCoberturaArs = new TextBox();
            lblCoberturaArs = new Label();
            cmbArsP = new ComboBox();
            cmbSangreP = new ComboBox();
            cmbGeneroP = new ComboBox();
            txbCorreoP = new TextBox();
            txbTelefonoP = new TextBox();
            txbCedulaP = new TextBox();
            txbNombreP = new TextBox();
            lblArsP = new Label();
            lblGeneroP = new Label();
            lblTelefonoP = new Label();
            lblCorreoP = new Label();
            lblSangreP = new Label();
            lblCedulaP = new Label();
            lblNombreP = new Label();
            tabPage1 = new TabPage();
            cmbEstadoC = new ComboBox();
            dtpHoraC = new DateTimePicker();
            dtpFechaC = new DateTimePicker();
            txbMotivoC = new TextBox();
            txbCedulaC = new TextBox();
            lblEstadoC = new Label();
            lblMotivoC = new Label();
            lblNumC = new Label();
            label5 = new Label();
            lblFechaC = new Label();
            lblHoraC = new Label();
            lblCita = new Label();
            tabControl1.SuspendLayout();
            tapControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(683, 411);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(109, 41);
            btnSiguiente.TabIndex = 0;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            btnSiguiente.Click += btnSiguiente_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(823, 411);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 41);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 38);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 3;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tapControl1);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location = new Point(11, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(913, 399);
            tabControl1.TabIndex = 4;
            // 
            // tapControl1
            // 
            tapControl1.Controls.Add(dtpNacimientoP);
            tapControl1.Controls.Add(lblNacimientoP);
            tapControl1.Controls.Add(txbCoberturaArs);
            tapControl1.Controls.Add(lblCoberturaArs);
            tapControl1.Controls.Add(cmbArsP);
            tapControl1.Controls.Add(cmbSangreP);
            tapControl1.Controls.Add(cmbGeneroP);
            tapControl1.Controls.Add(txbCorreoP);
            tapControl1.Controls.Add(txbTelefonoP);
            tapControl1.Controls.Add(txbCedulaP);
            tapControl1.Controls.Add(txbNombreP);
            tapControl1.Controls.Add(lblArsP);
            tapControl1.Controls.Add(lblGeneroP);
            tapControl1.Controls.Add(lblTelefonoP);
            tapControl1.Controls.Add(lblCorreoP);
            tapControl1.Controls.Add(lblSangreP);
            tapControl1.Controls.Add(lblCedulaP);
            tapControl1.Controls.Add(lblNombreP);
            tapControl1.Location = new Point(4, 29);
            tapControl1.Name = "tapControl1";
            tapControl1.Padding = new Padding(3);
            tapControl1.Size = new Size(905, 366);
            tapControl1.TabIndex = 1;
            tapControl1.Text = "Paciente";
            tapControl1.UseVisualStyleBackColor = true;
            // 
            // dtpNacimientoP
            // 
            dtpNacimientoP.Format = DateTimePickerFormat.Short;
            dtpNacimientoP.Location = new Point(165, 96);
            dtpNacimientoP.Name = "dtpNacimientoP";
            dtpNacimientoP.Size = new Size(191, 27);
            dtpNacimientoP.TabIndex = 17;
            dtpNacimientoP.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // lblNacimientoP
            // 
            lblNacimientoP.AutoSize = true;
            lblNacimientoP.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblNacimientoP.Location = new Point(6, 101);
            lblNacimientoP.Name = "lblNacimientoP";
            lblNacimientoP.Size = new Size(159, 20);
            lblNacimientoP.TabIndex = 16;
            lblNacimientoP.Text = "Fecha de Nacimiento";
            lblNacimientoP.Click += label1_Click_1;
            // 
            // txbCoberturaArs
            // 
            txbCoberturaArs.BorderStyle = BorderStyle.FixedSingle;
            txbCoberturaArs.Location = new Point(105, 290);
            txbCoberturaArs.Name = "txbCoberturaArs";
            txbCoberturaArs.ReadOnly = true;
            txbCoberturaArs.Size = new Size(60, 27);
            txbCoberturaArs.TabIndex = 15;
            // 
            // lblCoberturaArs
            // 
            lblCoberturaArs.AutoSize = true;
            lblCoberturaArs.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblCoberturaArs.Location = new Point(18, 292);
            lblCoberturaArs.Name = "lblCoberturaArs";
            lblCoberturaArs.Size = new Size(81, 20);
            lblCoberturaArs.TabIndex = 14;
            lblCoberturaArs.Text = "Cobertura";
            lblCoberturaArs.Visible = false;
            // 
            // cmbArsP
            // 
            cmbArsP.FormattingEnabled = true;
            cmbArsP.Items.AddRange(new object[] { "Privado / Sin Seguro", "Primera (Humano)", "Mapfre Salud", "Monumental", "SeNaSa ", "Universal", "Palic (Futuro / Rimac)", "Renacer" });
            cmbArsP.Location = new Point(62, 219);
            cmbArsP.Name = "cmbArsP";
            cmbArsP.Size = new Size(84, 28);
            cmbArsP.TabIndex = 13;
            cmbArsP.SelectedIndexChanged += cmbArsP_SelectedIndexChanged;
            // 
            // cmbSangreP
            // 
            cmbSangreP.FormattingEnabled = true;
            cmbSangreP.Items.AddRange(new object[] { "A+", "A-", "B+", "B-", "AB+", "AB-", "O+", "O-" });
            cmbSangreP.Location = new Point(807, 98);
            cmbSangreP.Name = "cmbSangreP";
            cmbSangreP.Size = new Size(84, 28);
            cmbSangreP.TabIndex = 12;
            // 
            // cmbGeneroP
            // 
            cmbGeneroP.FormattingEnabled = true;
            cmbGeneroP.Items.AddRange(new object[] { "Hombre", "Mujer" });
            cmbGeneroP.Location = new Point(807, 12);
            cmbGeneroP.Name = "cmbGeneroP";
            cmbGeneroP.Size = new Size(84, 28);
            cmbGeneroP.TabIndex = 11;
            cmbGeneroP.SelectedIndexChanged += cmbGeneroP_SelectedIndexChanged;
            // 
            // txbCorreoP
            // 
            txbCorreoP.BorderStyle = BorderStyle.FixedSingle;
            txbCorreoP.Location = new Point(152, 154);
            txbCorreoP.Name = "txbCorreoP";
            txbCorreoP.Size = new Size(263, 27);
            txbCorreoP.TabIndex = 10;
            // 
            // txbTelefonoP
            // 
            txbTelefonoP.BorderStyle = BorderStyle.FixedSingle;
            txbTelefonoP.Location = new Point(478, 94);
            txbTelefonoP.Name = "txbTelefonoP";
            txbTelefonoP.Size = new Size(188, 27);
            txbTelefonoP.TabIndex = 9;
            // 
            // txbCedulaP
            // 
            txbCedulaP.BorderStyle = BorderStyle.FixedSingle;
            txbCedulaP.Location = new Point(576, 13);
            txbCedulaP.Name = "txbCedulaP";
            txbCedulaP.Size = new Size(161, 27);
            txbCedulaP.TabIndex = 8;
            // 
            // txbNombreP
            // 
            txbNombreP.BorderStyle = BorderStyle.FixedSingle;
            txbNombreP.Location = new Point(79, 13);
            txbNombreP.Name = "txbNombreP";
            txbNombreP.Size = new Size(417, 27);
            txbNombreP.TabIndex = 7;
            // 
            // lblArsP
            // 
            lblArsP.AutoSize = true;
            lblArsP.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblArsP.Location = new Point(18, 227);
            lblArsP.Name = "lblArsP";
            lblArsP.Size = new Size(38, 20);
            lblArsP.TabIndex = 6;
            lblArsP.Text = "ARS";
            // 
            // lblGeneroP
            // 
            lblGeneroP.AutoSize = true;
            lblGeneroP.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblGeneroP.Location = new Point(743, 20);
            lblGeneroP.Name = "lblGeneroP";
            lblGeneroP.Size = new Size(60, 20);
            lblGeneroP.TabIndex = 5;
            lblGeneroP.Text = "Género";
            // 
            // lblTelefonoP
            // 
            lblTelefonoP.AutoSize = true;
            lblTelefonoP.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblTelefonoP.Location = new Point(400, 101);
            lblTelefonoP.Name = "lblTelefonoP";
            lblTelefonoP.Size = new Size(72, 20);
            lblTelefonoP.TabIndex = 4;
            lblTelefonoP.Text = "Teléfono";
            lblTelefonoP.Click += lblTelefonoP_Click;
            // 
            // lblCorreoP
            // 
            lblCorreoP.AutoSize = true;
            lblCorreoP.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblCorreoP.Location = new Point(6, 156);
            lblCorreoP.Name = "lblCorreoP";
            lblCorreoP.Size = new Size(140, 20);
            lblCorreoP.TabIndex = 3;
            lblCorreoP.Text = "Correo Electronico";
            lblCorreoP.Click += label3_Click_1;
            // 
            // lblSangreP
            // 
            lblSangreP.AutoSize = true;
            lblSangreP.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblSangreP.Location = new Point(688, 101);
            lblSangreP.Name = "lblSangreP";
            lblSangreP.Size = new Size(115, 20);
            lblSangreP.TabIndex = 2;
            lblSangreP.Text = "Tipo de Sangre";
            // 
            // lblCedulaP
            // 
            lblCedulaP.AutoSize = true;
            lblCedulaP.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblCedulaP.Location = new Point(511, 20);
            lblCedulaP.Name = "lblCedulaP";
            lblCedulaP.Size = new Size(59, 20);
            lblCedulaP.TabIndex = 1;
            lblCedulaP.Text = "Cédula";
            lblCedulaP.Click += label3_Click;
            // 
            // lblNombreP
            // 
            lblNombreP.AutoSize = true;
            lblNombreP.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblNombreP.Location = new Point(3, 20);
            lblNombreP.Name = "lblNombreP";
            lblNombreP.Size = new Size(67, 20);
            lblNombreP.TabIndex = 0;
            lblNombreP.Text = "Nombre";
            lblNombreP.Click += label1_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(cmbEstadoC);
            tabPage1.Controls.Add(dtpHoraC);
            tabPage1.Controls.Add(dtpFechaC);
            tabPage1.Controls.Add(txbMotivoC);
            tabPage1.Controls.Add(txbCedulaC);
            tabPage1.Controls.Add(lblEstadoC);
            tabPage1.Controls.Add(lblMotivoC);
            tabPage1.Controls.Add(lblNumC);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(lblFechaC);
            tabPage1.Controls.Add(lblHoraC);
            tabPage1.Controls.Add(lblCita);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(905, 366);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Cita";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // cmbEstadoC
            // 
            cmbEstadoC.FormattingEnabled = true;
            cmbEstadoC.Items.AddRange(new object[] { "Pendiente", "Completa", "Cancelada" });
            cmbEstadoC.Location = new Point(75, 306);
            cmbEstadoC.Name = "cmbEstadoC";
            cmbEstadoC.Size = new Size(109, 28);
            cmbEstadoC.TabIndex = 11;
            cmbEstadoC.Text = "Pendiente";
            // 
            // dtpHoraC
            // 
            dtpHoraC.Format = DateTimePickerFormat.Time;
            dtpHoraC.Location = new Point(536, 49);
            dtpHoraC.Name = "dtpHoraC";
            dtpHoraC.Size = new Size(128, 27);
            dtpHoraC.TabIndex = 10;
            // 
            // dtpFechaC
            // 
            dtpFechaC.Format = DateTimePickerFormat.Short;
            dtpFechaC.Location = new Point(354, 47);
            dtpFechaC.Name = "dtpFechaC";
            dtpFechaC.Size = new Size(128, 27);
            dtpFechaC.TabIndex = 9;
            // 
            // txbMotivoC
            // 
            txbMotivoC.BorderStyle = BorderStyle.FixedSingle;
            txbMotivoC.Location = new Point(12, 133);
            txbMotivoC.Multiline = true;
            txbMotivoC.Name = "txbMotivoC";
            txbMotivoC.Size = new Size(887, 158);
            txbMotivoC.TabIndex = 8;
            // 
            // txbCedulaC
            // 
            txbCedulaC.BorderStyle = BorderStyle.FixedSingle;
            txbCedulaC.Location = new Point(73, 49);
            txbCedulaC.Name = "txbCedulaC";
            txbCedulaC.Size = new Size(145, 27);
            txbCedulaC.TabIndex = 7;
            // 
            // lblEstadoC
            // 
            lblEstadoC.AutoSize = true;
            lblEstadoC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblEstadoC.Location = new Point(12, 309);
            lblEstadoC.Name = "lblEstadoC";
            lblEstadoC.Size = new Size(61, 20);
            lblEstadoC.TabIndex = 6;
            lblEstadoC.Text = "Estado:";
            lblEstadoC.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblMotivoC
            // 
            lblMotivoC.AutoSize = true;
            lblMotivoC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblMotivoC.Location = new Point(12, 110);
            lblMotivoC.Name = "lblMotivoC";
            lblMotivoC.Size = new Size(63, 20);
            lblMotivoC.TabIndex = 5;
            lblMotivoC.Text = "Motivo:";
            lblMotivoC.TextAlign = ContentAlignment.TopCenter;
            // 
            // lblNumC
            // 
            lblNumC.AutoSize = true;
            lblNumC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblNumC.ForeColor = Color.LightCoral;
            lblNumC.Location = new Point(44, 13);
            lblNumC.Name = "lblNumC";
            lblNumC.Size = new Size(18, 20);
            lblNumC.TabIndex = 4;
            lblNumC.Text = "1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            label5.Location = new Point(12, 52);
            label5.Name = "label5";
            label5.Size = new Size(59, 20);
            label5.TabIndex = 3;
            label5.Text = "Cédula";
            // 
            // lblFechaC
            // 
            lblFechaC.AutoSize = true;
            lblFechaC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblFechaC.Location = new Point(228, 52);
            lblFechaC.Name = "lblFechaC";
            lblFechaC.Size = new Size(123, 20);
            lblFechaC.TabIndex = 2;
            lblFechaC.Text = "Fecha de la Cita";
            // 
            // lblHoraC
            // 
            lblHoraC.AutoSize = true;
            lblHoraC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblHoraC.Location = new Point(488, 52);
            lblHoraC.Name = "lblHoraC";
            lblHoraC.Size = new Size(44, 20);
            lblHoraC.TabIndex = 1;
            lblHoraC.Text = "Hora";
            // 
            // lblCita
            // 
            lblCita.AutoSize = true;
            lblCita.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblCita.ForeColor = SystemColors.ActiveBorder;
            lblCita.Location = new Point(6, 13);
            lblCita.Name = "lblCita";
            lblCita.Size = new Size(43, 20);
            lblCita.TabIndex = 0;
            lblCita.Text = "Cita:";
            lblCita.Click += label1_Click_2;
            // 
            // FormPaciente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 464);
            Controls.Add(tabControl1);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnSiguiente);
            Name = "FormPaciente";
            Text = "Datos de Paciente";
            Load += FormPaciente_Load;
            tabControl1.ResumeLayout(false);
            tapControl1.ResumeLayout(false);
            tapControl1.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSiguiente;
        private Button btnCancelar;
        private Label label2;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tapControl1;
        private Label lblCedulaP;
        private Label lblNombreP;
        private Label lblGeneroP;
        private Label lblTelefonoP;
        private Label lblCorreoP;
        private Label lblSangreP;
        private TextBox txbNombreP;
        private Label lblArsP;
        private ComboBox cmbArsP;
        private ComboBox cmbSangreP;
        private ComboBox cmbGeneroP;
        private TextBox txbCorreoP;
        private TextBox txbTelefonoP;
        private TextBox txbCedulaP;
        private Label lblCoberturaArs;
        private TextBox txbCoberturaArs;
        private Label lblNacimientoP;
        private DateTimePicker dtpNacimientoP;
        private Label lblNumC;
        private Label label5;
        private Label lblFechaC;
        private Label lblHoraC;
        private Label lblCita;
        private DateTimePicker dtpHoraC;
        private DateTimePicker dtpFechaC;
        private TextBox txbMotivoC;
        private TextBox txbCedulaC;
        private Label lblEstadoC;
        private Label lblMotivoC;
        private ComboBox cmbEstadoC;
    }
}
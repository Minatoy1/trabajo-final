namespace trabajo_final
{
    partial class FormConsulta
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
            tabConsulta = new TabControl();
            tapControl1 = new TabPage();
            lblMmhgC = new Label();
            lblPresiconDivicionC = new Label();
            txbDiatolicaC = new TextBox();
            txbSistolicaC = new TextBox();
            txbPesoC = new TextBox();
            lblLibrasC = new Label();
            txbDiagnosticoC = new TextBox();
            txbSintomasC = new TextBox();
            txbNumCitaC = new TextBox();
            lblDiagnosticoC = new Label();
            lblSintomasC = new Label();
            lblPresionC = new Label();
            lblPesoC = new Label();
            lblNomPacienteC = new Label();
            lblCedulaC = new Label();
            lblCitaC = new Label();
            lblNumConsulta = new Label();
            lblConsultaNum = new Label();
            tabPage1 = new TabPage();
            lblNumC = new Label();
            lblCita = new Label();
            label2 = new Label();
            btnCancelar = new Button();
            btnSiguiente = new Button();
            tabConsulta.SuspendLayout();
            tapControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // tabConsulta
            // 
            tabConsulta.Controls.Add(tapControl1);
            tabConsulta.Controls.Add(tabPage1);
            tabConsulta.Location = new Point(10, 3);
            tabConsulta.Name = "tabConsulta";
            tabConsulta.SelectedIndex = 0;
            tabConsulta.Size = new Size(913, 399);
            tabConsulta.TabIndex = 8;
            tabConsulta.Selecting += tabConsulta_Selecting;
            // 
            // tapControl1
            // 
            tapControl1.Controls.Add(lblMmhgC);
            tapControl1.Controls.Add(lblPresiconDivicionC);
            tapControl1.Controls.Add(txbDiatolicaC);
            tapControl1.Controls.Add(txbSistolicaC);
            tapControl1.Controls.Add(txbPesoC);
            tapControl1.Controls.Add(lblLibrasC);
            tapControl1.Controls.Add(txbDiagnosticoC);
            tapControl1.Controls.Add(txbSintomasC);
            tapControl1.Controls.Add(txbNumCitaC);
            tapControl1.Controls.Add(lblDiagnosticoC);
            tapControl1.Controls.Add(lblSintomasC);
            tapControl1.Controls.Add(lblPresionC);
            tapControl1.Controls.Add(lblPesoC);
            tapControl1.Controls.Add(lblNomPacienteC);
            tapControl1.Controls.Add(lblCedulaC);
            tapControl1.Controls.Add(lblCitaC);
            tapControl1.Controls.Add(lblNumConsulta);
            tapControl1.Controls.Add(lblConsultaNum);
            tapControl1.Location = new Point(4, 29);
            tapControl1.Name = "tapControl1";
            tapControl1.Padding = new Padding(3);
            tapControl1.Size = new Size(905, 366);
            tapControl1.TabIndex = 1;
            tapControl1.Text = "Consulta";
            tapControl1.UseVisualStyleBackColor = true;
            // 
            // lblMmhgC
            // 
            lblMmhgC.AutoSize = true;
            lblMmhgC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblMmhgC.Location = new Point(832, 51);
            lblMmhgC.Name = "lblMmhgC";
            lblMmhgC.Size = new Size(57, 20);
            lblMmhgC.TabIndex = 22;
            lblMmhgC.Text = "mmHg";
            // 
            // lblPresiconDivicionC
            // 
            lblPresiconDivicionC.AutoSize = true;
            lblPresiconDivicionC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblPresiconDivicionC.Location = new Point(752, 51);
            lblPresiconDivicionC.Name = "lblPresiconDivicionC";
            lblPresiconDivicionC.Size = new Size(16, 20);
            lblPresiconDivicionC.TabIndex = 21;
            lblPresiconDivicionC.Text = "/";
            // 
            // txbDiatolicaC
            // 
            txbDiatolicaC.BorderStyle = BorderStyle.FixedSingle;
            txbDiatolicaC.Location = new Point(773, 48);
            txbDiatolicaC.Name = "txbDiatolicaC";
            txbDiatolicaC.Size = new Size(53, 27);
            txbDiatolicaC.TabIndex = 20;
            txbDiatolicaC.TextChanged += textBox3_TextChanged;
            // 
            // txbSistolicaC
            // 
            txbSistolicaC.BorderStyle = BorderStyle.FixedSingle;
            txbSistolicaC.Location = new Point(693, 48);
            txbSistolicaC.Name = "txbSistolicaC";
            txbSistolicaC.Size = new Size(53, 27);
            txbSistolicaC.TabIndex = 19;
            txbSistolicaC.TextChanged += textBox2_TextChanged;
            // 
            // txbPesoC
            // 
            txbPesoC.BorderStyle = BorderStyle.FixedSingle;
            txbPesoC.Location = new Point(427, 49);
            txbPesoC.Name = "txbPesoC";
            txbPesoC.Size = new Size(78, 27);
            txbPesoC.TabIndex = 18;
            // 
            // lblLibrasC
            // 
            lblLibrasC.AutoSize = true;
            lblLibrasC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblLibrasC.Location = new Point(511, 51);
            lblLibrasC.Name = "lblLibrasC";
            lblLibrasC.Size = new Size(33, 20);
            lblLibrasC.TabIndex = 17;
            lblLibrasC.Text = "Lbs";
            // 
            // txbDiagnosticoC
            // 
            txbDiagnosticoC.BorderStyle = BorderStyle.FixedSingle;
            txbDiagnosticoC.Location = new Point(6, 231);
            txbDiagnosticoC.Multiline = true;
            txbDiagnosticoC.Name = "txbDiagnosticoC";
            txbDiagnosticoC.Size = new Size(893, 129);
            txbDiagnosticoC.TabIndex = 16;
            // 
            // txbSintomasC
            // 
            txbSintomasC.BorderStyle = BorderStyle.FixedSingle;
            txbSintomasC.Location = new Point(6, 117);
            txbSintomasC.Multiline = true;
            txbSintomasC.Name = "txbSintomasC";
            txbSintomasC.Size = new Size(873, 88);
            txbSintomasC.TabIndex = 15;
            // 
            // txbNumCitaC
            // 
            txbNumCitaC.BorderStyle = BorderStyle.FixedSingle;
            txbNumCitaC.Location = new Point(105, 48);
            txbNumCitaC.Name = "txbNumCitaC";
            txbNumCitaC.Size = new Size(190, 27);
            txbNumCitaC.TabIndex = 14;
            // 
            // lblDiagnosticoC
            // 
            lblDiagnosticoC.AutoSize = true;
            lblDiagnosticoC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblDiagnosticoC.Location = new Point(6, 208);
            lblDiagnosticoC.Name = "lblDiagnosticoC";
            lblDiagnosticoC.Size = new Size(99, 20);
            lblDiagnosticoC.TabIndex = 13;
            lblDiagnosticoC.Text = "Diagnostico:";
            // 
            // lblSintomasC
            // 
            lblSintomasC.AutoSize = true;
            lblSintomasC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblSintomasC.Location = new Point(6, 94);
            lblSintomasC.Name = "lblSintomasC";
            lblSintomasC.Size = new Size(80, 20);
            lblSintomasC.TabIndex = 12;
            lblSintomasC.Text = "Sintomas:";
            // 
            // lblPresionC
            // 
            lblPresionC.AutoSize = true;
            lblPresionC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblPresionC.Location = new Point(567, 51);
            lblPresionC.Name = "lblPresionC";
            lblPresionC.Size = new Size(120, 20);
            lblPresionC.TabIndex = 11;
            lblPresionC.Text = "Presión arterial";
            // 
            // lblPesoC
            // 
            lblPesoC.AutoSize = true;
            lblPesoC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblPesoC.Location = new Point(319, 51);
            lblPesoC.Name = "lblPesoC";
            lblPesoC.Size = new Size(110, 20);
            lblPesoC.TabIndex = 10;
            lblPesoC.Text = "Peso corporal:";
            // 
            // lblNomPacienteC
            // 
            lblNomPacienteC.AutoSize = true;
            lblNomPacienteC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblNomPacienteC.Location = new Point(209, 13);
            lblNomPacienteC.Name = "lblNomPacienteC";
            lblNomPacienteC.Size = new Size(67, 20);
            lblNomPacienteC.TabIndex = 9;
            lblNomPacienteC.Text = "Nombre";
            // 
            // lblCedulaC
            // 
            lblCedulaC.AutoSize = true;
            lblCedulaC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblCedulaC.Location = new Point(757, 13);
            lblCedulaC.Name = "lblCedulaC";
            lblCedulaC.Size = new Size(59, 20);
            lblCedulaC.TabIndex = 8;
            lblCedulaC.Text = "Cedula";
            // 
            // lblCitaC
            // 
            lblCitaC.AutoSize = true;
            lblCitaC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblCitaC.Location = new Point(6, 51);
            lblCitaC.Name = "lblCitaC";
            lblCitaC.Size = new Size(102, 20);
            lblCitaC.TabIndex = 7;
            lblCitaC.Text = "Cita número:";
            // 
            // lblNumConsulta
            // 
            lblNumConsulta.AutoSize = true;
            lblNumConsulta.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblNumConsulta.ForeColor = Color.LightCoral;
            lblNumConsulta.Location = new Point(80, 13);
            lblNumConsulta.Name = "lblNumConsulta";
            lblNumConsulta.Size = new Size(18, 20);
            lblNumConsulta.TabIndex = 6;
            lblNumConsulta.Text = "1";
            // 
            // lblConsultaNum
            // 
            lblConsultaNum.AutoSize = true;
            lblConsultaNum.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblConsultaNum.ForeColor = SystemColors.ActiveBorder;
            lblConsultaNum.Location = new Point(6, 13);
            lblConsultaNum.Name = "lblConsultaNum";
            lblConsultaNum.Size = new Size(77, 20);
            lblConsultaNum.TabIndex = 5;
            lblConsultaNum.Text = "Consulta:";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(lblNumC);
            tabPage1.Controls.Add(lblCita);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(905, 366);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Certificado Medico";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // lblNumC
            // 
            lblNumC.AutoSize = true;
            lblNumC.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblNumC.ForeColor = Color.LightCoral;
            lblNumC.Location = new Point(47, 16);
            lblNumC.Name = "lblNumC";
            lblNumC.Size = new Size(18, 20);
            lblNumC.TabIndex = 4;
            lblNumC.Text = "1";
            // 
            // lblCita
            // 
            lblCita.AutoSize = true;
            lblCita.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic);
            lblCita.ForeColor = SystemColors.ActiveBorder;
            lblCita.Location = new Point(9, 16);
            lblCita.Name = "lblCita";
            lblCita.Size = new Size(43, 20);
            lblCita.TabIndex = 0;
            lblCita.Text = "Cita:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(307, 34);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 7;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(821, 407);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(109, 41);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSiguiente
            // 
            btnSiguiente.Location = new Point(682, 407);
            btnSiguiente.Name = "btnSiguiente";
            btnSiguiente.Size = new Size(109, 41);
            btnSiguiente.TabIndex = 5;
            btnSiguiente.Text = "Siguiente";
            btnSiguiente.UseVisualStyleBackColor = true;
            // 
            // FormConsulta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(943, 464);
            Controls.Add(tabConsulta);
            Controls.Add(label2);
            Controls.Add(btnCancelar);
            Controls.Add(btnSiguiente);
            Name = "FormConsulta";
            Text = "Consulta";
            tabConsulta.ResumeLayout(false);
            tapControl1.ResumeLayout(false);
            tapControl1.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabConsulta;
        private TabPage tapControl1;
        private TabPage tabPage1;
        private Label lblNumC;
        private Label lblCita;
        private Label label2;
        private Button btnCancelar;
        private Button btnSiguiente;
        private Label lblNumConsulta;
        private Label lblConsultaNum;
        private Label lblNomPacienteC;
        private Label lblCedulaC;
        private Label lblCitaC;
        private Label lblDiagnosticoC;
        private Label lblSintomasC;
        private Label lblPresionC;
        private Label lblPesoC;
        private TextBox txbPesoC;
        private Label lblLibrasC;
        private TextBox txbDiagnosticoC;
        private TextBox txbSintomasC;
        private TextBox txbNumCitaC;
        private Label lblPresiconDivicionC;
        private TextBox txbDiatolicaC;
        private TextBox txbSistolicaC;
        private Label lblMmhgC;
    }
}
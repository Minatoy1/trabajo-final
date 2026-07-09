namespace trabajo_final
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
            tcPrincipal = new TabControl();
            tbcPrincipal = new TabPage();
            dgvConsultaPrincipal = new DataGridView();
            btnAggP = new Button();
            btnConsultar = new Button();
            btnAggServicio = new Button();
            btnAggMed = new Button();
            tbnAggReceta = new Button();
            btnEditarPrincipal = new Button();
            tcPrincipal.SuspendLayout();
            tbcPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaPrincipal).BeginInit();
            SuspendLayout();
            // 
            // tcPrincipal
            // 
            tcPrincipal.Controls.Add(tbcPrincipal);
            tcPrincipal.Location = new Point(30, 12);
            tcPrincipal.Name = "tcPrincipal";
            tcPrincipal.SelectedIndex = 0;
            tcPrincipal.Size = new Size(896, 339);
            tcPrincipal.TabIndex = 0;
            // 
            // tbcPrincipal
            // 
            tbcPrincipal.Controls.Add(dgvConsultaPrincipal);
            tbcPrincipal.Location = new Point(4, 29);
            tbcPrincipal.Name = "tbcPrincipal";
            tbcPrincipal.Padding = new Padding(3);
            tbcPrincipal.Size = new Size(888, 306);
            tbcPrincipal.TabIndex = 0;
            tbcPrincipal.Text = "Citas Pendientes";
            tbcPrincipal.UseVisualStyleBackColor = true;
            // 
            // dgvConsultaPrincipal
            // 
            dgvConsultaPrincipal.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaPrincipal.Location = new Point(0, 0);
            dgvConsultaPrincipal.Name = "dgvConsultaPrincipal";
            dgvConsultaPrincipal.RowHeadersWidth = 51;
            dgvConsultaPrincipal.Size = new Size(888, 306);
            dgvConsultaPrincipal.TabIndex = 0;
            dgvConsultaPrincipal.CellDoubleClick += dgvConsultaPrincipal_CellDoubleClick;
            dgvConsultaPrincipal.DoubleClick += dgvConsultaPrincipal_DoubleClick;
            // 
            // btnAggP
            // 
            btnAggP.Location = new Point(30, 357);
            btnAggP.Name = "btnAggP";
            btnAggP.Size = new Size(149, 32);
            btnAggP.TabIndex = 1;
            btnAggP.Text = "Agregar Paciente";
            btnAggP.UseVisualStyleBackColor = true;
            btnAggP.Click += btnAggP_Click;
            // 
            // btnConsultar
            // 
            btnConsultar.Location = new Point(823, 357);
            btnConsultar.Name = "btnConsultar";
            btnConsultar.Size = new Size(103, 32);
            btnConsultar.TabIndex = 2;
            btnConsultar.Text = "Consultar";
            btnConsultar.UseVisualStyleBackColor = true;
            btnConsultar.Click += button2_Click;
            // 
            // btnAggServicio
            // 
            btnAggServicio.Location = new Point(185, 357);
            btnAggServicio.Name = "btnAggServicio";
            btnAggServicio.Size = new Size(141, 32);
            btnAggServicio.TabIndex = 3;
            btnAggServicio.Text = "Agregar Servicio";
            btnAggServicio.UseVisualStyleBackColor = true;
            // 
            // btnAggMed
            // 
            btnAggMed.Location = new Point(332, 357);
            btnAggMed.Name = "btnAggMed";
            btnAggMed.Size = new Size(175, 32);
            btnAggMed.TabIndex = 4;
            btnAggMed.Text = "Agregar Medicamento";
            btnAggMed.UseVisualStyleBackColor = true;
            // 
            // tbnAggReceta
            // 
            tbnAggReceta.Location = new Point(513, 357);
            tbnAggReceta.Name = "tbnAggReceta";
            tbnAggReceta.Size = new Size(129, 32);
            tbnAggReceta.TabIndex = 5;
            tbnAggReceta.Text = "Agregar Receta";
            tbnAggReceta.UseVisualStyleBackColor = true;
            tbnAggReceta.Visible = false;
            // 
            // btnEditarPrincipal
            // 
            btnEditarPrincipal.Location = new Point(714, 357);
            btnEditarPrincipal.Name = "btnEditarPrincipal";
            btnEditarPrincipal.Size = new Size(103, 32);
            btnEditarPrincipal.TabIndex = 6;
            btnEditarPrincipal.Text = "Editar";
            btnEditarPrincipal.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(957, 454);
            Controls.Add(btnEditarPrincipal);
            Controls.Add(tbnAggReceta);
            Controls.Add(btnAggMed);
            Controls.Add(btnAggServicio);
            Controls.Add(btnConsultar);
            Controls.Add(btnAggP);
            Controls.Add(tcPrincipal);
            Name = "Form1";
            Text = "Centro Medico";
            Load += Form1_Load;
            tcPrincipal.ResumeLayout(false);
            tbcPrincipal.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvConsultaPrincipal).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tcPrincipal;
        private TabPage tbcPrincipal;
        private Button btnAggP;
        private Button btnConsultar;
        private Button btnAggServicio;
        private Button btnAggMed;
        private Button tbnAggReceta;
        private DataGridView dgvConsultaPrincipal;
        private Button btnEditarPrincipal;
    }
}

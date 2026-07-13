using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace trabajo_final
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            dgvServicios.Columns.Add("Codigo", "Codigo");
            dgvServicios.Columns.Add("Nombre", "Nombre");
            dgvServicios.Columns.Add("Costo", "Costo");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == "" || txtNombre.Text == "" || txtCosto.Text == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            dgvServicios.Rows.Add(
                txtCodigo.Text,
                txtNombre.Text,
                txtCosto.Text);

            MessageBox.Show("Servicio agregado correctamente.");

            txtCodigo.Clear();
            txtNombre.Clear();
            txtCosto.Clear();

            txtCodigo.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtCosto.Clear();

            txtCodigo.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

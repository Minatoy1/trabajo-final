using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace trabajo_final
{
    
    public partial class FormPaciente : Form
    {

  
        public FormPaciente()
        {
            InitializeComponent();
        }
        public class ConexionBD
        {
            private string cadenaConexion = "Server=MONEGRO; Database=Consultorio_Med; Integrated Security=True;";

            public SqlConnection ObtenerConexion()
            {
                return new SqlConnection(cadenaConexion);
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbGeneroP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbArsP_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblTelefonoP_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FormPaciente_Load(object sender, EventArgs e)
        {

        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txbCedulaP.Text) || string.IsNullOrWhiteSpace(txbNombreP.Text) || string.IsNullOrWhiteSpace(txbTelefonoP.Text))
            {
                MessageBox.Show("Por favor, complete los campos obligatorios (Cédula, Nombre, Genero y telefono).",
                                "Campos Vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; 
            }

            ConexionBD conexion = new ConexionBD();

            string query = @"INSERT INTO Paciente (Paciente, Cedula, Genero, Nacimiento, Telefono,  TipoSangre, CorreoElectronico, ID_ARS) 
                     VALUES (@nombre, @cedula, @genero, @fecha, @telefono, @sangre, @correo, @idArs)";

            using (SqlConnection con = conexion.ObtenerConexion())
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@cedula", txbCedulaP.Text.Trim());
                    cmd.Parameters.AddWithValue("@nombre", txbNombreP.Text.Trim());
                    cmd.Parameters.AddWithValue("@fecha", dtpNacimientoP.Value.Date);

                    string genero = cmbGeneroP     .SelectedItem != null ? cmbGeneroP.SelectedItem.ToString() : "M";
                    cmd.Parameters.AddWithValue("@genero", genero);

                    cmd.Parameters.AddWithValue("@telefono", txbTelefonoP.Text.Trim());
                    cmd.Parameters.AddWithValue("@correo", txbCorreoP.Text.Trim());

                    string ArsFinal;

                    if (cmbSangreP.SelectedItem == null || cmbSangreP.SelectedIndex == -1)
                        cmd.Parameters.AddWithValue("@sangre", DBNull.Value);
                    else
                        cmd.Parameters.AddWithValue("@sangre", DBNull.Value);


                    if (cmbArsP.SelectedValue == null || cmbArsP.SelectedIndex == -1)
                    {
                        cmbArsP.SelectedIndex = 0;
                        ArsFinal = cmbArsP.SelectedItem.ToString();
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@idArs", cmbArsP.SelectedValue);
                    }

                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("¡Paciente registrado exitosamente en la base de datos!",
                                        "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        this.Close();
                    }
                    catch (Exception ex)
                    {
                            MessageBox.Show("Error al guardar el paciente: " + ex.Message,
                                        "Error de Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}

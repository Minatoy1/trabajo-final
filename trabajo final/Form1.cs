using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
namespace trabajo_final
{
    public partial class Form1 : Form
    {
        private string Cadena = "Server=Monegro; Database=Consultorio_Med; Integrated Security=True; Encrypt=True; TrustServerCertificate=True;";
        private DataTable dtCita;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarCita();
        }

        private void CargarCita()
        {
            string consulta = "SELECT IdCita, CedulaPaciente AS Cedula, Fecha, Hora, Motivo, Estado FROM Cita WHERE Estado = 'Pendiente'";
            using (SqlConnection conexion = new SqlConnection(Cadena))
            {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    dtCita = new DataTable();

                    adaptador.Fill(dtCita);
                    dgvConsultaPrincipal.DataSource = dtCita;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar las Citas: " + ex.Message);
                }
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dgvConsultaPrincipal_DoubleClick(object sender, EventArgs e)
        {


        }

        private void dgvConsultaPrincipal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (dgvConsultaPrincipal.Columns[e.ColumnIndex].Name == "Motivo")
                {
                    string motivoCompleto = dgvConsultaPrincipal.Rows[e.RowIndex].Cells["Motivo"].Value.ToString();
                    string cedula = dgvConsultaPrincipal.Rows[e.RowIndex].Cells["id_cedula"].Value.ToString();

                    string nombrePaciente = "No encontrado";

                    string consultaBuscarNombre = "SELECT nombre_paciente FROM Pacientes WHERE id_cedula = @cedula";

                    using (SqlConnection conexion = new SqlConnection(Cadena))
                    {
                        using (SqlCommand comando = new SqlCommand(consultaBuscarNombre, conexion))
                        {
                            comando.Parameters.AddWithValue("@cedula", cedula);

                            try
                            {
                                conexion.Open();

                                object resultado = comando.ExecuteScalar();

                                if (resultado != null)
                                {
                                    nombrePaciente = resultado.ToString();
                                }
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show("Error al buscar el nombre del paciente: " + ex.Message);
                            }
                        }
                    }

                    MessageBox.Show(motivoCompleto, "Motivo Completo - Paciente: " + nombrePaciente, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnAggP_Click(object sender, EventArgs e)
        {
            FormPaciente ventanaPaciente = new FormPaciente();

            ventanaPaciente.ShowDialog();
        }
    }
}


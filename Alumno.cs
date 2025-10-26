using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscolarBD
{
    public partial class Alumno : Form
    {
        
        ConexionesBD conexionesBD = new ConexionesBD();
        public Alumno()
        {
            InitializeComponent();

        }

        private void Alumno_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string seleccion = "";
            if (cbEstatus.SelectedItem == null)
            {
                MessageBox.Show("Eliga una opcion");
                return;
            }
            else
            {
                seleccion = cbEstatus.SelectedItem.ToString();
            }
            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                {
                    miConexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_CrearAlumnos", miConexion);


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", tbNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellidos", tbApellidos.Text);
                    cmd.Parameters.AddWithValue("@Estatus", cbEstatus.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@FechaHoraCreacion", fechaFormateada);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro creado correctamente.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
            tbNombre.Text = string.Empty;
            tbApellidos.Text = string.Empty;
            cbEstatus.SelectedIndex = -1;
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAlumnos);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

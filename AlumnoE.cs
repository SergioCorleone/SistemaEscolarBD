using Microsoft.Data.SqlClient;
using System;
using System.CodeDom;
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
    public partial class AlumnoE : Form
    {
        EditarAlumnos editarAlumnos;
        ConexionesBD conexionesBD = new ConexionesBD();
        public AlumnoE(EditarAlumnos editarAlumnos)
        {
            InitializeComponent();
            this.editarAlumnos = editarAlumnos;
            tbNombre.Text = editarAlumnos.Nombre;
            tbApellidos.Text = editarAlumnos.Apellidos;
            cbEstatus.SelectedItem = editarAlumnos.Estatus;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                {
                    miConexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_ActualizarAlumnos", miConexion);


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdAlumnos", editarAlumnos.Id);
                    cmd.Parameters.AddWithValue("@Nombre", tbNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellidos", tbApellidos.Text);
                    cmd.Parameters.AddWithValue("@Estatus", cbEstatus.SelectedItem.ToString());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro editado correctamente.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAlumnos);
        }
    }
}

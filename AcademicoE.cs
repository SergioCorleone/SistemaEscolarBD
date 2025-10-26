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
    public partial class AcademicoE : Form
    {
        EditarGeneral editarAcademico;
        ConexionesBD conexionesBD = new ConexionesBD();

        public AcademicoE(EditarGeneral EditarAcademico)
        {
            InitializeComponent();
            this.editarAcademico = EditarAcademico;
            tbNombreEditar.Text = EditarAcademico.nombre;
            tbApellidosEditar.Text = EditarAcademico.apellidos;
            GradoEditar.SelectedItem = EditarAcademico.grado;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                {
                    miConexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_ActualizarAcademicos", miConexion);
                    

                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Parameters.AddWithValue("@IdAcademico", editarAcademico.ID);
                        cmd.Parameters.AddWithValue("@Nombre", tbNombreEditar.Text);
                        cmd.Parameters.AddWithValue("@Apellidos", tbApellidosEditar.Text);
                        cmd.Parameters.AddWithValue("@Grado", GradoEditar.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@FechaHoraCreacion", fechaFormateada);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Registro actualizado correctamente.");
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAcademico);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

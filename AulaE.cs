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
    public partial class AulaE : Form
    {
        EditarAula editarAula;
        ConexionesBD conexionesBD = new ConexionesBD();
        public AulaE(EditarAula EditarAula)
        {
            InitializeComponent();
            this.editarAula = EditarAula;

            cbEdificio.SelectedItem = EditarAula.Edificio;
            cbAula.SelectedItem = EditarAula.Aula;
            cbPiso.SelectedItem = EditarAula.Piso;
            tbCapacidad.Text = EditarAula.CapacidadMaxima;
            
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
                    SqlCommand cmd = new SqlCommand("sp_ActualizarAulas", miConexion);


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdAula", editarAula.Id);
                    cmd.Parameters.AddWithValue("@Edificio", cbEdificio.Text);
                    cmd.Parameters.AddWithValue("@Aula", cbAula.Text);
                    cmd.Parameters.AddWithValue("@Piso", cbPiso.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CapacidadMaxima", tbCapacidad.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro actualizado correctamente.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAula);
        }
    }
}

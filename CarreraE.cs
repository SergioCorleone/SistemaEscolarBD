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
    public partial class CarreraE : Form
    {
        EditarCarrera editarCarrera;
        ConexionesBD conexionesBD = new ConexionesBD();
        public CarreraE(EditarCarrera editarCarre)
        {
            InitializeComponent();
            this.editarCarrera = editarCarre;

            tbNombreCarrera.Text = editarCarre.NombreCarrera;
            tbSiglasCarrera.Text = editarCarre.SiglasCarrera;

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
                    SqlCommand cmd = new SqlCommand("sp_ActualizarCarreras", miConexion);


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCarrera", editarCarrera.Id);
                    cmd.Parameters.AddWithValue("@NombreCarrera", tbNombreCarrera.Text);
                    cmd.Parameters.AddWithValue("@SiglasCarrera", tbSiglasCarrera.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro actualizado correctamente.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerCarrera);
        }
    }
}

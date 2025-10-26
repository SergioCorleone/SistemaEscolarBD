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
    public partial class MateriaEcs : Form
    {
        EditarMateria editarMateria;
        ConexionesBD ConexionesBD = new ConexionesBD();
        public MateriaEcs(EditarMateria EditarMateria)
        {
            InitializeComponent();
            this.editarMateria = EditarMateria;
            tbNombreMateria.Text = EditarMateria.NombreMateria;
            tbCreditos.Text = EditarMateria.Creditos;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MateriaEcs_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection miConexion = new SqlConnection(ConexionesBD.connexion))
                {
                    miConexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_ActualizarMaterias", miConexion);


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdMateria", editarMateria.Id);
                    cmd.Parameters.AddWithValue("@NombreMateria", tbNombreMateria.Text);
                    cmd.Parameters.AddWithValue("@Creditos", tbCreditos.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro actualizado correctamente.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
            ConexionesBD.ObtenerBD(Registro.dataGridView1, ConexionesBD.ConsultaObtenerMateria) ;
        }
    }
}

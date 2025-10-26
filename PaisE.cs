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
    public partial class PaisE : Form
    {
        EditarPais editarPais;
        ConexionesBD conexionesBD = new ConexionesBD();
        public PaisE(EditarPais EditarPais)
        {
            InitializeComponent();
            this.editarPais = EditarPais;

            tbNombrePais.Text = EditarPais.NombrePais;
            tbSiglasPais.Text = EditarPais.SiglaPais;
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
                    SqlCommand cmd = new SqlCommand("sp_ActualizarPaises", miConexion);


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdPais", editarPais.Id);
                    cmd.Parameters.AddWithValue("@NombrePais", tbNombrePais.Text);
                    cmd.Parameters.AddWithValue("@SiglaPais", tbSiglasPais.Text);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro actualizado correctamente.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerPais);
        }
    }
}

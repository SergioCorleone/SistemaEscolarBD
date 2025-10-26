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
    public partial class CiudadEcs : Form
    {
        EditarCiudad editarCiudad;
        ConexionesBD conexionesBD = new ConexionesBD();
        public CiudadEcs(EditarCiudad EditarCiudad)
        {
            InitializeComponent();
            this.editarCiudad = EditarCiudad;

            tbCuidad.Text = EditarCiudad.NombreCiudad;
            tbSiglasCiudad.Text = EditarCiudad.SiglasCiudad;
            //Formatear comboBox antes de llenarlo 
            SqlConnection con = new SqlConnection(conexionesBD.connexion);

            try
            {

                con.Open();
                DataTable cbEstado = new DataTable();
                string idEstado = "SELECT [IdEstado],[NombreEstado] FROM [GruposBD].[dbo].[Estado]";
                SqlDataAdapter adapter = new SqlDataAdapter(idEstado, con);
                adapter.Fill(cbEstado);
                cbIdEstado.DataSource = cbEstado;
                cbIdEstado.DisplayMember = "NombreEstado";
                cbIdEstado.ValueMember = "IdEstado";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);

            }
            finally
            {
                if (con != null)
                {
                    con.Close();
                }
            }
            cbIdEstado.SelectedValue = EditarCiudad.IdEstado;
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
                    SqlCommand cmd = new SqlCommand("sp_ActualizarCiudades", miConexion);


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@IdCiudad", editarCiudad.Id);
                    cmd.Parameters.AddWithValue("@NombreCiudad", tbCuidad.Text);
                    cmd.Parameters.AddWithValue("@SiglasCiudad", tbSiglasCiudad.Text);
                    cmd.Parameters.AddWithValue("@IdEstado", cbIdEstado.SelectedValue);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro actualizado correctamente.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObteneCiudad);
        }
   
    }
}

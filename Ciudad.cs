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
    public partial class Ciudad : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        public Ciudad()
        {
            InitializeComponent();
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
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string IdEstado = "";


            if (cbIdEstado.SelectedItem == null)
            {
                MessageBox.Show("Agrege un Estado");
            }
            else
            {
                IdEstado = cbIdEstado.SelectedValue.ToString();
            }
            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            try
            {
                using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                {
                    miConexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_CrearCiudades", miConexion);


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreCiudad", tbCuidad.Text);
                    cmd.Parameters.AddWithValue("@SiglasCiudad", tbSiglasCiudad.Text);
                    cmd.Parameters.AddWithValue("@IdEstado", cbIdEstado.SelectedValue);
                    cmd.Parameters.AddWithValue("@FechaHoraCreacion", fechaFormateada);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro creado correctamente.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }

            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObteneCiudad);

            tbCuidad.Text = string.Empty;
            tbSiglasCiudad.Text = string.Empty;
            cbIdEstado.SelectedIndex = -1;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

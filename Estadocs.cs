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
    public partial class Estadocs : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        public Estadocs()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(conexionesBD.connexion);
            try
            {

                con.Open();
                DataTable cbPais = new DataTable();
                string idPais = "SELECT [IdPais],[NombrePais] FROM [GruposBD].[dbo].[Pais]";
                SqlDataAdapter adapter = new SqlDataAdapter(idPais, con);
                adapter.Fill(cbPais);
                cbIdPais.DataSource = cbPais;
                cbIdPais.DisplayMember = "NombrePais";
                cbIdPais.ValueMember = "IdPais";
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
                string idPais = "";

            if(cbIdPais.SelectedItem == null)
            {
                MessageBox.Show("Agrege un pais");
            }   
            else
            {
                idPais = cbIdPais.SelectedValue.ToString();
            }
            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                {
                    miConexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_CrearEstados", miConexion);


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@NombreEstado", tbEstado.Text);
                    cmd.Parameters.AddWithValue("@SiglaEstado", tbSiglasEstado.Text);
                    cmd.Parameters.AddWithValue("@IdPais", cbIdPais.SelectedValue);
                    cmd.Parameters.AddWithValue("@FechaHoraCreacion", fechaFormateada);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro creado correctamente.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerEstado);
            tbEstado.Text = string.Empty;
            tbSiglasEstado.Text = string.Empty;
            cbIdPais.SelectedIndex = -1;
        }
    }
}

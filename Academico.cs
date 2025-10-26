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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaEscolarBD
{
    public partial class Academico : Form
    {
       
        ConexionesBD conexionesBD = new ConexionesBD();
        public Academico()
        {
            InitializeComponent();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string seleccion = "";
            if (Grado.SelectedItem == null)
            {
                MessageBox.Show("Eliga una opcion:");
                return;
            }
            else
            {
                seleccion = Grado.SelectedItem.ToString();
            }
            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                {
                    miConexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_CrearAcademicos", miConexion);


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Nombre", tbNombre.Text);
                    cmd.Parameters.AddWithValue("@Apellidos", tbApellidos.Text);
                    cmd.Parameters.AddWithValue("@Grado", Grado.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@FechaHoraCreacion", fechaFormateada);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro creado correctamente.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el registro: " + ex.Message);
            }
            tbApellidos.Text = string.Empty;
            tbNombre.Text = string.Empty;
            Grado.SelectedIndex = -1;


            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAcademico);

        }
        

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

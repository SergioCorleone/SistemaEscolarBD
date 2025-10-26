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
    public partial class Aula : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        public Aula()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Edificio="";
            if (cbEdificio.SelectedItem == null)
            {
                MessageBox.Show("Elige una opcion");
                return;
            }
            else
            {
                Edificio = cbEdificio.SelectedItem.ToString();
            }
            string Aula = "";
            if (cbAula.SelectedItem == null)
            {
                MessageBox.Show("Elige una opcion");
                return;
            }
            else
            {
                Aula = cbAula.SelectedItem.ToString();
            }
            string Piso = "";
            if (cbPiso.SelectedItem == null)
            {
                MessageBox.Show("Elige una opcion");
                return;
            }
            else
            {
                Piso = cbPiso.SelectedItem.ToString();
            }

            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");

            try
            {
                using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                {
                    miConexion.Open();
                    SqlCommand cmd = new SqlCommand("sp_CrearAulas", miConexion);


                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Edificio", cbEdificio.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Aula", cbAula.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@Piso", cbAula.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@CapacidadMaxima" , tbCapacidad.Text);
                    cmd.Parameters.AddWithValue("@FechaHoraCreacion", fechaFormateada);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro creado correctamente.");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al crear el registro: " + ex.Message);
            }
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAula);
            cbEdificio.SelectedIndex = -1;
            cbAula.SelectedIndex = -1;
            cbPiso.SelectedIndex = -1;
            tbCapacidad.Text = string.Empty;
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

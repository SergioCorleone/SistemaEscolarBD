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
            string AgregarCiudad = "INSERT INTO [dbo].[Ciudad]" +
           "([NombreCiudad]" +
           ",[SiglasCiudad]" +
           ",[FechaHoraCreacion]" +
           ",[IdEstado])" +
     "VALUES" +
           $"('{tbCuidad.Text}','{tbSiglasCiudad.Text}','{fechaFormateada}','{IdEstado}')";
            conexionesBD.AgregarBD(AgregarCiudad);

            conexionesBD.ObtenerBD(Registro.dataGridView1,conexionesBD.ConsultaObteneCiudad);

            tbCuidad.Text = string.Empty;
            tbSiglasCiudad.Text = string.Empty;
            cbIdEstado.SelectedIndex = -1;
        }
    }
}

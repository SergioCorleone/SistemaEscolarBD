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

            string AgregaEstado = "INSERT INTO [dbo].[Estado]" +
           "([NombreEstado]" +
           ",[SiglaEstado]" +
           ",[FechaHoraCreacion]" +
           ",[IdPais])" +
             "VALUES" +
           $"('{tbEstado.Text}','{tbSiglasEstado.Text}','{fechaFormateada}','{idPais}')";

            conexionesBD.AgregarBD(AgregaEstado);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerEstado);
            tbEstado.Text = string.Empty;
            tbSiglasEstado.Text = string.Empty;
            cbIdPais.SelectedIndex = -1;
        }
    }
}

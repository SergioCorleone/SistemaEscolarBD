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
    public partial class EstadosE : Form
    {
        
        EditarEstado editarEstado; 
        ConexionesBD conexionesBD = new ConexionesBD();
        public EstadosE(EditarEstado EditarEstado)
        {
            InitializeComponent();
            this.editarEstado = EditarEstado;

            tbEstado.Text = EditarEstado.NombreEstado;
            tbSiglasEstado.Text = EditarEstado.SiglasEstado;
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
            cbIdPais.SelectedValue = EditarEstado.IdPais;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string EditarEstado = $"UPDATE [dbo].[Estado] SET [NombreEstado] = '{tbEstado.Text}',[SiglaEstado] ='{tbSiglasEstado.Text}',[IdPais] = '{cbIdPais.SelectedValue}' WHERE IdEstado = '{editarEstado.Id}'";

            conexionesBD.EditarBD(EditarEstado);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerEstado);
        }
    }
}

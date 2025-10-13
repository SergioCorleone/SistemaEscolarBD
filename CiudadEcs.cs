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
            string EditarCiudad = $"UPDATE [dbo].[Ciudad] SET [NombreCiudad] = '{tbCuidad.Text}',[SiglasCiudad] = '{tbSiglasCiudad.Text}',[IdEstado] = '{cbIdEstado.SelectedValue}' WHERE IdCiudad = '{editarCiudad.Id}'";

            conexionesBD.EditarBD(EditarCiudad);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObteneCiudad);
        }
   
    }
}

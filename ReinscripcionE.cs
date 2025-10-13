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
    public partial class ReinscripcionE : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        EditarReinscripcion editarReinscripcion;
        public ReinscripcionE(EditarReinscripcion EditarReinscripcion)
        {
            InitializeComponent();
            this.editarReinscripcion = EditarReinscripcion;
            tbCalificacion.Text = EditarReinscripcion.Calificacion.ToString();
            SqlConnection sqlConnection = new SqlConnection(conexionesBD.connexion);

            try
            {
                sqlConnection.Open();
                DataTable table = new DataTable();
                DataTable tabla1 = new DataTable();
                string IdAlumno = "SELECT[IdAlumnos],[Apellidos] FROM[dbo].[Alumnos]";
                string IdGrupo = "SELECT [Id_Grupo] FROM [GruposBD].[dbo].[Grupo]";
                SqlDataAdapter adapter2 = new SqlDataAdapter(IdAlumno, sqlConnection);
                SqlDataAdapter adapter = new SqlDataAdapter(IdGrupo, sqlConnection);
                adapter.Fill(table);
                adapter2.Fill(tabla1);
                cbAlumno.DataSource = tabla1;
                cbGrupo.DataSource = table;
                cbAlumno.DisplayMember = "Apellidos";
                cbAlumno.ValueMember = "IdAlumnos";
                cbGrupo.DisplayMember = "Id_Grupo";
                cbGrupo.ValueMember = "Id_Grupo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);

            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }

            }
            cbGrupo.SelectedValue = EditarReinscripcion.idGrupo;
            cbAlumno.SelectedValue = EditarReinscripcion.idAlumno;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string EditarReinscripcion = $"UPDATE [dbo].[Reincripcion] SET [Id_Grupo] = '{cbGrupo.SelectedValue}',[Id_Alumno] = '{cbAlumno.SelectedValue}',[Calificacion] = '{tbCalificacion.Text}' WHERE IdReinscripcion = '{editarReinscripcion.id}'";

            conexionesBD.EditarBD(EditarReinscripcion);
            conexionesBD.ObtenerBD(Registro.dataGridView1,conexionesBD.ConsultaReinscripcion);
        }
    }
}

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
    public partial class GruposE : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        EditarGrupo editarGrupo;
        public GruposE(EditarGrupo EditarGrupo)
        {
            InitializeComponent();
            tbHorario.Text = EditarGrupo.Horario.ToString();
            SqlConnection sqlConnection = new SqlConnection(conexionesBD.connexion);

            try
            {
                sqlConnection.Open();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataTable dt4 = new DataTable();

                string IdAlumno = "SELECT [IdAlumnos],[Apellidos] FROM [dbo].[Alumnos]";
                string IdMaestro = "SELECT [IdAcademico],[Apellidos] FROM [dbo].[Academico]";
                string IdAula = "SELECT [IdAula],[Aula] FROM [dbo].[Aula]";
                string IdCarrera = "SELECT [IdCarrera],[NombreCarrera] FROM [dbo].[Carrera]";

                SqlDataAdapter adapterAlumno = new SqlDataAdapter(IdAlumno, sqlConnection);
                SqlDataAdapter adapterMaestro = new SqlDataAdapter(IdMaestro, sqlConnection);
                SqlDataAdapter adapterAula = new SqlDataAdapter(IdAula, sqlConnection);
                SqlDataAdapter adapterCarrera = new SqlDataAdapter(IdCarrera, sqlConnection);

                adapterAlumno.Fill(dt1);
                adapterMaestro.Fill(dt2);
                adapterAula.Fill(dt3);
                adapterCarrera.Fill(dt4);

                cbAlumno.DataSource = dt1;
                cbAlumno.DisplayMember = "Apellidos";
                cbAlumno.ValueMember = "IdAlumnos";

                cbMaestro.DataSource = dt2;
                cbMaestro.DisplayMember = "Apellidos";
                cbMaestro.ValueMember = "IdAcademico";

                cbAula.DataSource = dt3;
                cbAula.DisplayMember = "Aula";
                cbAula.ValueMember = "IdAula";

                cbCarrera.DataSource = dt4;
                cbCarrera.DisplayMember = "NombreCarrera";
                cbCarrera.ValueMember = "IdCarrera";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex);

            }
            finally
            {
                if (sqlConnection != null)
                {
                    sqlConnection.Close();
                }
            }
            cbAlumno.SelectedValue = EditarGrupo.Alumno;
            cbMaestro.SelectedValue = EditarGrupo.Maestro;
            cbAula.SelectedValue = EditarGrupo.Aula;
            cbCarrera.SelectedValue = EditarGrupo.Carrera;


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string EditarGrupo = $"UPDATE [dbo].[Grupo] SET [IdAlumno] = '{cbAlumno.SelectedValue}',[IdMaestro] = '{cbMaestro.SelectedValue}',[IdAula] = '{cbAula.SelectedValue}',[Horario] = '{tbHorario.Text}',[IdCarrera] = '{cbCarrera.SelectedValue}' WHERE Id_Grupo = '{editarGrupo.Id}'";
            conexionesBD.EditarBD(EditarGrupo);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaGrupo);
        }
    }
}

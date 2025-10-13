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
    public partial class Grupo : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        public Grupo()
        {
            InitializeComponent();
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
            cbAlumno.SelectedIndex = -1;
            cbMaestro.SelectedIndex = -1;
            cbAula.SelectedIndex = -1;
            cbCarrera.SelectedIndex = -1;

        }

        private void Grupo_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string IdAlumno = "";
            string IdMaestro = "";
            string IdAula = "";
            string IdCarrera = "";
            if (cbAlumno.SelectedItem == null)
            {
                MessageBox.Show("Seleccione Alumno");
                return;
            }
            else 
            {
                IdAlumno = cbAlumno.SelectedValue.ToString();
            }
            if (cbMaestro.SelectedItem == null)
            {
                MessageBox.Show("Seleccione Maestro");
                return;
            }
            else
            {
                IdMaestro = cbMaestro.SelectedValue.ToString();
            }
            if(cbAula.SelectedItem == null)
            {
                MessageBox.Show("Seleccione Aula");
                return;
            }
            else
            {
                IdAula = cbAula.SelectedValue.ToString();
            }
            if (cbCarrera.SelectedItem == null) 
            {
                MessageBox.Show("Seleccione Carrera");
                return;
            }
            else
            {
                IdCarrera = cbCarrera.SelectedValue.ToString();
            }
            string Agregargrupo = $"INSERT INTO[dbo].[Grupo]([IdAlumno], [IdMaestro], [IdAula], [Horario], [IdCarrera]) VALUES('{IdAlumno}', '{IdMaestro}', '{IdAula}', '{tbHorario.Text}', '{IdCarrera}')";
            conexionesBD.AgregarBD(Agregargrupo);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaGrupo);
        }
        

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

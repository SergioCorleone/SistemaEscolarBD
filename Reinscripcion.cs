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
    public partial class Reinscripcion : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        public Reinscripcion()
        {
            InitializeComponent();
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

            cbGrupo.SelectedIndex = -1;
            cbAlumno.SelectedIndex = -1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string IdGrupo = "";
            string IdAlumno = "";
            if (cbGrupo.SelectedItem == null)
            {
                MessageBox.Show("Agrege un grupo");
                return;


            }
            else
            {
                IdGrupo = cbGrupo.SelectedValue.ToString();
            }
            if (cbAlumno.SelectedItem == null)
            {
                MessageBox.Show("Agrege un alumno");
                return;
            }
            else
            {
                IdAlumno = cbAlumno.SelectedValue.ToString();
            }
            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string AgregarInscripcion = $"INSERT INTO [dbo].[Reincripcion] ([Id_Grupo],[Id_Alumno],[Calificacion],[FechaHoraCreacion])" +
            $"VALUES('{IdGrupo}','{IdAlumno}','{tbCalificacion.Text}','{fechaFormateada}')";
            conexionesBD.AgregarBD(AgregarInscripcion);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaReinscripcion);
            cbGrupo.SelectedIndex = -1;
            cbAlumno.SelectedIndex = -1;
            tbCalificacion.Text = string.Empty;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

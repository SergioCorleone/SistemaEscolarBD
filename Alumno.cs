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
    public partial class Alumno : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        public Alumno()
        {
            InitializeComponent();
        }

        private void Alumno_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string seleccion = "";
            if (cbEstatus.SelectedItem == null)
            {
                MessageBox.Show("Eliga una opcion");
                return;
            }
            else
            {
                seleccion = cbEstatus.SelectedItem.ToString();
            }
            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string AgregarAlumno = "INSERT INTO [dbo].[Alumnos]" +
               "([Nombre]" +
               ",[Apellidos]" +
               ",[Estatus]" +
               ",[FechaHoraCreacion])" +
         "VALUES" +
               $"('{tbNombre.Text}','{tbApellidos.Text}','{seleccion}','{fechaFormateada}')";
            conexionesBD.AgregarBD(AgregarAlumno);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAlumnos);
            tbNombre.Text = string.Empty;
            tbApellidos.Text = string.Empty;
            cbEstatus.SelectedIndex = -1;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

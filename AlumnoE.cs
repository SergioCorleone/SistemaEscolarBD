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
    public partial class AlumnoE : Form
    {
        EditarAlumnos editarAlumnos;
        ConexionesBD conexionesBD = new ConexionesBD();
        public AlumnoE(EditarAlumnos editarAlumnos)
        {
            InitializeComponent();
            this.editarAlumnos = editarAlumnos;
            tbNombre.Text = editarAlumnos.Nombre;
            tbApellidos.Text = editarAlumnos.Apellidos;
            cbEstatus.SelectedItem = editarAlumnos.Estatus;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string EditarAlumno = $"UPDATE [dbo].[Alumnos] SET [Nombre] = '{tbNombre.Text}' ,[Apellidos] = '{tbApellidos.Text}' ,[Estatus] = '{cbEstatus.SelectedItem}' WHERE IdAlumnos = '{editarAlumnos.Id}'";
            conexionesBD.EditarBD(EditarAlumno);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAlumnos);
        }
    }
}

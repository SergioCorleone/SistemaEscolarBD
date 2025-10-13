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
    public partial class AcademicoE : Form
    {
        EditarGeneral editarAcademico;
        ConexionesBD conexionesBD = new ConexionesBD();

        public AcademicoE(EditarGeneral EditarAcademico)
        {
            InitializeComponent();
            this.editarAcademico = EditarAcademico;
            tbNombreEditar.Text = EditarAcademico.nombre;
            tbApellidosEditar.Text = EditarAcademico.apellidos;
            GradoEditar.SelectedItem = EditarAcademico.grado;
        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string EditarAcademico = "UPDATE [dbo].[Academico]" +
             $"SET [Nombre] = '{tbNombreEditar.Text}'" +
            $",[Apellidos] = '{tbApellidosEditar.Text}'" +
            $",[Grado] = '{GradoEditar.SelectedItem}'" +
            $",[FechaHoraCreacion] = '{fechaFormateada}'" +
             $"WHERE IdAcademico = '{editarAcademico.ID}'";

            conexionesBD.EditarBD(EditarAcademico);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAcademico);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

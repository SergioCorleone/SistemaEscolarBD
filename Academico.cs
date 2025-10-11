using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaEscolarBD
{
    public partial class Academico : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        public Academico()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            string seleccion = "";
            if (Grado.SelectedItem == null)
            {
                MessageBox.Show("Eliga una opcion:");
                return;
            }
            else
            {
                seleccion = Grado.SelectedItem.ToString();
            }
            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string AgregarAcademicoBD = "INSERT INTO[dbo].[Academico]" + "([Nombre]" + ",[Apellidos]" + ",[Grado]" + ",[FechaHoraCreacion])" +
            "VALUES" +
           $"('{tbNombre.Text}','{tbApellidos.Text}' ,'{seleccion}' ,'{fechaFormateada}' )";

            conexionesBD.AgregarBD(AgregarAcademicoBD);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAcademico);
            tbNombre.Text = string.Empty;
            tbApellidos.Text = string.Empty;
            Grado.SelectedIndex = -1;
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

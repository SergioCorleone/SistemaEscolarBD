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
    public partial class Materia : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        public Materia()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombreMateria.Text == "")
            {
                MessageBox.Show("Agrege un nombre");
                return;
            }
            if (tbCreditos.Text == "")
            {
                MessageBox.Show("Agrege creditos");
                return;
            }
            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string AgregarMateria = "INSERT INTO [dbo].[Materia]" +
           "([NombreMateria]" +
           ",[Creditos]" +
           ",[FechaHoraCreacion])" +
     "VALUES" +
           $"('{tbNombreMateria.Text}','{tbCreditos.Text}','{fechaFormateada}')";

            conexionesBD.AgregarBD(AgregarMateria);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerMateria);
            tbNombreMateria.Text = string.Empty;
            tbCreditos.Text = string.Empty;
        }
    }
}

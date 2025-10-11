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
    public partial class Aula : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        public Aula()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string Edificio="";
            if (cbEdificio.SelectedItem == null)
            {
                MessageBox.Show("Elige una opcion");
                return;
            }
            else
            {
                Edificio = cbEdificio.SelectedItem.ToString();
            }
            string Aula = "";
            if (cbAula.SelectedItem == null)
            {
                MessageBox.Show("Elige una opcion");
                return;
            }
            else
            {
                Aula = cbAula.SelectedItem.ToString();
            }
            string Piso = "";
            if (cbPiso.SelectedItem == null)
            {
                MessageBox.Show("Elige una opcion");
                return;
            }
            else
            {
                Piso = cbPiso.SelectedItem.ToString();
            }

            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string AgregarAula = "INSERT INTO [dbo].[Aula]" +
           "([Edificio]" +
           ",[Aula]" +
           ",[Piso]" +
           ",[CapacidadMaxima]" +
           ",[FechaHoraCreacion])" +
     "VALUES" +
           $"('{Edificio}','{Aula}','{Piso}','{tbCapacidad.Text}','{fechaFormateada}')";

            conexionesBD.AgregarBD(AgregarAula);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAula);
            cbEdificio.SelectedIndex = -1;
            cbAula.SelectedIndex = -1;
            cbPiso.SelectedIndex = -1;
            tbCapacidad.Text = string.Empty;
           
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

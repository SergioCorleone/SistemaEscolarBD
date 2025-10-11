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
    public partial class Carrera : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        public Carrera()
        {
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombreCarrera.Text == "")
            {
                MessageBox.Show("Agrege un nombre");
                return;
            }
            if (tbSiglasCarrera.Text == "")
            {
                MessageBox.Show("Agrege las siglas");
                return;
            }
            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string AgregarCarrera = "INSERT INTO [dbo].[Carrera]" +
             "([NombreCarrera]" +
             ",[SiglasCarrera]" +
             ",[FechaHoraCreacion])" +
             "VALUES" +
             $"('{tbNombreCarrera.Text}','{tbSiglasCarrera.Text}','{fechaFormateada}')";
            conexionesBD.AgregarBD(AgregarCarrera);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerCarrera);
            tbNombreCarrera.Text = string.Empty;
            tbSiglasCarrera.Text = string.Empty;
        }

        private void Carrera_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

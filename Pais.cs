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
    public partial class Pais : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        public Pais()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (tbNombrePais.Text == "")
            {
                MessageBox.Show("Agrege un nombre");
                return;
            }
            if (tbSiglasPais.Text == "")
            {
                MessageBox.Show("Agrege siglas");
            }
            string fechaFormateada = dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss");
            string AgregarPais = "INSERT INTO [dbo].[Pais]" +
           "([NombrePais]" +
           ",[SiglaPais]" +
           ",[FechaHoraCreacion])" +
     "VALUES" +
           $"('{tbNombrePais.Text}','{tbSiglasPais.Text}','{fechaFormateada}')";

            conexionesBD.AgregarBD(AgregarPais);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerPais);

            tbNombrePais.Text = string.Empty;
            tbSiglasPais.Text = string.Empty;
        }
    }
}

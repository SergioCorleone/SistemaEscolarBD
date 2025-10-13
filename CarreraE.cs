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
    public partial class CarreraE : Form
    {
        EditarCarrera editarCarrera;
        ConexionesBD conexionesBD = new ConexionesBD();
        public CarreraE(EditarCarrera editarCarre)
        {
            InitializeComponent();
            this.editarCarrera = editarCarre;

            tbNombreCarrera.Text = editarCarre.NombreCarrera;
            tbSiglasCarrera.Text = editarCarre.SiglasCarrera;

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string EditarCarrera = $"UPDATE [dbo].[Carrera] SET [NombreCarrera] = '{tbNombreCarrera.Text}',[SiglasCarrera] = '{tbSiglasCarrera.Text}' WHERE IdCarrera = '{editarCarrera.Id}'";
            conexionesBD.EditarBD(EditarCarrera);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerCarrera);
        }
    }
}

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
    public partial class AulaE : Form
    {
        EditarAula editarAula;
        ConexionesBD conexionesBD = new ConexionesBD();
        public AulaE(EditarAula EditarAula)
        {
            InitializeComponent();
            this.editarAula = EditarAula;

            cbEdificio.SelectedItem = EditarAula.Edificio;
            cbAula.SelectedItem = EditarAula.Aula;
            cbPiso.SelectedItem = EditarAula.Piso;
            tbCapacidad.Text = EditarAula.CapacidadMaxima;
            
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string EditarAula = $"UPDATE [dbo].[Aula] SET [Edificio] = '{cbEdificio.SelectedItem}',[Aula] = '{cbAula.SelectedItem}',[Piso] = '{cbPiso.SelectedItem}',[CapacidadMaxima] = '{tbCapacidad.Text}' WHERE IdAula = '{editarAula.Id}'";
            conexionesBD.EditarBD(EditarAula);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAula);
        }
    }
}

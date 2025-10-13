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
    public partial class PaisE : Form
    {
        EditarPais editarPais;
        ConexionesBD conexionesBD = new ConexionesBD();
        public PaisE(EditarPais EditarPais)
        {
            InitializeComponent();
            this.editarPais = EditarPais;

            tbNombrePais.Text = EditarPais.NombrePais;
            tbSiglasPais.Text = EditarPais.SiglaPais;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string EditarPais = $"UPDATE [dbo].[Pais] SET [NombrePais] = '{tbNombrePais.Text}',[SiglaPais] = '{tbSiglasPais.Text}' WHERE IdPais = '{editarPais.Id}'";
            conexionesBD.EditarBD(EditarPais);
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerPais);
        }
    }
}

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
    public partial class MateriaEcs : Form
    {
        EditarMateria editarMateria;
        ConexionesBD ConexionesBD = new ConexionesBD();
        public MateriaEcs(EditarMateria EditarMateria)
        {
            InitializeComponent();
            this.editarMateria = EditarMateria;
            tbNombreMateria.Text = EditarMateria.NombreMateria;
            tbCreditos.Text = EditarMateria.Creditos;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MateriaEcs_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string EditarMateria = $"UPDATE [dbo].[Materia] SET [NombreMateria] = '{tbNombreMateria.Text}',[Creditos] = '{tbCreditos.Text}' WHERE IdMateria = '{editarMateria.Id}'";
            ConexionesBD.EditarBD(EditarMateria) ;
            ConexionesBD.ObtenerBD(Registro.dataGridView1, ConexionesBD.ConsultaObtenerMateria) ;
        }
    }
}

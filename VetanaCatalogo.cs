using Microsoft.Data.SqlClient;
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
    
    public partial class VetanaCatalogo : Form
    {

        public VetanaCatalogo()
        {
            InitializeComponent();
        }

        private void VetanaCatalogo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConexionesBD conexionesBD = new ConexionesBD();
            conexionesBD.ObtenerBDAcademicos(Registro.dataGridView1, conexionesBD.ConsultaObtenerAcademico);
            Close ();

        }
            
        

        private void btnAlumnos_Click(object sender, EventArgs e)
        {

        }
    }
}

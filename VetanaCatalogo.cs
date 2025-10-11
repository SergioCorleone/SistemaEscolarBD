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
        ConexionesBD conexionesBD = new ConexionesBD();
        public VetanaCatalogo()
        {
            InitializeComponent();
        }

        private void VetanaCatalogo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAcademico);
            Close();
            int Academico = 1;

        }
        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAlumnos);
            Close();
            
        }

        private void btnAula_Click(object sender, EventArgs e)
        {
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerAula);
            Close();
        }

        private void btnCarrera_Click(object sender, EventArgs e)
        {
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerCarrera);
            Close();
        }

        private void btnCiudad_Click(object sender, EventArgs e)
        {
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObteneCiudad);
            Close();
        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerEstado);
            Close();
        }

        private void btnMateria_Click(object sender, EventArgs e)
        {
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerMateria);
            Close();
        }

        private void btnReinscripcion_Click(object sender, EventArgs e)
        {
            conexionesBD.ObtenerBD(Registro.dataGridView1, conexionesBD.ConsultaObtenerPais);
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

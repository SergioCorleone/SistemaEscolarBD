namespace SistemaEscolarBD
{
    public partial class Registro : Form
    {
        VetanaCatalogo vetanaCatalogo = new VetanaCatalogo();
        Academico academico = new Academico();
        Alumno alumno = new Alumno();
        Aula Aula = new Aula();
        Carrera Carrera = new Carrera();
        Ciudad ciudad = new Ciudad();
        Estadocs estado = new Estadocs();
        Materia materia = new Materia();
        Pais Pais = new Pais();
        public Registro()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (VetanaCatalogo.Editar == 1) {
                academico.ShowDialog();
                
            }
            if (VetanaCatalogo.Editar == 2)
            {
                alumno.ShowDialog();
                
            }
            if (VetanaCatalogo.Editar == 3)
            {
                Aula.ShowDialog();
                
            }
            if (VetanaCatalogo.Editar == 4)
            {
                Carrera.ShowDialog();
                
            }
            if (VetanaCatalogo.Editar == 5)
            {
                ciudad.ShowDialog();
               
            }
            if (VetanaCatalogo.Editar == 6)
            {
                estado.ShowDialog();
                
            }
            if (VetanaCatalogo.Editar == 7)
            {
               materia.ShowDialog();
                
            }
            if (VetanaCatalogo.Editar == 8)
            {
                Pais.ShowDialog();
                 
            }
        }

        private void tsbObtener_Click(object sender, EventArgs e)
        {
               vetanaCatalogo.ShowDialog();
            
           
        }
    }
}

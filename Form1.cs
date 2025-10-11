namespace SistemaEscolarBD
{
    public partial class Registro : Form
    {
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

        }

        private void tsbObtener_Click(object sender, EventArgs e)
        {
            
                VetanaCatalogo vetanaCatalogo = new VetanaCatalogo();
               vetanaCatalogo.Show();
            
           
        }
    }
}

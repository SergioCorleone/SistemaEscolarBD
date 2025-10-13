namespace SistemaEscolarBD
{
    public partial class Registro : Form
    {
        ConexionesBD conexionesBD = new ConexionesBD();
        EditarGeneral editarGeneral = new EditarGeneral();
        EditarAlumnos EditarAlumnos = new EditarAlumnos();
        EditarCarrera editarCarrera = new EditarCarrera();
        EditarMateria editarMateria = new EditarMateria();
        EditarEstado editarEstado = new EditarEstado();
        EditarCiudad editarCiudad = new EditarCiudad();
        EditarPais editarPais = new EditarPais();
        EditarAula EditarAula = new EditarAula();
        EditarGrupo EditarGrupo = new EditarGrupo();
        EditarReinscripcion EditarReinscripcion = new EditarReinscripcion();
        VetanaCatalogo vetanaCatalogo = new VetanaCatalogo();
        Academico academico = new Academico();
        Alumno alumno = new Alumno();
        Aula Aula = new Aula();
        Carrera Carrera = new Carrera();
        Ciudad ciudad = new Ciudad();
        Estadocs estado = new Estadocs();
        Materia materia = new Materia();
        Pais Pais = new Pais();
        Reinscripcion Reinscripcion = new Reinscripcion();
        Grupo Grupo = new Grupo();


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
            if (VetanaCatalogo.Editar == 1)
            {
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
            if(VetanaCatalogo.Editar == 10)
            {
                Grupo.ShowDialog();
            }

        }

        private void tsbObtener_Click(object sender, EventArgs e)
        {
            vetanaCatalogo.ShowDialog();


        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (VetanaCatalogo.Editar == 1)
            {

                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    editarGeneral.ID = int.Parse(r.Cells["IdAcademico"].Value.ToString());
                    editarGeneral.nombre = r.Cells["Nombre"].Value.ToString();
                    editarGeneral.apellidos = r.Cells["Apellidos"].Value.ToString();
                    editarGeneral.grado = r.Cells["Grado"].Value.ToString();
                    AcademicoE academicoE = new AcademicoE(editarGeneral);
                    academicoE.ShowDialog();

                }

            }
            if (VetanaCatalogo.Editar == 2)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    EditarAlumnos.Id = int.Parse(r.Cells["IdAlumnos"].Value.ToString());
                    EditarAlumnos.Nombre = r.Cells["Nombre"].Value.ToString();
                    EditarAlumnos.Apellidos = r.Cells["Apellidos"].Value.ToString();
                    EditarAlumnos.Estatus = r.Cells["Estatus"].Value.ToString();
                    AlumnoE alumnoE = new AlumnoE(EditarAlumnos);
                    alumnoE.ShowDialog();
                }
            }
            if (VetanaCatalogo.Editar == 3)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    EditarAula.Id = int.Parse(r.Cells["IdAula"].Value.ToString());
                    EditarAula.Edificio = r.Cells["Edificio"].Value.ToString();
                    EditarAula.Aula = r.Cells["Aula"].Value.ToString();
                    EditarAula.Piso = r.Cells["Piso"].Value.ToString();
                    EditarAula.CapacidadMaxima = r.Cells["CapacidadMaxima"].Value.ToString();
                    AulaE aulaE = new AulaE(EditarAula);
                    aulaE.ShowDialog();
                }
            }
            if (VetanaCatalogo.Editar == 4)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    editarCarrera.Id = int.Parse(r.Cells["IdCarrera"].Value.ToString());
                    editarCarrera.NombreCarrera = r.Cells["NombreCarrera"].Value.ToString();
                    editarCarrera.SiglasCarrera = r.Cells["SiglasCarrera"].Value.ToString();
                    CarreraE carreraE = new CarreraE(editarCarrera);
                    carreraE.ShowDialog();
                }
            }
            if (VetanaCatalogo.Editar == 5)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    editarCiudad.Id = int.Parse(r.Cells["IdCiudad"].Value.ToString());
                    editarCiudad.NombreCiudad = r.Cells["NombreCiudad"].Value.ToString();
                    editarCiudad.SiglasCiudad = r.Cells["SiglasCiudad"].Value.ToString();
                    editarCiudad.IdEstado = int.Parse(r.Cells["IdEstado"].Value.ToString());
                    CiudadEcs ciudadEcs = new CiudadEcs(editarCiudad);
                    ciudadEcs.ShowDialog();
                }
            }
            if (VetanaCatalogo.Editar == 6)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    editarEstado.Id = int.Parse(r.Cells["IdEstado"].Value.ToString());
                    editarEstado.NombreEstado = r.Cells["NombreEstado"].Value.ToString();
                    editarEstado.SiglasEstado = r.Cells["SiglaEstado"].Value.ToString();
                    editarEstado.IdPais = int.Parse(r.Cells["IdPais"].Value.ToString());
                    EstadosE estadosE = new EstadosE(editarEstado);
                    estadosE.ShowDialog();
                }
            }
            if (VetanaCatalogo.Editar == 7)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    editarMateria.Id = int.Parse(r.Cells["IdMateria"].Value.ToString());
                    editarMateria.NombreMateria = r.Cells["NombreMateria"].Value.ToString();
                    editarMateria.Creditos = r.Cells["Creditos"].Value.ToString();
                    MateriaEcs materiaEcs = new MateriaEcs(editarMateria);
                    materiaEcs.ShowDialog();

                }
            }
            if (VetanaCatalogo.Editar == 8)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    editarPais.Id = int.Parse(r.Cells["IdPais"].Value.ToString());
                    editarPais.NombrePais = r.Cells["NombrePais"].Value.ToString();
                    editarPais.SiglaPais = r.Cells["SiglaPais"].Value.ToString();
                    PaisE paisE = new PaisE(editarPais);
                    paisE.ShowDialog();
                }
            }
            if (VetanaCatalogo.Editar == 9)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    EditarReinscripcion.id = int.Parse(r.Cells["IdReinscripcion"].Value.ToString());
                    EditarReinscripcion.idGrupo = int.Parse(r.Cells["Id_Grupo"].Value.ToString());
                    EditarReinscripcion.idAlumno = int.Parse(r.Cells["Id_Alumno"].Value.ToString());
                    EditarReinscripcion.Calificacion = float.Parse(r.Cells["Calificacion"].Value.ToString());
                    ReinscripcionE reinscripcionE = new ReinscripcionE(EditarReinscripcion);
                    reinscripcionE.ShowDialog();
                }
            }
            if (VetanaCatalogo.Editar == 10)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    EditarGrupo.Id = int.Parse(r.Cells["Id_Grupo"].Value.ToString());
                    EditarGrupo.Alumno = int.Parse(r.Cells["IdAlumno"].Value.ToString());
                    EditarGrupo.Maestro = int.Parse(r.Cells["IdMaestro"].Value.ToString());
                    EditarGrupo.Aula = int.Parse(r.Cells["IdAula"].Value.ToString());
                    EditarGrupo.Horario = r.Cells["Horario"].Value.ToString();
                    EditarGrupo.Carrera = int.Parse(r.Cells["IdCarrera"].Value.ToString()); 
                    GruposE gruposE = new GruposE(EditarGrupo);
                    gruposE.ShowDialog();
                }
            }
         }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (VetanaCatalogo.Editar == 1)
            {
                int idseleccionado = 0;
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    idseleccionado = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un registro");
                    return;
                }
                string EliminarAcademico = $"DELETE FROM [dbo].[Academico] WHERE IdAcademico = '{idseleccionado}'";
                conexionesBD.EliminarDB(EliminarAcademico);
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerAcademico);
            }
            if (VetanaCatalogo.Editar == 2)
            {
                int idseleccionado = 0;
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    idseleccionado = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un registro");
                    return;
                }
                string EliminarAlumno = $"DELETE FROM [dbo].[Alumnos] WHERE IdAlumnos = '{idseleccionado}'";
                conexionesBD.EliminarDB(EliminarAlumno);
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerAlumnos);
            }
            if (VetanaCatalogo.Editar == 3)
            {
                int idseleccionado = 0;
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    idseleccionado = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un registro");
                    return;
                }
                string EliminarAula = $"DELETE FROM [dbo].[Aula] WHERE IdAula = '{idseleccionado}'";
                conexionesBD.EliminarDB(EliminarAula);
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerAula);
            }
            if (VetanaCatalogo.Editar == 4)
            {
                int idseleccionado = 0;
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    idseleccionado = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un registro");
                    return;
                }
                string EliminarCarrera = $"DELETE FROM [dbo].[Carrera] WHERE IdCarrera = '{idseleccionado}'";
                conexionesBD.EliminarDB(EliminarCarrera);
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerCarrera);
            }
            if (VetanaCatalogo.Editar == 5)
            {
                int idseleccionado = 0;
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    idseleccionado = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un registro");
                    return;
                }
                string EliminarCiudad = $"DELETE FROM [dbo].[Ciudad] WHERE IdCiudad = '{idseleccionado}'";
                conexionesBD.EliminarDB(EliminarCiudad);
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObteneCiudad);
            }
            if (VetanaCatalogo.Editar == 6)
            {
                int idseleccionado = 0;
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    idseleccionado = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un registro");
                    return;
                }
                string EliminarEstado = $"DELETE FROM [dbo].[Estado] WHERE IdEstado = '{idseleccionado}'";
                conexionesBD.EliminarDB(EliminarEstado);
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerEstado);
            }
            if (VetanaCatalogo.Editar == 7)
            {
                int idseleccionado = 0;
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    idseleccionado = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un registro");
                    return;
                }
                string EliminarMateria = $"DELETE FROM [dbo].[Materia] WHERE IdMateria = '{idseleccionado}'";
                conexionesBD.EliminarDB(EliminarMateria);
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerMateria);
            }
            if (VetanaCatalogo.Editar == 8)
            {
                int idseleccionado = 0;
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    idseleccionado = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un registro");
                    return;
                }
                string EliminarPais = $"DELETE FROM [dbo].[Pais] WHERE IdPais = '{idseleccionado}'";
                conexionesBD.EliminarDB(EliminarPais);
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerPais);
            }
            if (VetanaCatalogo.Editar == 9)
            {
                int idseleccionado = 0;
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    idseleccionado = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un registro");
                    return;
                }
                string EliminarReinscripcion = $"DELETE FROM [dbo].[Reincripcion] WHERE IdReinscripcion = '{idseleccionado}'";
                conexionesBD.EliminarDB(EliminarReinscripcion);
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaReinscripcion);
            }
            if (VetanaCatalogo.Editar == 10)
            {
                int idseleccionado = 0;
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    idseleccionado = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                }
                else
                {
                    MessageBox.Show("Debes seleccionar un registro");
                    return;
                }
                string EliminarGrupo = $"DELETE FROM [dbo].[Grupo] WHERE Id_Grupo = '{idseleccionado}'";
                conexionesBD.EliminarDB(EliminarGrupo);
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaGrupo);

            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaReinscripcion);
            VetanaCatalogo.Editar = 9;
            Reinscripcion.ShowDialog();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaGrupo);
            VetanaCatalogo.Editar = 10;

        }
    }
}

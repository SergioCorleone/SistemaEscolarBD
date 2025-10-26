using Microsoft.Data.SqlClient;
using System.Data;

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
            else if (VetanaCatalogo.Editar == 2)
            {
                alumno.ShowDialog();

            }
            else if (VetanaCatalogo.Editar == 3)
            {
                Aula.ShowDialog();

            }
            else if (VetanaCatalogo.Editar == 4)
            {
                Carrera.ShowDialog();

            }
            else if (VetanaCatalogo.Editar == 5)
            {
                ciudad.ShowDialog();

            }
            else if (VetanaCatalogo.Editar == 6)
            {
                estado.ShowDialog();

            }
            else if (VetanaCatalogo.Editar == 7)
            {
                materia.ShowDialog();

            }
            else if (VetanaCatalogo.Editar == 8)
            {
                Pais.ShowDialog();

            }
            else if(VetanaCatalogo.Editar == 10)
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
            else if (VetanaCatalogo.Editar == 2)
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
            else if (VetanaCatalogo.Editar == 3)
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
           else  if (VetanaCatalogo.Editar == 4)
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
           else  if (VetanaCatalogo.Editar == 5)
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
            else if (VetanaCatalogo.Editar == 6)
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
            else if (VetanaCatalogo.Editar == 7)
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
            else if (VetanaCatalogo.Editar == 8)
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
            else if (VetanaCatalogo.Editar == 9)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    try
                    {
                        dataGridView1.Columns["IdReinscripcion"].Visible = false;
                        dataGridView1.Columns["IdAlumnos"].Visible = false;
                        dataGridView1.Columns["Id_Grupo"].Visible = false;
                       
                    }
                    catch (Exception ex) {    
                        MessageBox.Show("Error ocultando columnas: " + ex.Message);
                    }
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    EditarReinscripcion.id = int.Parse(r.Cells["IdReinscripcion"].Value.ToString());
                    EditarReinscripcion.idGrupo = int.Parse(r.Cells["Id_Grupo"].Value.ToString());
                    EditarReinscripcion.idAlumno = int.Parse(r.Cells["IdAlumnos"].Value.ToString());
                    EditarReinscripcion.Calificacion = float.Parse(r.Cells["Calificacion"].Value.ToString());
                    ReinscripcionE reinscripcionE = new ReinscripcionE(EditarReinscripcion);
                    reinscripcionE.ShowDialog();
                }
            }
            else if (VetanaCatalogo.Editar == 10)
            {
                if (dataGridView1.SelectedRows != null && dataGridView1.SelectedRows.Count == 1)
                {
                    try
                    {
                        dataGridView1.Columns["IdAcademico"].Visible = false;
                        dataGridView1.Columns["IdAlumnos"].Visible = false;
                        dataGridView1.Columns["IdCarrera"].Visible = false;
                        dataGridView1.Columns["IdAula"].Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error ocultando columnas: " + ex.Message);
                    }
                    DataGridViewRow r = dataGridView1.SelectedRows[0];
                    EditarGrupo.Id = int.Parse(r.Cells["Id_Grupo"].Value.ToString());
                    EditarGrupo.Alumno = int.Parse(r.Cells["IdAlumnos"].Value.ToString());
                    EditarGrupo.Maestro = int.Parse(r.Cells["IdAcademico"].Value.ToString());
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
               
                try
                {
                    
                    using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                    {
                        miConexion.Open();

                        
                        using (SqlCommand cmd = new SqlCommand("sp_EliminarAcademico", miConexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@IdAcademico", idseleccionado);

                            
                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Registro eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerAcademico);
            }
            else if (VetanaCatalogo.Editar == 2)
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
                try
                {

                    using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                    {
                        miConexion.Open();


                        using (SqlCommand cmd = new SqlCommand("sp_EliminarAlumno", miConexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@IdAlumno", idseleccionado);


                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Registro eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerAlumnos);
            }
            else if (VetanaCatalogo.Editar == 3)
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
                try
                {

                    using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                    {
                        miConexion.Open();


                        using (SqlCommand cmd = new SqlCommand("sp_EliminarAula", miConexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@IdAula", idseleccionado);


                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Registro eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerAula);
            }
            else if (VetanaCatalogo.Editar == 4)
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
                try
                {

                    using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                    {
                        miConexion.Open();


                        using (SqlCommand cmd = new SqlCommand("sp_EliminarCarrera", miConexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@IdCarrera", idseleccionado);


                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Registro eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerCarrera);
            }
            else if (VetanaCatalogo.Editar == 5)
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
                try
                {

                    using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                    {
                        miConexion.Open();


                        using (SqlCommand cmd = new SqlCommand("sp_EliminarCiudad", miConexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@IdCiudad", idseleccionado);


                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Registro eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObteneCiudad);
            }
            else if (VetanaCatalogo.Editar == 6)
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
                try
                {

                    using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                    {
                        miConexion.Open();


                        using (SqlCommand cmd = new SqlCommand("sp_EliminarEstado", miConexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@IdEstado", idseleccionado);


                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Registro eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerEstado);
            }
           else  if (VetanaCatalogo.Editar == 7)
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
                try
                {

                    using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                    {
                        miConexion.Open();


                        using (SqlCommand cmd = new SqlCommand("sp_EliminarMateria", miConexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@IdMateria", idseleccionado);


                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Registro eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerMateria);
            }
            else if (VetanaCatalogo.Editar == 8)
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
                try
                {

                    using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                    {
                        miConexion.Open();


                        using (SqlCommand cmd = new SqlCommand("sp_EliminarPais", miConexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@IdPais", idseleccionado);


                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Registro eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaObtenerPais);
            }
           else  if (VetanaCatalogo.Editar == 9)
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
                try
                {

                    using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                    {
                        miConexion.Open();


                        using (SqlCommand cmd = new SqlCommand("sp_EliminarReinscripcion", miConexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@IdReinscripcion", idseleccionado);


                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Registro eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
                conexionesBD.ObtenerBD(dataGridView1, conexionesBD.ConsultaReinscripcion);
            }
            else if (VetanaCatalogo.Editar == 10)
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
                try
                {

                    using (SqlConnection miConexion = new SqlConnection(conexionesBD.connexion))
                    {
                        miConexion.Open();


                        using (SqlCommand cmd = new SqlCommand("sp_EliminarGrupo", miConexion))
                        {
                            cmd.CommandType = CommandType.StoredProcedure;

                            cmd.Parameters.AddWithValue("@IdGrupo", idseleccionado);


                            cmd.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Registro eliminado correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al eliminar el registro: " + ex.Message);
                }
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

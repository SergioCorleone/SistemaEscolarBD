using Microsoft.Data.SqlClient;
using SistemaEscolarBD;
using System;
using System.Data;

public class ConexionesBD
    {
    //Consulta para la conexion
    public string connexion = "Server=SERGIO\\SQLEXPRESS;"
              + " Database= GruposBD;"
              + " Integrated Security=True; "
              + " TrustServerCertificate=True";
    //Consultas para agregar
    public string ConsultaObtenerAcademico = "SELECT * FROM viewAcademico";
    public string ConsultaObtenerAlumnos = "SELECT * FROM viewAlumnos";
    public string ConsultaObtenerAula = "SELECT * FROM viewAula";
    public string ConsultaObtenerCarrera = "SELECT * FROM viewCarrera";
    public string ConsultaObteneCiudad = "SELECT * FROM viewCiudad";
    public string ConsultaObtenerEstado = "SELECT * FROM viewEstado";
    public string ConsultaObtenerMateria = "SELECT * FROM viewMateria";
    public string ConsultaObtenerPais = "SELECT * FROM viewPais";
    public string ConsultaReinscripcion = "SELECT * FROM viewReinscripcionesCompleto";
    public string ConsultaGrupo = "SELECT * FROM viewGrupoCompleto";



    public void ObtenerBD(DataGridView dgv,string consulta) {
        
        SqlConnection con = new SqlConnection(connexion);
        
        try
        {
            con.Open();
            SqlDataAdapter adacademicos = new SqlDataAdapter(consulta,connexion);
            DataTable dt = new DataTable();
            adacademicos.Fill(dt);
            dgv.DataSource = dt;
           
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error:" + ex);

        }
        finally
        {
            if (con != null)
            {
                con.Close();
            }
        }
    }
    public void AgregarBD(string consultaAgregar)
    {
        SqlConnection con = new SqlConnection(connexion);
        try
        {
            con.Open();
            SqlCommand cmdAgregar = new SqlCommand(consultaAgregar,con);
            int renglonesAfectados = cmdAgregar.ExecuteNonQuery();

            if (renglonesAfectados > 0) {
                MessageBox.Show("Exito al insertar registro");
            }
            else
            {
                MessageBox.Show("Error desconocido al insertar registro");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error:" + ex);

        }
        finally
        {
            if(con != null)
            {
                con.Close( );
            }
        }
    }
	
    public void EditarBD (string ConsultaEditar)
    {
        SqlConnection sqlConnection = new SqlConnection(connexion);

        try
        {
            sqlConnection.Open();
            SqlCommand cmdEditar = new SqlCommand(ConsultaEditar,sqlConnection);
            int registrosEditados = cmdEditar.ExecuteNonQuery();

            if (registrosEditados > 0)
            {
                MessageBox.Show("Registro editado correctamente");
            }
            else
            {
                MessageBox.Show("Error desconocido al editar el registro");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error:" + ex) ;

        }
        finally
        {
            if (sqlConnection != null) 
            { 
            sqlConnection.Close();
            }
        }
    }

    public void EliminarDB (string ConsultaEliminar)
    {
        SqlConnection sqlConnection = new SqlConnection(connexion);

        try
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand( ConsultaEliminar,sqlConnection);
            sqlCommand.CommandType = CommandType.Text;

            int NumeroRenglonesAfectados = sqlCommand.ExecuteNonQuery();

            if (NumeroRenglonesAfectados > 0)
            {
                MessageBox.Show("El registro fue eliminado");
               
            }
            else
            {
                MessageBox.Show("Ningun registro fue eliminado");
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error" + ex);

        }
        finally
        {
            if(sqlConnection != null)
            {
                sqlConnection.Close();
            }
        }
    }
}

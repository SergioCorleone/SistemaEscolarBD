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
    public string ConsultaObtenerAcademico = "SELECT [IdAcademico]\r\n      ,[Nombre]\r\n      ,[Apellidos]\r\n      ,[Grado]\r\n      ,[FechaHoraCreacion]\r\n  FROM [GruposBD].[dbo].[Academico]";
    public string ConsultaObtenerAlumnos = "SELECT[IdAlumnos],[Nombre],[Apellidos],[Estatus],[FechaHoraCreacion] FROM [GruposBD].[dbo].[Alumnos]";
    public string ConsultaObtenerAula = "SELECT[IdAula],[Edificio],[Aula],[Piso],[CapacidadMaxima],[FechaHoraCreacion]FROM[GruposBD].[dbo].[Aula]";
    public string ConsultaObtenerCarrera = "SELECT[IdCarrera],[NombreCarrera],[SiglasCarrera],[FechaHoraCreacion]FROM[GruposBD].[dbo].[Carrera]";
    public string ConsultaObteneCiudad = "SELECT[IdCiudad],[NombreCiudad],[SiglasCiudad],[FechaHoraCreacion],[IdEstado] FROM [GruposBD].[dbo].[Ciudad]";
    public string ConsultaObtenerEstado = "SELECT[IdEstado],[NombreEstado],[SiglaEstado],[FechaHoraCreacion],[IdPais]FROM[GruposBD].[dbo].[Estado]";
    public string ConsultaObtenerMateria = "SELECT[IdMateria],[NombreMateria],[Creditos],[FechaHoraCreacion]FROM[GruposBD].[dbo].[Materia]";
    public string ConsultaObtenerPais = "SELECT[IdPais],[NombrePais],[SiglaPais],[FechaHoraCreacion]FROM[GruposBD].[dbo].[Pais]";




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
	
	public ConexionesBD()
	{

	}
}

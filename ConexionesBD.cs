using Microsoft.Data.SqlClient;
using SistemaEscolarBD;
using System;
using System.Data;

public class ConexionesBD
{
    public string connexion = "Server=SERGIO\\SQLEXPRESS;"
              + " Database= GruposBD;"
              + " Integrated Security=True; "
              + " TrustServerCertificate=True";
    public string ConsultaObtenerAcademico = "SELECT [IdAcademico]\r\n      ,[Nombre]\r\n      ,[Apellidos]\r\n      ,[Grado]\r\n      ,[FechaHoraCreacion]\r\n  FROM [GruposBD].[dbo].[Academico]";

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
	
	public ConexionesBD()
	{

	}
}

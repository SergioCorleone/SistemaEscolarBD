using Microsoft.Data.SqlClient;
using System;
using System.Data;

public class ConexionesBD
{
	public void ObtenerBD(DataGridView dgv)
	{
		SqlUtilidades uti = new SqlUtilidades();
		using (SqlConnection con = new SqlConnection(uti.connexion))
		{
			try
			{
				con.Open();
				DataTable dt = new DataTable();
			}
			catch (Exception)
			{

			
			}
		}
	}
	public ConexionesBD()
	{

	}
}

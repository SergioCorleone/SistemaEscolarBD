using Microsoft.Identity.Client;
using System;

public class SqlUtilidades
{
    
    public string connexion = "Server=SERGIO\\SQLEXPRESS;"
              + " Database= GruposBD;"
              + " Integrated Security=True; "
              + " TrustServerCertificate=True";
    public string ConsultaObtenerAcademico = "SELECT [IdAcademico]\r\n      ,[Nombre]\r\n      ,[Apellidos]\r\n      ,[Grado]\r\n      ,[FechaHoraCreacion]\r\n  FROM [GruposBD].[dbo].[Academico]"; 
    
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;


namespace Datos
{
	public class BD_Notas
	{
		SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
		SqlCommand cmd;

		public Boolean guardar_notas(string descripcion) 
		{
			Boolean xRet = true;
			try 
			{
				cn.Open();
				string guardarSql = "UPDATE Notas SET descripcion = @descripcion";
				cmd = new SqlCommand(guardarSql,cn);
				cmd.Parameters.AddWithValue("@Descripcion",descripcion);
				cmd.ExecuteScalar();
			}
			catch (Exception)		
			{
				xRet = false;
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}

			return xRet;
		}
		public string get_Nota()
		{
			String descripcion = null ;
			try
			{
				cn.Open();
				string sql = "SELECT TOP 1 descripcion , max(idNota)FROM Notas GROUP BY descripcion ";
				cmd = new SqlCommand(sql, cn);
				SqlDataReader oReader = cmd.ExecuteReader();

				while (oReader.Read())
				{
					descripcion = oReader["Descripcion"].ToString();
				}
			}
			catch (Exception)
			{
				descripcion = null;
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}

			return descripcion;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
	public class BD_CondPago
	{
		SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
		SqlCommand cmd;
		string xRet = "0";

		public List<E_CondPago> getAllCondPago()
		{
			List<E_CondPago> condPagos = new List<E_CondPago>();
			try
			{
				cn.Open();
				cmd = new SqlCommand("getAllCondPago", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				SqlDataReader oReader = cmd.ExecuteReader();

				while (oReader.Read())
				{
					E_CondPago condPago = new E_CondPago();

					condPago.idCondPago = Convert.ToInt16(oReader["idCondPago"]);
					condPago.descripcion = oReader["descripcion"].ToString();

					condPagos.Add(condPago);
				}

			}
			catch (Exception e)
			{
				xRet = e.Message;
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}

			}


			return condPagos;
		}
		public E_CondPago getOneCondPago(Int64 idCondPago)
		{
			E_CondPago condPago = null;
			try
			{
				cn.Open();
				cmd = new SqlCommand("getOneCondPago", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@idCondPago", idCondPago);
				SqlDataReader oReader = cmd.ExecuteReader();

				while (oReader.Read())
				{
					condPago = new E_CondPago();
					condPago.idCondPago = Convert.ToInt64(oReader["idCondPago"]);
					condPago.descripcion = oReader["descripcion"].ToString();
				
				}
			}
			catch (Exception)
			{
				condPago = null;


			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}
			return condPago;
		}//getOneCliente
	}
}

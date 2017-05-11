using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
	public class BD_Caja
	{
		SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
		SqlCommand cmd;

		public E_Caja getOne_CajaDiaria(DateTime fecha)
		{
			E_Caja caja= null;
			try
			{
				cmd = new SqlCommand("getOneCaja", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@fecCaja", fecha);
				cn.Open();
				SqlDataReader oReader = cmd.ExecuteReader();

				while (oReader.Read())
				{
					 caja = new E_Caja();
					 if (oReader["Efectivo"] != DBNull.Value) caja.efectivo = Convert.ToDecimal(oReader["Efectivo"]);
					 if (oReader["Cheque"] != DBNull.Value) caja.cheques = Convert.ToDecimal(oReader["Cheque"]);
					 if (oReader["Tarjeta"] != DBNull.Value) caja.tarjCredito = Convert.ToDecimal(oReader["Tarjeta"]);
					 if (oReader["CajaInicial"] != DBNull.Value) caja.caja = Convert.ToDecimal(oReader["CajaInicial"]);
                     if (oReader["NotasCreditoOtorgado"] != DBNull.Value) caja.notaCreditoOrtogado = Convert.ToDecimal(oReader["NotasCreditoOtorgado"]);
                     if (oReader["NotasCreditoUtilizado"] != DBNull.Value) caja.notaCreditoUtilizado = Convert.ToDecimal(oReader["NotasCreditoUtilizado"]);

				}
			}
			catch
			{
				caja = null;
			}

			return caja;
		}
		public Int16 count_CajaDiaria(DateTime fecha)
		{
			Int16 caja = 0;
			try
			{
				cmd = new SqlCommand("Select COUNT(*) FROM CajaDiaria WHERE fecCaja= @fecCaja ", cn);
				cmd.Parameters.AddWithValue("@fecCaja", fecha);
				cn.Open();
				caja = Convert.ToInt16(cmd.ExecuteScalar());
			}
			catch (Exception)
			{

				caja = -1;
			}

			return caja;
		}
		public Boolean abrir_CajaDiaria(E_Caja caja)
		{
			Boolean xConf = true;
			try
			{
				cmd = new SqlCommand("INSERT INTO CajaDiaria(fecCaja,cajaInicial,cerrado) VALUES (@fecCaja,@cajaInicial,@cerrado) ", cn);
				cmd.Parameters.AddWithValue("@fecCaja", caja.fecCaja);
				cmd.Parameters.AddWithValue("@cajaInicial", caja.caja);
				cmd.Parameters.AddWithValue("@cerrado", caja.cerrado);

				cn.Open();
				cmd.ExecuteScalar();
			}
			catch (Exception)
			{
				xConf = false;
				
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}

			}
			return xConf;
		}
		public Boolean cerrar_CajaDiaria(DateTime fecCaja)
		{
			Boolean xConf = true;
			try
			{
				cmd = new SqlCommand("UPDATE CajaDiaria SET cerrado = @Cerrado WHERE fecCaja=@fecCaja", cn);
				cmd.Parameters.AddWithValue("@fecCaja", fecCaja);
				cmd.Parameters.AddWithValue("@cerrado", E_Caja.CERRAR_CAJA);

				cn.Open();
				cmd.ExecuteScalar();
			}
			catch (Exception)
			{
				xConf = false;

			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}

			}
			return xConf;
		}
		//public E_Caja getOne_CajaDiaria(DateTime fecCaja)
		//{
		//    E_Caja caja = null; 
		//    try
		//    {
		//        cmd = new SqlCommand("SELECT * FROM CajaDiaria WHERE fecCaja  = @fecCaja", cn);
				
		//        cmd.Parameters.AddWithValue("@fecCaja", fecCaja);
		//        cn.Open();
		//        cmd.ExecuteScalar();
		//        SqlDataReader oReader = cmd.ExecuteReader();
		//        while (oReader.Read())
		//        {
		//            caja = new E_Caja();
		//            caja.idCaja = Convert.ToInt64(oReader["idCaja"]);
		//            caja.cerrado = Convert.ToBoolean(oReader["cerrado"]);
		//            caja.caja = Convert.ToDecimal(oReader["cajaInicial"]);
		//        }

			
		//    }
		//    catch (Exception)
		//    {
		//        caja = null;
				
		//    }
		//    finally
		//    {
		//        if (cn.State == ConnectionState.Open)
		//        {
		//            cn.Close();
		//        }

		//    }
		//    return caja;
		//}

		
	}
}

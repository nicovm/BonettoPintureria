using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class BD_NotasCredito
    {
        private SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
        private SqlCommand cmd;
        private string xRet = "0";

        public string add_NotaCredito(E_NotaCredito oNotaCredito)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("INSERT INTO NotasCredito(fechaAlta,idCliente,monto,codVenta) " +
                                        "VALUES(@fechaAlta,@idCliente,@monto,@codVenta) ", cn);

                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@fechaAlta", oNotaCredito.fecha);
                cmd.Parameters.AddWithValue("@idCliente", oNotaCredito.idCliente);
                cmd.Parameters.AddWithValue("@monto", oNotaCredito.monto);
                cmd.Parameters.AddWithValue("@codVenta", oNotaCredito.codVenta);

                cmd.ExecuteNonQuery();

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
            return xRet;
        }

        public string set_NotaCredito(E_NotaCredito oNotaCredito)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("UPDATE NotasCredito Set(fechaAlta=@fecha,idCliente=@idCliente,monto=@monto,fechaUtilizado = @fechaUtilizado " +
                                      " montoUtilizado =@montoUtilizado) where idNotaCredito=@idNotaCredito", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCliente" , oNotaCredito.idCliente);
                cmd.Parameters.AddWithValue("@fecha", oNotaCredito.fecha);
                cmd.Parameters.AddWithValue("@idCliente", oNotaCredito.idCliente);
                cmd.Parameters.AddWithValue("@monto", oNotaCredito.monto);
                cmd.Parameters.AddWithValue("@fechaUtilizado", oNotaCredito.fechaUtilizado);
                cmd.Parameters.AddWithValue("@montoUtilizado", oNotaCredito.montoUtilizado);

                cmd.ExecuteNonQuery();

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


            return xRet;
        }

        public string delete_NotaCredito(E_NotaCredito oNotaCredito)
        {
             try
            {
                cn.Open();
                cmd = new SqlCommand("UPDATE NotasCredito Set(fecha=@fecha,idCliente=@idCliente,monto=@monto,fechaUtilizado = @fechaUtilizado " +
                                      " montoUtilizado =@montoUtilizado) where idNotaCredito=@idNotaCredito", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCliente" , oNotaCredito.idCliente);
                cmd.Parameters.AddWithValue("@fecha", oNotaCredito.fecha);
                cmd.Parameters.AddWithValue("@idCliente", oNotaCredito.idCliente);
                cmd.Parameters.AddWithValue("@monto", oNotaCredito.monto);
                cmd.Parameters.AddWithValue("@fechaUtilizado", oNotaCredito.fechaUtilizado);
                cmd.Parameters.AddWithValue("@montoUtilizado", oNotaCredito.montoUtilizado);

                cmd.ExecuteNonQuery();

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


            return xRet;
        }

        public List<E_NotaCredito> getAll(DateTime fecDesde, DateTime fecHasta, string descripcionClie)
        {
            List<E_NotaCredito> listNotaCredito =  new List<E_NotaCredito>();
            try
            {


                cn.Open();
                cmd = new SqlCommand("getAllNotaCredito", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@fecDesde", fecDesde);
                cmd.Parameters.AddWithValue("@fecHasta", fecHasta);
                cmd.Parameters.AddWithValue("@descripcion", descripcionClie);

                SqlDataReader oReader = cmd.ExecuteReader();

                

                while (oReader.Read())
                {
                    E_NotaCredito  oNotaCredito = new E_NotaCredito();
                    oNotaCredito.idNotaCredito = Convert.ToInt64(oReader["idNotaCredito"]);
                    oNotaCredito.fecha = Convert.ToDateTime(oReader["fechaAlta"]);
                    oNotaCredito.monto = Convert.ToDecimal(oReader["monto"]);
                    oNotaCredito.idCliente = Convert.ToInt64(oReader["idCliente"]);
                    oNotaCredito.montoUtilizado = oReader["montoUtilizado"] == DBNull.Value ?  0: Convert.ToDecimal(oReader["montoUtilizado"]);
                    oNotaCredito.codVenta =  oReader["codVenta"] == DBNull.Value ? 0 :   Convert.ToInt64(oReader["codVenta"]);
                    oNotaCredito.nombreCliente = Convert.ToString(oReader["cliente"]);

                    listNotaCredito.Add(oNotaCredito);
                }

                return listNotaCredito;

            }
            catch (Exception e)
            {
                xRet = e.Message;
                listNotaCredito = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }

            return listNotaCredito;
        }

        /// <summary>
        /// Permite obtener el monto total de credito ortogado al cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public decimal getCredito(Int64 idCliente)
        {
            decimal credito = -1;
            List<E_NotaCredito> listNotaCredito = new List<E_NotaCredito>();
            try
            {


                cn.Open();
                cmd = new SqlCommand("getCredito", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCliente", idCliente);

                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    //Si devuelve NULL es porque no tiene credito
                    credito = oReader ["monto"] == DBNull.Value ? 0:  Convert.ToDecimal(oReader["monto"]); 
                   
                }

                return credito;

            }
            catch (Exception e)
            {
                xRet = e.Message;
                listNotaCredito = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }

            return credito;
        }

        public E_NotaCredito getOne(Int64 idNotaCredito)
        { 
            E_NotaCredito  oNotaCredito = new E_NotaCredito();
            try
            {


                cn.Open();
                cmd = new SqlCommand("getOneNotaCredito", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idNotaCredito", idNotaCredito);
              

                SqlDataReader oReader = cmd.ExecuteReader();

                
   
                while (oReader.Read())
                {
                   
                    oNotaCredito.idNotaCredito = Convert.ToInt64(oReader["idNotaCredito"]);
                    oNotaCredito.fecha = Convert.ToDateTime(oReader["fechaAlta"]);
                    oNotaCredito.monto = Convert.ToDecimal(oReader["monto"]);
                    oNotaCredito.idCliente = Convert.ToInt64(oReader["idCliente"]);
                    //oNotaCredito.fechaUtilizado = 
                    if (oReader["fechaUtilizado"] == DBNull.Value)
                    {
                        oNotaCredito.utilizado = false;
                        

                    }
                    else
                    {
                        oNotaCredito.fechaUtilizado = Convert.ToDateTime(oReader["fechaUtilizado"]);
                        oNotaCredito.montoUtilizado = Convert.ToDecimal(oReader["montoUtilizado"]);
                    }

                    oNotaCredito.codVenta =  oReader["codVenta"] == DBNull.Value ? 0:  Convert.ToInt64(oReader["codVenta"]);
                    oNotaCredito.nombreCliente = Convert.ToString(oReader["cliente"]);

                }

            }
            catch (Exception e)
            {
                xRet = e.Message;
               oNotaCredito = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }

            return oNotaCredito;
        }

        /// <summary>
        /// Permite obtener el primer credito vigente otorgado al cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public E_NotaCredito getPrimerCredito(Int64 idCliente)
        {
            E_NotaCredito oNotaCredito = null ;
            try
            {


                cn.Open();
                cmd = new SqlCommand("getPrimerCredito", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idCliente", idCliente );


                SqlDataReader oReader = cmd.ExecuteReader();



                while (oReader.Read())
                {

                    oNotaCredito = new E_NotaCredito();
                    oNotaCredito.idNotaCredito = Convert.ToInt64(oReader["idNotaCredito"]);
                    oNotaCredito.fecha = Convert.ToDateTime(oReader["fechaAlta"]);
                    oNotaCredito.monto = Convert.ToDecimal(oReader["monto"]);
                    oNotaCredito.idCliente = Convert.ToInt64(oReader["idCliente"]);
                    //oNotaCredito.fechaUtilizado = 
                    if (oReader["fechaUtilizado"] == DBNull.Value)
                    {
                        oNotaCredito.utilizado = false;


                    }
                    else
                    {
                        oNotaCredito.fechaUtilizado = Convert.ToDateTime(oReader["fechaUtilizado"]);
                        oNotaCredito.montoUtilizado = Convert.ToDecimal(oReader["montoUtilizado"]);
                    }

                    oNotaCredito.codVenta = oReader["codVenta"] == DBNull.Value ? 0 : Convert.ToInt64(oReader["codVenta"]);
                    //oNotaCredito.nombreCliente = Convert.ToString(oReader["cliente"]);

                }

            }
            catch (Exception e)
            {
                xRet = e.Message;
                oNotaCredito = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }

            return oNotaCredito ;
        }

        public string utilizarCredito(decimal montoUtilizar, Int64 codVenta , Int64 idNotaCredito)
        {
            string xRet="0";
            try
            {
                
          
                cn.Open();
                cmd = new SqlCommand("UtilizarCredito", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@MontoUtilizar", montoUtilizar);
                cmd.Parameters.AddWithValue("@FechaUtilizado", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("idNotaCredito", idNotaCredito);
                cmd.Parameters.AddWithValue("@codVentaUtilizado", codVenta);


                cmd.ExecuteScalar();

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
            return xRet;
        }

        /// <summary>
        /// Permite obtener el credito utilizado para un venta
        /// </summary>
        /// <param name="codVenta"></param>
        /// <returns></returns>
        public E_NotaCredito getOneCreditoUtilizado(Int64 codVenta)
        {
            E_NotaCredito oNotaCredito = new E_NotaCredito();
            try
            {


                cn.Open();
                cmd = new SqlCommand("getOneCreditoUtilizado", cn);
                cmd.CommandType = CommandType.Text;

                cmd.Parameters.AddWithValue("@codVentaUtilizado", codVenta);


                SqlDataReader oReader = cmd.ExecuteReader();



                while (oReader.Read())
                {

                    oNotaCredito.idNotaCredito = Convert.ToInt64(oReader["idNotaCredito"]);
                    oNotaCredito.fecha = Convert.ToDateTime(oReader["fechaAlta"]);
                    oNotaCredito.monto = Convert.ToDecimal(oReader["monto"]);
                    oNotaCredito.idCliente = Convert.ToInt64(oReader["idCliente"]);
                    //oNotaCredito.fechaUtilizado = 
                    if (oReader["fechaUtilizado"] == DBNull.Value)
                    {
                        oNotaCredito.utilizado = false;


                    }
                    else
                    {
                        oNotaCredito.fechaUtilizado = Convert.ToDateTime(oReader["fechaUtilizado"]);
                        oNotaCredito.montoUtilizado = Convert.ToDecimal(oReader["montoUtilizado"]);
                    }

                 }

            }
            catch (Exception e)
            {
                xRet = e.Message;
                oNotaCredito = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }

            return oNotaCredito;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;


namespace Datos
{
    public class BD_Cliente
    {
         SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
        SqlCommand cmd;
        string xRet;
        ///<summary>
        /// Metodo para agregar un cliente a la base de datos Pintureria 
        ///</summary>
        ///<returns>
        /// Devuelve NULL si se agrego con exito el cliente de los contrario devuelve el mensaje del error 
        ///</returns>
        public String add_Cliente(E_Cliente cliente)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("addCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", cliente.descripcion);
                cmd.Parameters.AddWithValue("@dni", cliente.dni);
                cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                cmd.Parameters.AddWithValue("@idLocalidad", cliente.localidad.idLocalidad);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
                cmd.Parameters.AddWithValue("@boletin", cliente.boletinProtec);
                cmd.Parameters.AddWithValue("@mail", cliente.mail);
                cmd.Parameters.AddWithValue("@observacion", cliente.observacion);
               
                if (cliente.fecNac != null)
                {
                    cmd.Parameters.AddWithValue("@fecNac", cliente.fecNac);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@fecNac", DBNull.Value);
                }

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
                xRet = "0";
            }

            return xRet;
        }//addCliente 
        /// <summary>
        /// Devuelve todos los clientes de la base de datos 
        /// si se la coleccion de clientes devuelve NULL
        /// no se puedo realizar la consulta
        /// </summary>
        /// <returns></returns>
        public List<E_Cliente> getAll_Clientes( string filtro)
        {
            List<E_Cliente> clientes = new List<E_Cliente>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllClientes", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("filtro", filtro);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Cliente cliente = new E_Cliente();

                    cliente.idCliente = Convert.ToInt64(oReader["idCliente"]);
                    cliente.direccion = oReader["Direccion"].ToString();
                    cliente.descripcion = oReader["Descripcion"].ToString();
                    cliente.dni = Convert.ToInt32(oReader["Dni"]);
                    cliente.localidad.idLocalidad = Convert.ToInt64(oReader["idLocalidad"]);
                    cliente.localidad.nombre = oReader["Localidad"].ToString();
                    cliente.telefono = oReader["Telefono"].ToString();
                    cliente.boletinProtec =   Convert.ToBoolean(oReader["BoletinProtec"]);
                    if (oReader["FecNac"] != DBNull.Value)
                    {
                        cliente.fecNac = Convert.ToDateTime(oReader["FecNac"]);
                    }

                   
                    clientes.Add(cliente);
                }

            }
            catch (Exception)
            {
                clientes = null;

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return clientes;
        }//getAll_Clientes
        /// <summary>
        /// modificar un cliente de la base de datos 
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public string set_Cliente(E_Cliente cliente)
        {
            string xRet = "0";
            try
            {
                cn.Open();
                cmd = new SqlCommand("setCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", cliente.idCliente);
                cmd.Parameters.AddWithValue("@descripcion", cliente.descripcion);
                cmd.Parameters.AddWithValue("@dni", cliente.dni);
                cmd.Parameters.AddWithValue("@direccion", cliente.direccion);
                cmd.Parameters.AddWithValue("@idLocalidad", cliente.localidad.idLocalidad);
                cmd.Parameters.AddWithValue("@telefono", cliente.telefono);
                cmd.Parameters.AddWithValue("@mail", cliente.mail);
                cmd.Parameters.AddWithValue("@observacion", cliente.observacion);
				cmd.Parameters.AddWithValue("@boletin", cliente.boletinProtec);

                if (cliente.fecNac != null)
                {
                    cmd.Parameters.AddWithValue("@fecNac", cliente.fecNac);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@fecNac", DBNull.Value);
                }
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
        /// <summary>
        /// Eliminar un cliente parametro el idCliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string delete_Cliente(Int64 id)
        {
			string xRet = "0";
            try
            {
                cn.Open();
                cmd = new SqlCommand("deleteCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", id);
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
        }//delete_Cliente
        /// <summary>
        /// Devuelve un cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public E_Cliente getOne_Cliente(Int64 idCliente)
        {
			E_Cliente cliente = null;
            try
            {
                cn.Open();
                cmd = new SqlCommand("getOneCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idCliente", idCliente);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read()){
				cliente = new E_Cliente();
                cliente.idCliente = Convert.ToInt64(oReader["idCliente"]);
                cliente.direccion = oReader["Direccion"].ToString();
                cliente.descripcion = oReader["Descripcion"].ToString();
                cliente.dni = Convert.ToInt32(oReader["Dni"]);
                cliente.localidad.idLocalidad = Convert.ToInt64(oReader["idLocalidad"]);
                cliente.localidad.nombre = oReader["Localidad"].ToString();
                cliente.telefono = oReader["Telefono"].ToString();
                cliente.boletinProtec = Convert.ToBoolean(oReader["BoletinProtec"]);
                if (oReader["FecNac"] != DBNull.Value)
                {
                    cliente.fecNac = Convert.ToDateTime(oReader["FecNac"]);
                }
                cliente.observacion = oReader["observacion"].ToString();
                cliente.mail = oReader["Mail"].ToString();
                cliente.localidad.provincia.IdProvincia = Convert.ToInt16(oReader["idProvincia"]);
                }   
            }
            catch (Exception )
            {
                cliente = null;
               

            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return cliente;
        }//getOneCliente
		public List<E_CtaCorriente> getAll_CtaCorriente(string filtro, DateTime fecDesde, DateTime fecHasta)
		{
			List<E_CtaCorriente> listCtaCorriente = new List<E_CtaCorriente>();
			try
			{
				cn.Open();
				cmd = new SqlCommand("getAllCtaCorriente", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("filtro", filtro);
				cmd.Parameters.AddWithValue("fecDesde", fecDesde);
				cmd.Parameters.AddWithValue("fecHasta", fecHasta);
				SqlDataReader oReader = cmd.ExecuteReader();

				while (oReader.Read()){
					
					E_CtaCorriente ctaCorriente = new E_CtaCorriente();
					ctaCorriente.cliente.idCliente = Convert.ToInt64(oReader["idCliente"]);
					ctaCorriente.cliente.descripcion = oReader["Descripcion"].ToString();
					ctaCorriente.cliente.dni = Convert.ToInt32(oReader["dni"]);
					if (oReader["ventasPendientes"] != DBNull.Value) ctaCorriente.ventasPendientes = Convert.ToInt32(oReader["ventasPendientes"]);
					ctaCorriente.saldoDeudor = Convert.ToDecimal(oReader["SaldoDeudor"]);
				

					listCtaCorriente.Add(ctaCorriente);
				}

			}
			catch (Exception)
			{
				listCtaCorriente = null;

			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}
			return listCtaCorriente;
		}//getAll_Clientes
		public List<E_Venta> getOne_ResumenCta(Int64 idCliente, string filtro)
		{
			List<E_Venta> listVentas = new List<E_Venta>();
			try
			{	
				cn.Open();
				cmd = new SqlCommand("getOneResumenCta", cn);
				cmd.CommandType = CommandType.StoredProcedure;
				cmd.Parameters.AddWithValue("@idCliente", idCliente);
				cmd.Parameters.AddWithValue("@filtro", filtro);
				SqlDataReader oReader = cmd.ExecuteReader();

				while (oReader.Read())
				{
					E_Venta venta = new E_Venta();
					venta.codVenta = Convert.ToInt64(oReader["codVenta"]);
					venta.fecha = Convert.ToDateTime(oReader["fecVenta"]);
					venta.cantidadArt = Convert.ToInt32(oReader["cantidadArt"]);
					venta.precioTotal = Convert.ToDecimal(oReader["precioTotal"]);
					venta.abonado = Convert.ToDecimal(oReader["entrega"]);

					listVentas.Add(venta);
				}
			

			}
			catch (Exception)
			{
				listVentas = null;


			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}
			return listVentas;
		}//getOneCliente
		public Int64 ultCliente_Cliente()
		{
			Int64 idCliente;
			try
			{
				cn.Open();
				cmd = new SqlCommand("SELECT MAX(Clientes.idCliente) FROM Clientes WHERE idCliente<>1", cn);
				cmd.CommandType = CommandType.Text;

				idCliente = Convert.ToInt64(cmd.ExecuteScalar());

				
			}
			catch (Exception)
			{
				idCliente=0;
			}
			finally
			{
				if (cn.State == ConnectionState.Open)
				{
					cn.Close();
				}
			}
			return idCliente;
		}

    }//Class BD_Cliente
}//namespace Datos

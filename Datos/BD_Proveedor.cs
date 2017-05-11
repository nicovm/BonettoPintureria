using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using System.Data;
using System.Data.SqlClient;
namespace Datos
{
    public class BD_Proveedor
    {
        SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
        SqlCommand cmd;

        string xRet = "0";
        public string add_Proveedor(E_Proveedor proveedor)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("addProveedores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@raSocial", proveedor.raSocial);
                cmd.Parameters.AddWithValue("@cuit", proveedor.cuit);
                cmd.Parameters.AddWithValue("@idLocalidad", proveedor.localidad.idLocalidad);
                cmd.Parameters.AddWithValue("@detalle", proveedor.detalle);
                cmd.Parameters.AddWithValue("@telefono", proveedor.telefono);
                if (proveedor.fecReg != null) 
                {
                    cmd.Parameters.AddWithValue("@fecReg", proveedor.fecReg);
                }
                else// si la fecha esta vacia se agrega null en la base de datos
                {
                    cmd.Parameters.AddWithValue("@fecReg", DBNull.Value);
                }
                cmd.Parameters.AddWithValue("@Mail", proveedor.mail);

                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                xRet = e.Message;
            }
            return xRet;
        }
        public string set_Proveedor(E_Proveedor proveedor)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("setProveedores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@raSocial", proveedor.raSocial);
                cmd.Parameters.AddWithValue("@idProveedor", proveedor.idProveedor);
                cmd.Parameters.AddWithValue("@cuit", proveedor.cuit);
                cmd.Parameters.AddWithValue("@idLocalidad", proveedor.localidad.idLocalidad);
                cmd.Parameters.AddWithValue("@detalle", proveedor.detalle);
                cmd.Parameters.AddWithValue("@telefono", proveedor.telefono);
                cmd.Parameters.AddWithValue("@fecReg", proveedor.fecReg);
                cmd.Parameters.AddWithValue("@mail", proveedor.mail);
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
        public string delete_Proveedor(Int64 idProveedor)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("deleteProveedores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
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
        public List<E_Proveedor> getAll_Proveedor(string filtro)
        {
            List<E_Proveedor> proveedores = new List<E_Proveedor>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllProveedores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filtro", filtro);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Proveedor proveedor = new E_Proveedor();

                    proveedor.idProveedor = Convert.ToInt64(oReader["idProveedor"]);
                    proveedor.raSocial = oReader["RaSocial"].ToString();
                    proveedor.cuit = oReader["CUIT"].ToString();
                    proveedor.localidad.idLocalidad = Convert.ToInt64(oReader["idLocalidad"]);
                    proveedor.localidad.nombre = oReader["Localidad"].ToString();
                    proveedor.detalle = oReader["Detalle"].ToString();
                    proveedor.telefono = oReader["Telefono"].ToString();
                    proveedor.fecReg = Convert.ToDateTime(oReader["FecReg"]);
                    proveedor.mail = oReader["Mail"].ToString();
                    proveedores.Add(proveedor);
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


            return proveedores;
        }
        public E_Proveedor getOne_Proveedor(Int64 idProveedor)
        {
			E_Proveedor Proveedor = null;
            try
            {
                cn.Open();
                cmd = new SqlCommand("getOneProveedores", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProveedor", idProveedor);
                SqlDataReader oReader = cmd.ExecuteReader();

				
                while (oReader.Read())
                {
					Proveedor = new E_Proveedor();
                    Proveedor.idProveedor = Convert.ToInt64(oReader["idProveedor"]);
                  
                    Proveedor.raSocial = oReader["RaSocial"].ToString();
                    Proveedor.cuit = Convert.ToString(oReader["CUIT"]);
                    Proveedor.localidad.idLocalidad = Convert.ToInt64(oReader["idLocalidad"]);
                    Proveedor.localidad.nombre = oReader["Localidad"].ToString();
                    Proveedor.telefono = oReader["Telefono"].ToString();
                    
                    if (oReader["FecReg"] != DBNull.Value)
                    {
                       Proveedor.fecReg = Convert.ToDateTime(oReader["FecReg"]);
                    }
                    Proveedor.detalle = oReader["Detalle"].ToString();
                    Proveedor.mail = oReader["Mail"].ToString();
                    Proveedor.localidad.provincia.IdProvincia = Convert.ToInt16(oReader["idProvincia"]);
                }
            }
            catch (Exception)
            {
                Proveedor = null;


            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }
            return Proveedor;
        }//getOneClien


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
   public class BD_Vendedor
    {
        private SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
        private SqlCommand cmd;
        
       string xRet = "0";


        public string add_Vendedor(E_Vendedor vendedor)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("addVendedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", vendedor.nombre);
                cmd.Parameters.AddWithValue("@direccion", vendedor.direccion);
                cmd.Parameters.AddWithValue("@idLocalidad", vendedor.localidad.idLocalidad);
                cmd.Parameters.AddWithValue("@observacion", vendedor.obaservacion);
                if (vendedor.fecNac != null)
                {
                    cmd.Parameters.AddWithValue("@fecNac", vendedor.fecNac);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@fecNac", DBNull.Value);
                }
                cmd.Parameters.AddWithValue("@baja", vendedor.baja);
                cmd.Parameters.AddWithValue("@telefono ", vendedor.telefono);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                xRet = e.Message;
            }
            return xRet;
        }

        public string set_Vendedor(E_Vendedor vendedor)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("setVendedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idVendedor", vendedor.idVendedor);
                cmd.Parameters.AddWithValue("@nombre", vendedor.nombre);
                cmd.Parameters.AddWithValue("@direccion", vendedor.direccion);
                cmd.Parameters.AddWithValue("@idLocalidad", vendedor.localidad.idLocalidad);
                cmd.Parameters.AddWithValue("@observacion", vendedor.obaservacion);
				if (vendedor.fecNac != null) cmd.Parameters.AddWithValue("@fecNac", vendedor.fecNac);
				else cmd.Parameters.AddWithValue("@fecNac", DBNull.Value);
               
                cmd.Parameters.AddWithValue("@baja", vendedor.baja);
                cmd.Parameters.AddWithValue("@telefono", vendedor.telefono);
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

        public string delete_Vendedor(Int64 idVendedor)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("deleteMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idVendedor", idVendedor);
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

        public List<E_Vendedor> getAll_Vendedor(string filtro)
        {
            List<E_Vendedor> vendedores = new List<E_Vendedor>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllVendedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filtro", filtro);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Vendedor vendedor = new E_Vendedor();

                    vendedor.idVendedor = Convert.ToInt64(oReader["idVendedor"]);
                    vendedor.nombre = oReader["nombre"].ToString();
                    vendedor.localidad.nombre = oReader["Localidad"].ToString();
                    vendedor.telefono = oReader["telefono"].ToString();

                    vendedores.Add(vendedor);
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


            return vendedores;
        }

        public E_Vendedor getOne_Vendedor(Int64 idVendedor)
        {
            E_Vendedor vendedor = new E_Vendedor();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getOneVendedor", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idVendedor", idVendedor);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                   

                    vendedor.idVendedor = Convert.ToInt64(oReader["idVendedor"]);
                    vendedor.nombre = oReader["nombre"].ToString();
                    vendedor.direccion = oReader["direccion"].ToString();
                    vendedor.localidad.idLocalidad = Convert.ToInt64(oReader["idLocalidad"]);
                    vendedor.obaservacion = oReader["observacion"].ToString();
                    vendedor.telefono = oReader["telefono"].ToString();
                    vendedor.baja = Convert.ToBoolean(oReader["Baja"]);
                    vendedor.localidad.provincia.IdProvincia = Convert.ToInt16(oReader["idProvincia"]);
                    if (oReader["FecNac"] != DBNull.Value)
                    {
                        vendedor.fecNac = Convert.ToDateTime(oReader["FecNac"]);
                    }

               
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


            return vendedor;
        }

    }
}

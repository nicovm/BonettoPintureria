using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class BD_Unidad
    {
        private SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
        private SqlCommand cmd;
        private string xRet = "0";

        public string add_Unidad(E_Unidad unidad)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("addUnidad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", unidad.nombre);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                xRet = e.Message;
            }
            return xRet;
        }

        public string set_Unidad(E_Unidad unidad)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("setUnidad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", unidad.nombre);
                cmd.Parameters.AddWithValue("@idUnidad", unidad.idUnidad);
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

        public string delete_Unidad(Int64 idUnidad)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("deleteUnidad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUnidad", idUnidad);
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

        public List<E_Unidad> getAll_Unidades(string filtro)
        {
            List<E_Unidad> unidads = new List<E_Unidad>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllUnidad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filtro", filtro);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Unidad unidad = new E_Unidad();

                    unidad.idUnidad = Convert.ToInt64(oReader["idUnidad"]);
                    unidad.nombre = oReader["nombre"].ToString();

                    unidads.Add(unidad);
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


            return unidads;
        }
    }
}

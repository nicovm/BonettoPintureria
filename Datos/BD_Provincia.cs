using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class BD_Provincia
    {
        private SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
        private SqlCommand cmd;
        private string xRet = "0";

        /// <summary>
        /// Metodo para agregar una provincia
        /// </summary>
        /// <returns></returns>
        public string add_Provincia(E_Provincia provincia)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("addProvincia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", provincia.nombre);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                xRet = e.Message;
            }
            return xRet;
        }
        /// <summary>
        /// Modificar los una provincia en la base de datos
        /// </summary>
        /// <param name="provincia"></param>
        /// <returns></returns>
        public string set_Provincia(E_Provincia provincia)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("setProvincia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProvincia", provincia.IdProvincia);
                cmd.Parameters.AddWithValue("@nombre", provincia.nombre);
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
        /// Eliminar una Provincia en la base de datos
        /// </summary>
        /// <param name="idPro"></param>
        /// <returns></returns>
        public string delete_Provincia(Int64 idPro)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("deleteProvincia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idProvincia", idPro);
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
        /// Devuelve todas las provincias
        /// </summary>
        /// <returns></returns>
        public List<E_Provincia> getAll_Provincias()
        {
            List<E_Provincia> provincias = new List<E_Provincia>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllProvincia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Provincia provincia = new E_Provincia();

                    provincia.IdProvincia = Convert.ToInt16(oReader["idProvincia"]);
                    provincia.nombre = oReader["nombre"].ToString();

                    provincias.Add(provincia);
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


            return provincias;
        }
        /// <summary>
        /// Devuelve una provincia de la base de datos
        /// </summary>
        /// <param name="idProvincia">
        /// solicita el id de la provincia para la busqueda
        /// </param>
        /// <returns></returns>
        public E_Provincia getOne_Provincia(Int64 idProvincia)
        {
            E_Provincia provincia = new E_Provincia();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getOneProvincia", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader oReader = cmd.ExecuteReader();


                provincia.IdProvincia = Convert.ToInt16(oReader["idProvincia"]);
                provincia.nombre = oReader["nombre"].ToString();

            }
            catch (Exception)
            {
                provincia = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }


            return provincia;
        }
    }
}

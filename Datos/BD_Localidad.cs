using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    public class BD_Localidad
    {
        private SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
        private SqlCommand cmd;
        private string xRet = "0";
        /// <summary>
        /// Metodo para agregar una localidad
        /// </summary>
        /// <returns></returns>
        public Int16 add_Localidad(E_Localidad localidad)
        {
			Int16 idLocalidad;
            try
            {
                cn.Open();
                cmd = new SqlCommand("addLocalidad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", localidad.nombre);
                cmd.Parameters.AddWithValue("@idProvincia", localidad.provincia.IdProvincia);
                cmd.Parameters.AddWithValue("@codPostal", localidad.codPostal);
                idLocalidad = Convert.ToInt16(cmd.ExecuteScalar());

            }
            catch (Exception e)
            {
               idLocalidad = 0;
            }
            return idLocalidad;
        }
        /// <summary>
        /// Modificar una localidad en la base de datos
        /// </summary>
        /// <param name="provincia"></param>
        /// <returns></returns>
        public Int16 set_Localidad(E_Localidad localidad)
        {
			Int16 idLocalidad = 0;
            try
            {
                cn.Open();
                cmd = new SqlCommand("setLocalidad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idLocalidad", localidad.idLocalidad);
                cmd.Parameters.AddWithValue("@nombre", localidad.nombre);
                cmd.Parameters.AddWithValue("@idProvincia", localidad.provincia.IdProvincia);
                cmd.Parameters.AddWithValue("@codPostal", localidad.codPostal);
                idLocalidad = Convert.ToInt16(cmd.ExecuteScalar());

            }
            catch (Exception)
            {
                idLocalidad = 0;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }


            return idLocalidad;
        }
        /// <summary>
        /// Eliminar una Provincia en la base de datos
        /// </summary>
        /// <param name="idLocalidad"></param>
        /// <returns></returns>
        public string delete_Localidad(Int64 idLocalidad)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("deleteLocalidad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idLocalidad", idLocalidad);
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
        public List<E_Localidad> getAll_Localidad( Int16 idProvincia)
        {
            List<E_Localidad> localidades = new List<E_Localidad>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllLocalidad", cn);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@idProvincia", idProvincia);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Localidad localidad = new E_Localidad();

                    localidad.idLocalidad = Convert.ToInt64(oReader["idLocalidad"]);
                    localidad.provincia.IdProvincia = Convert.ToInt16(oReader["idProvincia"]);
                   // localidad.provincia.nombre = oReader["Provincia"].ToString();
                    localidad.nombre = oReader["nombre"].ToString();

                    localidades.Add(localidad);
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


            return localidades;
        }
        /// <summary>
        /// Devuelve una localidad de la base de datos
        /// </summary>
        /// <param name="idProvincia">
        /// solicita el id de la localidad para la busqueda
        /// </param>
        /// <returns></returns>
        public E_Localidad getOne_Localidad(Int64 idProvincia)
        {
            E_Localidad localidad = new E_Localidad();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getOneLocalidad", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                SqlDataReader oReader = cmd.ExecuteReader();

                localidad.provincia.nombre = oReader["Provincia"].ToString();
                localidad.provincia.IdProvincia = Convert.ToInt16(oReader["idProvincia"]);
                localidad.nombre = oReader["nombre"].ToString();
                localidad.idLocalidad = Convert.ToInt64(oReader["idLocalidad"]);

            }
            catch (Exception)
            {
                localidad = null;
            }
            finally
            {
                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }

            }


            return localidad;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class BD_Marca
    {
        private SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
        private SqlCommand cmd;
        private string xRet = "0";

        public string add_Marca(E_Marca marca)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("addMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", marca.nombre);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                xRet = e.Message;
            }
            return xRet;
        }
        
        public string set_Marca(E_Marca marca)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("setMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", marca.nombre);
                cmd.Parameters.AddWithValue("@idMarca", marca.idMarca);
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

        public string delete_Marca(Int64 idMarca)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("deleteMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idMarca", idMarca);
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

        public List<E_Marca> getAll_Marcas( string filtro)
        {
            List<E_Marca> marcas = new List<E_Marca>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filtro", filtro);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Marca marca = new E_Marca();

                    marca.idMarca = Convert.ToInt64(oReader["idMarca"]);
                    marca.nombre = oReader["nombre"].ToString();

                    marcas.Add(marca);
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


            return marcas;
        }
    }
}

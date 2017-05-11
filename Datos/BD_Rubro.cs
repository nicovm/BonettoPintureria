using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class BD_Rubro
    {
        private SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
        private SqlCommand cmd;
        private string xRet = "0";

        public string add_Rubro(E_Rubro rubro)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("addRubro", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", rubro.nombre);
               
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                xRet = e.Message;
            }
            return xRet;
        }

        public string set_Rubro(E_Rubro rubro)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("setRubro", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", rubro.nombre);
                cmd.Parameters.AddWithValue("@idRubro", rubro.idRubro);
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

        public string delete_Rubro(Int64 idRubro)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("deleteRubro", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRubro", idRubro);
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

        public List<E_Rubro> getAll_Rubros( string filtro)
        {
            List<E_Rubro> rubros = new List<E_Rubro>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllRubro", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filtro", filtro);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Rubro rubro = new E_Rubro();

                    rubro.idRubro = Convert.ToInt64(oReader["idRubro"]);
                    rubro.nombre = oReader["nombre"].ToString();

                    rubros.Add(rubro);
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

            return rubros;
        }
    }
}

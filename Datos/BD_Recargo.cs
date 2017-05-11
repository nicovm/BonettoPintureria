using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;

namespace Datos
{
    public class BD_Recargo
    {
        private SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
        private SqlCommand cmd;
        private string xRet = "0";
        
        public string add_Recargo(E_Recargo recargo)
        {

            try
            {
                cn.Open();
                cmd = new SqlCommand("addRecargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", recargo.descripcion);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                xRet = e.Message;
            }
            return xRet;
        }

        public string set_Recargo(E_Recargo recargo)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("setRecargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", recargo.descripcion);
                cmd.Parameters.AddWithValue("@idRecargo", recargo.idRecargo);
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

        public string delete_Recargo(Int64 idRecargo)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("deleteRecargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idRecargo", idRecargo);
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

        public List<E_Recargo> getAll_Recargo(string filtro)
        {
            List<E_Recargo> recargos = new List<E_Recargo>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllRecargo", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filtro", filtro);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Recargo recargo = new E_Recargo();

                    recargo.idRecargo = Convert.ToInt64(oReader["idRecargo"]);
                    recargo.descripcion = oReader["descripcion"].ToString();

                    recargos.Add(recargo);
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


            return recargos;
        }
    }
}

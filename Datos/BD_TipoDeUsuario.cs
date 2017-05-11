using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class BD_TipoDeUsuario
    {
        private SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
        private SqlCommand cmd;
        private string xRet = "0";

        public string add_TipoDeUsuario(E_TipoDeUsuario TipoDeUsuario)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("addTipoDeUuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", TipoDeUsuario.nombre);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                xRet = e.Message;
            }
            return xRet;
        }

        public string set_TipoDeUsuario(E_TipoDeUsuario TipoDeUsuario)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("setMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", TipoDeUsuario.nombre);
                //cmd.Parameters.AddWithValue("@idMarca", TipoDeUsuario.idMarca);
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

        public string delete_TipoDeUsuario(Int64 idMarca)
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

        public List<E_TipoDeUsuario> getAll_TipoDeUsuario(string filtro)
        {
            List<E_TipoDeUsuario> TipoDeUsuarios = new List<E_TipoDeUsuario>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllMarca", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filtro", filtro);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_TipoDeUsuario TipoDeUsuario = new E_TipoDeUsuario();

                    //TipoDeUsuario.idMarca = Convert.ToInt64(oReader["idMarca"]);
                    TipoDeUsuario.nombre = oReader["nombre"].ToString();

                    TipoDeUsuarios.Add(TipoDeUsuario);
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


            return TipoDeUsuarios;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;



namespace Datos
{
    public class BD_Descuento
    {
        private SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
        private SqlCommand cmd;
        private string xRet = "0";
        public string add_Descuento(E_Descuento descuento)
        {
            
            try
            {
                cn.Open();
                cmd = new SqlCommand("addDescuento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", descuento.descripcion);
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                xRet = e.Message;
            }
            return xRet;
        }

        public string set_Descuento(E_Descuento descuento)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("setDescuento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@descripcion", descuento.descripcion);
                cmd.Parameters.AddWithValue("@idDescuento", descuento.idDescuento);
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

        public string delete_Descuento(Int64 idDescuento)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("deleteDescuento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idDescuento", idDescuento);
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

        public List<E_Descuento> getAll_Descuento(string filtro)
        {
            List<E_Descuento> descuentos = new List<E_Descuento>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllDescuento", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filtro", filtro);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Descuento descuento = new E_Descuento();

                    descuento.idDescuento = Convert.ToInt64(oReader["idDescuento"]);
                    descuento.descripcion = oReader["descripcion"].ToString();

                    descuentos.Add(descuento);
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


            return descuentos;
        }
    }
}

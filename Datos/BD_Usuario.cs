using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using Entidades;
namespace Datos
{
    public class BD_Usuario
    {
        private SqlConnection cn = new SqlConnection(Conexion.get_StringConexion());
        private SqlCommand cmd;
        private string xRet = "0";

        public string add_Usuario(E_Usuario usuario)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("addUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                cmd.Parameters.AddWithValue("@contrasenia", usuario.contrasenia);
                cmd.Parameters.AddWithValue("@idTipoDeUsuario", usuario.tipoDeUsuario.idTipoDeUsuario);
                
                cmd.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                xRet = e.Message;
            }
            return xRet;
        }

        public string set_Usuario(E_Usuario usuario)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("setUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idUsuario", usuario.idUsuario);
                cmd.Parameters.AddWithValue("@nombre", usuario.nombre);
                cmd.Parameters.AddWithValue("@contrasenia", usuario.contrasenia);
                cmd.Parameters.AddWithValue("idTipoDeUsuario", usuario.tipoDeUsuario.idTipoDeUsuario);


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

        public string delete_Usuario(Int64 idUsuario)
        {
            try
            {
                cn.Open();
                cmd = new SqlCommand("deleteUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
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

        public List<E_Usuario> getAll_Usuario(string filtro)
        {
            List<E_Usuario> usuarios = new List<E_Usuario>();
            try
            {
                cn.Open();
                cmd = new SqlCommand("getAllUsuario", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@filtro", filtro);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
                    E_Usuario usuario = new E_Usuario();

                    usuario.idUsuario = Convert.ToInt64(oReader["idUsuario"]);
                    usuario.nombre = oReader["nombre"].ToString();

                    usuarios.Add(usuario);
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


            return usuarios;
        }

		public E_Usuario get_Usuario(Int64 idUsuario)
		{
			E_Usuario oUsuario = null;
			try
			{
				cn.Open();
				cmd = new SqlCommand("SELECT * FROM Usuarios WHERE idUsuario=@idUsuario", cn);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
				SqlDataReader oReader = cmd.ExecuteReader();
				while (oReader.Read())
				{
					oUsuario.nombre = oReader["nombre"].ToString();
					oUsuario.contrasenia = oReader["contrasenia"].ToString();

					return oUsuario;
				}
				return oUsuario;
			}
			catch (Exception)
			{
				return oUsuario;
			}

		}

		public E_Usuario iniciarSesion_Usuario(string usuario, string contrasenia)
		{
			E_Usuario oUsuarioSesion = null;
			try
			{
				cn.Open();
				cmd = new SqlCommand("SELECT * FROM Usuarios WHERE Nombre=@Nombre COLLATE SQL_Latin1_General_CP1_CS_AS and Contrasenia =@Contrasenia COLLATE SQL_Latin1_General_CP1_CS_AS", cn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@nombre", usuario);
				cmd.Parameters.AddWithValue("@Contrasenia", contrasenia);
                SqlDataReader oReader = cmd.ExecuteReader();

                while (oReader.Read())
                {
					oUsuarioSesion = new E_Usuario();
					oUsuarioSesion.nombre = oReader["nombre"].ToString();
					oUsuarioSesion.idUsuario = Convert.ToInt64(oReader["idUsuario"]);
					oUsuarioSesion.contrasenia = oReader["contrasenia"].ToString();


                    return oUsuarioSesion;
                }
				return oUsuarioSesion;
			}
			catch (Exception e)
			{
				return null;
				
			}

		}

		public Boolean setContrasenia_Usuario(string contrasenia, Int64 idUsuario)
		{
			try
			{
				cn.Open();
				cmd = new SqlCommand("UPDATE Usuarios SET contrasenia=@contrasenia WHERE idUsuario=@idUsuario", cn);
				cmd.CommandType = CommandType.Text;
				cmd.Parameters.AddWithValue("@contrasenia", contrasenia);
				cmd.Parameters.AddWithValue("@idUsuario", idUsuario);
				 cmd.ExecuteScalar();
				return false;
			}
			catch (Exception e)
			{
				return false;

			}
		}

    }
}

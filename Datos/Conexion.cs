using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace Datos
{
    static class Conexion
    {

        /// <summary>
        /// Metodo que devuelde el string de conexion de la base de datos pintureria
        /// </summary>
        public static String get_StringConexion()
        {
            string coneccion = null;
            if (System.Environment.MachineName == "GERA-PC")
            {
                 coneccion = ConfigurationManager.ConnectionStrings["gera"].ConnectionString;
            }
            else if (System.Environment.MachineName == "BRINGA-PC")
            {
                 coneccion = ConfigurationManager.ConnectionStrings["nico"].ConnectionString;
            }
			else
			{
				coneccion = ConfigurationManager.ConnectionStrings["default"].ConnectionString;
			}
            
            //string a = "19";
            
            return coneccion;
        }
    }
}

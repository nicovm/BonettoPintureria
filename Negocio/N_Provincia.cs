using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;

namespace Negocio
{
    public class N_Provincia
    {
        /// <summary>
        /// Devuelve todas las provinica
        /// Devuelve NULL si no devuelve ninguna provincia
        /// </summary>
        /// <returns></returns>
        public List<E_Provincia> getAllProvincias()
        {
            List<E_Provincia> Provincias = new List<E_Provincia>();
            BD_Provincia bdProvincia = new BD_Provincia();
            Provincias = bdProvincia.getAll_Provincias();
            return Provincias;
        }
    }
}

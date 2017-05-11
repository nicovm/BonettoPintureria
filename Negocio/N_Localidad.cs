using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;

namespace Negocio
{
    public class N_Localidad
    {
        BD_Localidad bdLocalidad = new BD_Localidad();
        /// <summary>
        /// Devuelve todas las localidades
        /// devuelve NULL si no hay podido devolver las localidades
        /// </summary>
        /// <returns></returns>
        public List<E_Localidad> getAllLocalidades(Int16 idProvincia)
        {
            List<E_Localidad> localidades = new List<E_Localidad>();
            localidades = bdLocalidad.getAll_Localidad(idProvincia);
            return localidades;
        }
        public Int16 guardar( E_Localidad localidad)
        {
            if (localidad.idLocalidad == 0)
            {
                return bdLocalidad.add_Localidad(localidad);
            }
            else
            {
                return bdLocalidad.set_Localidad(localidad);
            }
        }
        public string delete(Int64 idLocalidad)
        {
            return bdLocalidad.delete_Localidad(idLocalidad);
        }
    }
}

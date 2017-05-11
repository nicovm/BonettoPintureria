using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
    public class N_Unidad
    {
        public List<E_Unidad> getAllUnidad(string filtro)
        {
            BD_Unidad bdUnidad = new BD_Unidad();
            return bdUnidad.getAll_Unidades(filtro);
        }
    }
}

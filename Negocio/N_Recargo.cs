using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
    public class N_Recargo
    {
        public List<E_Recargo> getAllRecargo(string filtro)
        {
            BD_Recargo bdRecargo = new BD_Recargo();
            return bdRecargo.getAll_Recargo(filtro);
        }
    }
}

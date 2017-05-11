using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
    public class N_Descuento
    {
        public List<E_Descuento> getAllDescuentos(string filtro)
        {
            BD_Descuento bdDescuento = new BD_Descuento();
            return bdDescuento.getAll_Descuento(filtro);
        }
    }
}

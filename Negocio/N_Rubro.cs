using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
    public class N_Rubro
    {
        BD_Rubro bdRubro = new BD_Rubro();

        public List<E_Rubro> getAllRubros(string filtro)
        {
            return bdRubro.getAll_Rubros(filtro);
        }

        public string guardar(E_Rubro rubro)
        {
            if (rubro.idRubro == 0)
            {
                return bdRubro.add_Rubro(rubro);
            }
            else
            {
                return bdRubro.set_Rubro(rubro);
            }
        }
        public string delete(Int64 idRubro)
        {
            return bdRubro.delete_Rubro(idRubro);
        }
       

    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades; 

namespace Negocio
{
    public class N_Proveedor
    {
        BD_Proveedor bdProve = new BD_Proveedor( );

        public string guardar(E_Proveedor proveedor)
        {
            string xRet="0";

            if (proveedor.idProveedor == 0) // si el id de cliente es igual a 0 creara un nuevo cliente  
            {
                xRet = bdProve.add_Proveedor(proveedor);
            }
            else // sino modificara un cliente existente
            {
                xRet = bdProve.set_Proveedor(proveedor);
            }

            return xRet;
        }
        public List<E_Proveedor> getAllProveedor(string filtro)
        {
            BD_Proveedor bdProve = new BD_Proveedor();
            return  bdProve.getAll_Proveedor(filtro);

        }

        public string delete(Int64 idProveedor)
        {
            return bdProve.delete_Proveedor(idProveedor);
        }

        public E_Proveedor getOne (Int64 idProveedor)
        {
            return bdProve.getOne_Proveedor(idProveedor);
        }
    }
}

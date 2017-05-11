using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;

namespace Negocio
{
  public  class N_Vendedor
    {
       
      BD_Vendedor bdVendedor = new BD_Vendedor();
       
      
      
      
      /// <summary>
        /// Devuelve todos los vendedores
        /// devuelve NULL si no hay podido devolver las localidades
        /// </summary>
        /// <returns></returns>
        /// 

        public List<E_Vendedor> getAll(string filtro)
        {
            List<E_Vendedor> Vendedores;

            Vendedores = bdVendedor.getAll_Vendedor(filtro);
            return Vendedores;
        }
     
        public string guardar(E_Vendedor Vendedor)
        {
            if (Vendedor.idVendedor == 0)
            {
                return bdVendedor.add_Vendedor(Vendedor);
            }
            else
            {
                return bdVendedor.set_Vendedor(Vendedor);
            }
        }
        public string delete(Int64 idVendedor)
        {
            return bdVendedor.delete_Vendedor(idVendedor);
        }

        public E_Vendedor getOne(Int64 idVendedor)
        {

          return  bdVendedor.getOne_Vendedor(idVendedor);

        }
        //public string deleteVendedor(Int64 idVendedor)
        //{
        //    return bdVendedor.delete_Vendedor(idVendedor);
        //}

    }
}

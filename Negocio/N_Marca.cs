using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;
namespace Negocio
{
    public class N_Marca
    {
        BD_Marca bdMarca = new BD_Marca();
       
        
        
        public List<E_Marca> getAllMarcas( string filtro)
        {
            return bdMarca.getAll_Marcas(filtro);
        }
        
        
        public string guardar(E_Marca marca)
        {
            //Agrega una nueva marca
            if (marca.idMarca == 0)
            {
                return bdMarca.add_Marca(marca);
            }
            else//modifica
            {
                return bdMarca.set_Marca(marca);
            }
        }
        public string delete(Int64 idMarca)
        {
            return bdMarca.delete_Marca(idMarca);
        }
        
    }
}

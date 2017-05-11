using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
    public class N_Articulo
    {
        BD_Articulo bdArticulo = new BD_Articulo();

        public List<E_Articulo> getAllArticulos(string filtro)
        {
            BD_Articulo bdArticulo = new BD_Articulo();

            return bdArticulo.getAll_Articulo(filtro);

        }
        public List<E_Articulo> getAllArticulosXcod(string filtro)
        {
            BD_Articulo bdArticulo = new BD_Articulo();

            return bdArticulo.getAll_ArticuloXcod(filtro);

        }
		//public string guardar( E_Articulo articulo)
		//{
		//    string xRet="0";
		//    BD_Articulo bdArticulo = new BD_Articulo();
		//    int count = bdArticulo.count_Articulo(articulo.codArticulo);

		//    if (count == 0) // si es 0 significa que hay agregar un nuevo articulo
		//    {
		//        xRet = bdArticulo.add_Articulo(articulo);
		//    }
		//    else if (count == 1) // si es 1 siginifica que es una modificacion
		//    {
		//        xRet = bdArticulo.set_Articulo(articulo);
		//    }
		//    else // se produjo un error;m
		//    {
		//        xRet = "Erro en el count";
		//    }
		//    return xRet;
		//}


		public string add(Entidades.E_Articulo oArticulo)
		{ 
			 BD_Articulo bdArticulo = new BD_Articulo();
			 return bdArticulo.add_Articulo(oArticulo);
		}
		public string set(Entidades.E_Articulo oArticulo, string codArticuloMod)
		{
			
			 BD_Articulo bdArticulo = new BD_Articulo();
			 return bdArticulo.set_Articulo(oArticulo, codArticuloMod);
		}

        public Boolean ExisteCodArticulo(string codArticulo)
        {
            BD_Articulo bdArticulo = new BD_Articulo();
            if (bdArticulo.count_Articulo(codArticulo) == 0) return false;
            return true;

        }
        public E_Articulo getOneArticulo(string codArticulo)
        {
           // BD_Articulo bdArticulo = new BD_Articulo();
            return bdArticulo.getOne_Articulo(codArticulo);
        }
        /// <summary>
        /// Devuelve TRUE Si el codigo del articulo esta en uso y FALSE si no esta en uso
        /// </summary>
        /// <param name="codArticulo"></param>
        public string deleteArticulo(string codArticulo)
        {
            return bdArticulo.delete_Articulo(codArticulo);
        }
		public List<E_Stock> getALLStockArticulo(string codArticulo)
		{
			return bdArticulo.getAll_StockArticulo(codArticulo);
		}

		/// <summary>
		/// Permite importar una lista de articulo(agregando los articulos y modificacion los articulos existentes)
		/// </summary>
		/// <param name="?"></param>
		/// <returns></returns>
		public List<E_Articulo> addImportArticulo(List<E_Articulo> listImportArticulo)
		{
			//Lista de articulo que produgieron error al agregarse
			List<E_Articulo> oListArticuloError = new List<E_Articulo>();
			//Recorro las lista de articulo que se quiere importar
			foreach (E_Articulo oArticuloImport in listImportArticulo)
			{
			

				E_Articulo oArticulo = bdArticulo.getOne_Articulo(oArticuloImport.codArticulo);

				if (oArticulo != null) //El articulo ya existe solo hay que modificarlo
				{
					oArticulo.detCondCosto = oArticuloImport.detCondCosto;
					oArticulo.precioFinal = oArticuloImport.precioFinal;
					oArticulo.iva = oArticuloImport.iva;
					oArticulo.ganancia = oArticuloImport.ganancia;
					oArticulo.precioLista = oArticuloImport.precioLista;

					//AModifico el producto

					if (bdArticulo.set_Articulo(oArticulo) != "0")
					{
						oListArticuloError.Add(oArticulo);
					}
				}
				else // El articulo no existe hay que agregarlo
				{
					oArticuloImport.fecCompra = DateTime.Now.Date;
					//Agrego el articulo

					if (bdArticulo.add_Articulo(oArticuloImport) != "0") //Surgio un error
					{
						oListArticuloError.Add(oArticuloImport);
					}
	
				}//Else

				
			}//for each

			return oListArticuloError.Count > 0 ? oListArticuloError : null;
		}
    }
}

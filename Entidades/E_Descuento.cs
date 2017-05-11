using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Descuento
    {
        private Int64 _idDescuento;
        private string _descripcion;

        public E_Descuento()
        {
           _idDescuento = 0;
          
        }
        public Int64 idDescuento { get { return _idDescuento; } set { _idDescuento = value; } }
        public string descripcion { get { return _descripcion; } set { _descripcion = value; } }
      
    }
}

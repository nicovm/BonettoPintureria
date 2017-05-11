using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Rubro
    {
        private Int64 _idRubro;
        private string _nombre;

        /// <summary>
        /// el id se crea en 0
        /// </summary>
        public E_Rubro()
        {
            _idRubro = 0;
        }
        public Int64 idRubro { get { return _idRubro; } set { _idRubro = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
    }
}

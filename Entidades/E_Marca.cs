using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Marca
    {
		public static Int64 TERSUAVE = 3;
		public static Int64 QUIMEX = 1;

        private Int64 _idMarca;
        private string _nombre;

        public E_Marca()
        {
            idMarca = 0;
        }
        public Int64 idMarca { get { return _idMarca; } set { _idMarca = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }


	
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Localidad
    {
        private Int64 _idLocalidad;
        private string _nombre;
        private Int64 _codPostal;
        private E_Provincia _provincia = new E_Provincia();

        public Int64 idLocalidad { get { return _idLocalidad; } set { _idLocalidad = value; } }
        public Int64 codPostal { get { return _codPostal; } set { _codPostal = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public E_Provincia provincia { get { return _provincia; } set { _provincia = value; } }
    }
}

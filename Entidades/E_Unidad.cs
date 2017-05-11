using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Unidad
    {
        private Int64 _idUnidad;
        private string _nombre;

        public E_Unidad()
        {
            _idUnidad = 0;
        }//constructor

        public Int64 idUnidad { get { return _idUnidad; } set { _idUnidad = value; } }
        public string nombre { get {return  _nombre; } set { _nombre = value;} }
    }
}

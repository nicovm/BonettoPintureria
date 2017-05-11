using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Provincia
    {
        private Int16 _idProvincia;
        private string _nombre;
        public Int16 IdProvincia { get { return _idProvincia; } set { _idProvincia = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
    }
}

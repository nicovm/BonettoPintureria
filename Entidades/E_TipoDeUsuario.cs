using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_TipoDeUsuario
    {
        private Int64 _idTipoDeUsuario;
        private string _nombre;

        public Int64 idTipoDeUsuario { get { return _idTipoDeUsuario; } set { _idTipoDeUsuario = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Usuario
    {
        private Int64 _idUsuario;
        private string _nombre;
        private E_TipoDeUsuario _tipoDeUsuario = new E_TipoDeUsuario();
        private string _contrsenia;

        public Int64 idUsuario { get { return _idUsuario; } set { _idUsuario = value; } }
        public string nombre { get { return _nombre; } set { _nombre = value; } }
        public E_TipoDeUsuario tipoDeUsuario { get { return _tipoDeUsuario; } set { _tipoDeUsuario = value; } }
        public string contrasenia { get { return _contrsenia; } set { _contrsenia = value; } }
    }
}

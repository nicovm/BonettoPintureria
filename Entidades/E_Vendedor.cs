using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Vendedor
    {
        private Int64 _idVendedor;
        private string _nombre;
        private string _direccion;
        private E_Localidad _localidad = new E_Localidad();
        private string _observacion;
        private DateTime? _fecNac;
        private Boolean _baja;
        private string _telefono;

        /// <summary>
        /// el id se crea en 0 fecNac = null y baja en false
        /// </summary>
        public E_Vendedor()
        {
            _idVendedor = 0;
            _fecNac = null;
            _baja = false;
        }

        public Int64 idVendedor { get { return _idVendedor; } set { _idVendedor = value; } }
        public string nombre  { get { return _nombre; } set { _nombre = value; } }
        public string direccion { get { return _direccion; } set { _direccion = value; } }
        public E_Localidad localidad { get { return _localidad; } set { _localidad = value; } }
        public string obaservacion { get { return _observacion; } set { _observacion = value; } }
        public DateTime? fecNac { get { return _fecNac; } set { _fecNac = value; } }
        public Boolean baja { get { return _baja; } set { _baja = value; } }
        public string telefono { get { return _telefono; } set { _telefono = value; } }
        public string nombreLocalidad { get { return _localidad.nombre; } } // devuelve un campo de un objeto

    }
}

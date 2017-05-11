using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Proveedor
    {
        private Int64 _idProveedor;
        private string _raSocial;
        private string _cuit;
        private E_Localidad _localidad;
        private string _detalle;
        private string _telefono;
        private DateTime? _fecReg;
        private string _mail;
        //Constructor
        public E_Proveedor()
        {
            _idProveedor = 0;
            _fecReg = null;
            _localidad = new E_Localidad();
        }

        public Int64 idProveedor { get { return _idProveedor; } set { _idProveedor = value; } }
        public string raSocial { get { return _raSocial; } set { _raSocial = value; } }
        public string cuit { get { return _cuit; } set { _cuit = value; } }
        public E_Localidad localidad { get { return _localidad; } set { _localidad = value; } }
        public string detalle { get { return _detalle; } set { _detalle = value; } }
        public string telefono { get { return _telefono; } set { _telefono = value; } }
        public DateTime? fecReg { get { return _fecReg; } set { _fecReg = value; } }
        public string mail { get { return _mail; } set { _mail = value; } }
        public string nombreLocalidad { get { return localidad.nombre; } }
    }
}

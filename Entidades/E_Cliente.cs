using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Cliente
    {
        private Int64 _idCliente;
        private string _descripcion;
        string _direccion;
        private Int32 _dni;
        private string _telefono;
        private DateTime? _fecNac;
        private E_Localidad _localidad = new E_Localidad();
        private Boolean _boletinProtec;
        private string _mail;
        private string _observacion;

        /// <summary>
        /// Contructor de Cliente
        /// </summary>
        public E_Cliente()
        {
             _idCliente = 0;
            _boletinProtec = false;
            _fecNac = null;
        }
        public DateTime? fecNac { get { return _fecNac; } set { _fecNac = value; } }
        public Int64 idCliente { set { _idCliente = value; } get { return _idCliente; } }
        public string descripcion { set { _descripcion = value; } get { return _descripcion; } }
        public string direccion { set { _direccion = value; } get { return _direccion; } }
        public Int32 dni { set { _dni = value; } get { return _dni; } }
        public string telefono { set { _telefono = value; } get { return _telefono; } }
        public E_Localidad localidad { set { _localidad = value; } get { return _localidad; } }
        public string nombreLocalidad { get { return _localidad.nombre; } }
        public Boolean boletinProtec { set { _boletinProtec = value; } get { return _boletinProtec; } }
        public string observacion { set { _observacion = value; } get { return _observacion; } }
        public string mail { set { _mail = value; } get { return _mail; } }

    }//class
 }//namespace

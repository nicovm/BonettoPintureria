using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Nota
    {
        private Int64 _idNota;
        private E_Vendedor _vendedor = new E_Vendedor();
        private string _descripcion;
        private DateTime? _fecha;
        
        /// <summary>
        /// el id se crea en 0
        /// </summary>
        public E_Nota()
        {
            _idNota = 0;
        }

        public Int64 idNota { get { return _idNota; } set { _idNota = value; } }
        public E_Vendedor vendedor { get { return _vendedor; } set { _vendedor = value; } }
        public DateTime? fecha { get { return _fecha; } set { _fecha = value; } }
        public string descripcion { get { return _descripcion; } set { _descripcion = value; } }
    }
}

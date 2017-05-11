using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_Recargo
    {
        private Int64 _idRecargo;
        private string _descripcion;

        public  E_Recargo()
        {
            _idRecargo = 0;
        }
        public Int64 idRecargo { get { return _idRecargo; } set { _idRecargo = value; } }
        public string descripcion { get { return _descripcion; } set { _descripcion = value; } }


    }
}

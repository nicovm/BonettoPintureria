using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
	public class E_CondPago
	{
		private Int64 _idCondPago;
		private string _descripcion;
		//contructor
		public E_CondPago()
		{
			_idCondPago = 0;
			_descripcion = null;
		}
		//Metodos Accesos setter y getter
		public Int64 idCondPago { get { return _idCondPago; } set { _idCondPago = value; } }
		public string descripcion { get { return _descripcion; } set { _descripcion = value; } }
	}
}

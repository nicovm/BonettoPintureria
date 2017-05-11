using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
	public class E_DetallePedido
	{
		private Int64 _idDetalle;
		private string _codArticulo;
		private Int16 _cantidad;
		private string _descripcionArt;
		private string _observacionArt;
		private Int16 _stockActual;
		//contructor
		public E_DetallePedido()
		{
			_idDetalle = 0;
			_codArticulo = null;
			_cantidad = 0;
			_descripcionArt = null;
			_observacionArt = null;
			_stockActual = 0;
		}
		//metodos de accesos
		public Int64 idDetalle { get { return _idDetalle; } set { _idDetalle = value; } }
		public string codArticulo { get { return _codArticulo; } set { _codArticulo = value; } }
		public Int16 cantidad { get { return _cantidad; } set { _cantidad = value; } }
		public string descripcionArt { get { return _descripcionArt; } set { _descripcionArt = value; } }
		public string observacionArt { get { return _observacionArt; } set { _observacionArt = value; } }
		public Int16 stockActual { get { return _stockActual; } set { _stockActual = value; } }
	}
}

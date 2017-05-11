using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
	public class E_DetalleVenta
	{
		private Int64 _idDetalle;
		private string _codArticulo;
		private decimal _precioArticulo;
		private decimal _precioTotal;
		private Int16 _cantidad;
		private string _descripcion;
		private Int16 _stockActual;

		//contructor
		public E_DetalleVenta()
		{
			_idDetalle = 0;
			_codArticulo = null;
			_cantidad = 0;
			_precioArticulo = 0;
			_descripcion = null;
			_stockActual = 0;
			_precioTotal = 0;
		}
		//metodos de accesos
		public Int64 idDetalle { get { return _idDetalle; } set { _idDetalle = value; } }
		public string codArticulo { get { return _codArticulo; } set { _codArticulo = value; } }
		public Int16 cantidad { get { return _cantidad; } set { _cantidad = value; } }
		public decimal precioArticulo { get { return _precioArticulo; } set { _precioArticulo = value; } }
		public decimal precioTotal { get { return _precioTotal; } set { _precioTotal = value; } }
		public string descripcion { get { return _descripcion; } set { _descripcion = value; } }
		public Int16 stockActual { get { return _stockActual; } set { _stockActual = value; } }
	}
}

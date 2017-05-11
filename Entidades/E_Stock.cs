using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
	public class E_Stock
	{
		private Int64 _idStoclArticulo;
		private string _codArticulo;
		private DateTime? _fecha;
		private Int32 _stockActual;
		private Int64 _codCompra;
		private Int64 _codVenta;

		//constructor
		public E_Stock()
		{
			_idStoclArticulo = 0;
			_codArticulo = null;
			_fecha = null;
			_stockActual = 0;
			_codCompra = 0;
			_codVenta = 0;
		}

		public Int64 idStockArticulo{get{return _idStoclArticulo;} set { _idStoclArticulo= value;}}
		public string codArticulo { get { return _codArticulo; } set { _codArticulo = value; } }
		public DateTime? fecha { get { return _fecha; } set { _fecha = value; } }
		public Int32 stockActual { get { return _stockActual; } set { _stockActual = value; } }
		public Int64 codCompra { get { return _codCompra; } set { _codCompra = value; } }
		public Int64 codVenta { get { return _codVenta; } set { _codVenta = value; } }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
	public class E_DetalleCondicionCosto
	{
		private string _condicion; // aca digo si es recargo o descuento
		private string _descripcion;
		private Int16 _orden;
		private decimal _porcentaje;
		//Contructor
		public E_DetalleCondicionCosto()
		{
			_condicion = null;
			_descripcion = null;
			_orden = 0;
			_porcentaje = 0;
		}
		//SETTER Y GETTER
		public string condicion	 { get { return _condicion; } set { _condicion = value; } }
		public string descrpcion { get { return _descripcion; } set { _descripcion = value; } }
		public Int16 orden { get { return _orden; } set { _orden = value; } }
		public decimal porcentaje { get { return _porcentaje; } set { _porcentaje = value; } }

	}
}

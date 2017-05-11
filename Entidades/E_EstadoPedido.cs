using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
	public class E_EstadoPedido
	{
		private Int32 _idEstado;
		public static Int32 PENDIENTE = 1;
		public static Int32 CONFIRMADO = 2;
		public static Int32 ANULADO = 3;

		public E_EstadoPedido()
		{
			_idEstado = 0;
		}
		public Int32 idEstado { get { return _idEstado; } set { _idEstado = value; } }
	}
}

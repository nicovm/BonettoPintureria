using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
	public class E_Pedido : E_Movimiento //Hereda de la clase Movimiento
	{
		private Int64 _codPedido;
		private E_Proveedor _Proveedor;
		private List<E_DetallePedido> _detalles;
		private Int32 _cantidadArt;
		private E_EstadoPedido _estadoPedido;
		private DateTime? _fecEntrega;
	
		//Contructor
		public E_Pedido()
		{
			_codPedido = 0;
			_Proveedor = new E_Proveedor();
			_detalles = new List<E_DetallePedido>();
			_cantidadArt = 0;
			_estadoPedido = new E_EstadoPedido();
			_fecEntrega = null;
		
		}
		//metodos de accesos setter y getter
		public Int64 codPedido { get { return _codPedido; } set { _codPedido = value; } }
		public Int32 cantidadArt { get { return _cantidadArt; } set { _cantidadArt = value; } }
		public E_Proveedor proveedor { get { return _Proveedor; } set { _Proveedor = value; } }
		public List<E_DetallePedido> detalles { get { return _detalles; } set { _detalles = value; } }
		public string raSocial { get { return _Proveedor.raSocial; }}
		public E_EstadoPedido estadoPedido { get { return _estadoPedido; } set { _estadoPedido = value; } }
		public Int32 estado { get { return _estadoPedido.idEstado; } }
		public DateTime? fecEntrega { get { return _fecEntrega; } set { _fecEntrega = value; } }
	}
}

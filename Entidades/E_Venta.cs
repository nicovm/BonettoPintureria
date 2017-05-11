using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
	public class E_Venta : E_Movimiento //Hereda de la clase movimiento
	{
		private Int64 _codVenta;
		private E_Cliente _cliente;
		private List<E_DetalleVenta> _detalles;
		private Int32 _cantidadArt;
		private decimal _recargo;
        private decimal _creditoUtilizado;
	
		//contructor
		public E_Venta()
		{
			_codVenta = 0;
			_cliente = new E_Cliente();
			_detalles = new List<E_DetalleVenta>();
			_cantidadArt = 0;
			_recargo = 0;
            _creditoUtilizado = 0;

		}
		//metodos de accesos setter y getter
		public Int64 codVenta { get { return _codVenta; } set { _codVenta = value; } }
		public E_Cliente cliente { get { return _cliente; } set { _cliente = value; } }
		public string descripcionCliente { get { return _cliente.descripcion; } }
		public Int32 dniCliente { get { return _cliente.dni; } }
		public List<E_DetalleVenta> detalles { get { return _detalles; } set { _detalles = value; } }
		public Int32 cantidadArt { get { return _cantidadArt; } set { _cantidadArt = value; } }
		public decimal saldo { 
            get {

                decimal saldo = _precioTotal - (abonado + creditoUtilizado);
                //Si el saldo es mayor a cero devuelvo el saldo de lo contrario devuelvo cero si es negativo
                return saldo > 0 ? saldo : 0 ; 
             } 
        }
		public decimal recargo { get { return _recargo; } set { _recargo = value; } }
        public decimal creditoUtilizado { get { return _creditoUtilizado; } set { _creditoUtilizado = value; } }

	}
}

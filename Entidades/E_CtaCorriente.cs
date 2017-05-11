using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;

namespace Entidades
{
	public class E_CtaCorriente
	{
		private E_Cliente _cliente;
		private Int32 _ventasPendientes;
		private decimal _saldoDeudor;

		public E_CtaCorriente()
		{
			_cliente = new E_Cliente();
			_ventasPendientes = 0;
			_saldoDeudor = 0;
		}
		public E_Cliente cliente { get { return _cliente; } set { _cliente = value; } }
		public Int32 ventasPendientes { get { return _ventasPendientes; } set { _ventasPendientes = value; } }
		public decimal saldoDeudor { get { return _saldoDeudor; } set { _saldoDeudor = value; } }
		public Int64 idCliente { get { return _cliente.idCliente; } }
		public string descripcion { get { return _cliente.descripcion; } }
		public Int32 dni { get { return _cliente.dni; } }
	}
}

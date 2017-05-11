using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
	public class E_Movimiento
	{
		protected DateTime? _fecha;
		protected E_Vendedor _vendedor;
		protected Boolean _anular;
		
		protected string _direccion;
		protected string _cuit;
		protected E_CondPago _condPago;
		protected string _observacion;
		protected decimal _precioTotal;
		protected decimal _abonado;
		protected decimal _descuento;
		//Contructor
		public E_Movimiento()
		{
			_fecha = null;
			_vendedor = new E_Vendedor();
			_anular = false;
		
			_observacion = null;
			_condPago = new E_CondPago();
			_cuit = null;
			_precioTotal=0;
			_abonado = 0;
			_descuento = 0;
		}
		//Metodos de accesos
		public DateTime? fecha { get { return _fecha; } set { _fecha = value; } }
		public E_Vendedor vendedor { get { return _vendedor; } set { _vendedor = value; } }
		public Boolean anular { get { return _anular; } set { _anular = value; } }
		
		public string direccion { get { return _direccion; } set { _direccion = value; } }
		public string cuit { get { return _cuit; } set { _cuit = value; } }
		public E_CondPago condPago { get { return _condPago; } set { _condPago = value; } }
		public string observacion { get { return _observacion; } set { _observacion = value; } }
		public decimal precioTotal { get { return _precioTotal; } set { _precioTotal = value; } }
		public string pago { get { return _condPago.descripcion; } }
		public decimal abonado { get { return _abonado; } set { _abonado = value; } }
		public decimal descuento { get { return _descuento; } set { _descuento = value; } }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
	public class E_Caja
	{
	
		private Int64 _idCaja;
		private DateTime? _fecCaja;
		private decimal _caja;
		private Boolean _cerrado;
		private decimal _ingresos;
		private decimal _otrosIngresos;
		private decimal _egresos;
		private decimal _efectivo;
		private decimal _cheques;
		private decimal _tarjCredito;
        private decimal _notaCreditoOrtogado;
        private decimal _notaCreditoUtilizado;

		public E_Caja()
		{
			_idCaja = 0;
			_fecCaja = null;
			_caja = 0;
			_cerrado = false;
			_ingresos =0;
			_otrosIngresos =0;
			_egresos =0;
			_efectivo = 0;
			_cheques = 0;
			_tarjCredito = 0;
            _notaCreditoUtilizado = 0;
            _notaCreditoOrtogado = 0;
		}

		public Int64 idCaja { get { return _idCaja; } set { _idCaja = value; } }
		public DateTime? fecCaja { get { return _fecCaja; } set { _fecCaja = value; } }
		public decimal caja { get { return _caja; } set { _caja = value; } }
		public Boolean cerrado { get { return _cerrado; } set { _cerrado = value; } }
		public static Boolean CERRAR_CAJA { get { return true; } }
		public decimal ingresos { get { return _ingresos; } set { _ingresos = value; } }
		public decimal otrosIngresos { get { return _otrosIngresos; } set { _otrosIngresos = value; } }
		public decimal egresos { get { return _egresos; } set { _egresos = value; } }
		public decimal efectivo { get { return _efectivo; } set { _efectivo = value; } }
		public decimal cheques { get { return _cheques; } set { _cheques = value; } }
	    public decimal tarjCredito { get { return _tarjCredito; } set { _tarjCredito = value; } }
        public decimal notaCreditoUtilizado { get { return _notaCreditoUtilizado; } set { _notaCreditoUtilizado = value; } }
        public decimal notaCreditoOrtogado { get { return _notaCreditoOrtogado; } set { _notaCreditoOrtogado = value; } }


	}
}

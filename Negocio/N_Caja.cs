using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
	public class N_Caja
	{
		public E_Caja getOneCaja(DateTime fecha)
		{
			BD_Caja bdCaja = new BD_Caja();
			return bdCaja.getOne_CajaDiaria(fecha);
		}
		public Int16 countCajaDiaria(DateTime fecCaja)
		{
			BD_Caja bdCaja = new BD_Caja();
			return  bdCaja.count_CajaDiaria(fecCaja);
		}
		public Boolean abrirCajaDiaria(E_Caja caja)
		{
			BD_Caja bdCaja = new BD_Caja();
			return bdCaja.abrir_CajaDiaria(caja);
		}
		public Boolean cerrarCajaDiaria(DateTime fecCaja)
		{

			BD_Caja bdCaja = new BD_Caja();
			return bdCaja.cerrar_CajaDiaria(fecCaja);
		}
		public E_Caja getOneCajaDiaria(DateTime fecCaja)
		{
			BD_Caja bdCaja = new BD_Caja();
			return bdCaja.getOne_CajaDiaria(fecCaja);
		}
	}
}

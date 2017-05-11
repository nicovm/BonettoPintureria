using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
	public class N_CondPago
	{
		public List<E_CondPago> getAllCondPago()
		{
			BD_CondPago bdCondPago = new BD_CondPago();
			 return  bdCondPago.getAllCondPago();
		}
		public E_CondPago getOneCondPago(Int64 idCondPago)
		{
			BD_CondPago bdCondPago = new BD_CondPago();
			return bdCondPago.getOneCondPago(idCondPago);
		}
	}
}

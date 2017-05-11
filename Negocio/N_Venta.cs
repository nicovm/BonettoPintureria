using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;

namespace Negocio
{
	public class N_Venta
	{
		public Int64 ultCodVenta()
		{
			BD_Venta bdVenta = new BD_Venta();
			return bdVenta.ulitCodVenta();
		}
		public Int64 addVenta(E_Venta venta, bool utilizaCredito = false )
		{
            
            BD_Venta bdVenta = new BD_Venta();
            Int64 codVenta =  bdVenta.add_Venta(venta);

            if (utilizaCredito)
            {
                venta.codVenta = codVenta;
                // Utilizar los creditos
                Negocio.N_NotasCredito nNotaCredito = new N_NotasCredito();
                nNotaCredito.UtilizarCredito(venta);

            }

            return codVenta;

		}
		public List<E_Venta> getAllVenta(DateTime fecDesde, DateTime fecHasta, string descripcionClie, string filtro)
		{
			BD_Venta bdVenta = new BD_Venta();
			return bdVenta.getAll_Venta(fecDesde, fecHasta, descripcionClie, filtro);
		}
        public List<E_Venta> getAllVenta(DateTime fecDesde, DateTime fecHasta, Int64 idCliente)
        {
            BD_Venta bdVenta = new BD_Venta();
            return bdVenta.getAll_Venta(fecDesde, fecHasta, idCliente);
        }
		public E_Venta getOneVenta(Int64 codVenta)
		{
			BD_Venta bdVenta = new BD_Venta();
			return bdVenta.getOne_Venta(codVenta);
		}
		public Boolean anularVenta(E_Venta venta)
		{
			BD_Venta bdVenta = new BD_Venta();
			return bdVenta.anular_Venta(venta);
		}
		public Boolean aplicarRecargoVenta(Int64 codVenta, decimal recargo, decimal nvoPrecioTotal)
		{
			BD_Venta bdVenta = new BD_Venta();
			return bdVenta.aplicarRecargo_Venta(codVenta, recargo, nvoPrecioTotal);
		}
		public Boolean abonarVenta(E_Venta venta, decimal abonadoActual)
		{
			BD_Venta bdVenta = new BD_Venta();
			return bdVenta.abonar_Venta(venta, abonadoActual);
		}
        /// <summary>
        /// Permite abonar el total de un conjunto de ventas
        /// </summary>
        /// <param name="listVenta">lista de ventas que se van a abonar su totalidad</param>
        /// <returns></returns>
        public Boolean abonarVenta( List< E_Venta> listVenta)
        {
            BD_Venta bdVenta = new BD_Venta();
            return bdVenta.abonar_Venta(listVenta);
        }

     
		public Boolean aplicarRecargoVenta(List<E_DetalleVenta> listDet, decimal precioTotalVenta,Int64 codVenta)
		{
			BD_Venta bdVenta = new BD_Venta();
			return bdVenta.aplicarRecargo_Venta(listDet,precioTotalVenta,codVenta);
		}
        public Boolean setDescuento(decimal descuentoMod, decimal precioTotal ,Int64 codVenta)
        {
            BD_Venta bdVenta = new BD_Venta();
            return bdVenta.setDescuento(descuentoMod, precioTotal,codVenta);
        }
        /// <summary>
        /// Permite modificar una venta, y determina si le queda credito al cliente
        /// </summary>
        /// <returns></returns>
        public Boolean ModificarVenta(E_Venta venta)
        {
            BD_Venta bdVenta = new BD_Venta();
            bdVenta.Update_Venta(venta);
            //Si se pudo modifcar la venta le agrego el credito al cliente
            return true;

        }

	}
}

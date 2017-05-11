using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;

namespace Negocio
{
	public class N_Pedido
	{
		public Int64 ultCodCompra()
		{
			BD_Pedido bdCompra = new BD_Pedido();
			return bdCompra.ulitCodCompra();
		}
		public string addPedido(E_Pedido pedido)
		{
			BD_Pedido bdPedido = new BD_Pedido();
			return bdPedido.add_Pedido(pedido);
		}
		public List<E_Pedido> getAllPedido(DateTime fecDesde, DateTime fecHasta, string filtro,string estado)
		{
			BD_Pedido bdpedido = new BD_Pedido();
			return bdpedido.getAll_Pedido(fecDesde, fecHasta, filtro,estado);
		}
		public E_Pedido getOnePedido(Int64 codPedido)
		{
			BD_Pedido bdPedido = new BD_Pedido();
			return bdPedido.getOne_Pedido(codPedido);
		}
		public Boolean anularPedido(Int64 codPedido)
		{
			BD_Pedido bdPedido = new BD_Pedido();
			return bdPedido.anular_Pedido(codPedido);
		}
		public Boolean confirmarPedido(E_Pedido pedido)
		{
			BD_Pedido bdPedido = new BD_Pedido();
			return bdPedido.confirmar_Pedido(pedido);
		}

	}
}

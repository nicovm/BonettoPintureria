using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Datos;
using Entidades;

namespace Negocio
{
    public class N_Cliente
    {
         
        /// <summary>
        /// Devuelve una lista de clientes si devuelve NULL es que no ah devuelto ningun cliente
        /// </summary>
        /// <param name="filtro"></param>
        /// <returns></returns>
        public List<E_Cliente> getAll(string filtro)
        {
            List<E_Cliente> clientes;
			BD_Cliente bdCliente = new BD_Cliente();
            clientes = bdCliente.getAll_Clientes( filtro);
            return clientes;
        }
        /// <summary>
        /// Metodo que guarda un cliente
        /// si el ID de cliente es 0 crear una nuevo cliente
        /// sino modificara una cliente existente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public string guardar( E_Cliente cliente)
        {
            string xRet;
			BD_Cliente bdCliente = new BD_Cliente();
            
            if (cliente.idCliente == 0) // si el id de cliente es igual a 0 creara un nuevo cliente  
            {
               xRet =  bdCliente.add_Cliente(cliente);
            }
            else // sino modificara un cliente existente
            {
                xRet = bdCliente.set_Cliente(cliente);
            }

            return xRet;
        }
        /// <summary>
        /// Devuelve un cliente especifico
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public E_Cliente getOne(Int64 idCliente)
        {
			BD_Cliente bdCliente = new BD_Cliente();
            return bdCliente.getOne_Cliente(idCliente);
        }
        /// <summary>
        /// elimina un cliente
        /// </summary>
        /// <param name="idCliente"></param>
        /// <returns></returns>
        public string deleteCliente(Int64 idCliente)
        {
			BD_Cliente bdCliente = new BD_Cliente();
            return bdCliente.delete_Cliente(idCliente);
        }
		public List<E_CtaCorriente> getGetAllCtaCorriente(string filtro,DateTime fecDesde, DateTime fecHasta)
		{
			BD_Cliente bdCliente = new BD_Cliente();
			return bdCliente.getAll_CtaCorriente(filtro,fecDesde,fecHasta);
		}
		public Int64 ultCliente()
		{
			BD_Cliente bdCliente = new BD_Cliente();
			return bdCliente.ultCliente_Cliente();
		}
		public List<E_Venta> getOneResumenCta(Int64 idCliente ,string filtro)
		{
			BD_Cliente bdCliente = new BD_Cliente();
			return bdCliente.getOne_ResumenCta(idCliente,filtro);
		}
    }
}

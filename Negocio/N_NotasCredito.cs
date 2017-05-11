using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Entidades;
using Datos;

namespace Negocio
{
    public class N_NotasCredito
    {
        BD_NotasCredito bdNotaCredito = new BD_NotasCredito();
        public string add_NotaCredito(E_NotaCredito oNotaCredito)
        {
            return bdNotaCredito.add_NotaCredito(oNotaCredito);
        }

        public List<E_NotaCredito> getAll(DateTime fecDesde, DateTime fecHasta, string descripcionClie)
        {
            return bdNotaCredito.getAll(fecDesde,fecHasta,descripcionClie);

        }

        public E_NotaCredito getOne(Int64 idNotaCredito)
        {
            return bdNotaCredito.getOne(idNotaCredito);
        }


        public decimal getCredito(Int64 idCliente)
        {
            return bdNotaCredito.getCredito(idCliente);
        }

       


        public string UtilizarCredito(Entidades.E_Venta venta )
        {
            string xRet = "0";
            //CREdit
            decimal totalCreditoUtilizar = venta.precioTotal;
            while (totalCreditoUtilizar > 0)
            {
                Entidades.E_NotaCredito nc = bdNotaCredito.getPrimerCredito(venta.cliente.idCliente);
                if (nc != null) //Tiene credito vigente
                {
                    if (nc.monto >= totalCreditoUtilizar) // El monto del credito es mayo o  igual al  total utilizar
                    {
                        //Utilizo el credito
                        xRet = bdNotaCredito.utilizarCredito(totalCreditoUtilizar, venta.codVenta, nc.idNotaCredito);

                        if (nc.monto > totalCreditoUtilizar) // SI el monto del credito es mayor que el total de la venta a utilizar
                        {
                            //Creo un nuevo credito con el restante
                            decimal restanteCredito =  nc.monto - totalCreditoUtilizar ;

                            Entidades.E_NotaCredito nvaNc = new E_NotaCredito(venta.cliente.idCliente, restanteCredito, DateTime.Now, venta.codVenta);

                            bdNotaCredito.add_NotaCredito(nvaNc);

                        }
                        //resto el total de credito a utilizar
                        totalCreditoUtilizar -= nc.monto;

                    }
                    else
                    {
                        //Utilizo el total del credito
                        xRet = bdNotaCredito.utilizarCredito(nc.monto, venta.codVenta, nc.idNotaCredito);
                    }
                }
                else // no tiene credito vigente
                {
                    totalCreditoUtilizar = 0;
                }

            }

            
            return "0";
        }

        public E_NotaCredito getOneCreditoUtilizado(Int64 codVenta)
        {
            return   bdNotaCredito.getOneCreditoUtilizado(codVenta);
        }

    }
}

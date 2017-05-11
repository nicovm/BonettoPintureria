using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Negocio
{
    public class N_CuentaCorriente
    {


        public Boolean realizarEntrega(List<Entidades.E_Venta> ventas , decimal entrega )
        {
            Negocio.N_Venta nVneta = new N_Venta();

            foreach (Entidades.E_Venta venta in ventas)
            {
                //pregunto si el resto de la entrega es mayor que cero
                if (entrega > 0)
                {
                    if (venta.saldo <= entrega) //si el salfo en menor o igual a la al resto de la entrega
                    {
                       nVneta.abonarVenta(venta, venta.saldo); //abono el total de la venta
                       
                    }
                    else // saldo es mayor a la entega
                    {
                        nVneta.abonarVenta(venta, entrega);
                            
                    }
                     entrega -= venta.saldo; //resto el saldo a la entrega
                }
     
            }
            return true;

        }
    }
}

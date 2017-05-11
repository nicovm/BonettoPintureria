using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Entidades
{
    public class E_NotaCredito
    {
        public Int64 idNotaCredito { get; set; }
        public Int64 idCliente { get; set; }
        public decimal monto { get; set; }
        public DateTime fecha { get; set; }
        public DateTime fechaUtilizado { get; set; }
        public decimal  montoUtilizado { get; set; }
        public String nombreCliente { get; set; }
        public Int64 codVenta { get; set; }
        public Boolean utilizado { get; set; }

        


        public E_NotaCredito()
         {
            
         }

        
        public E_NotaCredito(Int64 idCliente , decimal monto , DateTime fecha , Int64 codVenta)
        {
            this.idCliente = idCliente;
            this.monto = monto;
            this.fecha = fecha;
            this.codVenta = codVenta;

        }

    }
}

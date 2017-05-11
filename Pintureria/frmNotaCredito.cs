using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pintureria
{
    public partial class frmNotaCredito : Form
    {

        /// <summary>
        /// Nota de credito consultada
        /// </summary>
        public Entidades.E_NotaCredito _ncConsultado { get; set; }
        public Int64 codVentaAsignado
        {
            set
            {
                if (value != 0) lblCodVenta.Text = value.ToString();
                else lblCodVenta.Text = "el crédito no tiene un venta asignada";
             
            }
        }


        public frmNotaCredito()
        {
            InitializeComponent();
        }

        public frmNotaCredito(Int64 idNotaCredito)
        {
            InitializeComponent();
            consultar(idNotaCredito);
        }

        private void consultar(Int64 idNotaCredito)
        {
            Negocio.N_NotasCredito nNotaCredito = new Negocio.N_NotasCredito();
            Entidades.E_NotaCredito nc = nNotaCredito.getOne(idNotaCredito);
            //Guardo la nota de credito consultada
            _ncConsultado = nc;
            dtFechaAlta.Value = nc.fecha;
            txtMonto.Text = nc.monto.ToString("N2");

            codVentaAsignado = nc.codVenta;

            if (nc.utilizado)
            {
                dtFechaUtilizado.Value = nc.fechaUtilizado;
                txtMontoUtilizado.Text = nc.montoUtilizado.ToString("N2");
                
            }
            else gbUtilizado.Enabled = false;

            btnEliminar.Enabled = true;
            deshabilitarBtn();
          
        }


        private void deshabilitarBtn()
        {
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Permite obtener los datos del formulario
        /// </summary>
        /// <returns> obtiene los datos de la nota de credito</returns>
        private Entidades.E_NotaCredito getDatosForm()
        {
            
            return null;
        }



        
    }
}

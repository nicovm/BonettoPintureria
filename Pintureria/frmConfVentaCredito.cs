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
    public partial class frmConfVentaCredito : Form
    {
        public Entidades.E_Venta venta{ get; set; }
        public decimal montoCredito { get; set; }

        public frmConfVentaCredito(Entidades.E_Venta venta , decimal montoCredito )
        {
            InitializeComponent();
            this.venta = venta;
            this.montoCredito = montoCredito;
            txtCredito.Text = montoCredito.ToString("N2");
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Negocio.N_NotasCredito nNotasCredito = new Negocio.N_NotasCredito();
            //Generar el credito
             Entidades.E_NotaCredito oNotaCredito = new Entidades.E_NotaCredito(venta.cliente.idCliente, montoCredito , DateTime.Now.Date, venta.codVenta);
             String xRet = nNotasCredito.add_NotaCredito(oNotaCredito);

             if (xRet == "0")
             {
                 MessageBox.Show("¡Operación realizada con exito!", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 this.DialogResult = DialogResult.OK;
             }
             else //Error
             {
                 MessageBox.Show(xRet, "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Error);
             }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }


    }
}

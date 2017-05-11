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
    public partial class ABMNotaCredito : Form
    {
        public ABMNotaCredito()
        {
            InitializeComponent();
        }



        private void refrescarGrilla()
        {
            DateTime fecDesde = dtDesde.Value.Date;
            DateTime fecHasta = dtHasta.Value.Date;
            if (fecDesde <= fecHasta)
            {

                dgNotaCredito.Rows.Clear();
                Negocio.N_NotasCredito nNotaCredito = new Negocio.N_NotasCredito();

                List<Entidades.E_NotaCredito> listNotaCredito = nNotaCredito.getAll(fecDesde, fecHasta, txtBscCliente.Text);

                if (listNotaCredito != null)
                {
                    foreach (Entidades.E_NotaCredito oNotaCredito in listNotaCredito)
                    {
                        string fechaUtilizado = "-";
                        string montoUtilizado = "-";

                        if (oNotaCredito.montoUtilizado > 0)
                        {
                            montoUtilizado = oNotaCredito.montoUtilizado.ToString("N2");
                            fechaUtilizado = oNotaCredito.fechaUtilizado.ToString("dd/MM/yyyy");

                        }


                        dgNotaCredito.Rows.Add(oNotaCredito.idNotaCredito, oNotaCredito.fecha, oNotaCredito.nombreCliente, oNotaCredito.monto, fechaUtilizado
                            , montoUtilizado);
                    }

                }
                else
                {

                }
                resumenGrilla();

                //ventas = nVenta.getAllVenta(dtDesde.Value, dtHasta.Value, txtBscCliente.Text, filtro);               
            }
            else // su la fecha desde es mayo al hasta
            {
                MessageBox.Show("¡La fecha DESDE tiene que ser menor a la fecha HASTA!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void resumenGrilla()
        {
            decimal totalCreditosUtilizados = 0;
            decimal totalCreditosOrtogados = 0;
            foreach (DataGridViewRow row in dgNotaCredito.Rows)
            {
                totalCreditosOrtogados += row.Cells[colMonto.Index].Value == "-" ? 0 : Convert.ToDecimal(row.Cells[colMonto.Index].Value);
                totalCreditosUtilizados += row.Cells[colMontoUtilizado.Index].Value == "-" ? 0 : Convert.ToDecimal(row.Cells[colMontoUtilizado.Index].Value);
            }

            txtCreditosOrtogados.Text = totalCreditosOrtogados.ToString("N2");
            txtCreditoUtilizados.Text = totalCreditosUtilizados.ToString("N2");

            txtCreditoDisponible.Text = (totalCreditosOrtogados - totalCreditosUtilizados).ToString("N2");
        }
 

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            refrescarGrilla();
        }

        private void dgNotaCredito_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == -1 || e.RowIndex == -1) return;

            frmNotaCredito frmNota = new frmNotaCredito(Convert.ToInt64(dgNotaCredito.CurrentRow.Cells[colIdNotaCredito.Index].Value));
            frmNota.ShowDialog();

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

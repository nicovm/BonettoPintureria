using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;
using Negocio;

namespace Pintureria
{
    public partial class frmCuentaCorriente : Form
    {
        private Int64 _idCliente;
        public frmCuentaCorriente(Int64 idCliente)
        {
            InitializeComponent();
            _idCliente = idCliente;


            dtDesde.Value = DateTime.Now.AddYears(-1);
            ConsultarCC();

        }
        List<E_Venta> _ventasPendientes;

        /// <summary>
        /// Consultar Cuenta Corriente
        /// </summary>
        private void ConsultarCC()
        {
            refrescarGrillaVentasPendiente();
        }

        private void refrescarGrillaVentasPendiente()
        {
            DateTime fecDesde = dtDesde.Value.Date;
            DateTime fecHasta = dtHasta.Value.Date;
            if (fecDesde <= fecHasta)
            {

              
                N_Venta nVenta = new N_Venta();

                dgVentas.AutoGenerateColumns = false;

              
               

                _ventasPendientes = nVenta.getAllVenta(dtDesde.Value, dtHasta.Value, _idCliente);
                if (_ventasPendientes != null)
                {
                    dgVentas.AutoGenerateColumns = false;
                    dgVentas.DataSource = _ventasPendientes;
                
                    decimal totalVentas = 0;
                    decimal totalAbonado = 0;
                    decimal totalSaldo = 0;
                 
                    try
                    {
                        foreach (DataGridViewRow row in dgVentas.Rows)
                        {
                            Boolean ventaAnulada = Convert.ToBoolean(row.Cells[colAnular.Index].Value);


                            if (ventaAnulada) // si es venta anulada
                            {
                                //Cambio el color de la fila a naranja o a cualquier otro color
                                dgVentas.Rows[row.Index].DefaultCellStyle.BackColor = Color.OrangeRed;
                            }
                            else // si no esta anulada
                            {
                              
                                totalVentas += Convert.ToDecimal(row.Cells[colTotal.Index].Value);
                                totalAbonado += Convert.ToDecimal(row.Cells[colAbonado.Index].Value);
                                totalSaldo += Convert.ToDecimal(row.Cells[colSaldo.Index].Value);

                            }
                        }
                        //Total de deuda
                        txtCuentaCorriente.Text = totalSaldo.ToString("N2");

                    }
                    catch
                    {

                    }
                }
                else
                {
                    MessageBox.Show("¡No se cargo la gilla!");
                }
            }
            else // su la fecha desde es mayo al hasta
            {
                MessageBox.Show("¡La fecha DESDE tiene que ser menor a la fecha HASTA!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnRealizarEntrega_Click(object sender, EventArgs e)
        {
            if (txtEntrega.Text == "") txtEntrega.Text = "0";

            decimal entrega = Convert.ToDecimal(txtEntrega.Text);

            if (entrega > 0)
            {
                Negocio.N_CuentaCorriente nCC = new N_CuentaCorriente();
               bool entregaRealizada = nCC.realizarEntrega(_ventasPendientes, entrega);

               if (entregaRealizada)
               {
                   MessageBox.Show("Operación realizada con exito", "Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
                   ConsultarCC();
               }
               else
               {
                   MessageBox.Show("Operación realizada con exito", "Entrega", MessageBoxButtons.OK, MessageBoxIcon.Information);
               }

            }
            else
            {
                MessageBox.Show("La entrega tiene que se mayor a 0","Entrega Cero",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);

            }


        }

      

       

    }
}

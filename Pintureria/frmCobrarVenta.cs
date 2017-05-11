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
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace Pintureria
{
    public partial class frmCobrarVenta : Form
    {

        private List<Entidades.E_Venta> _listVenta;


        public frmCobrarVenta(List<Entidades.E_Venta> listVenta)
        {
            InitializeComponent();
            dgVentas.AutoGenerateColumns = false;
            dgVentas.DataSource = listVenta;
            this._listVenta = listVenta;
            Resumen();
        }

        private void Resumen()
        {
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
                        // lo dejo en blanco al fondo de la fila
                        dgVentas.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGreen;
                        totalVentas += Convert.ToDecimal(row.Cells[colTotal.Index].Value);
                        totalAbonado += Convert.ToDecimal(row.Cells[colAbonado.Index].Value);
                        totalSaldo += Convert.ToDecimal(row.Cells[colSaldo.Index].Value);
                    }
                }
                txtTotal.Text = totalVentas.ToString("N2");
                txtAbonado.Text = totalAbonado.ToString("N2");
                txtSaldo.Text = totalSaldo.ToString("N2");

                txtTotalCobrar.Text = totalSaldo.ToString("N2");
                txtCantVenta.Text = dgVentas.RowCount.ToString();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Resumen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            Negocio.N_Venta nVenta = new Negocio.N_Venta();

            if (nVenta.abonarVenta(this._listVenta))
            {
                MessageBox.Show("Operación realizada correctamente", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
            }
            else MessageBox.Show("No se pudo realizar la operación intenta nuevamente", "Confirmar", MessageBoxButtons.OK, MessageBoxIcon.Error);

          

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            string ruta = Application.StartupPath + "\\CobrarVentas.rpt";
            ReportDocument rpt = new ReportDocument();


            dsVentas dsVentaCobrar = new dsVentas();
            dsVentaCobrar.EnforceConstraints = false;

            dsVentasTableAdapters.ClientesTableAdapter clienteTableAdap = new dsVentasTableAdapters.ClientesTableAdapter();
            dsVentasTableAdapters.CondPagoTableAdapter condPagoTableAdap = new dsVentasTableAdapters.CondPagoTableAdapter();
            dsVentasTableAdapters.DetalleVentaTableAdapter detVentaTableAdap = new dsVentasTableAdapters.DetalleVentaTableAdapter();
            dsVentasTableAdapters.AbonarVentaTableAdapter abonarVentaTableAdap = new dsVentasTableAdapters.AbonarVentaTableAdapter();
            dsVentasTableAdapters.VendedoresTableAdapter vendedorTableAdap = new dsVentasTableAdapters.VendedoresTableAdapter();
            dsVentasTableAdapters.VentasTableAdapter ventaTableAdap = new dsVentasTableAdapters.VentasTableAdapter();
            dsVentasTableAdapters.ArticulosTableAdapter articuloTableAdap = new dsVentasTableAdapters.ArticulosTableAdapter();
            dsVentasTableAdapters.MarcasTableAdapter marcasTableAdap = new dsVentasTableAdapters.MarcasTableAdapter();

            // llenos los tabla adapter

            clienteTableAdap.Fill(dsVentaCobrar.Clientes);
            condPagoTableAdap.Fill(dsVentaCobrar.CondPago);
            abonarVentaTableAdap.Fill(dsVentaCobrar.AbonarVenta);
            vendedorTableAdap.Fill(dsVentaCobrar.Vendedores);
            detVentaTableAdap.Fill(dsVentaCobrar.DetalleVenta);
            articuloTableAdap.Fill(dsVentaCobrar.Articulos);
            marcasTableAdap.Fill(dsVentaCobrar.Marcas);

           


            foreach (Entidades.E_Venta venta in this._listVenta)
            {
                dsVentas.VentasRow rowVenta = dsVentaCobrar.Ventas.NewVentasRow();
                rowVenta.codVenta = venta.codVenta;
                rowVenta.CUIT = venta.cuit;
                rowVenta.descuento = venta.descuento;
                rowVenta.idCliente = venta.cliente.idCliente;
                rowVenta.idVendedor = venta.vendedor.idVendedor;
                rowVenta.idCondPago = venta.condPago.idCondPago;
                rowVenta.precioTotal = venta.precioTotal;
                rowVenta.observacion = venta.observacion;
                rowVenta.recargo = venta.recargo;
                rowVenta.fecVenta = (DateTime)venta.fecha;

                dsVentaCobrar.Ventas.AddVentasRow(rowVenta);

            }
            ventaTableAdap.Fill(dsVentaCobrar.Ventas);

            rpt.Load(ruta);
            rpt.SetDataSource(dsVentaCobrar);


            frmRptVisor frmVerRpt = new frmRptVisor(rpt);
            frmVerRpt.Show();
            

        }

        private void GenerarReporte()
        {

        }
    }
}

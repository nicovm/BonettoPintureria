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
	public partial class ABMVenta : Form
	{
		// Variable de estado
		
		//Contructor
		public ABMVenta()
		{
			InitializeComponent();
		}
		//Eventos de formulario
		private void ABMVenta_Load(object sender, EventArgs e)
		{
			refrescarGrilla();
		}
		private void ABMVenta_Deactivate(object sender, EventArgs e)
		{
			//this.WindowState = FormWindowState.Minimized;
		}
		//Metodos
		private void refrescarGrilla()
		{
				DateTime fecDesde = dtDesde.Value.Date;
			DateTime fecHasta = dtHasta.Value.Date;
			if (fecDesde <= fecHasta)
			{

				List<E_Venta> ventas;
				N_Venta nVenta = new N_Venta();

				dgVentas.AutoGenerateColumns = false;

				string filtro = "TODAS LAS VENTAS";
				if (rbVentasPendiente.Checked) filtro = "VENTAS PENDIENTES";
				if (rbVentasAnuladas.Checked) filtro = "VENTAS ANULADAS";

				ventas = nVenta.getAllVenta(dtDesde.Value, dtHasta.Value, txtBscCliente.Text,filtro);
				if (ventas != null)
				{
					dgVentas.AutoGenerateColumns = false;
					dgVentas.DataSource = ventas;
					txtCantVenta.Text = ventas.Count().ToString();
					
					decimal totalVentas=0;
					decimal totalAbonado=0;
					decimal totalSaldo=0;
                    decimal totalCredito = 0;

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
        private Boolean MostrarCobrarVenta()
        {
            try
            {
                foreach (DataGridViewRow row in dgVentas.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[colSelect.Name].Value) == true) return true;

                    //Si tiene un venta seleccionada 
                    //DataGridViewCheckBoxCell cbx = (DataGridViewCheckBoxCell)row.Cells[colSelect.Index].Value;
                    //if (cbx.va == true) return true;
                }
                return false;
            }
            catch (Exception)
            {

                return false;
            }

        }
        /// <summary>
        /// Permite obtener las ventas seleccionadas
        /// </summary>
        /// <returns></returns>
        private List<Entidades.E_Venta> getVentaSeleccionadas()
        {

            List<E_Venta> listVenta = new List<E_Venta>();
            Boolean VentasSinSaldo = false;
            foreach (DataGridViewRow row in dgVentas.Rows)
            {
                
                if (Convert.ToBoolean(row.Cells[colSelect.Name].Value) == true)
                {
                    E_Venta ventaCobrar = (E_Venta)row.DataBoundItem;

                    if (ventaCobrar.saldo > 0)
                    {
                        listVenta.Add(ventaCobrar);
                    }
                    else VentasSinSaldo = true;
                  
                }
            }

            if (VentasSinSaldo) MessageBox.Show("Solo se van agregar las ventas que tengan saldo", "Ventas Sin Saldo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            return listVenta;
        }

		//Eventos
		private void dgVentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			
			if (dgVentas.Rows.Count != 0)
			{
				Int64 codArticulo = Convert.ToInt16(dgVentas.CurrentRow.Cells[colCodVenta.Index].Value);
				frmVenta _frmVenta = new frmVenta(codArticulo);//consultar la venta
				_frmVenta.ShowDialog();
				refrescarGrilla();
                
			}
		}

        private void btnBuscar_Click(object sender, EventArgs e) {refrescarGrilla();}

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void txtBscCliente_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == (int)Keys.Enter)
			{
				refrescarGrilla();
			}
		}

		private void rbTodasLasVentas_CheckedChanged(object sender, EventArgs e)
		{
			refrescarGrilla();
		}
		private void rbVentasPendiente_CheckedChanged(object sender, EventArgs e)
		{
			refrescarGrilla();
		}
		private void rbVentasAnuladas_CheckedChanged(object sender, EventArgs e)
		{
			refrescarGrilla();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{

		}

        private void dgVentas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex > -1 && e.RowIndex > -1)
            {
                if (colSelect.Index == e.ColumnIndex)
                {
                    btnCobrarVenta.Visible = MostrarCobrarVenta();
                }
            }
    
        }

      

        private void btnCobrarVenta_Click(object sender, EventArgs e)
        {
            frmCobrarVenta frm = new frmCobrarVenta(getVentaSeleccionadas());
            if (frm.ShowDialog() == DialogResult.OK) refrescarGrilla();
               
            

        }

        
		


		//private void dgVentas_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		//{
		//    Boolean ventaAnulada = Convert.ToBoolean(dgVentas.Rows[e.RowIndex].Cells[colAnular.Index].Value);

		//    if (ventaAnulada) // si es venta anulada
		//    {
		//        //Cambio el color de la fila a naranja o a cualquier otro color
		//        dgVentas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Orange;
		//    }
		//    else // si no esta anulada
		//    {
		//        // lo dejo en blanco al fondo de la fila
		//        dgVentas.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
		//    }
		//    //dgVentas.Rows[0].DefaultCellStyle.BackColor = Color.Orange;

		//}

	}
}

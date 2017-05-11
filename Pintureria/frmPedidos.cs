using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Entidades;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace Pintureria
{
	public partial class frmPedidos : Form
	{
		//Variables de estado
		public static string _frmName = "frmPedido";  
		public static Int64 _idProveedor = 1; //por defecto OTROS
		public static string _codArticuloAgr = null;
		public static DateTime? _fecEntrega ;
		//contructor
		public frmPedidos()
		{
			InitializeComponent();
			cargarCombos();
			valPrederteminado();
			buscarProveedor();
			_fecEntrega = null;
		}
		public frmPedidos(Int64 codPedido)
		{
			InitializeComponent();
			cargarCombos();
			consultarPedido(codPedido);
			_fecEntrega = null;
		}
		//Evento de formulario
		private void frmCompra_Load(object sender, EventArgs e)
		{
			this.dgDetalle.ClearSelection();
		}
		private void frmCompra_Deactivate(object sender, EventArgs e)
		{
			//this.WindowState = FormWindowState.Minimized;
		}
		//Metodos
		private void valPrederteminado()
		{
			N_Pedido nCompra = new N_Pedido();
			Int64 ultCodCompra = nCompra.ultCodCompra();
			txtUltVenta.Text = ultCodCompra.ToString();
			txtCodPedido.Text = (ultCodCompra + 1).ToString();
			cboVendedor.SelectedIndex = 0;  //primer vendedor
			cboCondPago.SelectedIndex = 0; // efectivo
			//cboTipDescuento.SelectedIndex = 0;//%
			btnAgrArticulo.Focus();
			dgDetalle.Rows.Clear();
			//txtNeto.Text = "0";
			//txtDescuento.Text = "0";
			//txtTotalVenta.Text = "0";
			txtCantArticulo.Text = "0";
		}
		private void cargarCombos()
		{
			//cboCondPago
			N_CondPago nCondPago = new N_CondPago();
			List<E_CondPago> listCondPago = nCondPago.getAllCondPago();
			foreach (E_CondPago condPago in listCondPago)
			{
				ComboItem cboItem = new ComboItem();

				cboItem.Id = condPago.idCondPago;
				cboItem.Text = condPago.descripcion;
				cboCondPago.Items.Add(cboItem);
			}
			//cboVendedor
			N_Vendedor nVendedor = new N_Vendedor();
			List<E_Vendedor> listVendedor = nVendedor.getAll("");
			foreach (E_Vendedor vendedor in listVendedor)
			{
				ComboItem cboItem = new ComboItem();

				cboItem.Id = vendedor.idVendedor;
				cboItem.Text = vendedor.nombre;
				cboVendedor.Items.Add(cboItem);
			}
		}
		private void buscarProveedor()
		{
			N_Proveedor nProveedor = new N_Proveedor();
			//si el txt id de proveedor esta vacio pone por defecto el valor uno del consumidor final
			if (string.IsNullOrEmpty(txtIdProveedor.Text)) txtIdProveedor.Text = Convert.ToString(1);
			E_Proveedor proveedor = nProveedor.getOne(Convert.ToInt64(txtIdProveedor.Text));
			// si el proveedor es null es que no lo ah encontrado entonce se pone por defecto consumidor final
			if (proveedor == null) proveedor = nProveedor.getOne(1);
			txtIdProveedor.Text = proveedor.idProveedor.ToString();
			txtDescripcion.Text = proveedor.raSocial;
			txtCuitDni.Text = proveedor.cuit.ToString();
		}
		public void refrescarGrilla()
		{
			N_Articulo nArticulo = new N_Articulo();
			E_Articulo articulo = nArticulo.getOneArticulo(_codArticuloAgr);

			if (articulo == null) return;										  //c , btn
			dgDetalle.Rows.Add(new[] { articulo.codArticulo, articulo.descripcion ,articulo.observacion, "1", "X", articulo.stock.ToString() });
			// una vez terminado el agreafo vuelvo la variable de estado a null
			_codArticuloAgr = null;


		}
		//private void calcularPrecio(Int32 indexRow)
		//{
		//    //obtengo la cantidad
		//    Int32 cantidad = Convert.ToInt32(dgDetalle.Rows[indexRow].Cells[colCantidad.Index].Value);
		//    //obtengo el precio
		//    decimal precio = Convert.ToDecimal(dgDetalle.Rows[indexRow].Cells[colPrecio.Index].Value);
		//    //calculo el total
		//    decimal total = cantidad * precio;
		//    //cambio el toal de la celda
		//    dgDetalle.Rows[indexRow].Cells[4].Value = total;
		//    txtNeto.Text = calcularPrecioNeto().ToString();
		//}


		//private decimal calcularPrecioNeto()
		//{
		//    decimal precioTotal = 0;

		//    if (dgDetalle.Rows.Count != 0)
		//    {
		//        foreach (DataGridViewRow fila in dgDetalle.Rows)
		//        {
		//            precioTotal += Convert.ToDecimal(fila.Cells[colTotal.Index].Value); //celda precio final
		//        }
		//    }
		//    return precioTotal;
		//}
		//private decimal calcularDescuento()
		//{
		//    decimal totalDescuento = 0;
		//    if (!string.IsNullOrEmpty(txtDescuento.Text) && !string.IsNullOrEmpty(txtNeto.Text))
		//    {
		//        decimal descuento = Convert.ToDecimal(txtDescuento.Text);
		//        decimal precioNeto = Convert.ToDecimal(txtNeto.Text);
		//        if (cboTipDescuento.SelectedIndex == 0)//%
		//        {
		//            totalDescuento = descuento * precioNeto / 100;
		//        }
		//        else//$
		//        {
		//            totalDescuento = descuento;
		//        }
		//    }
		//    return totalDescuento;
		//}
		//private decimal calcularTotalCompra()
		//{
		//    decimal descuento = calcularDescuento();
		//    decimal neto = calcularPrecioNeto();
		//    decimal totalVenta = neto - descuento;

		//    txtNeto.Text = neto.ToString();
		//    txtDescVenta.Text = descuento.ToString();
		//    txtTotalVenta.Text = totalVenta.ToString();

		//    //calcular el total de articulos
		//    Int16 cantArticulo = 0;
		//    foreach (DataGridViewRow filaDetalle in dgDetalle.Rows)
		//    {
		//        cantArticulo += Convert.ToInt16(filaDetalle.Cells[colCantidad.Index].Value);
		//    }
		//    txtCantArticulo.Text = cantArticulo.ToString();

		//    return totalVenta;
		//}
		private Boolean generarPedido()
		{
			Boolean xConf = false;
			if (dgDetalle.Rows.Count == 0) return xConf;
			E_Pedido pedido = new E_Pedido();
			//Cargar cabecera
			pedido.proveedor.idProveedor = _idProveedor;
			pedido.proveedor.raSocial = txtDescripcion.Text;
			pedido.condPago.idCondPago = ((ComboItem)cboCondPago.SelectedItem).Id;
			pedido.cuit = txtCuitDni.Text;
			pedido.fecha = dtFecVenta.Value; ;
			pedido.observacion = txtObservacion.Text;
			pedido.vendedor.idVendedor = ((ComboItem)cboVendedor.SelectedItem).Id;
			pedido.direccion = txtDireccion.Text;
			pedido.anular = false;
			pedido.estadoPedido.idEstado = E_EstadoPedido.PENDIENTE;
			//compra.precioTotal = calcularTotalCompra();
			//Cargar detalle
			foreach (DataGridViewRow filaDetalle in dgDetalle.Rows)
			{
				E_DetallePedido detalle = new E_DetallePedido();
				detalle.codArticulo = filaDetalle.Cells[colCodArticulo.Index].Value.ToString();
				detalle.descripcionArt = filaDetalle.Cells[colDescripcion.Index].Value.ToString();
				detalle.observacionArt = filaDetalle.Cells[colObservacion.Index].Value.ToString();
				detalle.cantidad = Convert.ToInt16(filaDetalle.Cells[colCantidad.Index].Value);
				pedido.detalles.Add(detalle);
			}

			N_Pedido nPedido = new N_Pedido();
			string xRet = nPedido.addPedido(pedido);
			if (xRet != "0")
			{
				xConf = false;
			}
			else
			{
				xConf = true;
			}

			return xConf;
		}
		private void consultarPedido(Int64 codPedido)
		{
			N_Pedido nPedido = new N_Pedido();
			E_Pedido pedido = nPedido.getOnePedido(codPedido);
			//por si anula la venta
			//_VentaAnular = pedido;
			posicionarCbo(pedido.vendedor.idVendedor, pedido.condPago.idCondPago);




			//si esta anulada la venta
			if (pedido.anular) // si esta anulada la venta
			{
				//lblInfoAnular.Visible = true;

			}
			else // si no esta anulada
			{
				//mostrar el boton anular
				//btnAnularVenta.Visible = true;
			}
			//cabecera

			cboVendedor.Enabled = false;
			dtFecVenta.Enabled = false;
			txtIdProveedor.Enabled = false;
			txtDescripcion.ReadOnly = true;
			txtDireccion.ReadOnly = true;
			txtCuitDni.ReadOnly = true;
			cboCondPago.Enabled = false;
			txtObservacion.ReadOnly = true;
			btnBuscar.Enabled = false;

			if (pedido.estadoPedido.idEstado == E_EstadoPedido.PENDIENTE)
			{
				btnConfirmar.Visible = true;
				btnAnular.Visible = true;
			}
			else if (pedido.estadoPedido.idEstado == E_EstadoPedido.CONFIRMADO)
			{
				btnAnular.Visible = false;
				dgDetalle.Enabled = false;
				lblInfoAnular.Text = "Pedido Confirmado. Fecha de Entrega: " + pedido.fecEntrega.Value.Date.ToString("dd/MM/yyyy");
				lblInfoAnular.Visible = true;
				lblInfoAnular.ForeColor = Color.Blue;
			}
			else if (pedido.estadoPedido.idEstado == E_EstadoPedido.ANULADO)
			{
				lblInfoAnular.Visible = true;
				dgDetalle.Enabled = false;
			}
			txtIdProveedor.Text = pedido.proveedor.idProveedor.ToString();
			txtCodPedido.Text = pedido.codPedido.ToString();		
			txtObservacion.Text = pedido.observacion;
		
			//piso la direccion y el cuit
			buscarProveedor();
			txtDireccion.Text = pedido.direccion;
			txtCuitDni.Text = pedido.cuit;
			//botones
			btnAgrArticulo.Visible = false;
			btnCancelar.Visible = false;
			btnGenerarPedido.Visible = false;
			//datagrid



			cargarGrillaPedido(pedido);
			//btnPrimir
			btnImprimir.Visible = true;

		}
		private void posicionarCbo(Int64 idVendedor, Int64 idCondPago)
		{
			//cboVendedor

			foreach (ComboItem cboItem in cboVendedor.Items)
			{
				if (cboItem.Id == idVendedor) cboVendedor.SelectedItem = cboItem;
			}
			//cbocCondPago

			foreach (ComboItem cboItem in cboCondPago.Items)
			{
				if (cboItem.Id == idCondPago) cboCondPago.SelectedItem = cboItem;
			}

		}
		private void cargarGrillaPedido(E_Pedido pedido)
		{
			foreach (E_DetallePedido detPedido in pedido.detalles)
			{
				dgDetalle.Rows.Add(new[] { detPedido.codArticulo, detPedido.descripcionArt ,detPedido.observacionArt, detPedido.cantidad.ToString(), "X", detPedido.stockActual.ToString() });
			}

		}
		private Boolean estaCargado(string codArticulo)
		{
			Boolean xResp = false;
			foreach (DataGridViewRow rowDet in dgDetalle.Rows)
			{
				if (rowDet.Cells[colCodArticulo.Index].Value.ToString() == codArticulo)
				{
					xResp = true; //confirmo que esta seleccionado
					dgDetalle.Rows[rowDet.Index].Selected = true; //si ya esta cargado lo selecciono
				}
			}
			return xResp;
		}
		//Eventos
		private void txtIdProveedor_Leave(object sender, EventArgs e)
		{
			buscarProveedor();
		}
		private void dgDetalle_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.ColumnIndex == colCantidad.Index)
				{
					//coloca la celda de cantidad en edicion
					dgDetalle.BeginEdit(true);
				}
				if (e.ColumnIndex == colEliminar.Index)
				{
					dgDetalle.Rows.RemoveAt(e.RowIndex);
				}
			}
			catch (Exception)
			{


			}
		}
		private void dgDetalle_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.ColumnIndex == colCantidad.Index)
				{
					Int16 salida = 0;
					string cantidad = dgDetalle.Rows[e.RowIndex].Cells[colCantidad.Index].Value.ToString();
					if (!Int16.TryParse(cantidad, out salida))
					{
						dgDetalle.Rows[e.RowIndex].Cells[colCantidad.Index].Value = "1";
					}
				}
			}
			catch (Exception)
			{
				
			}
			
		}
		private void txtNumeros_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			if (!(char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar)))
				e.Handled = true;
		}
		private void txtDescuento_Leave(object sender, EventArgs e)
		{
			//calcularTotalCompra();
		}
		private void cboTipDescuento_SelectedIndexChanged(object sender, EventArgs e)
		{
			//calcularTotalCompra();
		}
        private void btnBuscar_Click(object sender, EventArgs e)
        {

            frmBsqProveedor bsqProveedor = new frmBsqProveedor(_frmName);
            bsqProveedor.ShowDialog();
            txtIdProveedor.Text = _idProveedor.ToString();
            buscarProveedor();
        }
        private void btnAgrArticulo_Click(object sender, EventArgs e)
        {
            frmAgrDetalle frmAgrDetalle = new frmAgrDetalle(_frmName);
            frmAgrDetalle.ShowDialog();
            if (_codArticuloAgr == null) return;
			if (!estaCargado(_codArticuloAgr)) // si no esta cargado en el detalle
			{
				refrescarGrilla();	
			}
        }
        private void btnConfPedido_Click(object sender, EventArgs e)
        {
            if (generarPedido())
            {
                MessageBox.Show("¡El pedido se realizó con Exito!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                valPrederteminado();
            }//si se realizo bien la venta
            else
            {
                MessageBox.Show("¡No se ha cargado ningun articulo al detalle!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            valPrederteminado();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		private void btnAnular_Click(object sender, EventArgs e)
		{
			N_Pedido nPedido = new N_Pedido();

			Int64 codPedido = Convert.ToInt64(txtCodPedido.Text);
			Boolean xConf = nPedido.anularPedido(codPedido);

			if (!xConf)
			{
				MessageBox.Show("¡No se pudo anular la venta!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else // se confirmao la anulacion
			{
				lblInfoAnular.Visible= false;
				btnAnular.Visible = false;
			}
		}
		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			if (dgDetalle.Rows.Count > 0)
			{
				E_Pedido pedido = new E_Pedido();
				
				pedido.codPedido = Convert.ToInt64(txtCodPedido.Text);
				pedido.observacion = txtObservacion.Text;

				foreach (DataGridViewRow filaDetalle in dgDetalle.Rows)
				{
					E_DetallePedido detalle = new E_DetallePedido();
					detalle.codArticulo = filaDetalle.Cells[colCodArticulo.Index].Value.ToString();
					detalle.descripcionArt = filaDetalle.Cells[colDescripcion.Index].Value.ToString();
					detalle.observacionArt = filaDetalle.Cells[colObservacion.Index].Value.ToString();
					detalle.cantidad = Convert.ToInt16(filaDetalle.Cells[colCantidad.Index].Value);
					pedido.detalles.Add(detalle);
				}

				frmConfPedido frmConf = new frmConfPedido();
				frmConf.ShowDialog();

				if (_fecEntrega != null)// si se confirmo
				{
					N_Pedido nPedido = new N_Pedido();
					pedido.fecEntrega = _fecEntrega;
					Boolean xConf = nPedido.confirmarPedido(pedido);
					

					if (xConf)
					{
						lblInfoAnular.Text = "Pedido Confirmado. Fecha de Entrega: " + _fecEntrega;
						lblInfoAnular.Visible = true;
						lblInfoAnular.ForeColor = Color.Blue;
						dgDetalle.Enabled = false;
						btnConfirmar.Visible = false;
					}
					_fecEntrega = null;// vuelvo la fecha a null porque es static
				}
			}
			else
			{
				MessageBox.Show("¡No se ha cargado ningun artículo al detalle!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}


		}
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void lblInfoAnular_Click(object sender, EventArgs e)
        {

        }

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			try
			{
				string ruta = Application.StartupPath + "\\crPedido.rpt";
				ReportDocument rpt = new ReportDocument();

				dsPedido dsPintureriaPedido = new dsPedido();

				dsPintureriaPedido.EnforceConstraints = false;

				dsPedidoTableAdapters.ArticulosTableAdapter articuloTableAdap = new dsPedidoTableAdapters.ArticulosTableAdapter();
				dsPedidoTableAdapters.PedidosTableAdapter pedidoTableAdap = new dsPedidoTableAdapters.PedidosTableAdapter();
				dsPedidoTableAdapters.DetallePedidoTableAdapter detPedidoTableAdap = new dsPedidoTableAdapters.DetallePedidoTableAdapter();
				dsPedidoTableAdapters.ProveedoresTableAdapter proveedoresTableAdap = new dsPedidoTableAdapters.ProveedoresTableAdapter();
				dsPedidoTableAdapters.EstadosPedidosTableAdapter estadosPedidoTableAadap = new dsPedidoTableAdapters.EstadosPedidosTableAdapter();

				// llenos los tabla adapter

				articuloTableAdap.Fill(dsPintureriaPedido.Articulos);
				detPedidoTableAdap.Fill(dsPintureriaPedido.DetallePedido);
				proveedoresTableAdap.Fill(dsPintureriaPedido.Proveedores);
				estadosPedidoTableAadap.Fill(dsPintureriaPedido.EstadosPedidos);

				Int64 codPedido = Convert.ToInt64(txtCodPedido.Text);
				pedidoTableAdap.FillByGetOnePedido(dsPintureriaPedido.Pedidos, codPedido);
				

				rpt.Load(ruta);
				rpt.SetDataSource(dsPintureriaPedido);


				frmRptVisor frmVerRpt = new frmRptVisor(rpt);
				frmVerRpt.Show();
			}
			catch (Exception)
			{

				MessageBox.Show("No se pudo generar el reporte de Pedidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

	

	}
}

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
	public partial class frmVenta : Form
	{
		//variables de estados

		public static E_DetalleVenta _detNvoArticulo;// la utilizo cuando agrego un nuevo articulo al detalle que no que se encutra registrado en el sistema
		public static string _frmName = "frmVenta";
		public static string _codArticuloAgr;
		public static Int64 _idCliente = 1; //idCliente por defecto consumidor final
		public static Boolean _confVenta = false;
		public Int64 _codVenta ;
		//Variable de presupuesto
		public static DateTime? _fecFinPresupuesto;
		//variable para guardar los precios por si restablece 
		List<decimal> lisPrecioDetalle;
		//variable por si anula la venta
		private E_Venta _VentaConsultada; 
		//variables de DataGrid para las celdas cantidad y precio
		private decimal _cellPrecioAnt;
		//contructor
		public frmVenta()
		{
			InitializeComponent();
			_codArticuloAgr = null;
			cargarCombos();
			valPrederteminado();
			buscarCliente();
			_codVenta = 0;
			_fecFinPresupuesto = null;
		}
		/// <summary>
		/// Constructor para la consulta de una venta
		/// </summary>
		/// <param name="codVenta"> al que se va consultar</param>
		public frmVenta(Int64 codVenta)//contructor cuando consulta
		{
			InitializeComponent();
			_codVenta = codVenta;
			cargarCombos();
			consultarVenta();
			
		}
		//Evento del Formuladrio
		private void frmVenta_Load(object sender, EventArgs e)
		{
			dgDetalle.ClearSelection();
			

		}
		private void frmVenta_Deactivate(object sender, EventArgs e)
		{
			//this.WindowState = FormWindowState.Minimized;
		}
		//Metodos
		private void generarRemito( Int64 codVenta )
		{
			try
			{
				string ruta = Application.StartupPath + "\\crRemitoVenta.rpt";
				ReportDocument rpt = new ReportDocument();

				dsVentas dsPintureriaVenta = new dsVentas();

				dsPintureriaVenta.EnforceConstraints = false;
				dsVentasTableAdapters.ClientesTableAdapter clienteTableAdap = new dsVentasTableAdapters.ClientesTableAdapter();
				dsVentasTableAdapters.CondPagoTableAdapter condPagoTableAdap = new dsVentasTableAdapters.CondPagoTableAdapter();
				dsVentasTableAdapters.DetalleVentaTableAdapter detVentaTableAdap = new dsVentasTableAdapters.DetalleVentaTableAdapter();
				dsVentasTableAdapters.AbonarVentaTableAdapter abonarVentaTableAdap = new dsVentasTableAdapters.AbonarVentaTableAdapter();
				dsVentasTableAdapters.VendedoresTableAdapter vendedorTableAdap = new dsVentasTableAdapters.VendedoresTableAdapter();
				dsVentasTableAdapters.VentasTableAdapter ventaTableAdap = new dsVentasTableAdapters.VentasTableAdapter();
				dsVentasTableAdapters.ArticulosTableAdapter articuloTableAdap = new dsVentasTableAdapters.ArticulosTableAdapter();
				dsVentasTableAdapters.MarcasTableAdapter marcasTableAdap = new dsVentasTableAdapters.MarcasTableAdapter();

				// llenos los tabla adapter

				clienteTableAdap.Fill(dsPintureriaVenta.Clientes);
				condPagoTableAdap.Fill(dsPintureriaVenta.CondPago);
				abonarVentaTableAdap.Fill(dsPintureriaVenta.AbonarVenta);
				vendedorTableAdap.Fill(dsPintureriaVenta.Vendedores);
				detVentaTableAdap.Fill(dsPintureriaVenta.DetalleVenta);
				articuloTableAdap.Fill(dsPintureriaVenta.Articulos);
				marcasTableAdap.Fill(dsPintureriaVenta.Marcas);

				ventaTableAdap.FillByGetOneVenta(dsPintureriaVenta.Ventas, codVenta);

				rpt.Load(ruta);
				rpt.SetDataSource(dsPintureriaVenta);


				frmRptVisor frmVerRpt = new frmRptVisor(rpt);
				frmVerRpt.Show();
			}
			catch (Exception e)
			{

				MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void generarPresupuesto()
		{
			try
			{
				
				dsVentas dsPresupuestoVenta = new dsVentas();

				dsPresupuestoVenta.EnforceConstraints = false;
				dsVentas.cabPresupuestoRow cabPresuepuesto = dsPresupuestoVenta.cabPresupuesto.NewcabPresupuestoRow();
				dsVentas.detPresupuestoRow detPresupuesto;
				
				//Crear la cabecera
				cabPresuepuesto.Cliente = txtDescripcion.Text;
				cabPresuepuesto.Direccion = txtDireccion.Text;
				cabPresuepuesto.dniCliente = txtCuitDni.Text;
				cabPresuepuesto.Fecha = dtFecVenta.Value.Date.ToString("dd/MM/yyyy");
				cabPresuepuesto.FechaFin = _fecFinPresupuesto.Value.ToString("dd/MM/yyyy");
				cabPresuepuesto.Vendedor = cboVendedor.Text;
				cabPresuepuesto.Observacion = txtObservacion.Text;
				cabPresuepuesto.Descuento = Convert.ToDecimal(txtDescVenta.Text);
				dsPresupuestoVenta.cabPresupuesto.AddcabPresupuestoRow(cabPresuepuesto);


				foreach (DataGridViewRow rowDet in dgDetalle.Rows)
				{
					detPresupuesto = dsPresupuestoVenta.detPresupuesto.NewdetPresupuestoRow();
					detPresupuesto.codArticulo = rowDet.Cells[colCodArticulo.Index].Value.ToString();
					detPresupuesto.Descripcion = rowDet.Cells[colDescripcion.Index].Value.ToString();
					detPresupuesto.Observacion = rowDet.Cells[colObservacion.Index].Value.ToString();
					detPresupuesto.Cantidad = rowDet.Cells[colCantidad.Index].Value.ToString();
					detPresupuesto.Precio = rowDet.Cells[colPrecio.Index].Value.ToString();
					detPresupuesto.Total = Convert.ToDecimal(rowDet.Cells[colTotal.Index].Value.ToString());

					dsPresupuestoVenta.detPresupuesto.AdddetPresupuestoRow(detPresupuesto);
				}

				string ruta = Application.StartupPath + "\\crPresupuesto.rpt";
				ReportDocument rpt = new ReportDocument();
				rpt.Load(ruta);
				rpt.SetDataSource(dsPresupuestoVenta);

				frmRptVisor frmVerRpt = new frmRptVisor(rpt);
				frmVerRpt.Show();
			}
			catch (Exception)
			{

				throw;
			}

		}
		private void consultarVenta()
		{
			N_Venta nVenta = new N_Venta();
			E_Venta venta = nVenta.getOneVenta(_codVenta);

            if (venta == null)
            {
                MessageBox.Show(PintError.MsjError, "consultarVenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
			//por si anula la venta
			_VentaConsultada = venta;
			posicionarCbo(venta.vendedor.idVendedor,venta.condPago.idCondPago);



			//si esta anulada la venta
			if (!venta.anular) // si esta no esta anulada la venta
			{
				if (venta.saldo > 0) // si tiene saldo deudor
				{
					txtSaldo.Text = venta.saldo.ToString();
					txtAbonado.Text = venta.abonado.ToString("N2");
					grSaldo.Visible = true;
					btnAplicarRecargo.Visible = true;
				}
				else
				{
					grSaldo.Visible = false;
				}
				btnAnularVenta.Visible = true;
				
			}
			else // si esta anulada
			{
				//mostrar el boton anular	
				lblInfoAnular.Visible = true;
			}
			//cabecera
			
			cboVendedor.Enabled = false;
			dtFecVenta.Enabled = false;
			txtIdCliente.ReadOnly = true;
			txtDescripcion.ReadOnly = true;
			txtDireccion.ReadOnly = true;
			txtCuitDni.ReadOnly = true;
			cboCondPago.Enabled = false;
			cboTipDescuento.Enabled = false; //09/07/2015 fue comentado NB 
           // cboTipDescuento.SelectedIndex = 1;
            //txtDescuento.ReadOnly = true; 09/07/2015 fue comentado NB
			txtObservacion.ReadOnly = true;
			btnBuscar.Enabled = false;
			txtIdCliente.Enabled = false;



			txtIdCliente.Text = venta.cliente.idCliente.ToString();
			txtCodVenta.Text = venta.codVenta.ToString();
           
            txtDescVenta.Text = venta.descuento.ToString();
			txtObservacion.Text = venta.observacion;
			txtTotalVenta.Text = venta.precioTotal.ToString();

			//recargo
			if (venta.recargo > 0)// si tiene recargo
			{
				txtRecargo.Text = venta.recargo.ToString("N2");
				lblRecargo.Visible = true;
				txtRecargo.Visible = true;
			}
			else
			{
				txtRecargo.Text = "0";
				lblRecargo.Visible = false;
				txtRecargo.Visible = false;
			}
			lblCancelarRecargo.Visible = false;
			//piso la direccion y el cuit
			buscarCliente(venta.cliente.idCliente);
			txtDireccion.Text = venta.direccion;
			txtCuitDni.Text = venta.cuit;
			//botones
			btnAgrArticulo.Visible = false;
			btnAgreNvoArticulo.Visible = false;
			btnCancelar.Visible = false;
			btnConfVenta.Visible = venta.cliente.idCliente != 1; // Solo se muestra el boton cuando es un cliente
            btnPresupuesto.Visible = venta.cliente.idCliente != 1; // Solo se muestra el boton cuando es un cliente

			if (btnAplicarRecargo.Text == "Confirmar Recargo") btnAplicarRecargo.Text = "Aplicar &Recargo";
			grSaldo.Enabled = true;
			//datagridmar
			cargarGrillaDetVenta(venta);

            //Luego de cargar los productos vendidos calculo el precio neto
            txtNeto.Text = calcularPrecioNeto().ToString(); // 09/07/2015 fue agregado NB

				//Modifico la columna cantidad 
            if (venta.cliente.idCliente == 1)
            {
                colCantidad.ReadOnly = true;
                colCantidad.DefaultCellStyle.BackColor = Color.White;
                colCantidad.DefaultCellStyle.SelectionBackColor = colDescripcion.DefaultCellStyle.SelectionBackColor;
            }
			
			
				//Modifico la columna precio
				colPrecio.ReadOnly = true;
				colPrecio.DefaultCellStyle.BackColor = Color.White;
				colPrecio.DefaultCellStyle.SelectionBackColor = colDescripcion.DefaultCellStyle.SelectionBackColor;
            //Habilito la grilla detalle segun sea el cliente , si es un consumidor final no se puede modificar la cantidad
                dgDetalle.Enabled = venta.cliente.idCliente != 1;
			this.dgDetalle.ClearSelection();

			//Imprimir
			btnImprimir.Visible = true;
            //calcularTotalVenta(); 09/07/2015 fue comentado NB

            //Credito Uitlizado
            if (venta.creditoUtilizado > 0)
            {
                gbCreditoUtilizado.Visible = true;
                txtCreditoUtilizado.Text = venta.creditoUtilizado.ToString("N2");
            }
		}
		private void cargarGrillaDetVenta(E_Venta venta)
		{
            //dgDetalle.Rows.Clear();
			colCodArticulo.DataPropertyName = "codArticulo";
			colDescripcion.DataPropertyName = "descripcion";
			colCantidad.DataPropertyName = "cantidad";
			colPrecio.DataPropertyName = "precioArticulo";
			colTotal.DataPropertyName = "precioTotal";
			//colStock.DataPropertyName = "stock";
			dgDetalle.AutoGenerateColumns = false;
			dgDetalle.DataSource = venta.detalles;
			
		}
		private void cargarCombos()
		{
			//cboCondPago
			N_CondPago nCondPago = new N_CondPago();
			List<E_CondPago> listCondPago = nCondPago.getAllCondPago();
			foreach (E_CondPago condPago in listCondPago)
			{
				
				if (condPago.idCondPago != 2)
				{
					ComboItem cboItem = new ComboItem(); // FILTRO LAS CUENTA CORRIENTE YA QUE SE CREA AUTOMATICAMENTE CUANDO QUEDA DEVIENDO

					cboItem.Id = condPago.idCondPago;
					cboItem.Text = condPago.descripcion;
					cboCondPago.Items.Add(cboItem);
				}
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
       
		/// <summary>
		/// metodo static global para regrescar la grilla de articulo
		/// </summary>
		public void refrescarGrilla()
		{
			N_Articulo nArticulo = new N_Articulo();
			E_Articulo articulo = nArticulo.getOneArticulo(_codArticuloAgr);

			if (articulo == null) return;
			dgDetalle.Rows.Add(new[] { articulo.codArticulo, articulo.descripcion,articulo.observacion, "1", articulo.precioFinal.ToString(),  articulo.precioFinal.ToString(), "X" ,articulo.stock.ToString() });
			// una vez terminado el agreafo vuelvo la variable de estado a null
			_codArticuloAgr = null;
			
		}
		/// <summary>
		/// busca el cliente 1 que es el consumidor final , el cliente por defecto
		/// </summary>
		private void buscarCliente()
		{
			N_Cliente ncliente = new N_Cliente();
			//si el txt id de cliente esta vacio pone por defecto el valor uno del consumidor final
			if (string.IsNullOrEmpty(txtIdCliente.Text)) txtIdCliente.Text = Convert.ToString(1);
			E_Cliente cliente = ncliente.getOne(Convert.ToInt64(txtIdCliente.Text));
			// si el cliete es null es que no lo ah encontrado entonce se pone por defecto consumidor final
			if (cliente == null) cliente = ncliente.getOne(1);
			txtIdCliente.Text = cliente.idCliente.ToString();
			txtDescripcion.Text = cliente.descripcion;
			txtDireccion.Text = cliente.direccion;
			txtCuitDni.Text = cliente.dni.ToString();
			if (cliente.boletinProtec) // si tiene boletin protectivo le muestra una cartel
			{
				MessageBox.Show("El Cliente Se Encuentra en el boletin Protectivo", "Boletin Protectivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}
		private void buscarCliente(Int64 idCliente)
		{
			N_Cliente ncliente = new N_Cliente();
			E_Cliente cliente = ncliente.getOne(Convert.ToInt64(idCliente));
			txtIdCliente.Text = cliente.idCliente.ToString();
			txtDescripcion.Text = cliente.descripcion;
			txtDireccion.Text = cliente.direccion;
			txtCuitDni.Text = cliente.dni.ToString();
			if (cliente.boletinProtec) // si tiene boletin protectivo le muestra una cartel
			{
				MessageBox.Show("El Cliente Se Encuentra en el boletin Protectivo", "Boletin Protectivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}

		}
		private void valPrederteminado()
		{
			N_Venta nVenta = new N_Venta();
			Int64 ultCodVenta = nVenta.ultCodVenta();
			txtUltVenta.Text = ultCodVenta.ToString();
			txtCodVenta.Text = (ultCodVenta + 1).ToString();
			cboVendedor.SelectedIndex = 0;  //primer vendedor
			cboCondPago.SelectedIndex = 0; // efectivo
			cboTipDescuento.SelectedIndex = 0;//%
			btnAgrArticulo.Focus();
			dgDetalle.Rows.Clear();
			txtNeto.Text = "0";
			txtDescuento.Text = "0";
			txtTotalVenta.Text = "0";
			txtCantArticulo.Text = "0";
		}
		private void calcularPrecioNeto(Int32 indexRow)
		{
			//obtengo la cantidad
			Int32 cantidad = Convert.ToInt32(dgDetalle.Rows[indexRow].Cells[colCantidad.Index].Value);
			//obtengo el precio
			decimal precio = Convert.ToDecimal(dgDetalle.Rows[indexRow].Cells[colPrecio.Index].Value);
			//calculo el total
			decimal total = cantidad * precio;
			//cambio el toal de la celda
			dgDetalle.Rows[indexRow].Cells[colTotal.Index].Value = total;
			txtNeto.Text =  calcularPrecioNeto().ToString();

		}
		private decimal calcularPrecioNeto()
		{
			decimal precioTotal = 0;

			if (dgDetalle.Rows.Count != 0)
			{
				foreach (DataGridViewRow fila in dgDetalle.Rows)
				{
					precioTotal += Convert.ToDecimal(fila.Cells[colTotal.Index].Value); //celda precio final
				}
			}
			return precioTotal;
		}
		private decimal calcularDescuento()
		{
			decimal totalDescuento  = 0 ;
			if (!string.IsNullOrEmpty(txtDescuento.Text) && !string.IsNullOrEmpty(txtNeto.Text))
			{
				decimal descuento = Convert.ToDecimal(txtDescuento.Text);
				decimal precioNeto = Convert.ToDecimal(txtNeto.Text);
				if (cboTipDescuento.SelectedIndex == 0)//%
				{
					totalDescuento = descuento * precioNeto / 100;
				}
				else//$
				{
                    
					totalDescuento = descuento;
				}
			}
            //Esta consultando una venta 
            if (_VentaConsultada != null)
            {
                totalDescuento += _VentaConsultada.descuento;// El descuento los sumo al descuento anterior Agregado 09/07/2015 NB
                txtDescuento.Text = "";
            }
          
			return totalDescuento;
		}
		private decimal calcularTotalVenta()
		{
		    decimal descuento = calcularDescuento();
			decimal neto = calcularPrecioNeto();
			decimal recargo = Convert.ToDecimal(txtRecargo.Text);
			decimal totalVenta = (neto - descuento) + recargo;

			txtNeto.Text = neto.ToString();
			// va calcular siempre y cuando este cargando una venta
			//if(_codVenta==0) txtDescVenta.Text = descuento.ToString("N2"); //Comentado 09/07/2015 NB
            txtDescVenta.Text = descuento.ToString("N2"); //Ahora permito que se calcule el descuento cuando consulta una venta
			if (_codVenta==0) txtTotalVenta.Text = totalVenta.ToString("N2");

			//calcular el total de articulos
			Int16 cantArticulo = 0;
            foreach (DataGridViewRow filaDetalle in dgDetalle.Rows)
            {
                cantArticulo += Convert.ToInt16(filaDetalle.Cells[colCantidad.Index].Value);
            }


			txtCantArticulo.Text = cantArticulo.ToString();
			txtTotalVenta.Text = totalVenta.ToString("N2");

            if (_VentaConsultada != null) // Si esta consultando la venta 
            {// Modifico el saldo del cliente por si acaso se le aplicado mas descuento Agregado 09/07/2015 NB
                  txtSaldo.Text = (totalVenta - _VentaConsultada.abonado).ToString("N2");
			
			
                //_VentaConsultada.saldo = totalVenta - _VentaConsultada.abonado;
                _VentaConsultada.descuento = descuento; //Cambio del descuento
                //_VentaConsultada.precioTotal = totalVenta;
            }

			return totalVenta;
		}
		private Boolean confirmarVenta()
		{
			Boolean xConf = false;
			if (dgDetalle.Rows.Count == 0) return xConf;
			E_Venta venta = new E_Venta();
			//Cargar cabecera
            venta.codVenta = _codVenta;
			venta.cliente.idCliente = Convert.ToInt64(txtIdCliente.Text);
			venta.cliente.descripcion = txtDescripcion.Text;
			venta.condPago.idCondPago = ((ComboItem)cboCondPago.SelectedItem).Id;
			venta.cuit = txtCuitDni.Text;
			venta.fecha = dtFecVenta.Value; ;
			venta.observacion = txtObservacion.Text;
			venta.vendedor.idVendedor = ((ComboItem)cboVendedor.SelectedItem).Id;
			venta.direccion = txtDireccion.Text;
			venta.anular = false;
			venta.precioTotal = calcularTotalVenta();
			venta.descuento = calcularDescuento();
			
			
			//Cargar detalle
			foreach (DataGridViewRow filaDetalle in dgDetalle.Rows)
			{
				E_DetalleVenta detalle = new E_DetalleVenta();

				detalle.codArticulo = filaDetalle.Cells[colCodArticulo.Index].Value.ToString();
				detalle.descripcion = filaDetalle.Cells[colDescripcion.Index].Value.ToString();
				detalle.cantidad = Convert.ToInt16(filaDetalle.Cells[colCantidad.Index].Value);
				detalle.precioArticulo = Convert.ToDecimal( filaDetalle.Cells[colPrecio.Index].Value);
				detalle.stockActual = Convert.ToInt16(filaDetalle.Cells[colStock.Index].Value);
				detalle.precioTotal = Convert.ToDecimal(filaDetalle.Cells[colTotal.Index].Value);

				venta.detalles.Add(detalle);
			}

            if (_codVenta == 0) // Nueva Venta
            {
                //Confirmar la entrega
                frmConfVenta frmConf = new frmConfVenta(venta, _frmName);
                frmConf.ShowDialog();

                // el frm ConfVenta devuelve TRUE o False si se confirmar la venta lo guarda en la variable de clase 
                xConf = _confVenta;
            }
            else //Modificar una venta
            {
                if (MessageBox.Show("Estas Seguro que deseas modificar la venta", "Modificar Venta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    bool generarNotaCredito = true;

                    //Si se le agrega producto a la venta no genera nota de credito
                    if (_VentaConsultada.precioTotal <= venta.precioTotal) generarNotaCredito =  false;

                    /**
                     * Si lo abonado es menor al precio total o igual
                     * en el caso de que sea menor no genera porque queda deviendo
                     * si es igual no genera porque paga el total de la venta
                     **/
                    if (_VentaConsultada.abonado <= venta.precioTotal) generarNotaCredito = false;

                    if (generarNotaCredito) // si genero la nota de credito
                    {
                          decimal montoCredito =  _VentaConsultada.abonado - venta.precioTotal ; // El credito es la diferencia de la venta consultada y la venta modficada
                    //decimal montoCredito = this._VentaConsultada.abonado
                    //Nota Credito
                    frmConfVentaCredito frm = new frmConfVentaCredito(venta, montoCredito);
                    DialogResult oResult =  frm.ShowDialog();
                    }
                  

                    //MOdifico la venta
                    Negocio.N_Venta nVenta = new N_Venta();
                    nVenta.ModificarVenta(venta);
                    xConf = true;

                    //if (oResult == DialogResult.OK) //Se confirmo y se genero la nota de credito
                    //{
                    //    //MOdifico la venta
                    //    Negocio.N_Venta nVenta = new N_Venta();
                    //    nVenta.ModificarVenta(venta);
                    //    xConf = true;
                    //}
                    //else if (oResult == DialogResult.Cancel) // El usuario no quiso generar la nota de credito , devuelve el dinero
                    //{
                    //    //Devuele el dinero, se modifca lo abonado por el cliente
                    //    //MOdifico la venta
                    //    Negocio.N_Venta nVenta = new N_Venta();
                    //    nVenta.ModificarVenta(venta);
                    //    xConf = true;

                    //}
                    //else if (oResult == DialogResult.Abort) //Surgio un error no se pudo generar la nota de credito
                    //{
                    //    //Por el momento nada
                    //    xConf = true;
                    //}

                }


              
            }
			
			return xConf;
		}
		private void posicionarCbo(Int64 idVendedor,Int64 idCondPago)
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
		private Boolean estaCargado(string codArticulo)
		{
			Boolean xResp = false;
			foreach (DataGridViewRow rowDet in dgDetalle.Rows)
			{
				//string _codArticulo = rowDet.Cells[colCodArticulo.Index].Value.ToString();
				if (rowDet.Cells[colCodArticulo.Index].Value.ToString() != "#") // si no tiene codigo no pregunto si ya esta cargado
				{
					if (rowDet.Cells[colCodArticulo.Index].Value.ToString() == codArticulo)
					{
						xResp = true; //confirmo que esta seleccionado
						dgDetalle.Rows[rowDet.Index].Selected = true; //si ya esta cargado lo selecciono
					}
				}
			}
			return xResp;
		}
		//Eventos
		private void txtIdCliente_Leave(object sender, EventArgs e)
		{
			buscarCliente();
		}
		private void txtNumeros_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

			if (!(char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar)))
				e.Handled = true;
		}
		private void txtPrecio_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

			if (e.KeyChar == '.')
			{
				e.Handled = true;
				SendKeys.Send(",");
			}

			char coma = Convert.ToChar(",");
            char menos = Convert.ToChar("-");

            if (_VentaConsultada != null) //Esta consultando
            {
               

                //Si esta consultando permito que ingrese numeros negativo
                if (!e.KeyChar.Equals(menos))
                {

                    if (!(char.IsNumber(e.KeyChar) | e.KeyChar.Equals(coma) | char.IsControl(e.KeyChar)))
                        e.Handled = true;
                }
            }
            else
            {
                if (!(char.IsNumber(e.KeyChar) | e.KeyChar.Equals(coma) | char.IsControl(e.KeyChar)))
                    e.Handled = true;
            }
			
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
                    //Si esta consultado una venta
                    if (_VentaConsultada != null)
                    {
                        foreach (Entidades.E_DetalleVenta det in _VentaConsultada.detalles)
                        {
                            if (det.codArticulo == dgDetalle.Rows[e.RowIndex].Cells[colCodArticulo.Index].Value.ToString())
                            {
                                _VentaConsultada.detalles.Remove(det);
                                break;
                            }
                        }
                        cargarGrillaDetVenta(_VentaConsultada);
                    }
                    else
                    {
                        dgDetalle.Rows.RemoveAt(e.RowIndex);
                        calcularTotalVenta();
                    }
					
				}
				if (btnAplicarRecargo.Text == "Confirmar Recargo")
				{
					_cellPrecioAnt = Convert.ToDecimal (dgDetalle.CurrentCell.Value);
					dgDetalle.BeginEdit(true);
				}
			}
			catch (Exception)
			{
				
				
			}
		}
		private void dgDetalle_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			
			if (e.ColumnIndex == colCantidad.Index)
			{
				try
				{
					Int16 salida = 0;
					string cantidad = dgDetalle.Rows[e.RowIndex].Cells[colCantidad.Index].Value.ToString();
					if (Int16.TryParse(cantidad, out salida))
					{
						calcularPrecioNeto(e.RowIndex);
						calcularTotalVenta();
					}
					else
					{
						dgDetalle.Rows[e.RowIndex].Cells[colCantidad.Index].Value = "1";
					}
				}
				catch (Exception)
				{
					dgDetalle.Rows[e.RowIndex].Cells[colCantidad.Index].Value ="1";
				}
				
			}
			if (colPrecio.Index == e.ColumnIndex && _VentaConsultada != null)
			{
				try
				{
					decimal precioOut ;
					string precio = dgDetalle.Rows[e.RowIndex].Cells[colPrecio.Index].Value.ToString();
					if (decimal.TryParse(precio, out precioOut))
					{
						dgDetalle.Rows[e.RowIndex].Cells[colPrecio.Index].Value = precioOut;
						calcularPrecioNeto(e.RowIndex);
						decimal totalVenta =  calcularTotalVenta();
						// Saldo Cliente
                        decimal saldoCliente = totalVenta - _VentaConsultada.abonado;

                        if (saldoCliente >= 0) // si el saldo es positivo
                        {
                            //le queda saldo pendiente
                            lblSaldo.Text = "Saldo";
                            txtSaldo.Text = saldoCliente.ToString("N2");

                        }
                        else // saldo negativo
                        {
                            // significa que habia habonado y devuelve algunos productos
                            // y lo abonado es mayor al total de venta
                            lblSaldo.Text = "Credito";
                            txtSaldo.Text = (saldoCliente * -1).ToString("N2");
                            
                        }

						//txtSaldo.Text = (totalVenta -_VentaConsultada.abonado ).ToString("N2");
					}
					else
					{
						dgDetalle.Rows[e.RowIndex].Cells[colPrecio.Index].Value = _cellPrecioAnt.ToString("N2");
					}

				}
				catch (Exception)
				{

					dgDetalle.Rows[e.RowIndex].Cells[colPrecio.Index].Value = _cellPrecioAnt.ToString("N2");
				}
			}
		}
		private void txtDescuento_Leave(object sender, EventArgs e)
		{
			calcularTotalVenta();
            if (_VentaConsultada != null) //Esta consultando una venta
            {

                N_Venta nVenta = new N_Venta();
                if (nVenta.setDescuento(_VentaConsultada.descuento, _VentaConsultada.precioTotal,_VentaConsultada.codVenta))
                {
                    consultarVenta();
                }
                    
                
            }

		}
		private void cboTipDescuento_SelectedIndexChanged(object sender, EventArgs e)
		{
			calcularTotalVenta();

		}
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBsqCliente bsqCliente = new frmBsqCliente(_frmName);
            bsqCliente.ShowDialog();
            txtIdCliente.Text = _idCliente.ToString();
            buscarCliente();
        }
        private void btnAgrArticulo_Click(object sender, EventArgs e)
        {
            frmAgrDetalle agrDetalle = new frmAgrDetalle(_frmName);
            agrDetalle.ShowDialog();
            if (_codArticuloAgr == null) return;

            if (!estaCargado(_codArticuloAgr)) // si no esta cargado en el detalle
            {
                refrescarGrilla();
                calcularTotalVenta();
            }
		
        }
        private void btnAnularVenta_Click(object sender, EventArgs e)
        {


            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea anular la venta?", "Anular", MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Information);

            switch (respuesta)
            {
                case DialogResult.Yes:
                    
            N_Venta nVenta = new N_Venta();
            Boolean ventaAnulada = nVenta.anularVenta(_VentaConsultada);
            if (ventaAnulada)// si la venta a sido a anulada
            {
                lblInfoAnular.Visible = true;
                btnAnularVenta.Visible = false;
            }
            else // si no ah sido anulada
            {
                MessageBox.Show("No se pudo anular la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                    break;
                case DialogResult.No:

                    break;
            }
            
            
        }
        private void btnConfVenta_Click_1(object sender, EventArgs e)
        {
            if (dgDetalle.Rows.Count != 0)
            {
                if (confirmarVenta())
                {
                 DialogResult XResult =  MessageBox.Show("¡La venta se realizó con Exito! ¿Desea Imprimir el comprobante?", "Operación exitosa", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
					switch (XResult)
					{
						case DialogResult.Yes: //Genera el remito de venta
							{
								N_Venta nVenta = new N_Venta();
								Int64 codVenta = nVenta.ultCodVenta();
								generarRemito(codVenta);
								break;
							}
					}
                    //Si no esta consultando
                    if (_VentaConsultada == null) valPrederteminado();
                   

                }//si se realizo bien la venta
                else
                {
                    MessageBox.Show("No se pudo realizar la venta","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
                _confVenta = false;
            }
            else
            {
                MessageBox.Show("¡No se ha cargado ningun articulo al detalle!", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		private void btnAbonar_Click(object sender, EventArgs e)
		{
			frmAbonado frmAbonarVenta = new frmAbonado(_VentaConsultada);
			frmAbonarVenta.ShowDialog();
			consultarVenta();
		}
		private void btnAplicarRecargo_Click(object sender, EventArgs e)
		{

			dgDetalle.Enabled = true;

			if (btnAplicarRecargo.Text == "Aplicar &Recargo")
			{
				//coloca la celda de precio unitario en edicion
				colPrecio.ReadOnly = false;
				colPrecio.DefaultCellStyle.BackColor = Color.FromArgb(192, 255, 192);
				btnAplicarRecargo.Text = "Confirmar Recargo";
				//Desavilito los demas botones
				grSaldo.Enabled = false;
				lblCancelarRecargo.Visible = true;

			}
			else
			{

				List<E_DetalleVenta> listDet = new List<E_DetalleVenta>();
				foreach (DataGridViewRow detRow in dgDetalle.Rows)
				{
					E_DetalleVenta det = new E_DetalleVenta();

					det.idDetalle = Convert.ToInt64(detRow.Cells[colIdDetalle.Index].Value);
					det.precioArticulo = Convert.ToDecimal(detRow.Cells[colPrecio.Index].Value);
					det.precioTotal = Convert.ToDecimal(detRow.Cells[colTotal.Index].Value);

					listDet.Add(det);

				}

				E_Venta venta = new E_Venta();
				//habilito los botones
				grSaldo.Enabled = true;
			
				btnAplicarRecargo.Text = "Aplicar &Recargo";

				N_Venta nVenta = new N_Venta();
				decimal totalVenta = calcularTotalVenta();
				Boolean xConf = nVenta.aplicarRecargoVenta(listDet,totalVenta,_VentaConsultada.codVenta);

				if (xConf)
				{
					consultarVenta();
				}
				else
				{
					MessageBox.Show("Error");
				}
			}
			//################-------------NO BORRAR -------------########################
			//Puede servir en el futuro para cuando se quiera aplicar correctamente el recargo
			//decimal precioTotal = Convert.ToDecimal(txtTotalVenta.Text);
			//decimal recargo = Convert.ToDecimal(txtRecargo.Text);

			//frmAplicarRecargo frmAplRecargo = new frmAplicarRecargo(precioTotal-recargo,_VentaConsultada.codVenta);
			//frmAplRecargo.ShowDialog();
			//consultarVenta();
		}
		private void btnImprimir_Click(object sender, EventArgs e)
		{
			generarRemito(_VentaConsultada.codVenta);
		}
		private void btnAgreNvoArticulo_Click(object sender, EventArgs e)
		{
			frmAgrNvoDetalle frm = new frmAgrNvoDetalle();
			frm.ShowDialog();
			if (_detNvoArticulo != null) // si se a confirmado la agregacion de un nuevo prodructo
			{
				dgDetalle.Rows.Add(new[] { "#", _detNvoArticulo.descripcion, "", _detNvoArticulo.cantidad.ToString(), _detNvoArticulo.precioArticulo.ToString(), _detNvoArticulo.precioTotal.ToString(), "X", _detNvoArticulo.stockActual.ToString() });
				calcularTotalVenta();
			}

		}
		private void btnPresupuesto_Click(object sender, EventArgs e)
		{
			if (dgDetalle.RowCount > 0)
			{
				frmFecPresupuesto form = new frmFecPresupuesto();
				form.ShowDialog();

				// si confirmo la fecha fin del presupuesto
				if(_fecFinPresupuesto!= null) generarPresupuesto();
			}
			
		}
		
		private void dgDetalle_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			if (e.ColumnIndex == colPrecio.Index)
			{
				dgDetalle.Rows[e.RowIndex].Cells[colPrecio.Index].Value = _cellPrecioAnt;
				e.Cancel = false;
			}

		}

		private void frmVenta_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == Convert.ToInt16(Keys.F12))
			{
				consultarVenta();
			}
		}

		private void btnCancelarRecargo_Click(object sender, EventArgs e)
		{
			consultarVenta();
		}

		private void btnAyuda_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, Application.StartupPath + "\\AyudaPintureria.chm", HelpNavigator.KeywordIndex, "Ventas");
		}


	}
}

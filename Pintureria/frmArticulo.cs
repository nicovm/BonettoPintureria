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
    public partial class frmArticulo : Form
    {
        //Variable de estado
        private Entidades.E_Articulo _oArticuloConsultado = null;
		private List<DataGridViewColumn> _colsDescRec;
		private List<string> _valDescRec;
        //Variables de clase
        public static Int64 _IdProveedor;
        public static string _raSocial;
		private string _frmAnterior;
		public static string _frmName;
        //Contructor
        /// <summary>
        /// Contructor con parametro que recibe un articulo si es para consultar se le pasa un articulo
        /// si es para crear una nuevo articulo se le pasa NULL
        /// </summary>
        /// <param name="articulo"></param>
        public frmArticulo(E_Articulo oArticulo)
        {
            InitializeComponent();
            //_articulo = articulo;
            //cargarCombos();
            //consultarArticulo(codArticulo);
			_oArticuloConsultado = oArticulo;
			_frmName = "frmArticulo";
			if (_oArticuloConsultado == null) //estan agregando un articulo
			{
				_colsDescRec = new List<DataGridViewColumn>();
				_valDescRec = new List<string>();
			}
		}
		/// <summary>
		/// Contructor para agregar un articulo desde otro formulario distinto al ABM
		/// </summary>
		/// <param name="codArticulo"></param>
		/// <param name="frmName"></param>
		public frmArticulo(string codArticulo, string frmName)
		{
			InitializeComponent();
			this._frmAnterior = frmName;
			_colsDescRec = new List<DataGridViewColumn>();
			_valDescRec = new List<string>();
		}
        //Load
        private void frmArticulo_Load(object sender, EventArgs e)
        {
            cargarCombos();
            if (_oArticuloConsultado != null) //siginifica que esta conultando
            {
				consultarArticulo(_oArticuloConsultado);
                //txtCodArticulo.Enabled = false; ####Cambio Pedido### Ante no se permitia cambiar el codArticula si estaba consultando
				cargarStock();
            }
			cboDescRec.SelectedIndex = 0;
			dgCosto.ClearSelection();
			txtCodArticulo.Select();
			txtCodArticulo.Focus();
        }
        private void frmArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
            }
        }
        //Metodos
		public List<E_DetalleCondicionCosto> cargarCondicionStock()
		{
			List<E_DetalleCondicionCosto> listDetCondCosto = new List<E_DetalleCondicionCosto>();
			Int16 orden = 0;
			foreach (DataGridViewColumn col in dgCosto.Columns)
			{
				if (col.Index != colPrecLista.Index && col.Index != colSinIva.Index && col.Index != colConIva.Index) // guardo los descuento y los recargo
				{
					orden++; 
					E_DetalleCondicionCosto detCondCosto = new E_DetalleCondicionCosto();
					detCondCosto.descrpcion = dgCosto.Columns[col.Index].HeaderText;
					detCondCosto.orden = orden;
					detCondCosto.porcentaje = ((ClsColItem)dgCosto.Columns[col.Index]).porcentaje;
					detCondCosto.condicion = ((ClsColItem)dgCosto.Columns[col.Index]).condicion;

					listDetCondCosto.Add(detCondCosto);
				}
			}
			return listDetCondCosto;
		}
        public void cargarCombos()
        {

            //cboRubro
            N_Rubro nRubro = new N_Rubro();
            List<E_Rubro> listRubro = nRubro.getAllRubros("");
            foreach (E_Rubro rubro in listRubro)
            {
                ComboItem cboItem = new ComboItem();

                cboItem.Id = rubro.idRubro;
                cboItem.Text = rubro.nombre;
                cboRubro.Items.Add(cboItem);
            }
            //cboMarca
            N_Marca nMarca = new N_Marca();
            List<E_Marca> listMarca = nMarca.getAllMarcas("");
            foreach (E_Marca marca in listMarca)
            {
                ComboItem cboItem = new ComboItem();
                cboItem.Id = marca.idMarca;
                cboItem.Text = marca.nombre;
                cboMarca.Items.Add(cboItem);
            }
            //cboUnidad
            N_Unidad nUnidad = new N_Unidad();
            List<E_Unidad> listUnidad = nUnidad.getAllUnidad("");
            foreach (E_Unidad unidad in listUnidad)
            {
                ComboItem cboItem = new ComboItem();
                cboItem.Id = unidad.idUnidad;
                cboItem.Text = unidad.nombre;
                cboUnidad.Items.Add(cboItem);
            }

        }
		//public decimal totalCosto()
		//{
		//    decimal costo = Convert.ToDecimal(txtPreLista.Text);


		//    //iva
		//    decimal TotalIva = 0;
		//    if (chxIncluirIva.Checked) TotalIva = costo * Convert.ToDecimal(txtIva.Text) / 100;

		//    return costo + TotalIva;
		//}
		//public decimal totalPrecioFinal()
		//{
		//    decimal tmp;
		//    decimal porcGanancia = 0;
		//    decimal porcIva = 0;
		//    if (decimal.TryParse(txtGanancia.Text, out tmp)) porcGanancia = Convert.ToDecimal(txtGanancia.Text);
		//    //if (decimal.TryParse(cboIva.Text, out tmp)) porcIva = Convert.ToDecimal(cboIva.Text);
		//     decimal totalGanancia = 0;
		//    decimal costo = totalCosto();
		//    decimal totalIva = costo * porcIva / 100;
			
		//    //si calcula el total de la ganancia
		//    if(chxIncluirGanancia.Checked)  totalGanancia = (costo) * porcGanancia / 100;


		//    return costo + totalIva + totalGanancia;
		//}
		private void cargarStock()
		{
            //N_Articulo nArticulo = new N_Articulo();
            //dgStock.AutoGenerateColumns = false;
            //dgStock.DataSource = nArticulo.getALLStockArticulo(_codArticulo);
		}
		private void cargarDgCosto()
		{
			
			//foreach (DataGridViewColumn col in _colsDescRec)
			//{
			//    dgCosto.Columns.Add(col);

			//}
			

		}
		private void ordenarColumnas() 
		{
			//para ordenar las columnas del dgCosto donde los descuento y recargo se encuetran entre medio
			// del precLista y el S/IVA, C/IVA 
			Int16 ultimoIndice = 0;
			foreach (DataGridViewColumn col in dgCosto.Columns)
			{
				if (col.Name != colPrecLista.Name && col.Name != colSinIva.Name && col.Name != colConIva.Name)
				{
					ultimoIndice++;
					dgCosto.Columns[col.Index].DisplayIndex = ultimoIndice;
				}
			}
		}
		private void calcularPrecColumna()
		{
			Int32 indiceAnterior = colPrecLista.Index; 
			foreach (DataGridViewColumn col in dgCosto.Columns)//recorro la grilla
			{
				
				if (col.Index != colPrecLista.Index)//calculo apartir del precio de lista
				{
					decimal total = Convert.ToDecimal(dgCosto.Rows[0].Cells[indiceAnterior].Value); // el valor de la celda anterior
					if (col.Index != colConIva.Index && col.Index != colSinIva.Index) // si las columnas son los decuento y recargo agregado
					{

						string condicion = ((ClsColItem)dgCosto.Columns[col.Index]).condicion;
						decimal porcentaje = ((ClsColItem)dgCosto.Columns[col.Index]).porcentaje;

						//tomo el precio de la columna anterior
					
						if (condicion == "DESCUENTO")
						{
							dgCosto.Rows[0].Cells[col.Index].Value = total - (total * porcentaje / 100);

						}
						else // SINO ES RECARGO
						{
							dgCosto.Rows[0].Cells[col.Index].Value = total + (total * porcentaje / 100);
						}
						indiceAnterior = col.Index; // ASIGNO EL INDICE ANTERIOR PORQUE ME MANEJO CON LOS INDICES DEL DISPLAYINDEX
					}//if (col.Index != colConIva.Index && col.Index != colSinIva.Index)	
				}//if (col.Index != colPrecLista.Index)
			}//for

		//Calculo la ganacia y el precio con iva 
			decimal totalAnterior;
			//ganancia o precio sin iva
			totalAnterior = Convert.ToDecimal(dgCosto.Rows[0].Cells[indiceAnterior].Value);
			decimal porceGanancia = Convert.ToDecimal(txtGanancia.Text);
			dgCosto.Rows[0].Cells[colSinIva.Index].Value = totalAnterior + (totalAnterior * porceGanancia / 100);

			//precio con IVA
			totalAnterior = Convert.ToDecimal(dgCosto.Rows[0].Cells[colSinIva.Index].Value);
			decimal porceIva = Convert.ToDecimal(txtIva.Text);
			dgCosto.Rows[0].Cells[colConIva.Index].Value = totalAnterior + (totalAnterior * porceIva / 100);

			//lo agrego al text del precio final
			decimal precFinal = Convert.ToDecimal(dgCosto.Rows[0].Cells[colConIva.Index].Value);
			txtPreFinal.Text = precFinal.ToString("N2");
		}
        /// <summary>
        /// si devuelve TRUE es todos los campos oblgatorios estan ingresado o son correctos
        /// de lo contrario devuelve FALSE
        /// </summary>
        /// <returns></returns>
        private Boolean txtObligatorios()
        {
            N_Articulo nArticulo = new N_Articulo();
            Boolean obligatorios = true;
            txtCodArticulo.Text.Trim();
            string codArticulo = txtCodArticulo.Text;

			if (_oArticuloConsultado == null)
			{
				if (codArticulo.Trim() == "" || nArticulo.ExisteCodArticulo(txtCodArticulo.Text))
				{
					obligatorios = false;

				}
			}
         
            string descripcion = txtDescr.Text;
            if (descripcion.Trim() == "") obligatorios = false;
            decimal tmp;
            if (!decimal.TryParse(txtPreLista.Text, out tmp)) obligatorios = false;

            
            return obligatorios;

        }
        private void consultarArticulo(E_Articulo oArticulo)
        {
            

            txtCodArticulo.Text = oArticulo.codArticulo;
            txtDescr.Text = oArticulo.descripcion;
            foreach (ComboItem cboItem in cboMarca.Items)
            {
                if (cboItem.Id == oArticulo.marca.idMarca) cboMarca.SelectedItem = cboItem;
            }
            foreach (ComboItem cboItem in cboRubro.Items)
            {
                if (cboItem.Id == oArticulo.rubro.idRubro) cboRubro.SelectedItem = cboItem;
            }
            foreach (ComboItem cboItem in cboUnidad.Items)
            {
                if (cboItem.Id == oArticulo.unidad.idUnidad) cboUnidad.SelectedItem = cboItem;
            }
            txtUbicacion.Text = oArticulo.ubicacion;
            txtStock.Text = oArticulo.stock.ToString();
            txtStockMin.Text = oArticulo.stockMin.ToString();
            txtFecCom.Value = Convert.ToDateTime(oArticulo.fecCompra);
            txtObservacion.Text = oArticulo.observacion;
            txtPreLista.Text = oArticulo.precioLista.ToString();
            txtPreFinal.Text = oArticulo.precioFinal.ToString();
            txtGanancia.Text = oArticulo.ganancia.ToString();
			txtIva.Text = oArticulo.iva.ToString();
            //txtCosto.Text = totalCosto().ToString();
			//activo el eliminar
			btnEliminar.Enabled = true;
			//Si se esta consultando un articulo los campos de stock son de solo lectura
			//txtStock.ReadOnly = true; #Modificado A Pedido# 
			//txtStockMin.ReadOnly = true;  #Modificado A pedido#

			// cargar la grilla costo
			dgCosto.Rows.Add(new[] { oArticulo.precioLista.ToString() });
			foreach (E_DetalleCondicionCosto detCosto in oArticulo.detCondCosto)
			{
				ClsColItem colItem = new ClsColItem();
				colItem.condicion = detCosto.condicion;
				colItem.porcentaje = detCosto.porcentaje;
				colItem.HeaderText = detCosto.descrpcion;
				colItem.CellTemplate = dgCosto.Columns[0].CellTemplate;
				colItem.AutoSizeMode = dgCosto.Columns[0].AutoSizeMode;
				colItem.DefaultCellStyle = dgCosto.Columns[0].DefaultCellStyle;

				dgCosto.Columns.Add(colItem);
				ordenarColumnas();
				calcularPrecColumna();
			}
			//Habilito el group de costo
			grCosto.Enabled = true;

			//Colocar el proveedor

			
			N_Proveedor nProve = new N_Proveedor();
			E_Proveedor oProveedor = nProve.getOne(oArticulo.proveedor.idProveedor);

			if (oProveedor != null) txtProveedor.Text = oProveedor.raSocial;
			

			 
			

        }
        private void borrarTxt()
        {
            txtCodArticulo.Text = "";
            txtDescr.Text = "";
            cboRubro.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            cboMarca.SelectedIndex = -1;
            _IdProveedor = 0;
            _raSocial = null;
            txtProveedor.Text = "";
            txtUbicacion.Text = "";
            txtStock.Text = "";
            txtStockMin.Text = "";
            txtPreLista.Text = "";
            txtPreFinal.Text = "";
			txtObservacion.Text = "";
        }
        //Eventos btn
		private void txtNumeros_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{
			//if (e.KeyChar == '.')
			//{
			//    e.Handled = true;
			//    SendKeys.Send(",");
			//}



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


			if (!(char.IsNumber(e.KeyChar) | e.KeyChar.Equals(coma) | char.IsControl(e.KeyChar)))
				e.Handled = true;
		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (txtObligatorios())
			{
				E_Articulo articulo = new E_Articulo();
				articulo.codArticulo = txtCodArticulo.Text;
				articulo.descripcion = txtDescr.Text;
				if (cboRubro.SelectedIndex != -1) articulo.rubro.idRubro = ((ComboItem)cboRubro.SelectedItem).Id;
				if (cboUnidad.SelectedIndex != -1) articulo.unidad.idUnidad = ((ComboItem)cboUnidad.SelectedItem).Id;
				if (cboMarca.SelectedIndex != -1) articulo.marca.idMarca = ((ComboItem)cboMarca.SelectedItem).Id;

				articulo.proveedor.idProveedor = _IdProveedor;
				articulo.ubicacion = txtUbicacion.Text;
				Int32 tmp;
				if (Int32.TryParse(txtStock.Text, out tmp)) articulo.stock = Convert.ToInt32(txtStock.Text);
				if (Int32.TryParse(txtStockMin.Text, out tmp)) articulo.stockMin = Convert.ToInt32(txtStockMin.Text);
				DateTime dt;
				if (DateTime.TryParse(txtFecCom.Text, out dt))
				{
					articulo.fecCompra = Convert.ToDateTime(txtFecCom.Text);
				}
				else
				{
					articulo.fecCompra = null;
				}
				articulo.observacion = txtObservacion.Text;
				//TAB CALCULAR COSTO
				articulo.precioLista = Convert.ToDecimal(txtPreLista.Text);
				articulo.ganancia = Convert.ToDecimal(txtGanancia.Text);
				articulo.iva = Convert.ToDecimal(txtIva.Text);
				articulo.precioFinal = Convert.ToDecimal(dgCosto.Rows[0].Cells[colConIva.Index].Value); 

				articulo.detCondCosto = cargarCondicionStock();
				N_Articulo nArticulo = new N_Articulo();

				string xRet;
				if (_oArticuloConsultado == null) //Agregando un nuevo Articulo
				{
					xRet = nArticulo.add(articulo);
					
				}
				else // COnsultando un nuevo articulo
				{
					xRet = nArticulo.set(articulo, _oArticuloConsultado.codArticulo);
				}
				
				//string xRet = nArticulo.guardar(articulo);

				if (xRet != "0")
				{
					MessageBox.Show("Error");
				}
				else
				{
					MessageBox.Show("¡Articulo Guardado con exito!", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
					if (_frmAnterior == frmAgrDetalle._frmName) // estoy agregando desde el formulario AgrDetalle
					{
						this.Close();
					}
					if (_oArticuloConsultado == null)
					{
						borrarTxt();
						tabArticulo.SelectedIndex = 0; //foco en el tabPagGeneral

					}
					else
					{
						this.Close();
					}

				}

			}
			else
			{
                MessageBox.Show("¡Los campos obligatorios deben estar completos (*)!", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btnEliminar_Click(object sender, EventArgs e)
		{
			DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation);

			switch (respuesta)
			{
				case DialogResult.Yes:

					N_Articulo nArticulo = new N_Articulo();
					if (_oArticuloConsultado.codArticulo != null)
					{
						string xRet = nArticulo.deleteArticulo(_oArticuloConsultado.codArticulo);

						if (xRet != null)
						{
							MessageBox.Show("No se puede eliminar el producto porque ya ha sido utilizado ", "DuoHead", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
						}

					}
					this.Close();
					break;

				case DialogResult.No:
					this.Close();
					break;
			}





		}
		//TAB GENERAL
		//private void txtObservacion_LostFocus(object sender, System.EventArgs e)
		//{
		//    tabArticulo.SelectedIndex = 1;
		//}
		private void txtCodArticulo_Leave(object sender, EventArgs e)
		{
		
				N_Articulo nArticulo = new N_Articulo();

				//if (!String.IsNullOrEmpty(txtCodArticulo.Text))
				//{
				//     if (nArticulo.ExisteCodArticulo(txtCodArticulo.Text) && _oArticuloConsultado == null)
				//    {
				//        picErrorCodArt.Visible = true;
				//    }
				//    //picErrorCodArt.Visible = true;
				//}
				//else
				//{
				//    picErrorCodArt.Visible = false;
				//}

				if (String.IsNullOrEmpty(txtCodArticulo.Text))
				{
					picErrorCodArt.Visible = true;
				}
				else
				{
					picErrorCodArt.Visible = false;
				}
				if (nArticulo.ExisteCodArticulo(txtCodArticulo.Text))
				{
					if ((txtCodArticulo.Text != _oArticuloConsultado.codArticulo) && _oArticuloConsultado != null)
					{
						picErrorCodArt.Visible = true;
					}

				}
				

		}
		private void txtCodArticulo_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space) e.SuppressKeyPress = true;

		}
		
		//TAB COSTO
        private void txtGanancia_GotFocus(object sender, System.EventArgs e)
        {
            if (txtGanancia.Text != "")
            {
                txtGanancia.Select(txtGanancia.Text.Length, 0);
            }
            else
            {
                txtGanancia.Select(0, 0);
            }
        }
        private void txtPresLista_LostFocus(object sender, System.EventArgs e)
        {
            decimal tmp;
			if (decimal.TryParse(txtPreLista.Text, out tmp))//valida que alla ingresado correctamente el precio de lista
			{
				txtPreLista.Text = tmp.ToString("N2");// COLOCAR DOS NUMEROS DESPUES DE LA COMA
				if (dgCosto.Rows.Count == 0)
				{
					dgCosto.Rows.Add(new[] { txtPreLista.Text }); //agrego el precio de lista a la grilla de costo por primera vez
					grCosto.Enabled = true;
				}
				else
				{
					dgCosto.Rows[0].Cells[colPrecLista.Index].Value = tmp;
				}
				calcularPrecColumna();
				if (picErrorPreLista.Visible == true) picErrorPreLista.Visible = false;
			}
			else
			{
				picErrorPreLista.Visible = true;
			}


        }
        private void txtPreLista_GotFocus(object sender, System.EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPreLista.Text))
            {
                txtPreLista.SelectAll();
            }
        }
        private void txtPreFinal_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPreFinal.Text))
            {
                txtPreFinal.SelectAll();
            }
        }
		private void txtPreFinal_Leave(object sender, EventArgs e)
		{
		
			btnGuardar.Focus();
		}
		private void btnAgrDescRec_Click(object sender, EventArgs e)//Bton agregar descuento o recargo
		{
			decimal porcentaje;
			if (decimal.TryParse(txtPorDesRec.Text, out porcentaje) && cboDescRec.SelectedIndex >-1)
			{

				ClsColItem colItem = new ClsColItem();
				colItem.condicion = cboDescRec.Text;
				colItem.porcentaje = porcentaje;
				colItem.HeaderText = txtDescDescRec.Text +"%"+txtPorDesRec.Text;
				colItem.CellTemplate = dgCosto.Columns[0].CellTemplate;
				colItem.AutoSizeMode = dgCosto.Columns[0].AutoSizeMode;
				colItem.DefaultCellStyle = dgCosto.Columns[0].DefaultCellStyle;

				dgCosto.Columns.Add(colItem);
				ordenarColumnas();
				calcularPrecColumna();
			}
			else // si el porcentaje esta mal ingresado
			{
				// no se agrega nada

			}
			

		}
		private void btnEliminarCol_Click(object sender, EventArgs e)
		{
			if (dgCosto.ColumnCount > 3) // si es mayor a 3 significa que agregado alguna columna 
			{
				Int32 indice = dgCosto.ColumnCount - 1; // borro el ultimo indice
				DataGridViewColumn col = dgCosto.Columns[indice];
				dgCosto.Columns.Remove(col);
				calcularPrecColumna();
			}
		}
		private void txtGanancia_Leave(object sender, EventArgs e)
		{
			decimal ganacia;
			if (!decimal.TryParse(txtGanancia.Text, out ganacia))
			{
				ganacia = 0;
				txtGanancia.Text = ganacia.ToString("N2");
			}
			if (grCosto.Enabled == true)
			{
				calcularPrecColumna();
			}
		}
		private void txtIva_Leave(object sender, EventArgs e)
		{
			decimal iva;
			if (!decimal.TryParse(txtIva.Text, out iva)) 
			{
				iva = 0;
				txtIva.Text = iva.ToString("N2");
			}
			if (grCosto.Enabled == true)
			{
				calcularPrecColumna();
			}
		}
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBsqProveedor form = new frmBsqProveedor(_frmName);
            form.ShowDialog();
            if (_IdProveedor != 0)
            {
                txtProveedor.Text = _raSocial;
            }
        }
		private void txtDescr_Leave(object sender, EventArgs e)
		{
			string descripcion = txtDescr.Text;
			if (descripcion.Trim() == "") { picErrorDescr.Visible = true; }
			else { picErrorDescr.Visible = false; }
		}

		private void btnAyuda_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, Application.StartupPath + "\\AyudaPintureria.chm", HelpNavigator.KeywordIndex, "NuevoArticulos");
		}

	

		
		
	}//fin de clase
}//nameSpace


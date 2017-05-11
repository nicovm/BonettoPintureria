using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using Entidades;
using Negocio;
using System.Threading;

namespace Pintureria
{
	public partial class frmImportarLista : Form
	{
		private OpenFileDialog oFileDialog;
		/// <summary>
		/// Proveedor seleccionado para  importar la lista
		/// </summary>
		private Int64 idMarcaSelect;
		Thread _LoadingImportacion;
		bool _FinImportacion;

		//LetraClave dependiente de la marca que se ah seleccionado que va ir pegado al codigo
		string charMarca;

		frmConfImportacion oFrmConf;
		/// <summary>
		/// Formulario para importar los precios de una marca de pintura
		/// </summary>
		/// <param name="Marca">Lista de precio de la marca seleccionada</param>
		public frmImportarLista( Int64 idMarcaSelect )
		{
			this.idMarcaSelect = idMarcaSelect;
			InitializeComponent();
	
		

			oFileDialog = new OpenFileDialog();

			if (idMarcaSelect == E_Marca.TERSUAVE)
			{
				lblMarca.Text = "TERSUAVE";
				charMarca = "T";
			}
			else
			{
				lblMarca.Text = "QUIMEX";
				charMarca = "Q";
			}

		}

		
	
		//Eventos
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			if (!camposObligatorios()) return;

			oFileDialog.Filter = "Archivos de Excel (*.xls;*.xlsx)|*.xls;*.xlsx";
			oFileDialog.FilterIndex = 1;
			//Si selecciono un archivo de excel
			if (oFileDialog.ShowDialog() == DialogResult.OK)
			{
				LeerExcel(oFileDialog.FileName);

			}
		}
		private void btnAgrDescRec_Click(object sender, EventArgs e)
		{
			decimal porcentaje;
			if (decimal.TryParse(txtPorDesRec.Text, out porcentaje) && cboDescRec.SelectedIndex > -1)
			{

				ClsColItem colItem = new ClsColItem();
				colItem.condicion = cboDescRec.Text;
				colItem.porcentaje = porcentaje;
				colItem.HeaderText = txtDescDescRec.Text + "%" + txtPorDesRec.Text;
				colItem.CellTemplate = dgImportar.Columns[0].CellTemplate;
				colItem.AutoSizeMode = dgImportar.Columns[0].AutoSizeMode;
				colItem.DefaultCellStyle = dgImportar.Columns[0].DefaultCellStyle.Clone();
				colItem.DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);

				dgImportar.Columns.Add(colItem);
				ordenarColumnas();
				calcularPrecColumna();
			}
			else // si el porcentaje esta mal ingresado
			{
				//Normales

			}

		}
		private void btnEliminarCol_Click_1(object sender, EventArgs e)
		{
			if (dgImportar.ColumnCount > 5) // si es mayor a 6 significa que agregado alguna columna  de recargo o descuento
			{
				Int32 indice = dgImportar.ColumnCount - 1; // borro el ultimo indice
				DataGridViewColumn col = dgImportar.Columns[indice];
				dgImportar.Columns.Remove(col);
				//calcularPrecColumna();
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

			calcularPrecColumna();

		}
		private void txtIva_Leave(object sender, EventArgs e)
		{
			decimal iva;
			if (!decimal.TryParse(txtIva.Text, out iva))
			{
				iva = 0;
				txtIva.Text = iva.ToString("N2");
			}

			calcularPrecColumna();

		}
		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		//Metdoos
		private bool camposObligatorios()
		{
			bool xRet = true;
			if (String.IsNullOrEmpty(txtNombreCol.Text))
			{
				ep.SetError(txtNombreCol, "Ingresar el numero de columna");
				xRet = false;

			}
			else ep.SetError(txtNombreCol, null);

			if (String.IsNullOrEmpty(txtCodigoCol.Text))
			{
				ep.SetError(txtCodigoCol, "Ingresar el numero de columna");
				xRet = false;

			}
			else ep.SetError(txtCodigoCol, null);

			if (String.IsNullOrEmpty(txtPrecioListaCol.Text))
			{
				ep.SetError(txtPrecioListaCol, "Ingresar el numero de columna");
				xRet = false;

			}
			else ep.SetError(txtPrecioListaCol, null);

			

				return xRet;
		}
		private void ordenarColumnas()
		{
			//para ordenar las columnas del dgCosto donde los descuento y recargo se encuetran entre medio
			// del precLista y el S/IVA, C/IVA 
			int ultimoIndice = colPrecioLista.Index;

			foreach (DataGridViewColumn col in dgImportar.Columns)
			{
				if (col.Name != colPrecioLista.Name && col.Name != colSiniva.Name && col.Name != colConIva.Name && col.Name != colCodArticulo.Name
					&& col.Name != colDetalle.Name)
				{
					ultimoIndice++;
					dgImportar.Columns[col.Index].DisplayIndex = ultimoIndice;
				}
			}
		}
		private void calcularPrecColumna()
		{
			//Esta lista la utilizo cuando una fila agrega en el grillla me genera una error , la elimino luego que la recorri
			List<DataGridViewRow> listRowError = new List<DataGridViewRow>();

			foreach (DataGridViewRow row in dgImportar.Rows) //Recorro todas las filas de la grilla
			{
				try
				{


					Int32 indiceAnterior = colPrecioLista.Index; //Empieso a calcular a partir de indice de precio de lista
					foreach (DataGridViewColumn col in dgImportar.Columns)//recorro las columnas de la grilla
					{

						if (col.Index != colPrecioLista.Index)//calculo apartir del precio de lista
						{


							decimal total = Convert.ToDecimal(dgImportar.Rows[row.Index].Cells[indiceAnterior].Value); // el valor de la celda anterior
							if (col.Index != colConIva.Index && col.Index != colSiniva.Index && col.Index != colPrecioLista.Index
								&& col.Index != colCodArticulo.Index && col.Index != colDetalle.Index) // si las columnas son los decuento y recargo agregado
							{

								string condicion = ((ClsColItem)dgImportar.Columns[col.Index]).condicion;
								decimal porcentaje = ((ClsColItem)dgImportar.Columns[col.Index]).porcentaje;

								//tomo el precio de la columna anterior

								if (condicion == "DESCUENTO")
								{
									dgImportar.Rows[row.Index].Cells[col.Index].Value = (total - (total * porcentaje / 100)).ToString("N2"); ;

								}
								else // SINO ES RECARGO
								{
									dgImportar.Rows[row.Index].Cells[col.Index].Value = (total + (total * porcentaje / 100)).ToString("N2"); ;
								}
								indiceAnterior = col.Index; // ASIGNO EL INDICE ANTERIOR PORQUE ME MANEJO CON LOS INDICES DEL DISPLAYINDEX

							}//if (col.Index != colConIva.Index && col.Index != colSinIva.Index)	



						}//if (col.Index != colPrecLista.Index)

					}//for



					//Calculo la ganacia y el precio con iva 
					decimal totalAnterior;
					//ganancia o precio sin iva
					totalAnterior = Convert.ToDecimal(dgImportar.Rows[row.Index].Cells[indiceAnterior].Value);
					decimal porceGanancia = Convert.ToDecimal(txtGanancia.Text);
					dgImportar.Rows[row.Index].Cells[colSiniva.Index].Value = (totalAnterior + (totalAnterior * porceGanancia / 100)).ToString("N2"); ;

					//precio con IVA
					totalAnterior = Convert.ToDecimal(dgImportar.Rows[row.Index].Cells[colSiniva.Index].Value);
					decimal porceIva = Convert.ToDecimal(txtIva.Text);
					dgImportar.Rows[row.Index].Cells[colConIva.Index].Value = (totalAnterior + (totalAnterior * porceIva / 100)).ToString("N2"); ;
				}
				catch (Exception)
				{
					listRowError.Add(row);

				}

			}// for que recorre cada fila

			//Pregunto si alguna fila genero un error
			if (listRowError.Count > 0)
			{
				foreach (DataGridViewRow rowError in listRowError) //Recorro las filas que generaron errores
				{
					ssLblInformacion.Text = "La fila con codigo: " + rowError.Cells[colCodArticulo.Index].Value.ToString() + " se ha eliminado ";
					dgImportar.Rows.Remove(rowError); // Elimino la fila que genero el error;
				}
			}


			txtRegistros.Text = dgImportar.RowCount.ToString();
		}//calcularPrecColumna
		private void LeerExcel(string fileName)
		{
			OleDbConnection objConn = null;
			System.Data.DataTable dt = null;
			DataSet dataSet = null;
			OleDbDataAdapter dataAdapter = null;

			string excelFile = oFileDialog.FileName;
			try
			{
				// Connection String. Change the excel file to the file you
				// will search.
				String connString = "Provider=Microsoft.Jet.OLEDB.4.0;" +
					"Data Source=" + excelFile + ";Extended Properties=Excel 8.0;";
				// Create connection object by using the preceding connection string.
				objConn = new OleDbConnection(connString);
				// Open connection with the database.
				objConn.Open();
				// Get the data table containg the schema guid.
				dt = objConn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);

				if (dt != null)
				{

					int _colNombre = Convert.ToInt16(txtNombreCol.Text) -1;
					int _colCod = Convert.ToInt16(txtCodigoCol.Text) -1;
					int _colPrecio = Convert.ToInt16(txtPrecioListaCol.Text) -1;
					int _colEnvase = 0;
					if (txtEnvase.Text != "") _colEnvase = Convert.ToInt16(txtEnvase.Text) -1;

					List<string> hojas = new List<string>();
					// Add the sheet name to the string array.
					foreach (DataRow row in dt.Rows) //Recorro las hojas 
					{
						hojas.Add(row["TABLE_NAME"].ToString());
						//string consultaHojaExcel = "Select * from [" + hoja + "]";
					}

					frmHojaExcel frm = new frmHojaExcel(hojas);
					if (frm.ShowDialog() == DialogResult.OK)
					{

					
					try
							{
								string consultaHojaExcel = "Select * from [" + frm.HOJA_SELECCIOANDA +"]";
								dataAdapter = new OleDbDataAdapter(consultaHojaExcel, objConn); //traemos los datos de la hoja y las guardamos en un dataSdapter
								dataSet = new DataSet(); // creamos la instancia del objeto DataSet
								dataAdapter.Fill(dataSet, frm.HOJA_SELECCIOANDA);//llenamos el dataset

								DataTable dtH = dataSet.Tables[0];
								dgImportar.Rows.Clear();
								foreach (DataRow rowH in dtH.Rows)
								{
									decimal precio;

									if (decimal.TryParse(Convert.ToString(rowH[_colPrecio]), out precio) && Convert.ToString(rowH[_colCod]) != "")
									{
								
										if (txtEnvase.Text == "")
										{
											// T + codProducto				//Nombre					//Precio de lista
											dgImportar.Rows.Add(charMarca + Convert.ToString(rowH[_colCod]), Convert.ToString(rowH[_colNombre]), Convert.ToString(rowH[_colPrecio]));
										}
										else
										{
											// T + codProducto				//Nombre					//Precio de lista
											dgImportar.Rows.Add(charMarca + Convert.ToString(rowH[_colCod]), Convert.ToString(rowH[_colNombre]) +" Envase " +  Convert.ToString(rowH[_colEnvase]), Convert.ToString(rowH[_colPrecio]));
										}

									}
								}
							}
							catch (Exception ex)
							{
								MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


							}

					

						txtRegistros.Text = dgImportar.RowCount.ToString();
                   
                    
                    
						picVisto.Visible = true;
						lblMensaje.Visible = true;


						//Calculo del los precio  de las columnas de como quedaria con y sin iva y precio final

						calcularPrecColumna();


					} //if (frm.ShowDialog() == DialogResult.OK)
				else
				{
					MessageBox.Show("No se pudo obtener el nombre de la hoja", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}

				connString = null;

				} 
			}
			catch (Exception ex)
			{
				ssLblInformacion.Text = ex.Message;

			}
		}
		public List<E_DetalleCondicionCosto> cargarCondicionStock()
		{
			List<E_DetalleCondicionCosto> listDetCondCosto = new List<E_DetalleCondicionCosto>();
			Int16 orden = 0;
			foreach (DataGridViewColumn col in dgImportar.Columns)
			{
				if (col.Index != colPrecioLista.Index && col.Index != colSiniva.Index && col.Index != colConIva.Index && colCodArticulo.Index != col.Index
					&& colDetalle.Index != col.Index) // guardo los descuento y los recargo
				{
					orden++;
					E_DetalleCondicionCosto detCondCosto = new E_DetalleCondicionCosto();
					detCondCosto.descrpcion = dgImportar.Columns[col.Index].HeaderText;
					detCondCosto.orden = orden;
					detCondCosto.porcentaje = ((ClsColItem)dgImportar.Columns[col.Index]).porcentaje;
					detCondCosto.condicion = ((ClsColItem)dgImportar.Columns[col.Index]).condicion;

					listDetCondCosto.Add(detCondCosto);
				}
			}
			return listDetCondCosto;
		}

		private void btnConfirmarImportacion_Click(object sender, EventArgs e)
		{
			
			SetLoandig(true, picImportar, lblImportarDatos); //Pongo visible el progreso de importacion
			backgroundWorker.RunWorkerAsync();

			btnConfirmarImportacion.Enabled = false; ;
			btnImportarLista.Enabled = false; ;
		}
		
		//Hilo 

		private void hLoandig()
		{
			while (true)
			{
				if (_FinImportacion)
				{
					SetLoandig(false,picImportar,lblImportarDatos);
					_LoadingImportacion.Abort();
				}
				else
				{
					SetLoandig(true, picImportar, lblImportarDatos);
				}
			}
		}
		//Delegado
		delegate void DelSetLoandig(bool value , PictureBox _picLoandig , Label _lblImportacionDatos);

		private void SetLoandig(bool value, PictureBox _picLoandig, Label _lblImportacionDatos)
		{

			if (_picLoandig.InvokeRequired )
			{
				DelSetLoandig Delegado = new DelSetLoandig(SetLoandig);
				this.Invoke(Delegado, new object[] { value,_picLoandig,_lblImportacionDatos });
			}
			else
			{
				_picLoandig.Visible = value;
				_lblImportacionDatos.Visible = value;
			
				
			}
		}

       

		private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e) // Implementacion del hilo de importacion
		{
			

			//Lista de articulo a cargar o actualizar
			List<E_Articulo> oListArticulos = new List<E_Articulo>();

			//Recorro la lista de articulo
			foreach (DataGridViewRow row in dgImportar.Rows)
			{
				E_Articulo oArticulo = new E_Articulo();
				oArticulo.codArticulo = row.Cells[colCodArticulo.Index].Value.ToString();
				oArticulo.descripcion = row.Cells[colDetalle.Index].Value.ToString();
				oArticulo.ganancia = Convert.ToDecimal(txtGanancia.Text);
				oArticulo.iva = Convert.ToDecimal(txtIva.Text);
				oArticulo.precioLista = Convert.ToDecimal(row.Cells[colPrecioLista.Index].Value);
				oArticulo.stock = 0;
				oArticulo.stockMin = 0;
				oArticulo.marca.idMarca = idMarcaSelect; 
				oArticulo.observacion = "";
				oArticulo.ubicacion = "Pintureria";
				oArticulo.precioFinal = Convert.ToDecimal(row.Cells[colConIva.Index].Value); // el precio final es el precion con iva
				oArticulo.detCondCosto = cargarCondicionStock();



				oListArticulos.Add(oArticulo);

			}
			N_Articulo nArticulo = new N_Articulo();
			//Lista de articulos que no se pudieron agregar
			List<E_Articulo> oListArticulosError = nArticulo.addImportArticulo(oListArticulos);
			_FinImportacion = true;

			if (oListArticulosError == null) { MessageBox.Show("¡La importación de los artículos se realizo con exito!", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information); }
			else
			{
				MessageBox.Show(oListArticulosError.Count + " articulos no se pudieron importar ", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}


			SetLoandig(false, picImportar, lblImportarDatos); //Pongo visible el progreso de importacion
		}

		private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			btnConfirmarImportacion.Enabled = true; ;
			btnImportarLista.Enabled = true;
		}

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtCodigoCol.Text = "";
            txtNombreCol.Text = "";
            txtPrecioListaCol.Text = "";
        }

        

	

	

		
		
	}
}

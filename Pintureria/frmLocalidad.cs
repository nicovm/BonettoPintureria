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
using System.Configuration;

namespace Pintureria
{
    public partial class frmLocalidad : Form
    {
		//Variable de estado
		private string _frmAnterior = null;
		public static string _frmName= "frmLocalidad";
		//Contructor
        public frmLocalidad()
        {
            InitializeComponent();
			//posiscionar Cbo Localidad segun la localidad por defecto sacado del appConfig
			Int16 idProvincia = Convert.ToInt16(ConfigurationManager.AppSettings["Provincia"]);
			cargarCboProvincia(idProvincia);
			refrescarGrilla();
        }
		public frmLocalidad(string frmName,Int16 idProvincia)
		{
			InitializeComponent();
			_frmAnterior = frmName;
			cargarCboProvincia(idProvincia);
			refrescarGrilla();

		}
		//Eventos de formularios
		private void frmLocalidad_Load(object sender, EventArgs e)
		{
			if (_frmAnterior != null)//  se esta agregando desde otro formulario
			{
				agregarLocalidad();
			}

		
		}
		//Metodos
		/// <summary>
		/// Metodos que uso para agregar localidad desde otro formulario
		/// la seleccion de la provincia es traida del el formulario que lo llamo
		/// </summary>
		public void agregarLocalidad()
		{
			txtAgrModLocalidad.Text = null; //
			lblNvoMod.Text = "Nueva Localidad:";
			txtAgrModLocalidad.Focus();
			txtId.Text = null;
			btnModificar.Enabled = false;
			btnNuevo.Enabled = false;
			cboProvincia.Enabled = false;

		}
		public void cargarCboProvincia(Int16 idProvincia)
		{
			cboProvincia.Items.Clear();
			N_Provincia nProvincia = new N_Provincia();

			List<E_Provincia> provincias = nProvincia.getAllProvincias();

			foreach (E_Provincia provincia in provincias)
			{
				ComboItem cboItem = new ComboItem();
				cboItem.Id = provincia.IdProvincia;
				cboItem.Text = provincia.nombre;
				cboProvincia.Items.Add(cboItem);
			}
			  foreach (ComboItem cboItem in cboProvincia.Items)
            {
                if (cboItem.Id == idProvincia) cboProvincia.SelectedItem = cboItem;
            }
			

		}
		private void refrescarGrilla()
		{
			N_Localidad nLocalidad = new N_Localidad();
			Int16 idProvincia = Convert.ToInt16(((ComboItem)cboProvincia.SelectedItem).Id);
			List<E_Localidad> localidades = nLocalidad.getAllLocalidades(idProvincia);
			dgLocalidad.AutoGenerateColumns = false;
			dgLocalidad.DataSource = localidades;

		}
		//Eventos
		private void btnNuevo_Click(object sender, EventArgs e) 
		{
			txtAgrModLocalidad.Text = null; //
			lblNvoMod.Text = "Nueva Localidad:";
			txtAgrModLocalidad.Focus();
			txtId.Text = null;
		}
		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (dgLocalidad.Rows.Count != 0)
			{
				lblNvoMod.Text = "Modificar localidad:";
				txtId.Text = dgLocalidad.CurrentRow.Cells[colId.Index].Value.ToString();
				txtAgrModLocalidad.Text = dgLocalidad.CurrentRow.Cells[colNombre.Index].Value.ToString();
				txtAgrModLocalidad.SelectAll();
			}
			else
			{
                MessageBox.Show("¡Debe seleccionar una localidad!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				
			}
		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			if (txtAgrModLocalidad.Text != "")
			{
				E_Localidad localidad =  new E_Localidad();
				localidad.codPostal = 0;
				localidad.nombre = txtAgrModLocalidad.Text;
				localidad.provincia.IdProvincia = Convert.ToInt16(((ComboItem)cboProvincia.SelectedItem).Id);
			

				N_Localidad nLocalidad = new N_Localidad();
				// = nLocalidad.guardar();
				Int16 idLocalidad = nLocalidad.guardar(localidad);
				if (idLocalidad != 0)//si se agrego o modifico correctamente
				{
					if (_frmAnterior == null)// agrega desde el mismo formulario
					{
						refrescarGrilla();
						txtAgrModLocalidad.Text = null;
					}
					else if (_frmAnterior == frmCliente._frmName)
					{
						frmCliente._idArgLocalidad = idLocalidad;
						this.Close();
					}
					else if (_frmAnterior == frmProveedor._frmName)
					{
						frmProveedor._idArgLocalidad = idLocalidad;
						this.Close();
					}
					else if (_frmAnterior == frmVendedor._frmName)
					{
						frmVendedor._idAgrLocalidad = idLocalidad;
						this.Close();
					}
				
				}
				else // Surgio un error en la carga
				{
					MessageBox.Show("No se pudo cargar la localidad", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			else
			{
                MessageBox.Show("¡Los campos obligatorios deben estar completos (*)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
		{
			refrescarGrilla();
		}

		private void dgLocalidad_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			try
			{
				if (e.ColumnIndex == colEliminar.Index)
				{
					N_Localidad nLocalidad = new N_Localidad();
					Int16 idLocalidad = Convert.ToInt16(dgLocalidad.CurrentRow.Cells[colId.Index].Value);
					string xRet =  nLocalidad.delete(idLocalidad);

					if (xRet == "0")
					{
						refrescarGrilla();

					}
					else // surgio un error
					{
						MessageBox.Show("No se pudo eliminar la localidad porque esta en uso", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}

			}
			catch (Exception)
			{
				
				
			}
		}

		private void btnAyuda_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, Application.StartupPath + "\\AyudaPintureria.chm", HelpNavigator.KeywordIndex, "Localidades");
		}
		

		
    }
}

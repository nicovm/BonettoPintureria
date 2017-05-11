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
    public partial class frmProveedor : Form
    {
		public static string _frmName = "frmProveedor";
		public static Int16 _idArgLocalidad;
		private string _frmAnterior;
        Int64 _idProveedor;
      
		//CONTRUCTORes
		public frmProveedor(string frmName)
		{
			InitializeComponent();
			this._frmAnterior = frmName;
			cargarCboProvincia();
			_idArgLocalidad = 0;
		}
        public frmProveedor(Int64 idProveedor)
        {
            InitializeComponent();
			_idArgLocalidad = 0;
            ConsultarProv(idProveedor);
            cargarCboProvincia();
			_idProveedor = idProveedor;

        }
		//Eventos de formulario
		private void frmProveedor_Load(object sender, EventArgs e)
		{
			if (_idProveedor != 0) // consulta un cliente
			{
				ConsultarProv(_idProveedor);
				btnEliminar.Enabled = true;
			}
			else
			{
				mtxtFechaReg.Text = DateTime.Now.Date.ToString("dd/MM/yyyy");
			}

		}
		
		//Metodos
		private Boolean txtObligatorios()
		{
			if (string.IsNullOrEmpty(txtNombre.Text))
			{
				return false; // si esta vacio devuelvo false
			}
			return true; // si no true;
		}
		public void ConsultarProv(Int64 idProveedor)
		{
			E_Proveedor Prov;
			N_Proveedor nProv = new N_Proveedor();
			Prov = nProv.getOne(idProveedor);

			txtId.Text = Convert.ToString(Prov.idProveedor);
			txtNombre.Text = Prov.raSocial;
			txtObserv.Text = Prov.detalle;
			txtMail.Text = Prov.mail;

			txtCuit.Text = Convert.ToString(Prov.cuit);
			mtxtFechaReg.Text = Prov.fecReg.ToString();
			txtTelefono.Text = Prov.telefono;

			posicionarCboProvincia(Prov.localidad.provincia.IdProvincia);
			cargarCboLocalidad(Prov.localidad.provincia.IdProvincia);
			posicionarCboLocalidad(Prov.localidad.idLocalidad);
			// habilitar el btnEliminar
			btnEliminar.Enabled = true;
		}
		private void posicionarCboProvincia(Int16 idProvincia)
		{

			foreach (ComboItem cboItem in cboProvincia.Items)
			{
				if (cboItem.Id == idProvincia) cboProvincia.SelectedItem = cboItem;
			}
		}
		private void posicionarCboLocalidad(Int64 idLocalidad)
		{
			foreach (ComboItem cboItem in cboLocalidad.Items)
			{
				if (cboItem.Id == idLocalidad) cboLocalidad.SelectedItem = cboItem;
			}
		}
		public void cargarCboProvincia()
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
			//posicionar combo con el valor por defecto sacado del appConfig
			posicionarCboProvincia(Convert.ToInt16(ConfigurationManager.AppSettings["Provincia"]));

			Int16 idProvincia = Convert.ToInt16(((ComboItem)cboProvincia.SelectedItem).Id);
			cargarCboLocalidad(idProvincia);

		}
		private void cargarCboLocalidad(Int16 idProvincia)
		{
			cboLocalidad.Items.Clear();
			N_Localidad nLocalidad = new N_Localidad();
			//structura del item del combo

			List<E_Localidad> localidades = nLocalidad.getAllLocalidades(idProvincia);
			foreach (E_Localidad localidad in localidades)
			{
				ComboItem cboItem = new ComboItem();
				cboItem.Id = localidad.idLocalidad;
				cboItem.Text = localidad.nombre;

				cboLocalidad.Items.Add(cboItem);
			}
			Int16 idProvinciaAppConfig = Convert.ToInt16(ConfigurationManager.AppSettings["Provincia"]);
			if (idProvincia == idProvinciaAppConfig) // si la provincia seleccionada es la que esta por defecto posiciona la localidad por defecto
			{
				//posiscionar Cbo Localidad segun la localidad por defecto sacado del appConfig
				Int64 value = Convert.ToInt64(ConfigurationManager.AppSettings["Localidad"]);
				posicionarCboLocalidad(value);
			}
			else // sino coloca la primera localidad 
			{
				cboLocalidad.SelectedIndex = 0;
			}

		}
		//Eventos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnGuardarProv_Click(object sender, EventArgs e)
        {
			if (txtObligatorios()) // si devuelve true los txt obligatorios estan completos
			{
				E_Proveedor Proveedor = new E_Proveedor();

				if (txtId.Text != "") Proveedor.idProveedor = Convert.ToInt64(txtId.Text);

				Proveedor.raSocial = txtNombre.Text;
				Proveedor.telefono = txtTelefono.Text;

				Proveedor.localidad.idLocalidad = ((ComboItem)cboLocalidad.SelectedItem).Id;
				Proveedor.detalle = txtObserv.Text;
				Proveedor.cuit = txtCuit.Text;
				Proveedor.mail = txtMail.Text;


				DateTime dt;
				if (DateTime.TryParse(mtxtFechaReg.Text, out dt))
				{
					Proveedor.fecReg = Convert.ToDateTime(mtxtFechaReg.Text);
				}
				else
				{
					Proveedor.fecReg = null;
				}


				N_Proveedor nProveedor = new N_Proveedor();
				string xRet = nProveedor.guardar(Proveedor);
				if (xRet != "0")
				{
					MessageBox.Show("¡No se pudo guardar el Proveedor!");
				}
				else // se guardo correctamente
				{
					MessageBox.Show("¡El proveedor se guardo correctamente!", "Operacion Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
					if (_idProveedor != 0) // si se realizo una modificacion
					{
						this.Close();
					}
					else if (_frmAnterior == frmBsqProveedor._frmName) // si se agrego un proveedor y fue llamado del bsqProveedor
					{
						this.Close();
					}

				
				}
			}
			else
			{
				MessageBox.Show("¡Los campos obligatorios deben estar completos (*)!","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation);

            switch (respuesta)
            {
                case DialogResult.Yes:


                  N_Proveedor nProveedor = new N_Proveedor();
                    if (_idProveedor != 0) nProveedor.delete(_idProveedor);

                    this.Close();
                    break;

                case DialogResult.No:
                    this.Close();
                    break;
            }
        }
		private void btnAgrLocalidad_Click(object sender, EventArgs e)
		{
			Int16 idProvincia = Convert.ToInt16(((ComboItem)cboProvincia.SelectedItem).Id);
			frmLocalidad frmLocal = new frmLocalidad(_frmName, idProvincia);
			frmLocal.ShowDialog();
			cargarCboLocalidad(idProvincia);
			posicionarCboLocalidad(_idArgLocalidad);
		}
        private void txtLetras_keyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;

                SendKeys.Send("{TAB}");
            }
        }
		private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
		{
			Int16 idProvincia = Convert.ToInt16(((ComboItem)cboProvincia.SelectedItem).Id);
			cargarCboLocalidad(idProvincia);
		}

		private void frmProveedor_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SendKeys.Send("{TAB}");
				e.SuppressKeyPress = true;
			}
		}

		private void txtNombre_Leave(object sender, EventArgs e)
		{
			string descrip = txtNombre.Text;
			if (descrip.Trim() == "")
			{
				picErrorDesc.Visible = true;
			}
			else
			{
				picErrorDesc.Visible = false;
			}
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void btnAyuda_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, Application.StartupPath + "\\AyudaPintureria.chm", HelpNavigator.KeywordIndex, "NuevoProveedor");
		}















        
        
    }
}

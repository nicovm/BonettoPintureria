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
    public partial class frmCliente : Form
    {
		public static string _frmName = "frmCliente";
		public static Int16 _idArgLocalidad = 0;
		string _frmAnterior;
        Int64 _idCliente;


		/// <summary>
		/// Contructor que recibe el nombre de la clase que lo llama y quiere agregar un cliente
		/// </summary>
		/// <param name="frmSuperior"></param>
        public frmCliente(string frmName)
        {
            InitializeComponent();
			this._frmAnterior = frmName;
			this._idCliente = 0;

        }//contructor 1
        /// <summary>
        /// Contructor que recibe el id del cliente y el nombre del formulario que lo llama;
        /// </summary>
        /// <param name="idCliente"></param>
        public frmCliente(string frmName, Int64 idCliente)
        {
            InitializeComponent();
            this._idCliente = idCliente;
			this._frmAnterior = frmName;
        } //Constructor 2
		//Evento de formulario
        private void frmCliente_Load(object sender, EventArgs e)
        {
            if (_idCliente != 0) // consulta un cliente
            {
                consultarCliente();
				if (_idCliente !=1) btnEliminar.Enabled = true; // no perminto que puedo eliminar el consumidor final que tiene id 1
            }
			cargarCboProvincia();
			posicionarCboProvincia(Convert.ToInt16(ConfigurationManager.AppSettings["Provincia"]));
			posicionarCboLocalidad(Convert.ToInt16(ConfigurationManager.AppSettings["Localidad"]));
			txtDescripcion.Select();
			txtDescripcion.Focus();
        }
		private void frmCliente_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				SendKeys.Send("{TAB}");
				e.SuppressKeyPress = true;
			}
		}
		//Metodos
		public void LimpiarTXT()
		{
			txtDescripcion.Text = "";
			txtDireccion.Text = "";
			txtDNI.Text = "";
			txtFecNac.Text = "";
			txtId.Text = "";
			txtMail.Text = "";
			txtObservacion.Text = "";
			txtTelefono.Text = "";
			cbxBoletinProtect.Checked = false;

		}
        private Boolean txtObligatorios()
        {
            Boolean xResp = true;
			if (txtDescripcion.Text == "")
			{
				picErrorDesc.Visible = false;
				xResp = false;
			}
			else
			{
				picErrorDesc.Visible = true;
			}
           
            return xResp;
        }
        private void consultarCliente()
        {
            E_Cliente cliente;
            N_Cliente nCliente = new N_Cliente();
            cliente = nCliente.getOne(_idCliente);

            txtId.Text = cliente.idCliente.ToString();
            txtDescripcion.Text = cliente.descripcion;
            txtDireccion.Text = cliente.direccion;
            cbxBoletinProtect.Checked = cliente.boletinProtec;
            txtObservacion.Text = cliente.observacion;
            txtMail.Text = cliente.mail;
            txtDireccion.Text = cliente.direccion;
            txtDNI.Text =  cliente.dni.ToString();
            txtFecNac.Text = cliente.fecNac.ToString();
            txtTelefono.Text = cliente.telefono;

            posicionarCboProvincia(cliente.localidad.provincia.IdProvincia);
            cargarCboLocalidad(cliente.localidad.provincia.IdProvincia);
            posicionarCboLocalidad(cliente.localidad.idLocalidad);

		
           
        }
        private void posicionarCboProvincia( Int16 idProvincia)
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
            // Int16 idProvincia = Convert.ToInt16(((ComboItem)cboProvincia.SelectedItem).Id);
            //cargarCboLocalidad(idProvincia);

        }
        private void cargarCboLocalidad( Int16 idProvincia)
        {
            cboLocalidad.Items.Clear();
			cboLocalidad.Text = null;
            N_Localidad nLocalidad = new N_Localidad();
            //structura del item del combo
           
            List<E_Localidad> localidades = nLocalidad.getAllLocalidades(idProvincia);
			if (localidades != null)
			{
				foreach (E_Localidad localidad in localidades)
				{
					ComboItem cboItem = new ComboItem();
					cboItem.Id = localidad.idLocalidad;
					cboItem.Text = localidad.nombre;

					cboLocalidad.Items.Add(cboItem);
				}
				cboLocalidad.SelectedIndex = 0;
			}
			else// si no tiene ninguna localidad agregada la provincia
			{
		
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
        private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
			Int16 idProvincia = Convert.ToInt16(((ComboItem)cboProvincia.SelectedItem).Id);
			cargarCboLocalidad(idProvincia);
        }
        private void cboProvincia_Click(object sender, System.EventArgs e)
        {
            //cargarCboLocalidad(Convert.ToInt16(cboProvincia.SelectedValue.ToString()));
        }
		private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation);

            switch (respuesta)
            {
                case DialogResult.Yes:

                   N_Cliente nCliente = new  N_Cliente();
				   if (_idCliente != 0)
				   {
					   string xRet;
					   xRet = nCliente.deleteCliente(_idCliente);
					   if (xRet != "0")
					   {
						   MessageBox.Show("¡El Cliente no se puede eliminar ya ha sido utilizado!", "Eliminar", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
					   }
					   else
					   {
						   this.Close();
					   }
				   }
                    break;

                case DialogResult.No:
                    this.Close();
                    break;
            }

            
          
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
			
        }
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









        private void btnGuardar_Click(object sender, EventArgs e)
        {
            // si devuelve true es que los campos obligatorios estan completos
			if (txtObligatorios() == true)
			{
				E_Cliente cliente = new E_Cliente();
				//si el txt id esta vacio significa que es una cliente nuevo
				if (txtId.Text != "") cliente.idCliente = Convert.ToInt64(txtId.Text);

				cliente.descripcion = txtDescripcion.Text;
				cliente.direccion = txtDireccion.Text;
				if (!string.IsNullOrEmpty(txtDNI.Text)) cliente.dni = Convert.ToInt32(txtDNI.Text);
				cliente.boletinProtec = cbxBoletinProtect.Checked;

				DateTime dt;
				if (DateTime.TryParse(txtFecNac.Text, out dt))
				{
					cliente.fecNac = Convert.ToDateTime(txtFecNac.Text);
				}
				else
				{
					cliente.fecNac = null;
				}
				cliente.observacion = txtObservacion.Text;
				cliente.telefono = txtTelefono.Text;
				cliente.mail = txtMail.Text;
				cliente.localidad.idLocalidad = ((ComboItem)cboLocalidad.SelectedItem).Id;

				N_Cliente nCliente = new N_Cliente();
				string xRet = nCliente.guardar(cliente);
				if (xRet != "0") // si hubo un error 
				{
					MessageBox.Show("No se pudo agregar el cliente","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}

				else // se guardo correctamente
				{
					MessageBox.Show("¡El cliente se agregó correctamente!","Operacion Exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
					if (_idCliente != 0) // se realizo un modificacion
					{
						this.Close();
					}
					else if(_frmAnterior == frmConfVenta._frmName) // si es llamado del frmConfVenta y esta agregando un cliente
					{
						Int64 ultCliente;
						ultCliente = nCliente.ultCliente();

						if (ultCliente != 0)
						{
							frmConfVenta._idCliente = ultCliente; // le paso al confVenta el cliente agregado
							this.Close();
						}

					}
					else if (_frmAnterior == frmBsqCliente._frmName) // si ses llamado del formulario agrCliente 
					{
						this.Close();
					}
					LimpiarTXT();
				}

			}
			else// si los campos estan incompletos
			{
				MessageBox.Show("¡Los campos obligatorios deben estar completos (*)!", "Campos Incompletos", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
			}

        }
		private void picAgrProveedor_Click(object sender, EventArgs e)
		{

		}
		private void btnAgrLocalidad_Click(object sender, EventArgs e)
		{
			Int16 idProvincia = Convert.ToInt16(((ComboItem)cboProvincia.SelectedItem).Id);
			frmLocalidad frmLocal = new frmLocalidad(_frmName,idProvincia);
			frmLocal.ShowDialog();
			cargarCboLocalidad(idProvincia);
			posicionarCboLocalidad(_idArgLocalidad);
        }

		private void txtDescripcion_Leave(object sender, EventArgs e)
		{
			string descripcion = txtDescripcion.Text;
			if (descripcion.Trim() == "")
			{
				picErrorDesc.Visible = true;
			}
			else
			{
				picErrorDesc.Visible = false;
			}
		}

		private void btnAyuda_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, Application.StartupPath + "\\AyudaPintureria.chm", HelpNavigator.KeywordIndex, "NuevoClientes");
		}

		

		
    }
}

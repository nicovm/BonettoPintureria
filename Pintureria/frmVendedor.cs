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
    public partial class frmVendedor : Form
    {
		//variable de estado
		public static string _frmName = "frmVendedor";
		public static Int16 _idAgrLocalidad;
        Int64 idVendedor;
        public frmVendedor(Int32 idVendedor)
        {

            InitializeComponent();
			_idAgrLocalidad = 0;
            ConsultarVendedor(idVendedor);
            cargarComboProv();
        }  
        public frmVendedor()
    {
            InitializeComponent();
			_idAgrLocalidad = 0;
            cargarComboProv();
    }
		//Eventos de Formulario
		private void frmVendedor_Load(object sender, EventArgs e)
		{

		}
		//Metodos
       private void cargarComboProv ()
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
       private void ConsultarVendedor(Int32 idVendedor)
       {
           E_Vendedor Vendedor = new E_Vendedor();
           N_Vendedor NVendedor = new N_Vendedor();

           Vendedor = NVendedor.getOne(idVendedor);

           txtId.Text = Vendedor.idVendedor.ToString();
           txtDescripcion.Text = Vendedor.nombre;
           txtDireccion.Text = Vendedor.direccion;
           txtObservacion.Text = Vendedor.obaservacion;
           txtFecNac.Text = Vendedor.fecNac.ToString();
           txtTelefono.Text = Vendedor.telefono;
           checkBaja.Checked = Vendedor.baja;


           posicionarCboProvincia(Vendedor.localidad.provincia.IdProvincia);
           cargarCboLocalidad(Vendedor.localidad.provincia.IdProvincia);
           posicionarCboLocalidad(Vendedor.localidad.idLocalidad);
		   btnEliminar.Enabled = true;
            

       }
       private Boolean txtObligatorios()
       {
           if (string.IsNullOrEmpty(txtDescripcion.Text))
           {
               return false; // si esta vacio devuelvo false
           }
           return true; // si no true;
       }
		//Eventos
       private void btnGuardar_Click(object sender, EventArgs e)
       {
           if (txtObligatorios())
           {


               E_Vendedor Vendedor = new E_Vendedor();

               if (txtId.Text != "") Vendedor.idVendedor = Convert.ToInt64(txtId.Text);

               Vendedor.nombre = txtDescripcion.Text;
               Vendedor.telefono = txtTelefono.Text;
               Vendedor.localidad.idLocalidad = ((ComboItem)cboLocalidad.SelectedItem).Id;
               Vendedor.obaservacion = txtObservacion.Text;
               Vendedor.direccion = txtDireccion.Text;
               Vendedor.baja = checkBaja.Checked;


               DateTime dt;
               if (DateTime.TryParse(txtFecNac.Text, out dt))
               {
                   Vendedor.fecNac = Convert.ToDateTime(txtFecNac.Text);
               }
               else
               {
                   Vendedor.fecNac = null;
               }


               N_Vendedor nVendedor = new N_Vendedor();
               string xRet = nVendedor.guardar(Vendedor);
               if (xRet != "0")
               {
                   MessageBox.Show("No se pudo agregar el vendedor");
               }
               else
               {
                   MessageBox.Show("¡El vendedor se agregó correctamente!", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

                   this.Close();
               }
           }
           else
           {
               MessageBox.Show("¡Los campos obligatorios deben estar completos (*)!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
           }
            
       }
       private void btnEliminar_Click(object sender, EventArgs e)
       {

       }
       private void btnEliminar_Click_1(object sender, EventArgs e)
       {
           DialogResult respuesta = MessageBox.Show("¿Está seguro que desea eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Exclamation);

           switch (respuesta)
           {
               case DialogResult.Yes:

                   
                  N_Vendedor nVendedor = new N_Vendedor();
            if (idVendedor != 0) nVendedor.delete(idVendedor);

                   this.Close();
                   break;

               case DialogResult.No:
                   this.Close();
                   break;
           }
       }
	   private void btnAgregarLoc_Click(object sender, EventArgs e)
	   {
		   Int16 idProvincia = Convert.ToInt16(((ComboItem)cboProvincia.SelectedItem).Id);
		   frmLocalidad frmLocal = new frmLocalidad(_frmName, idProvincia);
		   frmLocal.ShowDialog();
		   cargarCboLocalidad(idProvincia);
		   posicionarCboLocalidad(_idAgrLocalidad);
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
       private void btnCancelar_Click(object sender, EventArgs e)
       {
           this.Close();
       }
	   private void txtDescripcion_Leave(object sender, EventArgs e)
	   {
		   string descr = txtDescripcion.Text;
		   if (descr.Trim() == "")
		   {
			   picErrorDesc.Visible = true;
		   }
		   else
		   {
			   picErrorDesc.Visible = false;
		   }
		   txtDireccion.Focus();
	   }
	   private void cboProvincia_SelectedIndexChanged(object sender, EventArgs e)
	   {
		   Int16 idProvincia = Convert.ToInt16(((ComboItem)cboProvincia.SelectedItem).Id);
		   cargarCboLocalidad(idProvincia);
	   }

	   private void frmVendedor_KeyDown(object sender, KeyEventArgs e)
	   {
		   if (e.KeyCode == Keys.Enter)
		   {
			   SendKeys.Send("{TAB}");
			   e.SuppressKeyPress = true;
		   }
	   }

	   private void btnAyuda_Click(object sender, EventArgs e)
	   {
		   Help.ShowHelp(this, Application.StartupPath + "\\AyudaPintureria.chm", HelpNavigator.KeywordIndex, "Vendedores");
	   }
    }
}

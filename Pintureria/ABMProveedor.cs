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


namespace Pintureria
{
    public partial class ABMProveedor : Form
    {
		//Variable de estado
		public static string _frmName = "ABMProveedor";
		//Contructor
        public ABMProveedor()
        {
            InitializeComponent();
        }
		//Evento de formulario
		private void ABMProveedor_Load(object sender, EventArgs e)
		{
			refrescarGrilla();
		}
		private void ABMProveedor_Deactivate(object sender, EventArgs e)
		{
			//this.WindowState = FormWindowState.Minimized;
		}
		//Metodos
		private void refrescarGrilla()
		{
			List<E_Proveedor> Proveedores;
			N_Proveedor NProveedor = new N_Proveedor();

			dgProveedor.AutoGenerateColumns = false;

			Proveedores = NProveedor.getAllProveedor(txtBsc.Text);
			if (Proveedores != null)
			{
				dgProveedor.AutoGenerateColumns = false;
				dgProveedor.DataSource = Proveedores;

			}
			else
			{
				MessageBox.Show("No se cargo la gillla");
			}

		}
		private void consultarProveedor(Int32 idProveedor)
		{
			frmProveedor form = new frmProveedor(idProveedor);
			form.ShowDialog();
			refrescarGrilla();
		}
		//Eventos
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProveedor form = new frmProveedor(_frmName);
            form.ShowDialog();
			refrescarGrilla();
        }
        private void btnVaciarLista_Click(object sender, EventArgs e)
        {
            dgProveedor.DataSource = null;
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void dgProveedor_DoubleClick(object sender, EventArgs e)
        {
            //obtener el id de Proveedor
            Int32 idProveedor = Convert.ToInt32(dgProveedor.CurrentRow.Cells[0].Value.ToString());
            consultarProveedor(idProveedor);
         
            
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            refrescarGrilla();
        }

		private void txtBsc_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == (int)Keys.Enter)
			{
				refrescarGrilla();
			}
		}

		private void txtBsc_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				refrescarGrilla();
				e.SuppressKeyPress = true;
			}
			else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
			{
				dgProveedor.Focus();
			}
		}

		private void btnAyuda_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, Application.StartupPath + "\\AyudaPintureria.chm", HelpNavigator.KeywordIndex, "Proveedores");
		}

		

	
    }
}

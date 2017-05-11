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
    public partial class frmBsqProveedor : Form
    {
		public static string _frmName = "BsqProveedor";
		string _frmAnterior;
        public frmBsqProveedor( string frmName)
        {
            InitializeComponent();
			_frmAnterior = frmName;
        }
        private void BsqProveedor_Load(object sender, EventArgs e)
        {
            refrescarGrilla();
        }
        public void refrescarGrilla()
        {
            N_Proveedor nPro = new N_Proveedor();
            dgProveedor.AutoGenerateColumns = false;
            dgProveedor.DataSource = nPro.getAllProveedor(txtFiltro.Text);

        }
        private void dgProveedor_DoubleClick(object sender, System.EventArgs e)
        {
			if (dgProveedor.Rows.Count != 0)
			{
				if (_frmAnterior == frmArticulo._frmName)
				{
					frmArticulo._IdProveedor = Convert.ToInt64(dgProveedor.CurrentRow.Cells[colIdProveedor.Index].Value.ToString());
					frmArticulo._raSocial = dgProveedor.CurrentRow.Cells[colDescripcion.Index].Value.ToString();

				}
				else if (_frmAnterior == frmPedidos._frmName)
				{
					frmPedidos._idProveedor = Convert.ToInt64(dgProveedor.CurrentRow.Cells[colIdProveedor.Index].Value.ToString());
				}

				this.Close();
			}
        }
        private void picBscProv_Click(object sender, EventArgs e)
        {
            refrescarGrilla();
        }
        private void btnNuevoVend_Click(object sender, EventArgs e)
        {
            frmProveedor form = new frmProveedor(_frmName);
            form.ShowDialog();
        }

		

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            refrescarGrilla();
        }

        private void btnAgrLocalidad_Click(object sender, EventArgs e)
        {
            frmProveedor frmProvee = new frmProveedor(_frmName);
            frmProvee.ShowDialog();
            refrescarGrilla();
        }

		private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == (int)Keys.Enter)
			{
				refrescarGrilla();
			}
		}

		

	

		
        
       
       
    }
}

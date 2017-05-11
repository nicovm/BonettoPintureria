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
    public partial class frmBsqCliente : Form
    {
		public static string _frmName = "BsqCliente";
		private string _frmAnterior;
        public frmBsqCliente(string frmName )
        {
            InitializeComponent();
			_frmAnterior = frmName;
        }
		private void BsqCliente_Load(object sender, EventArgs e)
		{
			refrescarGrilla();
		}
		//
		//Metodos
		//
		private void refrescarGrilla()
		{
			List<E_Cliente> clientes;
			N_Cliente NCliente = new N_Cliente();

			dgClientes.AutoGenerateColumns = false;

			clientes = NCliente.getAll(txtFiltro.Text);
			if (clientes != null)
			{
				dgClientes.AutoGenerateColumns = false;
				dgClientes.DataSource = clientes;

			}
			else
			{
				MessageBox.Show("No se cargo la gillla");
			}

		}
		

		private void dgClientes_DoubleClick(object sender, EventArgs e)
		{
			if (_frmAnterior == frmVenta._frmName)
			{
				frmVenta._idCliente = Convert.ToInt64(dgClientes.CurrentRow.Cells[colId.Index].Value.ToString());
				this.Close();
			}
			
		}

		

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            refrescarGrilla();
        }

        private void btnAgrLocalidad_Click(object sender, EventArgs e)
        {
            frmCliente frmCliente = new frmCliente(_frmName);
            frmCliente.ShowDialog();
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

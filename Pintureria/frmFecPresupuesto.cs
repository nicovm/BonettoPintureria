using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pintureria
{
	public partial class frmFecPresupuesto : Form
	{
		public frmFecPresupuesto()
		{
			InitializeComponent();
		}

		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			frmVenta._fecFinPresupuesto = dtFecFinPresupuesto.Value.Date;
			Close();
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			frmVenta._fecFinPresupuesto = null;
			Close();
		}
	}
}

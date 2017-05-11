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
	public partial class frmConfPedido : Form
	{
		

		public frmConfPedido()
		{
			InitializeComponent();
		}

		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			if (dtFecEntrega.Value.Date >= DateTime.Now.Date)
			{
				frmPedidos._fecEntrega = dtFecEntrega.Value;
				this.Close();
			}
			else
			{
				MessageBox.Show("La fecha de entrega no puedo ser menor a la fecha de actual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void frmConfPedido_Load(object sender, EventArgs e)
		{

		}
	}
}

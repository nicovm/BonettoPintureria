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
	public partial class frmAplicarRecargo : Form
	{
		private Int64 _codVenta;
		public frmAplicarRecargo(decimal precioTotal,Int64 codVenta)
		{
			InitializeComponent();
			txtPrecioTotal.Text = precioTotal.ToString();
			txtTotal.Text = precioTotal.ToString();
			_codVenta = codVenta;
			calcularRecargo();
		}
		//Metodos
		private decimal calcularRecargo()
		{
			decimal totalRecargo = 0;
			
			if (!string.IsNullOrEmpty(txtRecargo.Text))
			{
				decimal precioTotal = Convert.ToDecimal(txtPrecioTotal.Text);
				decimal recargo = Convert.ToDecimal(txtRecargo.Text);
				if (cboTipRecargo.SelectedIndex == 0)//%
				{
					totalRecargo = (recargo * precioTotal / 100) ;
				}
				else//$
				{
					totalRecargo = recargo;
				}
				txtTotal.Text = (totalRecargo + precioTotal).ToString("N2");
			}


			return totalRecargo;
		}

		private void frmAplicarRecargo_Load(object sender, EventArgs e)
		{
			cboTipRecargo.SelectedIndex = 0;
		}

		private void txtRecargo_Leave(object sender, EventArgs e)
		{
			decimal recargo;
			if (decimal.TryParse(txtRecargo.Text, out recargo))
			{
				calcularRecargo();
			}
			else
			{
				txtRecargo.Text = "0";
			}
		}

		private void cboTipRecargo_SelectedIndexChanged(object sender, EventArgs e)
		{
			calcularRecargo();
		}

		private void btnAplicarRecargo_Click(object sender, EventArgs e)
		{
			decimal recargo;
			if (decimal.TryParse(txtRecargo.Text, out recargo))
			{
				recargo = calcularRecargo();
				decimal nvoPrecioTotal = Convert.ToDecimal(txtTotal.Text);
				N_Venta nVenta = new N_Venta();
				Boolean xConf = nVenta.aplicarRecargoVenta(_codVenta,recargo,nvoPrecioTotal);
				if (!xConf)
				{
					MessageBox.Show("Error no se pudo aplicar el recargo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				this.Close();	
			}
			
		}
	}
}

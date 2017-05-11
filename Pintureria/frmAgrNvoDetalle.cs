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
	public partial class frmAgrNvoDetalle : Form
	{
		public frmAgrNvoDetalle()
		{
			InitializeComponent();
		}

		private void txtPrecio_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

			if (e.KeyChar == '.')
			{
				e.Handled = true;
				SendKeys.Send(",");
			}

			char coma = Convert.ToChar(",");


			if (!(char.IsNumber(e.KeyChar) | e.KeyChar.Equals(coma) | char.IsControl(e.KeyChar)))
				e.Handled = true;
		}
		private void txtNumeros_KeyPress(object sender, System.Windows.Forms.KeyPressEventArgs e)
		{

			if (!(char.IsNumber(e.KeyChar) | char.IsControl(e.KeyChar)))
				e.Handled = true;
		}
		private void frmAgrNvoDetalle_Load(object sender, EventArgs e)
		{
			txtPrecio.Text = Convert.ToDecimal(0).ToString("N2");
			txtPrecioTotal.Text = Convert.ToDecimal(0).ToString("N2");
			txtCantidad.Text ="1";
		}

		private void btnAgr_Click(object sender, EventArgs e)
		{
			
			frmVenta._detNvoArticulo = new Entidades.E_DetalleVenta();
			frmVenta._detNvoArticulo.descripcion = txtDescripcion.Text;
			frmVenta._detNvoArticulo.precioArticulo = Convert.ToDecimal( txtPrecio.Text);
			frmVenta._detNvoArticulo.cantidad = Convert.ToInt16(txtCantidad.Text);
			frmVenta._detNvoArticulo.precioTotal = Convert.ToDecimal(txtPrecioTotal.Text);
			frmVenta._detNvoArticulo.stockActual = 0;

			this.Close();
			
		}

		private void txtPrecio_txtCantidad_Leave(object sender, EventArgs e)
		{
			decimal xPrecio = 0;
			if (!decimal.TryParse(txtPrecio.Text, out xPrecio))
			{
				txtPrecio.Text = xPrecio.ToString("N2");
			}
			else
			{
				txtPrecio.Text = xPrecio.ToString("N2");
			}

		 //Calcular el total
			int cantidad = Convert.ToInt16(txtCantidad.Text);
			decimal precio = Convert.ToDecimal(txtPrecio.Text);
			txtPrecioTotal.Text = (cantidad * precio).ToString("N2");

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			frmVenta._detNvoArticulo = null;
			this.Close();
		}

	
	}
}

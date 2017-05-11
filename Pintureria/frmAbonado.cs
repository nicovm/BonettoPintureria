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
	public partial class frmAbonado : Form

	{
		private static E_Venta _ventaAbonar;
		public frmAbonado(E_Venta venta)
		{
			InitializeComponent();
			_ventaAbonar = venta;
			cargar();
		}

		private void frmAbonar_Load(object sender, EventArgs e)
		{

		}
		//Metodos
		private void cargar()
		{
			txtSaldo.Text = _ventaAbonar.saldo.ToString("N2");
			txtAbona.Text = _ventaAbonar.saldo.ToString("N2");
			calcularVuelto();
		}
		private decimal calcularVuelto()
		{
			decimal saldo = Convert.ToDecimal(txtSaldo.Text);
			decimal abonado = Convert.ToDecimal(txtAbona.Text);
			
			decimal vuelto =  abonado-saldo;
			txtVuelto.Text = vuelto.ToString("N2");
			return vuelto;
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
		private void txtAbona_Leave(object sender, EventArgs e)
		{
			decimal abona = 0;
			if (!decimal.TryParse(txtAbona.Text, out abona))
			{
				MessageBox.Show("Precio Abonado no es valido", "Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
				txtAbona.Text = "0";
				txtAbona.Focus();
				txtAbona.SelectAll();
			}
			calcularVuelto();
		}
		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			decimal abonado = Convert.ToDecimal(txtAbona.Text);
			decimal saldo = Convert.ToDecimal(txtSaldo.Text);
			Boolean XConf=true;
			N_Venta nVenta = new N_Venta();
			if (abonado >= saldo) // abono el totalidad del saldo
			{
				XConf = nVenta.abonarVenta(_ventaAbonar, saldo);
			}
			else if(abonado<saldo) // no abono la totalidad del saldo
			{
				XConf = nVenta.abonarVenta(_ventaAbonar, abonado);
			}
			
			if (!XConf)
			{
				MessageBox.Show("Error", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			this.Close();
		}
	}
}

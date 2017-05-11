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
	public partial class frmCajaInicial : Form
	{
		public frmCajaInicial()
		{
			InitializeComponent();
		}

		private void frmCajaInicial_Load(object sender, EventArgs e)
		{

		}
		//Metodos
		private Boolean validarCajaInicial()
		{
			decimal cajaInicial=0;
			if (!decimal.TryParse(txtCajaInicial.Text, out cajaInicial))
			{
				txtCajaInicial.Text = "0";
				MessageBox.Show("Precio de Caja Incial Incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			else
			{
				txtCajaInicial.Text = cajaInicial.ToString("N2");
			}
			return true;
		}
		//Eventos
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

		private void txtCajaInicial_Leave(object sender, EventArgs e)
		{
			if (!validarCajaInicial())
			{
				txtCajaInicial.Focus();
				txtCajaInicial.SelectAll();
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAbrirCaja_Click(object sender, EventArgs e)
		{
			N_Caja nCaja = new N_Caja();
			E_Caja caja = new E_Caja();

			caja.caja = Convert.ToDecimal(txtCajaInicial.Text);
			caja.fecCaja = DateTime.Now.Date;
			Boolean xConf = nCaja.abrirCajaDiaria(caja);
			if (!xConf)
			{
				MessageBox.Show("No puedo abrir la Caja Diaria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				this.Close();
			}
			
		}
	}
}

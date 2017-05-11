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
	public partial class frmConfVenta : Form
	{
		//variable de estado
		string _frmSuperior;
		public static string _frmName = "frmConfVenta";
		public static Int64 _idCliente;
		E_Venta _venta = null;
		E_Pedido _compra = null;

		//contructor
		public frmConfVenta(E_Venta venta , string frmSuperior)
		{
			InitializeComponent();
			_frmSuperior = frmSuperior;
			_venta = venta;
			_idCliente = 0;
		}
		public frmConfVenta(E_Pedido compra, string frmSuperior)
		{
			InitializeComponent();
			_frmSuperior = frmSuperior;
			_compra = compra;
		}
		
		private void frmConfVenta_Load(object sender, EventArgs e)
		{
			if (_frmSuperior == frmVenta._frmName)
			{
				txtTotal.Text = _venta.precioTotal.ToString("N2");
				txtEntrega.Text = _venta.precioTotal.ToString("N2");

                decimal credito =  getCredito();
                txtCredito.Text = credito.ToString("N2");

                // Si habilita los botones de credito , si el credito es mayor a cero
                gbCredito.Enabled = credito > 0; 

                
			}
			else if(_frmSuperior == frmPedidos._frmName)
			{
				txtTotal.Text = _compra.precioTotal.ToString("N2");
				txtEntrega.Text = _compra.precioTotal.ToString("N2");
			}
			
			calcularVuelto();

		}
		//Metodos
		private Boolean abonadoValido()
		{
			decimal salida=0;
			if(!decimal.TryParse(txtEntrega.Text, out salida))
			{
				MessageBox.Show("¡El precio de entrega no es valido!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
			return true;
		}
		private void calcularVuelto()
		{
			decimal entrega = 0;
			decimal total = Convert.ToDecimal(txtTotal.Text);
			if (abonadoValido())
			{
				entrega = Convert.ToDecimal(txtEntrega.Text);
				txtEntrega.Text = entrega.ToString("N2");
			}
			
			txtVuelto.Text = (entrega - total).ToString("N2");

		}
		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void txtEntrega_Click(object sender, EventArgs e)
		{
			txtEntrega.SelectAll();
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
		private void txtEntrega_GotFocus(object sender, System.EventArgs e)
		{
			if (!String.IsNullOrEmpty(txtEntrega.Text))
			{
				txtEntrega.SelectAll();
			}
		}
		private void txtEntrega_Leave(object sender, EventArgs e)
		{
			if (abonadoValido())
			{
				calcularVuelto();
			}
			else
			{
				txtEntrega.Text = "0";
				txtEntrega.Focus();
				txtEntrega.SelectAll();
			}
		}
		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			decimal total = Convert.ToDecimal(txtTotal.Text);
			decimal entrega = Convert.ToDecimal(txtEntrega.Text);

			if (_frmSuperior == frmVenta._frmName)
			{
				N_Venta nVenta = new N_Venta();
				Int64 codVenta;

                if (_venta.cliente.idCliente == 1 && entrega < total) // el cliente es un consumidor final = 1  y no paga el total de la venta
                {
                    DialogResult XResult = MessageBox.Show("El cliente no tiene cuenta. ¿Desea crearle una?", "Informacion", MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Question);

                    switch (XResult)
                    {
                        case DialogResult.Yes: //Crear una nuevo cliente
                            {
                                frmCliente frmCliente = new frmCliente(_frmName);
                                frmCliente.ShowDialog();
                                if (_idCliente != 0) _venta.cliente.idCliente = _idCliente;
                                break;
                            }
                    }

                }
                else
                {
                    _venta.abonado = entrega;
                    codVenta = nVenta.addVenta(_venta, cbCredito.Checked);

                    if (codVenta != 0) frmVenta._confVenta = true;
                    this.Close();
                }
			}

		}
		private void frmConfVenta_FormClosing(object sender, FormClosingEventArgs e)
		{

		}
		private void frmConfVenta_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				 SendKeys.Send("{TAB}");
                e.SuppressKeyPress = true;
			}
			if (e.KeyCode == Keys.Escape) this.Close();
		}
        private void setUtilizarCredito(Boolean utilizar)
        {
            lblCredito.Enabled = utilizar;
            txtCredito.Enabled = utilizar;

            if (utilizar) //Utiliza el credito
            {
                decimal total = _venta.precioTotal - getCredito();

                if (total < 0)  // el credito es mayor al total de la venta
                {
                    //El total de la venta es cero
                    txtTotal.Text = Convert.ToString(0);
                    txtEntrega.Text = Convert.ToString(0);
                }
                else// el total es 0 o mayor
                {
                    txtTotal.Text = total.ToString("N2");
                    txtEntrega.Text = total.ToString("N2");
                    
                }
            }
            else //Si deja de utilizar el credito
            {
                txtTotal.Text = _venta.precioTotal.ToString("N2");
                txtEntrega.Text = _venta.precioTotal.ToString("N2");
              
            }

            calcularVuelto();

        }
        

        /// <summary>
        /// Permite obtener el credito del cliente
        /// </summary>
        /// <returns></returns>
        private decimal getCredito()
        {
            Negocio.N_NotasCredito nNC = new N_NotasCredito();
            decimal credito = nNC.getCredito(_venta.cliente.idCliente);


            if (credito != -1) return credito;
            else
            {
                // surgio un error
                MessageBox.Show("Surgió un error , no pudieron obtener los créditos", "getCredito", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
            

        }

        private void cbCredito_CheckedChanged(object sender, EventArgs e)
        {
            setUtilizarCredito(cbCredito.Checked);
        }

       

     

	

	}
}
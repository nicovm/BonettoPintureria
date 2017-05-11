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
	public partial class frmPerfil : Form
	{
		private E_Usuario _oUsuarioSesion;
		public frmPerfil(E_Usuario oUsuario)
		{
			InitializeComponent();
			_oUsuarioSesion = oUsuario;
			txtUsuario.Text = _oUsuarioSesion.nombre;

		}

		private void btnConfirmar_Click(object sender, EventArgs e)
		{
			if (txtObligatorios())
			{
				//Comparo las contraseñas									
				if (string.Compare(txtContraAnterior.Text, _oUsuarioSesion.contrasenia, false) == 0)  // si el resutlado de la comparacion da 0 es que son iguales
				{
					N_Usuario eUsuarios = new N_Usuario();

					bool xRet = eUsuarios.setContrasenia(txtContraNueva.Text, _oUsuarioSesion.idUsuario);
					if (!xRet)
					{
						this.Close();
					}
					else
					{
						MessageBox.Show("Error en el cambio de contraseña intente nuevamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}
				}
			}
		}
		private Boolean txtObligatorios()
		{
			if (txtContraAnterior.Text.Trim() == "" && txtContraNueva.Text.Trim() == "")
			{
				epInciarSesion.SetError(txtContraNueva, "Campos Incompletos");
				epInciarSesion.SetError(txtContraAnterior, "Compos Incompletos");
				return false;
			}
			return true;
		}

	}
}

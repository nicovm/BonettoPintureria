using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Entidades;

namespace Pintureria
{
	public partial class frmInicioSesion : Form
	{
		public static Boolean _iniciaSesion = false;
		public E_Usuario oUsuarioSession = null;
		public frmInicioSesion()
		{
			InitializeComponent();
            lblVersion.Text = Negocio.N_VersionSisitema.GETVERSION();
		}

		private void btnIniciarSesion_Click(object sender, EventArgs e)
		{
			
			if (txtObligatorios())
			{
				Negocio.N_Usuario nUsuario = new Negocio.N_Usuario();
				oUsuarioSession = nUsuario.iniciarSesion(txtUsuario.Text,txtContrasenia.Text);
				if (oUsuarioSession != null)
				{
					this.DialogResult = System.Windows.Forms.DialogResult.OK;
					_iniciaSesion = true;
					//MessageBox.Show("Iniciar Sesion");
				}
				else
				{
					epInciarSesion.SetError(txtUsuario,"Usuario o Contraseña incorrecta");
					epInciarSesion.SetError(txtContrasenia, "Usuario o Contraseña incorrecta");
				}
			}

		}

		public Boolean txtObligatorios()
		{
			if (txtUsuario.Text.Trim() == null)
			{
				epInciarSesion.SetError(txtUsuario, "Debe completar los campos obligatorios(*)");
				return false;
			}
			if (txtContrasenia.Text.Trim() == null)
			{
				epInciarSesion.SetError(txtContrasenia, "Debe completar los campos obligatorios(*)");
				return false;
			}
			return true;
		}

		private void frmInicioSesion_Load(object sender, EventArgs e)
		{

		}

		private void frmInicioSesion_FormClosing(object sender, FormClosingEventArgs e)
		{
			if(!_iniciaSesion)
			{
			this.DialogResult = System.Windows.Forms.DialogResult.Abort;
			}
		}

		private void txtContrasenia_Enter(object sender, EventArgs e)
		{
			//Pregunto si esta habilitado la mayuscula cuando escribe la contraseña
			if (Control.IsKeyLocked(Keys.CapsLock))
			{
				ToolMayu.SetToolTip(txtContrasenia, "Mayuscula Activada");
			}
		
		}

		private void txtContrasenia_KeyDown(object sender, KeyEventArgs e)
		{
			

			
		}

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

		

	
	}
}

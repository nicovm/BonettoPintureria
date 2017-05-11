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
	public partial class frmTipoListaImportar : Form
	{
		public frmTipoListaImportar()
		{
			InitializeComponent();
		}

		private void btnTersuave_Click(object sender, EventArgs e)
		{
			
		
		}

		private void btnImportarTersuave_Click(object sender, EventArgs e)
		{
			
			
		}

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
			if (rdbQuimex.Checked == true)
			{
				frmImportarLista frm = new frmImportarLista(E_Marca.QUIMEX);

				frm.Show();

				this.Close();
			}

			else
			{
				frmImportarLista frm = new frmImportarLista(E_Marca.TERSUAVE);

				frm.Show();

				this.Close();
			}

        }

		

	
	}
}

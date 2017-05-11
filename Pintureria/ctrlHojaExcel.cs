using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Pintureria
{
	public partial class ctrlHojaExcel : UserControl
	{
		public delegate void eventHojaSelecionada(string Hoja);
		public event eventHojaSelecionada hojaSeleccionada ;

		protected virtual void clickHojaSeleccionada(string hoja)
		{
			eventHojaSelecionada tmp = hojaSeleccionada;
			if (tmp != null)
				tmp(hoja);
		}

		public ctrlHojaExcel( string hoja)
		{
			InitializeComponent();
			lblNombreHoja.Text = hoja;
		}
		public ctrlHojaExcel()
		{
			InitializeComponent();
			
		}

		private void btnSeleccionar_Click(object sender, EventArgs e)
		{
			clickHojaSeleccionada(lblNombreHoja.Text);
		}

		
	}
}

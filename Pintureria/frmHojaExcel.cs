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
	public partial class frmHojaExcel : Form
	{
		public String HOJA_SELECCIOANDA;

		public frmHojaExcel( List<String> hojas)
		{
			InitializeComponent();
			CargarHojas(hojas);
		}

		private void CargarHojas(List<String> hojas)
		{
			foreach (string hoja in hojas)
			{
				ctrlHojaExcel _ctrlHoja = new ctrlHojaExcel(hoja);
				flpHojaExcel.Controls.Add(_ctrlHoja);
				_ctrlHoja.hojaSeleccionada += hojaSeleccionada_Click;

			}
		}

		private void hojaSeleccionada_Click(string hoja)
		{
			HOJA_SELECCIOANDA = hoja;
			DialogResult = DialogResult.OK;
		}
	}
}

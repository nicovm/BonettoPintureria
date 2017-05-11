
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Windows.Forms;

namespace Pintureria
{
	public class ClsColItem : DataGridViewColumn //hereda de la clase coluna de una datagridview
	{
		private Int16 _orden;
		private string _condicion;
		private decimal _porcentaje;

		//Metdos setter y getter
		public Int16 orden { get { return _orden; } set { _orden = value; } }
		public string condicion { get { return _condicion; } set { _condicion = value; } }
		public decimal porcentaje { get { return _porcentaje; } set { _porcentaje = value; } }
	}
}

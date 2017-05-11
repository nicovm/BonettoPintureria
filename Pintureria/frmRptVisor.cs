using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
namespace Pintureria
{
	public partial class frmRptVisor : Form
	{
		public frmRptVisor(ReportDocument rpt)
		{
			InitializeComponent();
			if (rpt != null)
			{
				this.crvVisor.ReportSource = rpt;
			}
		}

		private void frmRptVisor_Load(object sender, EventArgs e)
		{
			
		}

		private void generarRptVenta()
		{

		}
	}
}

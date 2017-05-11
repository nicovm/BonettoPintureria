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
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;

namespace Pintureria
{
	public partial class Caja : Form
	{
		public Caja()
		{
			InitializeComponent();
			cargarCaja();
		}

		private void frmCaja_Load(object sender, EventArgs e)
		{
			cargarCaja();
		}
		private void cargarCaja()
		{
			N_Caja nCaja = new N_Caja(); 
			// devuelve 1 si existe un caja abierta del dia
			Int16 count = 0;//nCaja.countCajaDiaria(dtCaja.Value.Date);
			if (count == 1)
			{
				E_Caja caja = nCaja.getOneCajaDiaria(dtCaja.Value.Date);
				if (caja != null)
				{
					//txtCaja.Text = caja.caja.ToString("N2");
				}
				else// ERROR
				{

				}

			}
			else if (count == 0) // si devuelve cero significa que no se abrio la caja
			{
				txtCajaInical.Text = "0";
			}
			else// sino surgio un error en la consulta
			{
			}
			E_Caja cajaDiaria = nCaja.getOneCaja(dtCaja.Value.Date);

			if (cajaDiaria != null)
			{
				txtCajaInical.Text = cajaDiaria.caja.ToString("N2");
				txtEfectivo.Text = cajaDiaria.efectivo.ToString("N2");
				txtTarjCredito.Text = cajaDiaria.tarjCredito.ToString("N2");
				txtCheque.Text = cajaDiaria.cheques.ToString("N2");
                txtCreditoOrtogado.Text = cajaDiaria.notaCreditoOrtogado.ToString("N2");
                txtCreditoUtilizado.Text = cajaDiaria.notaCreditoUtilizado.ToString("N2");
			
			}
			else
			{
				txtCajaInical.Text =  "0";
				txtEfectivo.Text = "0";
				txtCheque.Text = "0";
				txtTarjCredito.Text = "0" ;
                txtCreditoUtilizado.Text = "0";
                txtCreditoOrtogado.Text = "0";
			}
			calcularTotal();
			
		}

		//METODOS
		private void calcularTotal()
		{
			decimal cajaInicial = Convert.ToDecimal(txtCajaInical.Text);
			decimal efectivo = Convert.ToDecimal(txtEfectivo.Text);
			decimal cheques = Convert.ToDecimal(txtCheque.Text);
			decimal tarjetaCred = Convert.ToDecimal(txtTarjCredito.Text);



			txtCajaTotal.Text = (cajaInicial + efectivo + cheques + tarjetaCred).ToString("N2"); 
		}

		private void txtCaja_Leave(object sender, EventArgs e)
		{
			calcularTotal();
		}

		private void dtCaja_ValueChanged(object sender, EventArgs e)
		{
			cargarCaja();
		}

		private void btnImprimir_Click(object sender, EventArgs e)
		{
			try
			{
				string ruta = Application.StartupPath + "\\crCajaDiaria.rpt";
				ReportDocument rpt = new ReportDocument();

				dsCajaDiaria dsPintureriaCajaDiaria = new dsCajaDiaria();
				dsCajaDiariaTableAdapters.getOneCajaRptTableAdapter cajaDiariaTableAdapter = new dsCajaDiariaTableAdapters.getOneCajaRptTableAdapter();

				cajaDiariaTableAdapter.Fill(dsPintureriaCajaDiaria.getOneCajaRpt, dtCaja.Value);

				dsPintureriaCajaDiaria.EnforceConstraints = false;

			

				rpt.Load(ruta);
				rpt.SetDataSource(dsPintureriaCajaDiaria);
				rpt.SetParameterValue("parCajaInicial", txtCajaInical.Text);


				frmRptVisor frmVerRpt = new frmRptVisor(rpt);
				frmVerRpt.Show();
			}
			catch (Exception)
			{

				
			}
		}
	}
}

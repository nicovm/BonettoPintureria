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
    public partial class ABMClientes : Form
    {
		//Variable de estado
		static string _frmName = "ABMCliente";

        public Boolean _abrirCuentaCorriente { get; set; }
		//Contructor
        public ABMClientes(Boolean abrirCuentaCorriente = false )
        {
            InitializeComponent();
            _abrirCuentaCorriente = abrirCuentaCorriente;
        }
		//Eventos de Formlario
        private void ABMClientes_Load(object sender, EventArgs e)
        {
            refrescarGrilla();
        }
		private void ABMClientes_Deactivate(object sender, EventArgs e)
		{
			//this.WindowState = FormWindowState.Minimized;
		}
		
		//Metodos
		private void consultarCliente(Int64 idCliente)
		{
			frmCliente frmClie = new frmCliente(_frmName, idCliente);
			frmClie.ShowDialog();
			refrescarGrilla();
		}
        private void refrescarGrilla()
        {
            List<E_Cliente> clientes;
            N_Cliente NCliente = new N_Cliente();

            dgClientes.AutoGenerateColumns = false;

            clientes = NCliente.getAll(txtBsc.Text);
            if (clientes != null)
            {
                dgClientes.AutoGenerateColumns = false;
                dgClientes.DataSource = clientes;
               
            }
            else
            {
                MessageBox.Show("No se cargo la gillla");
            }

        }

        private void consultarCuentaCorriente(Int64 idCliente )
        {
            frmCuentaCorriente frm = new frmCuentaCorriente(idCliente);
            frm.Show();
        }
		//Eventos
        private void txtBsc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                refrescarGrilla();
			
            }
        }
        private void dgClientes_DoubleClick(object sender, System.EventArgs e)
        {
            //obtener el id cliente
            Int64 idCliente = Convert.ToInt64(dgClientes.CurrentRow.Cells[0].Value.ToString());

            if (!_abrirCuentaCorriente) consultarCliente(idCliente); else consultarCuentaCorriente(idCliente);
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCliente frmClie = new frmCliente(_frmName);
            frmClie.ShowDialog();
			refrescarGrilla();
        }
        private void btnVaciarLista_Click(object sender, EventArgs e)
        {
            dgClientes.DataSource = null;
        }
        private void dgClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBusCod_Click(object sender, EventArgs e)
        {
            refrescarGrilla();
        }
		private void txtBsc_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				refrescarGrilla();
				e.SuppressKeyPress = true;
			}
			else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
			{
				dgClientes.Focus();
			}
		}

		private void btnAyuda_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, Application.StartupPath + "\\AyudaPintureria.chm", HelpNavigator.KeywordIndex, "Clientes");
		}

		
		
    }
}

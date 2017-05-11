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
    public partial class ABMVendedores : Form
    {
		//contructor
        public ABMVendedores()
        {
            InitializeComponent();
        }
		//Eventos de formulario
		private void ABMVendedores_Deactivate(object sender, EventArgs e)
		{
			//this.WindowState = FormWindowState.Minimized;
		}
		private void ABMVendedores_Load(object sender, EventArgs e)
		{
			refrescarGrilla();

		}
		//Metodos
        private void refrescarGrilla()
        {
            List<E_Vendedor> Vendedores;
            N_Vendedor NVendedor = new N_Vendedor ();

            Vendedores = NVendedor.getAll(txtBuscar.Text);
            if (Vendedores != null)
            {
                dgVendedor.AutoGenerateColumns = false;
                dgVendedor.DataSource = Vendedores;

            }
            else
            {
                MessageBox.Show("No se cargo la gillla");
            }

        }
		private void consultarVendedor(Int32 idVendedor)
		{
			frmVendedor form = new frmVendedor(idVendedor);
			form.ShowDialog();
			refrescarGrilla();
		}
        private void dgVendedor_DoubleClick(object sender, EventArgs e)
        {
            //obtener el id de vendedor
            Int32 idVendedor = Convert.ToInt32(dgVendedor.CurrentRow.Cells[0].Value.ToString());
            consultarVendedor(idVendedor);
        }
      
        private void btnNuevoVend_Click(object sender, EventArgs e)
        {
            frmVendedor form = new frmVendedor();
            form.ShowDialog();
			refrescarGrilla();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            refrescarGrilla();
        }

		private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == (int)Keys.Enter)
			{
				refrescarGrilla();
			}
		}

		private void txtBuscar_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				refrescarGrilla();
				e.SuppressKeyPress = true;
			}
			else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
			{
				dgVendedor.Focus();
			}
		}

       
    }
}

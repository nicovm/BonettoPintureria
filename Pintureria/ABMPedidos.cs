using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Negocio;
using Entidades;

namespace Pintureria
{
    public partial class ABMPedidos : Form
    {
        public ABMPedidos()
        {
            InitializeComponent();
        }

		private void ABMPedidos_Load(object sender, EventArgs e)
		{
			refrescarGrilla();
		}
		private void refrescarGrilla()
		{
			DateTime fecDesde = dtDesde.Value.Date;
			DateTime fecHasta = dtHasta.Value.Date;
			if (fecDesde <= fecHasta)
			{

				List<E_Pedido> pedidos;
				N_Pedido nPedido = new N_Pedido();

				dgPedidos.AutoGenerateColumns = false;
				//selecciono el estado de busqueda del radio button
				string estado;
				if (rbTodos.Checked) estado = "todos";
				else if (rbPendiente.Checked) estado = "pendiente";
				else if (rbConfirmados.Checked) estado = "confirmado";
				else estado = "anulado";

				pedidos = nPedido.getAllPedido(dtDesde.Value, dtHasta.Value, txtBscProveedor.Text,estado);
				if (pedidos != null)
				{
					dgPedidos.AutoGenerateColumns = false;
					dgPedidos.DataSource = pedidos;
					txtCantPedidos.Text = pedidos.Count().ToString();

					foreach (DataGridViewRow row in dgPedidos.Rows)
					{
						Int32 idEstado = Convert.ToInt32(row.Cells[colEstado.Index].Value);

						if (idEstado == E_EstadoPedido.CONFIRMADO) // 
						{
							//Cambio el color de la fila a naranja o a cualquier otro color
							dgPedidos.Rows[row.Index].DefaultCellStyle.BackColor = Color.LightGreen;
						}
						else if( idEstado == E_EstadoPedido.ANULADO) //
						{
							
							dgPedidos.Rows[row.Index].DefaultCellStyle.BackColor = Color.OrangeRed;
						}
					}

				}
				else
				{
					MessageBox.Show("¡No se cargó la gilla!");
				}
			}
			else // su la fecha desde es mayo al hasta
			{
				MessageBox.Show("¡La fecha DESDE tiene que ser menor a la fecha HASTA!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
		}

		private void btnBuscar_Click(object sender, EventArgs e)
		{
			refrescarGrilla();
		}

		private void rbTodos_CheckedChanged(object sender, EventArgs e)
		{
            refrescarGrilla();
		}

		private void dgPedidos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgPedidos.RowCount > 0)
			{
				Int64 codPedido = Convert.ToInt16(dgPedidos.CurrentRow.Cells[colCodPedido.Index].Value);
				frmPedidos _frmPedido = new frmPedidos(codPedido);//consultar la venta
				_frmPedido.ShowDialog();
				refrescarGrilla();
			}
		}

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbConfirmados_CheckedChanged(object sender, EventArgs e)
        {
            refrescarGrilla();
        }

        private void rbPendiente_CheckedChanged(object sender, EventArgs e)
        {
            refrescarGrilla();
        }

        private void rbAnulados_CheckedChanged(object sender, EventArgs e)
        {
            refrescarGrilla();
        }

	

		private void txtBscProveedor_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				refrescarGrilla();
				e.SuppressKeyPress = true;
			}
			else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
			{
				dgPedidos.Focus();
			}
		}
    }
}

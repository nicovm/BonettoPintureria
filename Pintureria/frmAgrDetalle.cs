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
    public partial class frmAgrDetalle : Form
    {
		//Variable de estado
		private string _frmSuperior;
		private static Int16 _filtrarXdefecto = -1;
		private static Int16 _filtrarXcodigo = 0;
		private static Int16 _filtrarXDescrMarc = 1;
		public static string _frmName = "agrDetalle";
		//Contructor
		public frmAgrDetalle(string frmSuperior)
		{
			InitializeComponent();
			this._frmSuperior = frmSuperior;
		}
		//Eventos de formulario
		private void AgrDetalle_Load(object sender, EventArgs e)
		{
			refrescarGrilla(_filtrarXdefecto);
		}
		//Metodos
		private void enStockMin()
		{
			Int16 stockMin = Convert.ToInt16(dgArticulo.CurrentRow.Cells["colStockMin"].Value);
			Int16 stock = Convert.ToInt16(dgArticulo.CurrentRow.Cells["colStock"].Value);
			string descripcion = dgArticulo.CurrentRow.Cells["colDescripcion"].Value.ToString();
			if (stock <= stockMin)
			{
				//lblInfo.Text = "El articulo " + descripcion + " esta dentro de los margenes del stock minimo";
				MessageBox.Show("El articulo " + descripcion + " esta dentro de los margenes del stock minimo", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			
		}
		private void cargarArticuloAlDetalle()
		{
			if (dgArticulo.Rows.Count != 0)
			{
				string codArticulo = dgArticulo.CurrentRow.Cells["colCodArticulo"].Value.ToString();
				if (_frmSuperior == frmVenta._frmName)
				{
					enStockMin();
					frmVenta._codArticuloAgr = codArticulo;
					this.Close();
				}
				else if (_frmSuperior == frmPedidos._frmName)
				{
					frmPedidos._codArticuloAgr = codArticulo;
					this.Close();
				}

			}
		}
		private void refrescarGrilla(Int16 idFiltro)
		{
			//id -1 = Filtro no lleva ninguna filtro
			//id 0 = Filtro por codigo de articulo
			//id 1 = Filtro por marca y descripcion de articulo

			N_Articulo nArticulo = new N_Articulo();

			dgArticulo.AutoGenerateColumns = false;
			List<E_Articulo> articulos;
			if (idFiltro == _filtrarXcodigo) //filtra por codigo
			{

				articulos = nArticulo.getAllArticulosXcod(txtFiltroCod.Text);
			}
			else if (idFiltro == _filtrarXDescrMarc) // filtra por marca y descripcion
			{
				articulos = nArticulo.getAllArticulos(txtFiltro.Text);
			}
			else//filtro por defecto
			{
				articulos = nArticulo.getAllArticulos("");
			}

			if (articulos != null)
			{
				dgArticulo.DataSource = articulos;
				//dgArticulo.Focus();
			}
			else
			{
				MessageBox.Show("No se pudo cargar la grilla","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
			}
		}
		//Eventos 
		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void AgrDetalle_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Escape) this.Close();

		}
		private void picAgrArticulo_Click(object sender, EventArgs e)
		{
			frmArticulo frmArticulo = new frmArticulo(null,_frmName);
			frmArticulo.ShowDialog();
			refrescarGrilla(_filtrarXdefecto);

		}
        private void btnBuscar2_Click(object sender, EventArgs e)
        {
            refrescarGrilla(_filtrarXcodigo);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            refrescarGrilla(_filtrarXDescrMarc);
        }
        private void dgArticulo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                cargarArticuloAlDetalle();
                //e.SuppressKeyPress = true;
            }
        }
        private void txtFiltroCod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                refrescarGrilla(_filtrarXcodigo);
                e.SuppressKeyPress = true;
            }
            if (e.KeyCode == Keys.Space) e.SuppressKeyPress = true;
        }
        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                refrescarGrilla(_filtrarXDescrMarc);
                e.SuppressKeyPress = true;
            }
			else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
			{
				dgArticulo.Focus();
			}
        }
        private void dgArticulo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }
        private void dgArticulo_DoubleClick(object sender, EventArgs e)
        {
            cargarArticuloAlDetalle();
        }
		//private void txtFiltro_KeyPress(object sender, KeyPressEventArgs e)
		//{
		//    if ((int)e.KeyChar == (int)Keys.Enter)
		//    {
		//        refrescarGrilla(_filtrarXDescrMarc);
		//        txtFiltro.Focus();
		//    }

		//}
		private void txtFiltroCod_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == (int)Keys.Enter)
			{
				refrescarGrilla(_filtrarXcodigo);
			}
			txtFiltroCod.Focus();
		}
    }
}

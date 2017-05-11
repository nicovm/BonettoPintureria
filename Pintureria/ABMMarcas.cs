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
    public partial class ABMMarcas : Form
    {
        public ABMMarcas()
        {
            InitializeComponent();
        }
		//Eventos de formulario
        private void ABMMarcas_Load(object sender, EventArgs e)
        {
            refrescarGrilla();
			txtId.Text = null;
			txtAgrMarca.Text = null;
        }
		private void ABMMarcas_Deactivate(object sender, EventArgs e)
		{
			//this.WindowState = FormWindowState.Minimized;
		}
		//metodos
        private void refrescarGrilla()
        {
            List<E_Marca> marcas;
            N_Marca NMarca = new N_Marca();

            marcas = NMarca.getAllMarcas(txtBscMarca.Text);
            if (marcas != null)
            {
                dgMarcas.AutoGenerateColumns = false;
                dgMarcas.DataSource = marcas;

            }
            else
            {
                MessageBox.Show("No se cargo la gillla");
            }

        }
		//Eventos   
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void picBuscar_Click(object sender, EventArgs e)
        {
            refrescarGrilla();
        }
		private void dgMarcas_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgMarcas.Rows.Count != 0)
			{
				if (e.ColumnIndex == ColDelete.Index)
				{
					
					Int32 idMarca = Convert.ToInt32(dgMarcas.CurrentRow.Cells[colId.Index].Value);
					N_Marca nMarca = new N_Marca();
					string xRet = nMarca.delete(idMarca);

					if (xRet != "0")
					{
						MessageBox.Show("La marca no se puede eliminar porque ah sido utilizada");
					}
					else
					{
						refrescarGrilla();
					}

				}
			}

		}
		private void btnGuardar_Click(object sender, EventArgs e)
		{
            if (txtAgrMarca.Text != "")
            {

                E_Marca marca = new E_Marca();
                marca.nombre = txtAgrMarca.Text;
                if (!string.IsNullOrEmpty(txtId.Text)) marca.idMarca = Convert.ToInt32(txtId.Text);
                N_Marca nMarca = new N_Marca();
                nMarca.guardar(marca);

                lblNvoMod.Text = "Nueva Marca";
                txtId.Text = null;
                txtAgrMarca.Text = null;
                refrescarGrilla();
            }
            else
            {
                MessageBox.Show("¡Los campos obligatorios deben estar completos (*)!", "Campos Incompletos", MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
            }
		}
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			txtAgrMarca.Text = null; //
			lblNvoMod.Text = "Nueva Marca:";
			txtAgrMarca.Focus();
			txtId.Text = null;
			
		}
		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (dgMarcas.Rows.Count != 0)
			{
				lblNvoMod.Text = "Modificar Marca";
				txtId.Text = dgMarcas.CurrentRow.Cells[colId.Index].Value.ToString();
				txtAgrMarca.Text = dgMarcas.CurrentRow.Cells[colNombre.Index].Value.ToString();
				txtAgrMarca.SelectAll();
			}
			else
			{
				MessageBox.Show("Debe seleccionar una marca");
			}
		}
		private void txtAgrMarca_TextChanged(object sender, EventArgs e)
		{

		}
		private void txtAgrMarca_Enter(object sender, EventArgs e)
		{
			txtAgrMarca.SelectAll();
		}
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            refrescarGrilla();
        }
		private void txtBscMarca_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				refrescarGrilla();
				e.SuppressKeyPress = true;
			}
			else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
			{
				dgMarcas.Focus();
			}
		}

		private void btnAyuda_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, Application.StartupPath + "\\AyudaPintureria.chm", HelpNavigator.KeywordIndex, "Marcas");
		}
		
	

       
    }
}

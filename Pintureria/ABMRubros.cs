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
    public partial class ABMRubros : Form
    {
		//Contructor
        public ABMRubros()
        {
            InitializeComponent();
        }
		//Eventos de formulario
        private void ABMRubros_Load(object sender, EventArgs e)
        {
            refrescarGrilla();
        }
		private void ABMRubros_Deactivate(object sender, EventArgs e)
		{
			this.WindowState = FormWindowState.Minimized;
		}
		//Metodos
        private void refrescarGrilla()
        {
            List<E_Rubro> rubros;
            N_Rubro nRubro = new N_Rubro();

            rubros = nRubro.getAllRubros(txtBscRubro.Text);
            if (rubros != null)
            {
                dgRubro.AutoGenerateColumns = false;
                dgRubro.DataSource = rubros;

            }
            else
            {
                MessageBox.Show("¡No se cargo la gilla!");
            }

        }
        //Eventos
        private void picBuscar_Click(object sender, EventArgs e)
        {
            refrescarGrilla();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtAgrRubro.Text != "")
            {
                string xRet;
                E_Rubro rubro = new E_Rubro();
                N_Rubro nRubro = new N_Rubro();
                rubro.nombre = txtAgrRubro.Text;
                if (txtId.Text != "") rubro.idRubro = Convert.ToInt64(txtId.Text);

                xRet = nRubro.guardar(rubro);

                if (xRet != "0")
                {
					MessageBox.Show("no se pudo agregar la rubro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("¡El rubro se agrego correctamente!","Operacion Exitosa",MessageBoxButtons.OK,MessageBoxIcon.Information);
                    txtAgrRubro.Text = "";
                }

                refrescarGrilla();
            }
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            
            //// si devuelve true es que los campos obligatorios estan completos
            // E_Rubro Rubro = new E_Rubro();
            //    //si el txt id esta vacio significa que es una cliente nuevo
            //    if (txtId.Text != "") Rubro.idRubro = Convert.ToInt64(txtId.Text);

            //    Rubro.nombre = txtAgrRubro.Text;
               

               

            //    N_Rubro nRubro = new N_Rubro();
            //    string xRet = nRubro.guardar(Rubro);
            //    if (xRet != "0")
            //    {
            //        MessageBox.Show("No se puedo agregar el rubro");
            //    }
            //    else
            //    {
            //        MessageBox.Show("¡El rubro se agrego correctamente!");
            //    }

            }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
		private void btnNuevo_Click(object sender, EventArgs e)
		{
			txtAgrRubro.Text = null; //
			lblNvoMod.Text = "Nueva Rubro:";
			txtAgrRubro.Focus();
			txtId.Text = null;
		}
		private void btnModificar_Click(object sender, EventArgs e)
		{
			if (dgRubro.Rows.Count != 0)
			{
				lblNvoMod.Text = "Modificar rubro";
				txtId.Text = dgRubro.CurrentRow.Cells[colId.Index].Value.ToString();
				txtAgrRubro.Text = dgRubro.CurrentRow.Cells[colNombre.Index].Value.ToString();
				txtAgrRubro.SelectAll();
			}
			else
			{
				MessageBox.Show("Debe seleccionar una rubro");
			}
		}

		private void btnGuardar_Click_1(object sender, EventArgs e)
		{
			if (txtAgrRubro.Text != "")
			{
				E_Rubro rubro = new E_Rubro();
				rubro.nombre = txtAgrRubro.Text;
				if (!string.IsNullOrEmpty(txtId.Text)) rubro.idRubro = Convert.ToInt32(txtId.Text);
				N_Rubro nRubro = new N_Rubro();
				nRubro.guardar(rubro);

				lblNvoMod.Text = "Nueva Rubro";
				txtId.Text = null;
				txtAgrRubro.Text = null;
				refrescarGrilla();
			}
		}

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            refrescarGrilla();
        }

		private void txtBscRubro_KeyPress(object sender, KeyPressEventArgs e)
		{
			if ((int)e.KeyChar == (int)Keys.Enter)
			{
				refrescarGrilla();
			}
		}

		private void txtBscRubro_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Enter)
			{
				refrescarGrilla();
				e.SuppressKeyPress = true;
			}
			else if (e.KeyCode == Keys.Down || e.KeyCode == Keys.Up)
			{
				dgRubro.Focus();
			}
		}

        private void dgRubro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgRubro.Rows.Count != 0)
            {
                if (e.ColumnIndex == colDelete.Index)
                {

                    Int32 idRubro = Convert.ToInt32(dgRubro.CurrentRow.Cells[colId.Index].Value);
                    N_Rubro nRubro = new N_Rubro();
                    string xRet = nRubro.delete(idRubro);

                    if (xRet != "0")
                    {
                        MessageBox.Show("El Rubro no se puede eliminar porque ha sido utilizado");
                    }
                    else
                    {
                        refrescarGrilla();
                    }

                }
            }
        }

		private void btnAyuda_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, Application.StartupPath + "\\AyudaPintureria.chm", HelpNavigator.KeywordIndex, "Rubros");
		}

		
		

        



       
    }
}

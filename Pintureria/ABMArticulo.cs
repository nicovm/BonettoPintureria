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
    public partial class ABMArticulo : Form
    {
		//contructor
        public ABMArticulo()
        {
            InitializeComponent();
            refrescarGrilla(-1);
        }
		//Evento de formulario
        private void ABMArticulo_Load(object sender, EventArgs e)
        {

        }
		private void ABMArticulo_Deactivate(object sender, EventArgs e)
		{
			//this.WindowState = FormWindowState.Minimized;
		}
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmArticulo frmArticulo = new frmArticulo(null);
            frmArticulo.ShowDialog();
			refrescarGrilla(-1);
        }
        private void dgArticulo_DoubleClick(object sender, System.EventArgs e)
        {
         string idArticulo = dgArticulo.CurrentRow.Cells[0].Value.ToString();
            consultarArticulo(idArticulo);

        }//obtener el id cliente
		//Metodos
        private void refrescarGrilla(Int16 idFiltro)
        {
            //id -1 = Filtro no lleva ninguna filtro
            //id 0 = Filtro por codigo de articulo
            //id 1 = Filtro por marca y descripcion de articulo

            N_Articulo nArticulo = new N_Articulo();

            dgArticulo.AutoGenerateColumns = false;
            List<E_Articulo> articulos;
            if (idFiltro == 0) //filtra por codigo
            {
               
                 articulos = nArticulo.getAllArticulosXcod(txtFiltroCod.Text);
            }
                else if (idFiltro == 1) // filtra por marca y descripcion
                {
                    articulos = nArticulo.getAllArticulos(txtFiltro.Text);
                }
                    else
                    {
                        articulos = nArticulo.getAllArticulos("");
                    }

            if (articulos != null)
            {
                dgArticulo.DataSource = articulos;
            }
            else
            {
                MessageBox.Show("no se cargo la grilla");
            }
        }
        private void consultarArticulo(string codArticulo)
        {
			N_Articulo nArticulo = new N_Articulo();
            frmArticulo frmArticulo = new frmArticulo(nArticulo.getOneArticulo(codArticulo));
            frmArticulo.ShowDialog();
            refrescarGrilla(-1);
        }
        //Eventos
        private void btnVaciarLista_Click(object sender, EventArgs e)
        {
            
            dgArticulo.DataSource = null;
            dgArticulo.Rows.Clear();
        }
        
        private void brnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dgArticulo_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
    
            string idArticulo = dgArticulo.CurrentRow.Cells[0].Value.ToString();
            consultarArticulo(idArticulo);
        }
        private void txtSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtFiltro_KeyDown(object sender, KeyEventArgs e)
        {
            //id=1
            if (e.KeyCode == Keys.Enter)
            {
                refrescarGrilla(1);
                e.SuppressKeyPress = true;
            }
			if (e.KeyCode == Keys.Down)
			{
				dgArticulo.Focus();
			}
        }
        private void txtFiltroCod_KeyDown(object sender, KeyEventArgs e)
        {
            //id=0
            if (e.KeyCode == Keys.Enter)
            {
                refrescarGrilla(0);
                e.SuppressKeyPress = true;
            }
        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBusCod_Click(object sender, EventArgs e)
        {

            refrescarGrilla(0);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            refrescarGrilla(1);
        }

		private void btnAyuda_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, Application.StartupPath + "\\AyudaPintureria.chm", HelpNavigator.KeywordIndex, "Articulos");
		}

		private void btnImportarLista_Click(object sender, EventArgs e)
		{
			frmTipoListaImportar frm = new frmTipoListaImportar();
			frm.Show();

		}

		
        

		


       

       

      

       
       
    }
}

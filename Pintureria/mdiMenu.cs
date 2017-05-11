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
    public partial class mdiMenu : Form
    {
		//Usuario en sesion
		public  E_Usuario _oUsuarioSesion = null;
		//Variable de estado
        private ABMClientes abmClientes = null;
        private ABMMarcas abmMarcas = null;
        private ABMVendedores abmVendedores = null;
        private ABMRubros abmRubros = null;
		private ABMArticulo abmArticulo = null;
		private frmVenta _frmVenta = null;
		private frmPedidos _frmPedidos = null;
		private ABMVenta _abmVenta = null;
		private ABMProveedor _abmProveedores = null;
		private ABMPedidos _abmPedidos =  null;
		private frmPerfil _frmPerfil = null;
		private Caja _frmCaja = null;
		private frmLocalidad _frmLocalidad = null;
        //instancias de formularios

        private ABMVendedores instanciaFrmVendedores
        {
            get
            {
                {
                    if (abmVendedores == null)
                    {
                        abmVendedores = new ABMVendedores();
                        //abmVendedores.MdiParent = this;
                        abmVendedores.Disposed += new EventHandler(abmVendedores_Disposed);
                    }

                    return abmVendedores;
                }
            }

        }
        private ABMClientes intanciaFrmCliente
        {
            get
            {
                if (abmClientes == null)
                {
                    abmClientes = new ABMClientes();
                   // abmClientes.MdiParent = this;
                    abmClientes.Disposed += new EventHandler(abmClientes_Disposed);
                }

                return abmClientes;
            }
        }
        private ABMMarcas instanciaFrmMarcas
        {
            get
            {
                if (abmMarcas == null)
                {
                    abmMarcas = new ABMMarcas();
                    //abmMarcas.MdiParent = this;
                    abmMarcas.Disposed += new EventHandler(abmMarcas_Disposed);
                }
                return abmMarcas;
            }
        }
        private ABMRubros instanciaFrmRubro
        {
            get
            {
                if (abmRubros == null)
                {
                    abmRubros = new ABMRubros();
                   // abmRubros.MdiParent = this;
                    abmRubros.Disposed += new EventHandler(abmRubros_Disposed);
                }
                return abmRubros;
            }
        }
        private ABMArticulo instanciaFrmArticulo
        {
            get
            {
                if (abmArticulo == null)
                {
                    abmArticulo = new ABMArticulo();
                    //abmArticulo.MdiParent = this;
                    abmArticulo.Disposed += new EventHandler(abmArticulo_Disposed);
                }
                return abmArticulo;
            }
        }
		private frmVenta instanciaFrmVenta
		{
			get
			{
				if (_frmVenta == null)
				{
					_frmVenta = new frmVenta();
					//abmArticulo.MdiParent = this;
					_frmVenta.Disposed += new EventHandler(frmVenta_Disposed);
				}
				return _frmVenta;
			}

		}
		private frmPedidos instanciaFrmCompra
		{
			get
			{
				if (_frmPedidos == null)
				{
					_frmPedidos = new frmPedidos();
					//abmArticulo.MdiParent = this;
					_frmPedidos.Disposed += new EventHandler(frmCompra_Disposed);
				}
				return _frmPedidos;
			}
		}
		private ABMVenta instanciaAbmVenta
		{
			get
			{
				if (_abmVenta == null)
				{
					_abmVenta = new ABMVenta();
					//abmArticulo.MdiParent = this;
					_abmVenta.Disposed += new EventHandler(abmVenta_Disposed);
				}
				return _abmVenta;
			}
		}
		private ABMProveedor instanciaAbmProveedores
		{
			get
			{
				if (_abmProveedores == null)
				{
					_abmProveedores = new ABMProveedor();
					//abmArticulo.MdiParent = this;
					_abmProveedores.Disposed += new EventHandler(abmProveedores_Disposed);
				}
				return _abmProveedores;
			}
		}
		private ABMPedidos instanciaAbmPedidos
		{
			get
			{
				if (_abmPedidos == null)
				{
					_abmPedidos = new ABMPedidos();
					//abmArticulo.MdiParent = this;
					_abmPedidos.Disposed += new EventHandler(abmPedidos_Disposed);
				}
				return _abmPedidos;
			}
		}
		private Caja instanciaFrmCaja
		{
			get
			{
				if (_frmCaja == null)
				{
					_frmCaja = new Caja();
					//abmArticulo.MdiParent = this;
					_frmCaja.Disposed += new EventHandler(frmCaja_Disposed);
				}
				return _frmCaja;
			}
		}
		private frmLocalidad instanciaFrmLocalidad
		{
			get
			{
				if (_frmLocalidad == null)
				{
					_frmLocalidad = new frmLocalidad();
					//abmArticulo.MdiParent = this;
					_frmLocalidad.Disposed += new EventHandler(frmLocalidad_Disposed);
				}
				return _frmLocalidad;
			}
		}
		private frmPerfil instanciaFrmPerfil
		{
			get
			{
				if (_frmPerfil == null)
				{
					_frmPerfil = new frmPerfil(_oUsuarioSesion);
					//abmArticulo.MdiParent = this;
					_frmPerfil.Disposed += new EventHandler(frmPerfil_Disposed);
				}
				return _frmPerfil;
			}
		}
        //evento de formularios
        void abmClientes_Disposed(object sender, EventArgs e)
        {
            abmClientes = null;
        }
        void abmMarcas_Disposed(object sender, EventArgs e)
        {
            abmMarcas = null;
        }
        void abmVendedores_Disposed(object sender, EventArgs e)
        {
            abmVendedores = null;
        }
        void abmRubros_Disposed(object sender, EventArgs e)
        {
            abmRubros = null;
        }
        void abmArticulo_Disposed(object sender, EventArgs e)
        {
            abmArticulo = null;
        }
		void frmVenta_Disposed(object sender, EventArgs e)
		{
			_frmVenta = null;
		}
		void frmCompra_Disposed(object sender, EventArgs e)
		{
			_frmPedidos = null;
		}
		void abmVenta_Disposed(object sender, EventArgs e)
		{
			_abmVenta = null;
		}
		void abmProveedores_Disposed(object sender, EventArgs e)
		{
			_abmProveedores = null;
		}
		void abmPedidos_Disposed(object sender, EventArgs e)
		{
			_abmPedidos = null;
		}
		void frmCaja_Disposed(object sender, EventArgs e)
		{
			_frmCaja = null;
		}
		void frmLocalidad_Disposed(object sender, EventArgs e)
		{
			_frmLocalidad = null;
		}
		void frmPerfil_Disposed(object sender, EventArgs e)
		{
			_frmPerfil = null;
		}
        //Contructor
        public mdiMenu(E_Usuario oUsuarioSsion)
        {
            InitializeComponent();
			_oUsuarioSesion = oUsuarioSsion;
            this.Text = N_VersionSisitema.GETVERSION();
            lblVersion.Text = N_VersionSisitema.GETVERSION();
			
        }
        //load
        private void mdiMenu_Load(object sender, EventArgs e)
        {
			if (abrirCajaDiaria())
			{
				frmCajaInicial frm = new frmCajaInicial();
				frm.ShowDialog();
			}
			//Actualiza la fecha y la hora inicial statusStrip del mdiMenu
			tssLblFecha.Text = DateTime.Now.Date.ToLongDateString();
			tssLblHora.Text = DateTime.Now.ToShortTimeString();

			//cargar nota
			cargarNota();

        }
		private void mdiMenu_FormClosing(object sender, FormClosingEventArgs e)
		{
			DialogResult respuesta = MessageBox.Show("¿Está Seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, System.Windows.Forms.MessageBoxIcon.Information);

			switch (respuesta)
			{
				case DialogResult.Yes:
					// this.Close();
					break;
				case DialogResult.No:
					e.Cancel = true;
					break;

			}
		}
		private void mdiMenu_KeyDown(object sender, KeyEventArgs e)
		{

			switch (e.KeyCode)
			{
				case Keys.F1:
					abrirFrmCiente();
					break;
				case Keys.F2:
					abrirFrmProveedores();
					break;
				case Keys.F3:
					abrirFrmPedido();
					break;
				case Keys.F4:
					abrirAbmPedido();
					break;
				case Keys.F5:
					abrirFrmVenta();
					break;
				case Keys.F6:
					abrirAbmVenta();
					break;
				case Keys.F7:
					abrirAbmArticulo();
					break;
				case Keys.F8:
					this.Close();
					break;

			}
		}
		//Metodos
		public Boolean abrirCajaDiaria()
		{
			N_Caja nCaja = new N_Caja();
			DateTime fecHoy = DateTime.Now.Date;
			
			Int16 count = nCaja.countCajaDiaria(fecHoy);
			if (count == 0) return true;
			return false;
		}

		private void abrirFrmCiente()
		{
			abmClientes = this.intanciaFrmCliente;
			if (abmClientes.WindowState == FormWindowState.Minimized)
				abmClientes.WindowState = FormWindowState.Normal;

			abmClientes.Show();
		}
		private void abrirFrmProveedores()
		{
			_abmProveedores = this.instanciaAbmProveedores;
			if (_abmProveedores.WindowState == FormWindowState.Minimized)
				_abmProveedores.WindowState = FormWindowState.Normal;
			_abmProveedores.Show();
		}
		private void abrirFrmVenta()
		{

			_frmVenta = this.instanciaFrmVenta;
			if (_frmVenta.WindowState == FormWindowState.Minimized)
				_frmVenta.WindowState = FormWindowState.Normal;
			_frmVenta.Show();
		}
		private void abrirFrmVendedores()
		{
			abmVendedores = this.instanciaFrmVendedores;
			if (abmVendedores.WindowState == FormWindowState.Minimized)
				abmVendedores.WindowState = FormWindowState.Normal;
			abmVendedores.Show();
		}
		private void abrirAbmArticulo()
		{
			abmArticulo = this.instanciaFrmArticulo;
			if (abmArticulo.WindowState == FormWindowState.Minimized)
				abmArticulo.WindowState = FormWindowState.Normal;
			abmArticulo.Show();
		}
		private void abrirAbmMarcas()
		{
			abmMarcas = this.instanciaFrmMarcas;
			if (abmMarcas.WindowState == FormWindowState.Minimized)
				abmMarcas.WindowState = FormWindowState.Normal;

			abmMarcas.Show();
		}
		private void abrirAbmRubro()
		{
			abmRubros = this.instanciaFrmRubro;
			if (abmRubros.WindowState == FormWindowState.Minimized)
				abmRubros.WindowState = FormWindowState.Normal;
			abmRubros.Show();
		}
		private void abrirFrmPedido()
		{
			_frmPedidos = this.instanciaFrmCompra;
			if (_frmPedidos.WindowState == FormWindowState.Minimized)
				_frmPedidos.WindowState = FormWindowState.Normal;
			_frmPedidos.Show();
		}
		private void abrirAbmVenta()
		{
			_abmVenta = this.instanciaAbmVenta;
			if (_abmVenta.WindowState == FormWindowState.Minimized)
				_abmVenta.WindowState = FormWindowState.Normal;
			_abmVenta.Show();
		}
		private void abrirAbmPedido()
		{
			_abmPedidos = this.instanciaAbmPedidos;
			if (_abmPedidos.WindowState == FormWindowState.Minimized)
				abmArticulo.WindowState = FormWindowState.Normal;
			_abmPedidos.Show();
		}
		private void abrirFrmPerfil()
		{
			_frmPerfil = this.instanciaFrmPerfil;
			if (_frmPerfil.WindowState == FormWindowState.Minimized)
				_frmPerfil.WindowState = FormWindowState.Normal;
			_frmPerfil.Show();
		}
        //click en el menu de formulario
		private void clientesToolStripMenuItem_Click(object sender, EventArgs e) { abrirFrmCiente(); }
		private void vendedoresToolStripMenuItem_Click(object sender, EventArgs e) { abrirFrmVendedores(); }
        private void articulosToolStripMenuItem_Click(object sender, EventArgs e){ abrirAbmArticulo();}
        private void salirToolStripMenuItem_Click(object sender, EventArgs e){ this.Close(); }
		private void marcasToolStripMenuItem1_Click(object sender, EventArgs e) { abrirAbmMarcas(); }
        private void rubrosToolStripMenuItem1_Click(object sender, EventArgs e){ abrirAbmRubro();}
		private void toolStripMenuItem1_Click(object sender, EventArgs e){abrirFrmVenta();}
		private void perfilToolStripMenuItem_Click(object sender, EventArgs e)
		{
			abrirFrmPerfil();
		}
		//click botones de acceso directo
        private void btnProveedor_Click(object sender, EventArgs e){abrirFrmProveedores();}
		private void btnVenta_Click(object sender, EventArgs e) { abrirFrmVenta(); }
		private void btnPedido_Click(object sender, EventArgs e){abrirFrmPedido();}
		private void consultarVentaToolStripMenuItem_Click(object sender, EventArgs e){abrirAbmVenta();}
		private void nuevaCompraToolStripMenuItem_Click(object sender, EventArgs e){abrirFrmPedido();}
		private void btnArticulo_Click(object sender, EventArgs e){abrirAbmArticulo();}
		private void consultarCompraToolStripMenuItem_Click(object sender, EventArgs e) { abrirAbmPedido(); }
		private void cajaToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			_frmCaja = this.instanciaFrmCaja;
			if (_frmCaja.WindowState == FormWindowState.Minimized)
				_frmCaja.WindowState = FormWindowState.Normal;
			_frmCaja.Show();
		}
		private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			_frmLocalidad = this.instanciaFrmLocalidad;
			if (_frmLocalidad.WindowState == FormWindowState.Minimized)
				_frmLocalidad.WindowState = FormWindowState.Normal;
			_frmLocalidad.Show();
		}
		private void btnConsultarVentas_Click(object sender, EventArgs e)
		{
			_abmVenta = this.instanciaAbmVenta;
			if (_abmVenta.WindowState == FormWindowState.Minimized)
				_abmVenta.WindowState = FormWindowState.Normal;
			_abmVenta.Show();
		}
        private void btnConsultarPed_Click(object sender, EventArgs e)
        {
            ABMPedidos form = new ABMPedidos();
            form.ShowDialog();
        }
		private void btnCliente_Click(object sender, EventArgs e)
		{
				abrirFrmCiente();
		}
		private void btnSalir_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
		{
			abrirFrmProveedores();
		}
        //TIMER
		private void timerPintureria_Tick(object sender, EventArgs e)
		{
			tssLblHora.Text = DateTime.Now.ToShortTimeString();
		}
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            txtNotas.Text = "";
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            txtNotas.BackColor = Color.FromArgb(255, 255, 192);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            txtNotas.BackColor = Color.FromArgb(255, 192, 128);
        }
        private void pictureBox10_Click(object sender, EventArgs e)
        {
            txtNotas.BackColor = Color.FromArgb(192, 255, 192);
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            txtNotas.BackColor = Color.FromArgb(128, 255, 128); 
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            txtNotas.BackColor = Color.FromArgb(255, 192, 192); 
        }
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            txtNotas.BackColor = Color.FromArgb(255, 128, 128);  
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            txtNotas.BackColor = Color.FromArgb(192, 192, 255);  
        }
        private void pictureBox11_Click(object sender, EventArgs e)
        {
            txtNotas.BackColor = Color.FromArgb(128, 128, 255);
        }
        
        
        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtNotas.Text = "";
        }

		//
        private void nota()
        {
            InitializeComponent();

        

        }
        
		private void btnGuardar_Click(object sender, EventArgs e)
		{
			N_Notas nNotas = new N_Notas();

			Boolean xRet = nNotas.guardarNota(DateTime.Now, txtNotas.Text);

			if (xRet == true)
			{
				MessageBox.Show("¡Nota Guardada con exito!","Confirmacion", MessageBoxButtons.OK,MessageBoxIcon.Information) ;
			}
			else
			{
				MessageBox.Show("No se puedo guardar la nota","Error", MessageBoxButtons.OK,MessageBoxIcon.Error) ;
			}
		}

		private void cargarNota()
		{
			N_Notas nNotas = new N_Notas();

			string descripcion = nNotas.getNotas();

			txtNotas.Text = descripcion;

		}

        private void btnFuente_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNotas.Font = fontDialog1.Font;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                txtNotas.ForeColor = colorDialog1.Color;
            }
        }

        private void cajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCajaInicial form = new frmCajaInicial();
            form.ShowDialog();
        }

		private void btnAyuda_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, Application.StartupPath + "\\AyudaPintureria.chm", HelpNavigator.KeywordIndex, "Menu");
		}

		private void ayudaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Help.ShowHelp(this, Application.StartupPath + "\\AyudaPintureria.chm", HelpNavigator.KeywordIndex, "Menu");
		}

        private void btnNotaCredito_Click(object sender, EventArgs e)
        {
            ABMNotaCredito frm = new ABMNotaCredito();
            frm.Show();
        }

        private void btnCuentaCorriente_Click(object sender, EventArgs e)
        {
            ABMClientes frmClienteCuentaCorriente = new ABMClientes(true);
            frmClienteCuentaCorriente.Show();
        }

        

		
    }
}

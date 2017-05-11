namespace Pintureria
{
	partial class frmPedidos
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPedidos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtUltVenta = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.grpCabeceraCompra = new System.Windows.Forms.GroupBox();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtObservacion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboCondPago = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCuitDni = new System.Windows.Forms.TextBox();
            this.lblCuit = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdProveedor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtFecVenta = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboVendedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCodPedido = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblInfoAnular = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.txtCantArticulo = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnAgrArticulo = new System.Windows.Forms.Button();
            this.dgDetalle = new System.Windows.Forms.DataGridView();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGenerarPedido = new System.Windows.Forms.Button();
            this.lblVentas = new System.Windows.Forms.Label();
            this.colCodArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpCabeceraCompra.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUltVenta
            // 
            this.txtUltVenta.Enabled = false;
            this.txtUltVenta.Location = new System.Drawing.Point(98, 105);
            this.txtUltVenta.Name = "txtUltVenta";
            this.txtUltVenta.Size = new System.Drawing.Size(87, 20);
            this.txtUltVenta.TabIndex = 69;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(89, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(106, 16);
            this.label16.TabIndex = 70;
            this.label16.Text = "Ultimo Pedido";
            // 
            // grpCabeceraCompra
            // 
            this.grpCabeceraCompra.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.grpCabeceraCompra.Controls.Add(this.btnAyuda);
            this.grpCabeceraCompra.Controls.Add(this.btnBuscar);
            this.grpCabeceraCompra.Controls.Add(this.txtObservacion);
            this.grpCabeceraCompra.Controls.Add(this.label11);
            this.grpCabeceraCompra.Controls.Add(this.cboCondPago);
            this.grpCabeceraCompra.Controls.Add(this.label9);
            this.grpCabeceraCompra.Controls.Add(this.txtCuitDni);
            this.grpCabeceraCompra.Controls.Add(this.lblCuit);
            this.grpCabeceraCompra.Controls.Add(this.txtDireccion);
            this.grpCabeceraCompra.Controls.Add(this.label7);
            this.grpCabeceraCompra.Controls.Add(this.txtDescripcion);
            this.grpCabeceraCompra.Controls.Add(this.label6);
            this.grpCabeceraCompra.Controls.Add(this.txtIdProveedor);
            this.grpCabeceraCompra.Controls.Add(this.label5);
            this.grpCabeceraCompra.Controls.Add(this.dtFecVenta);
            this.grpCabeceraCompra.Controls.Add(this.label4);
            this.grpCabeceraCompra.Controls.Add(this.label3);
            this.grpCabeceraCompra.Controls.Add(this.cboVendedor);
            this.grpCabeceraCompra.Controls.Add(this.label2);
            this.grpCabeceraCompra.Controls.Add(this.txtCodPedido);
            this.grpCabeceraCompra.Controls.Add(this.lbl);
            this.grpCabeceraCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpCabeceraCompra.Location = new System.Drawing.Point(292, 12);
            this.grpCabeceraCompra.Name = "grpCabeceraCompra";
            this.grpCabeceraCompra.Size = new System.Drawing.Size(879, 158);
            this.grpCabeceraCompra.TabIndex = 67;
            this.grpCabeceraCompra.TabStop = false;
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = global::Pintureria.Properties.Resources.Ayuda;
            this.btnAyuda.Location = new System.Drawing.Point(817, 68);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(35, 30);
            this.btnAyuda.TabIndex = 96;
            this.btnAyuda.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.White;
            this.btnBuscar.BackgroundImage = global::Pintureria.Properties.Resources.Lupa;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(203, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 25);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.Location = new System.Drawing.Point(136, 98);
            this.txtObservacion.MaxLength = 300;
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(716, 54);
            this.txtObservacion.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(14, 98);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(117, 16);
            this.label11.TabIndex = 48;
            this.label11.Text = "Observaciones:";
            // 
            // cboCondPago
            // 
            this.cboCondPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCondPago.FormattingEnabled = true;
            this.cboCondPago.Location = new System.Drawing.Point(378, 69);
            this.cboCondPago.Name = "cboCondPago";
            this.cboCondPago.Size = new System.Drawing.Size(121, 21);
            this.cboCondPago.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(291, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 16);
            this.label9.TabIndex = 43;
            this.label9.Text = "CondPago:";
            // 
            // txtCuitDni
            // 
            this.txtCuitDni.Location = new System.Drawing.Point(136, 70);
            this.txtCuitDni.Name = "txtCuitDni";
            this.txtCuitDni.Size = new System.Drawing.Size(136, 20);
            this.txtCuitDni.TabIndex = 7;
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCuit.Location = new System.Drawing.Point(82, 69);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(47, 16);
            this.lblCuit.TabIndex = 41;
            this.lblCuit.Text = "CUIT:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(652, 45);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(200, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(572, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 16);
            this.label7.TabIndex = 39;
            this.label7.Text = "Dirección:";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(378, 43);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(156, 20);
            this.txtDescripcion.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(281, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 16);
            this.label6.TabIndex = 37;
            this.label6.Text = "Descripción:";
            // 
            // txtIdProveedor
            // 
            this.txtIdProveedor.Location = new System.Drawing.Point(136, 42);
            this.txtIdProveedor.Name = "txtIdProveedor";
            this.txtIdProveedor.Size = new System.Drawing.Size(61, 20);
            this.txtIdProveedor.TabIndex = 3;
            this.txtIdProveedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeros_KeyPress);
            this.txtIdProveedor.Leave += new System.EventHandler(this.txtIdProveedor_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 16);
            this.label5.TabIndex = 35;
            this.label5.Text = "CodProveedor:";
            // 
            // dtFecVenta
            // 
            this.dtFecVenta.Location = new System.Drawing.Point(652, 22);
            this.dtFecVenta.Name = "dtFecVenta";
            this.dtFecVenta.Size = new System.Drawing.Size(200, 20);
            this.dtFecVenta.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(592, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 16);
            this.label4.TabIndex = 32;
            this.label4.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(412, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 31;
            // 
            // cboVendedor
            // 
            this.cboVendedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVendedor.FormattingEnabled = true;
            this.cboVendedor.Location = new System.Drawing.Point(378, 17);
            this.cboVendedor.Name = "cboVendedor";
            this.cboVendedor.Size = new System.Drawing.Size(121, 21);
            this.cboVendedor.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(291, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Vendedor:";
            // 
            // txtCodPedido
            // 
            this.txtCodPedido.Enabled = false;
            this.txtCodPedido.Location = new System.Drawing.Point(136, 16);
            this.txtCodPedido.Name = "txtCodPedido";
            this.txtCodPedido.Size = new System.Drawing.Size(61, 20);
            this.txtCodPedido.TabIndex = 27;
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(36, 16);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(90, 16);
            this.lbl.TabIndex = 28;
            this.lbl.Text = "CodPedido:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.btnImprimir);
            this.groupBox1.Controls.Add(this.btnSalir);
            this.groupBox1.Controls.Add(this.lblInfoAnular);
            this.groupBox1.Controls.Add(this.btnAnular);
            this.groupBox1.Controls.Add(this.btnConfirmar);
            this.groupBox1.Controls.Add(this.txtCantArticulo);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnAgrArticulo);
            this.groupBox1.Controls.Add(this.dgDetalle);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGenerarPedido);
            this.groupBox1.Location = new System.Drawing.Point(12, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1159, 444);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnImprimir.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Image = global::Pintureria.Properties.Resources.imp1;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(32, 374);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(109, 42);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "&Imprimir";
            this.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.BackgroundImage = global::Pintureria.Properties.Resources.exit;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.ForeColor = System.Drawing.Color.Black;
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalir.Location = new System.Drawing.Point(1068, 374);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 52);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblInfoAnular
            // 
            this.lblInfoAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoAnular.ForeColor = System.Drawing.Color.Red;
            this.lblInfoAnular.Location = new System.Drawing.Point(318, 20);
            this.lblInfoAnular.Name = "lblInfoAnular";
            this.lblInfoAnular.Size = new System.Drawing.Size(612, 24);
            this.lblInfoAnular.TabIndex = 95;
            this.lblInfoAnular.Text = "ESTE PEDIDO HA SIDO ANULADO";
            this.lblInfoAnular.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInfoAnular.Visible = false;
            this.lblInfoAnular.Click += new System.EventHandler(this.lblInfoAnular_Click);
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.Red;
            this.btnAnular.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAnular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnAnular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.Color.White;
            this.btnAnular.Image = global::Pintureria.Properties.Resources.error;
            this.btnAnular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnular.Location = new System.Drawing.Point(644, 374);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(141, 42);
            this.btnAnular.TabIndex = 14;
            this.btnAnular.Text = "&Anular Pedido";
            this.btnAnular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Visible = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConfirmar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnConfirmar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnConfirmar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmar.ForeColor = System.Drawing.Color.White;
            this.btnConfirmar.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmar.Image")));
            this.btnConfirmar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConfirmar.Location = new System.Drawing.Point(481, 374);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(155, 42);
            this.btnConfirmar.TabIndex = 13;
            this.btnConfirmar.Text = "&Confirmar Pedido";
            this.btnConfirmar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnConfirmar.UseVisualStyleBackColor = false;
            this.btnConfirmar.Visible = false;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // txtCantArticulo
            // 
            this.txtCantArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantArticulo.Location = new System.Drawing.Point(193, 338);
            this.txtCantArticulo.Name = "txtCantArticulo";
            this.txtCantArticulo.ReadOnly = true;
            this.txtCantArticulo.Size = new System.Drawing.Size(87, 20);
            this.txtCantArticulo.TabIndex = 92;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(29, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(162, 16);
            this.label12.TabIndex = 82;
            this.label12.Text = "Cantidad De Artículos:";
            // 
            // btnAgrArticulo
            // 
            this.btnAgrArticulo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgrArticulo.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAgrArticulo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAgrArticulo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgrArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgrArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgrArticulo.ForeColor = System.Drawing.Color.White;
            this.btnAgrArticulo.Location = new System.Drawing.Point(32, 19);
            this.btnAgrArticulo.Name = "btnAgrArticulo";
            this.btnAgrArticulo.Size = new System.Drawing.Size(125, 30);
            this.btnAgrArticulo.TabIndex = 10;
            this.btnAgrArticulo.Text = "&Agregar Artículo";
            this.btnAgrArticulo.UseVisualStyleBackColor = false;
            this.btnAgrArticulo.Click += new System.EventHandler(this.btnAgrArticulo_Click);
            // 
            // dgDetalle
            // 
            this.dgDetalle.AllowUserToAddRows = false;
            this.dgDetalle.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodArticulo,
            this.colDescripcion,
            this.colObservacion,
            this.colCantidad,
            this.colEliminar,
            this.colStock});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgDetalle.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgDetalle.Location = new System.Drawing.Point(32, 55);
            this.dgDetalle.Name = "dgDetalle";
            this.dgDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDetalle.Size = new System.Drawing.Size(1100, 278);
            this.dgDetalle.TabIndex = 11;
            this.dgDetalle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetalle_CellClick);
            this.dgDetalle.CellValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDetalle_CellValidated);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Image = global::Pintureria.Properties.Resources._1409140349_delete_32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(643, 374);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 43);
            this.btnCancelar.TabIndex = 84;
            this.btnCancelar.Text = "&Cancelar Pedido";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGenerarPedido
            // 
            this.btnGenerarPedido.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerarPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnGenerarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnGenerarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerarPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarPedido.ForeColor = System.Drawing.Color.White;
            this.btnGenerarPedido.Image = global::Pintureria.Properties.Resources._1409140104_tick_32;
            this.btnGenerarPedido.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGenerarPedido.Location = new System.Drawing.Point(495, 374);
            this.btnGenerarPedido.Name = "btnGenerarPedido";
            this.btnGenerarPedido.Size = new System.Drawing.Size(142, 43);
            this.btnGenerarPedido.TabIndex = 83;
            this.btnGenerarPedido.Text = "&Generar Pedido";
            this.btnGenerarPedido.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGenerarPedido.UseVisualStyleBackColor = false;
            this.btnGenerarPedido.Click += new System.EventHandler(this.btnConfPedido_Click);
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentas.ForeColor = System.Drawing.Color.Red;
            this.lblVentas.Location = new System.Drawing.Point(72, 30);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(152, 33);
            this.lblVentas.TabIndex = 85;
            this.lblVentas.Text = "PEDIDOS";
            // 
            // colCodArticulo
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCodArticulo.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCodArticulo.HeaderText = "Código";
            this.colCodArticulo.Name = "colCodArticulo";
            this.colCodArticulo.ReadOnly = true;
            this.colCodArticulo.Width = 140;
            // 
            // colDescripcion
            // 
            this.colDescripcion.HeaderText = "Descripción";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 310;
            // 
            // colObservacion
            // 
            this.colObservacion.HeaderText = "Observación";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.ReadOnly = true;
            this.colObservacion.Width = 300;
            // 
            // colCantidad
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle3;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            // 
            // colEliminar
            // 
            this.colEliminar.HeaderText = "Eliminar";
            this.colEliminar.Name = "colEliminar";
            // 
            // colStock
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colStock.DefaultCellStyle = dataGridViewCellStyle4;
            this.colStock.HeaderText = "Stock Actual";
            this.colStock.Name = "colStock";
            // 
            // frmPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(1183, 632);
            this.Controls.Add(this.lblVentas);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtUltVenta);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.grpCabeceraCompra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmPedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedido";
            this.Deactivate += new System.EventHandler(this.frmCompra_Deactivate);
            this.Load += new System.EventHandler(this.frmCompra_Load);
            this.grpCabeceraCompra.ResumeLayout(false);
            this.grpCabeceraCompra.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.TextBox txtUltVenta;
        private System.Windows.Forms.Label label16;
		private System.Windows.Forms.GroupBox grpCabeceraCompra;
		private System.Windows.Forms.TextBox txtObservacion;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.ComboBox cboCondPago;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtCuitDni;
		private System.Windows.Forms.Label lblCuit;
		private System.Windows.Forms.TextBox txtDireccion;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtIdProveedor;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.DateTimePicker dtFecVenta;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox cboVendedor;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCodPedido;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtCantArticulo;
        private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Button btnAgrArticulo;
		private System.Windows.Forms.DataGridView dgDetalle;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGenerarPedido;
        private System.Windows.Forms.Label lblVentas;
		private System.Windows.Forms.Button btnAnular;
		private System.Windows.Forms.Button btnConfirmar;
		private System.Windows.Forms.Label lblInfoAnular;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnImprimir;
		private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewButtonColumn colEliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
	}
}
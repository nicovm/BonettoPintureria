namespace Pintureria
{
	partial class frmImportarLista
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmImportarLista));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btnImportarLista = new System.Windows.Forms.Button();
			this.btnConfirmarImportacion = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ssLblInformacion = new System.Windows.Forms.ToolStripStatusLabel();
			this.label14 = new System.Windows.Forms.Label();
			this.txtIva = new System.Windows.Forms.TextBox();
			this.lvlIva = new System.Windows.Forms.Label();
			this.txtGanancia = new System.Windows.Forms.TextBox();
			this.txtPorDesRec = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.btnAgrDescRec = new System.Windows.Forms.Button();
			this.txtDescDescRec = new System.Windows.Forms.TextBox();
			this.cboDescRec = new System.Windows.Forms.ComboBox();
			this.btnEliminarCol = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtRegistros = new System.Windows.Forms.TextBox();
			this.picImportar = new System.Windows.Forms.PictureBox();
			this.lblImportarDatos = new System.Windows.Forms.Label();
			this.tLoanding = new System.Windows.Forms.Timer(this.components);
			this.dgImportar = new System.Windows.Forms.DataGridView();
			this.colCodArticulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colPrecioLista = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colSiniva = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colConIva = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btnSalir = new System.Windows.Forms.Button();
			this.picVisto = new System.Windows.Forms.PictureBox();
			this.lblMensaje = new System.Windows.Forms.Label();
			this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
			this.label2 = new System.Windows.Forms.Label();
			this.txtCodigoCol = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombreCol = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.txtPrecioListaCol = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.ep = new System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.txtEnvase = new System.Windows.Forms.TextBox();
			this.btnBorrar = new System.Windows.Forms.Button();
			this.lblMarca = new System.Windows.Forms.Label();
			this.statusStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.picImportar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgImportar)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.picVisto)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// btnImportarLista
			// 
			this.btnImportarLista.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnImportarLista.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnImportarLista.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnImportarLista.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnImportarLista.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnImportarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnImportarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnImportarLista.ForeColor = System.Drawing.Color.White;
			this.btnImportarLista.Image = global::Pintureria.Properties.Resources._1409136661_055;
			this.btnImportarLista.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btnImportarLista.Location = new System.Drawing.Point(494, 511);
			this.btnImportarLista.Name = "btnImportarLista";
			this.btnImportarLista.Size = new System.Drawing.Size(136, 40);
			this.btnImportarLista.TabIndex = 12;
			this.btnImportarLista.Text = "&Importar Lista";
			this.btnImportarLista.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnImportarLista.UseVisualStyleBackColor = false;
			this.btnImportarLista.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnConfirmarImportacion
			// 
			this.btnConfirmarImportacion.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnConfirmarImportacion.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnConfirmarImportacion.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnConfirmarImportacion.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnConfirmarImportacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnConfirmarImportacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnConfirmarImportacion.ForeColor = System.Drawing.Color.White;
			this.btnConfirmarImportacion.Image = ((System.Drawing.Image)(resources.GetObject("btnConfirmarImportacion.Image")));
			this.btnConfirmarImportacion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnConfirmarImportacion.Location = new System.Drawing.Point(649, 511);
			this.btnConfirmarImportacion.Name = "btnConfirmarImportacion";
			this.btnConfirmarImportacion.Size = new System.Drawing.Size(182, 40);
			this.btnConfirmarImportacion.TabIndex = 90;
			this.btnConfirmarImportacion.Text = "&Confirmar Importación";
			this.btnConfirmarImportacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnConfirmarImportacion.UseVisualStyleBackColor = false;
			this.btnConfirmarImportacion.Click += new System.EventHandler(this.btnConfirmarImportacion_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ssLblInformacion});
			this.statusStrip1.Location = new System.Drawing.Point(0, 562);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1225, 22);
			this.statusStrip1.TabIndex = 91;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// ssLblInformacion
			// 
			this.ssLblInformacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ssLblInformacion.Name = "ssLblInformacion";
			this.ssLblInformacion.Size = new System.Drawing.Size(78, 17);
			this.ssLblInformacion.Text = "Información:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(22, 17);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(95, 16);
			this.label14.TabIndex = 110;
			this.label14.Text = "Ganancia% :";
			// 
			// txtIva
			// 
			this.txtIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtIva.Location = new System.Drawing.Point(245, 14);
			this.txtIva.Name = "txtIva";
			this.txtIva.Size = new System.Drawing.Size(50, 22);
			this.txtIva.TabIndex = 108;
			this.txtIva.TabStop = false;
			this.txtIva.Text = "21";
			this.txtIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtIva.Leave += new System.EventHandler(this.txtIva_Leave);
			// 
			// lvlIva
			// 
			this.lvlIva.AutoSize = true;
			this.lvlIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lvlIva.Location = new System.Drawing.Point(203, 17);
			this.lvlIva.Name = "lvlIva";
			this.lvlIva.Size = new System.Drawing.Size(36, 16);
			this.lvlIva.TabIndex = 109;
			this.lvlIva.Text = "IVA:";
			// 
			// txtGanancia
			// 
			this.txtGanancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtGanancia.Location = new System.Drawing.Point(123, 14);
			this.txtGanancia.Name = "txtGanancia";
			this.txtGanancia.Size = new System.Drawing.Size(50, 22);
			this.txtGanancia.TabIndex = 107;
			this.txtGanancia.TabStop = false;
			this.txtGanancia.Text = "62";
			this.txtGanancia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.txtGanancia.Leave += new System.EventHandler(this.txtGanancia_Leave);
			// 
			// txtPorDesRec
			// 
			this.txtPorDesRec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPorDesRec.Location = new System.Drawing.Point(601, 14);
			this.txtPorDesRec.Name = "txtPorDesRec";
			this.txtPorDesRec.Size = new System.Drawing.Size(50, 22);
			this.txtPorDesRec.TabIndex = 112;
			this.txtPorDesRec.TabStop = false;
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.BackColor = System.Drawing.Color.Transparent;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.ForeColor = System.Drawing.Color.White;
			this.label15.Location = new System.Drawing.Point(574, 17);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(21, 16);
			this.label15.TabIndex = 115;
			this.label15.Text = "%";
			// 
			// btnAgrDescRec
			// 
			this.btnAgrDescRec.BackColor = System.Drawing.Color.Transparent;
			this.btnAgrDescRec.BackgroundImage = global::Pintureria.Properties.Resources.mas1;
			this.btnAgrDescRec.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAgrDescRec.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnAgrDescRec.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnAgrDescRec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAgrDescRec.Location = new System.Drawing.Point(656, 12);
			this.btnAgrDescRec.Name = "btnAgrDescRec";
			this.btnAgrDescRec.Size = new System.Drawing.Size(33, 27);
			this.btnAgrDescRec.TabIndex = 113;
			this.btnAgrDescRec.TabStop = false;
			this.btnAgrDescRec.UseVisualStyleBackColor = false;
			this.btnAgrDescRec.Click += new System.EventHandler(this.btnAgrDescRec_Click);
			// 
			// txtDescDescRec
			// 
			this.txtDescDescRec.Location = new System.Drawing.Point(428, 15);
			this.txtDescDescRec.MaxLength = 20;
			this.txtDescDescRec.Name = "txtDescDescRec";
			this.txtDescDescRec.Size = new System.Drawing.Size(143, 20);
			this.txtDescDescRec.TabIndex = 111;
			// 
			// cboDescRec
			// 
			this.cboDescRec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDescRec.FormattingEnabled = true;
			this.cboDescRec.Items.AddRange(new object[] {
            "DESCUENTO",
            "RECARGO"});
			this.cboDescRec.Location = new System.Drawing.Point(301, 15);
			this.cboDescRec.Name = "cboDescRec";
			this.cboDescRec.Size = new System.Drawing.Size(121, 21);
			this.cboDescRec.TabIndex = 114;
			// 
			// btnEliminarCol
			// 
			this.btnEliminarCol.BackColor = System.Drawing.Color.Transparent;
			this.btnEliminarCol.BackgroundImage = global::Pintureria.Properties.Resources.deshacer1;
			this.btnEliminarCol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEliminarCol.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnEliminarCol.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnEliminarCol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEliminarCol.Location = new System.Drawing.Point(693, 12);
			this.btnEliminarCol.Name = "btnEliminarCol";
			this.btnEliminarCol.Size = new System.Drawing.Size(33, 27);
			this.btnEliminarCol.TabIndex = 116;
			this.btnEliminarCol.UseVisualStyleBackColor = false;
			this.btnEliminarCol.Click += new System.EventHandler(this.btnEliminarCol_Click_1);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(6, 507);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(91, 20);
			this.label1.TabIndex = 117;
			this.label1.Text = "Registros:";
			// 
			// txtRegistros
			// 
			this.txtRegistros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txtRegistros.Location = new System.Drawing.Point(103, 507);
			this.txtRegistros.Name = "txtRegistros";
			this.txtRegistros.Size = new System.Drawing.Size(90, 20);
			this.txtRegistros.TabIndex = 118;
			this.txtRegistros.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// picImportar
			// 
			this.picImportar.BackColor = System.Drawing.Color.Transparent;
			this.picImportar.Image = global::Pintureria.Properties.Resources.Animation;
			this.picImportar.Location = new System.Drawing.Point(904, 12);
			this.picImportar.Name = "picImportar";
			this.picImportar.Size = new System.Drawing.Size(48, 48);
			this.picImportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picImportar.TabIndex = 120;
			this.picImportar.TabStop = false;
			this.picImportar.Visible = false;
			// 
			// lblImportarDatos
			// 
			this.lblImportarDatos.AutoSize = true;
			this.lblImportarDatos.BackColor = System.Drawing.Color.Transparent;
			this.lblImportarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblImportarDatos.ForeColor = System.Drawing.Color.White;
			this.lblImportarDatos.Location = new System.Drawing.Point(958, 20);
			this.lblImportarDatos.Name = "lblImportarDatos";
			this.lblImportarDatos.Size = new System.Drawing.Size(222, 24);
			this.lblImportarDatos.TabIndex = 119;
			this.lblImportarDatos.Text = "Importando los datos...";
			this.lblImportarDatos.Visible = false;
			// 
			// dgImportar
			// 
			this.dgImportar.AllowUserToAddRows = false;
			this.dgImportar.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
			dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgImportar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
			this.dgImportar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgImportar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodArticulo,
            this.colDetalle,
            this.colPrecioLista,
            this.colSiniva,
            this.colConIva});
			this.dgImportar.Location = new System.Drawing.Point(0, 133);
			this.dgImportar.Name = "dgImportar";
			this.dgImportar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgImportar.Size = new System.Drawing.Size(1201, 369);
			this.dgImportar.TabIndex = 89;
			// 
			// colCodArticulo
			// 
			dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.colCodArticulo.DefaultCellStyle = dataGridViewCellStyle7;
			this.colCodArticulo.HeaderText = "Codigo";
			this.colCodArticulo.Name = "colCodArticulo";
			this.colCodArticulo.ReadOnly = true;
			// 
			// colDetalle
			// 
			this.colDetalle.HeaderText = "Nombre";
			this.colDetalle.Name = "colDetalle";
			this.colDetalle.ReadOnly = true;
			this.colDetalle.Width = 400;
			// 
			// colPrecioLista
			// 
			dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.colPrecioLista.DefaultCellStyle = dataGridViewCellStyle8;
			this.colPrecioLista.HeaderText = "PrecioLista";
			this.colPrecioLista.Name = "colPrecioLista";
			this.colPrecioLista.ReadOnly = true;
			this.colPrecioLista.Width = 150;
			// 
			// colSiniva
			// 
			dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.colSiniva.DefaultCellStyle = dataGridViewCellStyle9;
			this.colSiniva.HeaderText = "S/IVA";
			this.colSiniva.Name = "colSiniva";
			// 
			// colConIva
			// 
			dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
			this.colConIva.DefaultCellStyle = dataGridViewCellStyle10;
			this.colConIva.HeaderText = "C/IVA";
			this.colConIva.Name = "colConIva";
			// 
			// btnSalir
			// 
			this.btnSalir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnSalir.BackgroundImage = global::Pintureria.Properties.Resources.exit;
			this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnSalir.FlatAppearance.BorderColor = System.Drawing.Color.White;
			this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.RoyalBlue;
			this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSalir.ForeColor = System.Drawing.Color.Black;
			this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.btnSalir.Location = new System.Drawing.Point(1137, 505);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(64, 52);
			this.btnSalir.TabIndex = 121;
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// picVisto
			// 
			this.picVisto.BackColor = System.Drawing.Color.Transparent;
			this.picVisto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picVisto.BackgroundImage")));
			this.picVisto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.picVisto.Location = new System.Drawing.Point(203, 508);
			this.picVisto.Name = "picVisto";
			this.picVisto.Size = new System.Drawing.Size(23, 19);
			this.picVisto.TabIndex = 122;
			this.picVisto.TabStop = false;
			this.picVisto.Visible = false;
			// 
			// lblMensaje
			// 
			this.lblMensaje.BackColor = System.Drawing.Color.Transparent;
			this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMensaje.ForeColor = System.Drawing.Color.White;
			this.lblMensaje.Location = new System.Drawing.Point(231, 506);
			this.lblMensaje.Name = "lblMensaje";
			this.lblMensaje.Size = new System.Drawing.Size(137, 23);
			this.lblMensaje.TabIndex = 123;
			this.lblMensaje.Text = "Lista importada";
			this.lblMensaje.Visible = false;
			// 
			// backgroundWorker
			// 
			this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
			this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(45, 40);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 16);
			this.label2.TabIndex = 124;
			this.label2.Text = "Codigo:";
			// 
			// txtCodigoCol
			// 
			this.txtCodigoCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtCodigoCol.Location = new System.Drawing.Point(113, 37);
			this.txtCodigoCol.MaxLength = 20;
			this.txtCodigoCol.Name = "txtCodigoCol";
			this.txtCodigoCol.Size = new System.Drawing.Size(65, 22);
			this.txtCodigoCol.TabIndex = 125;
			this.txtCodigoCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.White;
			this.label3.Location = new System.Drawing.Point(110, 18);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(68, 16);
			this.label3.TabIndex = 126;
			this.label3.Text = "Columna";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.White;
			this.label4.Location = new System.Drawing.Point(285, 18);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(68, 16);
			this.label4.TabIndex = 129;
			this.label4.Text = "Columna";
			// 
			// txtNombreCol
			// 
			this.txtNombreCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtNombreCol.Location = new System.Drawing.Point(288, 37);
			this.txtNombreCol.MaxLength = 20;
			this.txtNombreCol.Name = "txtNombreCol";
			this.txtNombreCol.Size = new System.Drawing.Size(65, 22);
			this.txtNombreCol.TabIndex = 128;
			this.txtNombreCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(216, 40);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(67, 16);
			this.label5.TabIndex = 127;
			this.label5.Text = "Nombre:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.White;
			this.label6.Location = new System.Drawing.Point(646, 18);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(68, 16);
			this.label6.TabIndex = 132;
			this.label6.Text = "Columna";
			// 
			// txtPrecioListaCol
			// 
			this.txtPrecioListaCol.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtPrecioListaCol.Location = new System.Drawing.Point(649, 37);
			this.txtPrecioListaCol.MaxLength = 20;
			this.txtPrecioListaCol.Name = "txtPrecioListaCol";
			this.txtPrecioListaCol.Size = new System.Drawing.Size(65, 22);
			this.txtPrecioListaCol.TabIndex = 131;
			this.txtPrecioListaCol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(549, 40);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(94, 16);
			this.label7.TabIndex = 130;
			this.label7.Text = "Precio Lista:";
			// 
			// ep
			// 
			this.ep.ContainerControl = this;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.txtEnvase);
			this.groupBox1.Controls.Add(this.btnBorrar);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.txtPrecioListaCol);
			this.groupBox1.Controls.Add(this.txtCodigoCol);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.txtNombreCol);
			this.groupBox1.Location = new System.Drawing.Point(25, 49);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(873, 67);
			this.groupBox1.TabIndex = 133;
			this.groupBox1.TabStop = false;
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(382, 40);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(64, 16);
			this.label8.TabIndex = 134;
			this.label8.Text = "Envase:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.White;
			this.label9.Location = new System.Drawing.Point(451, 18);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(68, 16);
			this.label9.TabIndex = 136;
			this.label9.Text = "Columna";
			// 
			// txtEnvase
			// 
			this.txtEnvase.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtEnvase.Location = new System.Drawing.Point(454, 37);
			this.txtEnvase.MaxLength = 20;
			this.txtEnvase.Name = "txtEnvase";
			this.txtEnvase.Size = new System.Drawing.Size(65, 22);
			this.txtEnvase.TabIndex = 135;
			this.txtEnvase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// btnBorrar
			// 
			this.btnBorrar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnBorrar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnBorrar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnBorrar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnBorrar.ForeColor = System.Drawing.Color.White;
			this.btnBorrar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btnBorrar.Location = new System.Drawing.Point(732, 28);
			this.btnBorrar.Name = "btnBorrar";
			this.btnBorrar.Size = new System.Drawing.Size(130, 31);
			this.btnBorrar.TabIndex = 133;
			this.btnBorrar.Text = "&Borrar";
			this.btnBorrar.UseVisualStyleBackColor = false;
			this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
			// 
			// lblMarca
			// 
			this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMarca.Location = new System.Drawing.Point(753, 12);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(134, 27);
			this.lblMarca.TabIndex = 134;
			this.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// frmImportarLista
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Pintureria.Properties.Resources.azul482;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1225, 584);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.lblMensaje);
			this.Controls.Add(this.picVisto);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.picImportar);
			this.Controls.Add(this.lblImportarDatos);
			this.Controls.Add(this.txtRegistros);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnEliminarCol);
			this.Controls.Add(this.txtPorDesRec);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.btnAgrDescRec);
			this.Controls.Add(this.txtDescDescRec);
			this.Controls.Add(this.cboDescRec);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.txtIva);
			this.Controls.Add(this.lvlIva);
			this.Controls.Add(this.txtGanancia);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.btnConfirmarImportacion);
			this.Controls.Add(this.dgImportar);
			this.Controls.Add(this.btnImportarLista);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "frmImportarLista";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Importar lista de productos";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.picImportar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgImportar)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.picVisto)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

        private System.Windows.Forms.Button btnImportarLista;
		private System.Windows.Forms.Button btnConfirmarImportacion;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel ssLblInformacion;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txtIva;
		private System.Windows.Forms.Label lvlIva;
		private System.Windows.Forms.TextBox txtGanancia;
		private System.Windows.Forms.TextBox txtPorDesRec;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Button btnAgrDescRec;
		private System.Windows.Forms.TextBox txtDescDescRec;
		private System.Windows.Forms.ComboBox cboDescRec;
		private System.Windows.Forms.Button btnEliminarCol;
		private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRegistros;
		private System.Windows.Forms.PictureBox picImportar;
		private System.Windows.Forms.Label lblImportarDatos;
        private System.Windows.Forms.Timer tLoanding;
        private System.Windows.Forms.DataGridView dgImportar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodArticulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecioLista;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSiniva;
        private System.Windows.Forms.DataGridViewTextBoxColumn colConIva;
        private System.Windows.Forms.PictureBox picVisto;
        private System.Windows.Forms.Label lblMensaje;
		private System.ComponentModel.BackgroundWorker backgroundWorker;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtCodigoCol;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNombreCol;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txtPrecioListaCol;
		private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnBorrar;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox txtEnvase;
	}
}
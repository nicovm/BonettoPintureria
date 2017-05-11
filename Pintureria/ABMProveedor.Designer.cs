namespace Pintureria
{
    partial class ABMProveedor
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMProveedor));
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnVaciarLista = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.dgProveedor = new System.Windows.Forms.DataGridView();
            this.txtBsc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnAyuda = new System.Windows.Forms.Button();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTelef = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCuit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedor)).BeginInit();
            this.SuspendLayout();
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
            this.btnSalir.Location = new System.Drawing.Point(704, 451);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 52);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnVaciarLista
            // 
            this.btnVaciarLista.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVaciarLista.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnVaciarLista.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnVaciarLista.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnVaciarLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVaciarLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVaciarLista.ForeColor = System.Drawing.Color.White;
            this.btnVaciarLista.Location = new System.Drawing.Point(12, 451);
            this.btnVaciarLista.Name = "btnVaciarLista";
            this.btnVaciarLista.Size = new System.Drawing.Size(160, 31);
            this.btnVaciarLista.TabIndex = 4;
            this.btnVaciarLista.Text = "&Vaciar Lista";
            this.btnVaciarLista.UseVisualStyleBackColor = false;
            this.btnVaciarLista.Click += new System.EventHandler(this.btnVaciarLista_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.ForeColor = System.Drawing.Color.White;
            this.btnNuevo.Location = new System.Drawing.Point(578, 37);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(126, 30);
            this.btnNuevo.TabIndex = 3;
            this.btnNuevo.Text = "&Nuevo proveedor";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // dgProveedor
            // 
            this.dgProveedor.AllowUserToAddRows = false;
            this.dgProveedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgProveedor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgProveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProveedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colDescripcion,
            this.colLocalidad,
            this.ColTelef,
            this.ColCuit,
            this.ColMail});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgProveedor.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgProveedor.Location = new System.Drawing.Point(8, 79);
            this.dgProveedor.MultiSelect = false;
            this.dgProveedor.Name = "dgProveedor";
            this.dgProveedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgProveedor.Size = new System.Drawing.Size(760, 366);
            this.dgProveedor.TabIndex = 69;
            this.dgProveedor.DoubleClick += new System.EventHandler(this.dgProveedor_DoubleClick);
            // 
            // txtBsc
            // 
            this.txtBsc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBsc.Location = new System.Drawing.Point(114, 41);
            this.txtBsc.Name = "txtBsc";
            this.txtBsc.Size = new System.Drawing.Size(298, 22);
            this.txtBsc.TabIndex = 1;
            this.txtBsc.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBsc_KeyDown);
            this.txtBsc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBsc_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 67;
            this.label1.Text = "Nombre/DNI:";
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
            this.btnBuscar.Location = new System.Drawing.Point(415, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnAyuda
            // 
            this.btnAyuda.Image = global::Pintureria.Properties.Resources.Ayuda;
            this.btnAyuda.Location = new System.Drawing.Point(733, 7);
            this.btnAyuda.Name = "btnAyuda";
            this.btnAyuda.Size = new System.Drawing.Size(35, 30);
            this.btnAyuda.TabIndex = 75;
            this.btnAyuda.UseVisualStyleBackColor = true;
            this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "idProveedor";
            this.colId.HeaderText = "";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 14;
            // 
            // colDescripcion
            // 
            this.colDescripcion.DataPropertyName = "RaSocial";
            this.colDescripcion.HeaderText = "Nombre";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.ReadOnly = true;
            this.colDescripcion.Width = 170;
            // 
            // colLocalidad
            // 
            this.colLocalidad.DataPropertyName = "nombreLocalidad";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colLocalidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.colLocalidad.HeaderText = "Localidad";
            this.colLocalidad.Name = "colLocalidad";
            this.colLocalidad.ReadOnly = true;
            this.colLocalidad.Width = 145;
            // 
            // ColTelef
            // 
            this.ColTelef.DataPropertyName = "Telefono";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColTelef.DefaultCellStyle = dataGridViewCellStyle3;
            this.ColTelef.HeaderText = "Telefono";
            this.ColTelef.Name = "ColTelef";
            this.ColTelef.ReadOnly = true;
            this.ColTelef.Width = 130;
            // 
            // ColCuit
            // 
            this.ColCuit.DataPropertyName = "CUIT";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColCuit.DefaultCellStyle = dataGridViewCellStyle4;
            this.ColCuit.HeaderText = "CUIT";
            this.ColCuit.Name = "ColCuit";
            this.ColCuit.ReadOnly = true;
            this.ColCuit.Width = 120;
            // 
            // ColMail
            // 
            this.ColMail.DataPropertyName = "Mail";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ColMail.DefaultCellStyle = dataGridViewCellStyle5;
            this.ColMail.HeaderText = "Mail";
            this.ColMail.Name = "ColMail";
            this.ColMail.ReadOnly = true;
            this.ColMail.Width = 150;
            // 
            // ABMProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(774, 511);
            this.Controls.Add(this.btnAyuda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVaciarLista);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.dgProveedor);
            this.Controls.Add(this.txtBsc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ABMProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proveedores";
            this.Deactivate += new System.EventHandler(this.ABMProveedor_Deactivate);
            this.Load += new System.EventHandler(this.ABMProveedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProveedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnVaciarLista;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.DataGridView dgProveedor;
        private System.Windows.Forms.TextBox txtBsc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.Button btnAyuda;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTelef;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCuit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMail;
    }
}
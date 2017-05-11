namespace Pintureria
{
    partial class ABMMarcas
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMMarcas));
			this.txtBscMarca = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.dgMarcas = new System.Windows.Forms.DataGridView();
			this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ColDelete = new System.Windows.Forms.DataGridViewButtonColumn();
			this.txtAgrMarca = new System.Windows.Forms.TextBox();
			this.lblNvoMod = new System.Windows.Forms.Label();
			this.btnSalir = new System.Windows.Forms.Button();
			this.btnGuardar = new System.Windows.Forms.Button();
			this.btnNuevo = new System.Windows.Forms.Button();
			this.btnModificar = new System.Windows.Forms.Button();
			this.txtId = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.btnAyuda = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgMarcas)).BeginInit();
			this.SuspendLayout();
			// 
			// txtBscMarca
			// 
			this.txtBscMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtBscMarca.Location = new System.Drawing.Point(81, 36);
			this.txtBscMarca.Name = "txtBscMarca";
			this.txtBscMarca.Size = new System.Drawing.Size(291, 22);
			this.txtBscMarca.TabIndex = 1;
			this.txtBscMarca.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBscMarca_KeyDown);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(21, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 16);
			this.label1.TabIndex = 1;
			this.label1.Text = "Marca:";
			// 
			// dgMarcas
			// 
			this.dgMarcas.AllowUserToAddRows = false;
			this.dgMarcas.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.dgMarcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgMarcas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colNombre,
            this.ColDelete});
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgMarcas.DefaultCellStyle = dataGridViewCellStyle1;
			this.dgMarcas.Location = new System.Drawing.Point(21, 74);
			this.dgMarcas.MultiSelect = false;
			this.dgMarcas.Name = "dgMarcas";
			this.dgMarcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgMarcas.Size = new System.Drawing.Size(395, 314);
			this.dgMarcas.TabIndex = 2;
			this.dgMarcas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgMarcas_CellContentClick);
			// 
			// colId
			// 
			this.colId.DataPropertyName = "idMarca";
			this.colId.HeaderText = "id";
			this.colId.Name = "colId";
			this.colId.ReadOnly = true;
			this.colId.Visible = false;
			// 
			// colNombre
			// 
			this.colNombre.DataPropertyName = "nombre";
			this.colNombre.HeaderText = "Nombre";
			this.colNombre.Name = "colNombre";
			this.colNombre.ReadOnly = true;
			this.colNombre.Width = 300;
			// 
			// ColDelete
			// 
			this.ColDelete.HeaderText = "Eliminar";
			this.ColDelete.Name = "ColDelete";
			this.ColDelete.ReadOnly = true;
			this.ColDelete.Text = "X";
			this.ColDelete.UseColumnTextForButtonValue = true;
			this.ColDelete.Width = 50;
			// 
			// txtAgrMarca
			// 
			this.txtAgrMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtAgrMarca.Location = new System.Drawing.Point(126, 426);
			this.txtAgrMarca.Name = "txtAgrMarca";
			this.txtAgrMarca.Size = new System.Drawing.Size(207, 22);
			this.txtAgrMarca.TabIndex = 3;
			this.txtAgrMarca.TextChanged += new System.EventHandler(this.txtAgrMarca_TextChanged);
			this.txtAgrMarca.Enter += new System.EventHandler(this.txtAgrMarca_Enter);
			// 
			// lblNvoMod
			// 
			this.lblNvoMod.AutoSize = true;
			this.lblNvoMod.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.lblNvoMod.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNvoMod.Location = new System.Drawing.Point(16, 427);
			this.lblNvoMod.Name = "lblNvoMod";
			this.lblNvoMod.Size = new System.Drawing.Size(104, 16);
			this.lblNvoMod.TabIndex = 7;
			this.lblNvoMod.Text = "Nueva Marca:";
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
			this.btnSalir.Location = new System.Drawing.Point(455, 402);
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(64, 52);
			this.btnSalir.TabIndex = 64;
			this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.btnSalir.UseVisualStyleBackColor = false;
			this.btnSalir.Click += new System.EventHandler(this.button4_Click);
			// 
			// btnGuardar
			// 
			this.btnGuardar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnGuardar.ForeColor = System.Drawing.Color.White;
			this.btnGuardar.Location = new System.Drawing.Point(339, 422);
			this.btnGuardar.Name = "btnGuardar";
			this.btnGuardar.Size = new System.Drawing.Size(83, 26);
			this.btnGuardar.TabIndex = 4;
			this.btnGuardar.Text = "&Guardar";
			this.btnGuardar.UseVisualStyleBackColor = false;
			this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
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
			this.btnNuevo.Location = new System.Drawing.Point(429, 74);
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(89, 26);
			this.btnNuevo.TabIndex = 5;
			this.btnNuevo.Text = "&Nuevo";
			this.btnNuevo.UseVisualStyleBackColor = false;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnModificar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnModificar.ForeColor = System.Drawing.Color.White;
			this.btnModificar.Location = new System.Drawing.Point(429, 106);
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(89, 26);
			this.btnModificar.TabIndex = 6;
			this.btnModificar.Text = "&Modificar";
			this.btnModificar.UseVisualStyleBackColor = false;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// txtId
			// 
			this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtId.Location = new System.Drawing.Point(126, 402);
			this.txtId.Name = "txtId";
			this.txtId.Size = new System.Drawing.Size(36, 22);
			this.txtId.TabIndex = 70;
			this.txtId.Visible = false;
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
			this.btnBuscar.Location = new System.Drawing.Point(376, 34);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(31, 25);
			this.btnBuscar.TabIndex = 2;
			this.btnBuscar.UseVisualStyleBackColor = false;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(58, 402);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(62, 16);
			this.label2.TabIndex = 72;
			this.label2.Text = "Código:";
			// 
			// btnAyuda
			// 
			this.btnAyuda.Image = global::Pintureria.Properties.Resources.Ayuda;
			this.btnAyuda.Location = new System.Drawing.Point(487, 12);
			this.btnAyuda.Name = "btnAyuda";
			this.btnAyuda.Size = new System.Drawing.Size(35, 30);
			this.btnAyuda.TabIndex = 73;
			this.btnAyuda.UseVisualStyleBackColor = true;
			this.btnAyuda.Click += new System.EventHandler(this.btnAyuda_Click);
			// 
			// ABMMarcas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.CancelButton = this.btnSalir;
			this.ClientSize = new System.Drawing.Size(534, 474);
			this.Controls.Add(this.btnAyuda);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btnBuscar);
			this.Controls.Add(this.txtId);
			this.Controls.Add(this.btnModificar);
			this.Controls.Add(this.btnNuevo);
			this.Controls.Add(this.btnGuardar);
			this.Controls.Add(this.btnSalir);
			this.Controls.Add(this.txtAgrMarca);
			this.Controls.Add(this.lblNvoMod);
			this.Controls.Add(this.dgMarcas);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtBscMarca);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.Name = "ABMMarcas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Marcas";
			this.Deactivate += new System.EventHandler(this.ABMMarcas_Deactivate);
			this.Load += new System.EventHandler(this.ABMMarcas_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgMarcas)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBscMarca;
        private System.Windows.Forms.Label label1;
		private System.Windows.Forms.DataGridView dgMarcas;
        private System.Windows.Forms.TextBox txtAgrMarca;
        private System.Windows.Forms.Label lblNvoMod;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnGuardar;
		private System.Windows.Forms.Button btnNuevo;
		private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewButtonColumn ColDelete;
		private System.Windows.Forms.Button btnAyuda;
    }
}
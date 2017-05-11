namespace Pintureria
{
    partial class ABMVendedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ABMVendedores));
            this.dgVendedor = new System.Windows.Forms.DataGridView();
            this.ColIdVend = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDescrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnNuevoVend = new System.Windows.Forms.Button();
            this.btnVaciarLista = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // dgVendedor
            // 
            this.dgVendedor.AllowUserToAddRows = false;
            this.dgVendedor.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgVendedor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdVend,
            this.ColDescrip,
            this.ColTel,
            this.ColLocalidad});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgVendedor.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgVendedor.Location = new System.Drawing.Point(12, 71);
            this.dgVendedor.MultiSelect = false;
            this.dgVendedor.Name = "dgVendedor";
            this.dgVendedor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgVendedor.Size = new System.Drawing.Size(760, 381);
            this.dgVendedor.TabIndex = 4;
            this.dgVendedor.DoubleClick += new System.EventHandler(this.dgVendedor_DoubleClick);
            // 
            // ColIdVend
            // 
            this.ColIdVend.DataPropertyName = "idVendedor";
            this.ColIdVend.HeaderText = "Código";
            this.ColIdVend.Name = "ColIdVend";
            this.ColIdVend.ReadOnly = true;
            // 
            // ColDescrip
            // 
            this.ColDescrip.DataPropertyName = "nombre";
            this.ColDescrip.HeaderText = "Nombre";
            this.ColDescrip.Name = "ColDescrip";
            this.ColDescrip.ReadOnly = true;
            this.ColDescrip.Width = 200;
            // 
            // ColTel
            // 
            this.ColTel.DataPropertyName = "telefono";
            this.ColTel.HeaderText = "Telefono";
            this.ColTel.Name = "ColTel";
            this.ColTel.ReadOnly = true;
            this.ColTel.Width = 200;
            // 
            // ColLocalidad
            // 
            this.ColLocalidad.DataPropertyName = "nombreLocalidad";
            this.ColLocalidad.HeaderText = "Localidad";
            this.ColLocalidad.Name = "ColLocalidad";
            this.ColLocalidad.ReadOnly = true;
            this.ColLocalidad.Width = 200;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(115, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(298, 22);
            this.txtBuscar.TabIndex = 1;
            this.txtBuscar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscar_KeyDown);
            this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre/DNI:";
            // 
            // btnNuevoVend
            // 
            this.btnNuevoVend.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevoVend.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnNuevoVend.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevoVend.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
            this.btnNuevoVend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoVend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoVend.ForeColor = System.Drawing.Color.White;
            this.btnNuevoVend.Location = new System.Drawing.Point(648, 23);
            this.btnNuevoVend.Name = "btnNuevoVend";
            this.btnNuevoVend.Size = new System.Drawing.Size(121, 30);
            this.btnNuevoVend.TabIndex = 3;
            this.btnNuevoVend.Text = "&Nuevo Vendedor";
            this.btnNuevoVend.UseVisualStyleBackColor = false;
            this.btnNuevoVend.Click += new System.EventHandler(this.btnNuevoVend_Click);
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
            this.btnVaciarLista.Location = new System.Drawing.Point(14, 458);
            this.btnVaciarLista.Name = "btnVaciarLista";
            this.btnVaciarLista.Size = new System.Drawing.Size(160, 31);
            this.btnVaciarLista.TabIndex = 5;
            this.btnVaciarLista.Text = "&Vaciar Lista";
            this.btnVaciarLista.UseVisualStyleBackColor = false;
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
            this.btnSalir.Location = new System.Drawing.Point(705, 458);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(64, 52);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.button4_Click);
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
            this.btnBuscar.Location = new System.Drawing.Point(417, 26);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(31, 25);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ABMVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(784, 521);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVaciarLista);
            this.Controls.Add(this.btnNuevoVend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dgVendedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "ABMVendedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendedores";
            this.Deactivate += new System.EventHandler(this.ABMVendedores_Deactivate);
            this.Load += new System.EventHandler(this.ABMVendedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgVendedor;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNuevoVend;
        private System.Windows.Forms.Button btnVaciarLista;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdVend;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDescrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTel;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColLocalidad;
    }
}
namespace Pintureria
{
	partial class frmAplicarRecargo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAplicarRecargo));
            this.txtRecargo = new System.Windows.Forms.TextBox();
            this.cboTipRecargo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPrecioTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAplicarRecargo = new System.Windows.Forms.Button();
            this.lbl = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRecargo
            // 
            this.txtRecargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRecargo.Location = new System.Drawing.Point(228, 66);
            this.txtRecargo.MaxLength = 10;
            this.txtRecargo.Name = "txtRecargo";
            this.txtRecargo.Size = new System.Drawing.Size(122, 22);
            this.txtRecargo.TabIndex = 2;
            this.txtRecargo.Text = "0";
            this.txtRecargo.Leave += new System.EventHandler(this.txtRecargo_Leave);
            // 
            // cboTipRecargo
            // 
            this.cboTipRecargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipRecargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipRecargo.FormattingEnabled = true;
            this.cboTipRecargo.Items.AddRange(new object[] {
            "%",
            "$"});
            this.cboTipRecargo.Location = new System.Drawing.Point(181, 66);
            this.cboTipRecargo.Name = "cboTipRecargo";
            this.cboTipRecargo.Size = new System.Drawing.Size(42, 24);
            this.cboTipRecargo.TabIndex = 1;
            this.cboTipRecargo.SelectedIndexChanged += new System.EventHandler(this.cboTipRecargo_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(107, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 16);
            this.label10.TabIndex = 48;
            this.label10.Text = "Recargo:";
            // 
            // txtPrecioTotal
            // 
            this.txtPrecioTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioTotal.Location = new System.Drawing.Point(228, 29);
            this.txtPrecioTotal.MaxLength = 10;
            this.txtPrecioTotal.Name = "txtPrecioTotal";
            this.txtPrecioTotal.ReadOnly = true;
            this.txtPrecioTotal.Size = new System.Drawing.Size(122, 22);
            this.txtPrecioTotal.TabIndex = 51;
            this.txtPrecioTotal.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(99, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 16);
            this.label1.TabIndex = 52;
            this.label1.Text = "Precio De Venta:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(269, 150);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 27);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Canc&elar Venta";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnAplicarRecargo
            // 
            this.btnAplicarRecargo.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAplicarRecargo.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAplicarRecargo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnAplicarRecargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarRecargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAplicarRecargo.ForeColor = System.Drawing.Color.White;
            this.btnAplicarRecargo.Location = new System.Drawing.Point(138, 150);
            this.btnAplicarRecargo.Name = "btnAplicarRecargo";
            this.btnAplicarRecargo.Size = new System.Drawing.Size(125, 27);
            this.btnAplicarRecargo.TabIndex = 3;
            this.btnAplicarRecargo.Text = "&Aplicar Recargo";
            this.btnAplicarRecargo.UseVisualStyleBackColor = false;
            this.btnAplicarRecargo.Click += new System.EventHandler(this.btnAplicarRecargo_Click);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(178, 104);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(48, 16);
            this.lbl.TabIndex = 76;
            this.lbl.Text = "Total:";
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(228, 101);
            this.txtTotal.MaxLength = 10;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(122, 22);
            this.txtTotal.TabIndex = 75;
            this.txtTotal.TabStop = false;
            // 
            // frmAplicarRecargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(489, 221);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAplicarRecargo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPrecioTotal);
            this.Controls.Add(this.txtRecargo);
            this.Controls.Add(this.cboTipRecargo);
            this.Controls.Add(this.label10);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAplicarRecargo";
            this.Text = "Recargo";
            this.Load += new System.EventHandler(this.frmAplicarRecargo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtRecargo;
		private System.Windows.Forms.ComboBox cboTipRecargo;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox txtPrecioTotal;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnCancelar;
		private System.Windows.Forms.Button btnAplicarRecargo;
		private System.Windows.Forms.Label lbl;
		private System.Windows.Forms.TextBox txtTotal;
	}
}
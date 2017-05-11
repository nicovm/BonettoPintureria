namespace Pintureria
{
	partial class ctrlHojaExcel
	{
		/// <summary> 
		/// Variable del diseñador requerida.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Limpiar los recursos que se estén utilizando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de componentes

		/// <summary> 
		/// Método necesario para admitir el Diseñador. No se puede modificar 
		/// el contenido del método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.lblNombreHoja = new System.Windows.Forms.Label();
			this.btnSeleccionar = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// lblNombreHoja
			// 
			this.lblNombreHoja.AutoSize = true;
			this.lblNombreHoja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblNombreHoja.Location = new System.Drawing.Point(41, 9);
			this.lblNombreHoja.Name = "lblNombreHoja";
			this.lblNombreHoja.Size = new System.Drawing.Size(71, 20);
			this.lblNombreHoja.TabIndex = 1;
			this.lblNombreHoja.Text = "Nombre";
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.BackColor = System.Drawing.SystemColors.HotTrack;
			this.btnSeleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSeleccionar.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnSeleccionar.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.HotTrack;
			this.btnSeleccionar.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Highlight;
			this.btnSeleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnSeleccionar.ForeColor = System.Drawing.Color.White;
			this.btnSeleccionar.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
			this.btnSeleccionar.Location = new System.Drawing.Point(333, 4);
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(102, 31);
			this.btnSeleccionar.TabIndex = 134;
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.UseVisualStyleBackColor = false;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Pintureria.Properties.Resources.excel2;
			this.pictureBox1.Location = new System.Drawing.Point(3, 3);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(32, 32);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// ctrlHojaExcel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.Controls.Add(this.btnSeleccionar);
			this.Controls.Add(this.lblNombreHoja);
			this.Controls.Add(this.pictureBox1);
			this.Name = "ctrlHojaExcel";
			this.Size = new System.Drawing.Size(451, 41);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label lblNombreHoja;
		private System.Windows.Forms.Button btnSeleccionar;
	}
}

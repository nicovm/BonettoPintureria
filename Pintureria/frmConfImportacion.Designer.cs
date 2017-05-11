namespace Pintureria
{
	partial class frmConfImportacion
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
			this.lblConfirmacion = new System.Windows.Forms.Label();
			this.picImportar = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.picImportar)).BeginInit();
			this.SuspendLayout();
			// 
			// lblConfirmacion
			// 
			this.lblConfirmacion.AutoSize = true;
			this.lblConfirmacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblConfirmacion.Location = new System.Drawing.Point(66, 37);
			this.lblConfirmacion.Name = "lblConfirmacion";
			this.lblConfirmacion.Size = new System.Drawing.Size(222, 24);
			this.lblConfirmacion.TabIndex = 0;
			this.lblConfirmacion.Text = "Importando los datos...";
			// 
			// picImportar
			// 
			this.picImportar.Image = global::Pintureria.Properties.Resources.Animation;
			this.picImportar.Location = new System.Drawing.Point(12, 28);
			this.picImportar.Name = "picImportar";
			this.picImportar.Size = new System.Drawing.Size(48, 48);
			this.picImportar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.picImportar.TabIndex = 1;
			this.picImportar.TabStop = false;
			// 
			// frmConfImportacion
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(293, 117);
			this.Controls.Add(this.picImportar);
			this.Controls.Add(this.lblConfirmacion);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "frmConfImportacion";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmConfImportacion";
			((System.ComponentModel.ISupportInitialize)(this.picImportar)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblConfirmacion;
		private System.Windows.Forms.PictureBox picImportar;
	}
}
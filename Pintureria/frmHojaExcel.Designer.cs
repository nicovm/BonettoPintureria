namespace Pintureria
{
	partial class frmHojaExcel
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
			this.flpHojaExcel = new System.Windows.Forms.FlowLayoutPanel();
			this.SuspendLayout();
			// 
			// flpHojaExcel
			// 
			this.flpHojaExcel.BackColor = System.Drawing.Color.White;
			this.flpHojaExcel.Location = new System.Drawing.Point(8, 12);
			this.flpHojaExcel.Name = "flpHojaExcel";
			this.flpHojaExcel.Size = new System.Drawing.Size(465, 266);
			this.flpHojaExcel.TabIndex = 0;
			// 
			// frmHojaExcel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(485, 290);
			this.Controls.Add(this.flpHojaExcel);
			this.Name = "frmHojaExcel";
			this.Text = "frmHojaExcel";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.FlowLayoutPanel flpHojaExcel;
	}
}
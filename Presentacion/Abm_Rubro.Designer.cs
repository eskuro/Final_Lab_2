﻿namespace Presentacion
{
	partial class Abm_Rubro
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
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(28, 164);
			this.txtDescripcion.MaximumSize = new System.Drawing.Size(327, 20);
			this.txtDescripcion.MinimumSize = new System.Drawing.Size(327, 20);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(327, 20);
			this.txtDescripcion.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(25, 135);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Descripcion";
			// 
			// Abm_Rubro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(404, 286);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.txtDescripcion);
			this.Name = "Abm_Rubro";
			this.Text = "Abm_Rubro";
			this.Controls.SetChildIndex(this.txtDescripcion, 0);
			this.Controls.SetChildIndex(this.label1, 0);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.Label label1;
	}
}
namespace Presentacion
{
	partial class Abm_Articulos
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
			this.txtAbreviatura = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.nudPrecio = new System.Windows.Forms.NumericUpDown();
			this.nudStock = new System.Windows.Forms.NumericUpDown();
			this.cmbRubro = new System.Windows.Forms.ComboBox();
			this.btnNuevoRubro = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStock)).BeginInit();
			this.SuspendLayout();
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(220, 98);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(150, 20);
			this.txtDescripcion.TabIndex = 1;
			// 
			// txtAbreviatura
			// 
			this.txtAbreviatura.Location = new System.Drawing.Point(220, 139);
			this.txtAbreviatura.Name = "txtAbreviatura";
			this.txtAbreviatura.Size = new System.Drawing.Size(100, 20);
			this.txtAbreviatura.TabIndex = 2;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(43, 98);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(66, 20);
			this.txtCodigo.TabIndex = 3;
			this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
			// 
			// nudPrecio
			// 
			this.nudPrecio.Location = new System.Drawing.Point(43, 139);
			this.nudPrecio.Name = "nudPrecio";
			this.nudPrecio.Size = new System.Drawing.Size(75, 20);
			this.nudPrecio.TabIndex = 4;
			// 
			// nudStock
			// 
			this.nudStock.Location = new System.Drawing.Point(43, 181);
			this.nudStock.MaximumSize = new System.Drawing.Size(75, 0);
			this.nudStock.MinimumSize = new System.Drawing.Size(75, 0);
			this.nudStock.Name = "nudStock";
			this.nudStock.Size = new System.Drawing.Size(75, 20);
			this.nudStock.TabIndex = 5;
			// 
			// cmbRubro
			// 
			this.cmbRubro.FormattingEnabled = true;
			this.cmbRubro.Location = new System.Drawing.Point(220, 181);
			this.cmbRubro.Name = "cmbRubro";
			this.cmbRubro.Size = new System.Drawing.Size(121, 21);
			this.cmbRubro.TabIndex = 6;
			// 
			// btnNuevoRubro
			// 
			this.btnNuevoRubro.Location = new System.Drawing.Point(347, 181);
			this.btnNuevoRubro.Name = "btnNuevoRubro";
			this.btnNuevoRubro.Size = new System.Drawing.Size(75, 23);
			this.btnNuevoRubro.TabIndex = 7;
			this.btnNuevoRubro.Text = "...";
			this.btnNuevoRubro.UseVisualStyleBackColor = true;
			this.btnNuevoRubro.Click += new System.EventHandler(this.btnNuevoRubro_Click);
			// 
			// Abm_Articulos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 252);
			this.Controls.Add(this.btnNuevoRubro);
			this.Controls.Add(this.cmbRubro);
			this.Controls.Add(this.nudStock);
			this.Controls.Add(this.nudPrecio);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.txtAbreviatura);
			this.Controls.Add(this.txtDescripcion);
			this.Name = "Abm_Articulos";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Abm_Articulos";
			this.Controls.SetChildIndex(this.txtDescripcion, 0);
			this.Controls.SetChildIndex(this.txtAbreviatura, 0);
			this.Controls.SetChildIndex(this.txtCodigo, 0);
			this.Controls.SetChildIndex(this.nudPrecio, 0);
			this.Controls.SetChildIndex(this.nudStock, 0);
			this.Controls.SetChildIndex(this.cmbRubro, 0);
			this.Controls.SetChildIndex(this.btnNuevoRubro, 0);
			((System.ComponentModel.ISupportInitialize)(this.nudPrecio)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudStock)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtAbreviatura;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.NumericUpDown nudPrecio;
		private System.Windows.Forms.NumericUpDown nudStock;
		private System.Windows.Forms.ComboBox cmbRubro;
		private System.Windows.Forms.Button btnNuevoRubro;
	}
}
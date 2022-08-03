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
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
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
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(40, 82);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 13);
			this.label1.TabIndex = 8;
			this.label1.Text = "Codigo";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(40, 121);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(37, 13);
			this.label2.TabIndex = 9;
			this.label2.Text = "Precio";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(40, 165);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(35, 13);
			this.label3.TabIndex = 10;
			this.label3.Text = "Stock";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(217, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(63, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Descripcion";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(217, 121);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(61, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Abreviatura";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(217, 162);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(36, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "Rubro";
			// 
			// Abm_Articulos
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 252);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
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
			this.Controls.SetChildIndex(this.label1, 0);
			this.Controls.SetChildIndex(this.label2, 0);
			this.Controls.SetChildIndex(this.label3, 0);
			this.Controls.SetChildIndex(this.label4, 0);
			this.Controls.SetChildIndex(this.label5, 0);
			this.Controls.SetChildIndex(this.label6, 0);
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
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
	}
}
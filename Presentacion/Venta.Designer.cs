namespace Presentacion
{
	partial class Venta
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
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.nudCantidad = new System.Windows.Forms.NumericUpDown();
			this.dgvGrilla = new System.Windows.Forms.DataGridView();
			this.txtSubTotal = new System.Windows.Forms.TextBox();
			this.nudDescuento = new System.Windows.Forms.NumericUpDown();
			this.txtTotal = new System.Windows.Forms.TextBox();
			this.btnFacturar = new System.Windows.Forms.Button();
			this.btnBorrarItem = new System.Windows.Forms.Button();
			this.btnCambiarCantidad = new System.Windows.Forms.Button();
			this.btnAgregar = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).BeginInit();
			this.SuspendLayout();
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(24, 75);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 20);
			this.txtCodigo.TabIndex = 0;
			this.txtCodigo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCodigo_KeyUp);
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(236, 75);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(100, 20);
			this.txtPrecio.TabIndex = 1;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(130, 75);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
			this.txtDescripcion.TabIndex = 2;
			// 
			// nudCantidad
			// 
			this.nudCantidad.Location = new System.Drawing.Point(419, 75);
			this.nudCantidad.Name = "nudCantidad";
			this.nudCantidad.Size = new System.Drawing.Size(81, 20);
			this.nudCantidad.TabIndex = 3;
			// 
			// dgvGrilla
			// 
			this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGrilla.Location = new System.Drawing.Point(2, 124);
			this.dgvGrilla.Name = "dgvGrilla";
			this.dgvGrilla.Size = new System.Drawing.Size(619, 281);
			this.dgvGrilla.TabIndex = 4;
			this.dgvGrilla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_RowEnter);
			this.dgvGrilla.DoubleClick += new System.EventHandler(this.dgvGrilla_DoubleClick);
			// 
			// txtSubTotal
			// 
			this.txtSubTotal.Location = new System.Drawing.Point(503, 411);
			this.txtSubTotal.Name = "txtSubTotal";
			this.txtSubTotal.Size = new System.Drawing.Size(100, 20);
			this.txtSubTotal.TabIndex = 5;
			// 
			// nudDescuento
			// 
			this.nudDescuento.Location = new System.Drawing.Point(503, 437);
			this.nudDescuento.Name = "nudDescuento";
			this.nudDescuento.Size = new System.Drawing.Size(81, 20);
			this.nudDescuento.TabIndex = 6;
			this.nudDescuento.ValueChanged += new System.EventHandler(this.nudDescuento_ValueChanged);
			// 
			// txtTotal
			// 
			this.txtTotal.Location = new System.Drawing.Point(503, 463);
			this.txtTotal.Name = "txtTotal";
			this.txtTotal.Size = new System.Drawing.Size(100, 20);
			this.txtTotal.TabIndex = 7;
			// 
			// btnFacturar
			// 
			this.btnFacturar.Location = new System.Drawing.Point(24, 423);
			this.btnFacturar.Name = "btnFacturar";
			this.btnFacturar.Size = new System.Drawing.Size(72, 60);
			this.btnFacturar.TabIndex = 8;
			this.btnFacturar.Text = "Facturar";
			this.btnFacturar.UseVisualStyleBackColor = true;
			this.btnFacturar.Click += new System.EventHandler(this.btnFacturar_Click);
			// 
			// btnBorrarItem
			// 
			this.btnBorrarItem.Location = new System.Drawing.Point(102, 423);
			this.btnBorrarItem.Name = "btnBorrarItem";
			this.btnBorrarItem.Size = new System.Drawing.Size(72, 60);
			this.btnBorrarItem.TabIndex = 9;
			this.btnBorrarItem.Text = "Borrar";
			this.btnBorrarItem.UseVisualStyleBackColor = true;
			this.btnBorrarItem.Click += new System.EventHandler(this.btnBorrarItem_Click);
			// 
			// btnCambiarCantidad
			// 
			this.btnCambiarCantidad.Location = new System.Drawing.Point(180, 423);
			this.btnCambiarCantidad.Name = "btnCambiarCantidad";
			this.btnCambiarCantidad.Size = new System.Drawing.Size(72, 60);
			this.btnCambiarCantidad.TabIndex = 10;
			this.btnCambiarCantidad.Text = "Cambiar Cantidad";
			this.btnCambiarCantidad.UseVisualStyleBackColor = true;
			this.btnCambiarCantidad.Click += new System.EventHandler(this.btnCambiarCantidad_Click);
			// 
			// btnAgregar
			// 
			this.btnAgregar.Location = new System.Drawing.Point(509, 73);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(75, 23);
			this.btnAgregar.TabIndex = 11;
			this.btnAgregar.Text = "Agregar";
			this.btnAgregar.UseVisualStyleBackColor = true;
			this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
			// 
			// Venta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(623, 505);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.btnCambiarCantidad);
			this.Controls.Add(this.btnBorrarItem);
			this.Controls.Add(this.btnFacturar);
			this.Controls.Add(this.txtTotal);
			this.Controls.Add(this.nudDescuento);
			this.Controls.Add(this.txtSubTotal);
			this.Controls.Add(this.dgvGrilla);
			this.Controls.Add(this.nudCantidad);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtCodigo);
			this.Name = "Venta";
			this.Text = "Venta";
			this.Load += new System.EventHandler(this.Venta_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudDescuento)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.NumericUpDown nudCantidad;
		private System.Windows.Forms.DataGridView dgvGrilla;
		private System.Windows.Forms.TextBox txtSubTotal;
		private System.Windows.Forms.NumericUpDown nudDescuento;
		private System.Windows.Forms.TextBox txtTotal;
		private System.Windows.Forms.Button btnFacturar;
		private System.Windows.Forms.Button btnBorrarItem;
		private System.Windows.Forms.Button btnCambiarCantidad;
		private System.Windows.Forms.Button btnAgregar;
	}
}
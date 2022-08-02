namespace FormularioBase
{
	partial class FormConsulta
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsulta));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnNuevo = new System.Windows.Forms.ToolStripButton();
			this.btnModificar = new System.Windows.Forms.ToolStripButton();
			this.btnElminar = new System.Windows.Forms.ToolStripButton();
			this.btnActualizar = new System.Windows.Forms.ToolStripButton();
			this.btnSalir = new System.Windows.Forms.ToolStripButton();
			this.pnlBusqueda = new System.Windows.Forms.Panel();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.dgvGrilla = new System.Windows.Forms.DataGridView();
			this.toolStrip1.SuspendLayout();
			this.pnlBusqueda.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnModificar,
            this.btnElminar,
            this.btnActualizar,
            this.btnSalir});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(3);
			this.toolStrip1.Size = new System.Drawing.Size(510, 58);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnNuevo
			// 
			this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
			this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnNuevo.Name = "btnNuevo";
			this.btnNuevo.Size = new System.Drawing.Size(46, 49);
			this.btnNuevo.Text = "Nuevo";
			this.btnNuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
			// 
			// btnModificar
			// 
			this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
			this.btnModificar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnModificar.Name = "btnModificar";
			this.btnModificar.Size = new System.Drawing.Size(62, 49);
			this.btnModificar.Text = "Modificar";
			this.btnModificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
			// 
			// btnElminar
			// 
			this.btnElminar.Image = ((System.Drawing.Image)(resources.GetObject("btnElminar.Image")));
			this.btnElminar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnElminar.Name = "btnElminar";
			this.btnElminar.Size = new System.Drawing.Size(54, 49);
			this.btnElminar.Text = "Eliminar";
			this.btnElminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnElminar.Click += new System.EventHandler(this.btnElminar_Click);
			// 
			// btnActualizar
			// 
			this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
			this.btnActualizar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnActualizar.Name = "btnActualizar";
			this.btnActualizar.Size = new System.Drawing.Size(63, 49);
			this.btnActualizar.Text = "Actualizar";
			this.btnActualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
			// 
			// btnSalir
			// 
			this.btnSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
			this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSalir.Name = "btnSalir";
			this.btnSalir.Size = new System.Drawing.Size(34, 49);
			this.btnSalir.Text = "Salir";
			this.btnSalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
			// 
			// pnlBusqueda
			// 
			this.pnlBusqueda.Controls.Add(this.btnBuscar);
			this.pnlBusqueda.Controls.Add(this.txtBuscar);
			this.pnlBusqueda.Location = new System.Drawing.Point(0, 61);
			this.pnlBusqueda.Name = "pnlBusqueda";
			this.pnlBusqueda.Size = new System.Drawing.Size(510, 27);
			this.pnlBusqueda.TabIndex = 1;
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(344, 1);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 1;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(3, 3);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(335, 20);
			this.txtBuscar.TabIndex = 0;
			this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
			// 
			// dgvGrilla
			// 
			this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGrilla.Location = new System.Drawing.Point(0, 94);
			this.dgvGrilla.MultiSelect = false;
			this.dgvGrilla.Name = "dgvGrilla";
			this.dgvGrilla.ReadOnly = true;
			this.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvGrilla.Size = new System.Drawing.Size(510, 356);
			this.dgvGrilla.TabIndex = 5;
			this.dgvGrilla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_RowEnter);
			// 
			// FormConsulta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(510, 450);
			this.Controls.Add(this.dgvGrilla);
			this.Controls.Add(this.pnlBusqueda);
			this.Controls.Add(this.toolStrip1);
			this.Name = "FormConsulta";
			this.Text = "FormConsulta";
			this.Load += new System.EventHandler(this.FormConsulta_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.pnlBusqueda.ResumeLayout(false);
			this.pnlBusqueda.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		protected System.Windows.Forms.ToolStripButton btnNuevo;
		protected System.Windows.Forms.ToolStripButton btnModificar;
		protected System.Windows.Forms.ToolStripButton btnElminar;
		protected System.Windows.Forms.ToolStripButton btnActualizar;
		protected System.Windows.Forms.ToolStripButton btnSalir;
		private System.Windows.Forms.Panel pnlBusqueda;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.DataGridView dgvGrilla;
	}
}
namespace FormularioBase
{
	partial class FormLookUp
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLookUp));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.btnSeleccionar = new System.Windows.Forms.ToolStripButton();
			this.btnActualizar = new System.Windows.Forms.ToolStripButton();
			this.btnSalir = new System.Windows.Forms.ToolStripButton();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dgvGrilla = new System.Windows.Forms.DataGridView();
			this.txtBuscar = new System.Windows.Forms.TextBox();
			this.btnBuscar = new System.Windows.Forms.Button();
			this.toolStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.ImageScalingSize = new System.Drawing.Size(30, 30);
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSeleccionar,
            this.btnActualizar,
            this.btnSalir});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Padding = new System.Windows.Forms.Padding(3);
			this.toolStrip1.Size = new System.Drawing.Size(621, 58);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// btnSeleccionar
			// 
			this.btnSeleccionar.Image = ((System.Drawing.Image)(resources.GetObject("btnSeleccionar.Image")));
			this.btnSeleccionar.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.btnSeleccionar.Name = "btnSeleccionar";
			this.btnSeleccionar.Size = new System.Drawing.Size(71, 49);
			this.btnSeleccionar.Text = "Seleccionar";
			this.btnSeleccionar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
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
			// panel1
			// 
			this.panel1.Controls.Add(this.btnBuscar);
			this.panel1.Controls.Add(this.txtBuscar);
			this.panel1.Location = new System.Drawing.Point(0, 61);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(621, 26);
			this.panel1.TabIndex = 1;
			// 
			// dgvGrilla
			// 
			this.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGrilla.Location = new System.Drawing.Point(0, 90);
			this.dgvGrilla.Name = "dgvGrilla";
			this.dgvGrilla.Size = new System.Drawing.Size(621, 362);
			this.dgvGrilla.TabIndex = 2;
			this.dgvGrilla.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrilla_RowEnter);
			this.dgvGrilla.DoubleClick += new System.EventHandler(this.dgvGrilla_DoubleClick);
			this.dgvGrilla.KeyUp += new System.Windows.Forms.KeyEventHandler(this.dgvGrilla_KeyUp);
			// 
			// txtBuscar
			// 
			this.txtBuscar.Location = new System.Drawing.Point(3, 3);
			this.txtBuscar.Name = "txtBuscar";
			this.txtBuscar.Size = new System.Drawing.Size(311, 20);
			this.txtBuscar.TabIndex = 0;
			this.txtBuscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBuscar_KeyPress);
			// 
			// btnBuscar
			// 
			this.btnBuscar.Location = new System.Drawing.Point(320, 3);
			this.btnBuscar.Name = "btnBuscar";
			this.btnBuscar.Size = new System.Drawing.Size(75, 23);
			this.btnBuscar.TabIndex = 1;
			this.btnBuscar.Text = "Buscar";
			this.btnBuscar.UseVisualStyleBackColor = true;
			this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
			// 
			// FormLookUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(621, 450);
			this.Controls.Add(this.dgvGrilla);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.toolStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "FormLookUp";
			this.Text = "FormLookUp";
			this.Load += new System.EventHandler(this.FormLookUp_Load);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGrilla)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		protected System.Windows.Forms.ToolStripButton btnSeleccionar;
		private System.Windows.Forms.ToolStripButton btnActualizar;
		private System.Windows.Forms.ToolStripButton btnSalir;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnBuscar;
		private System.Windows.Forms.TextBox txtBuscar;
		private System.Windows.Forms.DataGridView dgvGrilla;
	}
}
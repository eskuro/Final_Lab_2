namespace Principal
{
	partial class Principal
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
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.articulosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.creToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.rubrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.consultaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.nuevoRubroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.panelContenedor = new System.Windows.Forms.Panel();
			this.ventasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.generarVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.articulosToolStripMenuItem,
            this.rubrosToolStripMenuItem,
            this.ventasToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(531, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// articulosToolStripMenuItem
			// 
			this.articulosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem,
            this.creToolStripMenuItem});
			this.articulosToolStripMenuItem.Name = "articulosToolStripMenuItem";
			this.articulosToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
			this.articulosToolStripMenuItem.Text = "Articulos";
			// 
			// consultaToolStripMenuItem
			// 
			this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
			this.consultaToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.consultaToolStripMenuItem.Text = "Consulta";
			this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
			// 
			// creToolStripMenuItem
			// 
			this.creToolStripMenuItem.Name = "creToolStripMenuItem";
			this.creToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
			this.creToolStripMenuItem.Text = "Nuevo Articulo";
			this.creToolStripMenuItem.Click += new System.EventHandler(this.creToolStripMenuItem_Click);
			// 
			// rubrosToolStripMenuItem
			// 
			this.rubrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaToolStripMenuItem1,
            this.nuevoRubroToolStripMenuItem});
			this.rubrosToolStripMenuItem.Name = "rubrosToolStripMenuItem";
			this.rubrosToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
			this.rubrosToolStripMenuItem.Text = "Rubros";
			// 
			// consultaToolStripMenuItem1
			// 
			this.consultaToolStripMenuItem1.Name = "consultaToolStripMenuItem1";
			this.consultaToolStripMenuItem1.Size = new System.Drawing.Size(144, 22);
			this.consultaToolStripMenuItem1.Text = "Consulta ";
			this.consultaToolStripMenuItem1.Click += new System.EventHandler(this.consultaToolStripMenuItem1_Click);
			// 
			// nuevoRubroToolStripMenuItem
			// 
			this.nuevoRubroToolStripMenuItem.Name = "nuevoRubroToolStripMenuItem";
			this.nuevoRubroToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
			this.nuevoRubroToolStripMenuItem.Text = "Nuevo Rubro";
			this.nuevoRubroToolStripMenuItem.Click += new System.EventHandler(this.nuevoRubroToolStripMenuItem_Click);
			// 
			// panelContenedor
			// 
			this.panelContenedor.Location = new System.Drawing.Point(0, 27);
			this.panelContenedor.Name = "panelContenedor";
			this.panelContenedor.Size = new System.Drawing.Size(531, 420);
			this.panelContenedor.TabIndex = 1;
			// 
			// ventasToolStripMenuItem
			// 
			this.ventasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarVentaToolStripMenuItem});
			this.ventasToolStripMenuItem.Name = "ventasToolStripMenuItem";
			this.ventasToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
			this.ventasToolStripMenuItem.Text = "Ventas";
			// 
			// generarVentaToolStripMenuItem
			// 
			this.generarVentaToolStripMenuItem.Name = "generarVentaToolStripMenuItem";
			this.generarVentaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.generarVentaToolStripMenuItem.Text = "Generar Venta";
			this.generarVentaToolStripMenuItem.Click += new System.EventHandler(this.generarVentaToolStripMenuItem_Click);
			// 
			// Principal
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(531, 448);
			this.Controls.Add(this.panelContenedor);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Principal";
			this.Text = "Principal";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem articulosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem creToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem rubrosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem nuevoRubroToolStripMenuItem;
		private System.Windows.Forms.Panel panelContenedor;
		private System.Windows.Forms.ToolStripMenuItem ventasToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem generarVentaToolStripMenuItem;
	}
}
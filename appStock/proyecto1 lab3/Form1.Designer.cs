namespace proyecto1_lab3
{
	partial class Form1
	{
		/// <summary>
		/// Variable del diseñador necesaria.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Limpiar los recursos que se estén usando.
		/// </summary>
		/// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Código generado por el Diseñador de Windows Forms

		/// <summary>
		/// Método necesario para admitir el Diseñador. No se puede modificar
		/// el contenido de este método con el editor de código.
		/// </summary>
		private void InitializeComponent()
		{
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.categoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txtNombre = new System.Windows.Forms.TextBox();
			this.txtCodigo = new System.Windows.Forms.TextBox();
			this.cmbCategoria = new System.Windows.Forms.ComboBox();
			this.btnbuscar = new System.Windows.Forms.Button();
			this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
			this.btnagregar = new System.Windows.Forms.Button();
			this.btnmodificar = new System.Windows.Forms.Button();
			this.btneliminar = new System.Windows.Forms.Button();
			this.lblAlerta = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.txtStock = new System.Windows.Forms.TextBox();
			this.txtDescripcion = new System.Windows.Forms.TextBox();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.menuStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.categoriaToolStripMenuItem,
            this.reportesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(800, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// archivoToolStripMenuItem
			// 
			this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salirToolStripMenuItem});
			this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
			this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
			this.archivoToolStripMenuItem.Text = "Archivo";
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(96, 22);
			this.salirToolStripMenuItem.Text = "Salir";
			// 
			// productosToolStripMenuItem
			// 
			this.productosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
			this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
			this.productosToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
			this.productosToolStripMenuItem.Text = "Productos";
			// 
			// agregarToolStripMenuItem
			// 
			this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
			this.agregarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.agregarToolStripMenuItem.Text = "Agregar";
			// 
			// modificarToolStripMenuItem
			// 
			this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
			this.modificarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.modificarToolStripMenuItem.Text = "Modificar";
			// 
			// eliminarToolStripMenuItem
			// 
			this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
			this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
			this.eliminarToolStripMenuItem.Text = "Eliminar";
			// 
			// categoriaToolStripMenuItem
			// 
			this.categoriaToolStripMenuItem.Name = "categoriaToolStripMenuItem";
			this.categoriaToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
			this.categoriaToolStripMenuItem.Text = "Categorias";
			// 
			// reportesToolStripMenuItem
			// 
			this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
			this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
			this.reportesToolStripMenuItem.Text = "Reportes";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 33);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Panel de Busqueda";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(44, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Nombre";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(14, 95);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 13);
			this.label3.TabIndex = 3;
			this.label3.Text = "Codigo";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(224, 127);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(52, 13);
			this.label4.TabIndex = 4;
			this.label4.Text = "Categoria";
			// 
			// txtNombre
			// 
			this.txtNombre.Location = new System.Drawing.Point(72, 55);
			this.txtNombre.Name = "txtNombre";
			this.txtNombre.Size = new System.Drawing.Size(100, 20);
			this.txtNombre.TabIndex = 5;
			// 
			// txtCodigo
			// 
			this.txtCodigo.Location = new System.Drawing.Point(72, 88);
			this.txtCodigo.Name = "txtCodigo";
			this.txtCodigo.Size = new System.Drawing.Size(100, 20);
			this.txtCodigo.TabIndex = 6;
			// 
			// cmbCategoria
			// 
			this.cmbCategoria.FormattingEnabled = true;
			this.cmbCategoria.Location = new System.Drawing.Point(293, 125);
			this.cmbCategoria.Name = "cmbCategoria";
			this.cmbCategoria.Size = new System.Drawing.Size(121, 21);
			this.cmbCategoria.TabIndex = 7;
			this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
			// 
			// btnbuscar
			// 
			this.btnbuscar.Location = new System.Drawing.Point(495, 78);
			this.btnbuscar.Name = "btnbuscar";
			this.btnbuscar.Size = new System.Drawing.Size(100, 30);
			this.btnbuscar.TabIndex = 8;
			this.btnbuscar.Text = "Buscar";
			this.btnbuscar.UseVisualStyleBackColor = true;
			this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click_1);
			// 
			// dataGridViewProductos
			// 
			this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewProductos.Location = new System.Drawing.Point(16, 164);
			this.dataGridViewProductos.Name = "dataGridViewProductos";
			this.dataGridViewProductos.Size = new System.Drawing.Size(644, 150);
			this.dataGridViewProductos.TabIndex = 9;
			this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Eleccion);
			// 
			// btnagregar
			// 
			this.btnagregar.Location = new System.Drawing.Point(53, 335);
			this.btnagregar.Name = "btnagregar";
			this.btnagregar.Size = new System.Drawing.Size(140, 40);
			this.btnagregar.TabIndex = 10;
			this.btnagregar.Text = "Agregar";
			this.btnagregar.UseVisualStyleBackColor = true;
			this.btnagregar.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnmodificar
			// 
			this.btnmodificar.Location = new System.Drawing.Point(268, 335);
			this.btnmodificar.Name = "btnmodificar";
			this.btnmodificar.Size = new System.Drawing.Size(140, 40);
			this.btnmodificar.TabIndex = 11;
			this.btnmodificar.Text = "Modificar";
			this.btnmodificar.UseVisualStyleBackColor = true;
			this.btnmodificar.Click += new System.EventHandler(this.btnmodificar_Click);
			// 
			// btneliminar
			// 
			this.btneliminar.Location = new System.Drawing.Point(484, 335);
			this.btneliminar.Name = "btneliminar";
			this.btneliminar.Size = new System.Drawing.Size(140, 40);
			this.btneliminar.TabIndex = 12;
			this.btneliminar.Text = "Eliminar";
			this.btneliminar.UseVisualStyleBackColor = true;
			this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
			// 
			// lblAlerta
			// 
			this.lblAlerta.AutoSize = true;
			this.lblAlerta.BackColor = System.Drawing.SystemColors.Highlight;
			this.lblAlerta.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblAlerta.Location = new System.Drawing.Point(274, 404);
			this.lblAlerta.Name = "lblAlerta";
			this.lblAlerta.Size = new System.Drawing.Size(125, 13);
			this.lblAlerta.TabIndex = 13;
			this.lblAlerta.Text = "Producto con Stock bajo";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(224, 62);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(35, 13);
			this.label6.TabIndex = 14;
			this.label6.Text = "Stock";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(224, 95);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(63, 13);
			this.label7.TabIndex = 15;
			this.label7.Text = "Descripcion";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(14, 127);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(37, 13);
			this.label8.TabIndex = 16;
			this.label8.Text = "Precio";
			// 
			// txtStock
			// 
			this.txtStock.Location = new System.Drawing.Point(293, 59);
			this.txtStock.Name = "txtStock";
			this.txtStock.Size = new System.Drawing.Size(100, 20);
			this.txtStock.TabIndex = 17;
			// 
			// txtDescripcion
			// 
			this.txtDescripcion.Location = new System.Drawing.Point(293, 92);
			this.txtDescripcion.Name = "txtDescripcion";
			this.txtDescripcion.Size = new System.Drawing.Size(100, 20);
			this.txtDescripcion.TabIndex = 18;
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(72, 125);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(100, 20);
			this.txtPrecio.TabIndex = 19;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.txtDescripcion);
			this.Controls.Add(this.txtStock);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.lblAlerta);
			this.Controls.Add(this.btneliminar);
			this.Controls.Add(this.btnmodificar);
			this.Controls.Add(this.btnagregar);
			this.Controls.Add(this.dataGridViewProductos);
			this.Controls.Add(this.btnbuscar);
			this.Controls.Add(this.cmbCategoria);
			this.Controls.Add(this.txtCodigo);
			this.Controls.Add(this.txtNombre);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem categoriaToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtNombre;
		private System.Windows.Forms.TextBox txtCodigo;
		private System.Windows.Forms.ComboBox cmbCategoria;
		private System.Windows.Forms.Button btnbuscar;
		private System.Windows.Forms.DataGridView dataGridViewProductos;
		private System.Windows.Forms.Button btnagregar;
		private System.Windows.Forms.Button btnmodificar;
		private System.Windows.Forms.Button btneliminar;
		private System.Windows.Forms.Label lblAlerta;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox txtStock;
		private System.Windows.Forms.TextBox txtDescripcion;
		private System.Windows.Forms.TextBox txtPrecio;
	}
}


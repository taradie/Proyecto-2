namespace Sistema_compras
{
    partial class frmMenuPrincipal
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
            this.inicioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSecionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impresorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.multiempresaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lineaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conceptosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.existenciasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraPendientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesDeCompraFacturadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuracionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baseDeDatosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearAlmacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idiomaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impuestosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicioToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.oComprasToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.configuracionesToolStripMenuItem,
            this.seguridadToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(595, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicioToolStripMenuItem
            // 
            this.inicioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSecionToolStripMenuItem,
            this.impresorasToolStripMenuItem,
            this.multiempresaToolStripMenuItem});
            this.inicioToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.brightness;
            this.inicioToolStripMenuItem.Name = "inicioToolStripMenuItem";
            this.inicioToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.inicioToolStripMenuItem.Text = "Inicio";
            // 
            // cerrarSecionToolStripMenuItem
            // 
            this.cerrarSecionToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.door_open;
            this.cerrarSecionToolStripMenuItem.Name = "cerrarSecionToolStripMenuItem";
            this.cerrarSecionToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.cerrarSecionToolStripMenuItem.Text = "Cerrar Secion";
            // 
            // impresorasToolStripMenuItem
            // 
            this.impresorasToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.printer;
            this.impresorasToolStripMenuItem.Name = "impresorasToolStripMenuItem";
            this.impresorasToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.impresorasToolStripMenuItem.Text = "Impresoras";
            // 
            // multiempresaToolStripMenuItem
            // 
            this.multiempresaToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.building;
            this.multiempresaToolStripMenuItem.Name = "multiempresaToolStripMenuItem";
            this.multiempresaToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.multiempresaToolStripMenuItem.Text = "Multiempresa";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.inventarioTotalToolStripMenuItem,
            this.marcaToolStripMenuItem,
            this.lineaToolStripMenuItem,
            this.conceptosToolStripMenuItem,
            this.existenciasToolStripMenuItem});
            this.inventarioToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.box_zipper;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.block;
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.productosToolStripMenuItem.Text = "Productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // inventarioTotalToolStripMenuItem
            // 
            this.inventarioTotalToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.truck_box;
            this.inventarioTotalToolStripMenuItem.Name = "inventarioTotalToolStripMenuItem";
            this.inventarioTotalToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.inventarioTotalToolStripMenuItem.Text = "Movimiento Inventario";
            this.inventarioTotalToolStripMenuItem.Click += new System.EventHandler(this.inventarioTotalToolStripMenuItem_Click);
            // 
            // marcaToolStripMenuItem
            // 
            this.marcaToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.price_tag;
            this.marcaToolStripMenuItem.Name = "marcaToolStripMenuItem";
            this.marcaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.marcaToolStripMenuItem.Text = "Marca";
            this.marcaToolStripMenuItem.Click += new System.EventHandler(this.marcaToolStripMenuItem_Click);
            // 
            // lineaToolStripMenuItem
            // 
            this.lineaToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.television;
            this.lineaToolStripMenuItem.Name = "lineaToolStripMenuItem";
            this.lineaToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.lineaToolStripMenuItem.Text = "Linea";
            this.lineaToolStripMenuItem.Click += new System.EventHandler(this.lineaToolStripMenuItem_Click);
            // 
            // conceptosToolStripMenuItem
            // 
            this.conceptosToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.blue_document__arrow;
            this.conceptosToolStripMenuItem.Name = "conceptosToolStripMenuItem";
            this.conceptosToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.conceptosToolStripMenuItem.Text = "Conceptos";
            this.conceptosToolStripMenuItem.Click += new System.EventHandler(this.conceptosToolStripMenuItem_Click);
            // 
            // existenciasToolStripMenuItem
            // 
            this.existenciasToolStripMenuItem.Name = "existenciasToolStripMenuItem";
            this.existenciasToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.existenciasToolStripMenuItem.Text = "Existencias";
            this.existenciasToolStripMenuItem.Click += new System.EventHandler(this.existenciasToolStripMenuItem_Click);
            // 
            // oComprasToolStripMenuItem
            // 
            this.oComprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ordenesDeCompraPendientesToolStripMenuItem,
            this.ordenesDeCompraFacturadasToolStripMenuItem});
            this.oComprasToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.money_bag_dollar;
            this.oComprasToolStripMenuItem.Name = "oComprasToolStripMenuItem";
            this.oComprasToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.oComprasToolStripMenuItem.Text = "Compras";
            this.oComprasToolStripMenuItem.Click += new System.EventHandler(this.oComprasToolStripMenuItem_Click);
            // 
            // ordenesDeCompraPendientesToolStripMenuItem
            // 
            this.ordenesDeCompraPendientesToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.document_number_0;
            this.ordenesDeCompraPendientesToolStripMenuItem.Name = "ordenesDeCompraPendientesToolStripMenuItem";
            this.ordenesDeCompraPendientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenesDeCompraPendientesToolStripMenuItem.Text = "Ordenes de Compra";
            this.ordenesDeCompraPendientesToolStripMenuItem.Click += new System.EventHandler(this.ordenesDeCompraPendientesToolStripMenuItem_Click);
            // 
            // ordenesDeCompraFacturadasToolStripMenuItem
            // 
            this.ordenesDeCompraFacturadasToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.user_thief;
            this.ordenesDeCompraFacturadasToolStripMenuItem.Name = "ordenesDeCompraFacturadasToolStripMenuItem";
            this.ordenesDeCompraFacturadasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenesDeCompraFacturadasToolStripMenuItem.Text = "Proveedores";
            this.ordenesDeCompraFacturadasToolStripMenuItem.Click += new System.EventHandler(this.ordenesDeCompraFacturadasToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.report;
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(81, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // configuracionesToolStripMenuItem
            // 
            this.configuracionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.monedaToolStripMenuItem,
            this.baseDeDatosToolStripMenuItem,
            this.crearAlmacenToolStripMenuItem,
            this.idiomaToolStripMenuItem,
            this.impuestosToolStripMenuItem});
            this.configuracionesToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.toolbox;
            this.configuracionesToolStripMenuItem.Name = "configuracionesToolStripMenuItem";
            this.configuracionesToolStripMenuItem.Size = new System.Drawing.Size(122, 20);
            this.configuracionesToolStripMenuItem.Text = "Configuraciones";
            // 
            // monedaToolStripMenuItem
            // 
            this.monedaToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.currency;
            this.monedaToolStripMenuItem.Name = "monedaToolStripMenuItem";
            this.monedaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.monedaToolStripMenuItem.Text = "Moneda";
            this.monedaToolStripMenuItem.Click += new System.EventHandler(this.monedaToolStripMenuItem_Click);
            // 
            // baseDeDatosToolStripMenuItem
            // 
            this.baseDeDatosToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.database;
            this.baseDeDatosToolStripMenuItem.Name = "baseDeDatosToolStripMenuItem";
            this.baseDeDatosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.baseDeDatosToolStripMenuItem.Text = "Base de Datos";
            this.baseDeDatosToolStripMenuItem.Click += new System.EventHandler(this.baseDeDatosToolStripMenuItem_Click);
            // 
            // crearAlmacenToolStripMenuItem
            // 
            this.crearAlmacenToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.home_medium;
            this.crearAlmacenToolStripMenuItem.Name = "crearAlmacenToolStripMenuItem";
            this.crearAlmacenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.crearAlmacenToolStripMenuItem.Text = "Almacen";
            this.crearAlmacenToolStripMenuItem.Click += new System.EventHandler(this.crearAlmacenToolStripMenuItem_Click);
            // 
            // idiomaToolStripMenuItem
            // 
            this.idiomaToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.balloon_buzz;
            this.idiomaToolStripMenuItem.Name = "idiomaToolStripMenuItem";
            this.idiomaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.idiomaToolStripMenuItem.Text = "Idioma";
            this.idiomaToolStripMenuItem.Click += new System.EventHandler(this.idiomaToolStripMenuItem_Click);
            // 
            // impuestosToolStripMenuItem
            // 
            this.impuestosToolStripMenuItem.Name = "impuestosToolStripMenuItem";
            this.impuestosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.impuestosToolStripMenuItem.Text = "Impuestos";
            this.impuestosToolStripMenuItem.Click += new System.EventHandler(this.impuestosToolStripMenuItem_Click);
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuariosToolStripMenuItem});
            this.seguridadToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources._lock;
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = global::Sistema_compras.Properties.Resources.question;
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.toolStripLabel2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(595, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel1.Text = "toolStripLabel1";
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(86, 22);
            this.toolStripLabel2.Text = "toolStripLabel2";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Click += new System.EventHandler(this.usuariosToolStripMenuItem_Click);
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Sistema_compras.Properties.Resources.logocompras2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(595, 400);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenuPrincipal";
            this.Text = "Menu Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeCompraPendientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesDeCompraFacturadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuracionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baseDeDatosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearAlmacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem idiomaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impuestosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lineaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inicioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSecionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impresorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem multiempresaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem conceptosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem existenciasToolStripMenuItem;
        public System.Windows.Forms.ToolStrip toolStrip1;
        public System.Windows.Forms.ToolStripLabel toolStripLabel1;
        public System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
    }
}


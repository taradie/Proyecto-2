namespace Sistema_compras
{
    partial class frmCreacionOc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCreacionOc));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtNit = new System.Windows.Forms.TextBox();
            this.txtUbicacion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.grupoFiltrar = new System.Windows.Forms.GroupBox();
            this.rbRecepcion = new System.Windows.Forms.RadioButton();
            this.rbRequisicion = new System.Windows.Forms.RadioButton();
            this.rbDevoluciones = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbProveedor = new System.Windows.Forms.ComboBox();
            this.Productos = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDisponibles = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblExistente = new System.Windows.Forms.Label();
            this.lblMinima = new System.Windows.Forms.Label();
            this.lblMaxima = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.grdProducto = new System.Windows.Forms.DataGridView();
            this.txtgrdCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtgrdNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtgrdCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtgrdPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtgrdTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.Tipo = new System.Windows.Forms.GroupBox();
            this.cmbImpuesto = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.rbOrdenCompra = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnFilProv = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grupoFiltrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.Productos.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).BeginInit();
            this.Tipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "NIT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Ubicacion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Telefono:";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(374, 19);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(306, 20);
            this.txtNombre.TabIndex = 10;
            // 
            // txtNit
            // 
            this.txtNit.Enabled = false;
            this.txtNit.Location = new System.Drawing.Point(110, 46);
            this.txtNit.Name = "txtNit";
            this.txtNit.Size = new System.Drawing.Size(157, 20);
            this.txtNit.TabIndex = 11;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.Enabled = false;
            this.txtUbicacion.Location = new System.Drawing.Point(374, 45);
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(306, 20);
            this.txtUbicacion.TabIndex = 12;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Location = new System.Drawing.Point(110, 74);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(157, 20);
            this.txtTelefono.TabIndex = 13;
            // 
            // grupoFiltrar
            // 
            this.grupoFiltrar.Controls.Add(this.rbRecepcion);
            this.grupoFiltrar.Controls.Add(this.rbRequisicion);
            this.grupoFiltrar.Controls.Add(this.rbDevoluciones);
            this.grupoFiltrar.Controls.Add(this.button2);
            this.grupoFiltrar.Controls.Add(this.btnRefrescar);
            this.grupoFiltrar.Controls.Add(this.btnCancelar);
            this.grupoFiltrar.Controls.Add(this.btnGuardar);
            this.grupoFiltrar.Controls.Add(this.btnEliminar);
            this.grupoFiltrar.Controls.Add(this.btnEditar);
            this.grupoFiltrar.Controls.Add(this.btnNuevo);
            this.grupoFiltrar.Controls.Add(this.panel1);
            this.grupoFiltrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grupoFiltrar.Location = new System.Drawing.Point(0, 0);
            this.grupoFiltrar.Name = "grupoFiltrar";
            this.grupoFiltrar.Size = new System.Drawing.Size(715, 61);
            this.grupoFiltrar.TabIndex = 40;
            this.grupoFiltrar.TabStop = false;
            this.grupoFiltrar.Text = "MENU";
            // 
            // rbRecepcion
            // 
            this.rbRecepcion.AutoSize = true;
            this.rbRecepcion.Location = new System.Drawing.Point(57, 19);
            this.rbRecepcion.Name = "rbRecepcion";
            this.rbRecepcion.Size = new System.Drawing.Size(88, 17);
            this.rbRecepcion.TabIndex = 1;
            this.rbRecepcion.TabStop = true;
            this.rbRecepcion.Text = "Recepciones";
            this.rbRecepcion.UseVisualStyleBackColor = true;
            // 
            // rbRequisicion
            // 
            this.rbRequisicion.AutoSize = true;
            this.rbRequisicion.Location = new System.Drawing.Point(612, 14);
            this.rbRequisicion.Name = "rbRequisicion";
            this.rbRequisicion.Size = new System.Drawing.Size(91, 17);
            this.rbRequisicion.TabIndex = 2;
            this.rbRequisicion.TabStop = true;
            this.rbRequisicion.Text = "Requisiciones";
            this.rbRequisicion.UseVisualStyleBackColor = true;
            // 
            // rbDevoluciones
            // 
            this.rbDevoluciones.AutoSize = true;
            this.rbDevoluciones.Location = new System.Drawing.Point(613, 37);
            this.rbDevoluciones.Name = "rbDevoluciones";
            this.rbDevoluciones.Size = new System.Drawing.Size(90, 17);
            this.rbDevoluciones.TabIndex = 3;
            this.rbDevoluciones.TabStop = true;
            this.rbDevoluciones.Text = "Deboluciones";
            this.rbDevoluciones.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 61);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 454);
            this.panel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilProv);
            this.groupBox1.Controls.Add(this.cmbProveedor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtNit);
            this.groupBox1.Controls.Add(this.txtUbicacion);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(6, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 100);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            this.cmbProveedor.FormattingEnabled = true;
            this.cmbProveedor.Location = new System.Drawing.Point(110, 19);
            this.cmbProveedor.Name = "cmbProveedor";
            this.cmbProveedor.Size = new System.Drawing.Size(157, 21);
            this.cmbProveedor.TabIndex = 3;
            this.cmbProveedor.SelectedValueChanged += new System.EventHandler(this.cmbProveedor_SelectedValueChanged);
            // 
            // Productos
            // 
            this.Productos.Controls.Add(this.groupBox2);
            this.Productos.Controls.Add(this.label10);
            this.Productos.Controls.Add(this.label9);
            this.Productos.Controls.Add(this.label7);
            this.Productos.Controls.Add(this.lblExistente);
            this.Productos.Controls.Add(this.lblMinima);
            this.Productos.Controls.Add(this.lblMaxima);
            this.Productos.Controls.Add(this.button3);
            this.Productos.Controls.Add(this.txtCantidad);
            this.Productos.Controls.Add(this.label8);
            this.Productos.Controls.Add(this.cmbProducto);
            this.Productos.Controls.Add(this.grdProducto);
            this.Productos.Controls.Add(this.label1);
            this.Productos.Controls.Add(this.btnAgregar);
            this.Productos.Location = new System.Drawing.Point(7, 212);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(700, 304);
            this.Productos.TabIndex = 42;
            this.Productos.TabStop = false;
            this.Productos.Text = "Pedido";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblDisponibles);
            this.groupBox2.Location = new System.Drawing.Point(542, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 55);
            this.groupBox2.TabIndex = 70;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Unidades que puede Ingresar:";
            // 
            // lblDisponibles
            // 
            this.lblDisponibles.AutoSize = true;
            this.lblDisponibles.Location = new System.Drawing.Point(35, 36);
            this.lblDisponibles.Name = "lblDisponibles";
            this.lblDisponibles.Size = new System.Drawing.Size(55, 13);
            this.lblDisponibles.TabIndex = 67;
            this.lblDisponibles.Text = "Existentes";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(399, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 13);
            this.label10.TabIndex = 69;
            this.label10.Text = "En Existencia:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 68;
            this.label9.Text = "Cantidad Minima:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(385, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 67;
            this.label7.Text = "Cantidad Maxima:";
            // 
            // lblExistente
            // 
            this.lblExistente.AutoSize = true;
            this.lblExistente.Location = new System.Drawing.Point(482, 55);
            this.lblExistente.Name = "lblExistente";
            this.lblExistente.Size = new System.Drawing.Size(55, 13);
            this.lblExistente.TabIndex = 66;
            this.lblExistente.Text = "Existentes";
            // 
            // lblMinima
            // 
            this.lblMinima.AutoSize = true;
            this.lblMinima.Location = new System.Drawing.Point(482, 35);
            this.lblMinima.Name = "lblMinima";
            this.lblMinima.Size = new System.Drawing.Size(49, 13);
            this.lblMinima.TabIndex = 65;
            this.lblMinima.Text = "Cant Min";
            // 
            // lblMaxima
            // 
            this.lblMaxima.AutoSize = true;
            this.lblMaxima.Location = new System.Drawing.Point(482, 16);
            this.lblMaxima.Name = "lblMaxima";
            this.lblMaxima.Size = new System.Drawing.Size(52, 13);
            this.lblMaxima.TabIndex = 63;
            this.lblMaxima.Text = "Cant Max";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(68, 52);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(92, 20);
            this.txtCantidad.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 55);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(52, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cantidad:";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(67, 25);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(252, 21);
            this.cmbProducto.TabIndex = 16;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // grdProducto
            // 
            this.grdProducto.AllowUserToAddRows = false;
            this.grdProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txtgrdCodigo,
            this.txtgrdNombre,
            this.txtgrdCantidad,
            this.txtgrdPrecio,
            this.txtgrdTotal});
            this.grdProducto.Location = new System.Drawing.Point(6, 90);
            this.grdProducto.Name = "grdProducto";
            this.grdProducto.ReadOnly = true;
            this.grdProducto.Size = new System.Drawing.Size(676, 200);
            this.grdProducto.TabIndex = 26;
            this.grdProducto.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdProducto_CellContentDoubleClick);
            // 
            // txtgrdCodigo
            // 
            this.txtgrdCodigo.HeaderText = "Codigo";
            this.txtgrdCodigo.Name = "txtgrdCodigo";
            this.txtgrdCodigo.ReadOnly = true;
            // 
            // txtgrdNombre
            // 
            this.txtgrdNombre.HeaderText = "Nombre";
            this.txtgrdNombre.Name = "txtgrdNombre";
            this.txtgrdNombre.ReadOnly = true;
            // 
            // txtgrdCantidad
            // 
            this.txtgrdCantidad.HeaderText = "Cantidad";
            this.txtgrdCantidad.Name = "txtgrdCantidad";
            this.txtgrdCantidad.ReadOnly = true;
            // 
            // txtgrdPrecio
            // 
            this.txtgrdPrecio.HeaderText = "Precio/Unitario";
            this.txtgrdPrecio.Name = "txtgrdPrecio";
            this.txtgrdPrecio.ReadOnly = true;
            // 
            // txtgrdTotal
            // 
            this.txtgrdTotal.HeaderText = "Total";
            this.txtgrdTotal.Name = "txtgrdTotal";
            this.txtgrdTotal.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Producto:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(270, 52);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(87, 32);
            this.btnAgregar.TabIndex = 25;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // Tipo
            // 
            this.Tipo.Controls.Add(this.button1);
            this.Tipo.Controls.Add(this.cmbImpuesto);
            this.Tipo.Controls.Add(this.label11);
            this.Tipo.Controls.Add(this.rbOrdenCompra);
            this.Tipo.Location = new System.Drawing.Point(7, 65);
            this.Tipo.Name = "Tipo";
            this.Tipo.Size = new System.Drawing.Size(700, 44);
            this.Tipo.TabIndex = 43;
            this.Tipo.TabStop = false;
            this.Tipo.Text = "Tipo de Documento";
            // 
            // cmbImpuesto
            // 
            this.cmbImpuesto.FormattingEnabled = true;
            this.cmbImpuesto.Location = new System.Drawing.Point(374, 20);
            this.cmbImpuesto.Name = "cmbImpuesto";
            this.cmbImpuesto.Size = new System.Drawing.Size(157, 21);
            this.cmbImpuesto.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(310, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Impuesto:";
            // 
            // rbOrdenCompra
            // 
            this.rbOrdenCompra.AutoSize = true;
            this.rbOrdenCompra.Location = new System.Drawing.Point(6, 19);
            this.rbOrdenCompra.Name = "rbOrdenCompra";
            this.rbOrdenCompra.Size = new System.Drawing.Size(108, 17);
            this.rbOrdenCompra.TabIndex = 0;
            this.rbOrdenCompra.TabStop = true;
            this.rbOrdenCompra.Text = "Orden de Compra";
            this.rbOrdenCompra.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Image = global::Sistema_compras.Properties.Resources.magnifier_zoom;
            this.button1.Location = new System.Drawing.Point(537, 21);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 23);
            this.button1.TabIndex = 63;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = global::Sistema_compras.Properties.Resources.magnifier_zoom;
            this.button3.Location = new System.Drawing.Point(330, 25);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 23);
            this.button3.TabIndex = 62;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFilProv
            // 
            this.btnFilProv.Image = global::Sistema_compras.Properties.Resources.magnifier_zoom;
            this.btnFilProv.Location = new System.Drawing.Point(272, 19);
            this.btnFilProv.Name = "btnFilProv";
            this.btnFilProv.Size = new System.Drawing.Size(27, 23);
            this.btnFilProv.TabIndex = 62;
            this.btnFilProv.UseVisualStyleBackColor = true;
            this.btnFilProv.Click += new System.EventHandler(this.btnFilProv_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(482, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(48, 42);
            this.button2.TabIndex = 23;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(431, 12);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(48, 42);
            this.btnRefrescar.TabIndex = 20;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(380, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 42);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(329, 12);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 42);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(278, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(48, 42);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(227, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(48, 42);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(176, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(48, 42);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // frmCreacionOc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 515);
            this.Controls.Add(this.Tipo);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grupoFiltrar);
            this.Name = "frmCreacionOc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creacion de Ordenes de compra";
            this.grupoFiltrar.ResumeLayout(false);
            this.grupoFiltrar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Productos.ResumeLayout(false);
            this.Productos.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdProducto)).EndInit();
            this.Tipo.ResumeLayout(false);
            this.Tipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtNit;
        private System.Windows.Forms.TextBox txtUbicacion;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.GroupBox grupoFiltrar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbProveedor;
        private System.Windows.Forms.GroupBox Productos;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.DataGridView grdProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.GroupBox Tipo;
        private System.Windows.Forms.RadioButton rbDevoluciones;
        private System.Windows.Forms.RadioButton rbRequisicion;
        private System.Windows.Forms.RadioButton rbRecepcion;
        private System.Windows.Forms.RadioButton rbOrdenCompra;
        private System.Windows.Forms.Button btnFilProv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label lblMinima;
        private System.Windows.Forms.Label lblMaxima;
        private System.Windows.Forms.Label lblExistente;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDisponibles;
        private System.Windows.Forms.ComboBox cmbImpuesto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtgrdCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtgrdNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtgrdCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtgrdPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn txtgrdTotal;
    }
}
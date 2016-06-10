namespace Sistema_compras
{
    partial class frmIngresoEgreso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoEgreso));
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grupoFiltrar = new System.Windows.Forms.GroupBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtmovimiento = new System.Windows.Forms.TextBox();
            this.txtproveedor = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmOC = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.txtestado = new System.Windows.Forms.TextBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.rbActivo = new System.Windows.Forms.RadioButton();
            this.rbInactivo = new System.Windows.Forms.RadioButton();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.txtTipoMov = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grdIngreso = new System.Windows.Forms.DataGridView();
            this.Almacen = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Nombre_Proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigo_Producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad_Compra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OrdenCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbProducto = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.txtnombreprovee = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.grupoFiltrar.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdIngreso)).BeginInit();
            this.groupBox7.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // helpProvider1
            // 
            this.helpProvider1.HelpNamespace = "C:\\Users\\Josue\\Desktop\\Sistema compras\\Sistema compras\\bin\\Debug\\Movimiento de In" +
    "ventarios.chm";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.grupoFiltrar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(796, 519);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ingreso";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grupoFiltrar
            // 
            this.grupoFiltrar.Controls.Add(this.txtnombreprovee);
            this.grupoFiltrar.Controls.Add(this.txtproveedor);
            this.grupoFiltrar.Controls.Add(this.txtmovimiento);
            this.grupoFiltrar.Controls.Add(this.button1);
            this.grupoFiltrar.Controls.Add(this.btnCancelar);
            this.grupoFiltrar.Controls.Add(this.btnGuardar);
            this.grupoFiltrar.Controls.Add(this.btnEliminar);
            this.grupoFiltrar.Controls.Add(this.btnEditar);
            this.grupoFiltrar.Controls.Add(this.btnNuevo);
            this.grupoFiltrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grupoFiltrar.Location = new System.Drawing.Point(3, 3);
            this.grupoFiltrar.Name = "grupoFiltrar";
            this.grupoFiltrar.Size = new System.Drawing.Size(790, 61);
            this.grupoFiltrar.TabIndex = 43;
            this.grupoFiltrar.TabStop = false;
            this.grupoFiltrar.Text = "MENU";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(211, 13);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(48, 42);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(262, 13);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(48, 42);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Enabled = false;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(313, 13);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(48, 42);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(364, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 42);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(415, 13);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 42);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(466, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 42);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtmovimiento
            // 
            this.txtmovimiento.Location = new System.Drawing.Point(741, 13);
            this.txtmovimiento.Name = "txtmovimiento";
            this.txtmovimiento.Size = new System.Drawing.Size(10, 20);
            this.txtmovimiento.TabIndex = 24;
            this.txtmovimiento.Visible = false;
            // 
            // txtproveedor
            // 
            this.txtproveedor.Location = new System.Drawing.Point(725, 13);
            this.txtproveedor.Name = "txtproveedor";
            this.txtproveedor.Size = new System.Drawing.Size(10, 20);
            this.txtproveedor.TabIndex = 25;
            this.txtproveedor.Visible = false;
            this.txtproveedor.TextChanged += new System.EventHandler(this.txtproveedor_TextChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTipoMov);
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.groupBox6);
            this.groupBox1.Controls.Add(this.txtestado);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.cmOC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtFactura);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(9, 70);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(778, 94);
            this.groupBox1.TabIndex = 44;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Principal";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Fecha Factura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "No. Documento:";
            // 
            // txtFactura
            // 
            this.txtFactura.Location = new System.Drawing.Point(96, 61);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(137, 20);
            this.txtFactura.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(116, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Tipo Movimiento:";
            // 
            // cmOC
            // 
            this.cmOC.FormattingEnabled = true;
            this.cmOC.Location = new System.Drawing.Point(205, 24);
            this.cmOC.Name = "cmOC";
            this.cmOC.Size = new System.Drawing.Size(137, 21);
            this.cmOC.TabIndex = 19;
            this.cmOC.SelectedIndexChanged += new System.EventHandler(this.cmOC_SelectedIndexChanged);
            this.cmOC.TextUpdate += new System.EventHandler(this.cmOC_TextUpdate);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(320, 61);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker1.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Descripción:";
            // 
            // txtestado
            // 
            this.txtestado.Location = new System.Drawing.Point(735, 25);
            this.txtestado.Name = "txtestado";
            this.txtestado.Size = new System.Drawing.Size(10, 20);
            this.txtestado.TabIndex = 45;
            this.txtestado.Text = "ACTIVO";
            this.txtestado.Visible = false;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.rbInactivo);
            this.groupBox6.Controls.Add(this.rbActivo);
            this.groupBox6.Location = new System.Drawing.Point(656, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(89, 67);
            this.groupBox6.TabIndex = 56;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Estado";
            // 
            // rbActivo
            // 
            this.rbActivo.AutoSize = true;
            this.rbActivo.Checked = true;
            this.rbActivo.Location = new System.Drawing.Point(6, 24);
            this.rbActivo.Name = "rbActivo";
            this.rbActivo.Size = new System.Drawing.Size(64, 17);
            this.rbActivo.TabIndex = 8;
            this.rbActivo.TabStop = true;
            this.rbActivo.Text = "ACTIVO";
            this.rbActivo.UseVisualStyleBackColor = true;
            this.rbActivo.CheckedChanged += new System.EventHandler(this.rbActivo_CheckedChanged);
            // 
            // rbInactivo
            // 
            this.rbInactivo.AutoSize = true;
            this.rbInactivo.Location = new System.Drawing.Point(6, 45);
            this.rbInactivo.Name = "rbInactivo";
            this.rbInactivo.Size = new System.Drawing.Size(75, 17);
            this.rbInactivo.TabIndex = 9;
            this.rbInactivo.TabStop = true;
            this.rbInactivo.Text = "INACTIVO";
            this.rbInactivo.UseVisualStyleBackColor = true;
            this.rbInactivo.CheckedChanged += new System.EventHandler(this.rbInactivo_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(477, 25);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(163, 58);
            this.richTextBox1.TabIndex = 57;
            this.richTextBox1.Text = "";
            // 
            // txtTipoMov
            // 
            this.txtTipoMov.Location = new System.Drawing.Point(757, 63);
            this.txtTipoMov.Name = "txtTipoMov";
            this.txtTipoMov.Size = new System.Drawing.Size(11, 20);
            this.txtTipoMov.TabIndex = 58;
            this.txtTipoMov.Text = "INGRESO";
            this.txtTipoMov.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdIngreso);
            this.groupBox2.Location = new System.Drawing.Point(12, 231);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 280);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Detalle Documento";
            // 
            // grdIngreso
            // 
            this.grdIngreso.AllowUserToAddRows = false;
            this.grdIngreso.AllowUserToDeleteRows = false;
            this.grdIngreso.AllowUserToOrderColumns = true;
            this.grdIngreso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdIngreso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OrdenCompra,
            this.Cantidad_Compra,
            this.Codigo_Producto,
            this.Nombre,
            this.Codigo_proveedor,
            this.Nombre_Proveedor,
            this.Almacen});
            this.grdIngreso.Location = new System.Drawing.Point(13, 19);
            this.grdIngreso.Name = "grdIngreso";
            this.grdIngreso.Size = new System.Drawing.Size(751, 235);
            this.grdIngreso.TabIndex = 6;
            //this.grdIngreso.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdIngreso_CellClick);
            //this.grdIngreso.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdIngreso_CellContentClick);
            // 
            // Almacen
            // 
            this.Almacen.HeaderText = "almacen";
            this.Almacen.Items.AddRange(new object[] {
            "almacen1"});
            this.Almacen.Name = "Almacen";
            // 
            // Nombre_Proveedor
            // 
            this.Nombre_Proveedor.HeaderText = "Proveedor";
            this.Nombre_Proveedor.Name = "Nombre_Proveedor";
            // 
            // Codigo_proveedor
            // 
            this.Codigo_proveedor.HeaderText = "Codigo Proveedor";
            this.Codigo_proveedor.Name = "Codigo_proveedor";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Producto";
            this.Nombre.Name = "Nombre";
            // 
            // Codigo_Producto
            // 
            this.Codigo_Producto.HeaderText = "Codigo del Producto";
            this.Codigo_Producto.Name = "Codigo_Producto";
            // 
            // Cantidad_Compra
            // 
            this.Cantidad_Compra.HeaderText = "Cantidad a Comprar";
            this.Cantidad_Compra.Name = "Cantidad_Compra";
            // 
            // OrdenCompra
            // 
            this.OrdenCompra.HeaderText = "Orden de Compra";
            this.OrdenCompra.Name = "OrdenCompra";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtcantidad);
            this.groupBox7.Controls.Add(this.label4);
            this.groupBox7.Controls.Add(this.btnAdd);
            this.groupBox7.Controls.Add(this.cmbProducto);
            this.groupBox7.Controls.Add(this.label3);
            this.groupBox7.Location = new System.Drawing.Point(12, 170);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(775, 55);
            this.groupBox7.TabIndex = 45;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Seleccion de Productos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Seleccionar Producto";
            // 
            // cmbProducto
            // 
            this.cmbProducto.FormattingEnabled = true;
            this.cmbProducto.Location = new System.Drawing.Point(162, 21);
            this.cmbProducto.Name = "cmbProducto";
            this.cmbProducto.Size = new System.Drawing.Size(167, 21);
            this.cmbProducto.TabIndex = 1;
            this.cmbProducto.SelectedIndexChanged += new System.EventHandler(this.cmbProducto_SelectedIndexChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(566, 19);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(104, 27);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Agregar Producto";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cantidad Producto";
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(434, 21);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 4;
            // 
            // txtnombreprovee
            // 
            this.txtnombreprovee.AcceptsReturn = true;
            this.txtnombreprovee.AcceptsTab = true;
            this.txtnombreprovee.Location = new System.Drawing.Point(757, 13);
            this.txtnombreprovee.Name = "txtnombreprovee";
            this.txtnombreprovee.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtnombreprovee.Size = new System.Drawing.Size(10, 20);
            this.txtnombreprovee.TabIndex = 46;
            this.txtnombreprovee.Visible = false;
            this.txtnombreprovee.TextChanged += new System.EventHandler(this.txtnombreprovee_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(3, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(804, 545);
            this.tabControl1.TabIndex = 0;
            // 
            // frmIngresoEgreso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 546);
            this.Controls.Add(this.tabControl1);
            this.Name = "frmIngresoEgreso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimiento de Inventarios";
            this.Load += new System.EventHandler(this.frmIngresoEgreso_Load);
            this.tabPage1.ResumeLayout(false);
            this.grupoFiltrar.ResumeLayout(false);
            this.grupoFiltrar.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdIngreso)).EndInit();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cmbProducto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.DataGridView grdIngreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrdenCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad_Compra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre_Proveedor;
        private System.Windows.Forms.DataGridViewComboBoxColumn Almacen;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtTipoMov;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox6;
        public System.Windows.Forms.RadioButton rbInactivo;
        public System.Windows.Forms.RadioButton rbActivo;
        public System.Windows.Forms.TextBox txtestado;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmOC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox grupoFiltrar;
        public System.Windows.Forms.TextBox txtnombreprovee;
        private System.Windows.Forms.TextBox txtproveedor;
        private System.Windows.Forms.TextBox txtmovimiento;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.TabControl tabControl1;
    }
}
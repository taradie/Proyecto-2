namespace PROTOTIPO_C.C
{
    partial class frmFacturaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grpDocumento = new System.Windows.Forms.GroupBox();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.grdPago = new System.Windows.Forms.DataGridView();
            this.TipoPago = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Referencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.nTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.cmbTipoTransaccion = new System.Windows.Forms.ComboBox();
            this.txtCodCliente = new System.Windows.Forms.TextBox();
            this.txtTipoTransaccion = new System.Windows.Forms.TextBox();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtSerie = new System.Windows.Forms.TextBox();
            this.txtCobrador = new System.Windows.Forms.TextBox();
            this.txtVendedor = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.txtSituacion = new System.Windows.Forms.TextBox();
            this.cmbMora = new System.Windows.Forms.ComboBox();
            this.txtMora = new System.Windows.Forms.TextBox();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.grpDocumento.SuspendLayout();
            this.grpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPago)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.btnRefrescar);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuardar);
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnNuevo);
            this.panel1.Location = new System.Drawing.Point(399, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 54);
            this.panel1.TabIndex = 62;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(338, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 42);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(285, 4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(48, 42);
            this.btnRefrescar.TabIndex = 10;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            this.btnRefrescar.Click += new System.EventHandler(this.btnRefrescar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(231, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 42);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(177, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(48, 42);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(123, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(48, 42);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(69, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(48, 42);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(15, 4);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(48, 42);
            this.btnNuevo.TabIndex = 5;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // grpDocumento
            // 
            this.grpDocumento.Controls.Add(this.lblCorreo);
            this.grpDocumento.Controls.Add(this.label8);
            this.grpDocumento.Controls.Add(this.lblTelefono);
            this.grpDocumento.Controls.Add(this.label6);
            this.grpDocumento.Controls.Add(this.lblDireccion);
            this.grpDocumento.Controls.Add(this.lblNombre);
            this.grpDocumento.Controls.Add(this.label4);
            this.grpDocumento.Controls.Add(this.label3);
            this.grpDocumento.Controls.Add(this.txtFecha);
            this.grpDocumento.Controls.Add(this.dateTimePicker1);
            this.grpDocumento.Controls.Add(this.label2);
            this.grpDocumento.Controls.Add(this.txtNoDocumento);
            this.grpDocumento.Controls.Add(this.label1);
            this.grpDocumento.Location = new System.Drawing.Point(77, 72);
            this.grpDocumento.Name = "grpDocumento";
            this.grpDocumento.Size = new System.Drawing.Size(1135, 156);
            this.grpDocumento.TabIndex = 63;
            this.grpDocumento.TabStop = false;
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(618, 112);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(35, 13);
            this.lblCorreo.TabIndex = 12;
            this.lblCorreo.Text = "labelp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(547, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Correo:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(199, 112);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(35, 13);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "labelp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(127, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Telefono:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(618, 80);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(35, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "labelp";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(199, 80);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(35, 13);
            this.lblNombre.TabIndex = 7;
            this.lblNombre.Text = "labelp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(127, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(547, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion:";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(827, 27);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(47, 20);
            this.txtFecha.TabIndex = 4;
            this.txtFecha.Tag = "fecha";
            this.txtFecha.Visible = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yyyy-MM-dd";
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(621, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(547, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // txtNoDocumento
            // 
            this.txtNoDocumento.Enabled = false;
            this.txtNoDocumento.Location = new System.Drawing.Point(157, 31);
            this.txtNoDocumento.Name = "txtNoDocumento";
            this.txtNoDocumento.Size = new System.Drawing.Size(77, 20);
            this.txtNoDocumento.TabIndex = 1;
            this.txtNoDocumento.Tag = "codencabezado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(127, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No.";
            // 
            // grpPago
            // 
            this.grpPago.Controls.Add(this.grdPago);
            this.grpPago.Location = new System.Drawing.Point(62, 265);
            this.grpPago.Name = "grpPago";
            this.grpPago.Size = new System.Drawing.Size(1150, 266);
            this.grpPago.TabIndex = 64;
            this.grpPago.TabStop = false;
            // 
            // grdPago
            // 
            this.grdPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoPago,
            this.Referencia,
            this.Monto,
            this.Check});
            this.grdPago.Location = new System.Drawing.Point(6, 19);
            this.grdPago.Name = "grdPago";
            this.grdPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPago.Size = new System.Drawing.Size(1123, 241);
            this.grdPago.TabIndex = 0;
            this.grdPago.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdPago_CellValueChanged);
            // 
            // TipoPago
            // 
            this.TipoPago.HeaderText = "TipoPago";
            this.TipoPago.Name = "TipoPago";
            // 
            // Referencia
            // 
            this.Referencia.DataPropertyName = "0";
            this.Referencia.HeaderText = "Referencia";
            this.Referencia.Name = "Referencia";
            // 
            // Monto
            // 
            this.Monto.HeaderText = "Monto";
            this.Monto.Name = "Monto";
            // 
            // Check
            // 
            this.Check.HeaderText = "Check";
            this.Check.Name = "Check";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(1103, 242);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 65;
            this.checkBox1.Text = "Todos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // nTotal
            // 
            this.nTotal.AutoSize = true;
            this.nTotal.Location = new System.Drawing.Point(1095, 535);
            this.nTotal.Name = "nTotal";
            this.nTotal.Size = new System.Drawing.Size(28, 13);
            this.nTotal.TabIndex = 67;
            this.nTotal.Text = "0.00";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(1058, 534);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 66;
            this.lblTotal.Text = "Total:";
            // 
            // cmbTipoTransaccion
            // 
            this.cmbTipoTransaccion.FormattingEnabled = true;
            this.cmbTipoTransaccion.Location = new System.Drawing.Point(12, 18);
            this.cmbTipoTransaccion.Name = "cmbTipoTransaccion";
            this.cmbTipoTransaccion.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoTransaccion.TabIndex = 68;
            this.cmbTipoTransaccion.Visible = false;
            // 
            // txtCodCliente
            // 
            this.txtCodCliente.Enabled = false;
            this.txtCodCliente.Location = new System.Drawing.Point(12, 71);
            this.txtCodCliente.Name = "txtCodCliente";
            this.txtCodCliente.Size = new System.Drawing.Size(51, 20);
            this.txtCodCliente.TabIndex = 70;
            this.txtCodCliente.Tag = "ncodcliente";
            this.txtCodCliente.Visible = false;
            // 
            // txtTipoTransaccion
            // 
            this.txtTipoTransaccion.Enabled = false;
            this.txtTipoTransaccion.Location = new System.Drawing.Point(12, 45);
            this.txtTipoTransaccion.Name = "txtTipoTransaccion";
            this.txtTipoTransaccion.Size = new System.Drawing.Size(51, 20);
            this.txtTipoTransaccion.TabIndex = 69;
            this.txtTipoTransaccion.Tag = "codigo_tipo_transaccion";
            this.txtTipoTransaccion.Visible = false;
            // 
            // txtCondicion
            // 
            this.txtCondicion.Enabled = false;
            this.txtCondicion.Location = new System.Drawing.Point(819, 39);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(47, 20);
            this.txtCondicion.TabIndex = 71;
            this.txtCondicion.Tag = "condicion";
            this.txtCondicion.Text = "ACTIVO";
            this.txtCondicion.Visible = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(819, 12);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(47, 20);
            this.txtEstado.TabIndex = 72;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Text = "ACTIVO";
            this.txtEstado.Visible = false;
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Enabled = false;
            this.txtTipoDocumento.Location = new System.Drawing.Point(77, 44);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(51, 20);
            this.txtTipoDocumento.TabIndex = 73;
            this.txtTipoDocumento.Tag = "codtipodocumento";
            this.txtTipoDocumento.Visible = false;
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(12, 97);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(51, 20);
            this.txtMonto.TabIndex = 74;
            this.txtMonto.Tag = "monto";
            this.txtMonto.Visible = false;
            // 
            // txtFactura
            // 
            this.txtFactura.Enabled = false;
            this.txtFactura.Location = new System.Drawing.Point(12, 123);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(51, 20);
            this.txtFactura.TabIndex = 75;
            this.txtFactura.Tag = "ncodfactura";
            this.txtFactura.Visible = false;
            // 
            // txtSerie
            // 
            this.txtSerie.Enabled = false;
            this.txtSerie.Location = new System.Drawing.Point(12, 152);
            this.txtSerie.Name = "txtSerie";
            this.txtSerie.Size = new System.Drawing.Size(51, 20);
            this.txtSerie.TabIndex = 76;
            this.txtSerie.Tag = "vserie";
            this.txtSerie.Visible = false;
            // 
            // txtCobrador
            // 
            this.txtCobrador.Enabled = false;
            this.txtCobrador.Location = new System.Drawing.Point(12, 178);
            this.txtCobrador.Name = "txtCobrador";
            this.txtCobrador.Size = new System.Drawing.Size(51, 20);
            this.txtCobrador.TabIndex = 77;
            this.txtCobrador.Tag = "codCobrador";
            this.txtCobrador.Visible = false;
            // 
            // txtVendedor
            // 
            this.txtVendedor.Enabled = false;
            this.txtVendedor.Location = new System.Drawing.Point(12, 204);
            this.txtVendedor.Name = "txtVendedor";
            this.txtVendedor.Size = new System.Drawing.Size(51, 20);
            this.txtVendedor.TabIndex = 78;
            this.txtVendedor.Tag = "codVendedor";
            this.txtVendedor.Visible = false;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Enabled = false;
            this.txtReferencia.Location = new System.Drawing.Point(12, 230);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(51, 20);
            this.txtReferencia.TabIndex = 79;
            this.txtReferencia.Tag = "referencia";
            this.txtReferencia.Visible = false;
            // 
            // txtSituacion
            // 
            this.txtSituacion.Enabled = false;
            this.txtSituacion.Location = new System.Drawing.Point(12, 256);
            this.txtSituacion.Name = "txtSituacion";
            this.txtSituacion.Size = new System.Drawing.Size(51, 20);
            this.txtSituacion.TabIndex = 80;
            this.txtSituacion.Tag = "situacion";
            this.txtSituacion.Text = "Cancelado";
            this.txtSituacion.Visible = false;
            // 
            // cmbMora
            // 
            this.cmbMora.FormattingEnabled = true;
            this.cmbMora.Location = new System.Drawing.Point(12, 282);
            this.cmbMora.Name = "cmbMora";
            this.cmbMora.Size = new System.Drawing.Size(49, 21);
            this.cmbMora.TabIndex = 81;
            this.cmbMora.Visible = false;
            this.cmbMora.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtMora
            // 
            this.txtMora.Enabled = false;
            this.txtMora.Location = new System.Drawing.Point(12, 309);
            this.txtMora.Name = "txtMora";
            this.txtMora.Size = new System.Drawing.Size(51, 20);
            this.txtMora.TabIndex = 82;
            this.txtMora.Tag = "codMora";
            this.txtMora.Visible = false;
            // 
            // txtEditar
            // 
            this.txtEditar.Enabled = false;
            this.txtEditar.Location = new System.Drawing.Point(10, 335);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(51, 20);
            this.txtEditar.TabIndex = 83;
            this.txtEditar.Tag = "saldo";
            this.txtEditar.Visible = false;
            // 
            // frmFacturaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 579);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.txtMora);
            this.Controls.Add(this.cmbMora);
            this.Controls.Add(this.txtSituacion);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.txtVendedor);
            this.Controls.Add(this.txtCobrador);
            this.Controls.Add(this.txtSerie);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.txtTipoDocumento);
            this.Controls.Add(this.txtCondicion);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCodCliente);
            this.Controls.Add(this.cmbTipoTransaccion);
            this.Controls.Add(this.nTotal);
            this.Controls.Add(this.txtTipoTransaccion);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.grpPago);
            this.Controls.Add(this.grpDocumento);
            this.Controls.Add(this.panel1);
            this.Name = "frmFacturaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFacturaCliente";
            this.panel1.ResumeLayout(false);
            this.grpDocumento.ResumeLayout(false);
            this.grpDocumento.PerformLayout();
            this.grpPago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grpDocumento;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grpPago;
        private System.Windows.Forms.DataGridView grdPago;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label nTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ComboBox cmbTipoTransaccion;
        private System.Windows.Forms.TextBox txtCodCliente;
        private System.Windows.Forms.TextBox txtTipoTransaccion;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.TextBox txtSerie;
        private System.Windows.Forms.TextBox txtCobrador;
        private System.Windows.Forms.TextBox txtVendedor;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox txtSituacion;
        private System.Windows.Forms.ComboBox cmbMora;
        private System.Windows.Forms.TextBox txtMora;
        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.DataGridViewComboBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Referencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
    }
}
namespace PROTOTIPO_C.C
{
    partial class frmFacturaProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacturaProveedor));
            this.grpDocumento = new System.Windows.Forms.GroupBox();
            this.lblCuenta = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoDocumento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.grpPago = new System.Windows.Forms.GroupBox();
            this.grdPago = new System.Windows.Forms.DataGridView();
            this.TipoPago = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Monto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txtCondicion = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.cmbTipoTransaccion = new System.Windows.Forms.ComboBox();
            this.txtTipoTransaccion = new System.Windows.Forms.TextBox();
            this.txtCodProveedor = new System.Windows.Forms.TextBox();
            this.txtTipoDocumento = new System.Windows.Forms.TextBox();
            this.txtFactura = new System.Windows.Forms.TextBox();
            this.txtEncabezado = new System.Windows.Forms.TextBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.nTotal = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtEditar = new System.Windows.Forms.TextBox();
            this.cmbSaldo = new System.Windows.Forms.ComboBox();
            this.txtSituacion = new System.Windows.Forms.TextBox();
            this.grpDocumento.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grpPago.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdPago)).BeginInit();
            this.SuspendLayout();
            // 
            // grpDocumento
            // 
            this.grpDocumento.Controls.Add(this.lblCuenta);
            this.grpDocumento.Controls.Add(this.label8);
            this.grpDocumento.Controls.Add(this.lblDescripcion);
            this.grpDocumento.Controls.Add(this.label6);
            this.grpDocumento.Controls.Add(this.lblDireccion);
            this.grpDocumento.Controls.Add(this.lblProveedor);
            this.grpDocumento.Controls.Add(this.label4);
            this.grpDocumento.Controls.Add(this.label3);
            this.grpDocumento.Controls.Add(this.txtFecha);
            this.grpDocumento.Controls.Add(this.dateTimePicker1);
            this.grpDocumento.Controls.Add(this.label2);
            this.grpDocumento.Controls.Add(this.txtNoDocumento);
            this.grpDocumento.Controls.Add(this.label1);
            this.grpDocumento.Location = new System.Drawing.Point(90, 95);
            this.grpDocumento.Name = "grpDocumento";
            this.grpDocumento.Size = new System.Drawing.Size(671, 156);
            this.grpDocumento.TabIndex = 0;
            this.grpDocumento.TabStop = false;
            // 
            // lblCuenta
            // 
            this.lblCuenta.AutoSize = true;
            this.lblCuenta.Location = new System.Drawing.Point(371, 112);
            this.lblCuenta.Name = "lblCuenta";
            this.lblCuenta.Size = new System.Drawing.Size(35, 13);
            this.lblCuenta.TabIndex = 12;
            this.lblCuenta.Text = "labelp";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(300, 112);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cuenta:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(131, 112);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(35, 13);
            this.lblDescripcion.TabIndex = 10;
            this.lblDescripcion.Text = "labelp";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(59, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Descripcion:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(371, 80);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(35, 13);
            this.lblDireccion.TabIndex = 8;
            this.lblDireccion.Text = "labelp";
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Location = new System.Drawing.Point(131, 80);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(35, 13);
            this.lblProveedor.TabIndex = 7;
            this.lblProveedor.Text = "labelp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(59, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Proveedor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(300, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Direccion:";
            // 
            // txtFecha
            // 
            this.txtFecha.Enabled = false;
            this.txtFecha.Location = new System.Drawing.Point(580, 27);
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
            this.dateTimePicker1.Location = new System.Drawing.Point(374, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(302, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fecha:";
            // 
            // txtNoDocumento
            // 
            this.txtNoDocumento.Enabled = false;
            this.txtNoDocumento.Location = new System.Drawing.Point(89, 31);
            this.txtNoDocumento.Name = "txtNoDocumento";
            this.txtNoDocumento.Size = new System.Drawing.Size(77, 20);
            this.txtNoDocumento.TabIndex = 1;
            this.txtNoDocumento.Tag = "codencabezado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "No.";
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
            this.panel1.Location = new System.Drawing.Point(232, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 54);
            this.panel1.TabIndex = 16;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(338, 5);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(48, 42);
            this.btnBuscar.TabIndex = 12;
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(285, 4);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(48, 42);
            this.btnRefrescar.TabIndex = 10;
            this.btnRefrescar.UseVisualStyleBackColor = true;
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
            // grpPago
            // 
            this.grpPago.Controls.Add(this.grdPago);
            this.grpPago.Location = new System.Drawing.Point(12, 274);
            this.grpPago.Name = "grpPago";
            this.grpPago.Size = new System.Drawing.Size(806, 266);
            this.grpPago.TabIndex = 17;
            this.grpPago.TabStop = false;
            this.grpPago.Enter += new System.EventHandler(this.grpPago_Enter);
            // 
            // grdPago
            // 
            this.grdPago.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPago.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoPago,
            this.Monto,
            this.Check});
            this.grdPago.Location = new System.Drawing.Point(19, 19);
            this.grdPago.Name = "grdPago";
            this.grdPago.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdPago.Size = new System.Drawing.Size(769, 241);
            this.grdPago.TabIndex = 0;
            // 
            // TipoPago
            // 
            this.TipoPago.HeaderText = "TipoPago";
            this.TipoPago.Name = "TipoPago";
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
            // txtCondicion
            // 
            this.txtCondicion.Enabled = false;
            this.txtCondicion.Location = new System.Drawing.Point(644, 50);
            this.txtCondicion.Name = "txtCondicion";
            this.txtCondicion.Size = new System.Drawing.Size(47, 20);
            this.txtCondicion.TabIndex = 5;
            this.txtCondicion.Tag = "condicion";
            this.txtCondicion.Text = "ACTIVO";
            this.txtCondicion.Visible = false;
            // 
            // txtEstado
            // 
            this.txtEstado.Enabled = false;
            this.txtEstado.Location = new System.Drawing.Point(644, 23);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(47, 20);
            this.txtEstado.TabIndex = 6;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Text = "ACTIVO";
            this.txtEstado.Visible = false;
            // 
            // cmbTipoTransaccion
            // 
            this.cmbTipoTransaccion.FormattingEnabled = true;
            this.cmbTipoTransaccion.Location = new System.Drawing.Point(12, 12);
            this.cmbTipoTransaccion.Name = "cmbTipoTransaccion";
            this.cmbTipoTransaccion.Size = new System.Drawing.Size(121, 21);
            this.cmbTipoTransaccion.TabIndex = 19;
            this.cmbTipoTransaccion.Visible = false;
            // 
            // txtTipoTransaccion
            // 
            this.txtTipoTransaccion.Enabled = false;
            this.txtTipoTransaccion.Location = new System.Drawing.Point(12, 35);
            this.txtTipoTransaccion.Name = "txtTipoTransaccion";
            this.txtTipoTransaccion.Size = new System.Drawing.Size(51, 20);
            this.txtTipoTransaccion.TabIndex = 20;
            this.txtTipoTransaccion.Tag = "codigo_tipo_transaccion";
            this.txtTipoTransaccion.Visible = false;
            // 
            // txtCodProveedor
            // 
            this.txtCodProveedor.Enabled = false;
            this.txtCodProveedor.Location = new System.Drawing.Point(12, 61);
            this.txtCodProveedor.Name = "txtCodProveedor";
            this.txtCodProveedor.Size = new System.Drawing.Size(51, 20);
            this.txtCodProveedor.TabIndex = 21;
            this.txtCodProveedor.Tag = "codproveedor";
            this.txtCodProveedor.Visible = false;
            // 
            // txtTipoDocumento
            // 
            this.txtTipoDocumento.Enabled = false;
            this.txtTipoDocumento.Location = new System.Drawing.Point(69, 35);
            this.txtTipoDocumento.Name = "txtTipoDocumento";
            this.txtTipoDocumento.Size = new System.Drawing.Size(51, 20);
            this.txtTipoDocumento.TabIndex = 22;
            this.txtTipoDocumento.Tag = "codtipodocumento";
            this.txtTipoDocumento.Visible = false;
            // 
            // txtFactura
            // 
            this.txtFactura.Enabled = false;
            this.txtFactura.Location = new System.Drawing.Point(69, 61);
            this.txtFactura.Name = "txtFactura";
            this.txtFactura.Size = new System.Drawing.Size(51, 20);
            this.txtFactura.TabIndex = 23;
            this.txtFactura.Tag = "codfacturaprov";
            this.txtFactura.Visible = false;
            // 
            // txtEncabezado
            // 
            this.txtEncabezado.Enabled = false;
            this.txtEncabezado.Location = new System.Drawing.Point(12, 87);
            this.txtEncabezado.Name = "txtEncabezado";
            this.txtEncabezado.Size = new System.Drawing.Size(51, 20);
            this.txtEncabezado.TabIndex = 24;
            this.txtEncabezado.Tag = "codencabezado";
            this.txtEncabezado.Visible = false;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(499, 553);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total:";
            // 
            // nTotal
            // 
            this.nTotal.AutoSize = true;
            this.nTotal.Location = new System.Drawing.Point(536, 554);
            this.nTotal.Name = "nTotal";
            this.nTotal.Size = new System.Drawing.Size(28, 13);
            this.nTotal.TabIndex = 26;
            this.nTotal.Text = "0.00";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(660, 261);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(56, 17);
            this.checkBox1.TabIndex = 27;
            this.checkBox1.Text = "Todos";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckStateChanged += new System.EventHandler(this.checkBox1_CheckStateChanged);
            // 
            // txtMonto
            // 
            this.txtMonto.Enabled = false;
            this.txtMonto.Location = new System.Drawing.Point(12, 113);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(51, 20);
            this.txtMonto.TabIndex = 28;
            this.txtMonto.Tag = "monto";
            this.txtMonto.Visible = false;
            // 
            // txtEditar
            // 
            this.txtEditar.Enabled = false;
            this.txtEditar.Location = new System.Drawing.Point(12, 139);
            this.txtEditar.Name = "txtEditar";
            this.txtEditar.Size = new System.Drawing.Size(51, 20);
            this.txtEditar.TabIndex = 29;
            this.txtEditar.Tag = "saldo";
            this.txtEditar.Visible = false;
            // 
            // cmbSaldo
            // 
            this.cmbSaldo.FormattingEnabled = true;
            this.cmbSaldo.Location = new System.Drawing.Point(121, 36);
            this.cmbSaldo.Name = "cmbSaldo";
            this.cmbSaldo.Size = new System.Drawing.Size(71, 21);
            this.cmbSaldo.TabIndex = 30;
            this.cmbSaldo.Visible = false;
            // 
            // txtSituacion
            // 
            this.txtSituacion.Enabled = false;
            this.txtSituacion.Location = new System.Drawing.Point(12, 172);
            this.txtSituacion.Name = "txtSituacion";
            this.txtSituacion.Size = new System.Drawing.Size(51, 20);
            this.txtSituacion.TabIndex = 31;
            this.txtSituacion.Tag = "situacion";
            this.txtSituacion.Text = "Cancelado";
            this.txtSituacion.Visible = false;
            // 
            // frmFacturaProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 579);
            this.Controls.Add(this.txtSituacion);
            this.Controls.Add(this.cmbSaldo);
            this.Controls.Add(this.txtEditar);
            this.Controls.Add(this.txtMonto);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.nTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.txtEncabezado);
            this.Controls.Add(this.txtFactura);
            this.Controls.Add(this.txtTipoDocumento);
            this.Controls.Add(this.txtCodProveedor);
            this.Controls.Add(this.txtTipoTransaccion);
            this.Controls.Add(this.cmbTipoTransaccion);
            this.Controls.Add(this.txtCondicion);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.grpPago);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.grpDocumento);
            this.Name = "frmFacturaProveedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmFacturaProveedor";
            this.grpDocumento.ResumeLayout(false);
            this.grpDocumento.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.grpPago.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdPago)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpDocumento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoDocumento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.GroupBox grpPago;
        private System.Windows.Forms.DataGridView grdPago;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.TextBox txtCondicion;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewComboBoxColumn TipoPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn Monto;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Check;
        private System.Windows.Forms.ComboBox cmbTipoTransaccion;
        private System.Windows.Forms.TextBox txtTipoTransaccion;
        private System.Windows.Forms.TextBox txtCodProveedor;
        private System.Windows.Forms.TextBox txtTipoDocumento;
        private System.Windows.Forms.TextBox txtFactura;
        private System.Windows.Forms.TextBox txtEncabezado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label nTotal;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtEditar;
        private System.Windows.Forms.ComboBox cmbSaldo;
        private System.Windows.Forms.TextBox txtSituacion;
    }
}
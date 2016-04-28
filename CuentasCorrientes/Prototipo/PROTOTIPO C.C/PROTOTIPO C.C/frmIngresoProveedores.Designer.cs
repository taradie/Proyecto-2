namespace PROTOTIPO_C.C
{
    partial class frmIngresoProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIngresoProveedores));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lblNombreProveedor = new System.Windows.Forms.Label();
            this.lblDireccionProveedor = new System.Windows.Forms.Label();
            this.lblTelefonoProveedor = new System.Windows.Forms.Label();
            this.lblDescripcionProveedor = new System.Windows.Forms.Label();
            this.lblNit = new System.Windows.Forms.Label();
            this.lblCuentaProveedor = new System.Windows.Forms.Label();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.txtDireccionProveedor = new System.Windows.Forms.TextBox();
            this.txtTelefonoProveedor = new System.Windows.Forms.TextBox();
            this.txtDescripcionProveedor = new System.Windows.Forms.TextBox();
            this.txtNitProveedor = new System.Windows.Forms.TextBox();
            this.txtCuentaProveedor = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(226, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 54);
            this.panel1.TabIndex = 14;
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
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(69, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(48, 42);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
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
            // lblNombreProveedor
            // 
            this.lblNombreProveedor.AutoSize = true;
            this.lblNombreProveedor.Location = new System.Drawing.Point(67, 113);
            this.lblNombreProveedor.Name = "lblNombreProveedor";
            this.lblNombreProveedor.Size = new System.Drawing.Size(44, 13);
            this.lblNombreProveedor.TabIndex = 15;
            this.lblNombreProveedor.Text = "Nombre";
            // 
            // lblDireccionProveedor
            // 
            this.lblDireccionProveedor.AutoSize = true;
            this.lblDireccionProveedor.Location = new System.Drawing.Point(451, 113);
            this.lblDireccionProveedor.Name = "lblDireccionProveedor";
            this.lblDireccionProveedor.Size = new System.Drawing.Size(52, 13);
            this.lblDireccionProveedor.TabIndex = 16;
            this.lblDireccionProveedor.Text = "Direccion";
            // 
            // lblTelefonoProveedor
            // 
            this.lblTelefonoProveedor.AutoSize = true;
            this.lblTelefonoProveedor.Location = new System.Drawing.Point(67, 162);
            this.lblTelefonoProveedor.Name = "lblTelefonoProveedor";
            this.lblTelefonoProveedor.Size = new System.Drawing.Size(49, 13);
            this.lblTelefonoProveedor.TabIndex = 17;
            this.lblTelefonoProveedor.Text = "Telefono";
            // 
            // lblDescripcionProveedor
            // 
            this.lblDescripcionProveedor.AutoSize = true;
            this.lblDescripcionProveedor.Location = new System.Drawing.Point(451, 162);
            this.lblDescripcionProveedor.Name = "lblDescripcionProveedor";
            this.lblDescripcionProveedor.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcionProveedor.TabIndex = 18;
            this.lblDescripcionProveedor.Text = "Descripcion";
            // 
            // lblNit
            // 
            this.lblNit.AutoSize = true;
            this.lblNit.Location = new System.Drawing.Point(67, 203);
            this.lblNit.Name = "lblNit";
            this.lblNit.Size = new System.Drawing.Size(20, 13);
            this.lblNit.TabIndex = 19;
            this.lblNit.Text = "Nit";
            // 
            // lblCuentaProveedor
            // 
            this.lblCuentaProveedor.AutoSize = true;
            this.lblCuentaProveedor.Location = new System.Drawing.Point(451, 203);
            this.lblCuentaProveedor.Name = "lblCuentaProveedor";
            this.lblCuentaProveedor.Size = new System.Drawing.Size(61, 13);
            this.lblCuentaProveedor.TabIndex = 20;
            this.lblCuentaProveedor.Text = "No. Cuenta";
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.Enabled = false;
            this.txtNombreProveedor.Location = new System.Drawing.Point(128, 110);
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(255, 20);
            this.txtNombreProveedor.TabIndex = 21;
            this.txtNombreProveedor.Tag = "nombre";
            // 
            // txtDireccionProveedor
            // 
            this.txtDireccionProveedor.Enabled = false;
            this.txtDireccionProveedor.Location = new System.Drawing.Point(520, 110);
            this.txtDireccionProveedor.Name = "txtDireccionProveedor";
            this.txtDireccionProveedor.Size = new System.Drawing.Size(227, 20);
            this.txtDireccionProveedor.TabIndex = 22;
            this.txtDireccionProveedor.Tag = "direccion";
            // 
            // txtTelefonoProveedor
            // 
            this.txtTelefonoProveedor.Enabled = false;
            this.txtTelefonoProveedor.Location = new System.Drawing.Point(128, 159);
            this.txtTelefonoProveedor.Name = "txtTelefonoProveedor";
            this.txtTelefonoProveedor.Size = new System.Drawing.Size(255, 20);
            this.txtTelefonoProveedor.TabIndex = 23;
            this.txtTelefonoProveedor.Tag = "telefono";
            // 
            // txtDescripcionProveedor
            // 
            this.txtDescripcionProveedor.Enabled = false;
            this.txtDescripcionProveedor.Location = new System.Drawing.Point(520, 159);
            this.txtDescripcionProveedor.Name = "txtDescripcionProveedor";
            this.txtDescripcionProveedor.Size = new System.Drawing.Size(227, 20);
            this.txtDescripcionProveedor.TabIndex = 24;
            this.txtDescripcionProveedor.Tag = "descripcion";
            // 
            // txtNitProveedor
            // 
            this.txtNitProveedor.Enabled = false;
            this.txtNitProveedor.Location = new System.Drawing.Point(128, 200);
            this.txtNitProveedor.Name = "txtNitProveedor";
            this.txtNitProveedor.Size = new System.Drawing.Size(255, 20);
            this.txtNitProveedor.TabIndex = 25;
            this.txtNitProveedor.Tag = "nit";
            // 
            // txtCuentaProveedor
            // 
            this.txtCuentaProveedor.Enabled = false;
            this.txtCuentaProveedor.Location = new System.Drawing.Point(520, 200);
            this.txtCuentaProveedor.Name = "txtCuentaProveedor";
            this.txtCuentaProveedor.Size = new System.Drawing.Size(227, 20);
            this.txtCuentaProveedor.TabIndex = 26;
            this.txtCuentaProveedor.Tag = "cuenta";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(614, 73);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(41, 20);
            this.txtEstado.TabIndex = 29;
            this.txtEstado.Tag = "estado";
            this.txtEstado.Text = "ACTIVO";
            this.txtEstado.Visible = false;
            // 
            // frmIngresoProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 256);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCuentaProveedor);
            this.Controls.Add(this.txtNitProveedor);
            this.Controls.Add(this.txtDescripcionProveedor);
            this.Controls.Add(this.txtTelefonoProveedor);
            this.Controls.Add(this.txtDireccionProveedor);
            this.Controls.Add(this.txtNombreProveedor);
            this.Controls.Add(this.lblCuentaProveedor);
            this.Controls.Add(this.lblNit);
            this.Controls.Add(this.lblDescripcionProveedor);
            this.Controls.Add(this.lblTelefonoProveedor);
            this.Controls.Add(this.lblDireccionProveedor);
            this.Controls.Add(this.lblNombreProveedor);
            this.Controls.Add(this.panel1);
            this.Name = "frmIngresoProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso Proveedores";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Label lblNombreProveedor;
        private System.Windows.Forms.Label lblDireccionProveedor;
        private System.Windows.Forms.Label lblTelefonoProveedor;
        private System.Windows.Forms.Label lblDescripcionProveedor;
        private System.Windows.Forms.Label lblNit;
        private System.Windows.Forms.Label lblCuentaProveedor;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.TextBox txtDireccionProveedor;
        private System.Windows.Forms.TextBox txtTelefonoProveedor;
        private System.Windows.Forms.TextBox txtDescripcionProveedor;
        private System.Windows.Forms.TextBox txtNitProveedor;
        private System.Windows.Forms.TextBox txtCuentaProveedor;
        private System.Windows.Forms.TextBox txtEstado;
    }
}
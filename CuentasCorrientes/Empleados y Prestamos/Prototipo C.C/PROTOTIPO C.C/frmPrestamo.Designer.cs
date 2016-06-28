namespace PROTOTIPO_C.C
{
    partial class frmPrestamo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrestamo));
            this.grupoFiltrar = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefrescar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.txtInteres = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numPagos = new System.Windows.Forms.NumericUpDown();
            this.cmbEmpleados = new System.Windows.Forms.ComboBox();
            this.btnFiltrado = new System.Windows.Forms.Button();
            this.cmbCod = new System.Windows.Forms.ComboBox();
            this.grpPlazo = new System.Windows.Forms.GroupBox();
            this.rdMes = new System.Windows.Forms.RadioButton();
            this.rd15Dias = new System.Windows.Forms.RadioButton();
            this.grupoFiltrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numPagos)).BeginInit();
            this.grpPlazo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grupoFiltrar
            // 
            this.grupoFiltrar.Controls.Add(this.button1);
            this.grupoFiltrar.Controls.Add(this.btnRefrescar);
            this.grupoFiltrar.Controls.Add(this.btnCancelar);
            this.grupoFiltrar.Controls.Add(this.btnGuardar);
            this.grupoFiltrar.Controls.Add(this.btnEliminar);
            this.grupoFiltrar.Controls.Add(this.btnEditar);
            this.grupoFiltrar.Controls.Add(this.btnNuevo);
            this.grupoFiltrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.grupoFiltrar.Location = new System.Drawing.Point(0, 0);
            this.grupoFiltrar.Name = "grupoFiltrar";
            this.grupoFiltrar.Size = new System.Drawing.Size(631, 61);
            this.grupoFiltrar.TabIndex = 74;
            this.grupoFiltrar.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(453, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 42);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnRefrescar
            // 
            this.btnRefrescar.Image = ((System.Drawing.Image)(resources.GetObject("btnRefrescar.Image")));
            this.btnRefrescar.Location = new System.Drawing.Point(401, 12);
            this.btnRefrescar.Name = "btnRefrescar";
            this.btnRefrescar.Size = new System.Drawing.Size(48, 42);
            this.btnRefrescar.TabIndex = 20;
            this.btnRefrescar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(350, 12);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(48, 42);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(299, 12);
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
            this.btnEliminar.Location = new System.Drawing.Point(248, 12);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(49, 42);
            this.btnEliminar.TabIndex = 17;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Enabled = false;
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.Location = new System.Drawing.Point(197, 12);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(49, 42);
            this.btnEditar.TabIndex = 16;
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(146, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(49, 42);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(331, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 17);
            this.label3.TabIndex = 75;
            this.label3.Text = "Fecha:";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(101, 154);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(200, 25);
            this.txtTotal.TabIndex = 78;
            this.txtTotal.Tag = "total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 77;
            this.label1.Text = "Total:";
            // 
            // dtFecha
            // 
            this.dtFecha.CustomFormat = "yyyy-MM-dd";
            this.dtFecha.Enabled = false;
            this.dtFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFecha.Location = new System.Drawing.Point(401, 67);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 79;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 80;
            this.label2.Text = "Pagos:";
            // 
            // txtInteres
            // 
            this.txtInteres.Enabled = false;
            this.txtInteres.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInteres.Location = new System.Drawing.Point(401, 157);
            this.txtInteres.Name = "txtInteres";
            this.txtInteres.Size = new System.Drawing.Size(200, 25);
            this.txtInteres.TabIndex = 83;
            this.txtInteres.Tag = "interes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(321, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "Interes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(21, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 17);
            this.label5.TabIndex = 84;
            this.label5.Text = "Empleado:";
            // 
            // numPagos
            // 
            this.numPagos.Enabled = false;
            this.numPagos.Location = new System.Drawing.Point(101, 204);
            this.numPagos.Name = "numPagos";
            this.numPagos.Size = new System.Drawing.Size(120, 20);
            this.numPagos.TabIndex = 86;
            this.numPagos.Tag = "pagos";
            // 
            // cmbEmpleados
            // 
            this.cmbEmpleados.Enabled = false;
            this.cmbEmpleados.FormattingEnabled = true;
            this.cmbEmpleados.Location = new System.Drawing.Point(106, 110);
            this.cmbEmpleados.Name = "cmbEmpleados";
            this.cmbEmpleados.Size = new System.Drawing.Size(292, 21);
            this.cmbEmpleados.TabIndex = 87;
            // 
            // btnFiltrado
            // 
            this.btnFiltrado.Image = ((System.Drawing.Image)(resources.GetObject("btnFiltrado.Image")));
            this.btnFiltrado.Location = new System.Drawing.Point(404, 108);
            this.btnFiltrado.Name = "btnFiltrado";
            this.btnFiltrado.Size = new System.Drawing.Size(32, 23);
            this.btnFiltrado.TabIndex = 88;
            this.btnFiltrado.UseVisualStyleBackColor = true;
            this.btnFiltrado.Click += new System.EventHandler(this.btnFiltrado_Click);
            // 
            // cmbCod
            // 
            this.cmbCod.FormattingEnabled = true;
            this.cmbCod.Location = new System.Drawing.Point(264, 202);
            this.cmbCod.Name = "cmbCod";
            this.cmbCod.Size = new System.Drawing.Size(33, 21);
            this.cmbCod.TabIndex = 89;
            this.cmbCod.Visible = false;
            // 
            // grpPlazo
            // 
            this.grpPlazo.Controls.Add(this.rdMes);
            this.grpPlazo.Controls.Add(this.rd15Dias);
            this.grpPlazo.Location = new System.Drawing.Point(324, 193);
            this.grpPlazo.Name = "grpPlazo";
            this.grpPlazo.Size = new System.Drawing.Size(277, 48);
            this.grpPlazo.TabIndex = 90;
            this.grpPlazo.TabStop = false;
            this.grpPlazo.Text = "Plazo";
            // 
            // rdMes
            // 
            this.rdMes.AutoSize = true;
            this.rdMes.Location = new System.Drawing.Point(147, 19);
            this.rdMes.Name = "rdMes";
            this.rdMes.Size = new System.Drawing.Size(65, 17);
            this.rdMes.TabIndex = 1;
            this.rdMes.TabStop = true;
            this.rdMes.Text = "Mensual";
            this.rdMes.UseVisualStyleBackColor = true;
            // 
            // rd15Dias
            // 
            this.rd15Dias.AutoSize = true;
            this.rd15Dias.Location = new System.Drawing.Point(39, 19);
            this.rd15Dias.Name = "rd15Dias";
            this.rd15Dias.Size = new System.Drawing.Size(73, 17);
            this.rd15Dias.TabIndex = 0;
            this.rd15Dias.TabStop = true;
            this.rd15Dias.Text = "Quincenal";
            this.rd15Dias.UseVisualStyleBackColor = true;
            // 
            // frmPrestamo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 252);
            this.Controls.Add(this.grpPlazo);
            this.Controls.Add(this.cmbCod);
            this.Controls.Add(this.btnFiltrado);
            this.Controls.Add(this.cmbEmpleados);
            this.Controls.Add(this.numPagos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtInteres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grupoFiltrar);
            this.Name = "frmPrestamo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamo";
            this.grupoFiltrar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numPagos)).EndInit();
            this.grpPlazo.ResumeLayout(false);
            this.grpPlazo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grupoFiltrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefrescar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuardar;
        public System.Windows.Forms.Button btnEliminar;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtInteres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPagos;
        private System.Windows.Forms.ComboBox cmbEmpleados;
        private System.Windows.Forms.Button btnFiltrado;
        private System.Windows.Forms.ComboBox cmbCod;
        private System.Windows.Forms.GroupBox grpPlazo;
        private System.Windows.Forms.RadioButton rdMes;
        private System.Windows.Forms.RadioButton rd15Dias;
    }
}
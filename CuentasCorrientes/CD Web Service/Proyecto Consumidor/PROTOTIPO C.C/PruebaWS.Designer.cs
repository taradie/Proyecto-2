namespace PROTOTIPO_C.C
{
    partial class PruebaWS
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbDatos = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbCliente = new System.Windows.Forms.RadioButton();
            this.rbProveedores = new System.Windows.Forms.RadioButton();
            this.rbEmpleados = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.cbTodos = new System.Windows.Forms.CheckBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPendiente = new System.Windows.Forms.Label();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.nTotal = new System.Windows.Forms.Label();
            this.nTotalPendiente = new System.Windows.Forms.Label();
            this.nDiferencia = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 168);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(874, 291);
            this.dataGridView1.TabIndex = 0;
            // 
            // cmbDatos
            // 
            this.cmbDatos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDatos.FormattingEnabled = true;
            this.cmbDatos.Location = new System.Drawing.Point(489, 80);
            this.cmbDatos.Name = "cmbDatos";
            this.cmbDatos.Size = new System.Drawing.Size(257, 21);
            this.cmbDatos.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEmpleados);
            this.groupBox1.Controls.Add(this.rbProveedores);
            this.groupBox1.Controls.Add(this.rbCliente);
            this.groupBox1.Location = new System.Drawing.Point(250, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 114);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // rbCliente
            // 
            this.rbCliente.AutoSize = true;
            this.rbCliente.Location = new System.Drawing.Point(25, 26);
            this.rbCliente.Name = "rbCliente";
            this.rbCliente.Size = new System.Drawing.Size(62, 17);
            this.rbCliente.TabIndex = 3;
            this.rbCliente.TabStop = true;
            this.rbCliente.Text = "Clientes";
            this.rbCliente.UseVisualStyleBackColor = true;
            this.rbCliente.CheckedChanged += new System.EventHandler(this.rbCliente_CheckedChanged);
            // 
            // rbProveedores
            // 
            this.rbProveedores.AutoSize = true;
            this.rbProveedores.Location = new System.Drawing.Point(25, 49);
            this.rbProveedores.Name = "rbProveedores";
            this.rbProveedores.Size = new System.Drawing.Size(85, 17);
            this.rbProveedores.TabIndex = 4;
            this.rbProveedores.TabStop = true;
            this.rbProveedores.Text = "Proveedores";
            this.rbProveedores.UseVisualStyleBackColor = true;
            this.rbProveedores.CheckedChanged += new System.EventHandler(this.rbProveedores_CheckedChanged);
            // 
            // rbEmpleados
            // 
            this.rbEmpleados.AutoSize = true;
            this.rbEmpleados.Location = new System.Drawing.Point(25, 72);
            this.rbEmpleados.Name = "rbEmpleados";
            this.rbEmpleados.Size = new System.Drawing.Size(77, 17);
            this.rbEmpleados.TabIndex = 5;
            this.rbEmpleados.TabStop = true;
            this.rbEmpleados.Text = "Empleados";
            this.rbEmpleados.UseVisualStyleBackColor = true;
            this.rbEmpleados.CheckedChanged += new System.EventHandler(this.rbEmpleados_CheckedChanged);
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(575, 122);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(100, 23);
            this.btnConsultar.TabIndex = 3;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // cbTodos
            // 
            this.cbTodos.AutoSize = true;
            this.cbTodos.Location = new System.Drawing.Point(591, 42);
            this.cbTodos.Name = "cbTodos";
            this.cbTodos.Size = new System.Drawing.Size(56, 17);
            this.cbTodos.TabIndex = 5;
            this.cbTodos.Text = "Todos";
            this.cbTodos.UseVisualStyleBackColor = true;
            this.cbTodos.CheckStateChanged += new System.EventHandler(this.cbTodos_CheckStateChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(292, 476);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 6;
            this.lblTotal.Text = "Total:";
            // 
            // lblPendiente
            // 
            this.lblPendiente.AutoSize = true;
            this.lblPendiente.Location = new System.Drawing.Point(414, 476);
            this.lblPendiente.Name = "lblPendiente";
            this.lblPendiente.Size = new System.Drawing.Size(64, 13);
            this.lblPendiente.TabIndex = 7;
            this.lblPendiente.Text = "Total Saldo:";
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Location = new System.Drawing.Point(572, 476);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(58, 13);
            this.lblDiferencia.TabIndex = 8;
            this.lblDiferencia.Text = "Diferencia:";
            // 
            // nTotal
            // 
            this.nTotal.AutoSize = true;
            this.nTotal.Location = new System.Drawing.Point(333, 476);
            this.nTotal.Name = "nTotal";
            this.nTotal.Size = new System.Drawing.Size(0, 13);
            this.nTotal.TabIndex = 9;
            // 
            // nTotalPendiente
            // 
            this.nTotalPendiente.AutoSize = true;
            this.nTotalPendiente.Location = new System.Drawing.Point(484, 476);
            this.nTotalPendiente.Name = "nTotalPendiente";
            this.nTotalPendiente.Size = new System.Drawing.Size(0, 13);
            this.nTotalPendiente.TabIndex = 10;
            // 
            // nDiferencia
            // 
            this.nDiferencia.AutoSize = true;
            this.nDiferencia.Location = new System.Drawing.Point(636, 476);
            this.nDiferencia.Name = "nDiferencia";
            this.nDiferencia.Size = new System.Drawing.Size(0, 13);
            this.nDiferencia.TabIndex = 11;
            // 
            // PruebaWS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 527);
            this.Controls.Add(this.nDiferencia);
            this.Controls.Add(this.nTotalPendiente);
            this.Controls.Add(this.nTotal);
            this.Controls.Add(this.lblDiferencia);
            this.Controls.Add(this.lblPendiente);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cbTodos);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbDatos);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PruebaWS";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PruebaWS";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbDatos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEmpleados;
        private System.Windows.Forms.RadioButton rbProveedores;
        private System.Windows.Forms.RadioButton rbCliente;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.CheckBox cbTodos;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblPendiente;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.Label nTotal;
        private System.Windows.Forms.Label nTotalPendiente;
        private System.Windows.Forms.Label nDiferencia;
    }
}
namespace ZORBANK
{
    partial class frmPrincipalBanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipalBanco));
            this.grdBancos = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnIrUltimo = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.bntAnterior = new System.Windows.Forms.Button();
            this.btnIrPrimero = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.bntNuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdBancos)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdBancos
            // 
            this.grdBancos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBancos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grdBancos.Location = new System.Drawing.Point(0, 61);
            this.grdBancos.Name = "grdBancos";
            this.grdBancos.Size = new System.Drawing.Size(993, 411);
            this.grdBancos.TabIndex = 4;
            this.grdBancos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdBancos_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnIrUltimo);
            this.groupBox1.Controls.Add(this.btnSiguiente);
            this.groupBox1.Controls.Add(this.bntAnterior);
            this.groupBox1.Controls.Add(this.btnIrPrimero);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.bntNuevo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(993, 61);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtrar";
            // 
            // btnIrUltimo
            // 
            this.btnIrUltimo.Image = ((System.Drawing.Image)(resources.GetObject("btnIrUltimo.Image")));
            this.btnIrUltimo.Location = new System.Drawing.Point(341, 16);
            this.btnIrUltimo.Name = "btnIrUltimo";
            this.btnIrUltimo.Size = new System.Drawing.Size(48, 42);
            this.btnIrUltimo.TabIndex = 10;
            this.btnIrUltimo.UseVisualStyleBackColor = true;
            this.btnIrUltimo.Click += new System.EventHandler(this.btnIrUltimo_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Image = ((System.Drawing.Image)(resources.GetObject("btnSiguiente.Image")));
            this.btnSiguiente.Location = new System.Drawing.Point(282, 16);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(48, 42);
            this.btnSiguiente.TabIndex = 9;
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // bntAnterior
            // 
            this.bntAnterior.Image = ((System.Drawing.Image)(resources.GetObject("bntAnterior.Image")));
            this.bntAnterior.Location = new System.Drawing.Point(228, 16);
            this.bntAnterior.Name = "bntAnterior";
            this.bntAnterior.Size = new System.Drawing.Size(48, 42);
            this.bntAnterior.TabIndex = 8;
            this.bntAnterior.UseVisualStyleBackColor = true;
            this.bntAnterior.Click += new System.EventHandler(this.bntAnterior_Click);
            // 
            // btnIrPrimero
            // 
            this.btnIrPrimero.Image = ((System.Drawing.Image)(resources.GetObject("btnIrPrimero.Image")));
            this.btnIrPrimero.Location = new System.Drawing.Point(174, 16);
            this.btnIrPrimero.Name = "btnIrPrimero";
            this.btnIrPrimero.Size = new System.Drawing.Size(48, 42);
            this.btnIrPrimero.TabIndex = 7;
            this.btnIrPrimero.UseVisualStyleBackColor = true;
            this.btnIrPrimero.Click += new System.EventHandler(this.btnIrPrimero_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.Location = new System.Drawing.Point(120, 16);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(48, 42);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // bntNuevo
            // 
            this.bntNuevo.Image = ((System.Drawing.Image)(resources.GetObject("bntNuevo.Image")));
            this.bntNuevo.Location = new System.Drawing.Point(12, 16);
            this.bntNuevo.Name = "bntNuevo";
            this.bntNuevo.Size = new System.Drawing.Size(48, 42);
            this.bntNuevo.TabIndex = 5;
            this.bntNuevo.UseVisualStyleBackColor = true;
            this.bntNuevo.Click += new System.EventHandler(this.bntNuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(679, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 39);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bancos";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(66, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 42);
            this.button1.TabIndex = 11;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmPrincipalBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(993, 472);
            this.Controls.Add(this.grdBancos);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmPrincipalBanco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bancos";
            ((System.ComponentModel.ISupportInitialize)(this.grdBancos)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grdBancos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnIrUltimo;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.Button bntAnterior;
        private System.Windows.Forms.Button btnIrPrimero;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button bntNuevo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}
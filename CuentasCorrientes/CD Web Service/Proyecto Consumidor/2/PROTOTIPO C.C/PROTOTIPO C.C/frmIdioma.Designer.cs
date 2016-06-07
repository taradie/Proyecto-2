namespace PROTOTIPO_C.C
{
    partial class frmIdioma
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbIngles = new System.Windows.Forms.RadioButton();
            this.rbEspanol = new System.Windows.Forms.RadioButton();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(254, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione el idioma que desea utlizar en el sistema:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbIngles);
            this.groupBox1.Controls.Add(this.rbEspanol);
            this.groupBox1.Location = new System.Drawing.Point(140, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(238, 122);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Idioma";
            // 
            // rbIngles
            // 
            this.rbIngles.AutoSize = true;
            this.rbIngles.Location = new System.Drawing.Point(131, 52);
            this.rbIngles.Name = "rbIngles";
            this.rbIngles.Size = new System.Drawing.Size(53, 17);
            this.rbIngles.TabIndex = 1;
            this.rbIngles.TabStop = true;
            this.rbIngles.Text = "Ingles";
            this.rbIngles.UseVisualStyleBackColor = true;
            // 
            // rbEspanol
            // 
            this.rbEspanol.AutoSize = true;
            this.rbEspanol.Location = new System.Drawing.Point(25, 52);
            this.rbEspanol.Name = "rbEspanol";
            this.rbEspanol.Size = new System.Drawing.Size(63, 17);
            this.rbEspanol.TabIndex = 0;
            this.rbEspanol.TabStop = true;
            this.rbEspanol.Text = "Español";
            this.rbEspanol.UseVisualStyleBackColor = true;
            this.rbEspanol.CheckedChanged += new System.EventHandler(this.rbEspanol_CheckedChanged);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(232, 208);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 4;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmIdioma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 243);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmIdioma";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Idioma";
            this.Load += new System.EventHandler(this.frmIdioma_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbIngles;
        private System.Windows.Forms.RadioButton rbEspanol;
        private System.Windows.Forms.Button btnAceptar;
    }
}
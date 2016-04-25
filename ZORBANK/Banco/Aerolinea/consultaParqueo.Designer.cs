namespace ZORBANK
{
    partial class consultaParqueo
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
            this.grdFacultad = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdFacultad)).BeginInit();
            this.SuspendLayout();
            // 
            // grdFacultad
            // 
            this.grdFacultad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdFacultad.Location = new System.Drawing.Point(23, 17);
            this.grdFacultad.Name = "grdFacultad";
            this.grdFacultad.Size = new System.Drawing.Size(434, 150);
            this.grdFacultad.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(463, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(28, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Visible = false;
            // 
            // consultaParqueo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 179);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.grdFacultad);
            this.Name = "consultaParqueo";
            this.Text = "consultaParqueo";
            this.Load += new System.EventHandler(this.consultaParqueo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdFacultad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdFacultad;
        private System.Windows.Forms.TextBox textBox1;
    }
}
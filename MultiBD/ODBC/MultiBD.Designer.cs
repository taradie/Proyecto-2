﻿namespace MultiBD
{
    partial class frmMultiBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMultiBD));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txtBD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbDriver = new System.Windows.Forms.ComboBox();
            this.rbDSN = new System.Windows.Forms.RadioButton();
            this.rbDriver = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbODBC = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(115, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Multi Base de Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(53, 227);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Usuario:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(53, 266);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Contraseña:";
            // 
            // txtUsuario
            // 
            this.txtUsuario.Enabled = false;
            this.txtUsuario.Location = new System.Drawing.Point(212, 226);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(169, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Enabled = false;
            this.txtContrasena.Location = new System.Drawing.Point(212, 265);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.Size = new System.Drawing.Size(169, 20);
            this.txtContrasena.TabIndex = 9;
            this.txtContrasena.UseSystemPasswordChar = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(231, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Crear Nueva Conexión";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBD
            // 
            this.txtBD.Enabled = false;
            this.txtBD.Location = new System.Drawing.Point(212, 304);
            this.txtBD.Name = "txtBD";
            this.txtBD.Size = new System.Drawing.Size(169, 20);
            this.txtBD.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(53, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Base de Datos:";
            // 
            // txtServidor
            // 
            this.txtServidor.Enabled = false;
            this.txtServidor.Location = new System.Drawing.Point(212, 190);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(169, 20);
            this.txtServidor.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 191);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Servidor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(53, 152);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Driver:";
            // 
            // cmbDriver
            // 
            this.cmbDriver.Enabled = false;
            this.cmbDriver.FormattingEnabled = true;
            this.cmbDriver.Location = new System.Drawing.Point(212, 151);
            this.cmbDriver.Name = "cmbDriver";
            this.cmbDriver.Size = new System.Drawing.Size(169, 21);
            this.cmbDriver.TabIndex = 6;
            // 
            // rbDSN
            // 
            this.rbDSN.AutoSize = true;
            this.rbDSN.Enabled = false;
            this.rbDSN.Location = new System.Drawing.Point(16, 19);
            this.rbDSN.Name = "rbDSN";
            this.rbDSN.Size = new System.Drawing.Size(87, 17);
            this.rbDSN.TabIndex = 3;
            this.rbDSN.TabStop = true;
            this.rbDSN.Text = "DSN Usuario";
            this.rbDSN.UseVisualStyleBackColor = true;
            this.rbDSN.CheckedChanged += new System.EventHandler(this.rbDSN_CheckedChanged);
            // 
            // rbDriver
            // 
            this.rbDriver.AutoSize = true;
            this.rbDriver.Enabled = false;
            this.rbDriver.Location = new System.Drawing.Point(175, 19);
            this.rbDriver.Name = "rbDriver";
            this.rbDriver.Size = new System.Drawing.Size(125, 17);
            this.rbDriver.TabIndex = 4;
            this.rbDriver.TabStop = true;
            this.rbDriver.Text = "Controlador Instalado";
            this.rbDriver.UseVisualStyleBackColor = true;
            this.rbDriver.CheckedChanged += new System.EventHandler(this.rbDriver_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(56, 348);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 46);
            this.button2.TabIndex = 0;
            this.button2.Text = "Mostrar Conexión Actual";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbDSN);
            this.groupBox1.Controls.Add(this.rbDriver);
            this.groupBox1.Location = new System.Drawing.Point(56, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(325, 49);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Seleccione Tipo Conexión";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Orígen de Datos:";
            // 
            // cmbODBC
            // 
            this.cmbODBC.Enabled = false;
            this.cmbODBC.FormattingEnabled = true;
            this.cmbODBC.Location = new System.Drawing.Point(212, 111);
            this.cmbODBC.Name = "cmbODBC";
            this.cmbODBC.Size = new System.Drawing.Size(169, 21);
            this.cmbODBC.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(333, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(48, 42);
            this.button3.TabIndex = 20;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // frmMultiBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 411);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbODBC);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbDriver);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtContrasena);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMultiBD";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Establecer Conexión a Base de Datos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbDriver;
        private System.Windows.Forms.RadioButton rbDSN;
        private System.Windows.Forms.RadioButton rbDriver;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbODBC;
        private System.Windows.Forms.Button button3;
    }
}


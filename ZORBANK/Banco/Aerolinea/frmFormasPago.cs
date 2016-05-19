﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;
using ConexionODBC;
using System.Data.Odbc;
namespace ZORBANK
{
    public partial class frmFormasPago : Form
    {
        public static OdbcCommand _comando;
        public static OdbcDataReader _reader;
        public frmFormasPago()
        {
            InitializeComponent();
            funSedes1();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
        }
        void funSedes1()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("tipoformapago", "SELECT codigo_tipo_forma  from tipoformapago", "codigo_tipo_forma", comboBox1);

        }
        private void frmFormasPago_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(textBox1, true);
        
            cnegocio.funactivarDesactivarCombobox(comboBox1, true);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _comando = new OdbcCommand(String.Format("insert into formas_pago(descripcion,codigo_tipo_forma) values ('" + textBox1.Text + "','" + comboBox1 + "' )"), ConexionODBC.Conexion.ObtenerConexion());
            _comando.ExecuteNonQuery();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "C:\\IS.chm";
            proc.Start();
            proc.Close();
            
        }
    }
}

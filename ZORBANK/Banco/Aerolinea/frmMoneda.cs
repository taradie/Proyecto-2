using System;
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
    public partial class frmMoneda : Form
    {
        public static OdbcCommand _comando;
        public static OdbcDataReader _reader;
        public frmMoneda()
        {

            InitializeComponent();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;

        }

        private void frmMoneda_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _comando = new OdbcCommand(String.Format("insert into monedas(nombre,abreviatura,fecha_registro) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "' )"), ConexionODBC.Conexion.ObtenerConexion());
            _comando.ExecuteNonQuery();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(textBox1, true);
            cnegocio.funactivarDesactivarTextbox(textBox2, true);
            cnegocio.funactivarDesactivarTextbox(textBox3, true);
            
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "C:\\IS.chm";
            proc.Start();
            proc.Close();
            
        }
    }
}

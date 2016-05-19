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
    public partial class frmConceptos : Form
    {
       public static OdbcCommand _comando;
        public static OdbcDataReader _reader;
        public frmConceptos()
        {
            InitializeComponent();
            funSedes();
            funSedes1();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(textBox1, true);
            cnegocio.funactivarDesactivarTextbox(textBox2, true);
            cnegocio.funactivarDesactivarCombobox(comboBox1, true);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            //estado = "editar";
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(textBox1, true);
            cnegocio.funactivarDesactivarTextbox(textBox2, true);
            cnegocio.funactivarDesactivarCombobox(comboBox1, true);
            cnegocio.funactivarDesactivarCombobox(comboBox2, true);
            
            //txtNombre.Clear();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        

        void funSedes()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("codigo_operacion", "SELECT codigo_operacion  from operacioncontable", "codigo_operacion", comboBox1);

        }
        void funSedes1()
      {
          clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("codigo_clasificacion", "SELECT codigo_clasificacion  from clasificacionconceptosbancarios", "codigo_clasificacion", comboBox2);

       }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _comando = new OdbcCommand(String.Format("insert into conceptosbancarios(concepto,descripcion,codigo_operacion,codigo_clasificacion,estado) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + comboBox1 + "','" + comboBox2 + "','" + 1 + "' )"), ConexionODBC.Conexion.ObtenerConexion());
           _comando.ExecuteNonQuery();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(textBox1, true);
            cnegocio.funactivarDesactivarTextbox(textBox2, true);
            cnegocio.funactivarDesactivarCombobox(comboBox1, true);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void frmConceptos_Load(object sender, EventArgs e)
        {

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

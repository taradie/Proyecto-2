using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;using Seguridad;using SeguridadGrafico;
using ConexionODBC;
using System.Data.Odbc;

namespace ZORBANK
{
    public partial class frmBeneficiario : Form
    {
        public static OdbcCommand _comando;
        public static OdbcDataReader _reader;
        
        public frmBeneficiario()
        {
            InitializeComponent();
        }
         public frmBeneficiario(string sCodigoP, string sDPI, string sNombreP)
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
            textBox1.Text = sCodigoP;
            textBox2.Text = sDPI;
            textBox3.Text = sNombreP;
        }


        private void frmBeneficiario_Load(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _comando = new OdbcCommand(String.Format("update personas Set estado = " + textBox4.Text + " where dpi = " +textBox1.Text +""), ConexionODBC.Conexion.ObtenerConexion());
            _comando.ExecuteNonQuery();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}

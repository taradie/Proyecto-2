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

namespace PROTOTIPO_C.C
{
    public partial class frmIngresoCliente : Form
    {
        public frmIngresoCliente()
        {
            InitializeComponent();
        }

        public frmIngresoCliente(string sCodigoP, string sDPI, string sNit, string sNombreP, string sApellidoP, string sFechaP, string sDireccionP, string sTelefonoP, string sEmailP, string sSexo)
        {
            InitializeComponent();
            txtDpi.Text = sDPI;
            txtNombre.Text = sNombreP;
            txtApellidos.Text = sApellidoP;
            dtpFecha.Value = Convert.ToDateTime(sFechaP);
            txtDireccion.Text = sDireccionP;
            txtCorreo.Text = sEmailP;
            txtTelefono.Text = sTelefonoP;
            if (sSexo.Equals("Masculino"))
            {
                rbMasculino.Checked = true;
            }
            else if (sSexo.Equals("Femenino"))
            {
                rbFemenino.Checked = true;
            }
        }

        void funObtenerCodigoPersona()
        {
            cmbObtenerCodigo.Items.Clear();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("codigo_persona", "SELECT MAX(codigo_persona) as Codigo from personas", "Codigo", cmbObtenerCodigo);
            txtInformacion.Text = cmbObtenerCodigo.Text;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void frmIngresoCliente_Load(object sender, EventArgs e)
        {

        }
         
    }
}

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
    public partial class frmEmpleado : Form
    {
        public frmEmpleado()
        {
            InitializeComponent();
            //bloquearTodos();
        }

        public frmEmpleado(string sCodEmpleado, string sNombre, string sApellido, string sDpi, string sSexo, string sFechaNacimiento, string sDireccion, string sTelefono, string sNIT, string sCorreo, string sPuesto)
        {
            InitializeComponent();
            txtNombre.Text = sNombre;
            txtApellido.Text = sApellido;
            txtDPI.Text = sDpi;
            cmbSexo.Text = sSexo;
            dtFechaNacimiento.Value = Convert.ToDateTime(sFechaNacimiento);
            txtDireccion.Text = sDireccion;
            txtTelefono.Text = sTelefono;
            txtNIT.Text = sNIT;
            txtCorreo.Text = sCorreo;
            cmbTipoEmpleado.Text = sPuesto;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = true;
            funLlenarDatos();

        }

        void funLlenarDatos() {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("tipovendedor", "SELECT concat(codTipoVendedor, '.',tipo) AS Empleado FROM tipovendedor", "Empleado", cmbTipoEmpleado);
        }

        public void bloquearTodos()
        {
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnRefrescar.Enabled = false;            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }
    }
}

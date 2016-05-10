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
        string sCod;
        string estado = "";
        public frmIngresoCliente()
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
        }

        public frmIngresoCliente(string sCodigoP, string sDPI, string sNombreP, string sApellidoP, string sFechaP, string sNitP, string sDireccionP, string sEmailP, string sTelefonoP, string sSexo)
        {
            InitializeComponent();
            sCod = sCodigoP;
            txtDpi.Text = sDPI;
            txtNombre.Text = sNombreP;
            txtApellidos.Text = sApellidoP;
            dtpFecha.Value = Convert.ToDateTime(sFechaP);
            txtDireccion.Text = sDireccionP;
            txtCorreo.Text = sEmailP;
            txtTelefono.Text = sTelefonoP;
            txtNit.Text = sNitP;
            if (sSexo.Equals("masculino"))
            {
                rbMasculino.Checked = true;
            }
            else if (sSexo.Equals("femenino"))
            {
                rbFemenino.Checked = true;
            }

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        void funObtenerCodigoCliente()
        {
            cmbObtenerCodigo.Items.Clear();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("ncodcliente", "SELECT ncodcliente as Codigo FROM cliente WHERE codigo_persona = '"+sCod+"'", "Codigo", cmbObtenerCliente);
            txtInfo.Text = cmbObtenerCliente.Text;
        }

        void funObtenerCodigo()
        {
            cmbObtenerCodigo.Items.Clear();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("codigo_persona", "SELECT Max(codigo_persona) as Codigo  from personas", "Codigo", cmbObtenerCodigo);
            txtInformacion.Text = cmbObtenerCodigo.Text;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            dtpFecha.Enabled = true;
            txtDireccion.Clear();
            txtNit.Clear();
            txtTelefono.Clear();
            txtDpi.Clear();
            txtCorreo.Clear();
            txtApellidos.Clear();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, true);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, true);
            cnegocio.funactivarDesactivarTextbox(txtNit, true);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, true);
            cnegocio.funactivarDesactivarTextbox(txtDpi, true);
            cnegocio.funactivarDesactivarTextbox(txtCorreo, true);
            cnegocio.funactivarDesactivarTextbox(txtApellidos, true);

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void frmIngresoCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            clasnegocio cnegocio = new clasnegocio();
            dtpFecha.Enabled = true;
            cnegocio.funactivarDesactivarTextbox(txtNombre, true);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, true);
            cnegocio.funactivarDesactivarTextbox(txtNit, true);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, true);
            cnegocio.funactivarDesactivarTextbox(txtDpi, true);
            cnegocio.funactivarDesactivarTextbox(txtCorreo, true);
            cnegocio.funactivarDesactivarTextbox(txtApellidos, true);
            //txtNombre.Clear();
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            clasnegocio cnegocio = new clasnegocio();
            dtpFecha.Enabled = false;
            cnegocio.funactivarDesactivarTextbox(txtNombre, false);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, false);
            cnegocio.funactivarDesactivarTextbox(txtNit, false);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, false);
            cnegocio.funactivarDesactivarTextbox(txtDpi, false);
            cnegocio.funactivarDesactivarTextbox(txtCorreo, false);
            cnegocio.funactivarDesactivarTextbox(txtApellidos, false);
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
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            string sTabla = "personas";
            string sCodigo = "codigo_persona";
            string sCampoEstado = "estado";
            string sCampoEstado2 = "vestado";
            string sGenero;
            string sFecha = dtpFecha.Text;


            string sTabla2 = "cliente";
            string sCod2 = txtInfo.Text;
            string sCodigo2 = "ncodcliente";
            txtFecha.Text = sFecha;
            if (rbMasculino.Checked == true)
            {
                sGenero = "masculino";
                txtSexo.Text = sGenero;
            }
            else
            {
                sGenero = "Femenino";
                txtSexo.Text = sGenero;
            }


            if (estado.Equals("editar"))
            {

                TextBox[] aDatosEdit = { txtDpi, txtNombre, txtApellidos, txtSexo, txtFecha, txtDireccion, txtTelefono, txtNit, txtCorreo};
                cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, sCodigo);
                //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Editar", sTabla);
                this.Close();


            }
            else if (estado.Equals("eliminar"))
            {
                

                cn.funeliminarRegistro(sTabla, sCod, sCodigo, sCampoEstado);
                cn.funeliminarRegistro(sTabla2, sCod2, sCodigo2, sCampoEstado2);
                //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Eliminar", sTabla);
                this.Close();
            }
            else if (estado.Equals(""))
            {
                TextBox[] aDatos = { txtEmpresa, txtDpi, txtNombre, txtApellidos, txtSexo, txtFecha, txtDireccion, txtTelefono, txtNit, txtCorreo, txtEstado };
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                funObtenerCodigo();
                string sCodPersona = txtInformacion.Text;
                TextBox[] aDatos2 = {txtInformacion, txtTipoCliente, txtEmpleado, txtEstadoCliente};
                cn.AsignarObjetos(sTabla2, bPermiso, aDatos2);
                //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Insertar", sTabla);
                this.Close();
            }

            //frmPrincipalIngresoClientes temp = new frmPrincipalIngresoClientes();
            //temp.funActualizarGrid();
            estado = "";
            txtNombre.Clear();
            txtDireccion.Clear();
            txtNit.Clear();
            txtTelefono.Clear();
            txtDpi.Clear();
            txtCorreo.Clear();
            txtApellidos.Clear();
            clasnegocio cnegocio = new clasnegocio();
            dtpFecha.Enabled = false;
            cnegocio.funactivarDesactivarTextbox(txtNombre, false);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, false);
            cnegocio.funactivarDesactivarTextbox(txtNit, false);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, false);
            cnegocio.funactivarDesactivarTextbox(txtDpi, false);
            cnegocio.funactivarDesactivarTextbox(txtCorreo, false);
            cnegocio.funactivarDesactivarTextbox(txtApellidos, false);
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnRefrescar.Enabled = true;
            btnBuscar.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            dtpFecha.Enabled = false;
            cnegocio.funactivarDesactivarTextbox(txtNombre, false);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, false);
            cnegocio.funactivarDesactivarTextbox(txtNit, false);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, false);
            cnegocio.funactivarDesactivarTextbox(txtDpi, false);
            cnegocio.funactivarDesactivarTextbox(txtCorreo, false);
            cnegocio.funactivarDesactivarTextbox(txtApellidos, false);
            txtNombre.Clear();
            txtDireccion.Clear();
            txtNit.Clear();
            txtTelefono.Clear();
            txtDpi.Clear();
            txtCorreo.Clear();
            txtApellidos.Clear();

            /*
            Boolean[] permisos;
            permisos = claseUsuario.PermisosBotones(claseUsuario.varibaleUsuario, "frmFacultad");
            btnNuevo.Enabled = permisos[0];
            btnEditar.Enabled = permisos[1];
            btnEliminar.Enabled = permisos[2];
            */
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnRefrescar.Enabled = true;
            btnBuscar.Enabled = true;
        }
         
    }
}

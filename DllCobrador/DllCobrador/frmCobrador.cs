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

namespace DllCobrador
{
    public partial class frmCobrador : Form
    {
        string sCod;
        string estado = "";
        public frmCobrador()
        {
            InitializeComponent();
            rbMasculino.Checked = true;
            cmbEstado.SelectedIndex = 0;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        public frmCobrador(string sCodigo, string sNombre, string sApellido, string sGenero, string sCorreo, string sDireccion, string sTelefono, string sComision, string sEstado)
        {
            InitializeComponent();
            sCod = sCodigo;
            txtNombre.Text = sNombre;
            txtApellido.Text = sApellido;
            txtCorreo.Text = sCorreo;
            txtDireccion.Text = sDireccion;
            txtTelefono.Text = sTelefono;
            txtComision.Text = sComision;
            int index;
            if (sEstado == "ACTIVO")
            {
                index = 0;
            }
            else
            {
                index = 1;
            }
            cmbEstado.SelectedIndex = index;
            if (sGenero == "Masculino")
            {
                rbMasculino.Checked = true;
            }
            else
            {
                rbFemenino.Checked = true;
            }

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void frmCobrador_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtComision.Clear();
            cmbEstado.SelectedIndex = 0;
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, true);
            cnegocio.funactivarDesactivarTextbox(txtApellido, true);
            cnegocio.funactivarDesactivarTextbox(txtCorreo, true);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, true);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, true);
            cnegocio.funactivarDesactivarTextbox(txtComision, true);
            cnegocio.funactivarDesactivarCombobox(cmbEstado, true);

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
            estado = "editar";
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, true);
            cnegocio.funactivarDesactivarTextbox(txtApellido, true);
            cnegocio.funactivarDesactivarTextbox(txtCorreo, true);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, true);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, true);
            cnegocio.funactivarDesactivarTextbox(txtComision, true);
            cnegocio.funactivarDesactivarCombobox(cmbEstado, true);

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
            cnegocio.funactivarDesactivarTextbox(txtNombre, false);
            cnegocio.funactivarDesactivarTextbox(txtApellido, false);
            cnegocio.funactivarDesactivarTextbox(txtCorreo, false);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, false);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, false);
            cnegocio.funactivarDesactivarTextbox(txtComision, false);
            cnegocio.funactivarDesactivarCombobox(cmbEstado, false);

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
            if(rbMasculino.Checked == true){
                txtGenero.Text = "Masculino";
            }
            else
            {
                txtGenero.Text = "Femenino";
            }
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            string sTabla = "cobrador";
            string sCodigo = "codCobrador";
            string sCampoEstado = "condicion";
            txtEstado.Text = cmbEstado.SelectedItem.ToString();
            if (estado.Equals("editar"))
            {

                TextBox[] aDatosEdit = { txtNombre, txtApellido, txtGenero, txtCorreo, txtDireccion, txtTelefono, txtComision, txtEstado};
                cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, sCodigo);
                //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Editar", sTabla);
                this.Close();


            }
            else if (estado.Equals("eliminar"))
            {
                cn.funeliminarRegistro(sTabla, sCod, sCodigo, sCampoEstado);
                //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Eliminar", sTabla);
                this.Close();
            }
            else if (estado.Equals(""))
            {
                TextBox[] aDatos = { txtNombre, txtApellido, txtGenero, txtCorreo, txtDireccion, txtTelefono, txtComision, txtEstado, txtCondicion };
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Insertar", sTabla);
                this.Close();
            }

            estado = "";
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtComision.Clear();
            cmbEstado.SelectedIndex = 0;

            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, false);
            cnegocio.funactivarDesactivarTextbox(txtApellido, false);
            cnegocio.funactivarDesactivarTextbox(txtCorreo, false);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, false);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, false);
            cnegocio.funactivarDesactivarTextbox(txtComision, false);
            cnegocio.funactivarDesactivarCombobox(cmbEstado, false);
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
            txtNombre.Clear();
            txtApellido.Clear();
            txtCorreo.Clear();
            txtDireccion.Clear();
            txtTelefono.Clear();
            txtComision.Clear();
            cmbEstado.SelectedIndex = 0;

            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombre, false);
            cnegocio.funactivarDesactivarTextbox(txtApellido, false);
            cnegocio.funactivarDesactivarTextbox(txtCorreo, false);
            cnegocio.funactivarDesactivarTextbox(txtDireccion, false);
            cnegocio.funactivarDesactivarTextbox(txtTelefono, false);
            cnegocio.funactivarDesactivarTextbox(txtComision, false);
            cnegocio.funactivarDesactivarCombobox(cmbEstado, false);
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;

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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string debug = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            String ruta = debug + @"\Manual de Usuario Dll Cobrador.chm";
            Help.ShowHelp(this, ruta, HelpNavigator.Topic, "Manual de usuario");
        }
    }
}

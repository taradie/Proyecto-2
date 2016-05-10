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
    public partial class frmIngresoProveedores : Form
    {
        string sCod;
        string estado = "";
        public frmIngresoProveedores()
        {
            InitializeComponent();
        }

        public frmIngresoProveedores(string sCodP, string sNombre, string sDireccion, string sNit, string sTelefono, string sDescripcion, string sCuenta)
        {
            InitializeComponent();
            txtNombreProveedor.Text = sNombre;
            txtDireccionProveedor.Text = sDireccion;
            txtNitProveedor.Text = sNit;
            txtTelefonoProveedor.Text = sTelefono;
            txtDescripcionProveedor.Text = sDescripcion;
            txtCuentaProveedor.Text = sCuenta;
            sCod = sCodP;

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombreProveedor.Clear();
            txtDireccionProveedor.Clear();
            txtNitProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtDescripcionProveedor.Clear();
            txtCuentaProveedor.Clear();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombreProveedor, true);
            cnegocio.funactivarDesactivarTextbox(txtDireccionProveedor, true);
            cnegocio.funactivarDesactivarTextbox(txtNitProveedor, true);
            cnegocio.funactivarDesactivarTextbox(txtTelefonoProveedor, true);
            cnegocio.funactivarDesactivarTextbox(txtDescripcionProveedor, true);
            cnegocio.funactivarDesactivarTextbox(txtCuentaProveedor, true);

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
            cnegocio.funactivarDesactivarTextbox(txtNombreProveedor, true);
            cnegocio.funactivarDesactivarTextbox(txtDireccionProveedor, true);
            cnegocio.funactivarDesactivarTextbox(txtNitProveedor, true);
            cnegocio.funactivarDesactivarTextbox(txtTelefonoProveedor, true);
            cnegocio.funactivarDesactivarTextbox(txtDescripcionProveedor, true);
            cnegocio.funactivarDesactivarTextbox(txtCuentaProveedor, true);
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
            cnegocio.funactivarDesactivarTextbox(txtNombreProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtDireccionProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtNitProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtTelefonoProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtDescripcionProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtCuentaProveedor, false);
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
            string sTabla = "proveedor";
            string sCodigo = "codproveedor";
            string sCampoEstado = "estado";

            if (estado.Equals("editar"))
            {

                TextBox[] aDatosEdit = { txtNombreProveedor, txtDireccionProveedor, txtNitProveedor, txtTelefonoProveedor, txtDescripcionProveedor, txtCuentaProveedor };
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
                TextBox[] aDatos = { txtNombreProveedor, txtDireccionProveedor, txtNitProveedor, txtTelefonoProveedor, txtDescripcionProveedor, txtCuentaProveedor, txtEstado };
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Insertar", sTabla);
                this.Close();
            }

            frmPrincipalIngresoProveedores temp = new frmPrincipalIngresoProveedores();
            temp.funActualizarGrid();
            estado = "";
            txtNombreProveedor.Clear();
            txtDireccionProveedor.Clear();
            txtNitProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtDescripcionProveedor.Clear();
            txtCuentaProveedor.Clear();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtNombreProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtDireccionProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtNitProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtTelefonoProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtDescripcionProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtCuentaProveedor, false);
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
            cnegocio.funactivarDesactivarTextbox(txtNombreProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtDireccionProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtNitProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtTelefonoProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtDescripcionProveedor, false);
            cnegocio.funactivarDesactivarTextbox(txtCuentaProveedor, false);
            txtNombreProveedor.Clear();
            txtDireccionProveedor.Clear();
            txtNitProveedor.Clear();
            txtTelefonoProveedor.Clear();
            txtDescripcionProveedor.Clear();
            txtCuentaProveedor.Clear();

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

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}

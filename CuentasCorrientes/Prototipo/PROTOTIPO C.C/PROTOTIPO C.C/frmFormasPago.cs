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
    public partial class frmFormasPago : Form
    {
        string sCod;
        string estado = "";
        public frmFormasPago()
        {
            InitializeComponent();
        }

        public frmFormasPago(string sCodF, string sNombre)
        {
            InitializeComponent();
            txtDescripcionProveedor.Text = sNombre;
            sCod = sCodF;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtDescripcionProveedor.Clear();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtDescripcionProveedor, true);
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
            cnegocio.funactivarDesactivarTextbox(txtDescripcionProveedor, true);
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
            cnegocio.funactivarDesactivarTextbox(txtDescripcionProveedor, false);
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
            string sTabla = "formas_pago";
            string sCodigo = "codigo_forma";
            string sCampoEstado = "estado";

            if (estado.Equals("editar"))
            {

                TextBox[] aDatosEdit = { txtDescripcionProveedor};
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
                TextBox[] aDatos = { txtDescripcionProveedor, txtTipo};
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Insertar", sTabla);
                this.Close();
            }

            estado = "";
            txtDescripcionProveedor.Clear();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtDescripcionProveedor, false);
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
            cnegocio.funactivarDesactivarTextbox(txtDescripcionProveedor, false);
            txtDescripcionProveedor.Clear();

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
    }
}

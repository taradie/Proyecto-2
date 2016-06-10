using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Navegador;
using Seguridad;

namespace Sistema_compras
{
    public partial class frmAlmacen : Form
    {
        public static OdbcCommand _comando;
        public static OdbcDataReader _reader;
        //-----------------Variables Comunes---------------

        string sCod;

        public frmAlmacen()
        {
            InitializeComponent();
            btnRefrescar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }

         public frmAlmacen(string codalmacen,string codempresa,string nombre,string ubicacion, string tamano,string disponibilidad,string condicion)
        {
            InitializeComponent();
            
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = true;
            sCod = codalmacen;
            txtempresa.Text = codempresa;
            txtnombre.Text = nombre;
            txtubicacion.Text = ubicacion;
            txtTamano.Text = tamano;
            txtdispo.Text = disponibilidad;
           
            txtact.Text = condicion;
           

           
        }

        private void frmAlmacen_Load(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

        }

        #region funciones comunes para validaciones visuales


        public void funLimpiarTextos()
        {
            txtnombre.Text = "";
            txtubicacion.Text = "";
           
            txtempresa.Text = "";
            txtTamano.Text = "";
            txtdispo.Text = "";
            
        }

        #endregion


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtempresa.Enabled = true;
            txtnombre.Enabled = true;
            txtTamano.Enabled = true;
            txtdispo.Enabled = true;
            txtubicacion.Enabled = true;
           
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        public void funActualizar()
        {
            clasnegocio almacn = new clasnegocio();
            Boolean bPermiso = true;
            TextBox[] aDatosEdit = { txtnombre, txtempresa,txtubicacion, txtTamano, txtstatus };
            string sTabla = "almacen";
            string codalmacen = "codalmacen";
            almacn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, codalmacen);
            claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Editar", "Almacen");
        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!txtnombre.Text.Equals("") && !txtempresa.Text.Equals("") && !txtubicacion.Text.Equals("") && !txtTamano.Text.Equals(""))
            {
                if (MessageBox.Show("¿Desea Actualizar Los Datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funActualizar();
                    funLimpiarTextos();
                    
                }
            }
            else
            {
                MessageBox.Show("Todos Los Campos Tienen que Tener un Valor", "Datos no Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void funEliminar()
        {
            TomarDatos();
            try { 
            
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            txtstatus.Text = "0";
            txtact.Text = "INACTIVO";
            TextBox[] aDatosEdit = { txtstatus, txtact };
            string sTabla = "almacen";
            string codigoalmacen = "codalmacen";
            cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, codigoalmacen);

            MessageBox.Show("Proceso realizado exitosamente");
            claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Eliminar", "Almacen");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al guardar los datos");
            }
            }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Decea Eliminar al Proveedor?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funEliminar();
               
                funLimpiarTextos();
            }
        }

        private void TomarDatos()
        {
            if (rbActivo.Checked)
            {
                txtstatus.Text = "ACTIVO";
            }
            else if (rbInactivo.Checked)
            {
                txtstatus.Text = "INACTIVO";
            }
        }
        public void funGuardarDatos()
        {

            TomarDatos();
            try { 
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            txtstatus.Text = "1";
            txtact.Text = "ACTIVO";
            TextBox[] aDatos = { txtnombre, txtempresa, txtubicacion, txtTamano,txtact,txtstatus, txtdispo };
            string sTabla = "almacen";
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);
            funLimpiarTextos();
            MessageBox.Show("Datos guardados con exito");
            claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Insertar", "Almacen");
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al guardar los datos");
            }
        }
        
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!txtnombre.Text.Equals("") && !txtempresa.Text.Equals("") && !txtubicacion.Text.Equals("") && !txtTamano.Text.Equals(""))
            {
                if (MessageBox.Show("¿Decea Guardar Los Datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funGuardarDatos();
                    funLimpiarTextos();
                    btnGuardar.Enabled = false;
                    
                }
            }
            else
            {
                MessageBox.Show("Todos Los Campos Tienen que Tener un Valor", "Datos no Guardados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funLimpiarTextos();
            btnGuardar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, ayuda.HelpNamespace);
        }
    }
}

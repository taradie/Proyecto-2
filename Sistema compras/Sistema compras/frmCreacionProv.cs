using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;

namespace Sistema_compras
{
    public partial class frmCreacionProv : Form
    {
        //-----------variables para conexiones odbc---------------------------------------------------
        public static OdbcCommand _comando;
        public static OdbcDataReader _reader;
        //-----------------Variables Comunes---------------
        
        string sCod;
        double tiempo = 0.5;
        public frmCreacionProv()
        {
            InitializeComponent();
            bloquearTodos();
        }

        public frmCreacionProv(string codigo,string nombre,string ubicacion,string nit,string telefono,string descripcion,string cuenta,string estado)
        {
            InitializeComponent();
            rbActivo.Visible = true;
            rbInactivo.Visible = true;
            lblEstado.Visible = true;
            if (estado.Equals("ACTIVO"))
            {
                rbActivo.Checked = true;
                txtEstado.Text = "ACTIVO";
            }
            else if(estado.Equals("INACTIVO")) {
                rbInactivo.Checked = true;
                txtEstado.Text = "INACTIVO";
            }

            txtInactivo.Visible = false;
            txtEstado.Visible = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = true;
            sCod = codigo;
            txtNombre.Text = nombre;
            txtUbicacion.Text = ubicacion;
            txtNit.Text = nit;
            txtTelefono.Text = telefono;
            txtDescripcion.Text = descripcion;
            txtCuenta.Text = cuenta; 
        }

        #region funciones comunes para validaciones visuales
        public void bloquearTodos()
        {
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true; //boton principal de la funcion
            btnRefrescar.Enabled = false;
            txtDescripcion.Enabled = false;
            txtNombre.Enabled = false;
            txtCuenta.Enabled = false;
            //txtEstado.Visible = false;
            txtInactivo.Visible = false;
            txtUbicacion.Enabled = false;
            txtTelefono.Enabled = false;
            txtNit.Enabled = false;
            txtTelefono.Enabled = false;
            //rbActivo.Visible = false;
            //rbInactivo.Visible = false;
            lblEstado.Visible = false;
        }

        public void habilitarConNuevo()
        {
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false; //boton principal de la funcion
            txtDescripcion.Enabled = true;
            txtNombre.Enabled = true;
            txtCuenta.Enabled = true;
            txtUbicacion.Enabled = true;
            txtTelefono.Enabled = true;
            txtNit.Enabled = true;
            txtTelefono.Enabled = true;
        }
        
        public void funLimpiarTextos() {
            txtDescripcion.Text = "";
            txtNombre.Text = "";
            txtCuenta.Text = "";
            txtUbicacion.Text="";
            txtTelefono.Text = "";
            txtNit.Text = "";
        }
     
        #endregion

        #region funciones para cambios en base de datos
        public void funGuardarDatos() {
            //funTomarTextos();
            //_comando = new OdbcCommand(String.Format("I"), ConexionODBC.Conexion.ObtenerConexion());
            //_comando.ExecuteNonQuery();
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            TextBox[] aDatos = {txtDescripcion, txtNombre, txtCuenta,txtUbicacion, txtTelefono, txtNit,txtEstado };
            string sTabla = "proveedor";
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);

        }

        public void funActualizar() {
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            TextBox[] aDatosEdit = { txtDescripcion, txtNombre, txtCuenta,txtUbicacion, txtTelefono, txtNit,txtEstado };
            string sTabla = "proveedor";
            string codigopersona="codproveedor";
            cn.EditarObjetos(sTabla, bPermiso, aDatosEdit,sCod,codigopersona);
           
        }

        public void funEliminar() {
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            TextBox[] aDatosEdit = { txtInactivo };
            string sTabla = "proveedor";
            string codigoproveedor = "codproveedor";
            cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, codigoproveedor);
        }
        #endregion

        #region funciones con botones
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarConNuevo();

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Decea Cancelar La Operacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bloquearTodos();
                funLimpiarTextos();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!txtDescripcion.Text.Equals("") && !txtNombre.Text.Equals("") && !txtCuenta.Text.Equals("") && !txtUbicacion.Text.Equals("") && !txtTelefono.Text.Equals("") && !txtNit.Text.Equals("") && !txtEstado.Text.Equals(""))
            {
                if (MessageBox.Show("¿Decea Guardar Los Datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funGuardarDatos();
                    funLimpiarTextos();
                    bloquearTodos();
                }
            }
            else {
                MessageBox.Show("Todos Los Campos Tienen que Tener un Valor","Datos no Guardados",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!txtDescripcion.Text.Equals("") && !txtNombre.Text.Equals("") && !txtCuenta.Text.Equals("") && !txtUbicacion.Text.Equals("") && !txtTelefono.Text.Equals("") && !txtNit.Text.Equals("") && !txtEstado.Text.Equals(""))
            {
                if (MessageBox.Show("¿Decea Actualizar Los Datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funActualizar();
                    funLimpiarTextos();
                    bloquearTodos();
                }
            }
            else
            {
                MessageBox.Show("Todos Los Campos Tienen que Tener un Valor", "Datos no Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Decea Eliminar al Proveedor?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funEliminar();
                bloquearTodos();
                funLimpiarTextos();
            }

        }
        #endregion

        #region funciones para navegacion ordenada en campos
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Back) && !(e.KeyChar == 13) && (e.KeyChar != (char)Keys.Space) && !(char.IsLetter(e.KeyChar)))
            {
                MessageBox.Show("Solo se permiten Letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else if (e.KeyChar == 13)
            {
                txtUbicacion.Select();
                e.Handled = true;
            }
        }

        private void txtUbicacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && !(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == 13) && !(e.KeyChar == 45))
            {
                MessageBox.Show("Solo se permiten Numeros,letras y " + "-", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }else if (e.KeyChar == 13)
            {
                txtNit.Select();
                e.Handled = true;
            }
        }

        private void txtNit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == 13) && !(e.KeyChar == 45))
            {
                MessageBox.Show("Solo se permiten Numeros y "+ "-", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else if (e.KeyChar == 13)
            {
                txtTelefono.Select();
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == 13) && !(e.KeyChar == 45))
            {
                MessageBox.Show("Solo se permiten Numeros y " + "-", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else if (e.KeyChar == 13)
            {
                txtCuenta.Select();
                e.Handled = true;
            }
        }

        private void txtCuenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && !(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == 13) && !(e.KeyChar == 45) && !(e.KeyChar == 46))
                {
                    MessageBox.Show("Solo se permiten Numeros,Letras y " + "-", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
                else if (e.KeyChar == 13)
                {
                    if (rbActivo.Visible == true)
                    {
                        rbActivo.Select();
                        e.Handled = true;
                    }
                    else {
                        txtDescripcion.Select();
                        e.Handled = true;
                    }
                }
            
        }

        private void rbActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDescripcion.Select();
                e.Handled = true;
            }
        }

        private void rbInactivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                txtDescripcion.Select();
                e.Handled = true;
            }
        }

        private void txtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && !(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar !=(char)Keys.Space) && !(e.KeyChar == 13) && !(e.KeyChar == 45) && !(e.KeyChar == 46))
            {
                MessageBox.Show("Solo se permiten Numeros,Letras y " + "-", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else if (e.KeyChar == 13)
            {
                btnNuevo.Select();
                e.Handled = true;
            }
        }

        private void rbActivo_Click(object sender, EventArgs e)
        {
            txtEstado.Text = "ACTIVO";
        }

        private void rbInactivo_Click(object sender, EventArgs e)
        {
            txtEstado.Text = "INACTIVO";
        }
        #endregion


    }
}

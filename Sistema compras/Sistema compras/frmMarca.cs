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

namespace Sistema_compras
{
    public partial class frmMarca : Form
    {
        string sCod;
        public frmMarca()
        {
            InitializeComponent();
            bloquearTodos();
            btnNuevo.Select();
        }

        public frmMarca(string codigo,string descripcion,string comision,string estado)
        {
            InitializeComponent();
            rbActivo.Visible = true;
            rbInactivo.Visible = true;
            
            lblEstado.Visible = true;
            if (estado.Equals("ACTIVO"))
            {
                rbActivo.Checked = true;
                txtActivo.Text = "ACTIVO";
            }
            else if (estado.Equals("INACTIVO"))
            {
                rbInactivo.Checked = true;
                txtActivo.Text = "INACTIVO";
            }
            txtInactivo.Visible = false;
            txtActivo.Visible = false;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = true;
            sCod = codigo;
            txtNombre.Text = descripcion;
            txtComision.Text = comision;
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
            txtNombre.Enabled = false;
            txtInactivo.Visible = false;
            txtActivo.Visible = false;
            rbActivo.Visible = false;
            rbInactivo.Visible = false;
            lblEstado.Visible = false;
            txtComision.Enabled = false;
        }

        public void habilitarConNuevo()
        {
            txtNombre.Select();
            txtInactivo.Text = "1";
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false; //boton principal de la funcion
            txtComision.Enabled = true;
            txtNombre.Enabled = true;
            txtActivo.Visible = false;
            txtInactivo.Visible = false;

        }

        public void funLimpiarTextos()
        {
            txtNombre.Text = "";
            txtComision.Text = "";
        }
        #endregion

        #region funciones para movimiento en base de datos
        public void funGuardarDatos()
        {
            //funTomarTextos();
            //_comando = new OdbcCommand(String.Format("I"), ConexionODBC.Conexion.ObtenerConexion());
            //_comando.ExecuteNonQuery();
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            TextBox[] aDatos = {txtNombre,txtActivo,txtComision,txtInactivo};
            string sTabla = "marca";
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);

        }

        public void funActualizar()
        {
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            TextBox[] aDatosEdit = {txtNombre,txtComision,txtActivo};
            string sTabla = "marca";
            string codigomarca = "codmarca";
            cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, codigomarca);

        }

        public void funEliminar()
        {
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            TextBox[] aDatosEdit = { txtInactivo };
            string sTabla = "marca";
            string codigomarca = "codmarca";
            cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, codigomarca);

        }

        #endregion

        #region funciones con botones
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cancelar La Operacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bloquearTodos();
                funLimpiarTextos();
            }
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarConNuevo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals("") && !txtComision.Text.Equals(""))
            {
                if (MessageBox.Show("¿Desea Guardar Los Datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funGuardarDatos();
                    funLimpiarTextos();
                    bloquearTodos();
                }
            }
            else
            {
                MessageBox.Show("Ingrese un Valor al Campo Vacio", "Datos no Guardados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!txtNombre.Text.Equals("") && !txtComision.Text.Equals(""))
            {
                if (MessageBox.Show("¿Desea Actualizar Los Datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
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
            if (MessageBox.Show("¿Desea Eliminar la Marca?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtInactivo.Text = "0";
                funEliminar();
                bloquearTodos();
                funLimpiarTextos();
            }
        }

        #endregion

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Tab) && !(char.IsNumber(e.KeyChar)) && !(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && !(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == 13) && !(e.KeyChar == 45) && !(e.KeyChar == 46))
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
                else
                {
                    txtComision.Select();
                    e.Handled = true;
                }
            }
        }

        private void rbActivo_Click(object sender, EventArgs e)
        {
            txtActivo.Text = "ACTIVO";
        }

        private void rbInactivo_Click(object sender, EventArgs e)
        {
            txtActivo.Text = "INACTIVO";
        }

        private void rbActivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == (char)Keys.Tab)
            {
                txtComision.Select();
                e.Handled = true;
            }
        }

        private void rbInactivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == (char)Keys.Tab)
            {
                txtComision.Select();
                e.Handled = true;
            }
        }

        private void txtComision_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != (char)Keys.Tab) && !(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Space) && (e.KeyChar != (char)Keys.Back) && !(e.KeyChar == 13) && !(e.KeyChar == 45) && !(e.KeyChar == 46))
            {
                MessageBox.Show("Solo se permiten Numeros y " + "-", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 13 || e.KeyChar == (char)Keys.Tab)
            {
                btnGuardar.Select();
                e.Handled = true;
            }
        }


        

    }
}

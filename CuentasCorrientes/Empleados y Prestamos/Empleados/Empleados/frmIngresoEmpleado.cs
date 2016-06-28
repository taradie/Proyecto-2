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

namespace Empleados
{
    public partial class frmIngresoEmpleado : Form
    {
        int iEditar = 0;
        string sCadena;
        string sCE;
        public frmIngresoEmpleado()
        {
            InitializeComponent();            
            funLlenarDatos();
        }

        public frmIngresoEmpleado(string sCodEmpleado, string sNombre, string sApellido, string sDpi, string sSexo, string sFechaNacimiento, string sDireccion, string sTelefono, string sNIT, string sCorreo, string sComision)
        {
            InitializeComponent();
            sCE = sCodEmpleado;
            txtNombre.Text = sNombre;
            txtApellido.Text = sApellido;
            txtDPI.Text = sDpi;
            cmbSexo.Text = sSexo;
            dtFechaNacimiento.Value = Convert.ToDateTime(sFechaNacimiento);
            txtDireccion.Text = sDireccion;
            txtTelefono.Text = sTelefono;
            txtNIT.Text = sNIT;
            txtCorreo.Text = sCorreo;
            txtComision.Text = sComision;
            //cmbTipoEmpleado.Text = sPuesto;
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
            //funLlenarDatos();

        }

        void funLlenarDatos()
        {
            //clasnegocio cnegocio = new clasnegocio();
            //cnegocio.funconsultarRegistrosCombo("tipovendedor", "SELECT concat(codTipoVendedor, '.',tipo) AS Empleado FROM tipovendedor", "Empleado", cmbTipoEmpleado);
        }

        string funCortadorID(string sDato)
        {
            sCadena = "";
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {
                    if (sDato.Substring(i, 1) != ".")
                    {
                        sCadena = sCadena + sDato.Substring(i, 1);
                    }
                    else
                    {
                        break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al obtener Codigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return sCadena;
        }

        string funCortadorCadena(string sDato)
        {
            sCadena = "";
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {
                    if (sDato.Substring(i, 1) != ".")
                    {
                        sCadena = sCadena + sDato.Substring(i, 1);
                    }
                    else if (sDato.Substring(i, 1) == ".")
                    {
                        sCadena = "";
                    }
                    else
                    {
                        break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al obtener Codigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return sCadena;
        }

        public void habilitarConNuevo()
        {
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false; //boton principal de la funcion
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            cmbSexo.Enabled = true;
            dtFechaNacimiento.Enabled = true;
            txtTelefono.Enabled = true;
            txtDireccion.Enabled = true;
            txtDPI.Enabled = true;
            txtNIT.Enabled = true;
            txtCorreo.Enabled = true;
            txtComision.Enabled = true;
            //cmbTipoEmpleado.Enabled = true;            
        }

        public void funLimpiar() {
            txtNombre.Text = "";
            txtApellido.Text = "";            
            //dtFechaNacimiento.Enabled = true;
            txtTelefono.Text = "";
            txtDireccion.Text = "";
            txtDPI.Text = "";
            txtNIT.Text = "";
            txtCorreo.Text = "";
            txtComision.Text = "";            
        }

        public void funBloquear() {
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true; //boton principal de la funcion
            txtNombre.Enabled = false;
            txtApellido.Enabled = false;
            cmbSexo.Enabled = false;
            dtFechaNacimiento.Enabled = false;
            txtTelefono.Enabled = false;
            txtDireccion.Enabled = false;
            txtDPI.Enabled = false;
            txtNIT.Enabled = false;
            txtCorreo.Enabled = false;
            txtComision.Enabled = false;
            //cmbTipoEmpleado.Enabled = false;  
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarConNuevo();
            funLimpiar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Decea Cancelar La Operacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funBloquear();
                funLimpiar();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            iEditar = 1;
            habilitarConNuevo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            TextBox txtCodEmpresa = new TextBox();
            txtCodEmpresa.Tag = "codigo_empresa";
            txtCodEmpresa.Text = "1";

            TextBox txtSexo = new TextBox();
            txtSexo.Tag = "sexo";
            txtSexo.Text = cmbSexo.Text;

            TextBox txtFecha = new TextBox();
            txtFecha.Tag = "fechaNacimiento";
            txtFecha.Text = dtFechaNacimiento.Text;

            TextBox txtEstado = new TextBox();
            txtEstado.Tag = "estado";
            txtEstado.Text = "ACTIVO";

            TextBox txtCondicion = new TextBox();
            txtCondicion.Tag = "condicion";
            txtCondicion.Text = "ACTIVO";

            if (iEditar.Equals(0)) {
                //////////////////////INSERCION EN LA TABLA PERSONA////////////////////////////                
                clasnegocio cn = new clasnegocio();
                Boolean bPermiso = true;                
                TextBox[] aDatos = {txtCodEmpresa, txtDPI, txtNombre, txtApellido, txtSexo, txtFecha, txtDireccion, txtTelefono, txtNIT, txtCorreo, txtEstado, txtCondicion };
                string sTabla = "personas";
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);

                /////////////////////BUSQUEDA DEL CODIGO DE LA PERSONA INSERTADA//////////////////                         
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistrosCombo("personas", "SELECT MAX(codigo_persona) AS N FROM personas", "N", cmbN);
                //System.Console.WriteLine();

                ////////////////////INSERCION EN LA TABLA EMPLEADO///////////////////////////////                
                TextBox txtCodPersona = new TextBox();
                txtCodPersona.Tag = "codigo_persona";
                txtCodPersona.Text = cmbN.Text;

                //TextBox txtTipoVendedor = new TextBox();
                //txtTipoVendedor.Tag = "codTipoVendedor";
                //txtTipoVendedor.Text = funCortadorID(cmbTipoEmpleado.Text);

                clasnegocio cn2 = new clasnegocio();
                Boolean bPermiso2 = true;
                TextBox[] aDatos2 = { txtCodPersona, txtComision, txtEstado, txtCondicion };
                string sTabla2 = "empleado";
                cn2.AsignarObjetos(sTabla2, bPermiso2, aDatos2);

                funLimpiar();
                funBloquear();
            }
            else if (iEditar.Equals(1))
            {
                
                string sCodigo="codigo_persona";
                string sC=funCortadorCadena(sCE);
                clasnegocio cn2 = new clasnegocio();
                Boolean bPermiso2 = true;

                //////////////////ACTUALIZACION DE LA TABLA PERSONA///////////////////////////
                TextBox[] aDatos3 = { txtDPI, txtNombre, txtApellido, txtSexo, txtFecha, txtDireccion, txtTelefono, txtNIT, txtCorreo, txtEstado };
                string sTabla2 = "personas";
                cn2.EditarObjetos(sTabla2, bPermiso2, aDatos3, sC, sCodigo );

                /////////////////ACTUALIZACION DE LA TABLA EMPLEADO/////////////////////////
                string sCodigo2 = "cod_empleado";
                string sC2 = funCortadorID(sCE);
                //TextBox txtTipoEmpleado = new TextBox();
                //txtTipoEmpleado.Tag = "codTipoVendedor";
                //txtTipoEmpleado.Text = funCortadorID(cmbTipoEmpleado.Text);

                TextBox[] aDatos4 = { txtComision};
                string sTabla4 = "empleado";
                cn2.EditarObjetos(sTabla4, bPermiso2, aDatos4, sC2, sCodigo2);
            }
            funLimpiar();
            funBloquear();
        }

        private void cmbTipoEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

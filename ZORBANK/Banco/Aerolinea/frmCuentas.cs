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

namespace ZORBANK
{
    public partial class frmCuentas : Form
    {
        string estado,temporal,sCodigo,tEmpresa,tFecha,tCuenta,tTipocuenta,tBanco,tMoneda,tCheque,tEstado;
        public frmCuentas(string sMensaje, string sEstadoI, string sCodigoI, string sEmpresa, string sFecha, string sCuenta, string sBanco, string sTipocuenta, string sMoneda, string sCheque, string sEstado)
        {
            clasnegocio cn = new clasnegocio();
            estado = sEstadoI;
            temporal = sEstadoI;
            sCodigo = sCodigoI;
            tEmpresa = sEmpresa;
            tFecha = sFecha;
            tCuenta = sCuenta;
            tBanco = sBanco;
            tMoneda = sMoneda;
            tCheque = sCheque;
            tTipocuenta = sTipocuenta;
            tEstado = sEstado;              //captura de informacion de proviene del formulario principal
            this.Text = sMensaje;
            InitializeComponent();
            
            cn.funactivarDesactivarBoton(btnIrPrimero, false);  //desactivacion de botones de navegacion en formulario banco
            cn.funactivarDesactivarBoton(btnIrUltimo, false);
            cn.funactivarDesactivarBoton(btnSiguiente, false);
            cn.funactivarDesactivarBoton(btnAnterior, false);
            cn.funactivarDesactivarBoton(btnImprimir, false);
            cn.funactivarDesactivarBoton(btnRefrescar, false);
            if (estado.Equals(""))
            {            //botones que se desactivan al crear un nuevo banco
                cn.funactivarDesactivarBoton(btnNuevo, false);
                cn.funactivarDesactivarBoton(btnEditar, false);
                cn.funactivarDesactivarBoton(btnEliminar, false);
                cn.funactivarDesactivarTextbox(txtCheque, false);
                cmbEstado.SelectedIndex = 0;
                txtCheque.Text = "1";
                
            }
            else
            {          //botones de que activan al editar o elimiar registros
                cn.funactivarDesactivarBoton(btnEditar, true);
                cn.funactivarDesactivarBoton(btnEliminar, true);
                cn.funactivarDesactivarTextbox(txtEmpresa, false);
                cn.funactivarDesactivarTextbox(txtNoCuenta, false);
                cn.funactivarDesactivarTextbox(txtTipoCuenta, false);
                cn.funactivarDesactivarTextbox(txtCheque, false);
                cn.funactivarDesactivarTextbox(txtTipoCuenta, false);
                cn.funactivarDesactivarCombobox(cmbBanco, false);
                cn.funactivarDesactivarCombobox(cmbEstado, false);
                cn.funactivarDesactivarCombobox(cmbMoneda, false);
                dtFechaApertura.Enabled = false;
                dtFechaApertura.Text = sFecha;
                txtEmpresa.Text = sEmpresa;
                txtNoCuenta.Text = sCuenta;
                cmbMoneda.Text = tMoneda;
                cmbBanco.Text = tBanco;
                txtTipoCuenta.Text = sTipocuenta;
                txtCheque.Text = sCheque;
                cmbEstado.Text = sEstado;
            }
        }

        #region navegador
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            string sTabla = "cuentasinternas";
            string sTablaId = "codigo_cuenta_interna"; 
            txtFecha.Text = dtFechaApertura.Text;
            txtBanco.Text = Convert.ToString(cmbBanco.SelectedValue);
            txtMoneda.Text = Convert.ToString(cmbMoneda.SelectedValue);
            txtEstado.Text = cmbEstado.Text;

            if (estado.Equals("editar"))        //etastado de edicion 
            {
                TextBox[] aDatosEditar = { txtEmpresa, txtNoCuenta, txtFecha, txtMoneda, txtBanco,txtTipoCuenta,txtCheque,txtEstado };  //campos que se editaran
                cn.EditarObjetos(sTabla, bPermiso, aDatosEditar, sCodigo, sTablaId);
                claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Editar", sTabla); //bitacora de edidcion
            }
            else if (estado.Equals("eliminar"))                     //estado de eliminacion 
            {
                string sCampoEstado = "condicion";              //campo afectado para la eliminacion
                cn.funeliminarRegistro(sTabla, sCodigo, sTablaId, sCampoEstado);
                claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Eliminar", sTabla);  //bitacora de eliminacion

            }
            else if (estado.Equals(""))             //sin estado para un nuevo registro
            {
                TextBox[] aDatos = { txtEmpresa, txtNoCuenta, txtFecha, txtMoneda, txtBanco, txtTipoCuenta, txtCheque,txtEstado,txtCondicion };            //datos para el almacenamietno
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Insertar", sTabla);      //bitacora de alamcenamiento de nuevo registro

            }
            this.Close();           //Cierre de formulario
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";            //boton eliminar cambia el estado del formulario para eliminar un registro
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarBoton(btnNuevo, false);
            cn.funactivarDesactivarBoton(btnEditar, false);

        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = "";                //botone de nuevo registro no posee estado para la creacion de un nuevo registro
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarBoton(btnNuevo, false);
            cn.funactivarDesactivarBoton(btnEditar, false);
            cn.funactivarDesactivarBoton(btnEliminar, false);
            cn.funactivarDesactivarBoton(btnGuardar, true);
            cn.funactivarDesactivarTextbox(txtEmpresa, true);
            cn.funactivarDesactivarTextbox(txtNoCuenta, true);
            cn.funactivarDesactivarTextbox(txtTipoCuenta, true);
            cn.funactivarDesactivarTextbox(txtCheque, false);
            cn.funactivarDesactivarCombobox(cmbMoneda, true);
            cn.funactivarDesactivarCombobox(cmbBanco, true);
            cn.funactivarDesactivarCombobox(cmbEstado, true);
            txtEmpresa.Text = "";
            txtNoCuenta.Text = "";
            txtTipoCuenta.Text = "";
            txtCheque.Text = "1";
            cmbMoneda.Text = "";
            cmbBanco.Text = "";
            cmbEstado.SelectedIndex = 0;

        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();                 //activa la edicion de informacion 
            cn.funactivarDesactivarBoton(btnEditar, false);
            cn.funactivarDesactivarTextbox(txtEmpresa, true);
            cn.funactivarDesactivarTextbox(txtNoCuenta, true);
            cn.funactivarDesactivarTextbox(txtTipoCuenta, true);
            cn.funactivarDesactivarCombobox(cmbEstado, true);
            cn.funactivarDesactivarCombobox(cmbMoneda, true);
            cn.funactivarDesactivarCombobox(cmbBanco, true);
            cn.funactivarDesactivarBoton(btnGuardar, true);
            cn.funactivarDesactivarBoton(btnEliminar, true);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();             //boton de cancelar y regresa el estado con el que se abre por primera vez el formulario
            cn.funactivarDesactivarBoton(btnEditar, true);
            cn.funactivarDesactivarTextbox(txtEmpresa, false);
            cn.funactivarDesactivarTextbox(txtNoCuenta, false);
            cn.funactivarDesactivarTextbox(txtTipoCuenta, false);
            cn.funactivarDesactivarCombobox(cmbEstado, false);
            cn.funactivarDesactivarCombobox(cmbMoneda, false);
            cn.funactivarDesactivarCombobox(cmbBanco, false);
            cn.funactivarDesactivarBoton(btnGuardar, false);
            cn.funactivarDesactivarBoton(btnNuevo, true);
            cn.funactivarDesactivarBoton(btnEliminar, false);
            estado = temporal;
            if (temporal.Equals("editar"))          //Regresa lo datos con el que el formulario se abrio
            {
                txtEmpresa.Text = tEmpresa;
                txtNoCuenta.Text = tCuenta;
                cmbMoneda.Text = tMoneda;
                cmbBanco.Text = tBanco;
                txtTipoCuenta.Text = tTipocuenta;
                txtCheque.Text = tCheque;
                cmbEstado.Text = tEstado;
            } if (estado.Equals("eliminar") | estado.Equals("editar"))
            {
                cn.funactivarDesactivarBoton(btnEliminar, true);   //desactiva el boton de eliminar el regresar al estado principal del formulario
            }
        }
        #endregion

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void frmCuentas_Load(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            cn.funconsultarRegistrosCombo("codigo_banco", "select codigo_banco,nombre from bancos where condicion = '1' and estado='ACTIVO'", "nombre", cmbBanco);
            cn.funconsultarRegistrosCombo("codigo_moneda", "select codigo_moneda,nombre from monedas where condicion='1' and estado='ACTIVO'", "nombre", cmbMoneda);
            if (estado.Equals(""))
            {
                cmbBanco.Text = "";
                cmbMoneda.Text = "";
            }
        }
    }
}

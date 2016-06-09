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
using Seguridad;

namespace ZORBANK
{
    public partial class frmMovimientos : Form
    {
        //programador y analista: Jose alberto oxcal ley
        string estado,sCodigo,temporal, tCodigoI, tCuenta, tConcepto, tFormaP, tBeneficiario, tMoneda, tFechaR, tFechaA, tReferencia1, tReferencia2, tMonto, tObservaciones, tEstado;        
        public frmMovimientos(string sMensaje,string sEstadoI,string sCodigoI,string sCuenta,string sConcepto,string sFormaP,string sBeneficiario,string sMoneda,string sFechaR,string sFechaA,string sReferencia1,string sReferencia2,string sMonto,string sObservaciones,string sEstado)
        {
            InitializeComponent();
            this.Text = sMensaje;
            estado = sEstadoI;
            temporal = sEstadoI;
            tCodigoI = sCodigoI;
            sCodigo = sCodigoI;             //datos demporales si el usuario no desea realizar una modificacion
            tCuenta = sCuenta;
            tConcepto = sConcepto;
            tFormaP = sFormaP;
            tBeneficiario = sBeneficiario;
            tMoneda = sMoneda;
            tFechaR = sFechaR;
            tFechaA = sFechaA;
            tReferencia1 = sReferencia1;
            tReferencia2 = sReferencia2;
            tMonto = sMonto;
            tObservaciones = sObservaciones;
            tEstado = sEstado;
            clasnegocio cn = new clasnegocio();
            dtFechaRegistro.Enabled = false;
            dtFechaAplicacion.Enabled = false;          //botones desabilitados al iniciar el programas
            cn.funactivarDesactivarTextbox(txtTotal, false);
            cn.funactivarDesactivarTextbox(txtReferencia1, false);
            cn.funactivarDesactivarTextbox(txtReferentia2, false);
            cn.funactivarDesactivarTextbox(txtObservaciones, false);
            cn.funactivarDesactivarCombobox(cmbConceptos, false);
            cn.funactivarDesactivarCombobox(cmbMoneda, false);
            cn.funactivarDesactivarCombobox(cmbFormaPago, false);
            cn.funactivarDesactivarCombobox(cmbCuenta, false);
            cn.funactivarDesactivarCombobox(cmbBeneficiario, false);
            if (estado.Equals(""))
            {            //botones que se desactivan al crear un nuevo banco
                cn.funactivarDesactivarBoton(btnEditar, false);
                cn.funactivarDesactivarBoton(btnEliminar, false);
            }
            else
            {          //botones de que activan al editar o elimiar registros
                cn.funactivarDesactivarBoton(btnEditar, true);
                cn.funactivarDesactivarBoton(btnEliminar, true);
                cmbConceptos.Text = sConcepto;
                cmbFormaPago.Text = sFormaP;
                cmbCuenta.Text = sCuenta;
                cmbMoneda.Text = sMoneda;           //datos que provienen del formularion master 
                txtTotal.Text = sMonto;
                cmbBeneficiario.Text = sBeneficiario;
                dtFechaAplicacion.Text = sFechaA;
                dtFechaRegistro.Text = sFechaR;
                txtReferencia1.Text = sReferencia1;
                txtReferentia2.Text = sReferencia2;
                txtObservaciones.Text = sObservaciones;
            }

        
        }

        private void frmMovimientos_Load(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();         //llenado de combos para mostrar informacion de otros formularios
            cn.funconsultarRegistrosCombo("codigo_moneda", "select codigo_moneda,concat(codigo_moneda,'.',nombre) as nombreM from monedas where condicion = '1' and estado='ACTIVO'", "nombreM",cmbMoneda);
            cn.funconsultarRegistrosCombo("codigo_cuenta_interna","select codigo_cuenta_interna,no_cuenta from cuentasinternas where condicion = '1' and estado='ACTIVO'","no_cuenta",cmbCuenta);
            cn.funconsultarRegistrosCombo("codigo_concepto", "Select codigo_concepto,concat(codigo_concepto,'.',concepto) as conceptos from conceptosbancarios where condicion = '1' and estado='ACTIVO'", "conceptos", cmbConceptos);
            cn.funconsultarRegistrosCombo("codigo_forma", "select codigo_forma,concat(codigo_forma,'.',descripcion) as TipoPago from formas_pago where condicion = '1' and estado='ACTIVO'", "TipoPago", cmbFormaPago);
            cn.funactivarDesactivarBoton(btnAnterior, false);
            cn.funactivarDesactivarBoton(btnIrPrimero, false);
            cn.funactivarDesactivarBoton(btnSiguiente, false);
            cn.funactivarDesactivarBoton(bntIrUltimo, false);
            if (estado.Equals(""))
            {
                cmbConceptos.Text = "";
                cmbFormaPago.Text = "";
                cmbCuenta.Text = "";
                cmbMoneda.Text = "";                //limpieza de comandos 
                txtTotal.Text = "";
                cmbBeneficiario.Text = "";
                txtReferencia1.Text = "";
                txtReferentia2.Text = "";
                txtObservaciones.Text = "";
                dtFechaAplicacion.Text = "";
            }
        }




        #region navegador
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;                                //datos de se utilizan para visualizar la tabla y el codigo del movimiento
            string sTabla = "movimientosbancarios";
            string sTablaId = "codigo_movimiento";
            txtFechaAplicacion.Text = dtFechaAplicacion.Text;
            txtFechaRegistro.Text = dtFechaRegistro.Text;
            txtConcepto.Text = Convert.ToString(cmbConceptos.SelectedValue);
            txtCuenta.Text = Convert.ToString(cmbCuenta.SelectedValue);             //comversion de informacion del combo box para seleccionar el codigo
            txtMoneda.Text = Convert.ToString(cmbMoneda.SelectedValue);
            txtFormaPago.Text = Convert.ToString(cmbFormaPago.SelectedValue);
            
            if (estado.Equals("editar"))        //etastado de edicion 
            {
                TextBox[] aDatosEditar = { txtCuenta, txtConcepto, txtFormaPago, txtMoneda, txtFechaRegistro, txtFechaAplicacion, txtReferencia1, txtReferentia2, txtTotal, txtObservaciones, txtEstado, txtCondicion };  //campos que se editaran
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
                TextBox[] aDatos = { txtCuenta, txtConcepto, txtFormaPago, txtMoneda, txtFechaRegistro, txtFechaAplicacion, txtReferencia1, txtReferentia2, txtTotal, txtObservaciones, txtEstado, txtCondicion };            //datos para el almacenamietno
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();                 //activa la edicion de informacion 
            cn.funactivarDesactivarBoton(btnEditar, false);
            cn.funactivarDesactivarTextbox(txtTotal, true);
            cn.funactivarDesactivarTextbox(txtReferencia1, true);
            cn.funactivarDesactivarTextbox(txtReferentia2, true);
            cn.funactivarDesactivarTextbox(txtObservaciones, true);         //activacion de botones para ingreso de informacion
            cn.funactivarDesactivarCombobox(cmbConceptos, true);
            cn.funactivarDesactivarCombobox(cmbMoneda, true);
            cn.funactivarDesactivarCombobox(cmbFormaPago, true);
            cn.funactivarDesactivarCombobox(cmbCuenta, true);
            cn.funactivarDesactivarCombobox(cmbBeneficiario, true);
            cn.funactivarDesactivarBoton(btnGuardar, true);
            cn.funactivarDesactivarBoton(btnEliminar, true);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = "";
            clasnegocio cn = new clasnegocio();
            dtFechaAplicacion.Enabled = true;
            cn.funactivarDesactivarTextbox(txtTotal, true);                 //botones activadodos para el ingreso de un nuevo registro
            cn.funactivarDesactivarTextbox(txtReferencia1, true);
            cn.funactivarDesactivarTextbox(txtReferentia2, true);
            cn.funactivarDesactivarTextbox(txtObservaciones, true);
            cn.funactivarDesactivarCombobox(cmbConceptos, true);
            cn.funactivarDesactivarCombobox(cmbMoneda, true);
            cn.funactivarDesactivarCombobox(cmbFormaPago, true);
            cn.funactivarDesactivarCombobox(cmbCuenta, true);
            cn.funactivarDesactivarCombobox(cmbBeneficiario, true);
            cmbConceptos.Text = "";                         //limpieza de informacion si hay datos en los comandos
            cmbFormaPago.Text = "";
            cmbCuenta.Text = "";
            cmbMoneda.Text = "";
            txtTotal.Text = "";
            cmbBeneficiario.Text = "";
            txtReferencia1.Text = "";
            txtReferentia2.Text = "";
            txtObservaciones.Text = "";
            dtFechaAplicacion.Text = "";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();             //boton de cancelar y regresa el estado con el que se abre por primera vez el formulario
            cn.funactivarDesactivarBoton(btnEditar, true);
            cn.funactivarDesactivarTextbox(txtTotal, false);
            cn.funactivarDesactivarTextbox(txtReferencia1, false);
            cn.funactivarDesactivarTextbox(txtReferentia2, false);
            cn.funactivarDesactivarTextbox(txtObservaciones, false);
            cn.funactivarDesactivarCombobox(cmbConceptos, false);
            cn.funactivarDesactivarCombobox(cmbMoneda, false);
            cn.funactivarDesactivarCombobox(cmbFormaPago, false);
            cn.funactivarDesactivarCombobox(cmbCuenta, false);
            cn.funactivarDesactivarCombobox(cmbBeneficiario, false);
            cn.funactivarDesactivarBoton(btnGuardar, false);
            cn.funactivarDesactivarBoton(btnNuevo, true);
            cn.funactivarDesactivarBoton(btnEliminar, false);
            estado = temporal;
            if (temporal.Equals("editar"))          //Regresa lo datos con el que el formulario se abrio
            {
                cmbConceptos.Text = tConcepto;
                cmbFormaPago.Text = tFormaP;
                cmbCuenta.Text = tCuenta;
                cmbMoneda.Text = tMoneda;
                txtTotal.Text = tMonto;
                cmbBeneficiario.Text = tBeneficiario;
                dtFechaAplicacion.Text = tFechaA;
                dtFechaRegistro.Text = tFechaR;
                txtReferencia1.Text = tReferencia1;
                txtReferentia2.Text = tReferencia2;
                txtObservaciones.Text = tObservaciones;
            } if (estado.Equals("eliminar") | estado.Equals("editar"))
            {
                cn.funactivarDesactivarBoton(btnEliminar, true);   //desactiva el boton de eliminar el regresar al estado principal del formulario
            }
        }


        #endregion


        
    }
}

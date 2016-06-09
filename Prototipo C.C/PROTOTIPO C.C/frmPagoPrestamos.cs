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
    public partial class frmPagoPrestamos : Form
    {
        public frmPagoPrestamos()
        {
            InitializeComponent();
        }

        public frmPagoPrestamos(string sCodPrestamo)
        {
            InitializeComponent();
            funCargarDatosPrestamo(sCodPrestamo);
        }

        public void funCargarDatosPrestamo(string sCodigoPrestamo)
        {
            /////---------------SELECCIONAR EL NO DE TALONARIO QUE LE CORRESPONDE CANCELAR---------------////
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("talonario", "SELECT MIN(talonario.codTalonario) AS CODIGO FROM talonario, prestamo WHERE talonario.codPrestamo=prestamo.codPrestamo AND prestamo.codPrestamo='" + sCodigoPrestamo + "' AND talonario.condicion='ACTIVO' ", "CODIGO", cmbCodigoTalonario);
            //////////--------------------------------------

            /////---------------SELECCIONAR EL MONTO DE TALONARIO QUE LE CORRESPONDE CANCELAR---------------////           
            cnegocio.funconsultarRegistrosCombo("talonario", "SELECT monto AS MONTO FROM talonario WHERE talonario.codTalonario='"+cmbCodigoTalonario.Text+"' AND talonario.condicion='ACTIVO' ", "MONTO", cmbMonto);
            //////////--------------------------------------

            /////---------------SELECCIONAR EL TIPO DE DOCUMENTO QUE PARA PODER PAGAR---------------////           
            cnegocio.funconsultarRegistrosCombo("tipodocumento", "SELECT CONCAT(codtipodocumento, '. ', tipo) AS TPAGO FROM tipodocumento WHERE condicion='ACTIVO' ", "TPAGO", cmbTipoPago);
            //////////--------------------------------------

            /////---------------SELECCIONAR EL CODIGO DE LA TRANSACCION CORRESPONDIENTE---------------////           
            cnegocio.funconsultarRegistrosCombo("conceptos", "SELECT codigo_tipo_transaccion AS TRANS FROM conceptos WHERE tipo='Abono' AND descripcion='Cobro Empleados' AND condicion='ACTIVO' ", "TRANS", cmbTipoTransaccion);
            //////////--------------------------------------
        }

        private void cmbTipoPago_SelectedValueChanged(object sender, EventArgs e)
        {
            string sTPago = cmbTipoPago.Text;
            if(sTPago=="1. Cheque")
            {
                txtReferencia.Enabled = true;
            }
            else
            {
                txtReferencia.Enabled = false;
            }
        }
    }
}

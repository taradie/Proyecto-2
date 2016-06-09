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
    //programador y analista Jose Alberto oxcal ley
    public partial class frmConsultaMovimiento : Form
    {
        public frmConsultaMovimiento()
        {
            InitializeComponent();
            funActualizarGrid();            //funcion de actualizar el grid al inicializar los componentes
        }
        #region grid
        private void temp_FormClosed(object sender, FormClosedEventArgs e)
        {
            funActualizarGrid();            //actualizar informacion de datos en el grid
        }

        public void funActualizarGrid()
        {
            clasnegocio negocio = new clasnegocio();        //datos que se mostraran en el grid 
            negocio.funconsultarRegistros("movimientosbancarios", "SELECT movimientosbancarios.codigo_movimiento as Codigo, cuentasinternas.no_cuenta as Cuenta,conceptosbancarios.concepto as Concepto, formas_pago.descripcion as Forma_pago, movimientosbancarios.codigo_cuenta_externa as Beneficiario, monedas.nombre as Moneda, movimientosbancarios.fecha_registro as Fecha_registro, movimientosbancarios.fecha_aplicacion as Fecha_aplicacion, movimientosbancarios.referencia_1 as Referencia, movimientosbancarios.referencia_2 as Referencia2, movimientosbancarios.monto_total as Monto, movimientosbancarios.observaciones as Observaciones, movimientosbancarios.estado as Estado FROM movimientosbancarios,cuentasinternas,conceptosbancarios,formas_pago,monedas WHERE cuentasinternas.codigo_cuenta_interna=movimientosbancarios.codigo_cuenta_interna and movimientosbancarios.codigo_concepto=conceptosbancarios.codigo_concepto and movimientosbancarios.codigo_forma=formas_pago.codigo_forma and movimientosbancarios.codigo_moneda=monedas.codigo_moneda and movimientosbancarios.condicion= '1'", "consulta", grdMovimientos);
        }

        private void grdMovimientos_CellDoubleClick(object senser,DataGridViewCellEventArgs e) {
            string sMensaje = "Editar Movimiento";
            string sEstadoI = "editar";                     //datos que seran enviados al formulario hijo para modificacion y edicion
            string sCodigo = grdMovimientos.Rows[grdMovimientos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sCuenta = grdMovimientos.Rows[grdMovimientos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sConcepto= grdMovimientos.Rows[grdMovimientos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sFormaP= grdMovimientos.Rows[grdMovimientos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sBeneficiario= grdMovimientos.Rows[grdMovimientos.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string sMoneda= grdMovimientos.Rows[grdMovimientos.CurrentCell.RowIndex].Cells[5].Value.ToString();
            string sFechaR= grdMovimientos.Rows[grdMovimientos.CurrentCell.RowIndex].Cells[6].Value.ToString();
            string sFechaA= grdMovimientos.Rows[grdMovimientos.CurrentCell.RowIndex].Cells[7].Value.ToString();
            string sReferencia1= grdMovimientos.Rows[grdMovimientos.CurrentCell.RowIndex].Cells[8].Value.ToString();
            string sReferencia2= grdMovimientos.Rows[grdMovimientos.CurrentCell.RowIndex].Cells[9].Value.ToString();
            string sMonto= grdMovimientos.Rows[grdMovimientos.CurrentCell.RowIndex].Cells[10].Value.ToString();
            string sObservaciones= grdMovimientos.Rows[grdMovimientos.CurrentCell.RowIndex].Cells[11].Value.ToString();
            string sEstado = grdMovimientos.Rows[grdMovimientos.CurrentCell.RowIndex].Cells[12].Value.ToString();
            frmMovimientos temp = new frmMovimientos(sMensaje,sEstadoI,sCodigo,sCuenta,sConcepto,sFormaP,sBeneficiario,sMoneda,sFechaR,sFechaA,sReferencia1,sReferencia2,sMonto,sObservaciones,sEstado);
            temp.FormClosed += new FormClosedEventHandler(temp_FormClosed);         //llamado de formulario movimientos
            temp.Show();
        
        }


        #endregion


        #region    navegador
        private void bntNuevo_Click(object sender, EventArgs e)
        {
            string sMensaje = "Nuevo Movimiento";                   //llamado de formulario cuentas
            string estadoI = "";
            frmMovimientos temp = new frmMovimientos(sMensaje,estadoI,"","","","","","","","","","","","","");
            temp.FormClosed += new FormClosedEventHandler(temp_FormClosed);
            temp.Show();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio negocio = new clasnegocio();        //funcion para ir al primer registro
            negocio.funPrimero(grdMovimientos);
        }

        private void bntAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio negocio = new clasnegocio();        //funcion para retroceder un registro 
            negocio.funAnterior(grdMovimientos);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio negocio = new clasnegocio();        //funcion para avanzar un registro
            negocio.funSiguiente(grdMovimientos);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio negocio = new clasnegocio();        //fucnion para avancar al final de la lista
            negocio.funUltimo(grdMovimientos);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();                            //funcion de acutalizacion de grid
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("movimientosbancarios");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();                  //funcion de busqueda personalizada en funcion del grid
            clasnegocio cn = new clasnegocio();
            cn.funconsultarRegistros("movimientosbancarios", query, "consulta", grdMovimientos);

        }

        #endregion    
    }
}

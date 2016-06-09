using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;using Seguridad;using SeguridadGrafico;
using FiltradoGrids;

namespace ZORBANK
{
    //Programador y analista: Jose Alberto oxcal Ley
    public partial class frmConsultaCuentas : Form
    {
        public frmConsultaCuentas()
        {
            InitializeComponent();
            funActualizarGrid();
        }
        
        private void frmConsultaCuentas_Load(object sender, EventArgs e)
        {
            
        }

        private void temp_FormClosed(object sender, FormClosedEventArgs e) {
            funActualizarGrid();
        }

        #region grid cuentas
        public void funActualizarGrid()
        {
            clasnegocio negocio = new clasnegocio();
            negocio.funconsultarRegistros("cuentasinternas", "SELECT cuentasinternas.codigo_cuenta_interna AS Codigo, empresa.razon_social AS Empresa,cuentasinternas.fecha_apertura AS Apertura,cuentasinternas.no_cuenta as No_cuenta,bancos.nombre as Banco,cuentasinternas.nombre_cuenta as Tipo_Cuenta,monedas.nombre as Moneda,cuentasinternas.siguiente_cheque as Cheque,cuentasinternas.estado as Estado FROM proyecto2.cuentasinternas,proyecto2.bancos,proyecto2.empresa,proyecto2.monedas WHERE cuentasinternas.codigo_empresa=empresa.codigo_empresa and cuentasinternas.codigo_banco=bancos.codigo_banco and cuentasinternas.codigo_moneda=monedas.codigo_moneda and cuentasinternas.condicion= '1'", "consulta", grdCuentas);       
        }

        private void grdCuentas_CellDoubleClick(object sender, DataGridViewCellEventArgs e) {
            string sMensaje = "Editar Cuenta";
            string sEstadoI="editar";
            string sCodigo = grdCuentas.Rows[grdCuentas.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sEmpresa = grdCuentas.Rows[grdCuentas.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sFecha = grdCuentas.Rows[grdCuentas.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sCuenta = grdCuentas.Rows[grdCuentas.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sBanco = grdCuentas.Rows[grdCuentas.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string sTipocuenta = grdCuentas.Rows[grdCuentas.CurrentCell.RowIndex].Cells[5].Value.ToString();
            string sMoneda = grdCuentas.Rows[grdCuentas.CurrentCell.RowIndex].Cells[6].Value.ToString();
            string sCheque = grdCuentas.Rows[grdCuentas.CurrentCell.RowIndex].Cells[7].Value.ToString();
            string sEstado = grdCuentas.Rows[grdCuentas.CurrentCell.RowIndex].Cells[8].Value.ToString();
            frmCuentas temp = new frmCuentas(sMensaje,sEstadoI,sCodigo,sEmpresa,sFecha,sCuenta,sBanco,sTipocuenta,sMoneda,sCheque,sEstado);
            temp.FormClosed += new FormClosedEventHandler(temp_FormClosed); 
            temp.Show();
        }

        #endregion

        #region    navegador
        private void bntNuevo_Click(object sender, EventArgs e)
        {
            string sMensaje = "Nueva cuenta";                   //llamado de formulario cuentas
            string estadoI = "";
            frmCuentas temp = new frmCuentas(sMensaje,estadoI,"","","","","","","","","");
            temp.FormClosed += new FormClosedEventHandler(temp_FormClosed);
            temp.Show();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio negocio = new clasnegocio();
            negocio.funPrimero(grdCuentas);
        }

        private void bntAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio negocio = new clasnegocio();
            negocio.funAnterior(grdCuentas);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio negocio = new clasnegocio();
            negocio.funSiguiente(grdCuentas);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio negocio = new clasnegocio();
            negocio.funUltimo(grdCuentas);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("cuentasinternas");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            clasnegocio cn = new clasnegocio();
            cn.funconsultarRegistros("cuentasinternas",query,"consulta",grdCuentas);
        }
        
        #endregion    

        private void button1_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }
    
    }
}

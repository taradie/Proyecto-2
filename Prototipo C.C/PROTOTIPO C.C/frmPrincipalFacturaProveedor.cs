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
using System.Data.Odbc;

namespace PROTOTIPO_C.C
{
    public partial class frmPrincipalFacturaProveedor : Form
    {
        public frmPrincipalFacturaProveedor()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("facturaproveedor", "SELECT codfacturaprov as NoFactura, concat(proveedor.codproveedor, '.' ,proveedor.nombre) as Proveedor, total as Total, saldo as Saldo, fecha as Fecha, facturaproveedor.estado as Estado from facturaproveedor, proveedor WHERE facturaproveedor.condicion = '1' and facturaproveedor.codproveedor = proveedor.codproveedor and facturaproveedor.saldo < facturaproveedor.total", "consulta", grdConceptos);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmFacturaProveedor temp = new frmFacturaProveedor();
            temp.Show();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdConceptos);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdConceptos);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdConceptos);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdConceptos);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }

        private void grdConceptos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sNo = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sProveedor = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sTotal = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sSaldo = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sFecha = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string sEstado = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[5].Value.ToString();

            frmFacturaProveedor temp = new frmFacturaProveedor(sNo, sProveedor, sTotal, sSaldo, sFecha, sEstado);
            temp.Show();

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("cuentascorrientesproveedores");
                abc.ShowDialog(this);
                string query = abc.ObtenerQuery();

                ReporteCC objRpt = new ReporteCC();
                OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
                DataSet1 dt = new DataSet1();
                adp.Fill(dt, "cuentascorrientesproveedores");
                objRpt.SetDataSource(dt);

                frmVistaReporte vista = new frmVistaReporte();
                vista.crystalReportViewer1.ReportSource = objRpt;
                vista.Show();
            }catch{
                
            }
            
        }

    }
}

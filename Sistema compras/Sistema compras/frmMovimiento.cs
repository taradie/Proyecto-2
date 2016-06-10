using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionODBC;
using System.Data.Odbc;
using Navegador;

namespace Sistema_compras
{
    public partial class frmMovimiento : Form
    {
        public frmMovimiento()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmIngresoEgreso r = new frmIngresoEgreso();

            r.ShowDialog(this);
            funActualizarGrid();
        
        }
        public void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("movimientoinventario", "SELECT codNota As 'Codigo de Nota', fecha As 'Fecha ingreso', nombreProducto As 'Nombre del producto',CantidadProd As 'Cantidad Ingresada',nomProvee, TipoMov As 'Tipo de Movimiento', concepto AS 'Concepto Movimiento'  FROM movimientoinventario ", "consulta", grdInventario);
        }
        
      

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("movimientoinventario");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            //string query = "select * from usuario";
            MessageBox.Show(query);

            ReporteMovimientos objRpt = new ReporteMovimientos();
            OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
            DataSet1 dt = new DataSet1();
            adp.Fill(dt, "movimientoinventario");
            objRpt.SetDataSource(dt);

            frmVistaReporte vista = new frmVistaReporte();
            vista.crystalReportViewer1.ReportSource = objRpt;
            vista.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnIrPrimero_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdInventario);
        }

        private void btnAnterior_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdInventario);
        }

        private void btnSiguiente_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdInventario);
        }

        private void btnIrUltimo_Click_1(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdInventario);
        }

        private void frmMovimiento_Load(object sender, EventArgs e)
        {

        }
    
    }
}

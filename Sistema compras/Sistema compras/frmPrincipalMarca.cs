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

namespace Sistema_compras
{
    public partial class frmPrincipalMarca : Form
    {
        public frmPrincipalMarca()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMarca m = new frmMarca();
            m.Show();
        }
        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("marca", "SELECT codmarca as Codigo,descripcion as Marca,comision as Comision,estado as Estado FROM marca where condicion=1", "consulta", grdMarca);
        }

        private void grdMarca_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCodigo = grdMarca.Rows[grdMarca.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sMarca = grdMarca.Rows[grdMarca.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sComision = grdMarca.Rows[grdMarca.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sEstado = grdMarca.Rows[grdMarca.CurrentCell.RowIndex].Cells[3].Value.ToString();
            frmMarca m = new frmMarca(sCodigo, sMarca,sComision,sEstado);
            m.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdMarca);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdMarca);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdMarca);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdMarca);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("proveedor");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("proveedor", query, "consulta", grdMarca);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try{
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("marca");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            //string query = "select * from usuario";
            MessageBox.Show(query);

            ReporteMarca objRpt = new ReporteMarca();
            OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
            DataSet1 dt = new DataSet1();
            adp.Fill(dt, "marca");
            objRpt.SetDataSource(dt);

            frmVistaReporte vista = new frmVistaReporte();
            vista.crystalReportViewer1.ReportSource = objRpt;
            vista.Show();
            }catch(Exception){
            MessageBox.Show("Lo sentimos el Repote no se puede Generar");
            }
        }

       

    }
}

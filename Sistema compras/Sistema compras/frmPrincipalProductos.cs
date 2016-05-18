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
using FiltradoGrids;
using System.Data.Odbc;
using ConexionODBC;

namespace Sistema_compras
{
    public partial class frmPrincipalProductos : Form
    {
        public frmPrincipalProductos()
        {
            InitializeComponent();
            funActualizarGrid();
        }
        
        #region botones navegador

            private void button1_Click(object sender, EventArgs e)
            {
                FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("producto");
                abc.ShowDialog(this);
                string query = abc.ObtenerQuery();
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistros("producto", query, "consulta", grdInventario);
            }

            private void btnNuevo_Click(object sender, EventArgs e)
            {
                frmProducto TEM = new frmProducto();
                TEM.ShowDialog(this);
                funActualizarGrid();
            }

            private void btnRefrescar_Click(object sender, EventArgs e)
            {
                funActualizarGrid();
            }

            private void btnSiguiente_Click(object sender, EventArgs e)
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funSiguiente(grdInventario);
            }

            private void btnImprimir_Click(object sender, EventArgs e)
            {
                FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("producto");
                abc.ShowDialog(this);
                string query = abc.ObtenerQuery();
                
                ReporteProductos objRpt = new ReporteProductos();
                OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
                DataSet1 dt = new DataSet1();
                adp.Fill(dt, "producto");
                objRpt.SetDataSource(dt);

                frmVistaReporte vista = new frmVistaReporte();
                vista.crystalReportViewer1.ReportSource = objRpt;
                vista.Show();

            }

            private void btnBuscar_Click(object sender, EventArgs e)
            {
                Help.ShowHelp(this, helpProvider1.HelpNamespace);
            }

            private void btnIrPrimero_Click(object sender, EventArgs e)
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funPrimero(grdInventario);
            }

            private void btnAnterior_Click(object sender, EventArgs e)
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funAnterior(grdInventario);
            }

            private void btnIrUltimo_Click(object sender, EventArgs e)
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funUltimo(grdInventario);
            }

        #endregion

        #region funciones de tablas

            private void funActualizarGrid()
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistros("producto", "SELECT * FROM viewproducto", "consulta", grdInventario);
            }

            private void grdInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                try{
                    string sCodProducto = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    string sNombre = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[1].Value.ToString();
                    string sDescripcion = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[2].Value.ToString();
                    string sMarca = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[3].Value.ToString();
                    string sProveedor = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[4].Value.ToString();
                    string sLinea = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[5].Value.ToString();
                    string sTamano = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[6].Value.ToString();
                    string sCosto = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[7].Value.ToString();
                    string sPrecio = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[8].Value.ToString();
                    string sExistencia = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[9].Value.ToString();
                    string sExmin = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[10].Value.ToString();
                    string sExmax = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[11].Value.ToString();
                    string sCosteo = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[12].Value.ToString();
                    string sTipo = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[13].Value.ToString();
                    string sFecha = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[14].Value.ToString();
                    string sVenta = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[15].Value.ToString();
                    string sCompra = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[16].Value.ToString();
                    string sComision = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[17].Value.ToString();
                    string sEstado = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[18].Value.ToString();
            
                    frmProducto temp = new frmProducto(sCodProducto,sNombre,sDescripcion,sMarca,sProveedor,
                        sLinea,sTamano,sCosto,sPrecio,sExistencia,sExmin,sExmax,sCosteo,sTipo,sFecha,sVenta,sCompra,sComision,sEstado);
                    temp.ShowDialog(this);
                    funActualizarGrid();
                }
                catch (Exception){
                    MessageBox.Show("No puede editar el datos si no se encuentra toda la informacion del regsitro");
                }
            }

        #endregion
    }
}

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
    public partial class frmPrincipalExistencias : Form
    {
        public frmPrincipalExistencias()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        #region BotonesNavegador

            private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmExistencias TEM = new frmExistencias();
            TEM.ShowDialog(this);
            funActualizarGrid();
        }

        #endregion

        #region Funciones de Tablas
        
            private void funActualizarGrid()
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistros("existencias", "SELECT * FROM viewexistencias", "consulta", grdExistencias);
            }

            private void grdExistencias_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
            {
                //try
                //{
                    string sExistencia = grdExistencias.Rows[grdExistencias.CurrentCell.RowIndex].Cells[0].Value.ToString();
                    string sAlmacen = grdExistencias.Rows[grdExistencias.CurrentCell.RowIndex].Cells[1].Value.ToString();
                    string sCodProducto = grdExistencias.Rows[grdExistencias.CurrentCell.RowIndex].Cells[2].Value.ToString();
                    string sIngreso = grdExistencias.Rows[grdExistencias.CurrentCell.RowIndex].Cells[6].Value.ToString();
                    string sEgreso = grdExistencias.Rows[grdExistencias.CurrentCell.RowIndex].Cells[7].Value.ToString();

                    frmExistencias temp = new frmExistencias(sExistencia, sAlmacen, sCodProducto, sIngreso, sEgreso);
                    temp.ShowDialog(this);
                    funActualizarGrid();
                //}
                //catch (Exception)
                //{
                //    MessageBox.Show("No puede editar el datos si no se encuentra toda la informacion del regsitro");
                //}
            }

        #endregion

        #region Botones

            private void button1_Click(object sender, EventArgs e)
            {
                FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("existencias");
                abc.ShowDialog(this);
                string query = abc.ObtenerQuery();
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funconsultarRegistros("existencias", query, "consulta", grdExistencias);
            }

            private void btnRefrescar_Click(object sender, EventArgs e)
            {
                funActualizarGrid();
            }

            private void btnIrPrimero_Click(object sender, EventArgs e)
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funPrimero(grdExistencias);
            }

            private void btnAnterior_Click(object sender, EventArgs e)
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funAnterior(grdExistencias);
            }

            private void btnSiguiente_Click(object sender, EventArgs e)
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funSiguiente(grdExistencias);
            }

            private void btnIrUltimo_Click(object sender, EventArgs e)
            {
                clasnegocio cnegocio = new clasnegocio();
                cnegocio.funUltimo(grdExistencias);
            }

            private void btnImprimir_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("existencias");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();

            ReporteExistencias objRpt = new ReporteExistencias();
            OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
            DataSet1 dt = new DataSet1();
            adp.Fill(dt, "existencias");
            objRpt.SetDataSource(dt);

            frmVistaReporte vista = new frmVistaReporte();
            vista.crystalReportViewer1.ReportSource = objRpt;
            vista.Show();
        }

        #endregion

            
    }
}

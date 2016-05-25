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
    public partial class frmPrincipalOrdenCompra : Form
    {
        public frmPrincipalOrdenCompra()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("encabezado_doccompra", "SELECT encabezado_doccompra.codencabezado as No_Documento,encabezado_doccompra.fecha as FechaCreacion,encabezado_doccompra.estado estado FROM encabezado_doccompra WHERE encabezado_doccompra.condicion=1 ", "consulta", grdOrdenCompra);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("encabezado_doccompra");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("encabezado_doccompra", query, "consulta",grdOrdenCompra);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("encabezado_doccompra");
                abc.ShowDialog(this);
                string query = abc.ObtenerQuery();
                //string query = "select * from usuario";
                MessageBox.Show(query);

                ReporteOrdenCompra objRpt = new ReporteOrdenCompra();
                OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
                DataSet1 dt = new DataSet1();
                adp.Fill(dt, "encabezado_doccompra");
                objRpt.SetDataSource(dt);

                frmVistaReporte vista = new frmVistaReporte();
                vista.crystalReportViewer1.ReportSource = objRpt;
                vista.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos el Repote no se puede Generar");
            }
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdOrdenCompra);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdOrdenCompra);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdOrdenCompra);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdOrdenCompra);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //string debug = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            //String ruta = debug + @"\Proveedores.chm";
            //Help.ShowHelp(this, ruta, HelpNavigator.Topic, "Manual de usuario");
        }

        private void grdOrdenCompra_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //string sCodigo = grdMarca.Rows[grdMarca.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //frmMarca m = new frmMarca(sCodigo, sMarca, sComision, sEstado);
            //m.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCreacionOc temp = new frmCreacionOc();
            temp.Show();
        }
    }
}

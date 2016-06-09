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
using ConexionODBC;
using System.Data.Odbc;

namespace ZORBANK
{
    public partial class frmPrincipalConceptos : Form
    {
        public frmPrincipalConceptos()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("conceptosbancarios", "SELECT codigo_concepto as Codigo, concepto as Concepto, descripcion as Descripcion, estado as Estado from conceptosbancarios WHERE estado = '1'", "consulta", grdFacultad);
            ConexionODBC.Conexion.CerrarConexion();
        }
        private void frmPrincipalConceptos_Load(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void grdFacultad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            frmConceptos temp = new frmConceptos();
            temp.Show();
        
        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("conceptobancarios");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            //string query = "select * from usuario";
            MessageBox.Show(query);

            ReporteConcepto objRpt = new ReporteConcepto();
            OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
            DataSet1 dt = new DataSet1();
            adp.Fill(dt, "conceptosbancarios");
            objRpt.SetDataSource(dt);
            ConexionODBC.Conexion.CerrarConexion();

            frmVistaReporte vista = new frmVistaReporte();
            vista.crystalReportViewer1.ReportSource = objRpt;
            vista.Show();            
        }
    }
}

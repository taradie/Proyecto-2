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
using ConexionODBC;
using System.Data.Odbc;
namespace ZORBANK
{
    public partial class frmPrincipalFPcs : Form
    {

        public frmPrincipalFPcs()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void frmPrincipalFPcs_Load(object sender, EventArgs e)
        {

        }
        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("forma_pago", "SELECT formas_pago.descripcion as Descripcion, formas_pago.codigo_tipo_forma as Tipo, tipoformapago.tipo_forma as Forma from formas_pago,tipoformapago ", "consulta", grdFacultad);
            ConexionODBC.Conexion.CerrarConexion();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            frmFormasPago temp = new frmFormasPago();
            temp.Show();
        }

        private void grdFacultad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("formas_pago");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            //string query = "select * from usuario";
            MessageBox.Show(query);

            ReporteFormas objRpt = new ReporteFormas();
            OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
            DataSet1 dt = new DataSet1();
            adp.Fill(dt, "formas_pago");
            objRpt.SetDataSource(dt);
            ConexionODBC.Conexion.CerrarConexion();

            frmVistaReporte vista = new frmVistaReporte();
            vista.crystalReportViewer1.ReportSource = objRpt;
            vista.Show();            
        }
    }
}

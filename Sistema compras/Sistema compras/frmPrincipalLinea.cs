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
using Seguridad;


namespace Sistema_compras
{
    public partial class frmPrincipalLinea : Form
    {
        public frmPrincipalLinea()
        {
            InitializeComponent();
            funActualizarGrid();
        }
        public void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("linea", "SELECT codlinea As 'Codigo de Linea',comision As 'Comision de Linea', estado As 'Estado', descripcion As 'Descripcion Linea'  FROM linea ", "consulta", grdInventario);
            claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Consulta", "linea");
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtcondi l = new txtcondi();
            l.ShowDialog(this);
            funActualizarGrid();
        }

        private void frmPrincipalLinea_Load(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void grdInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCodLinea = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sComision = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sEstado = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sDescrpcion = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[3].Value.ToString();
            txtcondi m = new txtcondi(sCodLinea, sEstado, sDescrpcion, sComision);
       
            m.ShowDialog(this);
            funActualizarGrid();
            m.txtdesc.Enabled = true;
            m.txtcomi.Enabled = true;
        }

       
        private void grdInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCodLinea = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sComision = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sEstado = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sDescrpcion = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[3].Value.ToString();
            
            txtcondi m = new txtcondi(sCodLinea, sEstado, sDescrpcion, sComision);
            funActualizarGrid();
            m.ShowDialog(this);
            m.txtdesc.Enabled = true;
           
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, ayuda.HelpNamespace);
        }

        private void btnBuscar_HelpRequested(object sender, HelpEventArgs hlpevent)
        {


        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("linea");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            //string query = "select * from usuario";
            MessageBox.Show(query);

            ReporteLinea objRpt = new ReporteLinea();
            OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
            DataSet1 dt = new DataSet1();
            adp.Fill(dt, "linea");
            objRpt.SetDataSource(dt);

            frmVistaReporte vista = new frmVistaReporte();
            vista.crystalReportViewer1.ReportSource = objRpt;
            vista.Show();
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

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdInventario);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdInventario);
        }
    }
}

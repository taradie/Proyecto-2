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
    public partial class frmPrincipalAlmacen : Form
    {
        public frmPrincipalAlmacen()
        {
            InitializeComponent();
            funActualizarGrid();
        }
        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("almacen", "SELECT codalmacen As 'Codigo Almacen',codigo_empresa As 'Codigo Empresa' ,nombre As 'Nombre Bodega',tamano As 'Tamano de Bodega',disponibilidad As 'Disponibilidad',estado As 'Estado del Almacen',ubicacion As 'Ubicacion Almacen' FROM almacen ", "consulta", grdInventario);
            claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Consulta", "almacen");
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmAlmacen r = new frmAlmacen();
            r.ShowDialog(this);
            funActualizarGrid();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void grdInventario_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCodAlmacen = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[0].Value.ToString();
            
            string sCodEmpresa = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sNombre = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sTamano = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sDisponibilidad = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[5].Value.ToString();
            string sAct = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[6].Value.ToString();
            string sUbicacion = grdInventario.Rows[grdInventario.CurrentCell.RowIndex].Cells[7].Value.ToString();
            
                      

            frmAlmacen m = new frmAlmacen(sCodAlmacen, sCodEmpresa, sNombre, sTamano,sDisponibilidad,sAct,sUbicacion);
            m.ShowDialog(this);
          
            m.txtempresa.Enabled = true;
            m.txtTamano.Enabled = true;
            m.txtubicacion.Enabled = true;
            m.txtnombre.Enabled = true;
            m.txtdispo.Enabled = true;
           
        }

        private void grdInventario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void frmPrincipalAlmacen_Load(object sender, EventArgs e)
        {

        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, ayuda.HelpNamespace);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("almacen");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            //string query = "select * from usuario";
            MessageBox.Show(query);

            ReporteAlmacen objRpt = new ReporteAlmacen();
            OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
            DataSet1 dt = new DataSet1();
            adp.Fill(dt, "almacen");
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

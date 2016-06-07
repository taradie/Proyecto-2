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
using FiltradoGrids;

namespace PROTOTIPO_C.C
{
    public partial class frmPrincipalConcepto : Form
    {
        public frmPrincipalConcepto()
        {
            InitializeComponent();
            funActualizarGrid();
        }
        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("conceptos", "SELECT codigo_tipo_transaccion as Codigo, tipo as Tipo, descripcion as Descripcion, estado as Estado FROM conceptos WHERE condicion = 'ACTIVO' ", "consulta", grdConceptos);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmConceptos temp = new frmConceptos();
            temp.ShowDialog();
            funActualizarGrid();
        }

        private void grdConceptos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCod = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sTipo = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sDescripcion = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sEstado = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            frmConceptos temp = new frmConceptos(sCod, sTipo, sDescripcion, sEstado);
            temp.ShowDialog();
            funActualizarGrid();
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

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("conceptos");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("conceptos", query, "consulta", grdConceptos);
        }
    }
}

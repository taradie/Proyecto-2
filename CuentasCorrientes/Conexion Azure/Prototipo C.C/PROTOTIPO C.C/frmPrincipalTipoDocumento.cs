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
    public partial class frmPrincipalTipoDocumento : Form
    {
        public frmPrincipalTipoDocumento()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("tipodocumento", "SELECT codtipodocumento as Codigo, tipo as Tipo, descripcion as Descripcion, estado as Estado  FROM tipodocumento WHERE condicion = 'ACTIVO'", "consulta", grdDocumentos);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmTipoDocumento temp = new frmTipoDocumento();
            temp.ShowDialog();
            funActualizarGrid();

        }

        private void grdDocumentos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCod = grdDocumentos.Rows[grdDocumentos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sTipo = grdDocumentos.Rows[grdDocumentos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sDescripcion = grdDocumentos.Rows[grdDocumentos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sEstado = grdDocumentos.Rows[grdDocumentos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            frmTipoDocumento temp = new frmTipoDocumento(sCod, sTipo, sDescripcion, sEstado);
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
            cnegocio.funPrimero(grdDocumentos);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdDocumentos);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdDocumentos);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdDocumentos);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("tipodocumento");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("tipodocumentos", query, "consulta", grdDocumentos);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {

        }
    }
}

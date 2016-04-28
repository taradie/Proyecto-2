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

namespace PROTOTIPO_C.C
{
    public partial class frmPrincipalFormaPago : Form
    {
        public frmPrincipalFormaPago()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("formas_pago", "SELECT codigo_forma as Codigo, descripcion as Descripcion from formas_pago ", "consulta", grdFormasPago);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmFormasPago temp = new frmFormasPago();
            temp.Show();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdFormasPago);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdFormasPago);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdFormasPago);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdFormasPago);
        }

        private void grdFormasPago_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCod = grdFormasPago.Rows[grdFormasPago.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sNombre = grdFormasPago.Rows[grdFormasPago.CurrentCell.RowIndex].Cells[1].Value.ToString();
            frmFormasPago temp = new frmFormasPago(sCod, sNombre);
            temp.Show();
        }
    }
}

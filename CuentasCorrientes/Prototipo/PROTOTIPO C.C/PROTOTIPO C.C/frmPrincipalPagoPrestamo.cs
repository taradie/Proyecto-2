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
    public partial class frmPrincipalPagoPrestamo : Form
    {
        public frmPrincipalPagoPrestamo()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("prestamo", "SELECT prestamo.codPrestamo AS CODIGO, personas.dpi AS DPI, CONCAT(empleado.cod_empleado, ' ', personas.nombres,' ', personas.apellidos) AS NOMBRE , prestamo.fecha AS FECHA, prestamo.interes AS INTERES, prestamo.pagos AS PAGOS, prestamo.total as TOTAL FROM prestamo, empleado, personas WHERE empleado.codigo_persona=personas.codigo_persona AND prestamo.cod_empleado=empleado.cod_empleado AND prestamo.estado='ACTIVO' AND prestamo.condicion='ACTIVO' ", "consulta", grdPrestamos);
        }

        private void grdPrestamos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string sCodPrestamo = grdPrestamos.Rows[grdPrestamos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sDPI = grdPrestamos.Rows[grdPrestamos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sNombre = grdPrestamos.Rows[grdPrestamos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sFecha = grdPrestamos.Rows[grdPrestamos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sInteres = grdPrestamos.Rows[grdPrestamos.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string sPagos = grdPrestamos.Rows[grdPrestamos.CurrentCell.RowIndex].Cells[5].Value.ToString();
            string sTotal = grdPrestamos.Rows[grdPrestamos.CurrentCell.RowIndex].Cells[6].Value.ToString();
            
            frmPagoPrestamos m = new frmPagoPrestamos(sCodPrestamo);
            m.ShowDialog();
            funActualizarGrid();

        }

        private void grdPrestamos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdPrestamos);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdPrestamos);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdPrestamos);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdPrestamos);
        }
    }
}

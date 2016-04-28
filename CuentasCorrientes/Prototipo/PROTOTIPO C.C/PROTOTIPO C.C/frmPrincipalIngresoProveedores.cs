using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using Navegador;

namespace PROTOTIPO_C.C
{
    public partial class frmPrincipalIngresoProveedores : Form
    {
        public frmPrincipalIngresoProveedores()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("proveedor", "SELECT codproveedor as Codigo,nombre as Nombre, direccion as Direccion, nit as Nit, telefono as Telefono, descripcion as Descripcion, cuenta as Cuenta, estado as Estado from proveedor WHERE estado = 'ACTIVO' ", "consulta", grdProveedores);
        }

        private void frmPrincipalIngresoProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmIngresoProveedores temp = new frmIngresoProveedores();
            temp.Show();
        }

        private void grdProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCod = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sNombre = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sDireccion = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sNit = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sTelefono = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string sDescripcion = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[5].Value.ToString();
            string sCuenta = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[6].Value.ToString();
            frmIngresoProveedores temp = new frmIngresoProveedores(sCod, sNombre, sDireccion, sNit, sTelefono, sDescripcion, sCuenta);
            temp.Show();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdProveedores);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdProveedores);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdProveedores);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdProveedores);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}


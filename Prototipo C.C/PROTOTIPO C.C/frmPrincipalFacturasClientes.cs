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

namespace PROTOTIPO_C.C
{
    public partial class frmPrincipalFacturasClientes : Form
    {
        public frmPrincipalFacturasClientes()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("factura", "SELECT factura.ncodfactura AS Codigo, factura.vserie AS Serie, factura.nombre AS Nombre, factura.nit AS Nit, concat(factura.ncodcliente, '.', cliente.nombrecliente, ' ', cliente.apellidocliente) AS Cliente, factura.fechafactura AS Fecha, factura.fechavencimiento AS Vencimiento, factura.total AS Total, factura.saldo AS Saldo FROM factura, cliente WHERE factura.ncodcliente = cliente.ncodcliente AND factura.saldo < factura.total AND factura.condicion = '1'", "consulta", grdConceptos);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
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

        private void grdConceptos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCod = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sSerie = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sNombre = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sNit = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sCliente = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string sFecha = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[5].Value.ToString();
            string sVencimiento = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[6].Value.ToString();
            string sTotal = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[7].Value.ToString();
            string sSaldo = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[8].Value.ToString();

            frmFacturaCliente temp = new frmFacturaCliente(sCod, sSerie, sNombre, sNit, sCliente, sFecha, sVencimiento, sTotal, sSaldo);
            temp.ShowDialog();
            funActualizarGrid();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            frmNuevaFacturaCliente temp = new frmNuevaFacturaCliente();
            temp.ShowDialog();
            funActualizarGrid();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string debug = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            String ruta = debug + @"\Manual de Usuario Mantenimiento Factura.chm";
            Help.ShowHelp(this, ruta, HelpNavigator.Topic, "Manual de usuario");
        }
    }
}

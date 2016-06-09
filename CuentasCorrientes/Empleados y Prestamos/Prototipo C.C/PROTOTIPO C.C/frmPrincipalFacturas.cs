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
using FiltradoGrids;
namespace PROTOTIPO_C.C
{
    public partial class frmPrincipalFacturas : Form
    {
        public frmPrincipalFacturas()
        {
            InitializeComponent(); funActualizarGrid();
        }
        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("conceptos", "SELECT tipofactura.tipo as Factura, vserie as Serie, ncodfactura as No, factura.nombre as Nombre, factura.nit as Nit, fechafactura as Creacion, fechavencimiento as Vencimiento, concat(factura.ncodcliente,'.', cliente.nombrecliente) as Cliente, concat(factura.codproveedor,'.',proveedor.nombre) as Proveedor, factura.moneda as Moneda, total as TOTAL, factura.estado as Estado FROM factura, tipofactura, cliente, proveedor WHERE factura.condicion = '1' and tipofactura.codTipoFactura = factura.codTipoFactura and (cliente.ncodcliente = factura.ncodcliente OR proveedor.codproveedor = factura.codproveedor) ", "consulta", grdConceptos);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmFacturas temp = new frmFacturas();
            temp.Show();

           
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("factura");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("conceptos", query, "consulta", grdConceptos);
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

        }

        private void grdConceptos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sTipo = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sSerie = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sFactura = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sNombre = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sNit = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string sFecha = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[5].Value.ToString();
            string sFechaVencimiento = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[6].Value.ToString();
            string sCliente = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[7].Value.ToString();
            string sProveedor = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[8].Value.ToString();
            string sMoneda = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[9].Value.ToString();
            string sTotal = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[10].Value.ToString();
            string sEstado = grdConceptos.Rows[grdConceptos.CurrentCell.RowIndex].Cells[11].Value.ToString();
           if(sTipo.Equals("Cliente")){
                frmFacturas temp = new frmFacturas(sSerie, sFactura, sNombre, sNit, sFecha, sFechaVencimiento, sCliente, sProveedor, sMoneda, sTotal, sEstado);
                temp.tabControl1.SelectedTab = temp.Abonos;
                temp.ShowDialog(this);
                funActualizarGrid();
           }
           else if (sTipo.Equals("Proveedor"))
           {
               frmFacturas temp = new frmFacturas(sSerie, sFactura, sNombre, sNit, sFecha, sFechaVencimiento, sCliente, sProveedor, sMoneda, sTotal, sEstado);
                temp.tabControl1.SelectedTab = temp.Cargos;
                temp.ShowDialog(this);
                funActualizarGrid();
            }
            
        }
    }
}

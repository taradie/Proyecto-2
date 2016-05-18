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
namespace Sistema_compras
{
    public partial class frmProveedor : Form
    {
        
        public frmProveedor()
        {
            InitializeComponent();
            funActualizarGrid();
        }
        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("proveedor", "SELECT CONCAT(codproveedor,'.',nombre) AS proveedor,direccion AS Direccion,nit AS Nit,telefono AS Telefono,descripcion as Descripcion,cuenta as NoCuenta,estado as Status FROM proveedor", "consulta", grdProveedores);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCreacionProv f = new frmCreacionProv();
            f.Show();
        }

        private void grdProveedores_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string snombre = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[0].Value.ToString();
                string sdireccion = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string snit = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[2].Value.ToString();
                string stelefono = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[3].Value.ToString();
                string sdescripcion = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[4].Value.ToString();
                string scuenta = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[5].Value.ToString();
                string sestado = grdProveedores.Rows[grdProveedores.CurrentCell.RowIndex].Cells[6].Value.ToString();
                string[] codigonombre = snombre.Split('.');
                string cod = codigonombre[0];
                string nom = codigonombre[1];
                frmCreacionProv temp = new frmCreacionProv(cod, nom, sdireccion, snit, stelefono, sdescripcion, scuenta, sestado);
                temp.Show();
            }catch (Exception){
                MessageBox.Show("No se puede editar este dato");
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("proveedor");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("proveedor", query, "consulta", grdProveedores);
        }

    }
}

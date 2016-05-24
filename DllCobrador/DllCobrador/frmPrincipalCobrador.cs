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

namespace DllCobrador
{
    public partial class frmPrincipalCobrador : Form
    {
        public frmPrincipalCobrador()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("cobrador", "SELECT codCobrador AS Cobrador, nombre AS Nombre, apellido as Apellido, genero AS Genero, correo AS Correo, direccion AS Direccion, telefono AS Telefono, comision AS Comision, estado AS Estado  FROM cobrador WHERE condicion = 'ACTIVO'", "consulta", grdCobrador);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCobrador temp = new frmCobrador();
            temp.ShowDialog();
            funActualizarGrid();
        }

        private void grdCobrador_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCod = grdCobrador.Rows[grdCobrador.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sNombre = grdCobrador.Rows[grdCobrador.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sApellido = grdCobrador.Rows[grdCobrador.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sGenero = grdCobrador.Rows[grdCobrador.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sCorreo = grdCobrador.Rows[grdCobrador.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string sDireccion = grdCobrador.Rows[grdCobrador.CurrentCell.RowIndex].Cells[5].Value.ToString();
            string sTelefono = grdCobrador.Rows[grdCobrador.CurrentCell.RowIndex].Cells[6].Value.ToString();
            string sComision = grdCobrador.Rows[grdCobrador.CurrentCell.RowIndex].Cells[7].Value.ToString();
            string sEstado = grdCobrador.Rows[grdCobrador.CurrentCell.RowIndex].Cells[8].Value.ToString();
            frmCobrador temp = new frmCobrador(sCod, sNombre, sApellido, sGenero, sCorreo, sDireccion, sTelefono, sComision, sEstado);
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
            cnegocio.funPrimero(grdCobrador);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdCobrador);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdCobrador);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdCobrador);
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("cobrador");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("cobrador", query, "consulta", grdCobrador);
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            string debug = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            String ruta = debug + @"\Manual de Usuario Dll Cobrador.chm";
            Help.ShowHelp(this, ruta, HelpNavigator.Topic, "Manual de usuario");
        }
    }
}

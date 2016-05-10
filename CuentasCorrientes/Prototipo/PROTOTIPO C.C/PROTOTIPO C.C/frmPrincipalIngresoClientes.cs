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
    public partial class frmPrincipalIngresoClientes : Form
    {
        public frmPrincipalIngresoClientes()
        {
            InitializeComponent();
            funActualizarGrid();
        }
        public void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("cliente", "SELECT personas.codigo_persona as Codigo, dpi as DPI, nit as Nit, nombres as Nombre, apellidos as Apellido, fechaNacimiento as Fecha, direccion as Diereccino, telefono as Telefono, correo as Correo, sexo as Sexo  FROM personas, cliente WHERE personas.codigo_persona = cliente.codigo_persona and personas.estado = 'ACTIVO' ", "consulta", grdClientes);
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdClientes);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdClientes);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdClientes);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdClientes);
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCodPersona = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sDpi = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sNit = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sNombre = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sApellido = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string sFecha = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[5].Value.ToString();
            string sDireccion = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[6].Value.ToString();
            string sTelefono = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[7].Value.ToString();
            string sEmail = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[8].Value.ToString();
            string sSexo = grdClientes.Rows[grdClientes.CurrentCell.RowIndex].Cells[9].Value.ToString();
            frmIngresoCliente temp = new frmIngresoCliente(sCodPersona, sDpi, sNombre, sApellido, sFecha, sNit, sDireccion, sEmail, sTelefono, sSexo);
            temp.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmIngresoCliente temp = new frmIngresoCliente();
            temp.Show();
        }

        private void frmPrincipalIngresoClientes_Load(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

    }
}

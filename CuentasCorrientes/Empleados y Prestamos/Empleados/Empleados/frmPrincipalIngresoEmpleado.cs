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

namespace Empleados
{
    public partial class frmPrincipalIngresoEmpleadoDLL : Form
    {
        public frmPrincipalIngresoEmpleadoDLL()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("empleado", "SELECT CONCAT(empleado.cod_empleado,'.',personas.codigo_persona) AS Codigo,personas.nombres AS Nombre, personas.apellidos as Apellidos,personas.dpi AS DPI, personas.sexo AS Genero, personas.fechaNacimiento AS FechaNacimiento, personas.direccion AS Diereccion, personas.telefono AS Telefon, personas.nit AS NIT, personas.correo AS Correo, empleado.vmetidoComision AS Comision FROM empleado, personas WHERE empleado.codigo_persona=personas.codigo_persona AND empleado.condicion='ACTIVO' ", "consulta", grdEmpleados);
        }

        private void grdEmpleados_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdEmpleados);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdEmpleados);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdEmpleados);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdEmpleados);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmIngresoEmpleado m = new frmIngresoEmpleado();
            m.Show();
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {

        }

        private void grdEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdEmpleados_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCodEmpleado = grdEmpleados.Rows[grdEmpleados.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sNombre = grdEmpleados.Rows[grdEmpleados.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sApellido = grdEmpleados.Rows[grdEmpleados.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sDpi = grdEmpleados.Rows[grdEmpleados.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sSexo = grdEmpleados.Rows[grdEmpleados.CurrentCell.RowIndex].Cells[4].Value.ToString();
            string sFechaNacimiento = grdEmpleados.Rows[grdEmpleados.CurrentCell.RowIndex].Cells[5].Value.ToString();
            string sDireccion = grdEmpleados.Rows[grdEmpleados.CurrentCell.RowIndex].Cells[6].Value.ToString();
            string sTelefono = grdEmpleados.Rows[grdEmpleados.CurrentCell.RowIndex].Cells[7].Value.ToString();
            string sNIT = grdEmpleados.Rows[grdEmpleados.CurrentCell.RowIndex].Cells[8].Value.ToString();
            string sCorreo = grdEmpleados.Rows[grdEmpleados.CurrentCell.RowIndex].Cells[9].Value.ToString();
            string sComision = grdEmpleados.Rows[grdEmpleados.CurrentCell.RowIndex].Cells[10].Value.ToString();
            frmIngresoEmpleado m = new frmIngresoEmpleado(sCodEmpleado, sNombre, sApellido, sDpi, sSexo, sFechaNacimiento, sDireccion, sTelefono, sNIT, sCorreo, sComision);
            m.Show();
        }
    }
}

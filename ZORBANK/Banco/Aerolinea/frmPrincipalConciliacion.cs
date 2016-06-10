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
using ConexionODBC;
using System.Data.Odbc;
using Seguridad;

namespace ZORBANK
{
    public partial class frmPrincipalConciliacion : Form
    {
        public frmPrincipalConciliacion()
        {
            InitializeComponent();
            funActualizarGrid();
        }
        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("bancos", "SELECT bancos.nombre as Nombre, bancos.nombre_cuenta as Cuenta, bancos.sucursal as Sucursas from bancos ", "consulta", grdFacultad);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmConciliacion temp = new frmConciliacion();
            temp.Show();
        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            frmConciliacion temp = new frmConciliacion();
            temp.Show();
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmConciliacion temp = new frmConciliacion();
            temp.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grdFacultad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCodPersona = grdFacultad.Rows[grdFacultad.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sDpi = grdFacultad.Rows[grdFacultad.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sNombre = grdFacultad.Rows[grdFacultad.CurrentCell.RowIndex].Cells[3].Value.ToString();
            //frmConciliacion temp = new frmConciliacion(sCodPersona, sDpi, sNombre);
            //temp.Show();
        }
    }
}

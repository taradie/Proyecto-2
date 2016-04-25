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


namespace ZORBANK
{
    public partial class frmPrincipalRol : Form
    {
        public frmPrincipalRol()
        {
            InitializeComponent();
            funActualizargrid();
        }
        private void funActualizargrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("rol", "SELECT rol.codigo_rol as Codigo, rol.tipo as TipoRol, rol.descripcion as Descripcion, rol.estado as Estado from rol WHERE rol.condicion = '1'", "consulta", grdrRolPrincipal);
        }

        private void frmPrincipalRol_Load(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizargrid();
        }
        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("rol", " SELECT rol.codigo_rol as Codigo, rol.tipo as TipoRol, rol.descripcion as Descripcion, rol.estado as Estado from rol WHERE rol.condicion = '1' AND rol.tipo LIKE '" + txtBuscar.Text + "%'", "consulta", grdrRolPrincipal);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string sCodTipo = grdrRolPrincipal.Rows[grdrRolPrincipal.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sTipo = grdrRolPrincipal.Rows[grdrRolPrincipal.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sDescripcion = grdrRolPrincipal.Rows[grdrRolPrincipal.CurrentCell.RowIndex].Cells[2].Value.ToString();
            frmRol temp = new frmRol (sCodTipo, sTipo, sDescripcion);
            temp.Show();
        }
 

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmRol rol = new frmRol();
            rol.Show();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cs = new clasnegocio();
            cs.funPrimero(grdrRolPrincipal);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cs = new clasnegocio();
            cs.funAnterior(grdrRolPrincipal);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cs = new clasnegocio();
            cs.funSiguiente(grdrRolPrincipal);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cs = new clasnegocio();
            cs.funUltimo(grdrRolPrincipal);
        }
    }
}

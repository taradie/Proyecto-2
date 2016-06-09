using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;using Seguridad;using SeguridadGrafico;
using ConexionODBC;
using System.Data.Odbc;
namespace ZORBANK
{
    public partial class frmPrincipalBeneficiario : Form
    {
        public frmPrincipalBeneficiario()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmBeneficiario temp = new frmBeneficiario();
            temp.Show();
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {

        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("personas", "SELECT codigo_persona as CodigoPersona,dpi as DPI,nombres as Nombre,apellidos as Apellido,estado as Beneficiario from personas", "consulta", grdFacultad);
        }
        
     
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void grdFacultad_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string sCodPersona = grdFacultad.Rows[grdFacultad.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sDpi = grdFacultad.Rows[grdFacultad.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sNombre = grdFacultad.Rows[grdFacultad.CurrentCell.RowIndex].Cells[4].Value.ToString();
            frmBeneficiario temp = new frmBeneficiario(sCodPersona, sDpi, sNombre);
            temp.Show();
        
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmBeneficiario temp = new frmBeneficiario();
            temp.Show();
        
        }

        private void btnRefrescar_Click_1(object sender, EventArgs e)
        {
            funActualizarGrid();
        }
    }
}

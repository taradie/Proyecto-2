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

namespace ZORBANK
{
    public partial class frmPrincipalConceptos : Form
    {
        public frmPrincipalConceptos()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmConceptos temp = new frmConceptos();
            temp.Show();
        }
        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("conceptosbancarios", "SELECT codigo_concepto as Codigo, concepto as Concepto, descripcion as Descripcion, estado as Estado from conceptosbancarios WHERE estado = '1'", "consulta", grdFacultad);
        }
        private void frmPrincipalConceptos_Load(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }
    }
}

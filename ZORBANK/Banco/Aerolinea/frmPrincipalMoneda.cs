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
    public partial class frmPrincipalMoneda : Form
    {
        public frmPrincipalMoneda()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMoneda temp = new frmMoneda();
            temp.Show();
        }
        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("monedas", "SELECT nombre as Nombre, abreviatura as Abreciatura, fecha_registro as Fecha_registro from monedas ", "consulta", grdPago);
        }
        private void frmPrincipalMoneda_Load(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }
    }
}

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
    public partial class frmPrincipalIngresoProveedores : Form
    {
        public frmPrincipalIngresoProveedores()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("proveedor", "SELECT codproveedor as Codigo,nombre as Nombre, direccion as Direccion, nit as Nit, telefono as Telefono, descripcion as Descripcion, cuenta as Cuenta, estado as Estado from proveedor ", "consulta", grdProveedores);
        }

        private void frmPrincipalIngresoProveedores_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmIngresoProveedores temp = new frmIngresoProveedores();
            temp.Show();
        }
    }
}

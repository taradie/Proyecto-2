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
    public partial class frmPrincipalCambioM : Form
    {
        public frmPrincipalCambioM()
        {
            InitializeComponent();
            funActualizarGrid();
        }
        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("tipocambiomoneda", "SELECT codigo_moneda as CodigoM, fecha_registro as Fecha, tipo_cambio As Cambio from tipocambiomoneda", "consulta", grdFacultad);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMoneda temp = new frmMoneda();
            temp.Show();
        }
    }
}

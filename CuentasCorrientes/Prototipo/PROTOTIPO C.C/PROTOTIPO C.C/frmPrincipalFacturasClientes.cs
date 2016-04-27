using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROTOTIPO_C.C
{
    public partial class frmPrincipalFacturasClientes : Form
    {
        public frmPrincipalFacturasClientes()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmFacturaCliente ver = new frmFacturaCliente();
            ver.Show();
        }
    }
}

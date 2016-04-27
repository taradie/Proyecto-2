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
    public partial class frmPrincipalIngresoProveedores : Form
    {
        public frmPrincipalIngresoProveedores()
        {
            InitializeComponent();
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

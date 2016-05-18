using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_compras
{
    public partial class frmPrincipalBD : Form
    {
        public frmPrincipalBD()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmBaseDatos r = new frmBaseDatos();
            r.Show();
        }
    }
}

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
    public partial class frmOC : Form
    {
        public frmOC()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCreacionOc f = new frmCreacionOc();
            f.Show();
        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {

        }
    }
}

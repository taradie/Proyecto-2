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
    public partial class frmPrincipalImpuestos : Form
    {
        public frmPrincipalImpuestos()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Impuestos a = new Impuestos();
            a.Show();
        }
    }
}

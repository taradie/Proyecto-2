using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZORBANK
{
    public partial class frmPrincipalConciliacion : Form
    {
        public frmPrincipalConciliacion()
        {
            InitializeComponent();
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmConciliacion temp = new frmConciliacion();
            temp.Show();
        }
    }
}

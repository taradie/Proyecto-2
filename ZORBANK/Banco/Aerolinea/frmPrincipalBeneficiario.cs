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
    public partial class frmPrincipalBeneficiario : Form
    {
        public frmPrincipalBeneficiario()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmBeneficiario temp = new frmBeneficiario();
            temp.Show();
        }
    }
}

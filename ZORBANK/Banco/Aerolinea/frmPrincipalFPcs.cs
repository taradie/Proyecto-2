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
    public partial class frmPrincipalFPcs : Form
    {
        public frmPrincipalFPcs()
        {
            InitializeComponent();
        }

        private void frmPrincipalFPcs_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmFormasPago temp = new frmFormasPago();
            temp.Show();
        }
    }
}

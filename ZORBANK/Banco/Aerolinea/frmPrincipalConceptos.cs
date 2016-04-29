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
    public partial class frmPrincipalConceptos : Form
    {
        public frmPrincipalConceptos()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmConceptos temp = new frmConceptos();
            temp.Show();
        }
    }
}

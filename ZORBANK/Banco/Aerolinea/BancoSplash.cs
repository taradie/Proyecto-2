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
    public partial class BancoSplash : Form
    {
        public BancoSplash()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Interval = 5000;
        }

        private void BancoSplash_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            this.DialogResult = DialogResult.OK;
            this.Close();            
        }
    }
}

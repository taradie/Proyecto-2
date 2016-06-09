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
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();            
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;

            timer1.Enabled = true;            
        }
        public void fn_prbar()
        {
            progressBar1.Increment(1);
           // timer1.Start();
            label1.Text = progressBar1.Value.ToString() + "%";
            if(progressBar1.Value==progressBar1.Maximum)
            {
                timer1.Stop();
                this.Hide();                
                frmMenu temp = new frmMenu();
                //FormClienteWeb temp = new FormClienteWeb();
                temp.Show();
                //MultiBD.frmMultiBD temp1 = new MultiBD.frmMultiBD();
                //temp1.Show();
            }             
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fn_prbar();
        }
    }
}

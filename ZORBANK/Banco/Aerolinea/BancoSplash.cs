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
            if (Application.RenderWithVisualStyles)
                progressBar1.Style = ProgressBarStyle.Marquee;
            else
            {
                progressBar1.Style = ProgressBarStyle.Continuous;
                progressBar1.Maximum = 100;
                progressBar1.Value = 0;
            }

            timer1.Enabled = true;
            timer1.Interval = 1000;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value < progressBar1.Maximum && progressBar1.Style != ProgressBarStyle.Marquee)
                this.progressBar1.Increment(5);
            else
                progressBar1.Value = progressBar1.Minimum;
            timer1.Stop();

            //this.DialogResult = DialogResult.OK;
            this.Close();            
        }
    }
}

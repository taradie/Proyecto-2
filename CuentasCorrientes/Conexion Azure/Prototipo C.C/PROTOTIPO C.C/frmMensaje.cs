
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROTOTIPO_C.C
{
    public partial class frmMensaje : Form
    {
        public frmMensaje()
        {
            InitializeComponent();
        }
        public void fn_prbar()
        {
            progressBar1.Increment(1);
           // timer1.Start();
            label1.Text = progressBar1.Value.ToString() + "%";
            if(progressBar1.Value==progressBar1.Maximum){
                timer1.Stop();
                this.Hide();
                frmLogins temp = new frmLogins();
                temp.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            fn_prbar();
        }
    }
}

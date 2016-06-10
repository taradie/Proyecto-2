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
    public partial class PruebaWs : Form
    {
        public PruebaWs()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;
                net.azurewebsites.wslogistica.WsLogistica a = new net.azurewebsites.wslogistica.WsLogistica();
                dataGridView1.DataSource = a.Consultar(textBox1.Text).Tables[0];
                this.Cursor = Cursors.Arrow;
            }
            catch (Exception)
            {
                this.Cursor = Cursors.Arrow;
                MessageBox.Show("no se pudo obtener datos");
            }
            

        }
    }
}

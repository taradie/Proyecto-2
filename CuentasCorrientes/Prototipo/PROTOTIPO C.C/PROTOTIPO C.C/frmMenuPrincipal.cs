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
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void cobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalIngresoClientes temp = new frmPrincipalIngresoClientes();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            //pictureBox1.Visible = false;
            temp.Show();
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalFacturasClientes temp = new frmPrincipalFacturasClientes();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            //pictureBox1.Visible = false;
            temp.Show();
        }

        private void cuentasCorrientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {

        }

        private void pagoProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagos temp = new frmPagos();
            temp.Show();
        }

        private void pagoAEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pagosDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalPagosClientes temp = new frmPrincipalPagosClientes();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            //pictureBox1.Visible = false;
            temp.Show();
        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMoneda temp = new frmMoneda();
            temp.MdiParent = this;
            //pictureBox1.Visible = false;
            temp.Show();
        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmIdioma temp = new frmIdioma();
            temp.MdiParent = this;
            //pictureBox1.Visible = false;
            temp.Show();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalIngresoProveedores temp = new frmPrincipalIngresoProveedores();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void deudasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrincipalFacturaProveedores temp = new frmPrincipalFacturaProveedores();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrestamos temp = new frmPrestamos();
            temp.Show();
        }

        private void formasDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalFormaPago temp = new frmPrincipalFormaPago();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }
    }
}

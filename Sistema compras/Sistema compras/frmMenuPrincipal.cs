using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClaseProveedor;

namespace Sistema_compras
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void ordenesDeCompraPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOC inv = new frmOC();
            inv.WindowState = FormWindowState.Maximized;
            inv.MdiParent = this;
            inv.Show();
        }

        private void inventarioTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimiento inv = new frmMovimiento();
            inv.WindowState = FormWindowState.Maximized;
            inv.MdiParent = this;
            inv.Show(); 
        }

        private void oComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ordenesDeCompraFacturadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //frmProveedor oc = new frmProveedor();
            PrincipalDllProveedor oc = new PrincipalDllProveedor();
            oc.WindowState = FormWindowState.Maximized;
            oc.MdiParent = this;
            oc.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalProductos inv = new frmPrincipalProductos();
            inv.WindowState = FormWindowState.Maximized;
            inv.MdiParent = this;
            inv.Show(); 
        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmConfIdioma oc = new frmConfIdioma();
            oc.WindowState = FormWindowState.Maximized;
            oc.MdiParent = this;
            oc.Show();*/
        }

        private void monedaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmConfMoneda oc = new frmConfMoneda();
            oc.WindowState = FormWindowState.Maximized;
            oc.MdiParent = this;
            oc.Show();*/
        }

        private void crearAlmacenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalAlmacen oc = new frmPrincipalAlmacen();
            oc.WindowState = FormWindowState.Maximized;
            oc.MdiParent = this;
            oc.Show();
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmBaseDatos oc = new frmBaseDatos();
            oc.WindowState = FormWindowState.Maximized;
            oc.MdiParent = this;
            oc.Show();*/
        }

        private void impuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmPrincipalImpuestos oc = new frmPrincipalImpuestos();
            oc.WindowState = FormWindowState.Maximized;
            oc.MdiParent = this;
            oc.Show();*/
        }

        private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalMarca oc = new frmPrincipalMarca();
            oc.WindowState = FormWindowState.Maximized;
            oc.MdiParent = this;
            oc.Show();
        }

        private void lineaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalLinea oc = new frmPrincipalLinea();
            oc.WindowState = FormWindowState.Maximized;
            oc.MdiParent = this;
            oc.Show();
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void conceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalConcepto ax = new frmPrincipalConcepto();
            ax.WindowState = FormWindowState.Maximized;
            ax.MdiParent = this;
            ax.Show();
        }

        private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalExistencias ax = new frmPrincipalExistencias();
            ax.WindowState = FormWindowState.Maximized;
            ax.MdiParent = this;
            ax.Show();
        }
    }
}

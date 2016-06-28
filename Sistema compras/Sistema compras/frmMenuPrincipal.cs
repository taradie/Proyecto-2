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
using SeguridadGrafico;
using Multilenguaje;
using Sistema_compras.Recursos_Localizables;
using System.Threading;
using System.Globalization;
using Seguridad;
using SeguridadGrafico;


namespace Sistema_compras
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
            /*this.multiempresaToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "0");
            this.productosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "1");
            this.MovimientoInToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "2");
            this.marcaToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "3");
            this.lineaToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "4");
            this.conceptosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "5");
            this.existenciasToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "6");
            this.ordenesDeCompraPendientesToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "7");
            this.ProveedoresToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "8");
            this.monedaToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "9");
            this.baseDeDatosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "10");
            this.AlmacenToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "11");
            this.idiomaToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "12");
            this.impuestosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "13");
            this.usuariosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "14");
            this.bitacoraToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "15");*/
        }

        public void aplicarIdioma()
        {
            
            inventarioToolStripMenuItem.Text = StringResources.msInventario;
            inicioToolStripMenuItem.Text = StringResources.msInicio;
            cerrarSecionToolStripMenuItem.Text = StringResources.msCerrarSesion;
            multiempresaToolStripMenuItem.Text = StringResources.msMultiEmpresa;
            productosToolStripMenuItem.Text = StringResources.msProducto;
            MovimientoInToolStripMenuItem.Text = StringResources.msMovInv;
            marcaToolStripMenuItem.Text = StringResources.msMarca;
            lineaToolStripMenuItem.Text = StringResources.msLinea;
            conceptosToolStripMenuItem.Text = StringResources.msConceptos;
            existenciasToolStripMenuItem.Text = StringResources.msExistencia;
            ordenesDeCompraPendientesToolStripMenuItem.Text = StringResources.msOrdComp;
            ProveedoresToolStripMenuItem.Text = StringResources.msProveedor;
            reportesToolStripMenuItem.Text = StringResources.msReporte;
            configuracionesToolStripMenuItem.Text = StringResources.msConfiguraciones;
            monedaToolStripMenuItem.Text = StringResources.msMoneda;
            baseDeDatosToolStripMenuItem.Text = StringResources.msBasedeDatos;
            AlmacenToolStripMenuItem.Text = StringResources.msAlmacen;
            idiomaToolStripMenuItem.Text = StringResources.msIdioma;
            impuestosToolStripMenuItem.Text = StringResources.msImpuesto;
            seguridadToolStripMenuItem.Text = StringResources.msSeguridad;
            usuariosToolStripMenuItem.Text = StringResources.msCreacionUsuario;
            bitacoraToolStripMenuItem.Text = StringResources.msBitacora;
            oComprasToolStripMenuItem.Text = StringResources.msCompras;
            ayudaToolStripMenuItem.Text = StringResources.msAyuda;
        }

        private void ordenesDeCompraPendientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalOrdenCompra inv = new frmPrincipalOrdenCompra();
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
            /*frmProveedor oc = new frmProveedor();
            PrincipalDllProveedor oc = new PrincipalDllProveedor();
            oc.WindowState = FormWindowState.Maximized;
            oc.MdiParent = this;
            oc.Show();*/
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
            frmMultilenguaje temp = new frmMultilenguaje();
            temp.ShowDialog(this);
            this.Refresh();
            aplicarIdioma();

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
            MultiBD.frmMultiBD temp = new MultiBD.frmMultiBD();
            temp.MdiParent = this;
            temp.Show();
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
            if (Idioma.ObtenerIdioma() == "Ingles")
            {

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ES-US");

                aplicarIdioma();

            }

            else if (Idioma.ObtenerIdioma() == "Espanol")
            {

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");

                aplicarIdioma();

            }


        }

        private void conceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*frmPrincipalConcepto ax = new frmPrincipalConcepto();
            ax.WindowState = FormWindowState.Maximized;
            ax.MdiParent = this;
            ax.Show();*/
        }

        private void existenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalExistencias ax = new frmPrincipalExistencias();
            ax.WindowState = FormWindowState.Maximized;
            ax.MdiParent = this;
            ax.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalUsuarios ax = new frmPrincipalUsuarios();
            ax.WindowState = FormWindowState.Maximized;
            ax.MdiParent = this;
            ax.Show();
            
        }

        private void webServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebaWs ax = new PruebaWs();
            ax.MdiParent = this;
            ax.Show();
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacora ax = new frmBitacora();
            ax.WindowState = FormWindowState.Maximized;
            ax.MdiParent = this;
            ax.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Empleados;
using Empresa;
using dllClientes;
using PROTOTIPO_C.C.Recursos_Localizables;
using System.Threading;
using System.Globalization;
using Multilenguaje;
using DllCobrador;
using SeguridadGrafico;
using System.Data.Odbc;

namespace PROTOTIPO_C.C
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void AplicarIdioma()
        {
            MenuInicio.Text = StringResources.frmMPMenuInicio;
            //impresorasToolStripMenuItem.Text = StringResources.frmMPImpresoras;
            //sistemaToolStripMenuItem.Text = StringResources.frmMPSeguridad;
            conceptosToolStripMenuItem.Text = StringResources.frmMPConceptos;
            tipoDePagoToolStripMenuItem.Text = StringResources.frmMPDocumentos;
            cerrarSesionToolStripMenuItem.Text = StringResources.frmMPCerrarSesion;
            MenuClientes.Text = StringResources.frmMPMenuClientes;
            ingresoCToolStripMenuItem.Text = StringResources.frmMPIngreso;
            facturasToolStripMenuItem.Text = StringResources.frmMPFacturas;
            MenuProveedores.Text = StringResources.frmMPMenuProveedores;
            ingresoPToolStripMenuItem.Text = StringResources.frmMPIngreso;
            facturasPToolStripMenuItem1.Text = StringResources.frmMPFacturas;
            MenuEmpleados.Text = StringResources.frmMPMenuEmpleados;
            ingresoEToolStripMenuItem.Text = StringResources.frmMPIngreso;
            prestamosToolStripMenuItem.Text = StringResources.frmMPPrestamo;
            pagosToolStripMenuItem.Text = StringResources.frmMPPagos;
            MenuReportes.Text = StringResources.frmMPReportes;
            MenuConfiguracion.Text = StringResources.frmMPMenuConfiguracion;
            baseDeDatosToolStripMenuItem.Text = StringResources.frmMPBasededatos;
            idiomaToolStripMenuItem.Text = StringResources.frmMPIdioma;
            empresaToolStripMenuItem.Text = StringResources.frmMPEmpresa;
            MenuSeguridad.Text = StringResources.frmMPSeguridad;
            MenuAyuda.Text = StringResources.frmMPAyuda;
            this.Text = StringResources.frmMPTitulo;

        }

        private void cobrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void prestamosToolStripMenuItem_Click(object sender, EventArgs e)
        {
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
            //frmPagos temp = new frmPagos();
            //temp.Show();
        }

        private void pagoAEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalPagoPrestamo temp = new frmPrincipalPagoPrestamo();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            //pictureBox1.Visible = false;
            temp.Show();
        }

        private void pagosDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*
            frmPrincipalPagosClientes temp = new frmPrincipalPagosClientes();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            //pictureBox1.Visible = false;
            temp.Show();
            */
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
           
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void deudasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void prestamosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void formasDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalFormaPago temp = new frmPrincipalFormaPago();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void ingresoDeEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void empresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void documentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            if(Idioma.ObtenerIdioma() == "Ingles"){
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ES-US");
                AplicarIdioma();

            }
            else if (Idioma.ObtenerIdioma() == "Espanol")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
                AplicarIdioma();
            }
        }

        private void conceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalConcepto temp = new frmPrincipalConcepto();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void tipoDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalTipoDocumento temp = new frmPrincipalTipoDocumento();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void ingresoCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dllClientes.frmPrincipalCliente temp = new dllClientes.frmPrincipalCliente();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            //pictureBox1.Visible = false;
            temp.Show();
        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalFacturas temp = new frmPrincipalFacturas();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            //pictureBox1.Visible = false;
            temp.Show();
        }

        private void ingresoPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClaseProveedor.PrincipalDllProveedor temp = new ClaseProveedor.PrincipalDllProveedor();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void facturasPToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmPrincipalFacturaProveedor temp = new frmPrincipalFacturaProveedor();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            //pictureBox1.Visible = false;
            temp.Show();
        }

        private void ingresoEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalIngresoEmpleadoDLL temp = new frmPrincipalIngresoEmpleadoDLL();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void prestamosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmPrincipalPrestamos temp = new frmPrincipalPrestamos();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void pagosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalPagoPrestamo temp = new frmPrincipalPagoPrestamo();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void idiomaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmMultilenguaje temp = new frmMultilenguaje();
            temp.ShowDialog(this);
            this.Refresh();
            AplicarIdioma();
        }

        private void empresaToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Empresa.frmPrincipalEmpresa temp = new Empresa.frmPrincipalEmpresa();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void cobradorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalCobrador temp = new frmPrincipalCobrador();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void webServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PruebaWS temp = new PruebaWS();
            temp.Show(); 
        }

        private void nuevaFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNuevaFacturaProveedor temp = new frmNuevaFacturaProveedor();
            //temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void creacionDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalUsuarios temp = new frmPrincipalUsuarios(); 
            temp.WindowState = FormWindowState.Maximized; 
            temp.MdiParent = this; 
            temp.Show();
        }

        private void bitacoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmBitacora temp = new frmBitacora();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            temp.Show();
        }

        private void cerrarSesionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmLogins temp = new frmLogins();
            this.Close();
            temp.Show();
        }

        private void baseDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultiBD.frmMultiBD temp = new MultiBD.frmMultiBD();
            temp.MdiParent = this;
            temp.Show();
        }

        private void generarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void saldoPorProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void facturasProveedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void saldoTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                //FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("facturaproveedor");
                //abc.ShowDialog(this);
                //string query = abc.ObtenerQuery();
                ReporteTotalProv objRpt = new ReporteTotalProv();
                //OdbcDataAdapter adp = new OdbcDataAdapter("", ConexionODBC.Conexion.ObtenerConexion());
                //DataSet1 dt = new DataSet1();
                //adp.Fill(dt, "cuentascorrientesproveedores");
                //objRpt.SetDataSource(dt);

                frmVistaReporte vista = new frmVistaReporte();
                vista.crystalReportViewer1.ReportSource = objRpt;
                vista.Show();
            }
            catch
            {

            }
        }

        private void saldoIndividualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("facturaproveedor");
                abc.ShowDialog(this);
                string query = abc.ObtenerQuery();
                ReportePorProveedor objRpt = new ReportePorProveedor();
                OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
                DataSet1 dt = new DataSet1();
                adp.Fill(dt, "facturaproveedor");
                objRpt.SetDataSource(dt);

                frmVistaReporte vista = new frmVistaReporte();
                vista.crystalReportViewer1.ReportSource = objRpt;
                vista.Show();
            }
            catch
            {

            }
        }

        private void facturasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteFacturasProv objRpt = new ReporteFacturasProv();
            //OdbcDataAdapter adp = new OdbcDataAdapter("", ConexionODBC.Conexion.ObtenerConexion());
            //DataSet1 dt = new DataSet1();
            //adp.Fill(dt, "cuentascorrientesproveedores");
            //objRpt.SetDataSource(dt);

            frmVistaReporte vista = new frmVistaReporte();
            vista.crystalReportViewer1.ReportSource = objRpt;
            vista.Show();
        }

        private void saldoTotalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                //FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("facturaproveedor");
                //abc.ShowDialog(this);
                //string query = abc.ObtenerQuery();
                ReporteSaldoClientes objRpt = new ReporteSaldoClientes();
                //OdbcDataAdapter adp = new OdbcDataAdapter("", ConexionODBC.Conexion.ObtenerConexion());
                //DataSet1 dt = new DataSet1();
                //adp.Fill(dt, "cuentascorrientesproveedores");
                //objRpt.SetDataSource(dt);

                frmVistaReporte vista = new frmVistaReporte();
                vista.crystalReportViewer1.ReportSource = objRpt;
                vista.Show();
            }
            catch
            {

            }
        }

        private void saldoIndividualToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("factura");
                abc.ShowDialog(this);
                string query = abc.ObtenerQuery();
                ReporteSaldoPorCliente objRpt = new ReporteSaldoPorCliente();
                OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
                DataSet1 dt = new DataSet1();
                adp.Fill(dt, "factura");
                objRpt.SetDataSource(dt);

                frmVistaReporte vista = new frmVistaReporte();
                vista.crystalReportViewer1.ReportSource = objRpt;
                vista.Show();
            }
            catch
            {

            }
        }

        private void facturasToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            ReporteFacturasClientes objRpt = new ReporteFacturasClientes();
            //OdbcDataAdapter adp = new OdbcDataAdapter("", ConexionODBC.Conexion.ObtenerConexion());
            //DataSet1 dt = new DataSet1();
            //adp.Fill(dt, "cuentascorrientesproveedores");
            //objRpt.SetDataSource(dt);

            frmVistaReporte vista = new frmVistaReporte();
            vista.crystalReportViewer1.ReportSource = objRpt;
            vista.Show();
        }

        private void MenuAyuda_Click(object sender, EventArgs e)
        {
            string debug = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            String ruta = debug + @"\Manual de Usuario Cuentas Corrientes.chm";
            Help.ShowHelp(this, ruta, HelpNavigator.Topic, "Manual de usuario");
        }
    }
}

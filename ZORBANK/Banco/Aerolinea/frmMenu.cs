using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using Seguridad;
using SeguridadGrafico;
using Multilenguaje;
using ZORBANK.Recursos_Localizables;
using System.Threading;
using System.Globalization;
using System.Data.Odbc;


namespace ZORBANK
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
            /*this.alumnosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmPersona");
            this.empleadosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmEmpleado");
            this.familiaresToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmFamilia");
            this.puestosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmPuestos");
            this.salonesToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmSalones");
            this.cursosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmCursos");
            this.parqueosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmParqueos");
            this.laboratoriosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmLaboratorios");
            this.pensumToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmPensum");
            this.sedesToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmSedes");
            this.tipoPagoToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmTipoPago");
            this.tipoServicioToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmTipoServicio");
            this.facultadYCarreraToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmCarrera");
            this.jornadaToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmJornada");
            this.horarioToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmHorario");
            this.seccionToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmSeccion");
            this.facultadToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmFacultad");
            this.asignacionOrdinariaToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmAsigOrd");
            this.reasignacionesToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmReasignacion");
            this.asignacionDeParqueoToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmAsigParq");
            this.reinscripcionesToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmReinscripcion");
            this.creacionDePensumToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmCreacionPensum");
            this.creacionDePaquetesToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmCreacionPaquete");
            this.mantenimientoToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmNotas");
            this.distribucionZonaToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmZona");
            this.cobroDeParqueoToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmCobroParqueo");
            this.cobroDeMensualidadToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmMensualidad");
            this.cobroDeInscripcionToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmCobroInscrip");
            this.cobroReasignacionToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmCobroReasig");
            this.cobroDeDocumentosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmCobroDoc");
            this.pagoEmpleadosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmPagoEmpleado");
            this.creacionUsuariosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmUsuario");
            this.bitacoraToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmBitacora");
            this.reportesDeCatalogosToolStripMenuItem.Enabled = claseUsuario.ObtenerPermisosForm(claseUsuario.varibaleUsuario, "frmReporteCatalogos");
        */}        
        
        private void aYUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "file://C:\\Aerolínea.chm");
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBitacora temp = new frmBitacora();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        }

        private void creacionUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            frmPrincipalUsuarios temp = new frmPrincipalUsuarios();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        }
                
        private void FormasPagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalFPcs temp = new frmPrincipalFPcs();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        
        }

        private void ConceptosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalConceptos temp = new frmPrincipalConceptos();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        
        }        

        private void BeneficiariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalBeneficiario temp = new frmPrincipalBeneficiario();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        
        }

        private void conciliaciónBancariaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalConciliacion temp = new frmPrincipalConciliacion();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        

        }

        private void CuentasBancariasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaCuentas temp = new frmConsultaCuentas();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        }

        private void MovimientosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaMovimiento temp = new frmConsultaMovimiento();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        }

        private void AgendaZonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultaAgendaMovimiento temp = new frmConsultaAgendaMovimiento();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        }

        private void MonedasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalMoneda temp = new frmPrincipalMoneda();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        }

        private void CessarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("¿Esta seguro que desea cerrar sesión?", "Mensaje de Confirmación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();
            }
        }

        private void establecerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MultiBD.frmMultiBD temp = new MultiBD.frmMultiBD();
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        }

        private void BancosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalBanco temp = new frmPrincipalBanco();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        }

        private void impresorasToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //PrintDocument formulario = new PrintDocument();
            //formulario.PrintPage += new PrintPageEventHandler(Datos_Cliente);
            PrintDialog printDialog1 = new PrintDialog();
            //printDialog1.Document = formulario;
            //printDialog1.ShowHelp = true;
            DialogResult result = printDialog1.ShowDialog();
        }

        private void AplicarIdioma()
        {
            inicioToolStripMenuItem.Text = StringResources.Inicio;
            CessarSesionToolStripMenuItem.Text = StringResources.CerrarSesión;
            impresorasToolStripMenuItem.Text = StringResources.Impresoras;
            CatalogosToolStripMenuItem.Text = StringResources.Catalogos;
            tipoCambioToolStripMenuItem.Text = StringResources.TipoCambio;
            FormasPagoToolStripMenuItem.Text = StringResources.FormasPago;
            ConceptosToolStripMenuItem.Text = StringResources.Conceptos;
            BeneficiariosToolStripMenuItem.Text = StringResources.Beneficiarios;
            cuentasToolStripMenuItem.Text = StringResources.Cuentas;
            BancosToolStripMenuItem.Text = StringResources.Bancos;
            CuentasBancariasToolStripMenuItem.Text = StringResources.CuentasBancarias;
            MovimientosToolStripMenuItem.Text = StringResources.MovimientosBancarios;
            AgendaZonaToolStripMenuItem.Text = StringResources.AgendaMovimientos;
            ProcesosToolStripMenuItem.Text = StringResources.Procesos;
            emisiónDeChequesToolStripMenuItem.Text = StringResources.EmisionCheques;
            conciliaciónBancariaToolStripMenuItem.Text = StringResources.Conciliacion;
            ReportesToolStripMenuItem.Text = StringResources.Reportes;
            SeguridadToolStripMenuItem.Text = StringResources.Seguridad;
            creacionUsuariosToolStripMenuItem.Text = StringResources.Usuarios;
            bitacoraToolStripMenuItem.Text = StringResources.Bitacora;
            ConfiguracionToolStripMenuItem.Text = StringResources.Configuracion;
            agregarEmpresaToolStripMenuItem.Text = StringResources.AgregarEmpresa;
            datosDeLaEmpresaToolStripMenuItem.Text = StringResources.DatosEmpresa;
            establecerToolStripMenuItem.Text = StringResources.MultiBD;
            MonedasToolStripMenuItem.Text = StringResources.Monedas;
            idiomaToolStripMenuItem.Text = StringResources.Idioma;
            AyudaToolStripMenuItem.Text = StringResources.Ayuda;
            índiceToolStripMenuItem.Text = StringResources.Indice;
            acercaDeToolStripMenuItem.Text = StringResources.Acerca;




        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            if (Idioma.ObtenerIdioma() == "Ingles")
            {

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ES-US");

                AplicarIdioma();

            }

            else if (Idioma.ObtenerIdioma() == "Espanol")

            {

                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");

                AplicarIdioma();

            }

        }

        private void idiomaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMultilenguaje temp = new frmMultilenguaje();
            temp.ShowDialog(this);
            this.Refresh();
            AplicarIdioma();

        }

        private void tipoCambioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalCambioM temp = new frmPrincipalCambioM();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        }

        private void ReporteConceptosDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("conceptobancarios");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            //string query = "select * from usuario";
            MessageBox.Show(query);

            ReporteConcepto objRpt = new ReporteConcepto();
            OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
            DataSet1 dt = new DataSet1();
            adp.Fill(dt, "conceptosbancarios");
            objRpt.SetDataSource(dt);
            ConexionODBC.Conexion.CerrarConexion();

            frmVistaReporte vista = new frmVistaReporte();
            vista.crystalReportViewer1.ReportSource = objRpt;
            vista.Show();
        }

        private void emisiónDeChequesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormClienteWeb temp = new FormClienteWeb();
            temp.WindowState = FormWindowState.Normal;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        }
    }
}

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

        private void cERRARSESSIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resul = MessageBox.Show("Esta seguro que desea cerrar session?", "Mensage de Confirmacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (resul == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                frmLogin login = new frmLogin();
                login.Show();  
            }
        }

        
        private void aYUDAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Help.ShowHelp(this, "file://C:\\Aerolínea.chm");
        }

        private void bitacoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbitacora temp = new frmbitacora();
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

        
        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPrincipalPersona temp = new frmPrincipalPersona();
            temp.WindowState = FormWindowState.Maximized;
            temp.MdiParent = this;
            pictureBox1.Visible = false;
            temp.Show();
        }                
    }
}

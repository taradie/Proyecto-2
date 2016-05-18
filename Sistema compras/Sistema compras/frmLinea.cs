using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;
using System.Data.Odbc;

namespace Sistema_compras
{
    public partial class txtcondi : Form
    {
          public static OdbcCommand _comando;
        public static OdbcDataReader _reader;
        string sCod; 
        public txtcondi()
        {
            InitializeComponent();
            btnRefrescar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
        }
         public txtcondi(string codlinea,string estado, string descripcion, string comision)
        {
            InitializeComponent();
            
            btnGuardar.Enabled = false;
            btnEditar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEliminar.Enabled = true;
            sCod = codlinea;
            txtdesc.Text = descripcion;
            txtcomi.Text = comision;
            
                   }

        public void funLimpiarTextos()
        {
            txtdesc.Text = "";
            txtcomi.Text = "";
                       
        }

        


        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtdesc.Enabled = true;
            txtcomi.Enabled = true;
                  btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        public void funActualizar()
        {
            clasnegocio almacn = new clasnegocio();
            Boolean bPermiso = true;
           
            TextBox[] aDatosEdit = { txtdesc, txtcomi };
            string sTabla = "linea";
            string codalmacen = "codlinea";
            almacn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, codalmacen);
        }




        private void frmLinea_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click_1(object sender, EventArgs e)
        {
            txtdesc.Enabled = true;
            txtcomi.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnGuardar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (!txtdesc.Text.Equals("") )
            {
                if (MessageBox.Show("¿Desea Actualizar Los Datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funActualizar();
                    funLimpiarTextos();
                    MessageBox.Show("Datos modificados exitosamente");
                }
            }
            else
            {
                MessageBox.Show("Todos Los Campos Tienen que Tener un Valor", "Datos no Actualizados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public void funEliminar()
        {
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            txtstatus.Text = "0";
            txtestado.Text = "INACTIVO";
            TextBox[] aDatosEdit = { txtstatus, txtestado };
            string sTabla = "linea";
            string codigoalmacen = "codlinea";
            cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, codigoalmacen);
        }
        
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar al Proveedor?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funEliminar();

                funLimpiarTextos();
            }
        }


        public void funGuardarDatos()
        {

            TomarDatos();
            try { 
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            txtstatus.Text = "1";
            txtestado.Text = "ACTIVO";
                TextBox[] aDatos = { txtdesc, txtstatus, txtcomi,txtestado };
            string sTabla = "linea";
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);
            funLimpiarTextos();
            frmPrincipalLinea linea = new frmPrincipalLinea();
            linea.funActualizarGrid(); ;
            
            linea.grdInventario.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Ocurrio un error al guardar los datos");
            }

        }

        private void TomarDatos()
        {
            if (rbActivo.Checked)
            {
                txtstatus.Text = "ACTIVO";
            }
            else if (rbInactivo.Checked)
            {
                txtstatus.Text = "INACTIVO";
            }
        }
        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
            
            if (!txtdesc.Text.Equals("") )
            {
                if (MessageBox.Show("¿Decea Guardar Los Datos?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funGuardarDatos();
                    funLimpiarTextos();
                    btnGuardar.Enabled = false;

                    

                    MessageBox.Show("Datos ingresados Correctamente");

                    
                }
            }
            else
            {
                MessageBox.Show("Todos Los Campos Tienen que Tener un Valor", "Datos no Guardados", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            txtdesc.Text = "";
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;

        }

        private void grupoFiltrar_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, ayuda1.HelpNamespace);
        }
    }
}

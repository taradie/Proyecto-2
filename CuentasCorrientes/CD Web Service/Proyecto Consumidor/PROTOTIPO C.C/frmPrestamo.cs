using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Filtrado;
using Navegador;

namespace PROTOTIPO_C.C
{
    public partial class frmPrestamo : Form
    {
        //int iNuevo;
        int iTipoNuevo;
        string sCadena;
        string sCE;
        public frmPrestamo()
        {
            InitializeComponent();
            funLlenarEmpleados();
            iTipoNuevo = 0;
        }

        public frmPrestamo(string sCodPrestamo, string sDPI, string sNombre, string sFecha, string sInteres, string sPagos, string sTotal)
        {
            InitializeComponent();
            sCE = sCodPrestamo;
            funLlenarDatos(sCodPrestamo, sDPI, sNombre, sFecha, sInteres, sPagos, sTotal);
            iTipoNuevo = 1;
            btnGuardar.Enabled = false;
            //btnEditar.Enabled = true;
            btnNuevo.Enabled = true;
            btnEliminar.Enabled = true;
        }

        string funCortadorID(string sDato)
        {
            sCadena = "";
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {
                    if (sDato.Substring(i, 1) != ".")
                    {
                        sCadena = sCadena + sDato.Substring(i, 1);
                    }
                    else
                    {
                        break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al obtener Codigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return sCadena;
        }

        public void funLimpiar()
        {
            cmbEmpleados.SelectedIndex = -1;
            dtFecha.Value = DateTime.Today;
            txtTotal.Text = "";
            txtInteres.Text = "";
            numPagos.Value = 0;
        }

        public void funActivar()
        {
            cmbEmpleados.Enabled = true;
            btnEliminar.Enabled = false;
            txtTotal.Enabled = true;
            txtInteres.Enabled = true;
            numPagos.Enabled = true;
        }

        public void funBloquear()
        {
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnRefrescar.Enabled = false;
        }

        public void funLlenarDatos(string sCodPrestamo, string sDPI, string sNombre, string sFecha, string sInteres, string sPagos, string sTotal)
        {                        
            dtFecha.Value = Convert.ToDateTime(sFecha);
            int index = cmbEmpleados.FindString(sNombre);
            cmbEmpleados.SelectedIndex = index;
            txtTotal.Text = sTotal;
            txtInteres.Text = sInteres;
            numPagos.Value = int.Parse(sPagos);
            funLlenarEmpleados();
            
        }

        public void funLlenarEmpleados()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("empleado", "SELECT CONCAT(empleado.cod_empleado, '.', personas.nombres,' ', personas.apellidos) AS EMPLEADO FROM personas, empleado WHERE empleado.codigo_persona=personas.codigo_persona", "EMPLEADO", cmbEmpleados);
        }

        public void funGuardarDatos()
        {
            //////////---------DEFINIR LA CANTIDAD DE DIAS PARA LA GENERACION DE TALONARIO (DIAS)---------////////
            int Dias = 0;
            if (rd15Dias.Checked) 
            {
                Dias = 15;
            }
            else
            {
                Dias = 30;
            }
            TextBox txtCodEmpleado = new TextBox();
            txtCodEmpleado.Tag = "cod_empleado";
            txtCodEmpleado.Text = funCortadorID(cmbEmpleados.Text);

            TextBox txtFecha = new TextBox();
            txtFecha.Tag = "fecha";
            txtFecha.Text = dtFecha.Text;

            TextBox txtPagos = new TextBox();
            txtPagos.Tag = "pagos";
            txtPagos.Text = numPagos.Value.ToString();

            TextBox txtEstado = new TextBox();
            txtEstado.Tag = "estado";
            txtEstado.Text = "ACTIVO";

            TextBox txtCondicion = new TextBox();
            txtCondicion.Tag = "condicion";
            txtCondicion.Text = "ACTIVO";

            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            
            TextBox[] aDatos = { txtFecha, txtTotal, txtPagos, txtInteres, txtEstado, txtCondicion, txtCodEmpleado };
            string sTabla = "prestamo";
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);

            /////////////////////BUSQUEDA DEL CODIGO DE LA PERSONA INSERTADA//////////////////                         
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("personas", "SELECT MAX(codPrestamo) AS N FROM prestamo", "N", cmbCod);

            ////////////////////INSERCION EN LA TABLA TALONARIO///////////////////////////////          
            
            TextBox txtCodPrestamo = new TextBox();
            txtCodPrestamo.Tag = "codPrestamo";
            txtCodPrestamo.Text = cmbCod.Text;
            
            //--division del monto en la cantidad de pagos--//
            int iTotal = Int32.Parse(txtTotal.Text);
            int iPagos = Decimal.ToInt32(numPagos.Value);
            int iPagosIndividuales = iTotal / iPagos;

            TextBox txtValorPagos = new TextBox();
            txtValorPagos.Tag = "monto";
            txtValorPagos.Text = iPagosIndividuales.ToString();

            DateTimePicker Fech = new DateTimePicker();
            Fech.CustomFormat = "yyyy-MM-dd";
            Fech.Value = Convert.ToDateTime(dtFecha.Text);

            
            
            TextBox txtFechaPagos = new TextBox();
            txtFechaPagos.Tag = "fechaPago";
            string sF = ""; 
            
            for (int i = 0; i < Decimal.ToInt32(numPagos.Value); i++) 
            {
                dtFecha.Value = dtFecha.Value.AddDays(Dias);
                sF = dtFecha.Text;                
                txtFechaPagos.Text = sF;                

                clasnegocio cn2 = new clasnegocio();
                Boolean bPermiso2 = true;
                TextBox[] aDatos2 = { txtValorPagos, txtFechaPagos, txtCondicion, txtEstado, txtCodPrestamo };
                string sTabla2 = "talonario";
                cn2.AsignarObjetos(sTabla2, bPermiso2, aDatos2);
            }                       
        }

        private void btnFiltrado_Click(object sender, EventArgs e)
        {
            string sCampoCodigo = "cod_empleado";// nombre del campo del codigo 
            string sCampoDescripcion = "nombres";// nombre del campo del nombre o descripcion 
            string query = "Select empleado.cod_empleado, personas.nombres, personas.apellidos FROM personas, empleado";// query que devuelve los
            //datos de codigoFacultad y nombre sin concatenar (Es el mismo query para llenar el combobox)
            frmFiltrado filtro = new frmFiltrado(query, sCampoCodigo, sCampoDescripcion);
            filtro.ShowDialog(this);
            int index = cmbEmpleados.FindString(filtro.funResultado());
            cmbEmpleados.SelectedIndex = index;//Selecciona el item del combobox
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            funLimpiar();
            funActivar();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            funGuardarDatos();
            MessageBox.Show("Registro Guardado!", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Decea Eliminar el Registro?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clasnegocio cn2 = new clasnegocio();
                Boolean bPermiso2 = true;

                string sCodigo2 = "codPrestamo";
                //string sC2 = funCortadorID(sCE);

                TextBox txtCondicion = new TextBox();
                txtCondicion.Tag = "condicion";
                txtCondicion.Text = "INACTIVO";               

                TextBox[] aDatos4 = { txtCondicion };
                string sTabla4 = "prestamo";
                cn2.EditarObjetos(sTabla4, bPermiso2, aDatos4, sCE, sCodigo2);

                MessageBox.Show("Registro Eliminado", "Confirmacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}

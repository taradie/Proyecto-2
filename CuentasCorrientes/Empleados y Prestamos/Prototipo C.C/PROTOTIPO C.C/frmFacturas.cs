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
using System.Data.Odbc;

namespace PROTOTIPO_C.C
{
    public partial class frmFacturas : Form
    {

        string sCod;
        string estado = "";
        public frmFacturas()
        {
            InitializeComponent();
            funProveedores();
            grpPago.Enabled = false;
            grpFactura.Enabled = true;
        }

        public frmFacturas(string sSerie, string sFactura, string sNombre, string sNit, string sFecha, string sFechaVencimiento, string sCliente, string sProveedor, string sMoneda, string sTotal, string sEstado)
        {
            InitializeComponent();
            sCod = sFactura;
            txtSerieP.Text = sSerie;
            txtNoP.Text = sFactura;
            cmbProveedor.Text = sProveedor;
            txtMoneda.Text = sMoneda;
            txtNombreP.Text = sNombre;
            txtNitP.Text = sNit;
            dtpFechaP.Text = sFecha;
            dtpVencimientoP.Text = sFechaVencimiento;
            txtTotalP.Text = sTotal;
            if(sEstado.Equals("ACTIVO")){
                cmbEstadoP.SelectedIndex = 0;
            }
            else
            {
                cmbEstadoP.SelectedIndex = 1;
            }
            grpPago.Enabled = false;
            grpFactura.Enabled = true;
            funProveedores();
            
            
        }

        void funProveedores()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("codproveedor", "SELECT concat(codproveedor, '.', nombre) as proveedor from proveedor WHERE condicion='1'", "proveedor", cmbProveedor);
            //cnegocio.funconsultarRegistrosCombo("codigoCarrera", "SELECT concat(codigoCarrera, '.', nombre) as Carrera from carrera WHERE estado='ACTIVO'", "Carrera", cmbBuscar);

        }

/*        void funNoFactura()
        {
            clasnegocio cnegocio = new clasnegocio();

            cnegocio.funconsultarRegistrosCombo("ncodfactura", "SELECT MAX(ncodfactura) from factura where condicion='1'", "factura", comboBox6);
            

        }*/

        string funCortador(string sDato)
        {
            string sCadena = "";
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            string sCampoCodigo = "codigoCarrera";// nombre del campo del codigo 
            string sCampoDescripcion = "nombre";// nombre del campo del nombre o descripcion 
            string query = "Select codigoCarrera, nombre from carrera where condicion='1'";// query que devuelve los
            //datos de codigoFacultad y nombre sin concatenar (Es el mismo query para llenar el combobox)
            frmFiltrado filtro = new frmFiltrado(query, sCampoCodigo, sCampoDescripcion);
            filtro.ShowDialog(this);
            //int index = cmbCarrera.FindString(filtro.funResultado());
            //cmbCarrera.SelectedIndex = index;//Selecciona el item del combobox 
            
        }

        private void btnFiltroFactura_Click(object sender, EventArgs e)
        {
            
        }

        private void btnFiltroProveedor_Click(object sender, EventArgs e)
        {
            string sCampoCodigo = "codproveedor";// nombre del campo del codigo 
            string sCampoDescripcion = "nombre";// nombre del campo del nombre o descripcion 
            string query = "Select codproveedor, nombre from proveedor where condicion='1'";// query que devuelve los
            //datos de codigoFacultad y nombre sin concatenar (Es el mismo query para llenar el combobox)
            frmFiltrado filtro = new frmFiltrado(query, sCampoCodigo, sCampoDescripcion);
            filtro.ShowDialog(this);
            int index = cmbProveedor.FindString(filtro.funResultado());
            cmbProveedor.SelectedIndex = index;//Selecciona el item del combobox
        }

        private void button9_Click(object sender, EventArgs e)
        {
          
            
            dtpFechaP.Value = DateTime.Now;
            txtSerieP.Clear();
            txtNitP.Clear();
            txtNombreP.Clear();
            txtTotalP.Clear();
            txtMoneda.Clear();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtSerieP, true);
            cnegocio.funactivarDesactivarTextbox(txtNitP, true);
            cnegocio.funactivarDesactivarTextbox(txtNombreP, true);
            cnegocio.funactivarDesactivarTextbox(txtTotalP, true);
            cnegocio.funactivarDesactivarTextbox(txtMoneda, true);
            cnegocio.funactivarDesactivarCombobox(cmbEstadoP,true);
            cnegocio.funactivarDesactivarCombobox(cmbProveedor, true);
            dtpFechaP.Enabled = true;
            dtpVencimientoP.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;

            
                ///CONSULTA DE EL CODIGO DEL EMPLEADO
                OdbcCommand _comando = new OdbcCommand(String.Format("SELECT MAX(ncodfactura)+1 from factura"), ConexionODBC.Conexion.ObtenerConexion());
                OdbcDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    txtNoP.Text = (_reader.GetString(0)).Trim();
                }


           
        }

        private void rbFactura_CheckedChanged(object sender, EventArgs e)
        {
            grpPago.Enabled = false;
            grpFactura.Enabled = true;
        }

        private void rbPagos_CheckedChanged(object sender, EventArgs e)
        {
            grpPago.Enabled = true;
            grpFactura.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            estado = "editar"; 
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtSerieP, true);
            cnegocio.funactivarDesactivarTextbox(txtNitP, true);
            cnegocio.funactivarDesactivarTextbox(txtNombreP, true);
            cnegocio.funactivarDesactivarTextbox(txtTotalP, true);
            cnegocio.funactivarDesactivarTextbox(txtMoneda, true);
            cnegocio.funactivarDesactivarCombobox(cmbEstadoP, true);
            cnegocio.funactivarDesactivarCombobox(cmbProveedor, true);
            dtpFechaP.Enabled = true;
            dtpVencimientoP.Enabled = true;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtSerieP, false);
            cnegocio.funactivarDesactivarTextbox(txtNitP, false);
            cnegocio.funactivarDesactivarTextbox(txtNombreP, false);
            cnegocio.funactivarDesactivarTextbox(txtTotalP, false);
            cnegocio.funactivarDesactivarTextbox(txtMoneda, false);
            cnegocio.funactivarDesactivarCombobox(cmbEstadoP, false);
            cnegocio.funactivarDesactivarCombobox(cmbProveedor, false);
            dtpFechaP.Enabled = false;
            dtpVencimientoP.Enabled = false;

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            string sTabla = "factura";
            string sCodigo = "ncodfactura";
            string sCampoEstado = "condicion";
            txtEstado.Text = cmbEstadoP.SelectedItem.ToString();
            txtProveedor.Text = funCortador(cmbProveedor.Text);
            txtFecha.Text = dtpFechaP.Text;
            txtVencimiento.Text = dtpVencimientoP.Text;

            if (estado.Equals("editar"))
            {

                TextBox[] aDatosEdit = { txtSerieP, txtMoneda, txtNombreP, txtNitP, txtFecha, txtVencimiento, txtTotalP, txtProveedor ,txtEstado };
                cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, sCodigo);
                //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Editar", sTabla);
                this.Close();


            }
            else if (estado.Equals("eliminar"))
            {
                cn.funeliminarRegistro(sTabla, sCod, sCodigo, sCampoEstado);
                //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Eliminar", sTabla);
                this.Close();
            }
            else if (estado.Equals(""))
            {
                //TextBox[] aDatos = { txtTipo, txtDescripcion, txtCondicion, txtEstado };
                //cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Insertar", sTabla);
                //this.Close();
            }
        }
        
    }
}

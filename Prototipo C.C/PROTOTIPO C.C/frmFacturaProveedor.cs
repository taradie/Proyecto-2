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

namespace PROTOTIPO_C.C
{
    public partial class frmFacturaProveedor : Form
    {
        string sCodP;
        public frmFacturaProveedor()
        {
            InitializeComponent();

        }

        public frmFacturaProveedor(string sNo, string sProveedor, string sTotal, string sSaldo, string sFecha, string sEstado)
        {
            InitializeComponent();
            sCodP = funCortador(sProveedor);
            funActualizarGrid();
            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT nombre, direccion, descripcion, cuenta from proveedor where condicion=1 and codproveedor = '"+sCodP+"'"), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                lblProveedor.Text = (_reader.GetString(0)).Trim();
                lblDireccion.Text = (_reader.GetString(1)).Trim();
                lblDescripcion.Text = (_reader.GetString(2)).Trim();
                lblCuenta.Text = (_reader.GetString(3)).Trim();
            }
            llenarcombogrid();
            tipotransaccion();
            Monto.Tag = "monto";
            //txtFactura.Text = sNo;
            txtCodProveedor.Text = sCodP;
            txtTipoTransaccion.Text = cmbTipoTransaccion.Text;
            //clasnegocio cnegocio = new clasnegocio();
            //cnegocio.funconsultarRegistrosCombo("tipodocumento","SELECT CONCAT(codtipodocumento, '.',tipo) as tpago from tipodocumento where condicion='1'","tpago", c);
        }

        void tipotransaccion()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("conceptos", "SELECT codigo_tipo_transaccion AS TRANS FROM conceptos WHERE tipo='Cargo' AND condicion='ACTIVO' ", "TRANS", cmbTipoTransaccion);
        }

        void llenarcombogrid()
        {
            TipoPago.Items.Clear();
            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT CONCAT(codtipodocumento, '.',tipo) as tpago from tipodocumento"), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                TipoPago.Items.Add(_reader.GetString(0));
            }

        }


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

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("cuentascorrientesproveedores", "SELECT codfacturaprov as NoFactura, concat(proveedor.codproveedor, '.' ,proveedor.nombre) as Proveedor, total as Total, saldo as Saldo from facturaproveedor, proveedor WHERE facturaproveedor.condicion = '1' and facturaproveedor.codproveedor = proveedor.codproveedor and facturaproveedor.saldo < facturaproveedor.total and facturaproveedor.codproveedor ='" + sCodP + "'", "consulta", grdPago);
            grdPago.Columns["NoFactura"].DisplayIndex = 0;
            grdPago.Columns["Proveedor"].DisplayIndex = 1;
            grdPago.Columns["TipoPago"].DisplayIndex = 2;
            grdPago.Columns["Total"].DisplayIndex = 3;
            grdPago.Columns["Saldo"].DisplayIndex = 4;
            grdPago.Columns["Monto"].DisplayIndex = 5;
            grdPago.Columns["Check"].DisplayIndex = 6;
        }

        private void rbFactura_CheckedChanged(object sender, EventArgs e)
        {
           // grpDocumento.Enabled = true;
           // grpPago.Enabled = false;
            
        }

        private void rbPagos_CheckedChanged(object sender, EventArgs e)
        {
            //grpDocumento.Enabled = false;
            //grpPago.Enabled = true;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            grdPago.Enabled = true;    

                OdbcCommand _comando = new OdbcCommand(String.Format("SELECT MAX(codencabezado)+1 from encabezadodoc"), ConexionODBC.Conexion.ObtenerConexion());
                OdbcDataReader _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    txtNoDocumento.Text = (_reader.GetString(0)).Trim();
                }

                txtFecha.Text = dateTimePicker1.Text;
                

                clasnegocio cn = new clasnegocio();
                Boolean bPermiso = true;
                string sTabla = "encabezadodoc";
                TextBox[] aDatos = {txtFecha, txtCondicion, txtEstado };
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);


        }
        

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNoDocumento.Clear();
        }

        private void grpPago_Enter(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            string sTabla = "cuentascorrientesproveedores";
            string sTablaActualizar = "facturaproveedor";
            string sCodigo = "codfacturaprov";

                    for (int i = 0; i < grdPago.Rows.Count - 1; i++)
                    {
                        
                        if (Convert.ToBoolean(grdPago.Rows[i].Cells[2].Value) == true)
                        {

                            if (Convert.ToString(grdPago.Rows[i].Cells[1].Value) == "")
                            {
                                MessageBox.Show("Celda Vacia");
                            }
                            else
                            {
                                string Total = grdPago.Rows[i].Cells[5].Value.ToString();
                                string Monto = grdPago.Rows[i].Cells[1].Value.ToString();
                                string Saldo = grdPago.Rows[i].Cells[6].Value.ToString();

                                float diferencia = float.Parse(Total) - float.Parse(Saldo);

                                if (float.Parse(Monto) <= diferencia)
                                {
                                    float NuevoSaldo;
                                    //    MessageBox.Show("Seleccionado: " + i);
                                    //MessageBox.Show("Tipo Pago: " + funCortador(grdPago.Rows[i].Cells[0].Value.ToString()));
                                    txtTipoDocumento.Text = funCortador(grdPago.Rows[i].Cells[0].Value.ToString());

                                   txtMonto.Text = grdPago.Rows[i].Cells[1].Value.ToString();
                                   txtFactura.Text = grdPago.Rows[i].Cells[3].Value.ToString();
                                   TextBox[] aDatos = { txtFecha, txtMonto, txtCondicion, txtEstado, txtCodProveedor, txtTipoTransaccion, txtTipoDocumento, txtFactura, txtNoDocumento };
                                   cn.AsignarObjetos(sTabla, bPermiso, aDatos);

                                   cn.funconsultarRegistrosCombo("conceptos", "SELECT saldo as TRANS from facturaproveedor where condicion ='1' and codfacturaprov='"+txtFactura.Text+"' ", "TRANS", cmbSaldo);
                                   NuevoSaldo = float.Parse(txtMonto.Text) + float.Parse(cmbSaldo.Text);
                                   txtEditar.Text = NuevoSaldo.ToString();
                                   TextBox[] aDatosEdit = {txtEditar, txtSituacion};
                                   cn.EditarObjetos(sTablaActualizar, bPermiso, aDatosEdit, txtFactura.Text, sCodigo);
                                    
                                }
                                else
                                {
                                    MessageBox.Show("Monto excedido");
                                }
                            }
                        }
                        else
                        {
                            //MessageBox.Show("Selecciona alguna factura");
                        }

                    }
                    //this.Close();

            
        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                for (int i = 0; i < grdPago.Rows.Count - 1; i++)
                {
                    grdPago.Rows[i].Cells[2].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < grdPago.Rows.Count - 1; i++)
                {
                    grdPago.Rows[i].Cells[2].Value = false;
                }
                
            }
        }

        private void grdPago_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class frmFacturaCliente : Form
    {
        string sCodP;
        public frmFacturaCliente()
        {
            InitializeComponent();
        }

        public frmFacturaCliente(string sCod, string sSerie, string sNombre, string sNit, string sCliente, string sFecha, string sVencimiento, string sTotal, string sSaldo)
        {
            InitializeComponent();
            sCodP = funCortador(sCliente);
            funActualizarGrid();
            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT CONCAT(nombrecliente, ' ',apellidocliente) AS Nombre, direccion, telefono, correo FROM cliente WHERE condicion = '1' AND ncodcliente = '" + sCodP + "'"), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                lblNombre.Text = (_reader.GetString(0)).Trim();
                lblDireccion.Text = (_reader.GetString(1)).Trim();
                lblTelefono.Text = (_reader.GetString(2)).Trim();
                lblCorreo.Text = (_reader.GetString(3)).Trim();
            }
            llenarcombogrid();
            tipotransaccion();
            Monto.Tag = "monto";
            Referencia.Tag = "referencia";
            txtCodCliente.Text = sCodP;
            txtTipoTransaccion.Text = cmbTipoTransaccion.Text;


            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            grdPago.Enabled = false;

        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("factura", "SELECT ncodfactura AS Codigo, vserie AS Serie, nombre AS Nombre, nit AS Nit, codVendedor AS Vendedor, codCobrador AS Cobrador, fechavencimiento AS Vencimiento, total AS Total, saldo AS Saldo FROM factura WHERE condicion = '1' AND total > saldo AND ncodcliente = '"+sCodP+"'", "consulta", grdPago);
            grdPago.Columns["Codigo"].DisplayIndex = 0;
            grdPago.Columns["Serie"].DisplayIndex = 1;
            grdPago.Columns["Nombre"].DisplayIndex = 2;
            grdPago.Columns["Nit"].DisplayIndex = 3;
            grdPago.Columns["Vendedor"].DisplayIndex = 4;
            grdPago.Columns["Cobrador"].DisplayIndex = 5;
            grdPago.Columns["Vencimiento"].DisplayIndex = 6;
            grdPago.Columns["Total"].DisplayIndex = 7;
            grdPago.Columns["Saldo"].DisplayIndex = 8;
            grdPago.Columns["TipoPago"].DisplayIndex = 9;
            grdPago.Columns["Referencia"].DisplayIndex = 10;
            grdPago.Columns["Monto"].DisplayIndex = 11;
            //grdPago.Columns["Mora"].DisplayIndex = 12;
            grdPago.Columns["Check"].DisplayIndex = 12;

            /*
            for (int i = 0; i < grdPago.Rows.Count - 1; i++)
            {
                string sVencimiento = grdPago.Rows[i].Cells[11].Value.ToString();
                string sActual = dateTimePicker1.Text;
                DateTimePicker dVencimiento  = new DateTimePicker();
                dVencimiento.CustomFormat = "dd-MMM-yy";
                dVencimiento.Value = Convert.ToDateTime(sVencimiento);
                DateTimePicker dActual = new DateTimePicker();
                dActual.CustomFormat = "yyyy-MM-dd";
                dActual.Value = dateTimePicker1.Value;
                
                if(dVencimiento.Value > dActual.Value){
                    cnegocio.funconsultarRegistrosCombo("mora", "SELECT porcentaje AS Valor FROM mora WHERE codMora = '2'", "Valor", cmbMora);
                    cmbMora.SelectedIndex = 0;
                    grdPago.Rows[i].Cells[3].Value = cmbMora.Text; 
                }
                
                */
            //}
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

        void tipotransaccion()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistrosCombo("conceptos", "SELECT codigo_tipo_transaccion AS TRANS FROM conceptos WHERE tipo='abono' AND condicion='ACTIVO' ", "TRANS", cmbTipoTransaccion);
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

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            grdPago.Enabled = true;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = false;
            

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
           TextBox[] aDatos = { txtFecha, txtCondicion, txtEstado };
           cn.AsignarObjetos(sTabla, bPermiso, aDatos);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtNoDocumento.Clear();
            grdPago.Enabled = false;
            btnEditar.Enabled = false;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            btnEliminar.Enabled = false;
            btnNuevo.Enabled = true;
        }

        private void CalcularMora()
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            string sTabla = "cuentascorrientesclientes";
            string sTablaActualizar = "factura";
            string sCodigo = "ncodfactura";

            for (int i = 0; i < grdPago.Rows.Count - 1; i++)
            {

                if (Convert.ToBoolean(grdPago.Rows[i].Cells[3].Value) == true)
                {

                    if (Convert.ToString(grdPago.Rows[i].Cells[2].Value) == "")
                    {
                        MessageBox.Show("Celda Vacia");
                    }
                    else
                    {
                        string Total = grdPago.Rows[i].Cells[11].Value.ToString();
                        string Monto = grdPago.Rows[i].Cells[2].Value.ToString();
                        string Saldo = grdPago.Rows[i].Cells[12].Value.ToString();

                        float diferencia = float.Parse(Total) - float.Parse(Saldo);

                        if (float.Parse(Monto) <= diferencia)
                        {
                            double NuevoSaldo;
                            //    MessageBox.Show("Seleccionado: " + i);
                            //MessageBox.Show("Tipo Pago: " + funCortador(grdPago.Rows[i].Cells[0].Value.ToString()));
                            txtTipoDocumento.Text = funCortador(grdPago.Rows[i].Cells[0].Value.ToString());

                            txtMonto.Text = grdPago.Rows[i].Cells[2].Value.ToString();
                            txtFactura.Text = grdPago.Rows[i].Cells[4].Value.ToString();
                            txtSerie.Text = grdPago.Rows[i].Cells[5].Value.ToString();
                            txtVendedor.Text = grdPago.Rows[i].Cells[8].Value.ToString();
                            txtCobrador.Text = grdPago.Rows[i].Cells[9].Value.ToString();
                            //txtReferencia.Text = grdPago.Rows[i].Cells[1].Value.ToString();
                            txtMora.Text = "1";
                             if (Convert.ToString(grdPago.Rows[i].Cells[1].Value) == "")
                             {
                                 txtReferencia.Text = "";
                             }
                             else
                             {
                                 txtReferencia.Text = grdPago.Rows[i].Cells[1].Value.ToString();
                             }

                            TextBox[] aDatos = { txtReferencia, txtFecha, txtMonto, txtSituacion, txtFactura, txtMora, txtTipoTransaccion, txtSerie, txtTipoDocumento, txtCondicion, txtEstado, txtCodCliente, txtVendedor, txtCobrador, txtNoDocumento};
                            cn.AsignarObjetos(sTabla, bPermiso, aDatos);

                            //cn.funconsultarRegistrosCombo("conceptos", "SELECT saldo as TRANS from facturaproveedor where condicion ='1' and codfacturaprov='" + txtFactura.Text + "' ", "TRANS", cmbSaldo);
                            //NuevoSaldo = float.Parse(txtMonto.Text) + float.Parse(cmbSaldo.Text);
                            NuevoSaldo = Convert.ToDouble(Monto) + Convert.ToDouble(Saldo);
                            txtEditar.Text = NuevoSaldo.ToString();
                            TextBox[] aDatosEdit = { txtEditar};
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
            this.Close();

            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                for (int i = 0; i < grdPago.Rows.Count - 1; i++)
                {
                    grdPago.Rows[i].Cells[3].Value = true;
                }
            }
            else
            {
                for (int i = 0; i < grdPago.Rows.Count - 1; i++)
                {
                    grdPago.Rows[i].Cells[3].Value = false;
                }

            }
        }

        private void grdPago_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            float Monto = 0;
            for (int i = 0; i < grdPago.Rows.Count - 1; i++)
            {
                if (Convert.ToString(grdPago.Rows[i].Cells[2].Value) != "")
                {
                    string x = grdPago.Rows[i].Cells[2].Value.ToString();
                    Monto += float.Parse(x);
                    nTotal.Text = Monto + "";
                }

            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string debug = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            String ruta = debug + @"\Manual de Usuario Mantenimiento Factura.chm";
            Help.ShowHelp(this, ruta, HelpNavigator.Topic, "Manual de usuario");
        }

    }
}

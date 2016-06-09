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
            txtCodCliente.Text = sCodP;
            txtTipoTransaccion.Text = cmbTipoTransaccion.Text;


        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("factura", "SELECT ncodfactura AS Codigo, vserie AS Serie, nombre AS Nombre, nit AS Nit, fechavencimiento AS Vencimiento, total AS Total, saldo AS Saldo FROM factura WHERE condicion = '1' AND total > saldo AND ncodcliente = '"+sCodP+"'", "consulta", grdPago);
            grdPago.Columns["Codigo"].DisplayIndex = 0;
            grdPago.Columns["Serie"].DisplayIndex = 1;
            grdPago.Columns["Nombre"].DisplayIndex = 2;
            grdPago.Columns["Nit"].DisplayIndex = 3;
            grdPago.Columns["Vencimiento"].DisplayIndex = 4;
            grdPago.Columns["Total"].DisplayIndex = 5;
            grdPago.Columns["Saldo"].DisplayIndex = 6;
            grdPago.Columns["TipoPago"].DisplayIndex = 7;
            grdPago.Columns["Monto"].DisplayIndex = 8;
            grdPago.Columns["Check"].DisplayIndex = 9;
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

          //  OdbcCommand _comando = new OdbcCommand(String.Format("SELECT MAX(codencabezado)+1 from encabezadodoc"), ConexionODBC.Conexion.ObtenerConexion());
           // OdbcDataReader _reader = _comando.ExecuteReader();
           // while (_reader.Read())
           // {
          //      txtNoDocumento.Text = (_reader.GetString(0)).Trim();
           // }

            txtFecha.Text = dateTimePicker1.Text;


            //clasnegocio cn = new clasnegocio();
            //Boolean bPermiso = true;
            //string sTabla = "encabezadodoc";
            //TextBox[] aDatos = { txtFecha, txtCondicion, txtEstado };
            //cn.AsignarObjetos(sTabla, bPermiso, aDatos);
        }

    }
}

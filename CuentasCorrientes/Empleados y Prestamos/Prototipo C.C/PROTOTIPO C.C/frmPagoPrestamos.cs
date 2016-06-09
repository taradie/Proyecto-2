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
    public partial class frmPagoPrestamos : Form
    {
        string sCPres;
        string sSaldoG;
        public frmPagoPrestamos()
        {
            InitializeComponent();
        }

        public frmPagoPrestamos(string sCodPrestamo, string sSaldo)
        {
            InitializeComponent();
            funCargarDatosPrestamo(sCodPrestamo);
            funLlenarcmbTabla();
            sCPres = sCodPrestamo;
            sSaldoG = sSaldo;
        }

        public void funLlenarcmbTabla()
        {
            FormaPago.Items.Clear();
            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT CONCAT(codtipodocumento, '.',tipo) as tpago from tipodocumento"), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                FormaPago.Items.Add(_reader.GetString(0));
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

        public void funCargarDatosPrestamo(string sCodigoPrestamo)
        {
            clasnegocio cnegocio = new clasnegocio();
            /////---------------SELECCIONAR EL NO DE TALONARIO QUE LE CORRESPONDE CANCELAR---------------////            
            //cnegocio.funconsultarRegistrosCombo("talonario", "SELECT MIN(talonario.codTalonario) AS CODIGO FROM talonario, prestamo WHERE talonario.codPrestamo=prestamo.codPrestamo AND prestamo.codPrestamo='" + sCodigoPrestamo + "' AND talonario.condicion='ACTIVO' ", "CODIGO", cmbCodigoTalonario);
            //////////--------------------------------------

            /////---------------SELECCIONAR EL MONTO DE TALONARIO QUE LE CORRESPONDE CANCELAR---------------////           
            //cnegocio.funconsultarRegistrosCombo("talonario", "SELECT monto AS MONTO FROM talonario WHERE talonario.codTalonario='"+cmbCodigoTalonario.Text+"' AND talonario.condicion='ACTIVO' ", "MONTO", cmbMonto);
            //////////--------------------------------------

            /////---------------SELECCIONAR EL TIPO DE DOCUMENTO QUE PARA PODER PAGAR---------------////           
            //cnegocio.funconsultarRegistrosCombo("tipodocumento", "SELECT CONCAT(codtipodocumento, '. ', tipo) AS TPAGO FROM tipodocumento WHERE condicion='ACTIVO' ", "TPAGO", cmbTipoPago);
            //////////--------------------------------------

            /////---------------SELECCIONAR EL CODIGO DE LA TRANSACCION CORRESPONDIENTE---------------////           
            cnegocio.funconsultarRegistrosCombo("conceptos", "SELECT codigo_tipo_transaccion AS TRANS FROM conceptos WHERE tipo='Abono' AND condicion='ACTIVO' ", "TRANS", cmbTipoTransaccion);
            //////////--------------------------------------

            /////---------------SELECCIONAR EL CODIGO DE LA TRANSACCION CORRESPONDIENTE---------------////   
            cnegocio.funconsultarRegistros("talonario", "SELECT codTalonario AS CODIGO, monto AS MONTO, fechaPago AS VENCIMIENTO FROM talonario WHERE condicion='ACTIVO' AND codPrestamo='"+sCodigoPrestamo+"'", "consulta", grdTalonarios);
            grdTalonarios.Columns["CODIGO"].DisplayIndex = 0;
            grdTalonarios.Columns["CODIGO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            grdTalonarios.Columns["MONTO"].DisplayIndex = 1;
            grdTalonarios.Columns["VENCIMIENTO"].DisplayIndex = 2;
            grdTalonarios.Columns["VENCIMIENTO"].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            grdTalonarios.Columns["FormaPago"].DisplayIndex = 3;
            grdTalonarios.Columns["Referencia"].DisplayIndex = 4;
            grdTalonarios.Columns["Mora"].DisplayIndex = 5;
            grdTalonarios.Columns["Pago"].DisplayIndex = 6;            
            //////////--------------------------------------


        }

        private void cmbTipoPago_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;
            string sTabla = "cuentascorrientesempleados";
            string sTablaActualizar1 = "talonario";
            string sTablaActualizar2 = "prestamo";
            string sCodigo1 = "codTalonario";
            string sCodigo2 = "codPrestamo";
            float fTotal = 0;

            TextBox txtFecha = new TextBox();
            txtFecha.Tag = "fecha";
            txtFecha.Text = dtFecha.Text;

            TextBox txtMonto = new TextBox();
            txtMonto.Tag = "monto";            

            TextBox txtSituacion = new TextBox();
            txtSituacion.Tag = "situacion";
            txtSituacion.Text = "Pagado";

            TextBox txtCondicion = new TextBox();
            txtCondicion.Tag = "condicion";
            txtCondicion.Text = "ACTIVO";

            TextBox txtCondicion2 = new TextBox();
            txtCondicion2.Tag = "condicion";
            txtCondicion2.Text = "INACTIVO";

            TextBox txtEstado = new TextBox();
            txtEstado.Tag = "estado";
            txtEstado.Text = "ACTIVO";

            TextBox txtCoditoTipoTransaccion = new TextBox();
            txtCoditoTipoTransaccion.Tag = "codigo_tipo_transaccion";
            txtCoditoTipoTransaccion.Text = cmbTipoTransaccion.Text;

            TextBox txtTipoDoc = new TextBox();
            txtTipoDoc.Tag = "codtipodocumento";

            TextBox txtCodTalonario = new TextBox();
            txtCodTalonario.Tag = "codTalonario";

            TextBox txtMora = new TextBox();
            txtMora.Tag = "codMora";
            txtMora.Text = "1";

            TextBox txtCodPrestamo = new TextBox();
            txtCodPrestamo.Tag = "codPrestamo";
            txtCodPrestamo.Text = sCPres;

            TextBox txtSaldo = new TextBox();
            txtSaldo.Tag = "Saldo";                        

            try
            {
                for (int i = 0; i < grdTalonarios.Rows.Count - 1; i++)
                {

                    if (Convert.ToBoolean(grdTalonarios.Rows[i].Cells[3].Value) == true)
                    {                                                    
                            txtMonto.Text = grdTalonarios.Rows[i].Cells[5].Value.ToString();
                            txtTipoDoc.Text = funCortador(grdTalonarios.Rows[i].Cells[0].Value.ToString());
                            txtCodTalonario.Text = grdTalonarios.Rows[i].Cells[4].Value.ToString();
                            string Saldo = grdTalonarios.Rows[i].Cells[6].Value.ToString();

                            TextBox[] aDatos = { txtFecha, txtMonto, txtSituacion, txtCondicion, txtEstado, txtCoditoTipoTransaccion, txtTipoDoc, txtCodTalonario, txtMora };
                            cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                            System.Console.WriteLine("INSERTO A CUENTAS CORRIENTES EMPLEADOS");

                            TextBox[] aDatosEdit = { txtCondicion2 };
                            cn.EditarObjetos(sTablaActualizar1, bPermiso, aDatosEdit, txtCodTalonario.Text, sCodigo1);
                            System.Console.WriteLine("ACTUALIZO LOS DATOS DE TALONARIOS");

                            fTotal= float.Parse(grdTalonarios.Rows[i].Cells[5].Value.ToString()) + fTotal;
                            System.Console.WriteLine("LA SUMA DE LOS TALONARIOS ES: " + fTotal);
 
                    }
                    else
                    {
                        //MessageBox.Show("Selecciona alguna factura");
                    }

                }
                txtSaldo.Text = fTotal.ToString();
                TextBox[] aDatosEdit2 = { txtSaldo };
                cn.EditarObjetos(sTablaActualizar2, bPermiso, aDatosEdit2, txtCodPrestamo.Text, sCodigo2);
                System.Console.WriteLine("ACTUALIZO EL SALDO EN PRESTAMO");
                //MessageBox.Show("Pagos realizados");
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error, Verificar datos");
            }
        }
    }
}

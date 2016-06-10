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
    public partial class frmPrincipalOrdenCompra : Form
    {
        public static OdbcCommand _comando;
        public static OdbcDataReader _reader;
        string sResltTipoDoc, sresultadoNomTipDoc,sResultadoImpuesto,sresultImpuesto, sResultadoProveedor,sresultNomProv, sResultadoEncabezado;
        string sProductoCodigo, sProductoNombre, sProductoCantidad, sProductoPrecio;
        int ContadorGrid;
        double dTotalOrdenCompra=0;
        public frmPrincipalOrdenCompra()
        {
            InitializeComponent();
            funActualizarGrid();
        }

        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("encabezado_doccompra", "SELECT encabezado_doccompra.codencabezado as No_Documento,encabezado_doccompra.fecha as FechaCreacion,encabezado_doccompra.estado estado FROM encabezado_doccompra WHERE encabezado_doccompra.condicion=1 ", "consulta", grdOrdenCompra);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("encabezado_doccompra");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("encabezado_doccompra", query, "consulta",grdOrdenCompra);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("encabezado_doccompra");
                abc.ShowDialog(this);
                string query = abc.ObtenerQuery();
                //string query = "select * from usuario";
                MessageBox.Show(query);

                ReporteOrdenCompra objRpt = new ReporteOrdenCompra();
                OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
                DataSet1 dt = new DataSet1();
                adp.Fill(dt, "encabezado_doccompra");
                objRpt.SetDataSource(dt);

                frmVistaReporte vista = new frmVistaReporte();
                vista.crystalReportViewer1.ReportSource = objRpt;
                vista.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Lo sentimos el Repote no se puede Generar");
            }
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdOrdenCompra);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdOrdenCompra);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdOrdenCompra);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdOrdenCompra);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string debug = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            String ruta = debug + @"\ayudaordendecompra.chm";
            Help.ShowHelp(this, ruta, HelpNavigator.Topic, "Manual de usuario");
        }

        public void parametros(string codigoEncabezado,string fecha) {
            //MessageBox.Show("Entro a parametros"+codigoEncabezado);
            //_comando = new OdbcCommand(String.Format("SELECT tipodocumento.codtipodocumento,tipodocumento.tipo,impuestos.codimpuesto,impuestos.nombre,proveedor.codproveedor,proveedor.nombre,encabezado_doccompra.codencabezado FROM tipodocumento,documento_compra,encabezado_doccompra,impuestos,proveedor WHERE documento_compra.codencabezado=encabezado_doccompra.codencabezado AND documento_compra.codtipodocumento=tipodocumento.codtipodocumento and documento_compra.codimpuesto=impuestos.codimpuesto AND documento_compra.codproveedor=proveedor.codproveedor AND encabezado_doccompra.codencabezado='"+codigoEncabezado+"' AND encabezado_doccompra.fecha='"+fecha+"'"), ConexionODBC.Conexion.ObtenerConexion());
            _comando = new OdbcCommand(String.Format("SELECT tipodocumento.codtipodocumento,tipodocumento.tipo,impuestos.codimpuesto,impuestos.nombre,proveedor.codproveedor,proveedor.nombre,encabezado_doccompra.codencabezado FROM tipodocumento,documento_compra,encabezado_doccompra,impuestos,proveedor WHERE documento_compra.codencabezado=encabezado_doccompra.codencabezado AND documento_compra.codtipodocumento=tipodocumento.codtipodocumento and documento_compra.codimpuesto=impuestos.codimpuesto AND documento_compra.codproveedor=proveedor.codproveedor AND encabezado_doccompra.codencabezado='" + codigoEncabezado + "'"), ConexionODBC.Conexion.ObtenerConexion());
            _reader = _comando.ExecuteReader();
            if (_reader.Read())
            {
                sResltTipoDoc = _reader.GetString(0);
                sresultadoNomTipDoc = _reader.GetString(1);
                sResultadoImpuesto = _reader.GetString(2);
                sresultImpuesto = _reader.GetString(3);
                sResultadoProveedor = _reader.GetString(4);
                sresultNomProv = _reader.GetString(5);
                sResultadoEncabezado = _reader.GetString(6);
                //MessageBox.Show(sResltTipoDoc + " " + sresultadoNomTipDoc+" "+sResultadoImpuesto + " "+ sresultImpuesto+ " "+ sResultadoProveedor + " " +sresultNomProv+" "+ sResultadoEncabezado);
                
            }
            ConexionODBC.Conexion.CerrarConexion();

        
        }

        

        private void grdOrdenCompra_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string estadofilas = "Quitar";
            string sCodigo = grdOrdenCompra.Rows[grdOrdenCompra.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //MessageBox.Show("doble click grid"+sCodigo);
            string sfecha = grdOrdenCompra.Rows[grdOrdenCompra.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sEstado = grdOrdenCompra.Rows[grdOrdenCompra.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string[] sCorteFecha = sfecha.Split('/',' ');
            string sCorreccionFecha = sCorteFecha[2]+"-"+sCorteFecha[1]+"-"+sCorteFecha[0];
            parametros(sCodigo,sCorreccionFecha);
            ContadorGrid = 0;
            frmCreacionOc temp = new frmCreacionOc(sResultadoImpuesto,sresultImpuesto,sResultadoProveedor,sresultNomProv,sResultadoEncabezado,sEstado,estadofilas);
           
            temp.grdProducto.Rows.Clear();
            _comando = new OdbcCommand(String.Format("SELECT documento_compra.codproducto,producto.nombreproducto,documento_compra.cantidad,producto.precio FROM producto,documento_compra,encabezado_doccompra WHERE encabezado_doccompra.codencabezado=documento_compra.codencabezado AND documento_compra.codproducto=producto.codproducto and encabezado_doccompra.codencabezado='"+sCodigo+"'"), ConexionODBC.Conexion.ObtenerConexion());
            _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                sProductoCodigo = _reader.GetString(0);
                sProductoNombre = _reader.GetString(1);
                sProductoCantidad = _reader.GetString(2);
                sProductoPrecio = _reader.GetString(3);
                double total = double.Parse(sProductoCantidad) * double.Parse(sProductoPrecio);
                temp.grdProducto.Rows.Insert(ContadorGrid, sProductoCodigo, sProductoNombre, sProductoCantidad, sProductoPrecio,total);
                sProductoCodigo = "";
                sProductoNombre = "";
                sProductoCantidad = "";
                sProductoPrecio = "";
                ContadorGrid++;
                dTotalOrdenCompra = dTotalOrdenCompra + total;
            }
            temp.txtTotalGrid.Text = dTotalOrdenCompra.ToString();
            dTotalOrdenCompra = 0;
            ConexionODBC.Conexion.CerrarConexion();

            //frmCreacionOc temp = new frmCreacionOc();
            //temp.grdProducto.Rows.Add("hola","prueba","dos","Etiqueta");
            //temp.Show();
            temp.ShowDialog(this);
            funActualizarGrid();
           
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCreacionOc temp = new frmCreacionOc();
            //temp.Show();
            temp.ShowDialog(this);
            funActualizarGrid();
        }
    }
}

using Filtrado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using iTextSharp;
//using iTextSharp.text;
//using iTextSharp.text.pdf;
using System.IO;
using CrystalDecisions.CrystalReports.Engine;
/*
 * Programador: Manuel Alejandro Chuquiej Buch
 * 0901-12-912
 * Inenieria en Sistemas
 * Diseño de SoftWare
 * Asingado por: Josue Daniel Revolorio Menendez
 */
namespace Sistema_compras
{
    public partial class frmCreacionOc : Form
    {
        string sCodigoOrdenCompra;
        public static OdbcCommand _comando;
        public static OdbcDataReader _reader;
        public static OdbcTransaction mitrans=null;
        Boolean siexiste;
        int estoyenfila;
        string pUnitario, fecha, condicion = "1", estado = "ACTIVO",descuento="0", sCodOrdenCompra, sCodTipoDoc; //variables para detalles de producto
        string estatus,quitarfilas="";
        double SumarTotalOrdenCompra = 0;
        string AccionBoton = "GUARDAR";
        public frmCreacionOc()
        {
            InitializeComponent();
            rbActivo.Select();
            funLlenarCmbProveedor();
            funLlenarCmbImpuesto();
            bloquearTodos();
            funNoOrdenCompra();
            
        }
        public frmCreacionOc(string codimpuesto,string nomimpuesto,string codproveedor,string nomproveedor,string codOrdenCompra,string Estado,string fils)
        {
            InitializeComponent();
            quitarfilas = "";
            quitarfilas = fils;
            //MessageBox.Show(quitarfilas);
            if (Estado.Equals("ACTIVO")) {
                rbActivo.Checked = true;
            }
            else if (Estado.Equals("INACTIVO")) {
                rbInactivo.Checked = true;
            }
            //MessageBox.Show("orden de compra  "+codOrdenCompra);
            bloquearTodos();
            
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            cmbImpuesto.Items.Clear();
            cmbImpuesto.Text = "";
            cmbProveedor.Items.Clear();
            cmbProveedor.Text = "";
            cmbProducto.Items.Clear();
            cmbProducto.Items.Clear();
            cmbImpuesto.Text=codimpuesto+"."+nomimpuesto;
            cmbProveedor.Text = codproveedor + "." + nomproveedor;
            sCodigoOrdenCompra = codOrdenCompra;
            lblNoOrden.Text = sCodigoOrdenCompra;
            funLLenarCmbProductos(codproveedor);
            btnImprimir.Enabled = true;
            funSumarOrdenCompra();

        }
        public void funNoOrdenCompra() {
            try {
                _comando = new OdbcCommand(String.Format("SELECT MAX(codencabezado) FROM encabezado_doccompra;"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                if (_reader.Read())
                {
                    Int16 correlativo = Int16.Parse(_reader.GetString(0));
                    lblNoOrden.Text = "";
                    lblNoOrden.Text = (correlativo + 1).ToString();
                }
                ConexionODBC.Conexion.CerrarConexion();
            }catch(Exception){
                MessageBox.Show("No se pudo obtener el Coorelativo de La Orden de Compra");
            }
        }
        public void bloquearTodos()
        {
            grbEstado.Visible = false;
            rbActivo.Visible = false;
            rbInactivo.Visible = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true; //boton principal de la funcion
            btnRefrescar.Enabled = false;
            cmbImpuesto.Enabled = false;
            cmbProducto.Enabled = false;
            cmbProveedor.Enabled = false;
            grdProducto.Enabled = false;
            txtCantidad.Enabled = false;
            btnAgregar.Enabled = false;
            button1.Enabled = false;
            button3.Enabled = false;
            btnFilProv.Enabled = false;
            btnImprimir.Enabled = false;
            btnRefrescar.Enabled = false;
            grdProducto.Enabled = false;
            
        }
        public void habilitarConNuevo()
        {
            rbActivo.Select();
            btnCancelar.Enabled = true;
            btnGuardar.Enabled = true;
            btnNuevo.Enabled = false; //boton principal de la funcion
            //txtNombre.Enabled = true;
            cmbImpuesto.Enabled = true;
            cmbProducto.Enabled = true;
            cmbProveedor.Enabled = true;
            grdProducto.Enabled = true;
            txtCantidad.Enabled = true;
            btnAgregar.Enabled = true;
            funLlenarCmbProveedor();
            button1.Enabled = true;
            button3.Enabled = true;
            btnFilProv.Enabled = true;
            grdProducto.Enabled = true;
            
        }
        public void funhabilitaedicion(){
            grbEstado.Visible = true;
            rbActivo.Visible = true;
            rbInactivo.Visible = true;
            cmbImpuesto.Enabled = true;
            cmbProducto.Enabled = true;
            cmbProveedor.Enabled = true;
            grdProducto.Enabled = true;
            txtCantidad.Enabled = true;
            btnAgregar.Enabled = true;
            funLlenarCmbProveedor();
            button1.Enabled = true;
            button3.Enabled = true;
            btnFilProv.Enabled = true;
            grdProducto.Enabled = true;
        }
        

        public void tomarFecha()
        {
            DateTime fe = DateTime.Today;
            fecha = fe.Year + "-" + fe.Month + "-" + fe.Day;
        }
        public void funLimpiar()
        {
            txtNombre.Text = "";
            txtNit.Text = "";
            txtTelefono.Text = "";
            txtUbicacion.Text = "";
            cmbImpuesto.Items.Clear();
            cmbProducto.Items.Clear();
            cmbProveedor.Items.Clear();
            cmbProveedor.Text = "";
            cmbImpuesto.Text = "";
            cmbProducto.Text = "";
            txtCantidad.Text = "";
            //lblDisponibles.Text = "";
            lblExistente.Text = "";
            grdProducto.Rows.Clear();
        }

        /*public void funCrearDoc(string dondeGuardar) {
            
            Document document = new Document();
            PdfWriter.GetInstance(document,new FileStream(dondeGuardar+"OrdendeCompra No."+sCodigoOrdenCompra+".pdf",FileMode.OpenOrCreate));
            document.Open();
            //-------variables para poner formato a las letras-------
            iTextSharp.text.Font fFontTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 13, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontSubTitulo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 9, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font fFontCuerpo = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            //-------fin del formato para letras---------------------
            //-------codigo Para Poner imagen en pdf---------
            string debug = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            String rutaImagenDebug = debug + @"\logocompras.png";
            iTextSharp.text.Image imagenEncabezado = iTextSharp.text.Image.GetInstance(rutaImagenDebug);
            imagenEncabezado.Alignment = Element.ALIGN_RIGHT;
            imagenEncabezado.ScaleToFit(50f, 50f);
            document.Add(imagenEncabezado);
            //-------fin de imagen para pdf------------------

            //-------Titulo para el documento-------------------
            Paragraph parrafoTitulo = new Paragraph("Orden de Compra No. " + sCodigoOrdenCompra, fFontTitulo);
            parrafoTitulo.Alignment = Element.ALIGN_CENTER;
            document.Add(parrafoTitulo);
            //-------Fin titulo para el documento---------------
            
            //-------datos de proveedor----------------------
            Paragraph parrafoNomProveedor = new Paragraph("\n" +"Nombre: "+(cmbProveedor.Text), fFontSubTitulo);
            parrafoNomProveedor.Alignment = Element.ALIGN_LEFT;
            document.Add(parrafoNomProveedor);
            Paragraph parrafoNitProveedor = new Paragraph("\n" +"Nit: "+(txtNit.Text), fFontSubTitulo);
            parrafoNitProveedor.Alignment = Element.ALIGN_LEFT;
            document.Add(parrafoNitProveedor);
            Paragraph parrafoTelProveedor = new Paragraph("\n" +"Telefono: "+ (txtTelefono.Text), fFontSubTitulo);
            parrafoTelProveedor.Alignment = Element.ALIGN_LEFT;
            document.Add(parrafoTelProveedor);
            //-------fin datos de proveedor------------------

            //-------Linea que divide y muestra datos--------
            Paragraph linea = new Paragraph("\n_________________________________________________________________________________________________________", fFontSubTitulo);
            linea.Alignment = Element.ALIGN_CENTER;
            document.Add(linea);
            //Paragraph divis = new Paragraph("\n________________________________________________________________________________________________________", fFontSubTitulo);
           // Creamos una tabla que contendrá el nombre, apellido y país

        iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
        PdfPTable tblPrueba = new PdfPTable(5);
        tblPrueba.WidthPercentage = 100;
 
        // Configuramos el título de las columnas de la tabla
        PdfPCell clCodigo = new PdfPCell(new Phrase("Codigo", _standardFont));
        clCodigo.BorderWidth = 0;
        clCodigo.BorderWidthBottom = 0.75f;
 
        PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
        clNombre.BorderWidth = 0;
        clNombre.BorderWidthBottom = 0.75f;
 
        PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", _standardFont));
        clCantidad.BorderWidth = 0;
        clCantidad.BorderWidthBottom = 0.75f;

        PdfPCell clPrecio = new PdfPCell(new Phrase("Precio", _standardFont));
        clPrecio.BorderWidth = 0;
        clPrecio.BorderWidthBottom = 0.75f;

        PdfPCell clTotal = new PdfPCell(new Phrase("Total", _standardFont));
        clTotal.BorderWidth = 0;
        clTotal.BorderWidthBottom = 0.75f;
        // Añadimos las celdas a la tabla
        tblPrueba.AddCell(clCodigo);
        tblPrueba.AddCell(clNombre);
        tblPrueba.AddCell(clCantidad);
        tblPrueba.AddCell(clPrecio);
        tblPrueba.AddCell(clTotal);

        
        for (int tamano = 0; tamano < grdProducto.Rows.Count;tamano++ )
        {
            string dtCodigoProducto = grdProducto.Rows[tamano].Cells[0].Value.ToString();
            string dtNombreProducto = grdProducto.Rows[tamano].Cells[1].Value.ToString();
            string dtCantidadProducto = grdProducto.Rows[tamano].Cells[2].Value.ToString();
            string dtPrecioProducto = grdProducto.Rows[tamano].Cells[3].Value.ToString();
            string dtTotalProducto = grdProducto.Rows[tamano].Cells[4].Value.ToString();
            // Llenamos la tabla con información
            clCodigo = new PdfPCell(new Phrase(dtCodigoProducto, _standardFont));
            clCodigo.BorderWidth = 0;

            clNombre = new PdfPCell(new Phrase(dtNombreProducto, _standardFont));
            clNombre.BorderWidth = 0;

            clCantidad = new PdfPCell(new Phrase(dtCantidadProducto, _standardFont));
            clCantidad.BorderWidth = 0;

            clPrecio = new PdfPCell(new Phrase("Q."+dtPrecioProducto, _standardFont));
            clPrecio.BorderWidth = 0;

            clTotal = new PdfPCell(new Phrase("Q."+dtTotalProducto, _standardFont));
            clTotal.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblPrueba.AddCell(clCodigo);
            tblPrueba.AddCell(clNombre);
            tblPrueba.AddCell(clCantidad);
            tblPrueba.AddCell(clPrecio);
            tblPrueba.AddCell(clTotal);
        }
            //-------Fin de linea que divide-----------------


        document.Add(tblPrueba);
            document.Close();
        }*/  // no se utilizo por Cambio de Crystal Report

        #region funciones que llenan combobox de producto,proveedor e impuesto
        public void funLlenarCmbProveedor() {
            try
            {
                cmbProveedor.Items.Clear();
                _comando = new OdbcCommand(String.Format("Select CONCAT(codproveedor,'.',nombre)AS Proveedor FROM proveedor where estado = 'ACTIVO' and condicion = 1"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    string proveedor = _reader.GetString(0);
                    cmbProveedor.Items.Add(proveedor);
                }
                ConexionODBC.Conexion.CerrarConexion();
            }
            catch (Exception) {
                MessageBox.Show("Ocurrio un Error Asegurese que tenga conexio con Base de Datos");
            }
        }
        public void LlenarInfoProveedor(String codProveedor)
        {
            try
            {
                _comando = new OdbcCommand(String.Format("SELECT nombre,direccion,nit,telefono FROM proveedor WHERE codproveedor='" + codProveedor + "';"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    string nombre = _reader.GetString(0);
                    string direccion = _reader.GetString(1);
                    string nit = _reader.GetString(2);
                    string telefono = _reader.GetString(3);
                    txtNombre.Text = nombre;
                    txtUbicacion.Text = direccion;
                    txtNit.Text = nit;
                    txtTelefono.Text = telefono;
                }
                ConexionODBC.Conexion.CerrarConexion();
            }
            catch (Exception) { MessageBox.Show("Ocurrio un Error al cargar la informacion del Proveedor"); }
        }
        public void funLlenarCmbImpuesto() {
            try
            {
                cmbImpuesto.Items.Clear();
                _comando = new OdbcCommand(String.Format("SELECT CONCAT(impuestos.codimpuesto,'.',impuestos.nombre)AS Ipuesto FROM impuestos where condicion='1'"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    string impuesto = _reader.GetString(0);
                    cmbImpuesto.Items.Add(impuesto);
                }
                ConexionODBC.Conexion.CerrarConexion();
            }
            catch (Exception) { MessageBox.Show("Error: Asegurese que existan datos en Impuesto"); }
        }
        public void funLLenarCmbProductos(string scodProveedor) {
            try
            {
                cmbProducto.Items.Clear();
                _comando = new OdbcCommand(String.Format("SELECT CONCAT(producto.codproducto,'.',producto.nombreproducto)AS Producto FROM producto,proveedor WHERE producto.codproveedor=proveedor.codproveedor and proveedor.codproveedor='" + scodProveedor + "';"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    string proveedor = _reader.GetString(0);
                    cmbProducto.Items.Add(proveedor);
                }
                ConexionODBC.Conexion.CerrarConexion();
            }catch(Exception){
                MessageBox.Show("Asegures que el proveedor tenga productos");
            }
        }
        #endregion
        

       
        #region Botones que filtran y concatenan
        private void btnFilProv_Click(object sender, EventArgs e)
        {
            string sCampoCodigo = "codproveedor";
            string sCampoDescripcion = "nombre";
            string query = "Select codproveedor, nombre from proveedor where condicion='1'";
            frmFiltrado filtro = new frmFiltrado(query, sCampoCodigo, sCampoDescripcion);
            filtro.ShowDialog(this);
            int index = cmbProveedor.FindString(filtro.funResultado());
            cmbProveedor.SelectedIndex = index;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                String[] sTomaCodProveedor = cmbProveedor.Text.Split('.');
                string sCorteCodProveedor = sTomaCodProveedor[0];
                string sCampoCodigo = "codproducto";  //en esto tengo duda
                string sCampoDescripcion = "nombreproducto"; //tambien en este
                //string query = "Select codproveedor, nombre from proveedor where condicion='1'";
                string query = "SELECT codproducto,nombreproducto FROM producto,proveedor WHERE producto.codproveedor=proveedor.codproveedor and proveedor.codproveedor='" + sCorteCodProveedor + "'";
                frmFiltrado filtro = new frmFiltrado(query, sCampoCodigo, sCampoDescripcion);
                filtro.ShowDialog(this);
                int index = cmbProducto.FindString(filtro.funResultado());
                cmbProducto.SelectedIndex = index;
            }
            catch (Exception) {
                System.Console.Out.WriteLine("fallo");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string sCampoCodigo = "codimpuesto";
                string sCampoDescripcion = "nombre";
                string query = "Select codimpuesto, nombre from impuestos where condicion='1'";
                frmFiltrado filtro = new frmFiltrado(query, sCampoCodigo, sCampoDescripcion);
                filtro.ShowDialog(this);
                int index = cmbImpuesto.FindString(filtro.funResultado());
                cmbImpuesto.SelectedIndex = index;
            }
            catch (Exception)
            {
                MessageBox.Show("No se puede obtener el Impuesto");
            }
        }
        #endregion //estos funcionan con Dll de Dylan Corado

        #region eventos que reaccionan con los combobox y grid
        private void cmbProveedor_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                String[] sTomaCodProveedor = cmbProveedor.Text.Split('.');
                string sCorteCodProveedor = sTomaCodProveedor[0];
                LlenarInfoProveedor(sCorteCodProveedor);
                funLLenarCmbProductos(sCorteCodProveedor);
            }
            catch (Exception) {
                MessageBox.Show("No se Cargaron los Datos del Proveedor");
            }
        }
        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                btnAgregar.Text = "Agregar";
                txtCantidad.Text = "";
                string[] corteproducto = cmbProducto.Text.Split('.');
                string codigo = corteproducto[0];
                _comando = new OdbcCommand(String.Format("SELECT producto.existencia FROM producto WHERE producto.codproducto='" + codigo + "'"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    string act = _reader.GetString(0);
                    lblExistente.Text = act;
                }
                ConexionODBC.Conexion.CerrarConexion();
            }catch(Exception){
                MessageBox.Show("Error al Traer Existencias de Producto");
            }
        }
        private void grdProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            //estoyenfila = grdProducto.CurrentRow.Index;
            //string scodigo = grdProducto.Rows[grdProducto.CurrentCell.RowIndex].Cells[0].Value.ToString();
            //string snombre = grdProducto.Rows[grdProducto.CurrentCell.RowIndex].Cells[1].Value.ToString();
            //string scantidad = grdProducto.Rows[grdProducto.CurrentCell.RowIndex].Cells[2].Value.ToString();
            //txtCantidad.Text = "";
            //cmbProducto.Text = scodigo + "." + snombre;
            //txtCantidad.Text = scantidad;
            ////-----------selcciona el combo y texbox de producto para modificar--------
            //cmbProducto.SelectionStart = 0;
            //cmbProducto.SelectionLength = cmbProducto.Text.Length;
            //txtCantidad.SelectionStart = 0;
            //txtCantidad.SelectionLength = txtCantidad.Text.Length;
            ////-------------------------------------------------------------------------
            ////btnAgregar.Text = "Editar";
            if (MessageBox.Show("¿Desea Retirar el Producto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (this.grdProducto.Columns[e.ColumnIndex].Name.Equals("btnEliminarfila"))
                {

                    int filadondeestoy = grdProducto.CurrentRow.Index;
                    //MessageBox.Show(filadondeestoy.ToString());
                    if (quitarfilas.Equals("Quitar"))
                    {

                        //MessageBox.Show(quitarfilas+" se va elimnar orden de compra");
                        string scodproducto = grdProducto.Rows[grdProducto.CurrentCell.RowIndex].Cells[0].Value.ToString();
                        string sproducto = grdProducto.Rows[grdProducto.CurrentCell.RowIndex].Cells[2].Value.ToString();
                        string[] cort = cmbProveedor.Text.Split('.');
                        string codigo = cort[0];
                        grdProducto.Rows.RemoveAt(filadondeestoy);
                        //MessageBox.Show("orden compra " + sCodigoOrdenCompra + "Codigo Proveedor " + codigo + "codigo Producto " + scodproducto);
                        _comando = new OdbcCommand(String.Format("delete from documento_compra where codproveedor='" + codigo + "' and codproducto='" + scodproducto + "' and codencabezado='" + sCodigoOrdenCompra + "'"), ConexionODBC.Conexion.ObtenerConexion());
                        _comando.ExecuteNonQuery();
                        ConexionODBC.Conexion.CerrarConexion();

                    }
                    else
                    {
                        //MessageBox.Show("solo fila "+ quitarfilas);
                        grdProducto.Rows.RemoveAt(filadondeestoy);
                    }

                }
            }

        }
        private void cmbProveedor_TextChanged(object sender, EventArgs e)
        {
            try
            {
                String[] sTomaCodProveedor = cmbProveedor.Text.Split('.');
                string sCorteCodProveedor = sTomaCodProveedor[0];
                LlenarInfoProveedor(sCorteCodProveedor);
                //funLLenarCmbProductos(sCorteCodProveedor2);
            }
            catch (Exception)
            {
                MessageBox.Show("No se Cargaron los Datos del Proveedor");
            }
        }
        #endregion


        #region funciones principales para datos

        public void funActualizarPrecios(string precio,string codproducto,string codproveedor) {
            try
            {
                _comando = new OdbcCommand(String.Format("update producto set precio='"+precio+"' where codproducto='"+codproducto+"' and codproveedor='"+codproveedor+"'"), ConexionODBC.Conexion.ObtenerConexion());
                _comando.ExecuteNonQuery();
                ConexionODBC.Conexion.CerrarConexion();
            }
            catch (Exception){
                MessageBox.Show("no se pudo actualizar el producto");
            }
        }
        public void funBuscarDetallesProducto() {
            try
            {
                string[] corteproducto = cmbProducto.Text.Split('.');
                string codigo = corteproducto[0];
                string nombre = corteproducto[1];
                cmbProveedor.Items.Clear();
                _comando = new OdbcCommand(String.Format("SELECT precio FROM producto WHERE codproducto='" + codigo + "' and nombreproducto='" + nombre + "'"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    pUnitario = _reader.GetString(0);

                }
                ConexionODBC.Conexion.CerrarConexion();
            }
            catch (Exception) {
                MessageBox.Show("Error al Traer Precio");
            }
        }
        public void funVerificaAgrega() {
            try
            {
             
                
                if (txtCantidad.Text.Equals("") || cmbProducto.Text.Equals("")) {
                    MessageBox.Show("Ingrese un Producto y Su cantidad");
                }
                else{
                    int iCantIngresada = Int16.Parse(txtCantidad.Text); //convierte cantidad a entero
                    //int irangoMinimo = Int16.Parse(lblMinima.Text);//rango minimo que puede ingresar el usuario
                    //int irangoMaximo = Int16.Parse(lblMaxima.Text);//rango maximo que puede ingresar el usuario
                    //int iDisponibles = Int16.Parse(lblExistente.Text);
                    string sCantidadIngresada = txtCantidad.Text;// toma el valor como string de la cantidad ingresada
                    //------------variables para comparar la cantidad con el rango maximo-------
                    //int irestaMaxCant = irangoMaximo - iCantIngresada;
                    //int isumamayorresta = iDisponibles + iCantIngresada; // evalua que no se sobrepase la can ingre por usuario al rango maximo
                    //--------------------------------------------------------------------------
                    //if (iCantIngresada < irangoMinimo || iCantIngresada > irangoMaximo || isumamayorresta > irangoMaximo)
                    //{
                    //    MessageBox.Show("Debe Ingesar una cantidad que este en el rago de los valores minimos y maximos");
                    //}else {
                        string[] corteproducto = cmbProducto.Text.Split('.');
                        string codigo = corteproducto[0];
                        string nombre = corteproducto[1];
                        //int iRecorreGrid = grdProducto.Rows.Count;
                        if (grdProducto.Rows.Count == 0) //if que muestra si el grid tiene registros
                        {
                            //MessageBox.Show("Grid vacio");
                            funBuscarDetallesProducto();
                            double PrecioUnitario=double.Parse(pUnitario);
                            double totalProducto = iCantIngresada*PrecioUnitario;
                            //MessageBox.Show(precioUnitGrid);
                            grdProducto.Rows.Add(codigo, nombre, sCantidadIngresada,pUnitario,totalProducto);
                            txtCantidad.Text = "";
                            cmbProducto.Text = "";
                        }else {
                            //MessageBox.Show(grdProducto.Rows.Count.ToString()+" "+"el grid no esta vacio");
                            Boolean repetido = false;
                            for (int x = 0; x < grdProducto.Rows.Count;x++)
                            {
                                //System.Console.WriteLine("entro al for");
                                string dato = grdProducto.Rows[x].Cells[0].Value.ToString();
                                string dato2 = grdProducto.Rows[x].Cells[1].Value.ToString();
                                if (dato==codigo && dato2==nombre)
                                {
                                    repetido = true;
                                    //System.Console.WriteLine("repetido");
                                }
                                
                                
                            }

                            if (repetido)
                            {
                                MessageBox.Show("Ingrese un producto diferente");
                            }
                            else {
                                //MessageBox.Show("Se Agrego producto");
                                funBuscarDetallesProducto();
                                double PrecioUnitario = double.Parse(pUnitario);
                                double totalProducto = iCantIngresada * PrecioUnitario;
                                grdProducto.Rows.Add(codigo, nombre, sCantidadIngresada,pUnitario,totalProducto);
                            }
                        }
                    //}
                }
                
                
            }
            catch {
                MessageBox.Show("Error Al verificar el producto");
            }
        }

        public void funGenerarOrden() {
            try
            {
               
                //----------------Inserta A Encabezado Orden de compra--------------
                tomarFecha();
                _comando = new OdbcCommand(String.Format("insert into encabezado_doccompra(condicion,fecha,estado) values ('" + condicion + "','" + fecha + "','" + estado + "')"), ConexionODBC.Conexion.ObtenerConexion());
                _comando.ExecuteNonQuery();
                ConexionODBC.Conexion.CerrarConexion();
                //----------------fin de insetar Encabezado Orden de Compra---------

                //----------------Obteniendo Codigo de Encabezado-------------------
                _comando = new OdbcCommand(String.Format("SELECT MAX(encabezado_doccompra.codencabezado) as codigoenc,tipodocumento.codtipodocumento from encabezado_doccompra,tipodocumento WHERE tipodocumento.tipo='Orden de Compra'"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                if (_reader.Read())
                {
                    sCodOrdenCompra = _reader.GetString(0);// trae el ultimo documento ingresado
                    sCodTipoDoc = _reader.GetString(1);//trae el codigo del tipo docmuento llamado Orden de Compra
                    //MessageBox.Show(sCodOrdenCompra+sCodTipoDoc);
                }
                ConexionODBC.Conexion.CerrarConexion();
                //----------------fin de codigo Encabezado--------------------------

                //----------------Insertando en documento compra--------------------
                    //--------corta codigos de impuesto y proveedor-----------------
                    string[] corteproveedor = cmbProveedor.Text.Split('.');
                    string codCortProveedor = corteproveedor[0];

                    string[] corteimpuesto = cmbImpuesto.Text.Split('.');
                    string codCortimpuesto = corteimpuesto[0];
                    //--------corta codigos de impuesto y proveedor-----------------

                //---------aqui recorro el grid para guardar los datos a mi tabla---------
                int iFilasdeGrid = grdProducto.Rows.Count;
                for (int tamaño = 0; tamaño < iFilasdeGrid; tamaño++) {

                    string dtCodigoProducto = grdProducto.Rows[tamaño].Cells[0].Value.ToString();
                    string dtCantidadProducto = grdProducto.Rows[tamaño].Cells[2].Value.ToString();
                    string dtPrecio = grdProducto.Rows[tamaño].Cells[3].Value.ToString();
                    _comando = new OdbcCommand(String.Format("insert into documento_compra(condicion,estado,cantidad,descuento,codtipodocumento,codimpuesto,codproveedor,codproducto,codencabezado) values ('" + condicion + "','" + estado + "','"+dtCantidadProducto+"','"+descuento+"','"+sCodTipoDoc+"','"+codCortimpuesto+"','"+codCortProveedor+"','"+dtCodigoProducto+"','"+sCodOrdenCompra+"')"), ConexionODBC.Conexion.ObtenerConexion());
                    _comando.ExecuteNonQuery();
                    ConexionODBC.Conexion.CerrarConexion();
                    funActualizarPrecios(dtPrecio, dtCodigoProducto, codCortProveedor);
                }
                MessageBox.Show("La Orden Se Guardo con Exito");
                 //-----------------------------fin para Guardar Datos------------------------------------------  
            }catch (Exception) {
                MessageBox.Show("Error al Guardar la Orden");
                
            }
        }

        public Boolean DatoExiste(string codigo) {
            siexiste = false;
            _comando = new OdbcCommand(String.Format("SELECT codproducto,cantidad FROM documento_compra WHERE codencabezado='"+sCodigoOrdenCompra+"' and codproducto='"+codigo+"'"), ConexionODBC.Conexion.ObtenerConexion());
            _reader = _comando.ExecuteReader();
            if (_reader.Read()) { 
            string codproducto = _reader.GetString(0); 
            siexiste=true;
            }
            ConexionODBC.Conexion.CerrarConexion();
            return siexiste;
        }
        public void ActualizarEstado(){
            try
            {
                if (rbActivo.Checked == true)
                {
                    estatus = "ACTIVO";
                    //MessageBox.Show(estatus);
                }
                else if (rbInactivo.Checked == true)
                {
                    estatus = "INACTIVO";
                    //MessageBox.Show(estatus);
                }
                _comando = new OdbcCommand(String.Format("update encabezado_doccompra set estado='" + estatus + "' where codencabezado='" + sCodigoOrdenCompra + "'"), ConexionODBC.Conexion.ObtenerConexion());
                _comando.ExecuteNonQuery();
                ConexionODBC.Conexion.CerrarConexion();
            }catch (Exception){
                MessageBox.Show("No se pudo actualizar el estado");
            }
        }
        public void FunActualizar() {
            try
            {

                grdProducto.Rows.Count.Equals(0);
                for (int dimGrid = 0; dimGrid < grdProducto.Rows.Count; dimGrid++)
                {
                    string[] corteproveedor = cmbProveedor.Text.Split('.');
                    string codCortProveedor = corteproveedor[0];
                    string codigoProductoAgregado = grdProducto.Rows[dimGrid].Cells[0].Value.ToString();
                    //string dato2 = grdProducto.Rows[x].Cells[1].Value.ToString();
                    //string u = "1";
                    if (DatoExiste(codigoProductoAgregado) == true)
                    {
                        
                        //MessageBox.Show("El dato si existe solo se actualizara");
                        string dtCodigoProducto = grdProducto.Rows[dimGrid].Cells[0].Value.ToString();
                        string sActualizarCantidad = grdProducto.Rows[dimGrid].Cells[2].Value.ToString();
                        string sprecuo = grdProducto.Rows[dimGrid].Cells[3].Value.ToString();
                        _comando = new OdbcCommand(String.Format("update documento_compra set cantidad='" + sActualizarCantidad + "' where codencabezado='" + sCodigoOrdenCompra + "' and codproducto='" + codigoProductoAgregado + "' and codproveedor='" + codCortProveedor + "'"), ConexionODBC.Conexion.ObtenerConexion());
                        _comando.ExecuteNonQuery();
                        ConexionODBC.Conexion.CerrarConexion();
                        funActualizarPrecios(sprecuo, dtCodigoProducto, codCortProveedor);

                    }
                    else if (DatoExiste(codigoProductoAgregado) == false)
                    //else
                    {
                        //MessageBox.Show("Se insertara nuevo dato");
                        //----------------Obteniendo Codigo de Encabezado-------------------
                        _comando = new OdbcCommand(String.Format("SELECT MAX(encabezado_doccompra.codencabezado) as codigoenc,tipodocumento.codtipodocumento from encabezado_doccompra,tipodocumento WHERE tipodocumento.tipo='Orden de Compra'"), ConexionODBC.Conexion.ObtenerConexion());
                        _reader = _comando.ExecuteReader();
                        if (_reader.Read())
                        {
                            //sCodOrdenCompra = _reader.GetString(0);// trae el ultimo documento ingresado
                            sCodTipoDoc = _reader.GetString(1);//trae el codigo del tipo docmuento llamado Orden de Compra
                            //MessageBox.Show(sCodOrdenCompra+sCodTipoDoc);
                        }
                        ConexionODBC.Conexion.CerrarConexion();
                        //----------------fin de codigo Encabezado--------------------------
                        //--------corta codigos de impuesto y proveedor-----------------
                        string[] corteimpuesto = cmbImpuesto.Text.Split('.');
                        string codCortimpuesto = corteimpuesto[0];
                        //--------corta codigos de impuesto y proveedor-----------------
                        string dtCodigoProducto = grdProducto.Rows[dimGrid].Cells[0].Value.ToString();
                        string sActualizarCantidad = grdProducto.Rows[dimGrid].Cells[2].Value.ToString();
                        _comando = new OdbcCommand(String.Format("insert into documento_compra(condicion,estado,cantidad,descuento,codtipodocumento,codimpuesto,codproveedor,codproducto,codencabezado) values ('" + condicion + "','" + estado + "','" + sActualizarCantidad + "','" + descuento + "','" + sCodTipoDoc + "','" + codCortimpuesto + "','" + codCortProveedor + "','" + dtCodigoProducto + "','" + sCodigoOrdenCompra + "')"), ConexionODBC.Conexion.ObtenerConexion());
                        _comando.ExecuteNonQuery();
                        ConexionODBC.Conexion.CerrarConexion();
                        string sprecuo = grdProducto.Rows[dimGrid].Cells[3].Value.ToString();
                        funActualizarPrecios(sprecuo, dtCodigoProducto, codCortProveedor);
                        

                    }
                }
                ActualizarEstado();
                MessageBox.Show("Datos Actualizado Correctamente");
            }
            catch (Exception) {
                MessageBox.Show("No se pudieron Actualizar los datos");
            }
            


            }
        #endregion

        #region Funciones que se activan cuando se presionan en el navegador

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            bloquearTodos();
            funLlenarCmbImpuesto();
            habilitarConNuevo();
            funLimpiar();
            AccionBoton = "";
            AccionBoton = "GUARDAR";
            funLlenarCmbProveedor();
            funLlenarCmbImpuesto();
            funNoOrdenCompra();
            
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(AccionBoton.Equals("GUARDAR")){
            if (!cmbImpuesto.Text.Equals("") && !cmbProveedor.Text.Equals("") && !grdProducto.Rows.Count.Equals(0))
            {
                if (MessageBox.Show("¿Desea Generar La Orden de Compra?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funGenerarOrden();
                    funLimpiar();
                    bloquearTodos();
                }
            }
            else {
                MessageBox.Show("Asegurese que Todos los campos y tabla esten llenos");
            }
        }else if(AccionBoton.Equals("EDITAR")){
            if (MessageBox.Show("¿Desea Actualizar La Orden de Compra?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FunActualizar();
                funLimpiar();
                bloquearTodos();
            }
        }else if(AccionBoton.Equals("ELIMINAR")){
            try
            {
                if (MessageBox.Show("¿Desea Eliminar la Orden de Compra?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //MessageBox.Show(sCodigoOrdenCompra);
                    _comando = new OdbcCommand(String.Format("update encabezado_doccompra set condicion='" + "0" + "' where codencabezado='" + sCodigoOrdenCompra + "'"), ConexionODBC.Conexion.ObtenerConexion());
                    _comando.ExecuteNonQuery();
                    ConexionODBC.Conexion.CerrarConexion();
                    funLimpiar();
                    bloquearTodos();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("No se Pudo Eliminar la Orden de Compra");
            }
        }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Cancelar La Operacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funLimpiar();
                bloquearTodos();
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            AccionBoton = "";
            AccionBoton = "ELIMINAR";
            funhabilitaedicion();
            btnGuardar.Enabled = true;
            //try
            //{
            //    if (MessageBox.Show("¿Desea Eliminar la Orden de Compra?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //    {
            //        //MessageBox.Show(sCodigoOrdenCompra);
            //        _comando = new OdbcCommand(String.Format("update encabezado_doccompra set condicion='" + "0" + "' where codencabezado='" + sCodigoOrdenCompra + "'"), ConexionODBC.Conexion.ObtenerConexion());
            //        _comando.ExecuteNonQuery();
            //        ConexionODBC.Conexion.CerrarConexion();
            //        funLimpiar();
            //        bloquearTodos();
            //    }
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("No se Pudo Eliminar la Orden de Compra");
            //}
        }
        #endregion

        #region Boton que sirve para agregar producto y para editar la cantidad ingresada
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text.Equals("Agregar"))
            {
                funVerificaAgrega();
                funSumarOrdenCompra();
            }
            else if (btnAgregar.Text.Equals("Editar"))
            {
                if (MessageBox.Show("¿Desea Modificar la Cantidad?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funEditarCantidad();
                    funVerificaAgrega();
                    btnAgregar.Text = "Agregar";
                }
                else {
                    btnAgregar.Text ="Agregar";
                }
            }
        }
        public void funEditarCantidad()
        {
            //MessageBox.Show(estoyenfila.ToString());
            grdProducto.Rows.RemoveAt(estoyenfila);
        }
        #endregion

        private void btnEditar_Click(object sender, EventArgs e)
        {
            AccionBoton = "";
            AccionBoton = "EDITAR";
            funhabilitaedicion();
            btnGuardar.Enabled = true;
            //if (MessageBox.Show("¿Desea Actualizar La Orden de Compra?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    FunActualizar();
            //    funLimpiar();
            //    bloquearTodos();
            //}
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string debug = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
            String ruta = debug + @"\ayudaordendecompra.chm";
            Help.ShowHelp(this, ruta, HelpNavigator.Topic, "Manual de usuario");
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            //if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    string rutaParaGuardar = folderBrowserDialog1.SelectedPath;
            //    MessageBox.Show(rutaParaGuardar);
            //    string rt = rutaParaGuardar + "/";
            //    funCrearDoc(rt);
            //}
            DataSet1 dt = new DataSet1();


            for (int tamano = 0; tamano < grdProducto.Rows.Count; tamano++)
            {

                dt.TablagridProductos.Rows.Add
                (new object[] { 
                    grdProducto[0,tamano].Value.ToString(),
                    grdProducto[1,tamano].Value.ToString(),
                    grdProducto[2,tamano].Value.ToString(),
                    grdProducto[3,tamano].Value.ToString(),
                    grdProducto[4,tamano].Value.ToString(),
                    sCodigoOrdenCompra.ToString(),
                    cmbProveedor.Text.ToString(),
                    txtNit.Text.ToString(),
                    txtTelefono.Text.ToString(),
                    txtTotalGrid.Text.ToString()
                }
                );
            }
            PruebaReporteGrid objRpt = new PruebaReporteGrid();
            objRpt.SetDataSource(dt);

            frmVistaReporte vista = new frmVistaReporte();
            //vista.crystalReportViewer1.ReportSource = objRpt2;
            vista.crystalReportViewer1.ReportSource = objRpt;
            vista.Show();
        }

        public void funSumarOrdenCompra() {
            try
            {
                
                txtTotalGrid.Text = "";
                SumarTotalOrdenCompra = 0;
                for (int tamano = 0; tamano < grdProducto.Rows.Count; tamano++)
                {
                    double sTotal = double.Parse(grdProducto.Rows[tamano].Cells[4].Value.ToString());
                    SumarTotalOrdenCompra = SumarTotalOrdenCompra + sTotal;
                }
                txtTotalGrid.Text = SumarTotalOrdenCompra.ToString();
            }catch(Exception){
                MessageBox.Show("Error al Sumar el Total de la Orden de Compra");
            }
        }

        public void MultiplicarCantPrecio() {
            try
            {
                int filGrid = grdProducto.Rows.Count;
                for (int tamano = 0; tamano < filGrid; tamano++)
                {
                    string sCantidad = grdProducto.Rows[tamano].Cells[2].Value.ToString();
                    string sPrecio = grdProducto.Rows[tamano].Cells[3].Value.ToString();
                    //MessageBox.Show("cantidad "+sCantidad+"precio u "+sPrecio);
                    double convsCantidad = double.Parse(sCantidad);
                    double convsPrecio = double.Parse(sPrecio);
                    double CantidadPrecio;
                    CantidadPrecio = convsCantidad * convsPrecio;
                    //MessageBox.Show(CantidadPrecio.ToString());
                    grdProducto.Rows[tamano].Cells[4].Value = CantidadPrecio;
                    CantidadPrecio = 0;
                }
            }
            catch (Exception) {
                MessageBox.Show("Error Al multiplicar celdas de precio y cantidad");
            }
        }
        private void grdProducto_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                MultiplicarCantPrecio();
                funSumarOrdenCompra();
            }catch(Exception){
                MessageBox.Show("Error al otener cantidades");
            }
        }

        /*
        private void grdProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        //    if (MessageBox.Show("¿Desea Retirar el Producto?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
        //    {
        //    if (this.grdProducto.Columns[e.ColumnIndex].Name.Equals("btnEliminarfila"))
        //    {

        //        int filadondeestoy = grdProducto.CurrentRow.Index;
        //        //MessageBox.Show(filadondeestoy.ToString());
        //        if (quitarfilas.Equals("Quitar"))
        //        {
                    
        //            //MessageBox.Show(quitarfilas+" se va elimnar orden de compra");
        //            string scodproducto = grdProducto.Rows[grdProducto.CurrentCell.RowIndex].Cells[0].Value.ToString();
        //            string sproducto = grdProducto.Rows[grdProducto.CurrentCell.RowIndex].Cells[2].Value.ToString();
        //            string[] cort = cmbProveedor.Text.Split('.');
        //            string codigo = cort[0];
        //            grdProducto.Rows.RemoveAt(filadondeestoy);
        //            //MessageBox.Show("orden compra " + sCodigoOrdenCompra + "Codigo Proveedor " + codigo + "codigo Producto " + scodproducto);
        //            _comando = new OdbcCommand(String.Format("delete from documento_compra where codproveedor='" + codigo + "' and codproducto='" + scodproducto + "' and codencabezado='" + sCodigoOrdenCompra + "'"), ConexionODBC.Conexion.ObtenerConexion());
        //            _comando.ExecuteNonQuery();
        //            ConexionODBC.Conexion.CerrarConexion();
                    
        //        }
        //        else {
        //            //MessageBox.Show("solo fila "+ quitarfilas);
        //            grdProducto.Rows.RemoveAt(filadondeestoy);   
        //        }
               
        //    }
        //}
        } */

    }
}

using Filtrado;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_compras
{
    public partial class frmCreacionOc : Form
    {
        public static OdbcCommand _comando;
        public static OdbcDataReader _reader;
        int estoyenfila;
        string pUnitario, fecha, condicion = "1", estado = "ACTIVO",descuento="0", sCodOrdenCompra, sCodTipoDoc; //variables para detalles de producto

        public frmCreacionOc()
        {
            InitializeComponent();
            funEsconderRbs();
            rbOrdenCompra.Select();
            funLlenarCmbProveedor();
            funLlenarCmbImpuesto();
            bloquearTodos();
            
        }
        public void bloquearTodos()
        {
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
        }
        public void habilitarConNuevo()
        {
            rbOrdenCompra.Select();
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
        }
        public void funEsconderRbs() {
            rbDevoluciones.Visible = false;
            rbRecepcion.Visible = false;
            rbRequisicion.Visible = false;
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
            cmbProveedor.Text = "";
            cmbImpuesto.Text = "";
            cmbProducto.Text = "";
            txtCantidad.Text = "";
            lblDisponibles.Text = "";
            lblExistente.Text = "";
            lblMaxima.Text = "";
            lblMinima.Text = "";
            grdProducto.Rows.Clear();
        }

        #region funciones que llenan combobox de producto,proveedor e impuesto
        public void funLlenarCmbProveedor() {
            cmbProveedor.Items.Clear();
            _comando = new OdbcCommand(String.Format("Select CONCAT(codproveedor,'.',nombre)AS Proveedor FROM proveedor where estado = 'ACTIVO' and condicion = 1"), ConexionODBC.Conexion.ObtenerConexion());
            _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                string proveedor = _reader.GetString(0);
                cmbProveedor.Items.Add(proveedor);
            }
        }
        public void LlenarInfoProveedor(String codProveedor)
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
        }
        public void funLlenarCmbImpuesto() {
            cmbImpuesto.Items.Clear();
            _comando = new OdbcCommand(String.Format("SELECT CONCAT(impuestos.codimpuesto,'.',impuestos.nombre)AS Ipuesto FROM impuestos where condicion='1'"), ConexionODBC.Conexion.ObtenerConexion());
            _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                string impuesto = _reader.GetString(0);
                cmbImpuesto.Items.Add(impuesto);
            }
        }
        public void funLLenarCmbProductos(string scodProveedor) {
            cmbProducto.Items.Clear();
            _comando = new OdbcCommand(String.Format("SELECT CONCAT(producto.codproducto,'.',producto.nombreproducto)AS Producto FROM producto,proveedor WHERE producto.codproveedor=proveedor.codproveedor and proveedor.codproveedor='"+scodProveedor+"';"), ConexionODBC.Conexion.ObtenerConexion());
            _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                string proveedor = _reader.GetString(0);
                cmbProducto.Items.Add(proveedor);
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
        #endregion

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
            btnAgregar.Text = "Agregar";
            txtCantidad.Text = "";
            string[] corteproducto = cmbProducto.Text.Split('.');
            string codigo = corteproducto[0];
            _comando = new OdbcCommand(String.Format("SELECT producto.exstmin,producto.exstmax,producto.existencia FROM producto WHERE producto.codproducto='"+codigo+"'"), ConexionODBC.Conexion.ObtenerConexion());
            _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                string min = _reader.GetString(0);
                string max = _reader.GetString(1);
                string act = _reader.GetString(2);
                lblMaxima.Text = max;
                lblMinima.Text = min;
                lblExistente.Text = act;
                int Disponible = Int16.Parse(lblExistente.Text);
                int irangoMinimo = Int16.Parse(lblMinima.Text);//rango minimo que puede ingresar el usuario
                int irangoMaximo = Int16.Parse(lblMaxima.Text);//rango maximo que puede ingresar el usuario
                int irestaMaxCant = irangoMaximo - Disponible;//muestra al usuario la cantidad de unidades que puede ingresar
                lblDisponibles.Text = irestaMaxCant.ToString();
                
            }
            
        }
        private void grdProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            estoyenfila = grdProducto.CurrentRow.Index;
            string scodigo = grdProducto.Rows[grdProducto.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string snombre = grdProducto.Rows[grdProducto.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string scantidad = grdProducto.Rows[grdProducto.CurrentCell.RowIndex].Cells[2].Value.ToString();
            txtCantidad.Text = "";
            cmbProducto.Text = scodigo + "." + snombre;
            txtCantidad.Text = scantidad;
            //-----------selcciona el combo y texbox de producto para modificar--------
            cmbProducto.SelectionStart = 0;
            cmbProducto.SelectionLength = cmbProducto.Text.Length;
            txtCantidad.SelectionStart = 0;
            txtCantidad.SelectionLength = txtCantidad.Text.Length;
            //-------------------------------------------------------------------------
            btnAgregar.Text = "Editar";

        }
        #endregion


        #region funciones principales para datos
        public void funCorteCodigos() {
            string[] corteproveedor = cmbProducto.Text.Split('.');
            string codCortProveedor = corteproveedor[0];

            string[] corteimpuesto = cmbProducto.Text.Split('.');
            string codCortimpuesto = corteimpuesto[0];

            //string[] corteproducto = cmbProducto.Text.Split('.');
            //string codCortProducto = corteproducto[0];
            
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
                    int irangoMinimo = Int16.Parse(lblMinima.Text);//rango minimo que puede ingresar el usuario
                    int irangoMaximo = Int16.Parse(lblMaxima.Text);//rango maximo que puede ingresar el usuario
                    int iDisponibles = Int16.Parse(lblExistente.Text);
                    string sCantidadIngresada = txtCantidad.Text;// toma el valor como string de la cantidad ingresada
                    //------------variables para comparar la cantidad con el rango maximo-------
                    int irestaMaxCant = irangoMaximo - iCantIngresada;
                    int isumamayorresta = iDisponibles + iCantIngresada; // evalua que no se sobrepase la can ingre por usuario al rango maximo
                    //--------------------------------------------------------------------------
                    if (iCantIngresada < irangoMinimo || iCantIngresada > irangoMaximo || isumamayorresta > irangoMaximo)
                    {
                        MessageBox.Show("Debe Ingesar una cantidad que este en el rago de los valores minimos y maximos");
                    }else {
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
                    }
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
                //----------------fin de insetar Encabezado Orden de Compra---------

                //----------------Obteniendo Codigo de Encabezado-------------------
                _comando = new OdbcCommand(String.Format("SELECT MAX(encabezado_doccompra.codencabezado) as codigoenc,tipodocumento.codtipodocumento from encabezado_doccompra,tipodocumento WHERE tipodocumento.tipo='Orden de Compra'"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                if (_reader.Read())
                {
                    sCodOrdenCompra = _reader.GetString(0);// trae el ultimo documento ingresado
                    sCodTipoDoc = _reader.GetString(1);//trae el codigo del tipo docmuento llamado Orden de Compra
                    MessageBox.Show(sCodOrdenCompra+sCodTipoDoc);
                }
                //----------------fin de codigo Encabezado--------------------------

                //----------------Insertando en documento compra--------------------
                    //--------corta codigos de impuesto y proveedor-----------------
                    string[] corteproveedor = cmbProducto.Text.Split('.');
                    string codCortProveedor = corteproveedor[0];

                    string[] corteimpuesto = cmbProducto.Text.Split('.');
                    string codCortimpuesto = corteimpuesto[0];
                    //--------corta codigos de impuesto y proveedor-----------------

                int iFilasdeGrid = grdProducto.Rows.Count;
                for (int tamaño = 0; tamaño < iFilasdeGrid; tamaño++) {

                    string dtCodigoProducto = grdProducto.Rows[tamaño].Cells[0].Value.ToString();
                    string dtCantidadProducto = grdProducto.Rows[tamaño].Cells[2].Value.ToString();
                    _comando = new OdbcCommand(String.Format("insert into documento_compra(condicion,estado,cantidad,descuento,codtipodocumento,codimpuesto,codproveedor,codproducto,codencabezado) values ('" + condicion + "','" + estado + "','"+dtCantidadProducto+"','"+descuento+"','"+sCodTipoDoc+"','"+codCortimpuesto+"','"+codCortProveedor+"','"+dtCodigoProducto+"','"+sCodOrdenCompra+"')"), ConexionODBC.Conexion.ObtenerConexion());
                    _comando.ExecuteNonQuery();
                }
                   


            }catch (Exception) {
                MessageBox.Show("Error al Guardar la Orden");
            }
        }
        #endregion

        #region Funciones que se activan cuando se presionan en el navegador

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarConNuevo();
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Generar La Orden de Compra?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funGenerarOrden();
                funLimpiar();
                bloquearTodos();
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
        #endregion

        #region Boton que sirve para agregar producto y para editar la cantidad ingresada
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (btnAgregar.Text.Equals("Agregar"))
            {
                funVerificaAgrega();
            }
            else if (btnAgregar.Text.Equals("Editar"))
            {
                if (MessageBox.Show("¿Desea Modificar la Cantidad?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    funEditarCantidad();
                    funVerificaAgrega();
                    btnAgregar.Text = "Agregar";
                }
            }
        }
        public void funEditarCantidad()
        {
            //MessageBox.Show(estoyenfila.ToString());
            grdProducto.Rows.RemoveAt(estoyenfila);
        }
        #endregion

       

       




    }
}

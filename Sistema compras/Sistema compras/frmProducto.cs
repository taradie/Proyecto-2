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
using Navegador;
using Filtrado;

namespace Sistema_compras
{
    public partial class frmProducto : Form
    {
        #region Variables
            public static OdbcCommand _comando;
            public static OdbcDataReader _reader;
            char[] separador = { '.' };
            char[] diagonal = {'\\'};
            private string codigo, pathe;
        #endregion

        #region Funciones de Inicio
            public frmProducto()
            {
                InitializeComponent();
                LlenadoCombos();
                BloqueoNuevo();
            }

            public frmProducto(string cod, string nom, string des, string marca, string proveedor, 
                string linea, string tamano, string costo, string precio, string existencia, string exmin, 
                string exmax, string costeo, string tipo, string fechac, string venta, string compra, string comision, string estado)
            {
                InitializeComponent();
                BloqueoEdicion();
                LlenadoCombos();
                codigo = cod;
                #region Llenado de Datos
                    txtCodigo.Text = cod;
                    txtNombre.Text = nom;
                    txtDescripcion.Text = des;
                    txtCosto.Text = costo;
                    txtPrecio.Text = precio;
                    txtExistencia.Text = existencia;
                    txtVenta.Text = venta;
                    txtCompra.Text = compra;
                    txtCreacion.Text = fechac;
                    txtTamano.Text = tamano;
                    txtExMax.Text = exmax;
                    txtExMin.Text = exmin;
                    txtComision.Text = comision;
                    switch (costeo)
                    {
                        case "UEPS":
                            rbUEPS.Select();
                        break;
                        case "PEPS":
                            rbPEPS.Select();
                        break;
                        case "Promedio":
                            rbPromedio.Select();
                        break;
                        case "Estandar":
                            rbEstandar.Select();
                        break;
                    }
                    if (tipo == "Producto")
                    {
                        rbProducto.Select();
                    }
                    else
                    {
                        rbServicio.Select();
                    }
                    if (estado == "ACTIVO")
                    {
                        rbActivo.Select();
                    }
                    else
                    {
                        rbInactivo.Select();
                    }

                    _comando = new OdbcCommand(String.Format("Select CONCAT(codmarca,'.',descripcion)AS Marca FROM marca where descripcion = '{0}'", marca), ConexionODBC.Conexion.ObtenerConexion());
                    _reader = _comando.ExecuteReader();
                    if (_reader.Read())
                        marca = _reader.GetString(0);
                    cmbMarca.Text = marca;    

                    _comando = new OdbcCommand(String.Format("Select CONCAT(codlinea,'.',descripcion)AS Linea FROM linea where descripcion = '{0}'",linea), ConexionODBC.Conexion.ObtenerConexion());
                    _reader = _comando.ExecuteReader();
                    if (_reader.Read())
                        linea = _reader.GetString(0);

                    _comando = new OdbcCommand(String.Format("Select CONCAT(codproveedor,'.',nombre)AS Proveedor FROM proveedor where nombre = '{0}'", proveedor), ConexionODBC.Conexion.ObtenerConexion());
                    _reader = _comando.ExecuteReader();
                    if (_reader.Read())
                        proveedor = _reader.GetString(0);

                    _comando = new OdbcCommand(String.Format("Select imagen FROM producto where codproducto = '{0}'", cod), ConexionODBC.Conexion.ObtenerConexion());
                    _reader = _comando.ExecuteReader();
                    if (_reader.Read())
                        pathe = _reader.GetString(0);
                    try
                    {
                        PictureBox.Image = Image.FromFile(pathe);
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("No se pudo obtener la imagen");
                    }
                    

                    cmbMarca.SelectedItem = marca;
                    cmbLinea.SelectedItem = linea;
                    cmbProveedor.SelectedItem = proveedor;
                #endregion
            }
        #endregion

        #region Funcioens Visuales

            #region Bloqueo de Botones
                
                public void BloqueoNuevo()
                {
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = false;
                    btnEliminar.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnNuevo.Enabled = false; 
                    btnRefrescar.Enabled = true;
                    txtCodigo.Enabled = false;
                }

                public void BloqueoEdicion()
                {
                    btnCancelar.Enabled = true;
                    btnEditar.Enabled = true;
                    btnEliminar.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnNuevo.Enabled = true;
                    btnRefrescar.Enabled = true;
                    txtCodigo.Enabled = false;
                }

            #endregion

            private void LimpiarTextos()
            {
                txtCodigo.Text = txtCosto.Text = txtDescripcion.Text = txtNombre.Text = txtPrecio.Text = txtCreacion.Text= "";
                cmbProveedor.SelectedIndex = cmbMarca.SelectedIndex = cmbLinea.SelectedIndex = - 1;
                txtCompra.Text = txtVenta.Text = txtExistencia.Text = txtExMax.Text = txtExMin.Text = txtTamano.Text = txtComision.Text ="";
                rbUEPS.Checked = rbProducto.Checked = true;
                PictureBox.Image = null;
            }

            private void rbProducto_CheckedChanged(object sender, EventArgs e)
            {
                cmbLinea.Enabled = cmbMarca.Enabled = gbCosteo.Enabled = cmbProveedor.Enabled = true;
                txtExMax.Enabled = txtExMin.Enabled = txtTamano.Enabled = true;
                rbEstandar.Checked = rbPEPS.Checked = rbPromedio.Checked = rbUEPS.Checked = false;
            }

            private void rbServicio_CheckedChanged(object sender, EventArgs e)
            {
                cmbLinea.Enabled = cmbMarca.Enabled = gbCosteo.Enabled = cmbProveedor.Enabled = txtPrecio.Enabled = false;
                txtExistencia.Enabled = txtExMax.Enabled = txtExMin.Enabled = txtCosto.Enabled = txtTamano.Enabled = false;
            }
        #endregion

        #region Funciones de Botones

            private void btnNuevo_Click(object sender, EventArgs e)
            {
                LimpiarTextos();
                BloqueoNuevo();
            }

            private void btnEditar_Click(object sender, EventArgs e)
            {
                if (rbProducto.Checked)
                {
                    if (!txtDescripcion.Text.Equals("") && !txtNombre.Text.Equals("") && !cmbProveedor.Text.Equals("") && !cmbLinea.Text.Equals("")
                        && !cmbMarca.Text.Equals("") && !txtTamano.Text.Equals("") && !txtComision.Text.Equals("") && !txtExMin.Text.Equals("") && !txtExMax.Text.Equals(""))
                    {
                        funActualizar();
                    }
                    else
                    {
                        MessageBox.Show("Todos campos habilitados deben estar llenos", "Datos no Guardados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!txtDescripcion.Text.Equals("") && !txtNombre.Text.Equals("") && !txtComision.Text.Equals(""))
                    {
                        funActualizar();
                    }
                    else
                    {
                        MessageBox.Show("Todos campos habilitados deben estar llenos", "Datos no Guardados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            private void btnEliminar_Click(object sender, EventArgs e)
            {
                funEliminar();
            }

            private void btnGuardar_Click(object sender, EventArgs e)
            {
                if (rbProducto.Checked)
                {
                    if (!txtDescripcion.Text.Equals("") && !txtNombre.Text.Equals("") && !cmbProveedor.Text.Equals("") && !cmbLinea.Text.Equals("")
                        && !cmbMarca.Text.Equals("") && !txtTamano.Text.Equals("") && !txtComision.Text.Equals("") && !txtExMin.Text.Equals("") && !txtExMax.Text.Equals(""))
                    {
                        funGuardarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Todos campos habilitados deben estar llenos", "Datos no Guardados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!txtDescripcion.Text.Equals("") && !txtNombre.Text.Equals("") && !txtComision.Text.Equals(""))
                    {
                        funGuardarDatos();
                    }
                    else
                    {
                        MessageBox.Show("Todos campos habilitados deben estar llenos", "Datos no Guardados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("¿Desea Cancelar La Operacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LimpiarTextos();
                    BloqueoNuevo();
                }
            }

            private void btnRefrescar_Click(object sender, EventArgs e)
            {
                LlenadoCombos();
            }

            private void btnAyuda_Click(object sender, EventArgs e)
            {
                Help.ShowHelp(this, helpProvider1.HelpNamespace);
            }

            private void btnIMG_Click(object sender, EventArgs e)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                string path, pathCortado = "";
                if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    path = ofd.FileName;
                    PictureBox.Image = Image.FromFile(path);
                    string[] path2 = path.Split(diagonal);
                    foreach (string i in path2)
                    {
                        pathCortado = pathCortado + i + '\\' + '\\';
                    }
                    string PathFinal = pathCortado.TrimEnd('\\');
                    txtIMG.Text = PathFinal;
                    //MessageBox.Show(aux);
                }

            }

        #endregion

        #region Manejo de BD
            
            private void LlenadoCombos()
            {
                cmbLinea.Items.Clear();
                _comando = new OdbcCommand(String.Format("Select CONCAT(codlinea,'.',descripcion)AS Linea FROM linea where estado = 'ACTIVO' and condicion = 1"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    string Linea = _reader.GetString(0);
                    cmbLinea.Items.Add(Linea);
                }
            
                cmbMarca.Items.Clear();
                _comando = new OdbcCommand(String.Format("Select CONCAT(codmarca,'.',descripcion)AS Marca FROM marca where estado = 'ACTIVO' and condicion = 1"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    string marca = _reader.GetString(0);
                    cmbMarca.Items.Add(marca);
                }

                cmbProveedor.Items.Clear();
                _comando = new OdbcCommand(String.Format("Select CONCAT(codproveedor,'.',nombre)AS Proveedor FROM proveedor where estado = 'ACTIVO' and condicion = 1"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    string proveedor = _reader.GetString(0);
                    cmbProveedor.Items.Add(proveedor);
                }
            }

            private void TomarDatos()
            {
                if (rbActivo.Checked)
                {
                    txtEstado.Text = "ACTIVO";
                }
                else if (rbInactivo.Checked)
                {
                    txtEstado.Text = "INACTIVO";
                }
                if (rbProducto.Checked)
                {
                    if (rbEstandar.Checked == true)
                        txtCosteo.Text = "Estandar";
                    else if (rbPEPS.Checked == true)
                        txtCosteo.Text = "PEPS";
                    else if (rbUEPS.Checked == true)
                        txtCosteo.Text = "UEPS";
                    else if (rbPromedio.Checked == true)
                        txtCosteo.Text = "Promedio";
                    string[] marca = cmbMarca.Text.Split(separador);
                    txtMarca.Text = marca[0];
                    string[] Linea = cmbLinea.Text.Split(separador);
                    txtLinea.Text = Linea[0];
                    string[] Proveedor = cmbProveedor.Text.Split(separador);
                    txtProveedor.Text = Proveedor[0];
                    txtTipo.Text = "Producto";
                    txtCosto.Text = txtPrecio.Text = txtExistencia.Text = "0";
                    txtCompra.Text = txtVenta.Text = "-";
                    txtCreacion.Text = DateTime.Now.ToString("yyyy/MM/dd");
                }
                else if (rbServicio.Checked)
                {
                    string nombre = txtNombre.Text;
                    string descripcion = txtDescripcion.Text;
                    txtCosto.Text = txtExistencia.Text = txtPrecio.Text = null;
                    txtCosteo.Text = "-";
                    txtLinea.Text = txtProveedor.Text = txtMarca.Text = "1";
                    txtTipo.Text = "Servicio";
                    txtEstado.Text = "ACTIVO";
                    txtCosto.Text = txtPrecio.Text = txtExistencia.Text = "0";
                    txtCompra.Text = txtVenta.Text = "-";
                    txtCreacion.Text = DateTime.Now.ToString("yyyy/MM/dd");
                }
            }

            public void funGuardarDatos()
            {
                TomarDatos();
                try{
                    clasnegocio cn = new clasnegocio();
                    Boolean bPermiso = true;
                    txtCondicion.Text = "1";
                    TextBox[] aDatos = { txtEstado, txtCondicion, txtCosto, txtNombre, txtDescripcion, txtTamano, txtPrecio, 
                    txtExistencia, txtExMin, txtExMax, txtCosteo,txtTipo, txtCreacion, txtVenta, txtCompra, txtComision, txtIMG, txtMarca, txtLinea, txtProveedor};
                    string sTabla = "producto";
                    cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                    LimpiarTextos();
                    MessageBox.Show("Datos guardados con exito");
                }catch (Exception){
                    MessageBox.Show("Ocurrio un error al guardar los datos");
                }
            }

            public void funActualizar()
            {
                TomarDatos();
                try{
                    clasnegocio cn = new clasnegocio();
                    Boolean bPermiso = true;
                    txtCondicion.Text = "1";
                    TextBox[] aDatos = { txtEstado, txtCondicion, txtCosto, txtNombre, txtDescripcion, txtTamano, txtPrecio, 
                        txtExistencia, txtExMin, txtExMax, txtCosteo,txtTipo, txtCreacion, txtVenta, txtCompra, txtComision, txtIMG, txtMarca, txtLinea, txtProveedor};
                    string sTabla = "producto";
                    string codigoproducto = "codproducto";
                    cn.EditarObjetos(sTabla, bPermiso, aDatos, codigo, codigoproducto);
                    LimpiarTextos();
                    MessageBox.Show("Datos editados con exito");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error al guardar los datos");
                }
            }

            public void funEliminar()
            {
                TomarDatos();
                try
                {
                    clasnegocio cn = new clasnegocio();
                    Boolean bPermiso = true;
                    txtCondicion.Text = "0";
                    TextBox[] aDatos = { txtEstado, txtCondicion, txtCosto, txtNombre, txtDescripcion, txtTamano, txtPrecio, 
                        txtExistencia, txtExMin, txtExMax, txtCosteo,txtTipo, txtCreacion, txtVenta, txtCompra, txtComision, txtMarca, txtLinea, txtProveedor};
                    string sTabla = "producto";
                    string codigopersona = "codproducto";
                    cn.EditarObjetos(sTabla, bPermiso, aDatos, codigo, codigopersona);
                    LimpiarTextos();
                    MessageBox.Show("Datos eliminados con exito");
                }
                catch (Exception)
                {
                    MessageBox.Show("Ocurrio un error al guardar los datos");
                }
            }

        #endregion   

        #region Validaciones
            private void txtTamano_KeyPress(object sender, KeyPressEventArgs e)
            {
                if ((e.KeyChar != (char)Keys.Back) && !(e.KeyChar == 13) && !(e.KeyChar == 46) && !(char.IsNumber(e.KeyChar)))
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }

            private void txtComision_KeyPress(object sender, KeyPressEventArgs e)
            {
                if ((e.KeyChar != (char)Keys.Back) && !(e.KeyChar == 13) && !(e.KeyChar == 46) && !(char.IsNumber(e.KeyChar)))
                {
                    MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
            }
        #endregion

        #region Funciones Busqueda Combos

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

            private void btnFilMarca_Click(object sender, EventArgs e)
            {
                string sCampoCodigo = "codmarca";
                string sCampoDescripcion = "descripcion";
                string query = "Select codmarca, descripcion from marca where condicion='1'";
                frmFiltrado filtro = new frmFiltrado(query,sCampoCodigo, sCampoDescripcion);
                filtro.ShowDialog(this);
                int index = cmbProveedor.FindString(filtro.funResultado());
                cmbProveedor.SelectedIndex = index;
            }

            private void btnFilLinea_Click(object sender, EventArgs e)
            {
                string sCampoCodigo = "codlinea";
                string sCampoDescripcion = "descripcion";
                string query = "Select codlinea, descripcion from linea where condicion='1'";
                frmFiltrado filtro = new frmFiltrado(query,sCampoCodigo, sCampoDescripcion);
                filtro.ShowDialog(this);
                int index = cmbProveedor.FindString(filtro.funResultado());
                cmbProveedor.SelectedIndex = index;
            }
        #endregion
    }

}

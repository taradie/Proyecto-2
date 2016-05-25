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
    public partial class frmExistencias : Form
    {
        
        #region Variables
        public static OdbcCommand _comando;
        public static OdbcDataReader _reader;
        char[] separador = { '.' };
        private string codigo="",codalmacen;
        #endregion

        #region Funcioens de Inicio

            public frmExistencias()
            {
                InitializeComponent();
                LlenadoCombos();
                BloqueoNuevo();
            }

            public frmExistencias(string existencias, string almacen, string producto, string ingreso, string egreso)
            {
                InitializeComponent();
                LlenadoCombos();
                BloqueoEdicion();
                txtCantidad.Text = existencias;
                txtIngreso.Text = ingreso;
                txtEgreso.Text = egreso;

                _comando = new OdbcCommand(String.Format("Select codalmacen FROM almacen where nombre = '{0}'", almacen), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                if (_reader.Read())
                    codalmacen = _reader.GetString(0);
                ConexionODBC.Conexion.CerrarConexion();

                _comando = new OdbcCommand(String.Format("Select codExistencias FROM existencias where codproducto = '{0}' AND codalmacen = '{0}'", producto, almacen), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                if (_reader.Read())
                    codigo = _reader.GetString(0);
                ConexionODBC.Conexion.CerrarConexion();

                _comando = new OdbcCommand(String.Format("Select CONCAT(codalmacen,'.',nombre)AS Almacen FROM almacen where nombre = '{0}'", almacen), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                if (_reader.Read())
                    almacen = _reader.GetString(0);
                cmbAlmacen.Text = almacen;
                ConexionODBC.Conexion.CerrarConexion();

                _comando = new OdbcCommand(String.Format("Select CONCAT(codproducto,'.',nombreproducto)AS Producto FROM producto where codproducto = '{0}'", producto), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                if (_reader.Read())
                    producto = _reader.GetString(0);
                cmbProducto.Text = producto;
                ConexionODBC.Conexion.CerrarConexion();

                
            }

        #endregion

        #region Funciones Visuales

            public void BloqueoNuevo()
            {
                btnCancelar.Enabled = true;
                btnEditar.Enabled = false;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = true;
                btnNuevo.Enabled = false;
                btnRefrescar.Enabled = true;
            }

            public void BloqueoEdicion()
            {
                btnCancelar.Enabled = true;
                btnEditar.Enabled = true;
                btnEliminar.Enabled = false;
                btnGuardar.Enabled = false;
                btnNuevo.Enabled = true;
                btnRefrescar.Enabled = true;
            }

            private void LimpiarTextos()
        {
            txtCantidad.Text = "";
            cmbProducto.SelectedIndex = cmbAlmacen.SelectedIndex;
        }

        #endregion

        #region Funciones de Botones

            private void btnAyuda_Click(object sender, EventArgs e)
            {

            }

            private void btnRefrescar_Click(object sender, EventArgs e)
            {
                LlenadoCombos();
            }

            private void btnCancelar_Click(object sender, EventArgs e)
            {
                if (MessageBox.Show("¿Desea Cancelar La Operacion?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    LimpiarTextos();
                    BloqueoNuevo();
                }
            }

            private void btnGuardar_Click(object sender, EventArgs e)
            {
                if (!cmbProducto.Text.Equals("") && !cmbAlmacen.Text.Equals(""))
                {
                    funGuardarDatos();
                }
                else
                {
                    MessageBox.Show("Todos campos habilitados deben estar llenos", "Datos no Guardados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnEliminar_Click(object sender, EventArgs e)
            {

            }

            private void btnEditar_Click(object sender, EventArgs e)
            {
                if (!cmbProducto.Text.Equals("") && !cmbAlmacen.Text.Equals(""))
                {
                    funActualizar();
                }
                else
                {
                    MessageBox.Show("Todos campos habilitados deben estar llenos", "Datos no Guardados", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            private void btnNuevo_Click(object sender, EventArgs e)
            {
                LimpiarTextos();
                BloqueoNuevo();
            }

        #endregion

        #region Funciones Manejo BD
        
            private void LlenadoCombos()
            {
                cmbProducto.Items.Clear();
                _comando = new OdbcCommand(String.Format("Select CONCAT(codproducto,'.',nombreproducto)AS Producto FROM producto where estado = 'ACTIVO' and condicion = 1"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    string producto = _reader.GetString(0);
                    cmbProducto.Items.Add(producto);
                }
                ConexionODBC.Conexion.CerrarConexion();

                cmbAlmacen.Items.Clear();
                _comando = new OdbcCommand(String.Format("Select CONCAT(codalmacen,'.',nombre)AS Almacen FROM almacen where estado = 'ACTIVO' and condicion = 1"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    string almacen = _reader.GetString(0);
                    cmbAlmacen.Items.Add(almacen);
                }
                ConexionODBC.Conexion.CerrarConexion();
            }

            public void funGuardarDatos()
            {
                try
                {
                    TextBox txtEstado = new TextBox(); txtEstado.Text = "ACTIVO"; txtEstado.Tag = "estado";
                    TextBox txtProducto = new TextBox(); txtProducto.Tag = "codproducto";
                    TextBox txtAlmacen = new TextBox(); txtAlmacen.Tag = "codalmacen";
                    string[] producto = cmbProducto.Text.Split(separador);
                    txtProducto.Text = producto[0];
                    string[] almacen = cmbAlmacen.Text.Split(separador);
                    txtAlmacen.Text = almacen[0];

                    _comando = new OdbcCommand(String.Format("Select codExistencias FROM existencias where codproducto = '{0}' AND codalmacen = '{0}'", txtProducto.Text, txtAlmacen.Text), ConexionODBC.Conexion.ObtenerConexion());
                    _reader = _comando.ExecuteReader();
                    if (_reader.Read())
                    {
                        MessageBox.Show("Este producto ya esta registrado en este almacen");
                    }
                    else
                    {
                        clasnegocio cn = new clasnegocio();
                        Boolean bPermiso = true;
                        TextBox[] aDatos = { txtEstado, txtCantidad, txtAlmacen, txtProducto };
                        string sTabla = "existencias";
                        cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                        funCommit();
                        MessageBox.Show("Datos guardados con exito");
                        LimpiarTextos();
                    }
                    ConexionODBC.Conexion.CerrarConexion();
                }
                catch (Exception)
                {
                    funRollback();
                    MessageBox.Show("Ocurrio un error al guardar los datos");
                }
            }

            public void funActualizar()
            {
                try
                {
                    TextBox txtEstado = new TextBox(); txtEstado.Text = "ACTIVO";
                    TextBox txtProducto = new TextBox(); txtProducto.Text = cmbProducto.Text;
                    TextBox txtAlmacen = new TextBox(); txtAlmacen.Text = cmbAlmacen.Text;

                    _comando = new OdbcCommand(String.Format("Select codExistencias FROM existencias where codproducto = '{0}' AND codalmacen = '{0}'", txtProducto.Text, txtAlmacen.Text), ConexionODBC.Conexion.ObtenerConexion());
                    _reader = _comando.ExecuteReader();
                    if (_reader.Read())
                    {
                        MessageBox.Show("Este producto ya esta registrado en este almacen");
                    }
                    else
                    {
                        clasnegocio cn = new clasnegocio();
                        Boolean bPermiso = true;
                        TextBox[] aDatos = { txtEstado, txtCantidad, txtAlmacen, txtProducto };
                        string sTabla = "existencias";
                        string codigoexistencia = "codexistencia";
                        cn.EditarObjetos(sTabla, bPermiso, aDatos, codigo, codigoexistencia);
                        funCommit();
                        LimpiarTextos();
                        MessageBox.Show("Datos editados con exito");
                    }
                    ConexionODBC.Conexion.CerrarConexion();
                }
                catch (Exception)
                {
                    funRollback();
                    MessageBox.Show("Ocurrio un error al editar los datos");
                }
            }

            private void funCommit()
            {
                _comando = new OdbcCommand(String.Format("COMMIT"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                ConexionODBC.Conexion.CerrarConexion();
            }

            private void funRollback()
            {
                _comando = new OdbcCommand(String.Format("ROLLBACK TO SAVEPOINT antesGuardar"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                ConexionODBC.Conexion.CerrarConexion();
            }

        #endregion
    }
}

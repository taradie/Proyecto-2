using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using ConexionODBC;
using Navegador;

namespace Sistema_compras
{
    public partial class frmIngresoEgreso : Form
    {
        public frmIngresoEgreso()
        {
            InitializeComponent();
            rellenarCombomovimientos();
            rellenarComboProductos();

            combogrid();
            enable();
        }

        private void enable()
        {
            dateTimePicker1.Enabled = false;
            txtFactura.Enabled = false;
            cmOC.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            richTextBox1.Enabled = false;
           
            btnAdd.Enabled = false;
            cmbProducto.Enabled = false;
        }


        public void rellenarCombomovimientos()
        {
            OdbcCommand busqueda = new OdbcCommand(
                                string.Format("SELECT tipo, descripcion FROM conceptos WhERE  estado='ACTIVO'"),
                              ConexionODBC.Conexion.ObtenerConexion()
                            );

            OdbcDataReader _reader = busqueda.ExecuteReader();

            while (_reader.Read())
            {
                cmOC.Items.Add(_reader["descripcion"].ToString());

            }
            cmOC.SelectedItem = 0;
        }



        private void cmOC_SelectedIndexChanged(object sender, EventArgs e)
        {

            grdIngreso.Rows.Clear();

            OdbcCommand busqueda = new OdbcCommand(
                              string.Format("SELECT tipo FROM conceptos WHERE  descripcion = '" + cmOC.Text + "'"),
                            ConexionODBC.Conexion.ObtenerConexion()
                          );

            OdbcDataReader _reader = busqueda.ExecuteReader();

            grdIngreso.Refresh();
            while (_reader.Read() == true)
            {
                txtmovimiento.Text = _reader["tipo"].ToString();
            }
            // combogrid();

        }


        private void combogrid()
        {
            
                OdbcCommand busqueda = new OdbcCommand(
                                    string.Format("SELECT CONCAT(codalmacen,'.',nombre) As Almacenn FROM almacen WhERE estado='ACTIVO'"),
                                  ConexionODBC.Conexion.ObtenerConexion()
                                );

                OdbcDataReader _reader = busqueda.ExecuteReader();

                while (_reader.Read())
                {

                    Almacen.Items.Add(_reader[0].ToString());

                }

            }
        

        private void cmOC_TextUpdate(object sender, EventArgs e)
        {
            grdIngreso.ClearSelection();
        }


        private void funguardaregreso()
        {
            //try
            //{

                
                string fecha;
                fecha = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;

                string factura;
                factura = txtFactura.Text;

                string descripcion;
                descripcion = richTextBox1.Text;

                string condicion;
                condicion = txtestado.Text;

                string tipomov;
                tipomov = txtmovimiento.Text;

                string concepto;
                concepto = cmOC.Text;

                //string[] corteproducto = Almacen.ToString().Split('.');
                //string codigo = corteproducto[0];
                //string nombre = corteproducto[1];

                for (int tamano = 0; tamano < grdIngreso.Rows.Count; tamano++)
                {

                    string insercion = grdIngreso.Rows[tamano].Cells[0].Value.ToString();
                    string insercion1 = grdIngreso.Rows[tamano].Cells[1].Value.ToString();
                    string insercion2 = grdIngreso.Rows[tamano].Cells[2].Value.ToString();
                    string insercion3 = grdIngreso.Rows[tamano].Cells[3].Value.ToString();
                    string insercion4 = grdIngreso.Rows[tamano].Cells[4].Value.ToString();
                    string insercion5 = grdIngreso.Rows[tamano].Cells[5].Value.ToString();
                    string insercion6 = grdIngreso.Rows[tamano].Cells[6].Value.ToString();

                    string[] corteproducto = insercion6.ToString().Split('.');
                    string codigo = corteproducto[0];
                    string nombre = corteproducto[1];

                    OdbcCommand orden = new OdbcCommand(String.Format("INSERT INTO movimientoinventario(OcompraAsoc,CantidadProd,codproducto,nombreProducto,codproveedor,nomProvee,almacen,fecha,facturaAsociada,TipoMov,descripcion,estado,concepto) values('" + insercion + "','" + insercion1 + "','" + insercion2 + "','" + insercion3 + "','" + insercion4 + "','" + insercion5 + "','" + insercion6 + "','" + fecha + "','" + factura + "','" + tipomov + "','" + descripcion + "','" + condicion + "','" + concepto + "')"),
                        ConexionODBC.Conexion.ObtenerConexion());

                    orden.ExecuteNonQuery();

                    OdbcCommand existencia = new OdbcCommand(String.Format("UPDATE producto SET existencia = existencia - '" + insercion1 + "' WHERE codproducto = '" + insercion2 + "'"),
                        ConexionODBC.Conexion.ObtenerConexion());

                    existencia.ExecuteNonQuery();

                    OdbcCommand oc = new OdbcCommand(String.Format("UPDATE encabezado_doccompra SET estado = 'INACTIVO' WHERE codencabezado = '" + insercion + "'"),
                            ConexionODBC.Conexion.ObtenerConexion());

                    oc.ExecuteNonQuery();

                    OdbcCommand existencias = new OdbcCommand(String.Format("UPDATE existencias SET fechaingreso = '" + fecha + "'  WHERE codproducto = '" + insercion2 + "' AND codalmacen = '" + codigo + "' "),
                                  ConexionODBC.Conexion.ObtenerConexion());

                    existencias.ExecuteNonQuery();

                    OdbcCommand cantidadexi = new OdbcCommand(String.Format("UPDATE existencias SET cantidad =cantidad - '" + insercion1 + "'  WHERE codproducto = '" + insercion2 + "' AND codalmacen = '" + codigo + "' "),
                                               ConexionODBC.Conexion.ObtenerConexion());

                    cantidadexi.ExecuteNonQuery();

                }
                MessageBox.Show("Datos insertados exitosamente.");
            //}
            //catch (Exception)
            //{
            //    MessageBox.Show("Error al insertar los datos.");
            //}
        }
        private void funguardarIngreso()
        {
            try
            {

                // string[] proveedor = cmbproveedor.Text.Split('.');
                // string codprovee = proveedor[0];

                string fecha;
                fecha = dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month + "-" + dateTimePicker1.Value.Day;

                string factura;
                factura = txtFactura.Text;

                string descripcion;
                descripcion = richTextBox1.Text;

                string condicion;
                condicion = txtestado.Text;

                string tipomov;
                tipomov = txtmovimiento.Text;

                string concepto;
                concepto = cmOC.Text;
                string[] corteproducto = Almacen.ToString().Split('.');
                string codigo = corteproducto[0];
                string nombre = corteproducto[1];


                for (int tamano = 0; tamano < grdIngreso.Rows.Count; tamano++)
                {

                    string insercion = grdIngreso.Rows[tamano].Cells[0].Value.ToString();
                    string insercion1 = grdIngreso.Rows[tamano].Cells[1].Value.ToString();
                    string insercion2 = grdIngreso.Rows[tamano].Cells[2].Value.ToString();
                    string insercion3 = grdIngreso.Rows[tamano].Cells[3].Value.ToString();
                    string insercion4 = grdIngreso.Rows[tamano].Cells[4].Value.ToString();
                    string insercion5 = grdIngreso.Rows[tamano].Cells[5].Value.ToString();
                    string insercion6 = grdIngreso.Rows[tamano].Cells[6].Value.ToString();



                    OdbcCommand orden = new OdbcCommand(String.Format("INSERT INTO movimientoinventario(OcompraAsoc,CantidadProd,codproducto,nombreProducto,codproveedor,nomProvee,almacen,fecha,facturaAsociada,TipoMov,descripcion,estado,concepto) values('" + insercion + "','" + insercion1 + "','" + insercion2 + "','" + insercion3 + "','" + insercion4 + "','" + insercion5 + "','" + insercion6 + "','" + fecha + "','" + factura + "','" + tipomov + "','" + descripcion + "','" + condicion + "','"+concepto+"')"),
                        ConexionODBC.Conexion.ObtenerConexion());

                    orden.ExecuteNonQuery();

                    OdbcCommand existencia = new OdbcCommand(String.Format("UPDATE producto SET existencia = existencia + '" + insercion1 + "' WHERE codproducto = '" + insercion2 + "'"),
                        ConexionODBC.Conexion.ObtenerConexion());

                    existencia.ExecuteNonQuery();

                    OdbcCommand oc = new OdbcCommand(String.Format("UPDATE encabezado_doccompra SET estado = 'INACTIVO' WHERE codencabezado = '" + insercion + "'"),
                            ConexionODBC.Conexion.ObtenerConexion());

                    oc.ExecuteNonQuery();

                    OdbcCommand existencias = new OdbcCommand(String.Format("UPDATE existencias SET fechaingreso = '" + fecha + "'  WHERE codproducto = '" + insercion2 + "' AND codalmacen = '" + codigo + "' "),
                                  ConexionODBC.Conexion.ObtenerConexion());

                    existencias.ExecuteNonQuery();

                    OdbcCommand cantidadexi = new OdbcCommand(String.Format("UPDATE existencias SET cantidad =cantidad + '" + insercion1 + "'  WHERE codproducto = '" + insercion2 + "' AND codalmacen = '" + codigo + "' "),
                                               ConexionODBC.Conexion.ObtenerConexion());

                    cantidadexi.ExecuteNonQuery();

                }
                MessageBox.Show("Datos insertados exitosamente.");
            }
            catch (Exception)
            {
                MessageBox.Show("Error al insertar los datos.");
            }


        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtmovimiento.Text == "INGRESO") { 
            
            funguardarIngreso();

            }
            else
            {
                funguardaregreso();
            }



            txtFactura.Text = " ";
            richTextBox1.Text = "";
            dateTimePicker1.Enabled = false;
            txtFactura.Enabled = false;
            cmOC.Enabled = false;
            btnGuardar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnCancelar.Enabled = false;
            richTextBox1.Enabled = false;
            grdIngreso.Rows.Clear();
            cmbProducto.Text = "";
            cmbProducto.Enabled = false;
            txtcantidad.Text = "";
            txtcantidad.Text = "";
        }


        private void rbActivo_CheckedChanged(object sender, EventArgs e)
        {

            txtestado.Text = "ACTIVO";

        }

        private void rbInactivo_CheckedChanged(object sender, EventArgs e)
        {
            txtestado.Text = "INACTIVO";
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = true;
            cmbProducto.Enabled = true;
            dateTimePicker1.Enabled = true;
            txtFactura.Enabled = true;
            cmOC.Enabled = true;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            richTextBox1.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtFactura.Text = " ";
            richTextBox1.Text = "";
            dateTimePicker1.Enabled = false;
            txtFactura.Enabled = false;
            cmOC.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            richTextBox1.Enabled = false;
            btnNuevo.Enabled = true;
        }

        private void modificarorden()
        {


        }
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

        }
        public void rellenarComboProductos()
        {

            OdbcCommand busqueda = new OdbcCommand(
                                string.Format("SELECT CONCAT (codproducto,'.',nombreproducto) AS Productos FROM producto WhERE  estado='ACTIVO'"),
                              ConexionODBC.Conexion.ObtenerConexion()
                            );

            OdbcDataReader _reader = busqueda.ExecuteReader();

            while (_reader.Read())
            {
                //  cmb.Items.Add(_reader["ncodordencompra"].ToString());
                cmbProducto.Items.Add(_reader[0].ToString());

            }
            cmbProducto.SelectedItem = 0;
        }

        private void frmIngresoEgreso_Load(object sender, EventArgs e)
        {

        }

        

       

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, helpProvider1.HelpNamespace);
        }

        private void txtconceptos_Click(object sender, EventArgs e)
        {
        
        }
        private void nombreproveedor()
        {

            OdbcCommand _comando = new OdbcCommand(string.Format("SELECT nombre FROM proveedor WHERE codproveedor='" + txtproveedor.Text + "' "),
                     ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read()) { 
                txtnombreprovee.Text = _reader[0].ToString();
            }
        }
     

        private void btnAdd_Click(object sender, EventArgs e)
        {
            nombreproveedor();
                     
            int documento = int.Parse(txtFactura.Text);
            int cantidad = int.Parse(txtcantidad.Text);
            int codigoprovee = int.Parse(txtproveedor.Text);
            string nombreprovee = txtnombreprovee.Text;
           
            if (grdIngreso.Rows.Count == 0) //if que muestra si el grid tiene registros
            {
                
                try
                {
                    string[] corteproducto = cmbProducto.Text.Split('.');
                    string codigo = corteproducto[0];
                    string nombre = corteproducto[1];
            
                   
                grdIngreso.Rows.Add(documento,cantidad,codigo, nombre, codigoprovee,nombreprovee);

                   
                    ConexionODBC.Conexion.CerrarConexion();
                }
                catch (Exception)
                {
                   MessageBox.Show("Error al agregar el producto");
                }

               
            }
            else
            {
                //MessageBox.Show(grdIngreso.Rows.Count.ToString() + " " + "el grid no esta vacio");
                Boolean repetido = false;
                string[] corteproducto = cmbProducto.Text.Split('.');
                string codigo = corteproducto[0];
                string nombre = corteproducto[1];
            
                for (int x = 0; x < grdIngreso.Rows.Count; x++)
                {
                   
                    string dato = grdIngreso.Rows[x].Cells[2].Value.ToString();
                    string dato2 = grdIngreso.Rows[x].Cells[3].Value.ToString();
                    if (dato == codigo && dato2 == nombre)
                    {
                        repetido = true;
                        System.Console.WriteLine("repetido");

                    }
                }
                if (repetido)
                {
                    MessageBox.Show("Ingrese un producto diferente, este ya fue agregado.");
                }
                else
                {
                   

                   
                    grdIngreso.Rows.Add(documento, cantidad, codigo, nombre, codigoprovee,nombreprovee);
                    }
                    
                }
            }

        

        private void cmbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] corteproducto = cmbProducto.Text.Split('.');
            string codigo = corteproducto[0];
            string nombre = corteproducto[1];


            OdbcCommand busqueda = new OdbcCommand(
                              string.Format("SELECT codproveedor FROM producto WHERE codproducto= '" + codigo + "'"),
                            ConexionODBC.Conexion.ObtenerConexion()
                          );

            OdbcDataReader _reader = busqueda.ExecuteReader();

            grdIngreso.Refresh();
            while (_reader.Read() == true)
            {
                txtproveedor.Text = _reader["codproveedor"].ToString();
            }
         //   combogrid();
}

        private void txtproveedor_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtnombreprovee_TextChanged(object sender, EventArgs e)
        {

           
        }
    }
}

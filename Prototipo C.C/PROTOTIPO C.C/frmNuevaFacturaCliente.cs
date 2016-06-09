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

namespace PROTOTIPO_C.C
{
    public partial class frmNuevaFacturaCliente : Form
    {
        public frmNuevaFacturaCliente()
        {
            InitializeComponent();

            funActualizarCombos();

            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            

            txtSerie.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            txtNombre.Enabled = false;
            txtNit.Enabled = false;
            txtTotal.Enabled = false;
            cmbCliente.Enabled = false;
            cmbCobrador.Enabled = false;
            cmbEstado.Enabled = false;
            cmbVendedor.Enabled = false;

        }

        private void funActualizarCombos()
        {
            clasnegocio cn = new clasnegocio();
            cn.funconsultarRegistrosCombo("cliente", "SELECT CONCAT(ncodcliente, '.', nombrecliente, ' ', apellidocliente) AS Cliente FROM cliente WHERE condicion = '1'", "Cliente", cmbCliente);
            cn.funconsultarRegistrosCombo("vendedor", "SELECT CONCAT(codVendedor, '.', nombrevendedor, ' ', apellidovendedor) AS vendedor FROM vendedor WHERE condicion = 1", "vendedor", cmbVendedor);
            cn.funconsultarRegistrosCombo("cobrador", "SELECT CONCAT(codCobrador, '.', nombre, ' ', apellido) AS cobrador FROM cobrador WHERE condicion = 'ACTIVO'", "cobrador", cmbCobrador);
            cn.funconsultarRegistrosCombo("empleado", "SELECT CONCAT(empleado.cod_empleado, '.', personas.nombres, ' ', personas.apellidos) AS empleado FROM personas, empleado WHERE empleado.codigo_persona = personas.codigo_persona AND empleado.condicion = 'ACTIVO'", "empleado", cmbEmpleado);
            cmbEstado.SelectedIndex = 0;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            

            txtSerie.Enabled = true;
            dateTimePicker1.Enabled = true;
            dateTimePicker2.Enabled = true;
            txtNombre.Enabled = true;
            txtNit.Enabled = true;
            txtTotal.Enabled = true;
            cmbCliente.Enabled = true;
            cmbCobrador.Enabled = true;
            cmbEstado.Enabled = true;
            cmbVendedor.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            

            txtSerie.Enabled = false;
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;
            txtNombre.Enabled = false;
            txtNit.Enabled = false;
            txtTotal.Enabled = false;
            cmbCliente.Enabled = false;
            cmbCobrador.Enabled = false;
            cmbEstado.Enabled = false;
            cmbVendedor.Enabled = false;
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarCombos();
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


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                clasnegocio cn = new clasnegocio();
                Boolean bPermiso = true;
                string sTabla = "factura";
                txtVendedor.Text = funCortador(cmbVendedor.Text);
                txtMoneda.Text = "Q";
                txtfecha.Text = dateTimePicker1.Text;
                txtVencimiento.Text = dateTimePicker2.Text;
                txtCondicion.Text = "1";
                txtEstado.Text = cmbEstado.Text;
                txtCliente.Text = funCortador(cmbCliente.Text);
                txtEmpleado.Text = funCortador(cmbEmpleado.Text);
                txtCobrador.Text = funCortador(cmbCobrador.Text);
                txtmovinventario.Text = "0";
                txtSaldo.Text = "0";
                TextBox[] aDatos = { txtSerie, txtVendedor, txtMoneda, txtNombre, txtNit, txtfecha, txtVencimiento, txtCondicion, txtTotal, txtEstado, txtCliente, txtEmpleado, txtCobrador, txtmovinventario, txtSaldo };
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Insertar", sTabla);
                this.Close();
            }
            catch
            {
                MessageBox.Show("Error al ingresar informacion");
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

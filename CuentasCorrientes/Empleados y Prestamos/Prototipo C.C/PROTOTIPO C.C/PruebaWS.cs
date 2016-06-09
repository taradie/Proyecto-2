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
    public partial class PruebaWS : Form
    {
        public PruebaWS()
        {
            InitializeComponent();
        }

        void funLlenarProveedores()
        {
            cmbDatos.Items.Clear();

            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT CONCAT(codproveedor, '. ',nombre) AS Proveedor FROM proveedor WHERE condicion='1'  "), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cmbDatos.Items.Add(_reader.GetString(0));
            }
            
            //clasnegocio cnegocio = new clasnegocio();
            //cnegocio.funconsultarRegistrosCombo("proveedor", "SELECT CONCAT(codproveedor, '. ',nombre) AS Proveedor FROM proveedor WHERE condicion='1' ", "Proveedor", cmbDatos);
        }

        void funLlenarClientes()
        {
            cmbDatos.Items.Clear();

            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT CONCAT(ncodcliente, '. ',nombrecliente) AS TPAGO FROM cliente WHERE condicion='1' "), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cmbDatos.Items.Add(_reader.GetString(0));
            }

            //clasnegocio cnegocio = new clasnegocio();
            //cnegocio.funconsultarRegistrosCombo("cliente", "SELECT CONCAT(ncodcliente, '. ',nombrecliente) AS TPAGO FROM cliente WHERE condicion='1' ", "TPAGO", cmbDatos);
        }

        void funLlenarEmpleados()
        {
            cmbDatos.Items.Clear();

            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT CONCAT(prestamo.cod_empleado, '.', personas.nombres) AS NOMBRE FROM prestamo, empleado, personas WHERE prestamo.cod_empleado=empleado.cod_empleado AND empleado.codigo_persona=personas.codigo_persona AND prestamo.condicion='ACTIVO'"), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                cmbDatos.Items.Add(_reader.GetString(0));
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

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string sCodigo = "";
            string sTipo = "";

            if (!cbTodos.Checked)
            {
                sCodigo = funCortador(cmbDatos.Text);
            }
            
            
            if (rbCliente.Checked)
            {
                sTipo = "C";
            }
            else if (rbProveedores.Checked)
            {
                sTipo = "P";
            }
            else if (rbEmpleados.Checked)
            {
                sTipo = "E";
            }

            net.azurewebsites.cuentascorrientes.WebServiceCC temp = new net.azurewebsites.cuentascorrientes.WebServiceCC();
            dataGridView1.DataSource = temp.Resultados(sTipo, sCodigo).Tables[0];

            if(sTipo=="P"){
                float fTotal=0;
                float fTotalPendiente=0;
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    fTotal += float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    fTotalPendiente += float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                }
                nTotal.Text = fTotal + "";
                nTotalPendiente.Text = fTotalPendiente + "";
                nDiferencia.Text = Convert.ToString(fTotal - fTotalPendiente);
            }
        }

        private void rbCliente_CheckedChanged(object sender, EventArgs e)
        {
            System.Console.WriteLine("Cliente");
            if(rbCliente.Checked && rbProveedores.Checked==false && rbEmpleados.Checked == false){
                funLlenarClientes();
            }
           
            
        }

        private void rbProveedores_CheckedChanged(object sender, EventArgs e)
        {
            System.Console.WriteLine("Proveedor");
            if (rbProveedores.Checked && rbCliente.Checked == false && rbEmpleados.Checked == false)
            {
                funLlenarProveedores();
            }
            
        }

        private void rbEmpleados_CheckedChanged(object sender, EventArgs e)
        {
            System.Console.WriteLine("Empleados");

            if (rbProveedores.Checked==false && rbCliente.Checked == false && rbEmpleados.Checked)
            {
                funLlenarEmpleados();
            }
        }

        private void rbTodos_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void cbTodos_CheckStateChanged(object sender, EventArgs e)
        {
            if(cbTodos.Checked){
                cmbDatos.Enabled = false;
            }else
            {
                cmbDatos.Enabled = true;
            }
            
        }
    }
}

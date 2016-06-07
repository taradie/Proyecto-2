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
using ConexionODBC;
using System.Data.Odbc;
namespace ZORBANK
{
    public partial class frmFormasPago : Form
    {
        public static OdbcCommand _comando;
        public static OdbcDataReader _reader;
        string estado = "";
        string sCod;
        
        public frmFormasPago()
        {
            InitializeComponent();
            funSedes1();
        }
        public frmFormasPago(string sCodigoP, string sDPI, string sNombreP)
        {
            InitializeComponent();
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
            textBox1.Text = sCodigoP;
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
        void funSedes1()
        {

          clasnegocio cnegocio = new clasnegocio();
          cnegocio.funconsultarRegistrosCombo("tipoformapago", "SELECT concat(TRIM(tipoformapago.codigo_tipo_forma), '.', TRIM(tipoformapago.tipo_forma)) as tipoformapago from tipoformapago", "tipoformapago", comboBox3);

            
            // cnegocio.funconsultarRegistrosCombo("codigo_tipo_forma","SELECT (CONVERT(char,codigo_tipo_forma) + ', ' + tipo_forma) as tipoformapago from tipoformapago", "tipoformapago", comboBox2);

            //clasnegocio cnegocio = new clasnegocio();
            //cnegocio.funconsultarRegistrosCombo("codigo_tipo_forma", "SELECT (codigo_tipo_forma)from tipoformapago","codigo_tipo_forma", comboBox1);
           // clasnegocio cnegocio1 = new clasnegocio();
            //cnegocio1.funconsultarRegistrosCombo("tipo_forma", "SELECT (tipo_forma)from tipoformapago", "tipo_forma", comboBox2);
          
            //_comando = new OdbcCommand(String.Format("Select (codigo_tipo_forma, )from tipoformapago",comboBox1), ConexionODBC.Conexion.ObtenerConexion());
           //comando.ExecuteNonQuery();
          // clasnegocio cnegocio = new clasnegocio();
          //cnegocio.funconsultarRegistrosCombo("tipo_forma", "SELECT(tipo_forma)  from tipoformapago ","tipo_forma", comboBox1);
            //clasnegocio cnegocio = new clasnegocio();
           // clasnegocio cnegocio1 = new clasnegocio();

           // string cnegocio1 = "Select codigo_tipo_forma, (CStr(codigo_tipo_forma) + ', ' + tipo_forma) as Forma" + "fron tipoformapago";
            //negocio.funconsultarRegistrosCombo("codigo_tipo_forma", "SELECT codigo_tipo_forma,(CStr(codigo_tipo_forma) + '.' + tipo_forma) As Sede from tipoformapago order by tipo_forma ", "Sede", comboBox1);
            //;
            //comboBox1.DisplayMember = "Sede";
       
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(textBox1, true);
        
            cnegocio.funactivarDesactivarCombobox(comboBox1, true);
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
           // _comando = new OdbcCommand(String.Format("insert into formas_pago(descripcion,codigo_tipo_forma) values ('" + textBox1.Text + "','" + comboBox1 + "' )"), ConexionODBC.Conexion.ObtenerConexion());
            //_comando.ExecuteNonQuery();
         clasnegocio cn = new clasnegocio();
            Boolean bPermiso = true;

            txtSede.Text = funCortador(comboBox1.Text);
            System.Console.WriteLine("*************Cortador: "+txtSede.Text);

            if (estado.Equals("editar"))
            {

                TextBox[] aDatosEdit = { textBox1, txtSede };
                string sTabla = "salon";
                string sCodigo = "codigo_tipo_forma";

                cn.EditarObjetos(sTabla, bPermiso, aDatosEdit, sCod, sCodigo);
                claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Editar", sTabla);


            }
            else if (estado.Equals("eliminar"))
            {
                string sTabla = "tipoformapago";
                string sCampoLlavePrimaria = "codigo_tipo_forma";
                string sCampoEstado = "condicion";
                //System.Console.WriteLine("----" + sCod);
                cn.funeliminarRegistro(sTabla, sCod, sCampoLlavePrimaria, sCampoEstado);
                claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Eliminar", sTabla);
            }
            else if (estado.Equals(""))
            {
                TextBox[] aDatos = {textBox1, txtSede};
                string sTabla = "tipoformapago";
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Insertar", sTabla);
            }

          
   
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnImprimir.Enabled = false;
            btnNuevo.Enabled = true;
            btnEditar.Enabled = true;
            btnEliminar.Enabled = true;
            btnRefrescar.Enabled = true;
            btnBuscar.Enabled = true;
            this.Close();
        }

        
      

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process proc = new System.Diagnostics.Process();
            proc.StartInfo.FileName = "C:\\IS.chm";
            proc.Start();
            proc.Close();
            
        }

        private void frmFormasPago_Load(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            string texto = comboBox1.Text + " " + comboBox2.Text;
        }
    }
}

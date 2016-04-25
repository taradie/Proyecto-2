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
namespace ZORBANK
{
    public partial class consultaParqueo : Form
    {
        String sCod;

        public consultaParqueo()
        {
            InitializeComponent();
            
        }

        public consultaParqueo(string sCodpersona)
        {
            InitializeComponent();
           
              textBox1.Text =  sCodpersona;
              sCod = textBox1.Text;
              funActualizarGrid1();
         
        }

        private void funActualizarGrid1()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("parqueo", "select asignacion_parqueo.codigo_parqueo as Codigo from asignacion_parqueo where codigopersona = '" + textBox1.Text + "'  ", "consulta", grdFacultad);
           
            claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "CONSULTA", " Parqueo");
        }

        private void consultaParqueo_Load(object sender, EventArgs e)
        {
          
        }

    
    }
}

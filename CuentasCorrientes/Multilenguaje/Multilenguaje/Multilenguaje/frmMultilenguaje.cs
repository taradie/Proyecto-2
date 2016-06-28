using Multilenguaje.Recursos_Localizables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multilenguaje
{
    public partial class frmMultilenguaje : Form
    {
        public frmMultilenguaje()
        {
            InitializeComponent();
        }

        void AplicarIdioma()
        {
            btnAceptar.Text = StringResources.ButtonLabel1;
            label1.Text = StringResources.String1;
            rbEspanol.Text = StringResources.rbEspanol;
            rbIngles.Text = StringResources.rbIngles;
            groupBox1.Text = StringResources.TituloGrupo;
            this.Text = StringResources.TituloGrupo;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            OdbcCommand _comando;

            if (rbIngles.Checked)
            {
                _comando = new OdbcCommand(String.Format("UPDATE idioma SET idioma='Ingles'"), ConexionODBC.Conexion.ObtenerConexion());
                _comando.ExecuteNonQuery();
                ConexionODBC.Conexion.CerrarConexion();
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ES-US");
                AplicarIdioma();
            }
            else
            {
                _comando = new OdbcCommand(String.Format("UPDATE idioma SET idioma='Espanol'"), ConexionODBC.Conexion.ObtenerConexion());
                _comando.ExecuteNonQuery();
                ConexionODBC.Conexion.CerrarConexion();
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
                AplicarIdioma();
            }
            this.Close();
        }

        private void frmMultilenguaje_Load(object sender, EventArgs e)
        {
            if (Idioma.ObtenerIdioma() == "Ingles")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ES-US");
                AplicarIdioma();
            }
            else if (Idioma.ObtenerIdioma() == "Espanol")
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("");
                AplicarIdioma();
            }
        }
    }
}

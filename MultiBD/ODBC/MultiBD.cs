/*
Programado por Josué Enrique Zeceña González
Sistema Banco: Proyecto 2 Ingeniería de Software 2016
Fecha de Entrega: 19-05-2016
*/
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
using Microsoft.Win32;

namespace MultiBD
{
    public partial class frmMultiBD : Form
    {
        public frmMultiBD()
        {
            InitializeComponent();            
        }

        public String ConexionODBC = "";
        protected String pass = "umg2016";

        OdbcConnection conexionBDODBC = new OdbcConnection();

        private static string[] GetOdbcDriverNames()
        {
            string[] odbcDriverNames = null;
            using (RegistryKey localMachineHive = Registry.LocalMachine)
            using (RegistryKey odbcDriversKey = localMachineHive.OpenSubKey(@"SOFTWARE\ODBC\ODBCINST.INI\ODBC Drivers"))
            {
                if (odbcDriversKey != null)
                {
                    odbcDriverNames = odbcDriversKey.GetValueNames();
                }
            }

            return odbcDriverNames;
        }

        private List<string> EnumDsn()
        {
            List<string> list = new List<string>();
            list.AddRange(EnumDsn(Registry.CurrentUser));
            list.AddRange(EnumDsn(Registry.LocalMachine));
            return list;
        }

        private IEnumerable<string> EnumDsn(RegistryKey rootKey)
        {
            RegistryKey regKey = rootKey.OpenSubKey(@"Software\ODBC\ODBC.INI\ODBC Data Sources");
            if (regKey != null)
            {
                foreach (string name in regKey.GetValueNames())
                {
                    string value = regKey.GetValue(name, "").ToString();
                    yield return name;
                }
            }
        }

        

        private string displayMembers(List<String> vegetales)
        {
            foreach (String s in vegetales)
            {                
                return s.ToString();                
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {            
            try
            {
                DialogResult boton = MessageBox.Show("Esto puede ocacionar problemas con los datos\n" +
                                     "¿Desea Continuar?", "MultiBD",
                     MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (boton == DialogResult.Cancel)
                {
                    this.Close();
                }
                else
                {

                    if (rbDSN.Checked == false && rbDriver.Checked == false)
                    {
                        rbDSN.Enabled = true;
                        rbDriver.Enabled = true;
                    }
                    else
                    {
                        if (rbDSN.Checked == true && rbDriver.Checked == false)
                        {                            
                            conexionBDODBC = new OdbcConnection("dsn=" + cmbODBC.Text +
                                ";UID=" + txtUsuario.Text + ";PWD=" + txtContrasena.Text +
                                 ";Database=" + txtBD.Text + ";");

                            string encryptedstring = StringCipher.Encrypt("dsn=" + cmbODBC.Text +
                                ";UID=" + txtUsuario.Text + ";PWD=" + txtContrasena.Text +
                                 ";Database=" + txtBD.Text + ";", pass);

                            //MessageBox.Show(encryptedstring);

                            ConexionODBC = encryptedstring;                        
                        }
                        if (rbDriver.Checked == true && rbDSN.Checked == false)
                        {

                            conexionBDODBC = new OdbcConnection("Driver={" + cmbDriver.Text +
                                 "};Server=" + txtServidor.Text +
                                 ";UID=" + txtUsuario.Text +
                                 ";PWD=" + txtContrasena.Text +
                                 ";Database=" + txtBD.Text + ";");

                            string encryptedstring = StringCipher.Encrypt("Driver={" + cmbDriver.Text +
                                 "};Server=" + txtServidor.Text +
                                 ";UID=" + txtUsuario.Text +
                                 ";PWD=" + txtContrasena.Text +
                                 ";Database=" + txtBD.Text + ";", pass);

                            ConexionODBC = encryptedstring;
                        }

                        conexionBDODBC.Open();

                        if (conexionBDODBC.State == ConnectionState.Open)
                        {
                            MessageBox.Show("Conectado a la base de datos", "MultiBD",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            try
                            {
                                RegistryKey key;
                                key = Registry.CurrentUser.CreateSubKey(@"SOFTWARE\Proyecto2");
                                key.SetValue("ConexionODBC", ConexionODBC);
                                key.Close();
                                //MessageBox.Show("Llave de Registro Windows creada");
                            }
                            catch (Exception error)
                            {
                                MessageBox.Show("Error al Registrar Key del Sistema: " +
                                System.Environment.NewLine + System.Environment.NewLine +
                                error.GetType().ToString() + System.Environment.NewLine +
                                error.Message, "MultiBD",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("No conectado a la base de datos", "MultiBD",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Error de base de datos: " +
                     System.Environment.NewLine + System.Environment.NewLine +
                     error.GetType().ToString() + System.Environment.NewLine +
                     error.Message, "MultiBD",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);                    
            }
            conexionBDODBC.Close();

        }
        
        private void rbDSN_CheckedChanged(object sender, EventArgs e)
        {
            cmbODBC.Enabled = true;
            cmbDriver.Enabled = false;
            txtServidor.Enabled = false;
            txtUsuario.Enabled = true;
            txtContrasena.Enabled = true;
            txtBD.Enabled = true;

            try
            {
                BindingSource dsn = new BindingSource();
                dsn.DataSource = EnumDsn();
                cmbODBC.DataSource = dsn;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al cargar ODBC DSN del Sistema: " +
                     System.Environment.NewLine + System.Environment.NewLine +
                     error.GetType().ToString() + System.Environment.NewLine +
                     error.Message, "MultiBD",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbDriver_CheckedChanged(object sender, EventArgs e)
        {
            cmbODBC.Enabled = false;
            cmbDriver.Enabled = true;            
            txtServidor.Enabled = true;
            txtUsuario.Enabled = true;
            txtContrasena.Enabled = true;
            txtBD.Enabled = true;

            try
            {
                BindingSource driver = new BindingSource();
                driver.DataSource = GetOdbcDriverNames();
                cmbDriver.DataSource = driver;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al cargar ODBC Drivers del Sistema: " +
                     System.Environment.NewLine + System.Environment.NewLine +
                     error.GetType().ToString() + System.Environment.NewLine +
                     error.Message, "MultiBD",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ConexionODBCActual = null;
            string keyname = "ConexionODBC";
            using (RegistryKey currentUserHive = Registry.CurrentUser)
            using (RegistryKey ConexionODBCKey = currentUserHive.OpenSubKey(@"SOFTWARE\Proyecto2"))
            {
                if (ConexionODBCKey != null)
                {
                    ConexionODBCActual = (string) ConexionODBCKey.GetValue(keyname,"DSN='proyecto2'");
                    ConexionODBCKey.Close();
                }
            }
            string decryptedstring = StringCipher.Decrypt(ConexionODBCActual, pass);

            conexionBDODBC = new OdbcConnection(decryptedstring);
            conexionBDODBC.Open();
            if (conexionBDODBC.State == ConnectionState.Open)
            {
                MessageBox.Show("¡Conexión Exitosa!", "MultiBD",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show("¡Conexión Falló!", "MultiBD",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        
        conexionBDODBC.Close();
               /* MessageBox.Show("ConexiónODBC : " + ConexionODBCActual, "MultiBD",
                     MessageBoxButtons.OK, MessageBoxIcon.Information);*/
        }

        private void button3_Click(object sender, EventArgs e)
        {            
            string appPath = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location);
            string ayuda = appPath + "\\MultiBD.chm";
            //MessageBox.Show(ayuda);
            Help.ShowHelp(this, ayuda);            
        }
    }
}

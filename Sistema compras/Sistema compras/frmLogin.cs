using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Seguridad;

namespace Sistema_compras
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (claseUsuario.Autentificar(txtUser.Text, txtPass.Text) == true)
            {
                claseUsuario.varibaleUsuario = txtUser.Text;
                claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Inicio Sesion", "Usuario");
                this.Hide();
                frmMenuPrincipal Menu = new frmMenuPrincipal();
                Menu.Show();
                Menu.toolStripLabel1.Text = "Usuario: " + txtUser.Text;
                Menu.toolStripLabel2.Text = DateTime.Now.ToString();
                //MessageBox.Show("Bienvenid@:  " + claseUsuario.user(txtUser.Text, txtPass.Text) + ":" + claseUsuario.varibaleUsuario);
            }
            else
            {
                MessageBox.Show("Usuario o Password Incorrecto, Si el problema persiste su Usuario esta Inactivo");
                txtUser.Clear();
                txtPass.Clear();
            }
        }
    }
}

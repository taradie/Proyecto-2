using Seguridad;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROTOTIPO_C.C
{
    public partial class frmLogins : Form
    {
        public frmLogins()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (claseUsuario.Autentificar(txtUser.Text, txtPass.Text) == true)
            {
                claseUsuario.varibaleUsuario = txtUser.Text;
                claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Inicio Sesion", "Usuario");
                this.Hide();
                frmMenuPrincipal Menu = new frmMenuPrincipal();
                Menu.Show();
                Menu.toolStripStatusLabel2.Text = "Usuario: " + txtUser.Text;
                Menu.toolStripStatusLabel.Text = DateTime.Now.ToString();
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

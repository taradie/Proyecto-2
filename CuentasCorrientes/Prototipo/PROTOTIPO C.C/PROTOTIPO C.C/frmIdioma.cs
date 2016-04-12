using PROTOTIPO_C.C.Recursos_Localizables;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROTOTIPO_C.C
{
    public partial class frmIdioma : Form
    {
        public frmIdioma()
        {
            InitializeComponent();
        }

        private void AplicarIdioma()
        {
            btnAceptar.Text = StringResources.ButtonLabel1;
            label1.Text = StringResources.String1;
            rbEspanol.Text = StringResources.rbEspanol;
            rbIngles.Text = StringResources.rbIngles;
            groupBox1.Text = StringResources.TituloGrupo;
            this.Text = StringResources.TituloGrupo;
        }
        private void frmIdioma_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if(rbIngles.Checked){
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ES-US");
                AplicarIdioma();
            }
            else
            {
                Thread.CurrentThread.CurrentUICulture = new CultureInfo("ES-CO");
                AplicarIdioma();
            }
        }

        private void rbEspanol_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

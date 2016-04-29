using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZORBANK
{
    //Programador y analista: Jose Alberto oxcal Ley
    public partial class frmConsultaCuentas : Form
    {
        public frmConsultaCuentas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmConsultaCuentas_Load(object sender, EventArgs e)
        {

        }

        private void bntNuevo_Click(object sender, EventArgs e)
        {
            string sMensaje = "Nueva cuenta";                   //llamado de formulario cuentas
            frmCuentas temp = new frmCuentas(sMensaje);
            temp.Show();


        }
    }
}

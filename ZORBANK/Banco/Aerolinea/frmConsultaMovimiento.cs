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
    //programador y analista Jose Alberto oxcal ley
    public partial class frmConsultaMovimiento : Form
    {
        public frmConsultaMovimiento()
        {
            InitializeComponent();
        }

        private void bntNuevo_Click(object sender, EventArgs e)
        {
            string sMensaje = "Nuevo Movimiento";       //llamado de formulario Movimientos
            frmMovimientos temp = new frmMovimientos(sMensaje);
            temp.Show();
        }
    }
}

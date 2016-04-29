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
    public partial class frmConsultaAgendaMovimiento : Form
    {
        //programador y analista Jose alberto oxcal ley
        public frmConsultaAgendaMovimiento()
        {
            InitializeComponent();
        }

        private void bntNuevo_Click(object sender, EventArgs e)
        {
            string sMensaje = "Agregar Movimiento Bancario";
            frmAgendaMovimiento temp = new frmAgendaMovimiento(sMensaje);
            temp.Show();
        }
    }
}

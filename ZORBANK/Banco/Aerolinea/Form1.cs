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

namespace ZORBANK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            funconsultarTablas();
        }

        private void funconsultarTablas()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("reporte", "SELECT cod_reporte as CodigoReporte, modulo_reporte as ModuloReporte,nom_reporte as NombreReporte, directorio as Directorio, usuario as Usuario, fecha as Fecha FROM reporte", "consulta", grdReporte);
       
        }

        public void funactivarDesactivarGrid(DataGridView tb, Boolean status) { tb.Enabled = status; }


        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funconsultarTablas();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdReporte);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdReporte);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdReporte);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdReporte);
        }

        private void grdReporte_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String Direccion = @"C:\Users\Josue\Desktop\Reportes\" + grdReporte.CurrentRow.Cells[2].Value.ToString() + ".rpt";
            FormReporte temp = new FormReporte(Direccion);
            temp.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //frmIngresoReporte FRM = new frmIngresoReporte();
            //FRM.Show();
        }
    }
}

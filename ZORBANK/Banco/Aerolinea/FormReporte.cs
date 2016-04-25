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
using CrystalDecisions.CrystalReports.Engine;

namespace ZORBANK
{
    public partial class FormReporte : Form
    {
        ReportDocument cry = new ReportDocument();
        public FormReporte(string sDireccion)
        {
            InitializeComponent();
            cry.Load(sDireccion);
            crystalReportViewer1.ReportSource = cry;
        }


        private void FormReporte_Load(object sender, EventArgs e)
        {

        }
    }
}

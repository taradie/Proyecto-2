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
    public partial class FormClienteWeb : Form
    {
        public FormClienteWeb()
        {
            InitializeComponent();
        }

        private void FormClienteWeb_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            net.azurewebsites.bancos.WebServicesBanco ws = new net.azurewebsites.bancos.WebServicesBanco();

            dataGridView1.DataSource = ws.sEnviarDisponibilidadBancaria().Tables[0];
        }
    }
}

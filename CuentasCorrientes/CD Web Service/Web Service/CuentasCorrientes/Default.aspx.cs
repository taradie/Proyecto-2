using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CuentasCorrientes
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            WebServiceCC Cuentas = new WebServiceCC();
            GridView1.DataSource = Cuentas.Resultados("","");
            GridView1.DataBind();
            //Label1.Text = Cuentas.cadena();
            
        }
    }
}
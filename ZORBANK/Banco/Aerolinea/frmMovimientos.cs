using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;using Seguridad;using SeguridadGrafico;

namespace ZORBANK
{
    public partial class frmMovimientos : Form
    {
        public frmMovimientos(string sMensaje)
        {
            InitializeComponent();
            this.Text = sMensaje;
        }

        private void frmMovimientos_Load(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();
            cn.funconsultarRegistrosCombo("codigo_cuenta_interna","select codigo_cuenta_interna,no_cuenta from cuentasinternas where condicion = '1' and estado='ACTIVO'","no_cuenta",cmbCuenta);
            cn.funconsultarRegistrosCombo("codigo_concepto", "Select concat(TRIM(codigo_concepto), '.', TRIM(concepto)) as conceptos from conceptosbancarios where condicion = '1' and estado='ACTIVO'", "conceptos", cmbConceptos);
            cn.funconsultarRegistrosCombo("codigo_forma", "select concat(TRIM(codigo_forma), '.', TRIM(descripcion)) as TipoPago from formas_pago where condicion = '1' and estado='ACTIVO'", "TipoPago",cmbFormaPago);

        }
    }
}

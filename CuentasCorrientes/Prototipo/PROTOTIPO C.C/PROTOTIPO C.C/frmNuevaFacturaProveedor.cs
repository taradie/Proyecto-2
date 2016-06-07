using Navegador;
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
    public partial class frmNuevaFacturaProveedor : Form
    {
        public frmNuevaFacturaProveedor()
        {
            InitializeComponent();
            clasnegocio cn = new clasnegocio();
            cn.funconsultarRegistrosCombo("proveedor", "SELECT concat(proveedor.codproveedor, '.' ,proveedor.nombre) as Proveedor FROM proveedor WHERE condicion='1' ", "proveedor", cmbProveedor);
        }
    }
}

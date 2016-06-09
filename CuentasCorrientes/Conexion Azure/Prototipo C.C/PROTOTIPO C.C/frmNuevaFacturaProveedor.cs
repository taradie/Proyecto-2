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
using Filtrado;
using Navegador;

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

        string funCortador(string sDato)
        {
            string sCadena = "";
            try
            {
                for (int i = 0; i < sDato.Length; i++)
                {
                    if (sDato.Substring(i, 1) != ".")
                    {
                        sCadena = sCadena + sDato.Substring(i, 1);
                    }
                    else
                    {
                        break;
                    }
                }

            }
            catch
            {
                MessageBox.Show("Error al obtener Codigo", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            return sCadena;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            string sCampoCodigo = "proveedor.codproveedor";
            string sCampoDescripcion = "proveedor.nombre";
            string query = "SELECT proveedor.codproveedor, proveedor.nombre as Proveedor FROM proveedor WHERE condicion='1'";
            frmFiltrado filtro = new frmFiltrado(query, sCampoCodigo, sCampoDescripcion);
            filtro.ShowDialog(this);
            int index = cmbProveedor.FindString(filtro.funResultado());
            cmbProveedor.SelectedIndex = index;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            dtpFecha.Enabled = true;
            txtTotal.Clear();
            cmbEstado.SelectedIndex = 0;
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funactivarDesactivarTextbox(txtTotal, true);
            cnegocio.funactivarDesactivarCombobox(cmbEstado, true);
            cnegocio.funactivarDesactivarCombobox(cmbProveedor, true);

            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNuevo.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnRefrescar.Enabled = false;
            btnBuscar.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string sTabla = "facturaproveedor";
            bool bPermiso = true;
            txtFecha.Text = dtpFecha.Text;
            txtEstado.Text = cmbEstado.Text;
            txtProveedor.Text = funCortador(cmbProveedor.Text);
            clasnegocio cn = new clasnegocio();
            TextBox[] aDatos = {txtProveedor, txtTotal, txtFecha, txtSituacion,txtEstadoMov, txtSaldo, txtEstado, txtCondicion };
            cn.AsignarObjetos(sTabla, bPermiso, aDatos);
            //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Insertar", sTabla);
            this.Close();
        }
    }
}

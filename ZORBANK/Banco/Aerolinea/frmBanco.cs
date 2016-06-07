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
    public partial class frmBanco : Form
    {
        string estado,sCodigo,temporal,tBanco,tAbreviatura,tTelefono,tEstado;
        public frmBanco(string sMensaje,string sEstadoI,string sCodigoI ,string sBanco,string sAbreviatura,string sTelefono,string sEstado)
        {
            clasnegocio cn = new clasnegocio();
            estado = sEstadoI;
            temporal = sEstadoI;
            sCodigo = sCodigoI;
            tBanco = sBanco;
            tAbreviatura = sAbreviatura;
            tTelefono = sTelefono;
            tEstado = sEstado;              //captura de informacion de proviene del formulario principal
            this.Text = sMensaje;
            InitializeComponent();
            cn.funactivarDesactivarBoton(btnIrPrimero, false);  //desactivacion de botones de navegacion en formulario banco
            cn.funactivarDesactivarBoton(btnIrUltimo, false);
            cn.funactivarDesactivarBoton(btnSiguiente, false);
            cn.funactivarDesactivarBoton(btnAnterior, false);
            cn.funactivarDesactivarBoton(btnImprimir, false);
            cn.funactivarDesactivarBoton(btnRefrescar, false);
            if (estado.Equals("")) {            //botones que se desactivan al crear un nuevo banco
                cn.funactivarDesactivarBoton(btnNuevo, false);
                cn.funactivarDesactivarBoton(btnEditar, false);
                cn.funactivarDesactivarBoton(btnEliminar, false);
                cmbEstado.SelectedIndex = 0;
            }
            else {          //botones de que activan al editar o elimiar registros
                cn.funactivarDesactivarBoton(btnEditar, true);
                cn.funactivarDesactivarBoton(btnEliminar, true);
                cn.funactivarDesactivarTextbox(txtNombreBanco, false);
                cn.funactivarDesactivarTextbox(txtAbreviatura, false);
                cn.funactivarDesactivarTextbox(txtTelefono, false);
                cn.funactivarDesactivarCombobox(cmbEstado, false);
                txtNombreBanco.Text = sBanco;
            txtAbreviatura.Text = sAbreviatura;
            txtTelefono.Text = sTelefono;
            cmbEstado.Text = sEstado;
            }
            
        }

        private void frmBanco_Load(object sender, EventArgs e)
        {

        }

        #region navegador
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";            //boton eliminar cambia el estado del formulario para eliminar un registro
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarBoton(btnNuevo, false);
            cn.funactivarDesactivarBoton(btnEditar, false);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            estado = "";                //botone de nuevo registro no posee estado para la creacion de un nuevo registro
            clasnegocio cn = new clasnegocio();
            cn.funactivarDesactivarBoton(btnNuevo, false);
            cn.funactivarDesactivarBoton(btnEditar, false);
            cn.funactivarDesactivarBoton(btnEliminar, false);
            cn.funactivarDesactivarBoton(btnGuardar, true);
            cn.funactivarDesactivarTextbox(txtNombreBanco, true);
            cn.funactivarDesactivarTextbox(txtAbreviatura, true);
            cn.funactivarDesactivarTextbox(txtTelefono, true);
            cn.funactivarDesactivarCombobox(cmbEstado, true);
            txtNombreBanco.Text = "";
            txtAbreviatura.Text = "";
            txtTelefono.Text = "";
            cmbEstado.SelectedIndex = 0;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();             //boton de cancelar y regresa el estado con el que se abre por primera vez el formulario
            cn.funactivarDesactivarBoton(btnEditar, true);
            cn.funactivarDesactivarTextbox(txtNombreBanco, false);
            cn.funactivarDesactivarTextbox(txtAbreviatura, false);
            cn.funactivarDesactivarTextbox(txtTelefono, false);
            cn.funactivarDesactivarCombobox(cmbEstado, false);
            cn.funactivarDesactivarBoton(btnGuardar, false);
            cn.funactivarDesactivarBoton(btnNuevo, true);
            cn.funactivarDesactivarBoton(btnEliminar, false);
            estado = temporal;
            if (temporal.Equals("editar"))          //Regresa lo datos con el que el formulario se abrio
            {
                txtNombreBanco.Text = tBanco;
                txtAbreviatura.Text = tAbreviatura;
                txtTelefono.Text = tTelefono;
                cmbEstado.Text = tEstado;
            } if (estado.Equals("eliminar") | estado.Equals("editar"))
            {
                cn.funactivarDesactivarBoton(btnEliminar, true);   //desactiva el boton de eliminar el regresar al estado principal del formulario
            }
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio();                 //activa la edicion de informacion 
            cn.funactivarDesactivarBoton(btnEditar, false);
            cn.funactivarDesactivarTextbox(txtNombreBanco, true);
            cn.funactivarDesactivarTextbox(txtAbreviatura, true);
            cn.funactivarDesactivarTextbox(txtTelefono, true);
            cn.funactivarDesactivarCombobox(cmbEstado, true);
            cn.funactivarDesactivarBoton(btnGuardar, true);
            cn.funactivarDesactivarBoton(btnEliminar, true);
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            clasnegocio cn = new clasnegocio(); //boton para el almacenamiento de la informacion
            Boolean bPermiso = true;
            string sTabla = "bancos";           //tabla en que se almacenan los datos
            string sTablaId = "codigo_banco";      //id para la edicion del registro
            txtEstado.Text = cmbEstado.Text;
            if (estado.Equals("editar"))        //etastado de edicion 
            {
                TextBox[] aDatosEditar = { txtNombreBanco, txtAbreviatura, txtTelefono, txtEstado, txtcondicion };  //campos que se editaran
                cn.EditarObjetos(sTabla, bPermiso, aDatosEditar, sCodigo, sTablaId);
                claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Editar", sTabla); //bitacora de edidcion
            }
            else if (estado.Equals("eliminar"))                     //estado de eliminacion 
            {
                string sCampoEstado = "condicion";              //campo afectado para la eliminacion
                cn.funeliminarRegistro(sTabla, sCodigo, sTablaId, sCampoEstado);
                claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Eliminar", sTabla);  //bitacora de eliminacion

            }
            else if (estado.Equals(""))             //sin estado para un nuevo registro
            {
                TextBox[] aDatos = { txtNombreBanco, txtAbreviatura, txtTelefono, txtEstado, txtcondicion };            //datos para el almacenamietno
                cn.AsignarObjetos(sTabla, bPermiso, aDatos);
                //claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Insertar", sTabla);      //bitacora de alamcenamiento de nuevo registro

            }
            this.Close();           //Cierre de formulario
        }

        #endregion
    }
}

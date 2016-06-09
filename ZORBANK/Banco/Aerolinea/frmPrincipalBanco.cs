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
    public partial class frmPrincipalBanco : Form
    {
        //programador y analista: Jose Alberto oxcal Ley
        public frmPrincipalBanco()//inicializacion de componentes y atualizacion de registros
        {
            InitializeComponent();
            funActualizarGrid();

        }
        

        #region    navegador           
        private void bntNuevo_Click(object sender, EventArgs e)
        {
            string sMensaje = "Nueva Banco";                   //llamado de formulario para nuevo banco
            string estadoI = "";
            frmBanco temp = new frmBanco(sMensaje, estadoI,"","","","","");
            temp.FormClosed += new FormClosedEventHandler(temp_FormClosed);
            temp.Show();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e) //navegacion de registros se posiciona en el primero
        {
            clasnegocio negocio = new clasnegocio();
            negocio.funPrimero(grdBancos);
        }

        private void bntAnterior_Click(object sender, EventArgs e)  //navegacion de registro, retrocede un registro
        {
            clasnegocio negocio = new clasnegocio();
            negocio.funAnterior(grdBancos);
        }

        private void btnSiguiente_Click(object sender, EventArgs e) //navegacion de registro, se posiciones en el siguiente reguistro
        {
            clasnegocio negocio = new clasnegocio();
            negocio.funSiguiente(grdBancos);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)      //navegacion se posiciona en el ultimo registro
        {
            clasnegocio negocio = new clasnegocio();
            negocio.funUltimo(grdBancos);
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();            //funcion de actualizado de informacion 
        }

        #endregion    

        #region grdBancos
        private void temp_FormClosed(object sender, FormClosedEventArgs e) {
            funActualizarGrid();  //funcion de actualizacion automatica al cerrar formulario hijo de bancos 
        }
        private void grdBancos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string sMensaje="Editar Banco";     //funcion de accion, se ejecuta al seleccionar con el mouse un registro y darle doble click
            string sEstadoI = "editar";
            string sCodigo = grdBancos.Rows[grdBancos.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string sBanco = grdBancos.Rows[grdBancos.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sAbreviatura = grdBancos.Rows[grdBancos.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string sTelefono = grdBancos.Rows[grdBancos.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string sEstado = grdBancos.Rows[grdBancos.CurrentCell.RowIndex].Cells[4].Value.ToString();
            frmBanco temp = new frmBanco(sMensaje,sEstadoI,sCodigo,sBanco,sAbreviatura,sTelefono,sEstado);      //llamado de formulario bancos
            temp.FormClosed += new FormClosedEventHandler(temp_FormClosed);                                     //al cerrar el formulario banco se actualiza automaticamente los registros
            temp.Show();
        }
        public void funActualizarGrid()
        {
            clasnegocio negocio = new clasnegocio();    //informacion que visualizara el formulario principal de bancos
            negocio.funconsultarRegistros("bancos", "SELECT codigo_banco AS Codigo, nombre AS Banco,abreviatura as Abreviatura,telefono AS No_Telefono,estado as Estado FROM bancos WHERE condicion= '1' ", "consulta", grdBancos);
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("bancos");//funcion de busqueda personalizada de grid
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            clasnegocio cn = new clasnegocio();
            cn.funconsultarRegistros("bancos", query, "consulta", grdBancos);
        }
        
    
    }
}

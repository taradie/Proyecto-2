﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Navegador;
using System.Data.Odbc;

namespace ZORBANK
{
    public partial class frmPrincipalUsuarios : Form
    {
        public frmPrincipalUsuarios()
        {
            InitializeComponent();
            funActualizarGrid();
        }
        private void funActualizarGrid()
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("usuario", "SELECT usuario.codigo_usuario as Codigo, usuario.nombre_usuario as Username, usuario.password_usuario as Password, rol.tipo as Rol, usuario.estado as Estado, persona.nombre as Nombre, persona.apellido as Apellido from usuario, persona, rol where rol.codigo_rol = usuario.codigo_rol and usuario.codigopersona = persona.codigopersona", "consulta", grdUsuarios);
            
        }
        
        

        private void btnNuevo_Click(object sender, EventArgs e)
        {


             frmcontrolUsuarios temp2 = new frmcontrolUsuarios();
             temp2.WindowState = FormWindowState.Normal;
            
            
            temp2.Show();
        }
        
        

        private void frmPrincipalUsuarios_Load(object sender, EventArgs e)
        {
            claseUsuario.timeCursor();
        }

        private void grdFacultad_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funconsultarRegistros("usuario", "SELECT codigo_usuario as Codigo,nombre_usuario as Nombre, estado as Estado,codigo_rol as Rol   from usuario WHERE condicion = '1' AND nombre_usuario LIKE '" + txtBuscar.Text + "%'", "consulta", grdUsuarios);
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            funActualizarGrid();
        }

        private void btnIrPrimero_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funPrimero(grdUsuarios);
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funAnterior(grdUsuarios);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funSiguiente(grdUsuarios);
        }

        private void btnIrUltimo_Click(object sender, EventArgs e)
        {
            clasnegocio cnegocio = new clasnegocio();
            cnegocio.funUltimo(grdUsuarios);
        }

        private void grdUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void grdUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string cod = grdUsuarios.Rows[grdUsuarios.CurrentCell.RowIndex].Cells[0].Value.ToString();
            string usuario = grdUsuarios.Rows[grdUsuarios.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string password = grdUsuarios.Rows[grdUsuarios.CurrentCell.RowIndex].Cells[2].Value.ToString();
            string rol = grdUsuarios.Rows[grdUsuarios.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string estado = grdUsuarios.Rows[grdUsuarios.CurrentCell.RowIndex].Cells[3].Value.ToString();
            string nombre = grdUsuarios.Rows[grdUsuarios.CurrentCell.RowIndex].Cells[5].Value.ToString();
            //string apellido = grdUsuarios.Rows[grdUsuarios.CurrentCell.RowIndex].Cells[5].Value.ToString();
           // MessageBox.Show("esto lleva" + usuario + password + rol + estado + nombre);
           
            frmcontrolUsuarios temp = new frmcontrolUsuarios(cod, usuario, password, rol, estado, nombre);
            temp.Show();
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FiltradoGrids.FiltradoGrids abc = new FiltradoGrids.FiltradoGrids("usuario");
            abc.ShowDialog(this);
            string query = abc.ObtenerQuery();
            //MessageBox.Show(query)

            ReporteUsuarios objRpt = new ReporteUsuarios();
            OdbcDataAdapter adp = new OdbcDataAdapter(query, ConexionODBC.Conexion.ObtenerConexion());
            DataSet1 dt = new DataSet1();
            adp.Fill(dt, "usuario");
            objRpt.SetDataSource(dt);

            frmVistaReporte vista = new frmVistaReporte();
            vista.crystalReportViewer1.ReportSource = objRpt;
            vista.Show();
        }
    }
}
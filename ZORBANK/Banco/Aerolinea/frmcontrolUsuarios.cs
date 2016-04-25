using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConexionODBC;
using System.Data.Odbc;
using Navegador;
using ZORBANK.Properties;


namespace ZORBANK
{
    public partial class frmcontrolUsuarios : Form
    {
        int varInsertar, varConsultar, varEliminar, check = 0;
        string codigoPrivilegio, varCondicion;
        string estado = "";
        
        public frmcontrolUsuarios()
        {
            InitializeComponent();
            llenarGrid();
            this.cmbModulos.SelectedItem = "Todos";
        }

        public frmcontrolUsuarios(string cod,string usuario, string password, string rol, string estado, string nombre )
        {
            InitializeComponent();
            txtIn.Text = cod;
            txtUser.Text = usuario;
            txtPassword.Text = password;
            cmbRolPre.Text= rol;
            cbMuestra.Text  = nombre;
            this.cmbModulos.SelectedItem = "Todos";
            llenarGrid();
        }

        public void llenarGrid()
        {
            GridPrivilegios.Rows.Add("frmPersona", "Mant. Alumnos", false, false, false, false);
            GridPrivilegios.Rows.Add("frmEmpleado", "Mant. Empleados", false, false, false, false);
            GridPrivilegios.Rows.Add("frmFamilia", "Mant. Familia de Alumnos", false, false, false, false);
            GridPrivilegios.Rows.Add("frmPuestos", "Mant. Puestos", false, false, false, false);
            GridPrivilegios.Rows.Add("frmSalones", "Mant. Salones", false, false, false, false);
            GridPrivilegios.Rows.Add("frmCursos", "Mant. Cursos", false, false, false, false);
            GridPrivilegios.Rows.Add("frmParqueos", "Mant. Parqueos", false, false, false, false);
            GridPrivilegios.Rows.Add("frmLaboratorios", "Mant. Laboratorios", false, false, false, false);
            GridPrivilegios.Rows.Add("frmPensum", "Mant. Pensum", false, false, false, false);
            GridPrivilegios.Rows.Add("frmSedes", "Mant. sedes", false, false, false, false);
            GridPrivilegios.Rows.Add("frmTipoPago", "Tipos Pago para Almns.", false, false, false, false);
            GridPrivilegios.Rows.Add("frmTipoServicio", "Mant. Razones de Cobros", false, false, false, false);
            GridPrivilegios.Rows.Add("frmCarrera", "Mant. Carreras", false, false, false, false);
            GridPrivilegios.Rows.Add("frmJornada", "Mant. Jornadas", false, false, false, false);
            GridPrivilegios.Rows.Add("frmHorario", "Mant. Horarios", false, false, false, false);
            GridPrivilegios.Rows.Add("frmSeccion", "Mant. Secciones",  false, false, false, false);
            GridPrivilegios.Rows.Add("frmFacultad", "Mant. Facultades", false, false, false, false);
            GridPrivilegios.Rows.Add("frmAsigOrd", "Asignacion de Cursos", false, false, false, false);
            GridPrivilegios.Rows.Add("frmReasignacion", "Reasignacinones", false, false, false, false);
            GridPrivilegios.Rows.Add("frmAsigParq", "Asignacion parqueos", false, false, false, false);
            GridPrivilegios.Rows.Add("frmReinscripcion", "Reinscripcon Almn.", false, false, false, false);
            GridPrivilegios.Rows.Add("frmCreacionPensum", "Creacion de pensa", false, false, false, false);
            GridPrivilegios.Rows.Add("frmCreacionPaquete", "Creacion paquete cursos", false, false, false, false);
            GridPrivilegios.Rows.Add("frmNotas", "Ingreso de notas", false, false, false, false);
            GridPrivilegios.Rows.Add("frmZona", "Distribucion de zona", false, false, false, false);
            GridPrivilegios.Rows.Add("frmCobroParqueo", "Cobros de parqueos", false, false, false, false);
            GridPrivilegios.Rows.Add("frmMensualidad", "Cobros de Mensualidad", false, false, false, false);
            GridPrivilegios.Rows.Add("frmCobroInscrip", "Cobros de Inscripcion", false, false, false, false);
            GridPrivilegios.Rows.Add("frmCobroReasig", "Cobros Reasignacion", false, false, false, false);
            GridPrivilegios.Rows.Add("frmCobroDoc", "Cobros de Doc. Varios", false, false, false, false);
            GridPrivilegios.Rows.Add("frmPagoEmpleado", "Pago Salarios", false, false, false, false);
            GridPrivilegios.Rows.Add("frmUsuario", "Creacion usuarios y roles", false, false, false, false);
            GridPrivilegios.Rows.Add("frmBitacora", "Bitacora de Base de Datos", false, false, false, false);
            GridPrivilegios.Rows.Add("frmReporteCatalogos", "Administrador de Reportes", false, false, false, false);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        private void labelUser_Click(object sender, EventArgs e)
        {

        }
        
        private void frmControlUsuarios_Load(object sender, EventArgs e)
        {
            

            txtUser.Enabled= false;
            txtPassword.Enabled= false;
            txtRectificaPassword.Enabled= false;
            cbMuestra.Enabled = false;
            GridPrivilegios.Enabled = false;

            claseUsuario.timeCursor();
            txtPassword.UseSystemPasswordChar = true;
            cmbRolPre.Enabled = false;
            txtRol.Enabled = false;
            txtDesc.Enabled = false;
            funRol();
            GridPrivilegios.Enabled = false;
         

        }
        
        private void funRol()
        {
            OdbcCommand _comando = new OdbcCommand(String.Format(
            "SELECT  CONCAT(codigo_rol,' .', tipo),codigo_rol FROM ROL as campos"), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            cmbRolPre.Items.Clear();
            while (_reader.Read())
            {
                cmbRolPre.Items.Add(_reader[0].ToString());
                cmbRolPre.ValueMember = "campos";
                txtGuarda2.Text = _reader["codigo_rol"].ToString();
            }
            ConexionODBC.Conexion.ObtenerConexion().Close();
            _reader.Close();
        }
          
        private void cbMuestra_SelectedIndexChanged(object sender, EventArgs e)
        {
              if (txtPassword.Text != txtRectificaPassword.Text)
                {
                  MessageBox.Show("Rectifique que la contraseña sea igual", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
        }

        public void funAgregaUsuario()
        {
            string sInsertarUsuario = "INSERT INTO USUARIO  (nombre_usuario, password_usuario,estado, codigo_rol, codigopersona, condicion )values('" + txtUser.Text + "','" + txtPassword.Text + "','" + "ACTIVO" + "','" + txtGuarda2.Text + "','" + txtGuarda.Text + "','" + "1" + "')";
            OdbcCommand cmd2 = new OdbcCommand(sInsertarUsuario, ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader MyReader = cmd2.ExecuteReader();
            ConexionODBC.Conexion.ObtenerConexion().Close();

            //INGRESO BITACORA 
            claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Ingreso Usuario", "USUARIO");
            //FIN iNGRESO bITACORA*/

    }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool btnEditar_Click = true;
            bool btnEliminar_Click = true;
            bool btnGuardar_Click = true;

            if (estado.Equals("editar"))
            {
                MessageBox.Show("entrando a editar");
                funguardarModificacion();
               
            }
             
            else if (estado.Equals("eliminar"))
            {
                MessageBox.Show("entrando a eliminar");
                funeliminarUsuario();


                } else if (estado.Equals(""))
                    {
                        OdbcConnection con = ConexionODBC.Conexion.ObtenerConexion();
                        claseUsuario.timeCursor();
                        if (rdPre.Checked == true)
                        {
                            funAgregaUsuario();
                        }
                        else if (rdNuevo.Checked == true)
                        {
                            string sInsertarUsuario = "INSERT INTO ROL  (tipo,descripcion,estado, condicion )values('" + txtRol.Text + "','" + txtDesc.Text + "','" + "ACTIVO" + "','" + "1" + "')";
                            OdbcCommand cmd2 = new OdbcCommand(sInsertarUsuario, con);
                            OdbcDataReader MyReader = cmd2.ExecuteReader();
                            funAgregaUsuario();

                            OdbcCommand _comando = new OdbcCommand(String.Format("select max(codigo_rol) from rol"), con);
                            OdbcDataReader _readerN = _comando.ExecuteReader();
                            if(_readerN.Read())
                            {
                                txtXX.Text = _readerN.GetString(0);
                            }
                            _readerN.Close();
                            string cod = txtXX.Text;
                            string parametro;
                            foreach (DataGridViewRow row in GridPrivilegios.Rows)
                            {
                                parametro = Convert.ToString(row.Cells[0].Value);
                                if (Convert.ToBoolean(row.Cells[2].Value) == true)
                                {
                                    string query = "INSERT INTO PRIVILEGIOS (formulario,permiso,estado,codigo_rol,condicion) VALUES ('" + parametro + "','si','ACTIVO','" + cod + "','1')";
                                    OdbcCommand cmdForm = new OdbcCommand(query, con);
                                    cmdForm.ExecuteNonQuery();

                                    string query2 = "select max(codigo_privilegios) from privilegios";
                                    OdbcCommand cmdForm2 = new OdbcCommand(query2, con);
                                    OdbcDataReader _readerN2 = cmdForm2.ExecuteReader();
                                    if (_readerN2.Read())
                                    {
                                        codigoPrivilegio = _readerN2.GetString(0);
                                    }

                                    if (Convert.ToBoolean(row.Cells[3].Value) == true)
                                    {
                                        varInsertar = 1;
                                    }
                                    else
                                    {
                                        varInsertar = 0;
                                    }

                                    if (Convert.ToBoolean(row.Cells[4].Value) == true)
                                    {
                                        varConsultar = 1;
                                    }
                                    else
                                    {
                                        varConsultar = 0;
                                    }

                                    if (Convert.ToBoolean(row.Cells[5].Value) == true)
                                    {
                                        varEliminar = 1;
                                    }
                                    else
                                    {
                                        varEliminar = 0;
                                    }

                                    OdbcCommand cmdInsertar = new OdbcCommand("insert into permiso (nombre, validacion, estado, codigo_privilegios, condicion) values('INSERTAR', '" + varInsertar + "','ACTIVO','" + codigoPrivilegio + "','1')", con);
                                    OdbcDataReader _rInsertar = cmdInsertar.ExecuteReader();
                                    OdbcCommand cmdModificar = new OdbcCommand("insert into permiso (nombre, validacion, estado, codigo_privilegios, condicion) values('MODIFICAR', '" + varConsultar + "','ACTIVO','" + codigoPrivilegio + "','1')", con);
                                    OdbcDataReader _rModificar = cmdModificar.ExecuteReader();
                                    OdbcCommand cmdEliminar = new OdbcCommand("insert into permiso (nombre, validacion, estado, codigo_privilegios, condicion) values('ELIMINAR', '" + varEliminar + "','ACTIVO','" + codigoPrivilegio + "','1')", con);
                                    OdbcDataReader _rEliminar = cmdEliminar.ExecuteReader();
                                }
                            }
                            MessageBox.Show("USUARIO REGISTRADO  :)");
                            claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Ingreso Usuario", "USUARIO");
                            desseleccionar();
                            limpiar();
                        }
                    }
            }
        

            

        private void desseleccionar()
        {
            foreach (DataGridViewRow row in GridPrivilegios.Rows)
            {
                DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[2];
                chk.Value = !(chk.Value == null ? false : (bool)chk.Value);
                DataGridViewCheckBoxCell chk2 = (DataGridViewCheckBoxCell)row.Cells[3];
                chk2.Value = !(chk2.Value == null ? false : (bool)chk2.Value);
                DataGridViewCheckBoxCell chk3 = (DataGridViewCheckBoxCell)row.Cells[4];
                chk3.Value = !(chk3.Value == null ? false : (bool)chk3.Value);
                DataGridViewCheckBoxCell chk4 = (DataGridViewCheckBoxCell)row.Cells[5];
                chk4.Value = !(chk4.Value == null ? false : (bool)chk4.Value);
            }
            
        }

        private void limpiar()
        {
            cmbModulos.SelectedItem = "Todos";
            txtPassword.Text = txtRectificaPassword.Text = txtUser.Text = txtRol.Text = txtDesc.Text = "";
        }
        private void funguardarModificacion()
        {


            string update = "UPDATE usuario SET nombre_usuario = " + "'" + txtUser.Text + "'" + " WHERE codigo_usuario = '" + txtIn.Text + "'";
            OdbcCommand cmd2 = new OdbcCommand(update, ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader MyReader = cmd2.ExecuteReader();
            ConexionODBC.Conexion.ObtenerConexion().Close();
            
            
          
            //******************************************************
                 string update2 = "UPDATE USUARIO SET   password_usuario = " + "'" + txtPassword.Text + "'" + " WHERE codigo_usuario = '" + txtIn.Text + "'";
                 OdbcCommand cmd3 = new OdbcCommand(update2, ConexionODBC.Conexion.ObtenerConexion());
                 cmd3.ExecuteNonQuery();
                 ConexionODBC.Conexion.ObtenerConexion().Close();
            //******************************************************
              
                 string modificarTipo = "UPDATE USUARIO SET   codigo_rol = " + "'" + txtGuarda2.Text + "'" + " WHERE codigo_usuario= '" + txtIn.Text + "'";
                 OdbcCommand cmd4 = new OdbcCommand(modificarTipo, ConexionODBC.Conexion.ObtenerConexion());
                 cmd4.ExecuteNonQuery();
                 ConexionODBC.Conexion.ObtenerConexion().Close();
            //******************************************************
            
                 string modificarPersona = "UPDATE USUARIO SET   codigopersona = " + "'" + txtGuarda.Text + "'" + " WHERE codigo_usuario = '" + txtIn.Text + "'";
                  OdbcCommand cmd5 = new OdbcCommand(modificarPersona, ConexionODBC.Conexion.ObtenerConexion());
                  cmd5.ExecuteNonQuery();
                  ConexionODBC.Conexion.ObtenerConexion().Close();
            //*******************************************************
            MessageBox.Show("USUARIO MODIFICADO");
                //INGRESO BITACORA
                claseUsuario.funobtenerBitacora(claseUsuario.varibaleUsuario, "Modifico Usaurio", "Usuario");
                //FIN INGRESO BITACORA
             
           
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            estado = "editar";
            txtUser.Enabled = true;
            txtPassword.Enabled = true;
            txtRectificaPassword.Enabled = true;
            cbMuestra.Enabled = true;
            GridPrivilegios.Enabled = true;
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void gbPrivilegios_Enter(object sender, EventArgs e)
        {

        }

        private void rdPre_CheckedChanged(object sender, EventArgs e)
        {
            if (rdPre.Checked == true)
            {
                txtRol.Enabled = false;
                cmbRolPre.Enabled = true;
                txtDesc.Enabled = false;
                GridPrivilegios.Enabled = false;
                lblTodo.Enabled = false;
                btnTodo.Enabled = false;
                rdNuevo.Checked = false;
                cmbModulos.Enabled = false;
                lblModulos.Enabled = false;
            }
        }

        private void rdNuevo_CheckedChanged(object sender, EventArgs e)
        {
            if (rdNuevo.Checked == true)
            {
                cmbRolPre.Enabled = false;
                txtRol.Enabled = true;
                txtDesc.Enabled = true;
                GridPrivilegios.Enabled = true;
                lblTodo.Enabled = true;
                btnTodo.Enabled = true;
                rdPre.Checked = false;
                cmbModulos.Enabled = true;
                lblModulos.Enabled = true;
            }
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            claseUsuario.timeCursor();
            cmbRolPre.Enabled = false;
            txtRol.Enabled = false;

            rdNuevo.Enabled = true;
            rdPre.Enabled = true;

            rdNuevo.Checked = false;
            rdPre.Checked = false;


        }

        private void GridPrivilegios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void GridPrivilegios_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (GridPrivilegios.Columns["Privilegio"].Selected == true)
            {
                GridPrivilegios.Columns["Guardar"].Selected = false;
                GridPrivilegios.Columns["Editar"].ReadOnly = true;
                GridPrivilegios.Columns["Eliminar"].ReadOnly = true;
            }

        }

        private void cmbRolPre_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        
        }
        
        void cmbRolPre_KeyUp(object sender, KeyEventArgs e)
        {
            string valorRol = cmbRolPre.Text;
            OdbcCommand _comandoRol = new OdbcCommand(String.Format(
            "SELECT   CONCAT(codigo_rol,' .', tipo),codigo_rol FROM ROL as camposRol WHERE tipo like  " + "'" + valorRol + "%'"), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _readerRol = _comandoRol.ExecuteReader();
            cbMuestra.Items.Clear();
            while (_readerRol.Read())
            {
                cmbRolPre.Items.Add(_readerRol[0].ToString());
                cmbRolPre.ValueMember = "camposRol";
                txtGuarda2.Text = _readerRol["codigo_rol"].ToString();
            }
            _readerRol.Close();
            ConexionODBC.Conexion.ObtenerConexion().Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GridPrivilegios_ColumnToolTipTextChanged(object sender, System.Windows.Forms.DataGridViewColumnEventArgs e)
        {

        }

        private void txtRectificaPassword_TextChanged_1(object sender, EventArgs e)
        {
            GridPrivilegios.Enabled = true;


        }

        private void txtGuarda2_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbMuestra_KeyUp_1(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            string valor = cbMuestra.Text;
            OdbcCommand _comando = new OdbcCommand(String.Format(
            "SELECT   CONCAT(codigopersona,' .', nombre,'  ',apellido),codigopersona FROM PERSONA as campos WHERE nombre like  " + "'" + valor + "%'"), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            cbMuestra.Items.Clear();
            while (_reader.Read())
            {
                // MessageBox.Show("entrando a consulta2");
                cbMuestra.Items.Add(_reader[0].ToString());
                cbMuestra.ValueMember = "campos";
                txtGuarda.Text = _reader["codigopersona"].ToString();
            }
            _reader.Close();
            ConexionODBC.Conexion.ObtenerConexion().Close();
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            if (check == 0)
            {
                foreach (DataGridViewRow row in GridPrivilegios.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                    chk.Value = !(chk.Value == null ? false : (bool)chk.Value);
                }
                this.btnTodo.Image = Resources._1457297125_stock_form_checkbox;
                check = 1;
            }
            else
            {
                foreach (DataGridViewRow row in GridPrivilegios.Rows)
                {
                    DataGridViewCheckBoxCell chk = (DataGridViewCheckBoxCell)row.Cells[1];
                    chk.Value = !(chk.Value == null ? true : (bool)chk.Value);
                }
                this.btnTodo.Image = Resources._unchecked;
                check = 0;
            }
            
        }

        private void cmbModulos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridPrivilegios.Rows.Clear();
            switch (cmbModulos.SelectedItem.ToString())
            {
                case "Todos":
                    llenarGrid();
                break;
                case "Catalogos":
                    GridPrivilegios.Rows.Add("frmPersona", "Mant. Alumnos", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmEmpleado", "Mant. Empleados", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmFamilia", "Mant. Familia de Alumnos", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmPuestos", "Mant. Puestos", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmSalones", "Mant. Salones", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmCursos", "Mant. Cursos", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmParqueos", "Mant. Parqueos", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmLaboratorios", "Mant. Laboratorios", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmPensum", "Mant. Pensum", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmSedes", "Mant. sedes", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmTipoPago", "Tipos Pago para Almns.", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmTipoServicio", "Mant. Razones de Cobros", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmCarrera", "Mant. Carreras", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmJornada", "Mant. Jornadas", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmHorario", "Mant. Horarios", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmSeccion", "Mant. Secciones",  false, false, false, false);
                    GridPrivilegios.Rows.Add("frmFacultad", "Mant. Facultades", false, false, false, false);
                break;
                case "Administracion":
                    GridPrivilegios.Rows.Add("frmAsigOrd", "Asignacion de Cursos", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmReasignacion", "Reasignacinones", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmAsigParq", "Asignacion parqueos", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmReinscripcion", "Reinscripcon Almn.", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmCreacionPensum", "Creacion de pensa", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmCreacionPaquete", "Creacion paquete cursos", false, false, false, false);
                break;
                case "Notas":
                    GridPrivilegios.Rows.Add("frmNotas", "Ingreso de notas", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmZona", "Distribucion de zona", false, false, false, false);
                break;
                case "Tesoreria":
                    GridPrivilegios.Rows.Add("frmCobroParqueo", "Cobros de parqueos", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmMensualidad", "Cobros de Mensualidad", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmCobroInscrip", "Cobros de Inscripcion", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmCobroReasig", "Cobros Reasignacion", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmCobroDoc", "Cobros de Doc. Varios", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmPagoEmpleado", "Pago Salarios", false, false, false, false);
                break;
                case "Seguridad":
                    GridPrivilegios.Rows.Add("frmUsuario", "Creacion usuarios y roles", false, false, false, false);
                    GridPrivilegios.Rows.Add("frmBitacora", "Bitacora de Base de Datos", false, false, false, false);
                break;
                case "Reportes":
                    GridPrivilegios.Rows.Add("frmReporteCatalogos", "Administrador de Reportes", false, false, false, false);
                break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
         
}

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            string text = txtPassword.Text;
            if (!checkPass.Checked)
              {
                txtPassword.UseSystemPasswordChar = true;
                txtPassword.Text = text;
                }
                  else
                       {
                         txtPassword.UseSystemPasswordChar = false;
                         txtPassword.Text = text;
                         }
                       }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void funeliminarUsuario()
        {
              string update2 = "UPDATE USUARIO set estado = 'INACTIVO' where codigopersona = '" + txtIn.Text + "'";
                 OdbcCommand cmd3 = new OdbcCommand(update2, ConexionODBC.Conexion.ObtenerConexion());
                 cmd3.ExecuteNonQuery();
                 ConexionODBC.Conexion.ObtenerConexion().Close();
                 MessageBox.Show("Usuario desactivado");
               }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            estado = "eliminar";
            txtUser.Enabled = true;
            txtPassword.Enabled = true;
            txtRectificaPassword.Enabled = true;
            cbMuestra.Enabled = true;
            GridPrivilegios.Enabled = true;
           
                
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtUser.Enabled=true;
            txtPassword.Enabled=true;
            txtRectificaPassword.Enabled=true;
            cbMuestra.Enabled = true;
            GridPrivilegios.Enabled = true;

        }
        }
  }
        
    
    


        
        
  

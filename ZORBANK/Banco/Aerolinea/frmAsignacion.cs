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
using iTextSharp.text;

namespace ZORBANK
{
    public partial class frmAsignacion : Form
    {
        public static OdbcCommand _comando;
        public static OdbcDataReader _reader;
        int iContador = 0,cuentecita;
        char[] delimitador = { '.' };

        string sDatoCarnet, sDatoCarrera, sDatoJornada,codigoCurso,fecha;
        int sFila,sumaValor;
        public string sGrdCurso, sGrdSeccion, sGrdHorario;
        //public string RecibeCurso,RecibeSeccion,RecibeHorario;
        List<string> listaCodigos = new List<string>();
        
        public frmAsignacion()
        {
            InitializeComponent();
            Boolean[] permisos;
            permisos = claseUsuario.PermisosBotones(claseUsuario.varibaleUsuario, "frmAsignacion");
            btnNuevo.Enabled = permisos[0];
            btnEditar.Enabled = permisos[1];
            btnEliminar.Enabled = permisos[2];
            bloquearTodos();
            //grdCursosAsignar.Rows.Add();
        }

        public void llenarCursos() { 
        
        
        }
        public void tomarFecha()
        {
            DateTime fe = DateTime.Today;
            fecha = fe.Year + "-" + fe.Month + "-" + fe.Day;
        }
        public void bloquearTodos()
        {
            btnAnterior.Enabled = false;
            btnBuscar.Enabled = false;
            btnCancelar.Enabled = false;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnImprimir.Enabled = false;
            btnIrPrimero.Enabled = false;
            btnIrUltimo.Enabled = false;
            btnNuevo.Enabled = true; //boton principal de la funcion
            btnRefrescar.Enabled = false;
            btnSiguiente.Enabled = false;
            txtCarnet.Enabled = false;
        }
        public void habilitarConNuevo()
        {
            btnAnterior.Enabled = false;
            btnBuscar.Enabled = true;
            btnCancelar.Enabled = true;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            btnGuardar.Enabled = false;
            btnImprimir.Enabled =false;
            btnIrPrimero.Enabled = false;
            btnIrUltimo.Enabled = false;
            btnNuevo.Enabled = false; //boton principal de la funcion
            btnRefrescar.Enabled = false;
            btnSiguiente.Enabled = false;
            txtCarnet.Enabled = true;
        }
        public void funlimpiar() {
            lblInfoAlumno.Text = "";
            lblInfoCarrera.Text = "";
            lblInfoJornada.Text = "";
            cmbSeccion.Text = "";
            grdCursosAsignar.Rows.Clear();
            lblHorario.Text = "";
            txtCarnet.Text = "";
        
        }

        public Boolean validarInscripcion(string carnet) {
            Boolean validacion = false;
            _comando = new OdbcCommand(String.Format("CALL ValidarInscripcion('"+txtCarnet.Text+"');"), ConexionODBC.Conexion.ObtenerConexion());
            _reader = _comando.ExecuteReader();
            validacion = true;
            return validacion;
        }

        public void funTraerDatosAlumno(string traercarnet) {
            try
            {
                _comando = new OdbcCommand(String.Format("CALL ManuelTraerDatosAlumno('"+traercarnet+"')"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                if(_reader.Read()){//CALL ManuelTraerDatosAlumno('1')
                    sDatoCarnet = _reader.GetString(0);
                    sDatoCarrera = _reader.GetString(1);
                    sDatoJornada = _reader.GetString(2);
                    lblInfoAlumno.Text = sDatoCarnet;
                    lblInfoCarrera.Text = sDatoCarrera;
                    lblInfoJornada.Text = sDatoJornada;
                    //MessageBox.Show("Datos del Alumno---->  " + sDatoCarnet + sDatoCarrera + sDatoJornada);
                    System.Console.WriteLine("Datos del Alumno---->  "+sDatoCarnet+sDatoCarrera+sDatoJornada);
                }

            }catch (Exception){
                System.Console.WriteLine("Dato no Coicide");
            }
        }

        public void funLlenarGrid() {
            //WaitSeconds(0.3);
            try
            {
                String[] cocarrera = lblInfoCarrera.Text.Split(delimitador);
                string CodigoCarrera = cocarrera[0];

                _comando = new OdbcCommand(String.Format("SELECT CONCAT(curso.codigo_curso,'.',curso.nombre) as curso FROM pensum,asignacion_pensum,creacion_pensum,curso,prerequisito,carnet WHERE pensum.codigo_pensum=creacion_pensum.codigo_pensum and pensum.codigo_pensum=asignacion_pensum.codigo_pensum AND creacion_pensum.codigo_curso=curso.codigo_curso and creacion_pensum.codigo_prerequisito=prerequisito.codigo_prerequisito and asignacion_pensum.codigoCarnet=carnet.codigoCarnet and carnet.codigoCarrera='" + CodigoCarrera + "' and prerequisito.nombre='SinPrerequisito' and asignacion_pensum.codigoCarnet='" + txtCarnet.Text + "'"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    //txtSeccion.Items.Clear(); //Limpia sin Duplicar los datos del combox
                    string sNombreCurso = _reader.GetString(0);
                    grdCursosAsignar.Rows.Insert(iContador, false, sNombreCurso);
                    sNombreCurso = "";
                    iContador++;
                }
            }
            catch (Exception) {
                txtCarnet.Text = "";
                lblInfoCarrera.Text = "";
                lblInfoAlumno.Text = "";
                lblInfoJornada.Text = "";
                System.Console.WriteLine("registro no encontrado");
            }
            
        }

      
        public void prueba2(){ 
             _comando = new OdbcCommand(String.Format("SELECT asignacioncurso.ccodigo_paquete FROM asignacioncurso,encabezado_nota,cursos_aprobados WHERE encabezado_nota.codigoInscripcion=asignacioncurso.codigoInscripcion and encabezado_nota.codigo_encabezado_nota=cursos_aprobados.codigo_cursos_aprobados and encabezado_nota.codigoCarnet='1'"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read())
                {
                    string Codigopaquete = _reader.GetString(0);
                    //MessageBox.Show(Codigopaquete);
                    _comando = new OdbcCommand(String.Format("SELECT curso.nombre FROM curso,paquete WHERE paquete.codigo_curso=curso.codigo_curso AND paquete.ccodigo_paquete='"+Codigopaquete+"'"), ConexionODBC.Conexion.ObtenerConexion());
                    _reader = _comando.ExecuteReader();
                    while (_reader.Read()) {
                        string nombreCurso = _reader.GetString(0);
                        //MessageBox.Show(nombreCurso);
                        _comando = new OdbcCommand(String.Format("SELECT prerequisito.codigo_prerequisito from prerequisito WHERE prerequisito.nombre='"+nombreCurso+"'"), ConexionODBC.Conexion.ObtenerConexion());
                        _reader = _comando.ExecuteReader();
                        while (_reader.Read())
                        {
                            string codigoPrerequisito = _reader.GetString(0);
                            //MessageBox.Show(codigoPrerequisito);
                            _comando = new OdbcCommand(String.Format("SELECT creacion_pensum.codigo_curso FROM creacion_pensum WHERE creacion_pensum.codigo_prerequisito='" + codigoPrerequisito + "'"), ConexionODBC.Conexion.ObtenerConexion());
                            _reader = _comando.ExecuteReader();
                            while (_reader.Read())
                            {
                                codigoCurso = _reader.GetString(0);
                                listaCodigos.Add(codigoCurso);
                            }
                            int numero = listaCodigos.Count;
                            for (int list = 0; list < numero; list++) {
                                //MessageBox.Show(listaCodigos[list]);
                                string tomalista = listaCodigos[list].ToString();
                                _comando = new OdbcCommand(String.Format("SELECT curso.nombre FROM curso,creacion_pensum WHERE creacion_pensum.codigo_curso=curso.codigo_curso and creacion_pensum.codigo_curso='" + tomalista + "'"), ConexionODBC.Conexion.ObtenerConexion());
                                _reader = _comando.ExecuteReader();
                                while (_reader.Read())
                                {
                                    int cont = 0;
                                    string finalNombre = _reader.GetString(0);
                                    MessageBox.Show(finalNombre);
                                    grdCursosAsignar.Rows.Insert(cont, false, finalNombre);
                                    finalNombre = "";
                                    cont++;
                                }
                            
                            }

                        }
                    }
                }
        }

        public void funrecibecurso(string recibe) {
            //MessageBox.Show("se recibio curso  "+recibe);
            _comando = new OdbcCommand(String.Format("SELECT curso.nombre FROM curso,creacion_pensum WHERE creacion_pensum.codigo_curso=curso.codigo_curso and creacion_pensum.codigo_curso='" + recibe + "'"), ConexionODBC.Conexion.ObtenerConexion());
            _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                //int cont = 0;
                string finalNombre = _reader.GetString(0);
                
                MessageBox.Show(finalNombre);
            }
        }

        public void funRecorrerGrid() {
            int fill = grdCursosAsignar.Rows.Count;
            System.Console.WriteLine("numero de filas del grid" + fill);
            if (fill== 0) {
                MessageBox.Show("El grid esta vacio");
            }
            else{
                for (int x = 0; x < fill; x++) {

                    if (grdCursosAsignar.Rows[x].Cells[0].Value.Equals(true))
                    {
                        cuentecita = 0;
                        cuentecita++;
                        string grdtomaCurso = grdCursosAsignar.Rows[x].Cells[1].Value.ToString();
                        string grdtomaSeccion = grdCursosAsignar.Rows[x].Cells[2].Value.ToString();
                        string grdtomaHorario = grdCursosAsignar.Rows[x].Cells[3].Value.ToString();
                        string[] takecodcurso = grdtomaCurso.Split(delimitador);
                        string[] takeseccion= grdtomaSeccion.Split(delimitador);
                        string[] takehorario = grdtomaHorario.Split(delimitador);

                        string codcurs = takecodcurso[0];
                        string codsecc = takeseccion[0];
                        string codhora = takehorario[0];

                        _comando = new OdbcCommand(String.Format("SELECT paquete.ccodigo_paquete from paquete WHERE paquete.codigo_curso='"+codcurs+"' and paquete.codigo_seccion='"+codsecc+"' and paquete.codigoHorario='"+codhora+"'"), ConexionODBC.Conexion.ObtenerConexion());
                        _reader = _comando.ExecuteReader();
                        while (_reader.Read())
                        {
                            int anio = 2016;
                            string ciclo = "Primero";
                            string codpacquete = _reader.GetString(0);
                            //MessageBox.Show(codpacquete);
                            //_comando = new OdbcCommand(String.Format("insert into asignacioncurso(anio,ciclo,codigo_paquete) values ('" + anio + "','" + ciclo + "','" + codpacquete + "')"), ConexionODBC.Conexion.ObtenerConexion());
                           //_comando.ExecuteNonQuery();
                        }
                        //--------recordar tomar dato de carnet
                        //MessageBox.Show(grdtomaCurso + grdtomaSeccion + sGrdHorario);
                        _comando = new OdbcCommand(String.Format("SELECT curso.valor from curso WHERE curso.codigo_curso='"+codcurs+"'"), ConexionODBC.Conexion.ObtenerConexion());
                        _reader = _comando.ExecuteReader();
                        while (_reader.Read()) {
                            string valor = _reader.GetString(0);
                            int cantidad = int.Parse(valor);
                            sumaValor = sumaValor+cantidad;
                            //MessageBox.Show(sumaValor.ToString());
                        }
                       
                        //_comando = new OdbcCommand(String.Format("insert into asignacioncurso(anio,ciclo,codigo_paquete) values ('" + anio + "','" + ciclo + "','" + codpacquete + "')"), ConexionODBC.Conexion.ObtenerConexion());
                        // _comando.ExecuteNonQuery();
                    }
                }

                //-------------insert para tabla de diego-----------------
                MessageBox.Show(sumaValor.ToString());
                string descricion = "Mensualidad";
                tomarFecha();
                string accion="Decremento";
                string estado = "ACTIVO";
                int codicion =1;
                _comando = new OdbcCommand(String.Format("insert into tipo_servicio(descripcion,fecha_corte,monto,accion,estado,condicion,carnet) values ('" + descricion + "','" + fecha + "','" + sumaValor + "','"+accion+"','"+estado+"','"+codicion+"','"+txtCarnet.Text+"')"), ConexionODBC.Conexion.ObtenerConexion());
                _comando.ExecuteNonQuery();
        }

        }

        
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //grdCursosAsignar.Rows[0].Cells[2].Value = "prueba";
            if (MessageBox.Show("¿Decea Asignar Al Alumno?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                funRecorrerGrid();
                MessageBox.Show("El Alumno se Asigno Correctamente");
                funlimpiar();
                bloquearTodos();
            }
            else {
                funlimpiar();
                bloquearTodos();
            }

        }
       
        private void txtCarnet_KeyUp(object sender, KeyEventArgs e)
        {
            //funlimpiar();
            string datoTxtCarnet = txtCarnet.Text;
            funTraerDatosAlumno(datoTxtCarnet);
            btnNuevo.Enabled = true;
           // WaitSeconds(0.5);
            //funLlenarGrid();

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            btnGuardar.Enabled = true;
            grdCursosAsignar.Rows.Clear();
            iContador = 0;
            funLlenarGrid();

        }

        
        private void grdCursosAsignar_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
                cmbSeccion.Items.Clear();
                sFila = grdCursosAsignar.CurrentCell.RowIndex;
                //string columna = grdCursosAsignar.CurrentCell.ColumnIndex.ToString();
                //MessageBox.Show("fila------->  " + sFila);
                //string sNombreCurso = grdCursosAsignar.Rows[grdCursosAsignar.CurrentCell.RowIndex].Cells[1].Value.ToString();
                string sNombreCurso = grdCursosAsignar.Rows[sFila].Cells[1].Value.ToString();
                string[] sCodCurso = sNombreCurso.Split(delimitador);
                string tomacod = sCodCurso[0];
                _comando = new OdbcCommand(String.Format("SELECT CONCAT(seccion.codigo_seccion,'.',seccion.nombre) as seccion from seccion,paquete WHERE paquete.codigo_seccion=seccion.codigo_seccion and paquete.codigo_curso='"+tomacod+"'"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read()) {
                    string resultado = _reader.GetString(0);
                    cmbSeccion.Items.Add(resultado);    
                }
                cmbSeccion.DroppedDown = true;
        }

        public void funObtenerHorario(string CodSeccion,string NomSeccion,string CodCurso) {
            //MessageBox.Show(CodSeccion + NomSeccion + CodCurso);
            _comando = new OdbcCommand(String.Format("SELECT CONCAT(horario.codigoHorario,'.',horario.rangoHora)as horario FROM horario,paquete WHERE paquete.codigoHorario=horario.codigoHorario and paquete.codigo_seccion='" + CodSeccion + "' and paquete.codigo_curso='" + CodCurso + "'"), ConexionODBC.Conexion.ObtenerConexion());
                _reader = _comando.ExecuteReader();
                while (_reader.Read()) {
                    lblHorario.Text = _reader.GetString(0);
                    //string tomalbl = lblHorario.Text;
                }
                string hora = lblHorario.Text;
                //MessageBox.Show("la  fila es   " + sFila);
                grdCursosAsignar.Rows[sFila].Cells[2].Value = CodSeccion+"."+NomSeccion;
                grdCursosAsignar.Rows[sFila].Cells[3].Value =lblHorario.Text.Trim();
        }

        private void cmbSeccion_DropDown(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            funlimpiar();
            bloquearTodos();
        }
        

        private void cmbSeccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblHorario.Text = "";
            //MessageBox.Show("holis funciono");
            string sNombreCurso = grdCursosAsignar.Rows[grdCursosAsignar.CurrentCell.RowIndex].Cells[1].Value.ToString();
            string sTomaSeccion = cmbSeccion.Text.Trim();
            string[] curs = sNombreCurso.Split(delimitador);
            string[] sec = sTomaSeccion.Split(delimitador);
            string sCurCodigo = curs[0];
            string sSecCodigo = sec[0];
            string sSecNombre = sec[1];
            //MessageBox.Show("codigo Seccion " + sSecCodigo + "  Nombre  " + sSecNombre + "  codigoCurso " + sCurCodigo);
            funObtenerHorario(sSecCodigo, sSecNombre, sCurCodigo);
        }

        

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            habilitarConNuevo();
        }
    }
}

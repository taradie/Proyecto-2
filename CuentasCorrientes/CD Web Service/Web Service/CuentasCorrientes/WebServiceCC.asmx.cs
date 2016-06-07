using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Services;
using MySql.Data.MySqlClient;
using System.Data;


namespace CuentasCorrientes
{
    /// <summary>
    /// Descripción breve de WebServiceCC
    /// </summary>
    [WebService(Namespace = "http://cuentascorrientes.azurewebsites.net")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceCC : System.Web.Services.WebService
    {
        string conexion = "server=us-cdbr-azure-southcentral-e.cloudapp.net;uid=bfeb7da828a1f8;pwd=3f5e63cf;database=acsm_a2d1841e03afcc8";
        MySqlConnection sql = null;
        MySqlCommand query = new MySqlCommand();
        MySqlDataReader consultar;
        string resultado;
        MySqlDataAdapter da;
        [WebMethod]        

        public DataSet Resultados(string sTipo, string sCod)
        {
            string query = "";
            DataSet ds;
            sql = new MySqlConnection(conexion);
            sql.Open();
            if (sTipo == "P")
            {
                if(sCod!=""){
                    query = "SELECT codfacturaprov as NoFactura, concat(proveedor.codproveedor, '.' ,proveedor.nombre) as Proveedor, total as Total, saldo as Saldo, fecha as Fecha, facturaproveedor.estado as Estado from facturaproveedor, proveedor WHERE facturaproveedor.condicion = '1' and facturaproveedor.codproveedor = proveedor.codproveedor and facturaproveedor.saldo < facturaproveedor.total and facturaproveedor.codproveedor='"+sCod+"'";
                }
                else{
                    query = "SELECT codfacturaprov as NoFactura, concat(proveedor.codproveedor, '.' ,proveedor.nombre) as Proveedor, total as Total, saldo as Saldo, fecha as Fecha, facturaproveedor.estado as Estado from facturaproveedor, proveedor WHERE facturaproveedor.condicion = '1' and facturaproveedor.codproveedor = proveedor.codproveedor and facturaproveedor.saldo < facturaproveedor.total";
                }

                da = new MySqlDataAdapter(query, sql);
                ds = new DataSet("facturaproveedor");
                da.FillSchema(ds, SchemaType.Source, "facturaproveedor");
                da.Fill(ds, "facturaproveedor");
                sql.Close();
                return ds;
            }
            else if (sTipo == "C")
            {
                if (sCod != "")
                {
                    query = "SELECT factura.ncodfactura AS Codigo, factura.vserie AS Serie, factura.nombre AS Nombre, factura.nit AS Nit, concat(factura.ncodcliente, '.', cliente.nombrecliente, ' ', cliente.apellidocliente) AS Cliente, factura.fechafactura AS Fecha, factura.fechavencimiento AS Vencimiento, factura.total AS Total, factura.saldo AS Saldo FROM factura, cliente WHERE factura.ncodcliente = cliente.ncodcliente AND factura.saldo < factura.total AND factura.condicion = '1' and factura.ncodcliente = '"+sCod+"'";
;
                }
                else
                {
                    query = "SELECT factura.ncodfactura AS Codigo, factura.vserie AS Serie, factura.nombre AS Nombre, factura.nit AS Nit, concat(factura.ncodcliente, '.', cliente.nombrecliente, ' ', cliente.apellidocliente) AS Cliente, factura.fechafactura AS Fecha, factura.fechavencimiento AS Vencimiento, factura.total AS Total, factura.saldo AS Saldo FROM factura, cliente WHERE factura.ncodcliente = cliente.ncodcliente AND factura.saldo < factura.total AND factura.condicion = '1'";
                }

                da = new MySqlDataAdapter(query, sql);
                ds = new DataSet("factura");
                da.FillSchema(ds, SchemaType.Source, "factura");
                da.Fill(ds, "factura");
                sql.Close();
                return ds;
            }
            else if (sTipo == "E")
            {
                if (sCod != "")
                {
                    query = "SELECT prestamo.cod_empleado AS CODIGO, personas.nombres AS NOMBRE, prestamo.total AS TOTAL, prestamo.Saldo AS PAGADO FROM prestamo, empleado, personas WHERE prestamo.cod_empleado=empleado.cod_empleado AND empleado.codigo_persona=personas.codigo_persona AND prestamo.condicion='ACTIVO' and prestamo.cod_empleado='"+sCod+"'";
                }
                else
                {
                    query = "SELECT prestamo.cod_empleado AS CODIGO, personas.nombres AS NOMBRE, prestamo.total AS TOTAL, prestamo.Saldo AS PAGADO FROM prestamo, empleado, personas WHERE prestamo.cod_empleado=empleado.cod_empleado AND empleado.codigo_persona=personas.codigo_persona AND prestamo.condicion='ACTIVO'";
                }

                da = new MySqlDataAdapter(query, sql);
                ds = new DataSet("prestamo");
                da.FillSchema(ds, SchemaType.Source, "prestamo");
                da.Fill(ds, "prestamo");
                sql.Close();
                return ds;
            }

            sql.Close();
            return null;
            
        }
    }
}

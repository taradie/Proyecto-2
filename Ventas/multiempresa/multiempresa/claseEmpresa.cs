using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using ConexionODBC;

namespace multiempresa
{
   public class claseEmpresa
    {

      public  static  List<clsCliente> Buscar(string pestado)
        {
            List<clsCliente> _lista = new List<clsCliente>();

            OdbcCommand _comando = new OdbcCommand(String.Format(
           "SELECT CONCAT(codigo_empresa)  AS Id, razon_social  from empresa where estado ='{0}'", pestado), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                clsCliente pCliente = new clsCliente();
               
               pCliente.Id= _reader.GetString(0);
               pCliente.Nombre = _reader.GetString(1);
               _lista.Add(pCliente);
            }

            return _lista;
        }

      



    }
}
            
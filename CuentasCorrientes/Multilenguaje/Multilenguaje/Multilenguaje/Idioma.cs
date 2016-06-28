using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multilenguaje
{
    public class Idioma
    {
        public static string ObtenerIdioma()
        {
            string sIdioma="";
            OdbcCommand _comando = new OdbcCommand(String.Format("SELECT idioma from idioma"), ConexionODBC.Conexion.ObtenerConexion());
            OdbcDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                sIdioma = (_reader.GetString(0)).Trim();
            }
            ConexionODBC.Conexion.CerrarConexion();
            return sIdioma;
        }
    }
}

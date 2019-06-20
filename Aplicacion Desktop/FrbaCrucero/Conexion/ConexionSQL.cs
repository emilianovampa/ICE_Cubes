using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace FrbaCrucero
{
    class ConexionSQLS
    {
        // La idea es que sea un Singleton, al menos por el momento

        private static SqlConnection Conexion;

        // Establece la configuración de la conección con la bd
        static ConexionSQLS() {
            Conexion = new SqlConnection();
            Conexion.ConnectionString =
            "Data Source=localhost\\SQLSERVER2012;" +
            "Initial Catalog=GD1C2019;" +
            "User ID=gdCruceros2019;" +
            "Password=gd2019;";
        }

        // Retorna la instancia de SqlConnection
        public static SqlConnection getConeccion() {
            return Conexion;
        }

        // Inicia la Conexion
        public static void iniciarConeccion() {
            Conexion.Open();
        }

        // Cierra la Conexion
        public static void CierraConexion()
        {
            Conexion.Close();
        }

        // Store
        //public static SqlDataReader ExecuteReader(string SP, Dictionary<string, object> parametros = null)
        //{
          
        ////    //if (parametros == null) parametros = new Dictionary<string, object>();
            
        ////    SqlCommand command = new SqlCommand("ICE_CUBES." + SP, ConexionSQLS.getConeccion());
        ////    command.CommandType = System.Data.CommandType.StoredProcedure;
        ////    foreach (ParametroStore parametro in parametros)
        ////    {
        ////        SqlParameter ParametroSt = new SqlParameter();
        ////        ParametroSt.ParameterName = ;
        ////        ParametroSt.     =;
        ////        ParametroSt.Direction = ;
                
        ////        command.Parameters.Add(parametro);
        ////        command.Parameters.AddWithValue
        ////    }

        ////    //foreach (var parametro in parametros)
        ////    //{
        ////    //    command.Parameters.Add(new SqlParameter(parametro.Key, parametro.Value));
        ////    //}
        //    SqlDataReader result = command.ExecuteReader();

        //    return result;
        //}

    
     

    }
}

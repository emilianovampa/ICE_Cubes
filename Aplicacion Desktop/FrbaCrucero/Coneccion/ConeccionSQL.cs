using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace FrbaCrucero
{
    class ConeccionSQL
    {
        // La idea es que sea un Singleton, al menos por el momento

        private static SqlConnection coneccion;

        // Establece la configuración de la conección con la bd
        static ConeccionSQL() {
            coneccion = new SqlConnection();
            coneccion.ConnectionString =
            "Data Source=localhost\\SQLSERVER2012;" +
            "Initial Catalog=GD1C2019;" +
            "User ID=gdCruceros2019;" +
            "Password=gd2019;";
        }

        // Retorna la instancia de SqlConnection
        public static SqlConnection getConeccion() {
            return coneccion;
        }

        // Inicia la conección
        public static void iniciarConeccion() {
            coneccion.Open();
        }

    }
}

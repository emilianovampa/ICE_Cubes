using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Menu;
using System.Configuration;
using FrbaCrucero.PagoReserva;

namespace FrbaCrucero
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static DateTime dia;
        [STAThread]
        static void Main()
        {
            dia = DateTime.Parse(ConfigurationManager.AppSettings["Dia"]);
            ConexionSQLS.iniciarConeccion(); //establesco la conexion por unica vez con la Base de datos.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new BusquedaReservaVista().ShowDialog();
            
  //          new loginView().ShowDialog();
            Application.Run();
            //new AltaRolView().ShowDialog();
        }

        public static DateTime ObtenerFechaActual()
        {
            return Program.dia;
        }
    }
}

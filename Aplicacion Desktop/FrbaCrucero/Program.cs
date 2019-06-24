using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Menu;

namespace FrbaCrucero
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConexionSQLS.iniciarConeccion(); //establesco la conexion por unica vez con la Base de datos.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            new loginView().ShowDialog();
            Application.Run();
        }
    }
}

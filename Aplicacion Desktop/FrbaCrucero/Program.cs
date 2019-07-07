using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Menu;
//using FrbaCrucero.AbmRol;
using FrbaCrucero.model;

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
//            new loginView().ShowDialog();
            List<Recorrido> recorridos = new List<Recorrido>(Recorrido.listarRecorridos());

            Tramo t1 = new Tramo(0, new Puerto(1, "BUENOS AIRES", true), new Puerto(2, "MONTEVIDEO", true), 100);
            Tramo t2 = new Tramo(1, new Puerto(2, "MONTEVIDEO", true), new Puerto(3, "RIO", true), 100);
            List<Tramo> tramos = new List<Tramo>();
            tramos.Add(t1);
            tramos.Add(t2);
            Recorrido recorrido = new Recorrido(0, tramos, true);
            RecorridoView vista = new RecorridoView(recorrido);
            vista.ShowDialog();
            Application.Run();
            //new AltaRolView().ShowDialog();
        }
    }
}

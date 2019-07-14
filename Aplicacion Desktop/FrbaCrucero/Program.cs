﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Menu;
using System.Configuration;
using FrbaCrucero.PagoReserva;
using FrbaCrucero.model;


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
            new loginView().ShowDialog();
            Application.Run();
        }

        public static DateTime ObtenerFechaActual()
        {
            return Program.dia;
        }

        public static DialogResult openNextWindow(Form self, Form next)
        {
            self.Hide();
            DialogResult ret = next.ShowDialog();
            next.Dispose();
            self.Show();
            return ret;
        }

        public static DialogResult openPopUpWindow(Form self, Form window)
        {
            self.Enabled = false;
            DialogResult ret = window.ShowDialog();
            window.Dispose();
            self.Enabled = true;
            return ret;
        }
    }
}

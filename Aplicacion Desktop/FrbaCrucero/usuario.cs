using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;


namespace FrbaCrucero
{
    class usuario
    {
        string nombreUsuario {set ; get; }
        string passUsuario { set; get; }
        char tipo { set; get; }
        int estado { set; get; } 
        int intentos {set ; get; } 
        List<Rol> Roles = new List<Rol>();
        private string usuario1;
        private string pass;

        public usuario(string usuario1, string pass)
        {
            // TODO: Complete member initialization
            this.usuario1 = usuario1;
            this.pass = pass;
        }

        public usuario()
        {
            // TODO: Complete member initialization
        }


    }
}

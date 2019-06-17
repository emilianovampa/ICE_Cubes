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


    }
}

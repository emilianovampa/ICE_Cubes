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
        string nombreUsuario;
        string contraseña;
        char tipo;
        int estado;
        int intentos;
        List<Rol> Roles = new List<Rol>();


    }
}

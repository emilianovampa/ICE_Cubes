using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.AbmRol
{
    class AbmRolController
    {
        // Atributos
        AltaRolView vistaDeAlta;
        Rol unRol;

        // Constructor
        public AbmRolController(AltaRolView vistaDeAlta)
        {
            this.vistaDeAlta = vistaDeAlta;
        }

        public void darDeAlta(string rolDescripcion, List<byte> idFuncionalidadesList)
        {
            unRol = new Rol(rolDescripcion);

            string mensajeDeRetorno = unRol.dateDeAlta(idFuncionalidadesList);
            vistaDeAlta.mostrarMensaje(mensajeDeRetorno);
        }
    }
}

using FrbaCrucero.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.AbmRol
{
    class RolController
    {
        // Atributos
        AltaRolView vistaDeAlta;
        Rol unRol;

        // Constructor
        public RolController(AltaRolView vistaDeAlta)
        {
            this.vistaDeAlta = vistaDeAlta;
        }

        public void cargarFuncionalidades()
        {
            unRol = new Rol();
            unRol.obtenerFuncionalidades();

            for (int i = 0; i < unRol.Funcionalidades.Count; i++)
            {
                vistaDeAlta.agregarFuncionalidad(unRol.Funcionalidades[i].NombreFuncionalidad);
            } 
        }

        // Completar
        public void darDeAlta(string rolDescripcion, string nombreFuncionalidad)
        {
            
            foreach (Funcionalidad f in unRol.Funcionalidades)
            {
                if (f.NombreFuncionalidad.Equals(nombreFuncionalidad))
                {
                    //unRol.RolDescripcion = rolDescripcion;
                    unRol.darDeAltaRol(rolDescripcion, f.IdFuncion);
                    break;
                }
            }            
        }
    }
}

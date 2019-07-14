using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.model
{
    public class Funcionalidad
    {
        // Atributos
        private decimal idFuncionalidad;
        private string nombreFuncionalidad;

        // Accessors
        public decimal IdFuncionalidad
        {
            get { return idFuncionalidad; }
            set { idFuncionalidad = value; }
        }
        public string NombreFuncionalidad
        {
            get { return nombreFuncionalidad; }
            set { nombreFuncionalidad = value; }
        }

        // Constructor
        public Funcionalidad(decimal idFuncionalidad, string nombreFuncionalidad)
        {
            // TODO: Complete member initialization
            IdFuncionalidad = idFuncionalidad;
            NombreFuncionalidad = nombreFuncionalidad;
        } 
    }
}

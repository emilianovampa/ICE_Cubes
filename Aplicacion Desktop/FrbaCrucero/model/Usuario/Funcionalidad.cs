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
        private decimal idFuncion;
        private string nombreFuncionalidad { get; set; }

        // Accessors
        public decimal IdFuncion
        {
            get { return idFuncion; }
            set { idFuncion = value; }
        }
        public string NombreFuncionalidad
        {
            get { return nombreFuncionalidad; }
            set { nombreFuncionalidad = value; }
        }

        // Constructor
        public Funcionalidad(decimal idFuncion, string nombreFuncionalidad)
        {
            // TODO: Complete member initialization
            IdFuncion = idFuncion;
            NombreFuncionalidad = nombreFuncionalidad;
        } 




    }
}

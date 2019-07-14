using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.model
{
    public class Crucero
    {
        [System.ComponentModel.DisplayName("Identificador")]
        public Int32 identificador { get; set;}

//        [System.ComponentModel.DisplayName("Cabinas")]
        public HashSet<Cabina> cabinas = new HashSet<Cabina>();

        [System.ComponentModel.DisplayName("Estado")]
        public String estado { get {return determinarEstado();}}

        private string determinarEstado()
        {
 	        if (identificador == 0)
            {
                return "Nuevo";
            }
            return "Activo";
        }

        [System.ComponentModel.DisplayName("Fecha de Alta")]
        public Nullable<DateTime> fechaAlta { get; set;}

//        [System.ComponentModel.DisplayName("Marca")]
        public Marca marca;

//        [System.ComponentModel.DisplayName("Tipo de Servicio")]
        public Servicio servicio;

        public Crucero() //Constructor para un crucero nuevo
        {
            identificador = 0;
            servicio = new Servicio();  
        }
            
    }
}

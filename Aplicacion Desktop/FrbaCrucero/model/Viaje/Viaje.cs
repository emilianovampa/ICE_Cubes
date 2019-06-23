using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrbaCrucero.model
{
    class Viaje
    {
        [System.ComponentModel.DisplayName("Fecha de Inicio")]
        public Nullable<DateTime> fechaInicio { get; set; }

        [System.ComponentModel.DisplayName("Fecha de Fin")]
        public Nullable<DateTime> fechaFin { get; set; }

        [System.ComponentModel.DisplayName("Crucero")]
        public Crucero crucero { get; set; }

        [System.ComponentModel.DisplayName("Recorrido")]
        public Recorrido recorrido { get; set; }

        public Viaje(Crucero crucero, Recorrido recorrido, Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaFin)
        {
            this.crucero = crucero;
            this.recorrido = recorrido;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }
        
    }
}

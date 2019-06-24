using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FrbaCrucero.model
{
    class Viaje
    {
//        [System.ComponentModel.DisplayName("Fecha de Inicio")]
        public Nullable<DateTime> fechaInicio ;

       public Nullable<DateTime> fechaFin ;

//        [System.ComponentModel.DisplayName("Crucero")]
        public Crucero crucero;

//        [System.ComponentModel.DisplayName("Recorrido")]
        public Recorrido recorrido;

        public Viaje(Crucero crucero, Recorrido recorrido, Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaFin)
        {
            this.crucero = crucero;
            this.recorrido = recorrido;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }
        
    }
}

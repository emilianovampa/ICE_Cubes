using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.model
    class Recorrido
    {
        public HashSet<Tramo> tramos = new HashSet<Tramo> { };
        private Boolean estado = true;

        public void eliminarRecorrido()
        {
            estado = false;
            /* Agregar todo lo que sucede cuando se elimina un recorrido*/
        }

        public HashSet<Tramo> getTramos()
        {
            return tramos;
        }

        private Puerto getOrigen()
        {
            return tramos.First().origen;
        }
        private Puerto getDestino()
        {
            return tramos.Last().destino;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.model
{
    class Tramo
    {
        public Tramo(Puerto origen, Puerto destino, double precio)
        {
            this.origen = origen;
            this.destino = destino;
            this.precio = precio;
        }

        public double precio { get; set; }
        public Puerto origen { get; set; }
        public Puerto destino { get; set; }
    }     
}

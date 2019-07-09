using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.model
{
    public class Tramo
    {
        public Tramo(int nivel,Puerto origen, Puerto destino, decimal precio)
        {
            this.nivel = nivel;
            this.origen = origen;
            this.destino = destino;
            this.precio = precio;
        }
        [System.ComponentModel.DisplayName("Nivel")]
        public int nivel { get; set; }
        [System.ComponentModel.DisplayName("Origen")]
        public Puerto origen { get; set; }
        [System.ComponentModel.DisplayName("Destino")]
        public Puerto destino { get; set; }
        [System.ComponentModel.DisplayName("Precio")]
        public decimal precio { get; set; }

        public Boolean pasaPor(Puerto puerto)
        {
            return (origen.idPuerto.Equals(puerto.idPuerto) || destino.idPuerto.Equals(puerto.idPuerto));
        }
    }     
}

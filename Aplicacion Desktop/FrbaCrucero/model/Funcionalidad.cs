using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.model
{
    public class Funcionalidad
    {
        public decimal FUNCION_ID { get; set; }
        public string FUNCION_NOMBRE { get; set; }

        public Funcionalidad(decimal p1, string p2)
        {
            // TODO: Complete member initialization
            this.FUNCION_ID = p1;
            this.FUNCION_NOMBRE = p2;
        } 




    }
}

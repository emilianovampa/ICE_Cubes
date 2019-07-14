using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.model
{
    public class Cabina
    {
        public decimal numero { get; set; }
        public decimal piso {get; set;}
        public TipoCabina tipo { get; set; }
        
        public int cabinaID { get; set; }
        public int cruceroId { get; set; }
        //public decimal p3 { get; set; }
        //public int p4 { get; set; }
        //public decimal p5 { get; set; }

        public Cabina(int p1, int p2, decimal p3, int p4, decimal p5)
        {
            // TODO: Complete member initialization
            this.cabinaID = p1;
            this.cruceroId = p2;
            this.numero = p3;
            this.tipo = (TipoCabina)p4;
            this.piso = p5;
        }


 
    }
}

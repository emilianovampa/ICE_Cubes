using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.model
{
    public class Crucero
    {
        [System.ComponentModel.DisplayName("Codigo Crucero")]
        public int id { get; set; }

        [System.ComponentModel.DisplayName("Identificador")]
        public Int32 identificador { get; set;}

//        [System.ComponentModel.DisplayName("Cabinas")]
        public HashSet<Cabina> cabinas = new HashSet<Cabina>();

//        [System.ComponentModel.DisplayName("Estado")]
        public EstadoCrucero estado;

        [System.ComponentModel.DisplayName("Fecha de Alta")]
        public Nullable<DateTime> fechaAlta { get; set;}

//        [System.ComponentModel.DisplayName("Marca")]
        public Marca marca;

//        [System.ComponentModel.DisplayName("Tipo de Servicio")]
        public TipoServicio servicio;

        public Crucero(int CruceroID)
        {
            // TODO: Complete member initialization
            this.id = CruceroID;
        }
    }
}

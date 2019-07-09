using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.model;

namespace FrbaCrucero
{
    public class ViajeController : SeleccionadorRecorrido
    {
        Recorrido recorridoSeleccionado = null;
        public void recibirRecorridoSeleccionado(Recorrido recorrido)
        {
            recorridoSeleccionado = recorrido;
        }
    }
}

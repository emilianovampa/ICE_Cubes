using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FrbaCrucero.model;

namespace FrbaCrucero
{
    public interface SeleccionadorRecorrido
    {
        void recibirRecorridoSeleccionado(Recorrido recorrido);
    }
}

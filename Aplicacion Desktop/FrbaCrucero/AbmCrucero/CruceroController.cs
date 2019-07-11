using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FrbaCrucero.model;
using System.ComponentModel;

namespace FrbaCrucero.AbmCrucero
{
    class CruceroController
    {
        private   CruceroView vista;
        private   Crucero crucero;

        public    CruceroController(CruceroView cruceroView,Crucero crucero)
        {
                // TODO: Complete member initialization
        this.vista = cruceroView;
        this.crucero = crucero;
        }
        internal void inicializarDatos()
        {
            vista.setearListadoMarcas(new BindingSource(new BindingList<Marca>(Marca.getMarcas()), null), 
                                      crucero.marca.idMarca);
        }
    }
}

using FrbaCrucero.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    public class ComprarPasajeController
    {
        private CompraPasaje.ComprarPasajeVista comprarPasajeVista;
        public SeleccionadorDePuerto caller;
        public ComprarPasajeController(CompraPasaje.ComprarPasajeVista comprarPasajeVista)
        {
            // TODO: Complete member initialization
            this.comprarPasajeVista = comprarPasajeVista;
        }

        internal void seleccionarPuertos()
        {
            
            new SeleccionarPuertoView(caller).ShowDialog();
        }

        public BindingSource getViajes(DateTime fechaDesde, DateTime FechaHasta, string POrigen, string Pdestino)
        {
            BindingList<Viaje> viajes = new BindingList<Viaje>(Viaje.getViajesActvos(fechaDesde, FechaHasta, POrigen,Pdestino));
            return new BindingSource(viajes, null);
        }
    }
}

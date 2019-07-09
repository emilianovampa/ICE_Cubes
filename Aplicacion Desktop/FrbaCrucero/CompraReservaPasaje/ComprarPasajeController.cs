using FrbaCrucero.CompraPasaje;
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
    public class ComprarPasajeController : SeleccionadorDePuerto
    {
        private ComprarPasajeVista unaComprarPasajeVista;
        //public SeleccionadorDePuerto caller;
        private Puerto puertoSeleccionado = null;
        private Viaje unViaje;
        private Tramo unTramo;
        private Recorrido unRecorrido;
        private Crucero unCrucero;


        public ComprarPasajeController(ComprarPasajeVista comprarPasajeVista)
        {
            // TODO: Complete member initialization
            this.unaComprarPasajeVista = comprarPasajeVista;
            this.unTramo = new Tramo();
        }

        internal void seleccionarPuertos()
        {
            SeleccionarPuertoView buscadorPuerto = new SeleccionarPuertoView(this);
            unaComprarPasajeVista.Hide();
            buscadorPuerto.ShowDialog();
            unaComprarPasajeVista.Show();
        }

        public void seleccionarPuerto(Puerto puerto)
        {
            this.puertoSeleccionado = puerto;
        }

        public BindingSource getViajes(DateTime fechaDesde, DateTime FechaHasta)
        {

            BindingList<Viaje> viajes = new BindingList<Viaje>(Viaje.getViajesActvos(fechaDesde, FechaHasta, unTramo));
            return new BindingSource(viajes, null);
        }

        internal void SetDestino()
        {
            if (this.puertoSeleccionado != null)
            {
                unTramo.destino = this.puertoSeleccionado;
                unaComprarPasajeVista.setPuertoDestino(this.puertoSeleccionado);
                this.puertoSeleccionado = null;
            }
        }

        internal void SetOrigen()
        {
            if (this.puertoSeleccionado != null)
            {
                unTramo.origen = this.puertoSeleccionado;
                unaComprarPasajeVista.SetPuertoOrigen(this.puertoSeleccionado);
                this.puertoSeleccionado = null;
            }
           
            
        }

        internal Boolean ValidarFechas(DateTimePicker FechHastaDTP, DateTimePicker FechaDesdeDTP)
        {
            return (FechaDesdeDTP.Value <= FechHastaDTP.Value);
        }

        internal Boolean ValidarPuertos()
        {
            return ( (unTramo.origen != null ) && ( unTramo.destino != null) );
        }
    }
}

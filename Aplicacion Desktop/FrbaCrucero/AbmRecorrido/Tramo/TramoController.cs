using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.model;
using System.Windows.Forms;

namespace FrbaCrucero
{
    public class TramoController : SeleccionadorDePuerto
    {
        private Puerto puertoSeleccionado = null;
        private TramoView vista;
        private Tramo tramo;
        private Tramo tramoReal;

        public TramoController(TramoView vista, Tramo tramo)
        {
            this.vista = vista;
            this.tramoReal = tramo;
            this.tramo = new Tramo(tramo.nivel, tramo.origen, tramo.destino, tramo.precio);
        }

        public void seleccionarPuerto(Puerto puerto)
        {
            this.puertoSeleccionado = puerto;
        }


        public void setearDatosIniciales()
        {
            if (tramo.origen != null)
            {
                vista.setOrigen(tramo.origen.nombre);
            }
            if (tramo.destino != null)
            {
                vista.setDestino(tramo.destino.nombre);
            }
            vista.setPrecio(tramo.precio.ToString());

        }

        public void buscarPuerto()
        {
            SeleccionarPuertoView buscadorPuerto = new SeleccionarPuertoView(this);
            vista.Hide();
            buscadorPuerto.ShowDialog();
            vista.Show();
        }

        public void setOrigen()
        {
            if (puertoSeleccionado != null)
            {
                tramo.origen = puertoSeleccionado;
                vista.setOrigen(tramo.origen.nombre);
                puertoSeleccionado = null;
            }
        }

        public void setDestino()
        {
            if (puertoSeleccionado != null)
            {
                tramo.destino = puertoSeleccionado;
                vista.setDestino(tramo.destino.nombre);
                puertoSeleccionado = null;
            }
        }

        public void setPrecio()
        {
            double p;
            if (double.TryParse(vista.getPrecio(), out p))
            {
                tramo.precio = p;
            }
            else
            {
                vista.setPrecio(tramo.precio.ToString());
                MessageBox.Show("El precio debe ser numerico", "Error al ingresar Precio");
            }
        }

        public bool puedeAceptar()
        {
            String mensajeError = "";
            if (tramo.origen == null)
            {
                mensajeError = mensajeError + "Debe ingresar Origen \n";
            }
            if (tramo.destino == null)
            {
                mensajeError = mensajeError + "Debe ingresar Destino \n";
            }

            if (tramo.origen != null && tramo.destino != null && tramo.origen.idPuerto == tramo.destino.idPuerto)
            {
                mensajeError = mensajeError + "El Origen y Destino no pueden ser el mismo\n";
            }

            if (tramo.precio <= 0)
            {
                mensajeError = mensajeError + "El precio debe ser mayor a 0 \n";
            }

            if (mensajeError != "")
            {
                MessageBox.Show(mensajeError,"Error al Aceptar");
            }  
            return ( mensajeError =="");
        }

        public void transferirTramo()
        {
            tramoReal.nivel = tramo.nivel;
            tramoReal.origen = tramo.origen;
            tramoReal.destino = tramo.destino;
            tramoReal.precio = tramo.precio;
        }
    }
}

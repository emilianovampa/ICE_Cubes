using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.model;
using System.ComponentModel;
using System.Windows.Forms;
using FrbaCrucero;

namespace FrbaCrucero{
    public class RecorridoController
    {
        private RecorridoView vista;
        private SeleccionadorRecorrido caller;
        private Recorrido recorrido;
        private BindingList<Tramo> tramos;
        public RecorridoController(RecorridoView vista, SeleccionadorRecorrido caller, Recorrido recorrido)
        {
            this.vista = vista;
            this.caller = caller;
            this.recorrido = recorrido;
        }

        public void setearDatosIniciales()
        {
            vista.setNroRecorrido(recorrido.id.ToString(), recorrido.getEstado());
            
            if(recorrido.id == 0)
            {
                vista.setTramos(inicializarTramos());
                vista.eliminarOnOff(false);
            }
            if (recorrido.id > 0)
            {
                vista.setTramos(getTramos());
                vista.eliminarOnOff(recorrido.getEstado());
            }
            vista.estadoCampos(recorrido.getEstado());
        }

        public BindingSource inicializarTramos()
        {
            tramos = new BindingList<Tramo>();
            return new BindingSource(tramos, null);
        }

        public BindingSource getTramos()
        {
            tramos = new BindingList<Tramo>(recorrido.getTramos());
            return new BindingSource(tramos, null);
        }

        public void eliminar()
        {
            recorrido.eliminarRecorrido();
            vista.eliminarOnOff(false);
        }

        internal void edit(int p)
        {
            TramoView edicionTramo = new TramoView(tramos[p]);
            vista.Hide();
            edicionTramo.ShowDialog();
            vista.Show();
            if (p > 0)
            {
                tramos[p - 1].destino = tramos[p].origen;
            }
            if (p < tramos.Count() - 1)
            {
                tramos[p + 1].origen = tramos[p].destino;
            }
        }

        internal void delete(int p)
        {
            if (p != tramos.Count() - 1)
            {
                tramos[p + 1].origen = tramos[p].origen;
            }
            tramos.RemoveAt(p);
            int i = 0;
            foreach (Tramo tramo in tramos)
            {
                tramo.nivel = i++;
            }

        }

        internal void agregarLinea()
        {
            int proxNivel = 0;
            Puerto puertoOrigen = null;
            if (tramos.Count() > 0){
             proxNivel = tramos.Last<Tramo>().nivel +1;
             puertoOrigen = tramos.Last<Tramo>().destino;
            }
            tramos.Add(new Tramo(proxNivel, puertoOrigen, null, 0));
        }

        internal bool puedeGuardar()
        {
            string mensaje = "";
            if (tramos.Count() == 0)
            {
                mensaje = "Debe tener al menos un tramo\n";
            }

            foreach (Tramo tramo in tramos)
            {
                if (tramo.origen == null)
                {
                    mensaje = mensaje + "Origen del nivel " + tramo.nivel.ToString() + " no valido\n";
                }
                if (tramo.destino == null)
                {
                    mensaje = mensaje + "Destino del nivel " + tramo.nivel.ToString() + " no valido\n";
                }
                if (tramo.precio == 0)
                {
                    mensaje = mensaje + "Precio del nivel " + tramo.nivel.ToString() + " no valido \n";
                }

            }
            if (mensaje != "")
            {
                MessageBox.Show(mensaje, "Error al Guardar");
            }  
            return mensaje == "";
        }

        internal void guardar()
        {
            recorrido.setTramos(tramos.ToList<Tramo>());
            recorrido.id = recorrido.guardarRecorrido();
            vista.setNroRecorrido(recorrido.id.ToString(), recorrido.getEstado());
            vista.eliminarOnOff(recorrido.getEstado());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero.model;
using System.ComponentModel;
using System.Windows.Forms;
using FrbaCrucero;

namespace FrbaCrucero
{
    class SeleccionarPuertoController
    {
        private SeleccionarPuertoView vista;
        private SeleccionadorDePuerto caller;

        public SeleccionarPuertoController(SeleccionarPuertoView vista, SeleccionadorDePuerto caller)
        {
            this.vista = vista;
            this.caller = caller;
        }
        
        public BindingSource getPuertosActivos(String puerto)
        {
            BindingList<Puerto> puertos = new BindingList<Puerto>(Puerto.getPuertosActivos(puerto));
            return new BindingSource(puertos, null);
        }

        internal void aceptar()
        {
            if (!vista.idSelectedText.Text.ToString().Equals(""))
            {
                caller.seleccionarPuerto(new Puerto(int.Parse(vista.idSelectedText.Text), vista.nombreSelectedText.Text, true));
                vista.Close();
            }
            else
            {
                MessageBox.Show("Debe seleccionar un puerto","Error al Aceptar");
            }
        }
    }
}

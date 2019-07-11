using FrbaCrucero.CompraReservaPasaje;
using FrbaCrucero.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraPasaje
{
    public partial class ComprarPasajeVista : Form
    {
        public ComprarPasajeController unControllerCompraPasaje;
        public ComprarPasajeVista()
        {
            InitializeComponent();
            unControllerCompraPasaje = new ComprarPasajeController(this);
        }


        private void SeleccionPuertoB_Click(object sender, EventArgs e)
        {
            unControllerCompraPasaje.seleccionarPuertos();

        }

        private void BuscarViajesB_Click(object sender, EventArgs e)
        {
                
            
           ViajesDGV.DataSource = unControllerCompraPasaje.getViajes(FechaDesdeDTP.Value,FechHastaDTP.Value,PuertoOrigenTB.Text,
                PuertoDestinoTB.Text);
        }
    }
}

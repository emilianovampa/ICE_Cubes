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
            this.FechaDesdeDTP.Value = Program.dia.Date;
            this.FechHastaDTP.Value = Program.dia.Date;
        }


        private void SeleccionPuertoB_Click(object sender, EventArgs e)
        {
            unControllerCompraPasaje.seleccionarPuertos();
            unControllerCompraPasaje.SetOrigen();

        }

        private void BuscarViajesB_Click(object sender, EventArgs e)
        {

            if (unControllerCompraPasaje.ValidarFechas(FechHastaDTP, FechaDesdeDTP))
            {

                if (unControllerCompraPasaje.ValidarPuertos())
                {
                    ViajesDGV.DataSource = unControllerCompraPasaje.getViajes(FechaDesdeDTP.Value, FechHastaDTP.Value);
                }
                else
                    MessageBox.Show(" Debe completar Puerto Origen y Puerto Destino");

            }

            else
                MessageBox.Show("La Fecha Desde debe ser menor a la Fecha Hasta");

           
        }

        private void ViajesDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CancelarB_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            unControllerCompraPasaje.seleccionarPuertos();
            unControllerCompraPasaje.SetDestino();
            
        }

        internal void SetPuertoOrigen(Puerto puerto)
        {
            this.PuertoOrigenTB.Text = puerto.nombre;
        }

        internal void setPuertoDestino(Puerto puerto)
        {
            this.PuertoDestinoTB.Text = puerto.nombre;
        }
    }
}

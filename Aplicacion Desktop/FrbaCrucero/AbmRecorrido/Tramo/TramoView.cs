using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.model;

namespace FrbaCrucero
{
    public partial class TramoView : Form
    {
        public TramoController controller;

        public TramoView(Tramo tramo)
        {
            InitializeComponent();
            controller = new TramoController(this, tramo);
            controller.setearDatosIniciales();
        }

        public void setOrigen(string puerto)
        {
            textOrigen.Text = puerto;
        }

        public void setDestino(string puerto)
        {
            textDestino.Text = puerto;
        }
        public void setPrecio(string precio)
        {
            textPrecio.Text = precio;
        }

        public string getPrecio()
        {
            return textPrecio.Text;
        }

        private void textPrecio_TextChanged(object sender, EventArgs e)
        {
            controller.setPrecio();
        }

        private void buscarOrigen_Click(object sender, EventArgs e)
        {
            controller.buscarPuerto();
            controller.setOrigen();
        }
        private void buscarDestino_Click(object sender, EventArgs e)
        {
            controller.buscarPuerto();
            controller.setDestino();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (controller.puedeAceptar())
            {
                controller.transferirTramo();
                this.Close();
            }
        }



    }
}

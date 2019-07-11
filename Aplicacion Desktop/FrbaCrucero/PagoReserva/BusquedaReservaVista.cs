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

namespace FrbaCrucero.PagoReserva
{
    public partial class BusquedaReservaVista : Form
    {
       public BusquedaReservaCtrl unControlerReserva;

        public BusquedaReservaVista() {

            InitializeComponent();
            unControlerReserva = new BusquedaReservaCtrl(this);
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BuscarBoton_Click(object sender, EventArgs e)
        {
             if (!String.IsNullOrWhiteSpace(NroReservaTextBox.Text))
             {
                 dataGridView1.DataSource = unControlerReserva.getReserva(NroReservaTextBox.Text);
                 }

        }

        private void PagarBoton_Click(object sender, EventArgs e)
        {

        }
    }
}

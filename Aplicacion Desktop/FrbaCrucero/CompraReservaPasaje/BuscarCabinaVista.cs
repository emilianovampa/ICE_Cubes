using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class BuscarCabinaVista : Form
    {
        private ComprarPasajeController comprarPasajeController;

        public BuscarCabinaVista()
        {
            InitializeComponent();
            
        }

        public BuscarCabinaVista(ComprarPasajeController comprarPasajeController)
        {
            // TODO: Complete member initialization
            this.comprarPasajeController = comprarPasajeController;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class SeleccionarPuertoView : Form
    {
        private SeleccionarPuertoController controller;

        public SeleccionarPuertoView(SeleccionadorDePuerto caller)
        {
            InitializeComponent();
            controller = new SeleccionarPuertoController(this, caller);
            this.listaDePuertos.DataSource = controller.getPuertosActivos("");
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            this.listaDePuertos.DataSource = controller.getPuertosActivos(this.textNombrePuerto.Text);
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            controller.aceptar();
        }

        private void listaDePuertos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
          if (e.RowIndex >= 0) {
          DataGridViewRow row = this.listaDePuertos.Rows[e.RowIndex];
          nombreSelectedText.Text = row.Cells["Nombre"].Value.ToString();
          idSelectedText.Text = row.Cells["idPuerto"].Value.ToString();
          }
        }

        private void Limpiar_Click(object sender, EventArgs e)
        {
            nombreSelectedText.Text = "";
            idSelectedText.Text = "";
            textNombrePuerto.Text = "";
            this.listaDePuertos.DataSource = controller.getPuertosActivos("");
        }







    }
}

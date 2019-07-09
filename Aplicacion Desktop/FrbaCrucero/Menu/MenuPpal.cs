using FrbaCrucero.AbmRol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.PagoReserva;
using FrbaCrucero;

namespace FrbaCrucero.Menu
{
    public partial class MenuPpal : Form
    {    
        public MenuPpal(Usuario unUsuarioVista2)
        {
            InitializeComponent();
            MenuController menuCentralController = new MenuController(unUsuarioVista2,this);
            this.btn_compraReserva.Visible = menuCentralController.soyVisible(1);
            this.btn_pagoReserva.Visible = menuCentralController.soyVisible(2);
            this.btn_abmPuerto.Visible = menuCentralController.soyVisible(3);
            this.btn_abmRol.Visible = menuCentralController.soyVisible(4);
            this.btn_abmUsuario.Visible = menuCentralController.soyVisible(5);
            this.btn_abmRecorrido.Visible = menuCentralController.soyVisible(6);
            this.btn_abmCrucero.Visible = menuCentralController.soyVisible(7);
            this.btn_altaViaje.Visible = menuCentralController.soyVisible(8);
            this.btn_reporting.Visible = menuCentralController.soyVisible(9);
          }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_abmRol_Click(object sender, EventArgs e)
        {
            new AbmRolForm().ShowDialog();
        }

        private void btn_pagoReserva_Click(object sender, EventArgs e)
        {
            new BusquedaReservaVista().ShowDialog();
        }

        private void btn_abmRecorrido_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ListadoRecorridosView(ModoInteraccion.MODIFICAR, null).ShowDialog();
            this.Show();
        }

        private void btn_abmCrucero_Click(object sender, EventArgs e)
        {

        }

        private void btn_altaViaje_Click(object sender, EventArgs e)
        {

        }

        private void btn_reporting_Click(object sender, EventArgs e)
        {

        }

        private void btn_compraReserva_Click(object sender, EventArgs e)
        {

        }

        private void btn_abmPuerto_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No implementado");

        }

        private void btn_abmUsuario_Click(object sender, EventArgs e)
        {
            MessageBox.Show("No implementado");
        }
    }
}

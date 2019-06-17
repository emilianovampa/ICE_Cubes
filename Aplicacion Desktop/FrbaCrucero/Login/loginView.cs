using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero;


namespace FrbaCrucero
{
    public partial class loginView : Form
    {
        public loginView()
        {
            InitializeComponent();

            //Binding bindingTest = new Binding
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clienteboton_Click(object sender, EventArgs e)
        {

        }

        private void usuarioTextB_TextChanged(object sender, EventArgs e)
        {
        }

        private void vendedorboton_Click(object sender, EventArgs e)
        {
            habilitarOpcionesVendedor();
        }

        private void passTextB_TextChanged(object sender, EventArgs e)
        {

        }

        private void ingresarboton_Click(object sender, EventArgs e)
        {

            
        }

        private void cancelarBoton_Click(object sender, EventArgs e)
        {

        }

        private void habilitarOpcionesVendedor () {
          this.ingresarboton.Visible = true;
          this.userLabel.Visible = true;
          this.userPassLabel.Visible = true;
          this.passLabel.Visible = true;
          this.passTextB.Visible = true;
          this.usuarioTextB.Visible = true;          
        }
    }
}

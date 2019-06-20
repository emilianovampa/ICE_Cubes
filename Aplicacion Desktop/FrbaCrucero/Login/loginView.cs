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
        //usuario unUsuario = new usuario();
        loginController UnControllerLogin;
        public loginView()
        {
            InitializeComponent();
            UnControllerLogin = new loginController(this);

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

            if (!String.IsNullOrWhiteSpace(usuarioTextB.Text) && !String.IsNullOrWhiteSpace(passTextB.Text))
            {
            
             UnControllerLogin.Ingresar(this.usuarioTextB.Text, this.passTextB.Text);
                       
                

            }

            else{
                MessageBox.Show("Ingrese Datos de Login");
            }




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

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

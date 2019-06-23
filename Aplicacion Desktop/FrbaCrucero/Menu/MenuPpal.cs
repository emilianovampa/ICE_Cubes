using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.Menu
{
    public partial class MenuPpal : Form
    {
      
                    

        public MenuPpal()
        {

            //InitializeComponent();


         }

        public MenuPpal(usuario unUsuarioVista2)
        {
            InitializeComponent();
            MenuController menuCentralController = new MenuController(unUsuarioVista2,this);
            this.button1.Visible = menuCentralController.soyVisible(1);
            this.button2.Visible = menuCentralController.soyVisible(2);
            this.button3.Visible = menuCentralController.soyVisible(3);
            this.button4.Visible = menuCentralController.soyVisible(4);
            this.button5.Visible = menuCentralController.soyVisible(5);
            this.button6.Visible = menuCentralController.soyVisible(6);
            this.button7.Visible = menuCentralController.soyVisible(7);
            this.button8.Visible = menuCentralController.soyVisible(8);
            this.button9.Visible = menuCentralController.soyVisible(9);

            
           

            

          }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

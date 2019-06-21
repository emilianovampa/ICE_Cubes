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
    public partial class MenuCentral : Form
    {
        public MenuCentral()
        {
            
            InitializeComponent();
            new loginView().ShowDialog();
        }
    }
}

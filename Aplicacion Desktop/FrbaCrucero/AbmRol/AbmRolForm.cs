using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmRol
{
    public partial class AbmRolForm : Form
    {
        public AbmRolForm()
        {
            InitializeComponent();
        }

        private void btn_altaRol_Click(object sender, EventArgs e)
        {
            new AltaRolView().ShowDialog();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}

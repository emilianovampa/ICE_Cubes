using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.AbmCrucero.Baja
{
    public partial class BajaCrucero : Form
    {
        public BajaCrucero()
        {
            InitializeComponent();
        }

        private void darBaja_CheckedChanged(object sender, EventArgs e)
        {
            visibilidadCamposBaja(darBaja.Checked);
        }

        private void visibilidadCamposBaja(bool p)
        {
            permanente.Visible = p;
            fechaRegresoLabel.Visible = p;
            fechaRegreso.Visible = p;
            corrimiento.Visible = p;
            corrimientoLabel.Visible = p;
            motivo.Visible = p;
            motivoLabel.Visible = p;
        }
    }
}

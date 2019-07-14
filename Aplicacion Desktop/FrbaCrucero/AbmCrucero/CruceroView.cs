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

namespace FrbaCrucero.AbmCrucero
{
    public partial class CruceroView : Form
    {
        CruceroController controller;
        public CruceroView(Crucero crucero)
        {
            InitializeComponent();
            controller = new CruceroController(this, crucero);
            controller.inicializarDatos();
        }

        internal void setearListadoMarcas(BindingSource marcas, int idMarca)
        {
            MarcasCombo.DataSource = marcas;
            MarcasCombo.SelectedValue = idMarca;
        }

        internal void setearListadoServicios(BindingSource servicios, int idServicio)
        {
            ServicioCombo.DataSource = servicios;
            ServicioCombo.SelectedValue = idServicio;
        }

        

    }
}

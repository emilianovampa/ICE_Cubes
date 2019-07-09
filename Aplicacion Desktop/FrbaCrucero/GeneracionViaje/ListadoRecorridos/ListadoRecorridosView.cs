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
    public partial class ListadoRecorridosView : Form
    {
        private ListadoRecorridoController controller;
        
        public ListadoRecorridosView(ModoInteraccion modo, SeleccionadorRecorrido caller)
        {
            InitializeComponent();
            controller = new ListadoRecorridoController(this, caller, modo);
            controller.inicializarDatos();
        }

        //Visibilidad de botones
        public void habilitarBotonesABM(Boolean estado)
        {
            agregarNuevo.Visible = estado;
            Recorridos.Columns[1].Visible = estado; //boton Editar Recorrido
        }

        public void habilitarBotonesSeleccion(Boolean estado)
        {
            Aceptar.Visible = estado;
        }

        public void habilitarTransferir(Boolean estado)
        {
            Aceptar.Enabled = estado;
        }

        //Ejecución de Botones
        private void BuscarOrigen_Click(object sender, EventArgs e)
        {
            controller.buscarPuerto();
            controller.setOrigen();
        }

        private void BuscarDestino_Click(object sender, EventArgs e)
        {
            controller.buscarPuerto();
            controller.setDestino();
        }

        private void pasaPorBuscar_Click(object sender, EventArgs e)
        {
            controller.buscarPuerto();
            controller.setPasaPor();
        }

        private void Recorridos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (e.ColumnIndex == 0) //select
                {
                    controller.select(e.RowIndex);
                }
                if (e.ColumnIndex == 1) //edit
                {
                    controller.edit(e.RowIndex);
                }
            }
        }

        private void BuscarRecorridos_Click(object sender, EventArgs e)
        {
            controller.buscarRecorridos();
        }

        private void LimpiarBusqueda_Click(object sender, EventArgs e)
        {
            controller.limpiarDatos();
        }

        private void agregarNuevo_Click(object sender, EventArgs e)
        {
            controller.agregarNuevoRecorrido();
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            controller.transferirSeleccionado();
        }

        //Setters y getters
        public void setEstadoDefault()
        {
            EstadoBox.SelectedIndex = 0;

        }

        public int getEstado()
        {
            return EstadoBox.SelectedIndex;
        }


        public void setRecorridos(BindingSource recorridos)
        {
            Recorridos.DataSource = recorridos;

        }

        public void setRecorridoSeleccionado(BindingSource tramos)
        {
            recorridoSeleccionado.DataSource = tramos;
        }
        internal void setOrigen(string puerto)
        {
            PuertoOrigen.Text = puerto;
        }
        
        internal void setDestino(string puerto)
        {
            PuertoDestino.Text = puerto;
        }
        
        internal void setPasaPor(string puerto)
        {
            PasaPor.Text = puerto;
        }

        internal void setPrecioDesde(decimal precio)
        {
            if (precio > 0)
            {            
                precioDesde.Text = precio.ToString();
            }
            else
            {
                precioDesde.Text = "";
            }
        }

        internal void setPrecioHasta(decimal precio)
        {
            if (precio > 0)
            {
                precioHasta.Text = precio.ToString();
            }
            else
            {
                precioHasta.Text = "";
            }
        }

        private void precioDesde_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void precioHasta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
                (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void precioDesde_TextChanged(object sender, EventArgs e)
        {
            controller.setPrecioDesde(precioDesde.Text);

        }

        private void precioHasta_TextChanged(object sender, EventArgs e)
        {
            controller.setPrecioHasta(precioHasta.Text);
        }


    }
}

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
using FrbaCrucero;

namespace FrbaCrucero
{
    public partial class RecorridoView : Form
    {
        public RecorridoController controller;
        
        public RecorridoView(Recorrido recorrido, ModoInteraccion modo)
        {
            InitializeComponent();
            controller = new RecorridoController(this, recorrido);
            controller.setearDatosIniciales();
            if(modo.Equals(ModoInteraccion.VISUALIZAR))
            {
                readOnly();
            }   
        }

        public void setNroRecorrido(String nro, Boolean estado)
        {
            nroRecorrido.Text = nro;
            if (estado && nroRecorrido.Text.Equals("0"))
            {
                EstadoText.Text = "Nuevo";
            }
            else if (estado)
            {
                EstadoText.Text = "Activo";
            }
            else
            {
                EstadoText.Text = "Eliminado";
            }
        }

        public void setTramos(BindingSource tramos)
        {
            gridTramos.DataSource = tramos;
            
        }

        public void eliminarOnOff(Boolean activado)
        {
            this.EliminarButton.Enabled = activado;
        }

        public void estadoCampos(Boolean activado)
        {
            this.Guardar.Enabled = activado;
            this.addLine.Enabled = activado;
            this.gridTramos.Columns[0].Visible = activado;
            this.gridTramos.Columns[1].Visible = activado;
        }

        public void readOnly()
        {
            this.EliminarButton.Visible = false;
            this.Guardar.Visible = false;
            this.addLine.Visible = false;
            this.gridTramos.Columns[0].Visible = false;
            this.gridTramos.Columns[1].Visible = false;
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            controller.eliminar();
        }

        private void addLine_Click(object sender, EventArgs e)
        {
            controller.agregarLinea();
        }

        private void gridTramos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0) //edit
            {
                controller.edit(e.RowIndex);
            }
            if (e.ColumnIndex == 1) //delete
            {
                controller.delete(e.RowIndex);
            }
        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            if (controller.puedeGuardar())
            {
                controller.guardar();
            }
        }


    }
}

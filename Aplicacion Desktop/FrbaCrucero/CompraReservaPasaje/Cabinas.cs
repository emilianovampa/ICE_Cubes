﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.model;

namespace FrbaCrucero.CompraReservaPasaje
{
    public partial class Cabinas : Form
    {
        Viaje viaje;
        List<Cabina> cabinas;
        
        public Cabinas(Int32 idViaje)
        {
            InitializeComponent();
            this.viaje =  Viaje.getViaje(idViaje);
            this.cabinas = Viaje.buscarCabinasDisponibles(idViaje);
            DataTable tablaCabinas = new DataTable();
            tablaCabinas.Columns.Add("codCabina");
            tablaCabinas.Columns.Add("Piso");
            tablaCabinas.Columns.Add("Numero");
            tablaCabinas.Columns.Add("codTipo");
            tablaCabinas.Columns.Add("Tipo de cabina");

            grilla.DataSource = tablaCabinas;
            grilla.Columns["codCabina"].Visible = false;
            grilla.Columns["codTipo"].Visible = false;

            foreach (Cabina cabina in cabinas)
            {
                tablaCabinas.Rows.Add(new Object[] { 
                    cabina.cabinaID, 
                    cabina.piso,    
                    cabina.numero, 
                    cabina.tipo, 
                    cabina.tipo.ToString()
                });
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Cabina> cabinasSeleccionadas = new List<Cabina>();
            foreach (DataGridViewRow fila in grilla.Rows)
            {
                String comprar = fila.Cells[0].Value == DBNull.Value ? "f" : (String) fila.Cells[0].Value;

                if (comprar == "t")
                {
                    cabinasSeleccionadas.Add(this.cabinas[fila.Index]);
                }
            }
            if (cabinasSeleccionadas.Count == 0)
                MessageBox.Show("No selecciono ninguna cabina");
            else
            {
                DialogResult result = Program.openNextWindow(this, new DNI(this.viaje, cabinasSeleccionadas));
                if (result == DialogResult.OK)
                    this.DialogResult = DialogResult.OK;
            }
        }

        private void grilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}

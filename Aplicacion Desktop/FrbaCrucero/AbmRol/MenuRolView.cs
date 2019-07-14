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
    public partial class MenuRolView : Form
    {
        public MenuRolView()
        {
            InitializeComponent();
            updateDataGridView();
        }

        public void updateDataGridView()
        {
            BindingList<Rol> roles = new BindingList<Rol>(new Rol().traerRoles());
            this.dataGridView.DataSource = new BindingSource(roles, null);
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            AltaRolView altaRolView = new AltaRolView(this);
            altaRolView.Show();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == this.checkBoxColumnEliminar.Index)
            {
                new Rol().eliminarRol(this.dataGridView.Rows[e.RowIndex].DataBoundItem as Rol);
                updateDataGridView();
            }

            if (e.ColumnIndex == this.btnColumnModificar.Index)
            {
                new ModificacionRolView(this, this.dataGridView.Rows[e.RowIndex].DataBoundItem as Rol).Show();
            }
        }

        
    }
}

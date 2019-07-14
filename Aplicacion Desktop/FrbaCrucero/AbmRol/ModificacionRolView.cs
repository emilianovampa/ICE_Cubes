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
using System.Data.SqlClient;

namespace FrbaCrucero.AbmRol
{
    public partial class ModificacionRolView : Form
    {
        private Rol rol;
        private List<Funcionalidad> funcionalidades;
        private List<Funcionalidad> funcSeleccionadas;
        private MenuRolView menuRolView;

        public ModificacionRolView(MenuRolView menuRolView, Rol rol)
        {
            InitializeComponent();
            this.menuRolView = menuRolView;
            funcionalidades = new Rol().traerFuncionalidades();
            funcSeleccionadas = this.rol.Funcionalidades;
            this.cmbBoxQuitarFuncs.DisplayMember = "nombreFuncionalidad";
            this.cmbBoxQuitarFuncs.ValueMember = "this";
            this.cmbBoxQuitarFuncs.DataSource = funcionalidades;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            menuRolView.updateDataGridView();
            this.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                //this.validar();
                new Rol().actualizarRol(new Rol(this.txtBoxDescripcion.Text, this.radioBtnSi.Checked, this.funcSeleccionadas), rol);
                MessageBox.Show("Modificado con exito");
                menuRolView.updateDataGridView();
                this.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (SystemException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void validar()
        { 
        
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBoxDescripcion.Text = "";
            this.radioBtnSi.Checked = false;
            this.cmbBoxAgregarFuncs.SelectedIndex = -1;
            this.cmbBoxQuitarFuncs.SelectedIndex = -1;
        }
        
    }
}

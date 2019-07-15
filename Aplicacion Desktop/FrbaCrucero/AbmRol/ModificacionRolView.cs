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
            this.rol = rol;
            funcionalidades = new Rol().traerFuncionalidades();
            funcSeleccionadas = this.rol.Funcionalidades;
            this.cmbBoxFuncionalidades.DisplayMember = "nombreFuncionalidad";
            this.cmbBoxFuncionalidades.ValueMember = "this";
            this.cmbBoxFuncionalidades.DataSource = funcionalidades;

            this.txtBoxDescripcion.Text = rol.RolDescripcion;
            this.cmbBoxEstado.Text = rol.Estado.ToString();
            this.actualizarTextBox();
        }

        private void actualizarTextBox()
        {
            this.txtBoxFuncionalidades.Clear();
            String total = "";
            foreach (Funcionalidad func in this.funcSeleccionadas)
            {
                total += func.NombreFuncionalidad + Environment.NewLine;
            }
            this.txtBoxFuncionalidades.Text = total;
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
                this.validar();
                new Rol().actualizarRol(new Rol(this.txtBoxDescripcion.Text, Convert.ToBoolean(cmbBoxEstado.Text), this.funcSeleccionadas), rol);
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
            if (this.txtBoxDescripcion.TextLength <= 0)
            {
                SystemException ex = new SystemException("Debes ponerle una descripcion");
                throw ex;
            }
            if (this.cmbBoxEstado.SelectedIndex == -1)
            {
                SystemException ex = new SystemException("Seleccione si el rol esta habilitado");
                throw ex;
            }

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!this.funcSeleccionadas.Any(elem => elem.NombreFuncionalidad.Equals(((Funcionalidad)this.cmbBoxFuncionalidades.SelectedValue).NombreFuncionalidad)))
            {
                this.funcSeleccionadas.Add(this.cmbBoxFuncionalidades.SelectedValue as Funcionalidad);
                this.actualizarTextBox();
            }
            else 
            {
                MessageBox.Show("Ya esta agregada esta funcionalidad");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (this.funcSeleccionadas.Any(elem => elem.NombreFuncionalidad.Equals(((Funcionalidad)this.cmbBoxFuncionalidades.SelectedValue).NombreFuncionalidad)))
            {
                this.funcSeleccionadas.Remove(this.funcSeleccionadas.Find(elem => elem.NombreFuncionalidad.Equals(((Funcionalidad)this.cmbBoxFuncionalidades.SelectedValue).NombreFuncionalidad)));
                this.actualizarTextBox();
            }
            else
            {
                MessageBox.Show("No esta seleccionado esta funcionalidad");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBoxDescripcion.Clear();
            this.cmbBoxFuncionalidades.SelectedIndex = -1;
        }

    }
}

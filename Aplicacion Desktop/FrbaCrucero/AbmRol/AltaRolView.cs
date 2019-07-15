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
    public partial class AltaRolView : Form
    {
        private List<Funcionalidad> funcionalidades;
        private List<Funcionalidad> funcSeleccionadas;
        private MenuRolView menuRol;
        private Rol rol;

        public AltaRolView(MenuRolView menuRol)
        {
            InitializeComponent();
            this.menuRol = menuRol;
            rol = new Rol();
            this.funcionalidades = rol.traerFuncionalidades();
            this.funcSeleccionadas = new List<Funcionalidad>();
            this.comboBoxFuncionalidades.DisplayMember = "nombreFuncionalidad";
            this.comboBoxFuncionalidades.ValueMember = "this";
            this.comboBoxFuncionalidades.DataSource = funcionalidades;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            menuRol.updateDataGridView();
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try 
            {
                this.validar();
                rol.cargarNuevoRol(new Rol(this.txtBoxDescripcion.Text, true, this.funcSeleccionadas));
                MessageBox.Show("Rol guardado con exito");
                menuRol.updateDataGridView();
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

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtBoxDescripcion.Clear();
            this.funcSeleccionadas.Clear();
            this.comboBoxFuncionalidades.SelectedIndex = -1;
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

        private void validar() 
        {
            if (this.txtBoxDescripcion.TextLength <= 0)
            {
                SystemException ex = new SystemException("Debes ponerle una descripcion");
                throw ex;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (!this.funcSeleccionadas.Contains(this.comboBoxFuncionalidades.SelectedValue as Funcionalidad))
            {
                this.funcSeleccionadas.Add(this.comboBoxFuncionalidades.SelectedValue as Funcionalidad);
                this.actualizarTextBox();
            }
            else 
            {
                MessageBox.Show("Ya esta agregada esta funcionalidad");
            }
        }

        private void btnQuitar_Click(object sender, EventArgs e)
        {
            if (this.funcSeleccionadas.Contains(this.comboBoxFuncionalidades.SelectedValue as Funcionalidad))
            {
                this.funcSeleccionadas.Remove(this.comboBoxFuncionalidades.SelectedValue as Funcionalidad);
                this.actualizarTextBox();
            }
            else 
            {
                MessageBox.Show("Ya esta agregada esta funcionalidad");
            }
        }

    }
}

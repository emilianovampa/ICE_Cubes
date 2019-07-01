using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FrbaCrucero.AbmRol
{
    public partial class AltaRolView : Form
    {
        // Atributos
        private RolController unRolController;
        private bool flagDescripcion;
        private bool flagFuncionalidad;

        public AltaRolView()
        {
            InitializeComponent();
            unRolController = new RolController(this);
            unRolController.cargarFuncionalidades();
        }

        private void validarRolDescripcion() {
            flagDescripcion = true;
            Regex exp = new Regex(@"\A[a-zA-Z][a-zA-Z0-9]{2,19}\Z");
            if (!exp.IsMatch(txtbox_nombre.Text))
            {
                flagDescripcion = false;
                MessageBox.Show("El campo Nombre debe contener entre 3 y 20 caracteres.");
            }
        }

        private void validarFuncionalidad()
        {
            flagFuncionalidad = true;
            if (comboBox_funcionalidades.SelectedIndex.Equals(-1))
            {
                flagFuncionalidad = false;
                MessageBox.Show("Seleccione una funcionalidad.");
            }
        }

        // Evento
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            validarRolDescripcion();
            validarFuncionalidad();
        
            if (flagDescripcion && flagFuncionalidad)
            {
                // el nombre del rol y la funcionalidad pasaron las validaciones de la vista
                unRolController.darDeAlta(txtbox_nombre.Text,comboBox_funcionalidades.SelectedItem.ToString());
            }
        }

        // Evento
        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txtbox_nombre.Text = "";
            comboBox_funcionalidades.SelectedIndex = -1;
        }

        public void agregarFuncionalidad(string nombreFuncionalidad)
        {
            comboBox_funcionalidades.Items.Add(nombreFuncionalidad);
        }

        public void mostrarMensaje(String mensaje)
        {
            MessageBox.Show(mensaje);
        }

    }
}

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
        AbmRolController unABMRolController;
        private bool flagNombre = true;             // Agrego flags para validar
        private bool flagFuncionalidades = true;    // nombre y funcionalidades en la vista

        public AltaRolView()
        {
            InitializeComponent();
            unABMRolController = new AbmRolController(this);
        }

        private void validarNombre() {
            Regex exp = new Regex(@"\A[a-zA-Z]{3,20}\Z");
            if (!exp.IsMatch(txtbox_nombre.Text))
            {
                flagNombre = false;
                MessageBox.Show("El campo Nombre debe contener entre 3 y 20 caracteres.");
            }
        }

        private void validarFuncionalidades() { 
           // Completar
            foreach (CheckBox checkBox in groupBoxFuncionalidades.Controls)
            {
                if(checkBox.Checked)
                {
                    
                }
            }

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            validarNombre();
            validarFuncionalidades();

            if (flagNombre && flagFuncionalidades)
            {
                // Los campos nombre y funcionalidades fueron completados correctamente
                
            }
        }

        public void mostrarMensaje(String mensaje)
        {
            MessageBox.Show(mensaje);
        }

    }
}

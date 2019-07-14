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

namespace FrbaCrucero.AbmRol
{
    public partial class AltaRolView : Form
    {
        private List<Funcionalidad> funcionalidades;
        private MenuRolView menuRol;
        private Rol rol;

        public AltaRolView(MenuRolView menuRol)
        {
            InitializeComponent();
            this.menuRol = menuRol;
            rol = new Rol();
            this.funcionalidades = rol.traerFuncionalidades();
            this.comboBoxFuncionalidades.DisplayMember = "nombreFuncionalidad";
            this.comboBoxFuncionalidades.ValueMember = "this";
            this.comboBoxFuncionalidades.DataSource = funcionalidades;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            menuRol.updateDataGridView();
            this.Close();
        }



    }
}

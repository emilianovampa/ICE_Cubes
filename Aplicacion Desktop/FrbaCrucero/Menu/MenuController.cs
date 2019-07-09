using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.Menu
{
    class MenuController
    {
        MenuPpal laVistacentral ;
        Usuario unUsuarioCentral ;

       public MenuController(Usuario unUsuarioVista2, MenuPpal menuPpal)
        {
            // TODO: Complete member initialization
            this.unUsuarioCentral = unUsuarioVista2;
            this.laVistacentral = menuPpal;
        }

        internal bool soyVisible(int p)
        {
            return unUsuarioCentral.poseeFuncionalidad(p);
        }
    }
}

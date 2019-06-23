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
        usuario unUsuarioCentral ;

       public MenuController(usuario unUsuarioVista2, MenuPpal menuPpal)
        {
            // TODO: Complete member initialization
            this.unUsuarioCentral = unUsuarioVista2;
            this.laVistacentral = menuPpal;
        }


        public void login (){
         
         

        
        }

        internal bool soyVisible(int p)
        {
           return unUsuarioCentral.usuarioRol.funcionalidades.Exists(X => X.FUNCION_ID == p);
        }
    }
}

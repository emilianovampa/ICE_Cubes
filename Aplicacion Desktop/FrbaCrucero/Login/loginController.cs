using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero
{
    public interface ILoginController {

        void Ingresar(string usuario, string pass);
    
    }

    public class loginController : ILoginController
    {
        loginView unaVistaLogin;
        usuario unUsuarioVista;

               public loginController()
        {
            // TODO: Complete member initialization
        }

        void Ingresar(string usuario, string pass) {

            ConexionSQLS UnaConex = new ConexionSQLS();

            
          


        }

    }
}


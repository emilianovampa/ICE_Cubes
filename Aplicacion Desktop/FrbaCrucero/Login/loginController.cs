using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrbaCrucero
{
    public interface ILoginController  {

        string Ingresar(string usuario, string pass);
    
    }

    public class loginController 
    {
        loginView unaVistaLogin;


        public loginController(loginView laVistaLogin)
        {
            unaVistaLogin = laVistaLogin;
        }

        
        public string Ingresar(string usuario, string pass)
        {
            usuario unUsuarioVista = new usuario(usuario, pass);

            MessageBox.Show(unUsuarioVista.logueate());
            return(unUsuarioVista.logueate());
        }
        
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaCrucero.Menu;


namespace FrbaCrucero
{
    public interface ILoginController  {

        string Ingresar(string usuario, string pass);
    
    }

    public class loginController 
    {
        loginView unaVistaLogin;
        Usuario unUsuarioVista2 = new Usuario();


        public loginController(loginView laVistaLogin)
        {
            unaVistaLogin = laVistaLogin;
        }


        public void Ingresar(string usuario, string pass)
        {
            Usuario unUsuarioVista = new Usuario(usuario, pass);
            unUsuarioVista2.nombreUsuario=usuario;
            unUsuarioVista2.passUsuario = pass;
            MessageBox.Show(unUsuarioVista2.logueate());
            
            if (unUsuarioVista2.usuarioRol != null ) {

                unaVistaLogin.Close();
                new MenuPpal(unUsuarioVista2).Show();
            }

        }
        
    }
}


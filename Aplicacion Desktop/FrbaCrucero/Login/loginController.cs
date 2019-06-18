using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero
{
    public interface ILoginController {

        string Ingresar(string usuario, string pass);
    
    }

    public class loginController : ILoginController
    {
        loginView unaVistaLogin;
        //usuario unUsuarioVista = new usuario();
        

        //       public loginController()
        //{
        //    // TODO: Complete member initialization
        //}

        public string Ingresar(string usuario, string pass) {
         
        try{

            SqlCommand cmd = new SqlCommand("ICE_CUBES.SP_INGRESAR_USUARIO", ConexionSQLS.getConeccion());
            cmd.CommandType = CommandType.StoredProcedure;
            // instancio parametro de salida
            SqlParameter VariableRetorno = new SqlParameter("@resultado", SqlDbType.Int);
            VariableRetorno.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(VariableRetorno);
            cmd.Parameters.Add(new SqlParameter("@usuario", usuario.ToString()));
            cmd.Parameters.Add(new SqlParameter("@password", pass));
            cmd.ExecuteNonQuery(); // aca se abre la conexion y se ejecuta el SP de login
            int resultado = (int)cmd.Parameters["@resultado"].Value;

            switch (resultado)
            {
                case 0:
                    return ("USUARIO INHABILITADO.");

                case 1:
                    //this.habilitarSeleccionDeRoles(username);
                    //this.Close();
                    usuario unUsuarioVista = new usuario(usuario, pass);
                    
                    return ("Ingreso Correcto");

                case 2:
                    return ("Login FALLIDO. Al tercer intento fallido se inhabilita la Cuenta!");
                case 3:
                    return ("NO EXISTE EL USUARIO");
                default:
                  return ("error Desconocido");

            }    
        }
        catch (SqlException ex)
        {
            string errorsql="SQL Error" + ex.Message.ToString();
            return (errorsql);
        
        }



        }

    }
}


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

        int Ingresar(string usuario, string pass);
    
    }

    public class loginController : ILoginController
    {
        loginView unaVistaLogin;
        usuario unUsuarioVista;

        //       public loginController()
        //{
        //    // TODO: Complete member initialization
        //}

        public int Ingresar(string usuario, string pass) {

        try{

       // string sp = "SP_INGRESAR_USUARIO";
       // //List<ParametroStore> parametros = new  List<ParametroStore>();
       ////parametros.Add(new ParametroStore("@@USUARIOID", usuario, ParameterDirection.Input));        
       // //parametros.Add(new ParametroStore("@USUARIOPASS", pass,ParameterDirection.Input));
       // //parametros.Add(new ParametroStore("@retorno", pass,ParameterDirection.Output));

       // Dictionary<string, object> test = new Dictionary<string, object>();

       // //SqlDataReader usarioDatosLogin = ConexionSQLS.ExecuteReader( sp, parametros);
       // int retorno = 1;
       // string idusuario = "0";
       // test.Add("@USUARIOID",usuario);
       // test.Add("@USUARIOPASS", pass);
       // test.Add("@retorno",retorno);
       // test.Add("@idUsuario", idusuario);

       // SqlDataReader usarioDatosLogin = ConexionSQLS.ExecuteReader(sp, test);

       // return 1;
            //SqlConnection conexion = ConexionSQLS.getConeccion();
            SqlCommand cmd = new SqlCommand("ICE_CUBES.SP_INGRESAR_USUARIO", ConexionSQLS.getConeccion());
            cmd.CommandType = CommandType.StoredProcedure;

            // instancio parametro de salida
            SqlParameter VariableRetorno = new SqlParameter("@resultado", SqlDbType.Int);
            VariableRetorno.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(VariableRetorno);
            //VariableRetorno = new SqlParameter("@idUsuario", SqlDbType.NVarChar,18);
            //VariableRetorno.Direction = ParameterDirection.Output;
            //cmd.Parameters.Add(VariableRetorno);
            cmd.Parameters.Add(new SqlParameter("@usuario", usuario.ToString()));
            cmd.Parameters.Add(new SqlParameter("@password", pass));
            

            //ConexionSQLS.iniciarConeccion();
            cmd.ExecuteNonQuery(); // aca se abre la conexion y se ejecuta el SP de login
            int resultado = (int)cmd.Parameters["@resultado"].Value;
            //ConexionSQLS.CierraConexion();


                    return resultado;

        }


        catch (SqlException ex)
        {
            Console.WriteLine("SQL Error" + ex.Message.ToString());
            return 0;
        }
            
          


        }

    }
}


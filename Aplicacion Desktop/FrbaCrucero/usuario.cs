using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;


namespace FrbaCrucero
{
    class usuario
    {
        public string nombreUsuario {set ; get; }
        public string passUsuario { set; get; }
        char tipo { set; get; }
        int estado { set; get; } 
        int intentos {set ; get; } 
        List<Rol> Roles = new List<Rol>();
        //private string usuario1;
        //private string pass;

        public usuario(string usuario1, string pass)
        {
            // TODO: Complete member initialization
            this.nombreUsuario = usuario1;
            this.passUsuario = pass;
        }

        public usuario()
        {
            // TODO: Complete member initialization
        }
        public string logueate()
        {

            try
            {

                SqlCommand cmd = new SqlCommand("ICE_CUBES.SP_INGRESAR_USUARIO", ConexionSQLS.getConeccion());
                cmd.CommandType = CommandType.StoredProcedure;
                // instancio parametro de salida
                SqlParameter VariableRetorno = new SqlParameter("@resultado", SqlDbType.Int);
                VariableRetorno.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(VariableRetorno);
                cmd.Parameters.Add(new SqlParameter("@usuario", this.nombreUsuario));
                cmd.Parameters.Add(new SqlParameter("@password", this.passUsuario));
                cmd.ExecuteNonQuery(); // aca se abre la conexion y se ejecuta el SP de login
                int resultado = (int)cmd.Parameters["@resultado"].Value;

                switch (resultado)
                {
                    case 0:
                        return ("USUARIO INHABILITADO.");

                    case 1:
                        //this.habilitarSeleccionDeRoles(username);
                        //this.Close();
                        //usuario unUsuarioVista = new usuario(usuario, pass);

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
                string errorsql = "SQL Error" + ex.Message.ToString();
                return (errorsql);

            }

        }

    }
}

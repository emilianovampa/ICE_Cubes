using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace FrbaCrucero
{
   public class usuario
    {
        public string nombreUsuario {set ; get; }
        public string passUsuario { set; get; }
        public char tipo { set; get; }
       public  int estado { set; get; } 
        public int intentos {set ; get; }
        public Rol usuarioRol {set ; get; }
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
                SqlConnection conexion = ConexionSQLS.getConeccion();
                SqlCommand cmd = new SqlCommand("ICE_CUBES.SP_INGRESAR_USUARIO", conexion);
                cmd.CommandType = CommandType.StoredProcedure;
                // instancio parametro de salida
                SqlParameter VariableRetorno = new SqlParameter("@resultado", SqlDbType.Int);
                VariableRetorno.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(VariableRetorno);
                cmd.Parameters.Add(new SqlParameter("@usuario", this.nombreUsuario));
                cmd.Parameters.Add(new SqlParameter("@password", this.passUsuario));
                conexion.Open();
                cmd.ExecuteNonQuery(); // aca se abre la conexion y se ejecuta el SP de login
                int resultado = (int)cmd.Parameters["@resultado"].Value;
                conexion.Close();
                switch (resultado)
                {
                    case 0:
                        return ("USUARIO INHABILITADO.");

                    case 1:

                        this.obtenerRol();

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
            //finally
            //{

            //}

        }

        private void obtenerRol()
        {
         
             //Rol rol = null;
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT USER_ROL FROM ICE_CUBES.USUARIO WHERE USERID = @usuario", conexion);
                consulta.Parameters.AddWithValue("@usuario", this.nombreUsuario);
                conexion.Open();
                Int32 cod_rol = Convert.ToInt32(consulta.ExecuteScalar());

                SqlCommand consulta2 = new SqlCommand("SELECT ROL_ID,ROL_DESCRIPCION,ROL_ESTADO FROM ICE_CUBES.ROL WHERE ROL_ID=@codRol", conexion);
                consulta2.Parameters.AddWithValue("@codRol", cod_rol);
                SqlDataReader rolesResultados = consulta2.ExecuteReader();

                while (rolesResultados.Read())
                {
                    this.usuarioRol = new Rol(rolesResultados.GetDecimal(0), rolesResultados.GetBoolean(2), rolesResultados.GetString(1));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            //return rol;
        }

        //}



        //public  getFuncionalidades()
        //{
        //    return this.usuarioRol.funcionalidades;
        //}
    }

    }
//}

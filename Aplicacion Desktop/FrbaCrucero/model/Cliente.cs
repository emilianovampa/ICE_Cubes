using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FrbaCrucero.model
{
   public class Cliente
    {
       [System.ComponentModel.DisplayName("idCliente")]
        public decimal id { get; set; }
       [System.ComponentModel.DisplayName("nombre")]
       public string nombre { get; set; }
       [System.ComponentModel.DisplayName("apellido")]
       public string apellido { get; set; }
       [System.ComponentModel.DisplayName("dni")]
       public decimal dni { get; set; }
       [System.ComponentModel.DisplayName("direccion")]
       public string direccion { get; set; }
       [System.ComponentModel.DisplayName("telefono")]
       public int telefono { get; set; }
       [System.ComponentModel.DisplayName("mail")]
       public string mail { get; set; }
       [System.ComponentModel.DisplayName("nacimiento")]
       public DateTime fechaNacimiento { get; set; }
    
       public Boolean tieneNacimiento { get; set; }

        public Cliente(decimal p1, string p2, string p3, decimal dni, string p4, int p5, string p6, DateTime dateTime, bool p7)
        {
            // TODO: Complete member initialization
            this.id = p1;
            this.nombre = p2;
            this.apellido = p3;
            this.dni = dni;
            this.direccion = p4;
            this.telefono = p5;
            this.mail = p6;
            this.fechaNacimiento = dateTime;
            this.tieneNacimiento = p7;
        }
        public static List<Cliente> buscarClientePorDNI(decimal dni)
        {
            List<Cliente> clientes = new List<Cliente>();

            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand consulta = new SqlCommand("SELECT CLIE_ID, CLIE_NOMBRE, CLIE_APELLIDO, CLI_DIR, CLI_TELEFONO, CLI_MAIL, CLI_FECHA_NAC FROM ice_cubes.Cliente WHERE CLIE_DNI = @dni", conexion);
                consulta.Parameters.AddWithValue("@dni", dni);
                conexion.Open();
                SqlDataReader result = consulta.ExecuteReader();
                while (result.Read())
                {
                    clientes.Add(new Cliente(result.GetDecimal(0), result.GetString(1), result.GetString(2), dni, result.GetString(3), result.GetInt32(4), result.GetString(5), result.GetDateTime(6), result.GetValue(6) == DBNull.Value));
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
            return clientes;
        }

        public bool validarDisponibilidad(DateTime? fecha_inicio, DateTime? fecha_fin)
        {
            Boolean resultado = false;
            SqlParameter VariableRetorno = new SqlParameter("@resultado", SqlDbType.Int);
            VariableRetorno.Direction = ParameterDirection.Output;

            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand consulta = new SqlCommand("ice_cubes.sp_clienteViajaDurante", conexion);
                consulta.CommandType = CommandType.StoredProcedure;
                consulta.Parameters.AddWithValue("@inicio", fecha_inicio);
                consulta.Parameters.AddWithValue("@fin", fecha_fin);
                consulta.Parameters.AddWithValue("@cod_cliente", this.id);
                conexion.Open();
                SqlDataReader result = consulta.ExecuteReader();
                resultado = !result.Read();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
            return resultado;
        }

        //internal bool validarDisponibilidad(DateTime? nullable1, DateTime? nullable2)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaCrucero.model{
    public class Servicio
    {
        [System.ComponentModel.DisplayName("Identificador")]
        public int idServicio { get; set; }
        [System.ComponentModel.DisplayName("Nombre")]
        public String nombre { get; set; }

        public Servicio(int idServicio, String nombre)
        {
            this.idServicio = idServicio;
            this.nombre = nombre;
        }
        public static List<Servicio> getServicio()
        {
            List<Servicio> servicios = new List<Servicio>();
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {   
                String select = "SELECT SERV_ID, SERV_NOMBRE" 
                              + "FROM ICE_CUBES.SERVICIO "
                              + " ORDER BY 2";           
                SqlCommand consulta = new SqlCommand(select.ToString(), conexion);
                conexion.Open();
                SqlDataReader servicioSql = consulta.ExecuteReader();
                while (servicioSql.Read())
                {
                    servicios.Add(new Servicio(servicioSql.GetFieldValue<int>(0),
                                                    servicioSql.GetString(1)));
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
            return servicios;
        }
    };
}

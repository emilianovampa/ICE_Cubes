using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FrbaCrucero;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace FrbaCrucero.model
{
    public class Puerto
    {
        public override string ToString()
        {
            return nombre.ToString();
        }
        [System.ComponentModel.DisplayName("Identificador")]
        public decimal idPuerto { get; set; }
        [System.ComponentModel.DisplayName("Nombre")]
        public String nombre { get; set; }
        public Boolean activo;
        public Puerto(int id, String nombre, Boolean estado)
        {
            this.idPuerto = id;
            this.nombre = nombre;
            this.activo = estado;
        }

        public Puerto(int id)
        {
            this.idPuerto = id;
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                SqlCommand select = new SqlCommand("SELECT [PUERTO_ID],[PUERTO_NOMBRE],[PUERTO_ESTADO] FROM ice_cubes.PUERTO WHERE PUERTO_ID = '" + id.ToString() + "'", conexion);
                conexion.Open();
                SqlDataReader sql_puerto = select.ExecuteReader();
                sql_puerto.Read();
                this.nombre = sql_puerto.GetString(1);
                this.activo = sql_puerto.GetBoolean(2);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexion.Close();
            }
        }

        public static List<Puerto> getPuertosActivos(String nombreAFiltrar)
        {
            List<Puerto> listadoDePuertos = new List<Puerto>();
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {   
                String select = "SELECT PUERTO_ID, PUERTO_NOMBRE, PUERTO_ESTADO " 
                              + "FROM ICE_CUBES.PUERTO WHERE PUERTO_ESTADO = 1"
                              + " AND PUERTO_NOMBRE LIKE '%" + nombreAFiltrar.ToString() + "%'"
                              + " ORDER BY 2";
                
                SqlCommand consulta = new SqlCommand(select.ToString(), conexion);
                conexion.Open();
                SqlDataReader puertos = consulta.ExecuteReader();
                while (puertos.Read())
                {
                    listadoDePuertos.Add(new Puerto(puertos.GetFieldValue<int>(0),
                                                    puertos.GetString(1),
                                                    puertos.GetBoolean(2)));
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
            return listadoDePuertos;
        }
        public void eliminar()
        {
            this.activo = false;
            /* Aca agregar la logica correspondiente de eliminar*/
        }
    }
}

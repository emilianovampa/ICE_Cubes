using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FrbaCrucero.model
{
    class Viaje
    {
//        [System.ComponentModel.DisplayName("Fecha de Inicio")]
        public Nullable<DateTime> fechaInicio ;

       public Nullable<DateTime> fechaFin ;

//        [System.ComponentModel.DisplayName("Crucero")]
        public Crucero crucero;

//        [System.ComponentModel.DisplayName("Recorrido")]
        public Recorrido recorrido;

        public Viaje(Crucero crucero, Recorrido recorrido, Nullable<DateTime> fechaInicio, Nullable<DateTime> fechaFin)
        {
            this.crucero = crucero;
            this.recorrido = recorrido;
            this.fechaInicio = fechaInicio;
            this.fechaFin = fechaFin;
        }


        public static List<Viaje> getViajesActvos(DateTime fechaDesde, DateTime FechaHasta, string POrigen, string Pdestino)
        {
            List<Viaje> listadoViaje = new List<Viaje>();
            SqlConnection conexion = ConexionSQLS.getConeccion();
            try
            {
                String select = "SELECT * "
                              + "FROM ICE_CUBES.OPERACION WHERE OPER_ESTADO = 1"
                              //+ " AND OPER_RESERVA_ID =" + numeroReserva.ToString()
                              + " ORDER BY 2";

                SqlCommand consulta = new SqlCommand(select.ToString(), conexion);
                conexion.Open();
                SqlDataReader reservas = consulta.ExecuteReader();
                while (reservas.Read())
                {
                    //listadoViaje.Add(new Reserva(reservas.GetInt32(0),
                    //                                reservas.GetDecimal(1),
                    //                                reservas.GetDateTime(2),
                    //                                reservas.GetDecimal(3),
                    //                                reservas.GetDateTime(4),
                    //                                reservas.GetDecimal(5),
                    //                                reservas.GetDecimal(6),
                    //                                reservas.GetInt32(7),
                    //                                reservas.GetInt32(8),
                    //                                reservas.GetBoolean(9)
                    //                                ));
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
            return listadoViaje;
        }
    }
}
